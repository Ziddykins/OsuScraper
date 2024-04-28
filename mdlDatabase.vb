Imports System.Data.SQLite
Imports System.IO

Module OsuDatabase

    Public Sub InsertIntoDatabase(databaseFile As String, tableName As String, columns As String(), values As String())
        Dim columnsString As String = String.Join(", ", columns)
        Dim finalCommand As String = Nothing
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String

        dataSource = $"Data Source={databaseFile};"
        conn = New SQLiteConnection(dataSource)

        finalCommand = $"REPLACE INTO {tableName} ("
        finalCommand &= columnsString
        finalCommand &= ") VALUES ("
        finalCommand &= "@" & String.Join(", @", columns)
        finalCommand &= ");"
        cmd = New SQLiteCommand(finalCommand, conn)

        For i = 0 To columns.Length - 1
            If Integer.TryParse(CStr(values(i)), Nothing) Then
                cmd.Parameters.Add("@" & columns(i), DbType.Int32).Value = values(i)
                FrmMain.log.Verbose($"Adding {columns(i)} as Integer, has value of {values(i)}")
            Else
                cmd.Parameters.Add("@" & columns(i), DbType.String).Value = values(i)
                FrmMain.log.Verbose($"Adding {columns(i)} as String, has value of {values(i)}")
            End If
            FrmMain.log.Verbose($"final string now: {finalCommand}")
        Next

        conn.Open()
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        conn.Close()

    End Sub

    Friend Function GetBeatmapIDFromName(databaseFile As String, tableName As String, beatmapName As String) As Integer
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String
        Dim result = 0

        dataSource = $"Data Source={databaseFile};"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()

        cmd.CommandText = $"SELECT `id` FROM {tableName} WHERE `name` LIKE '%@beatmapName%'"
        cmd.CommandType = CommandType.Text
        cmd.Parameters.AddWithValue("@beatmapName", beatmapName)

        conn.Open()

        Using reader As SQLiteDataReader = cmd.ExecuteReader()
            result = reader.GetInt32(0)
        End Using

        Return result
    End Function

    Friend Function DatabaseToBeatmap(databaseFile As String, tableName As String, beatmapID As Integer) As Beatmap
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String
        Dim result = New Beatmap

        dataSource = $"Data Source={databaseFile};"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()

        cmd.CommandText = $"SELECT * FROM {tableName} WHERE id = {beatmapID}"

        conn.Open()

        Using reader As SQLiteDataReader = cmd.ExecuteReader()
            While reader.Read()

            End While
        End Using

        Return result
    End Function

    Friend Sub CacheFileImport(databaseFile As String, tableName As String)
        Dim cacheFile As String = FrmMain.settings.GetValue("Paths", "CacheFile")
        Dim cacheContents() As String = File.ReadAllLines(cacheFile)
        'https://packs.ppy.sh/S1414%20-%20osu%21%20Beatmap%20Pack%20%231414.zip
        For Each pack As String In cacheContents
            Dim pack_split() As String = pack.Split(":::")
            Dim pack_category As Integer = StringToEnum(Of GamePackCategories)(pack_split(0))
            Dim pack_mode As String = pack_split(1)
            Dim pack_url As String = pack_split(2)
            Dim pack_name As String = pack_split(3)
            Dim pack_code As String = pack_url.Split("/").Last().Split("%20").First()
            Dim pack_zip As String = $"https://packs.ppy.sh/{pack_code}%20-%20{pack_name}.zip"
            Dim pack_downloaded = 0

            Dim columns() As String = {"category", "mode", "url", "name", "code", "zip", "downloaded"}
            Dim values() As String = {CStr(pack_category), pack_mode, pack_url, pack_name, pack_code, pack_zip, CStr(pack_downloaded)}

            FrmMain.log.Information($"Adding {pack_name} to the database")
            InsertIntoDatabase(databaseFile, "tbl_packs", columns, values)
        Next

    End Sub

    Friend Function CountEntries(databaseFile As String, tableName As String) As Integer
        Dim dataSource As String
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand

        dataSource = $"Data Source={databaseFile};"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()
        cmd.CommandText = $"SELECT COUNT(*) FROM {tableName}"

        conn.Open()

        Return CInt(cmd.ExecuteScalar())
    End Function

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

End Module