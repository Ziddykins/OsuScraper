Imports System.Diagnostics.Eventing.Reader
Imports System.Dynamic
Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports Windows.Management.Deployment


Module CommonUse


    Public Enum BrowserType
        MsEdge
        Chrome
        Firefox
        Other
    End Enum

    Public Enum OsuSession
        Valid
        Invalid
    End Enum

    Public Sub LoadCacheFile()
        Dim cacheFile As String = ".packs_cache"
        Dim cacheFilepath = Path.Combine(My.Application.Info.DirectoryPath, cacheFile)
        Dim cacheContents As String() = Nothing

        If File.Exists(cacheFilepath) Then
            cacheContents = File.ReadAllLines(cacheFilepath)
            FrmMain.tslCacheValue.ForeColor = Color.Green
            FrmMain.tslCacheValue.Image = My.Resources.icons8_cache_24_green
        End If

        For Each pack As String In cacheContents
            Dim packData As String() = pack.Split(":::")
            Dim packCategory As String = packData(0)
            Dim packMode As String = packData(1)
            Dim packUrl As String = packData(2)
            Dim packName As String = packData(3)

            Dim modeEnum As GameModes = StringToEnum(Of GameModes)(packMode)
            Dim categoryEnum As GamePackCategories = StringToEnum(Of GamePackCategories)(packCategory)

            Try
                'FrmMain.tvListings.Nodes(0).Nodes(modeEnum).Nodes(categoryEnum).Nodes.Add(packName)
            Catch ex As Exception
                FrmMain.log.Information($"Error adding {packName} to the treeview. {ex.Message}")
            End Try
        Next
    End Sub

    Public Function GetDefaultBrowser() As BrowserType
        Dim browserRegex As Match
        Dim defaultBrowser As String = "None"
        Dim browserCheckRegkey As String = My.Computer.Registry.GetValue(
            "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice",
            "ProgId",
            Nothing
        ).ToString()

        browserRegex = Regex.Match(browserCheckRegkey, "(ChromeHTML|FirefoxURL|MSEdge).*?")

        If browserRegex.Success Then
            defaultBrowser = browserRegex.Groups(1).Value
        End If

        If defaultBrowser = "ChromeHTML" Then
            Return BrowserType.Chrome
        ElseIf defaultBrowser = "FirefoxURL" Then
            Return BrowserType.Firefox
        ElseIf defaultBrowser = "MSEdge" Then
            Return BrowserType.MsEdge
        Else
            Return BrowserType.Other
        End If
    End Function

    Public Sub KillOpenBrowser(ByRef browserType As BrowserType)
        Dim browserName As String = ""
        Dim processes() As Process

        Select Case browserType
            Case BrowserType.Chrome
                browserName = "chrome"
            Case BrowserType.Firefox
                browserName = "firefox"
            Case BrowserType.MsEdge
                browserName = "msedge"
            Case BrowserType.Other

        End Select

        processes = Process.GetProcessesByName(browserName)

        If processes.Length() > 0 Then
            Dim userAnswer As DialogResult = MessageBox.Show(
                $"Found an open {browserName} process. Would you like to close it?",
                $"Found Open Browser",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )
            If userAnswer = DialogResult.Yes Then
                For Each process As Process In processes
                    process.Kill()
                Next
            End If
        End If
    End Sub

    Public Function VerifySession() As OsuSession
        Dim response As HttpResponseMessage
        Dim responseText() As String
        Dim checkString As Match
        Dim sourceLines As Integer
        
        response = HttpGet("https://osu.ppy.sh/beatmapsets")
        responseText = response.Content.ReadAsStringAsync().Result.ToString().Split(vbLf)
        sourceLines = responseText.Length()
        
        FrmMain.prgPrimaryTask.Value = 0
        FrmMain.prgPrimaryTask.Maximum = sourceLines

        For Each line As String In responseText
            FrmMain.prgPrimaryTask.Increment(1)
            
            checkString = Regex.Match(line, ".*?click to sign in.*?")
            
            If checkString.Success Then
                FrmMain.prgPrimaryTask.Value = 0
                Return OsuSession.Invalid
            End If
        Next
        
        FrmMain.prgPrimaryTask.Value = 0
        Return OsuSession.Valid
    End Function

    Public Function HttpGet(url As String) As HttpResponseMessage
        Dim client As HttpClient = New HttpClient()
        Dim request As HttpRequestMessage = New HttpRequestMessage(HttpMethod.[Get], url)

        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0")
        request.Headers.Add("Accept", "text/html, application/xhtml+xml")
        request.Headers.Add("Accept-Language", "en-CA,en-US;q=0.7,en;q=0.3")
        request.Headers.Add("Connection", "keep-alive")
        request.Headers.Add("Referer", "https://osu.ppy.sh/")
        request.Headers.Add("Cookie", $"XSRF-TOKEN={FrmMain.txtXSRFToken.Text}; osu_session={FrmMain.txtSessionToken.Text};")
        request.Headers.Add("Sec-Fetch-Dest", "empty")
        request.Headers.Add("Sec-Fetch-Mode", "cors")
        request.Headers.Add("Sec-Fetch-Site", "same-origin")

        Dim response As HttpResponseMessage = client.SendAsync(request).Result
        response.EnsureSuccessStatusCode()

        Return response
    End Function

    Public Function StringToEnum(Of T)(value As String) As T
        Return DirectCast([Enum].Parse(GetType(T), value), T)
    End Function

    Private Function GetSha256Hash(filePath As String) As String
        Dim sha256 As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
        Dim stream As FileStream = File.OpenRead(filePath)
        Dim hash As Byte() = sha256.ComputeHash(stream)
        stream.Close()

        Return BitConverter.ToString(hash).Replace("-", String.Empty)
    End Function

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

        For each curFile In osuExtractedFiles
            Dim fileHash = GetSha256Hash(curFile.FullName)
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
End Module