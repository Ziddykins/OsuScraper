Imports System.Data.SQLite
Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports System.Text.RegularExpressions

Module mdlBeatmaps

    Public Enum GameModes
        Osu
        Taiko
        CatchTheBeat
        Mania
    End Enum

    Public Enum GameSingleCategories
        Ranked
        Qualified
        Loved
        Favorites
        Pending
        Wip
        Graveyard
        Leaderboard
        Mine
    End Enum

    Public Enum GamePackCategories
        Standard
        Featured
        Tournament
        Loved
        Chart
        Theme
        Artist
    End Enum

    Public Enum GameType
        Packs
        Singles
    End Enum

    Public Sub ProcessBeatmaps(filePath As String, all As Boolean)
        Dim extractionFolder As String = FrmMain.settings.GetValue("Paths", "TempFolder")
        Dim downloadFolder As String = FrmMain.settings.GetValue("Paths", "DownloadFolder")
        Dim osuFolder As String = FrmMain.settings.GetValue("Paths", "OsuFolder")

        If Not Directory.Exists(extractionFolder) Then
            Directory.CreateDirectory(extractionFolder)
        End If

        If all = True Then
            For Each file In Directory.GetFiles(downloadFolder)
                If file.Contains(".osz") Then
                    Dim fileSplit = file.Split("\")(4)
                    extractionFolder = Path.Combine(extractionFolder, fileSplit)

                    If Not Directory.Exists(extractionFolder) Then
                        Directory.CreateDirectory(extractionFolder)
                    End If

                    ZipFile.ExtractToDirectory(file, extractionFolder, True)
                    MoveBeatmaps(extractionFolder)
                End If
            Next
        Else
            ZipFile.ExtractToDirectory(filePath, extractionFolder)
            MoveBeatmaps(extractionFolder)
        End If
    End Sub

    Private Sub MoveBeatmaps(extractionFolder As String)
        Dim osuExtractedFiles = New DirectoryInfo(extractionFolder).GetFiles()
        Dim osuFolder As String = FrmMain.settings.GetValue("Paths", "OsuFolder")

        FrmMain.log.Information($"Moving {osuExtractedFiles.Length} processed files to osu! folder.")

        For Each curFile In osuExtractedFiles
            Dim fileHash = mdlCommonUse.GetSha256Hash(curFile.FullName)
            Dim hashParent As String = fileHash.Substring(0, 1).ToLower()
            Dim hashChild As String = fileHash.Substring(0, 2).ToLower()
            Dim finalFileName As String

            If Not Directory.Exists(Path.Combine(osuFolder, "files", hashParent)) Then
                Directory.CreateDirectory(Path.Combine(osuFolder, "files", hashParent))
            End If

            If Not Directory.Exists(Path.Combine(osuFolder, "files", hashParent, hashChild)) Then
                Directory.CreateDirectory(Path.Combine(osuFolder, "files", hashParent, hashChild))
            End If

            finalFileName = Path.Combine(osuFolder, "files", hashParent, hashChild, fileHash.ToLower())

            If Not File.Exists(finalFileName) Then
                curFile.MoveTo(finalFileName)
            End If
        Next
    End Sub

    Public Sub PullPacks()
        Dim databaseFile As String = FrmMain.settings.GetValue("Database", "DatabaseFile")
        Dim types As New List(Of String)
        Dim response As HttpResponseMessage
        Dim content As String
        Dim lines() As String
        Dim dataSource As String
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim count As Integer

        dataSource = $"Datasource={databaseFile};"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()
        conn.Open()

        For Each cb As CheckBox In FrmMain.tpPacks.Controls
            If cb.Checked = True Then
                types.Add(cb.Name)
            End If
        Next

        count = types.Count()

        FrmMain.prgPrimaryTask.Maximum = count
        FrmMain.prgPrimaryTask.Value = 1

        For Each selected As String In types
            FrmMain.prgPrimaryTask.Increment(1)
            Dim type As String = selected.Split("Pack")(1)

            If type = "Spotlight" Then
                type = "Chart"
            End If

            response = HttpGet($"https://osu.ppy.sh/beatmaps/packs?type={type.ToLower()}")
            content = response.Content.ReadAsStringAsync.Result.ToString()

            content = Regex.Replace(content, "(?:[\r\n]+|\s{2,})", " ")
            lines = content.Split($"class={Chr(34)}beatmap-pack js-beatmap-pack js-accordion__item")

            FrmMain.prgSecondaryTask.Maximum = lines.Length
            FrmMain.prgSecondaryTask.Value = 1

            For Each line As String In lines
                FrmMain.prgSecondaryTask.Increment(1)
                Dim matched As Match = Regex.Match(line,
                                                   $"{Chr(34)} data-pack-tag={Chr(34)}(.*?){Chr(34)}.*?href={Chr(34) _
                                                      }(.*?){Chr(34)}.*?pack__name{Chr(34)}>(.*?)<\/div>.*?__date{ _
                                                      Chr(34)}>(.*?)<\/span>.*?__author--bold{Chr(34)}>(.*?)<\/span>")
                If matched.Success Then
                    Dim packTitle As String = matched.Groups(3).Value
                    Dim packAuthor As String = matched.Groups(4).Value
                    Dim packDate As String = matched.Groups(2).Value
                    Dim packCode As String = matched.Groups(1).Value
                    Dim packCategory As Integer = StringToEnum(Of GamePackCategories)(type)
                    Dim packUrl As String = $"https://osu.ppy.sh/beatmaps/packs/{packCode}"
                    Dim packMode As GameModes
                    Dim modeMatch As Match = Regex.Match(packTitle, "osu!(mania|taiko|catch)")

                    If modeMatch.Success Then
                        Dim modeMatched = modeMatch.Groups(1).Value

                        If modeMatched = "catch" Then
                            modeMatched = "CatchTheBeat"
                        End If

                        packMode = StringToEnum(Of GameModes)(FirstToUpper(modeMatched))
                    Else
                        packMode = GameModes.Osu
                    End If

                    Dim columns() As String =
                            {"pack_title", "pack_author", "pack_date", "pack_code", "pack_type", "pack_url",
                             "pack_category", "pack_mode"}
                    Dim values() As String =
                            {packTitle, packAuthor, packDate, packCode, CStr(GameType.Packs), packUrl,
                             CStr(packCategory), CStr(packMode)}

                    InsertIntoDatabase(databaseFile, "tbl_packs", columns, values)
                End If
            Next
        Next
    End Sub

End Module