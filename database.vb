Imports System.Data.SQLite
Imports System.IO

Module database
    
    Friend Sub ReplaceIntoDatabase(databaseFile As String, tableName As String, columns As Object(), values As Object())
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String
        Dim rowsAffected As Integer
        Dim processedColumns As String = Nothing
        Dim processedValues As String = Nothing
        Dim finalCommand As String = Nothing

        For i As Integer = 0 To columns.Length - 1
            Dim col As Object = columns(i)
            Dim val As Object = values(i)
            
            processedColumns &= $"'{col}', "
            
            If Integer.TryParse(CStr(values(i)), Nothing) Then
                processedValues &= $"{val}, "
            Else
                
                processedValues &= $"'{val}', "
            End If
        Next

        processedColumns = processedColumns.Substring(0, processedColumns.Length - 2)
        processedValues = processedValues.Substring(0, processedValues.Length - 2)

        finalCommand = $"REPLACE INTO {tableName} ({processedColumns}) VALUES ({processedValues})"

        dataSource = $"Data Source={databaseFile};"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()
        cmd.CommandText = finalCommand

        FrmMain.log.Information(finalCommand)

        conn.Open()
        
        rowsAffected = cmd.ExecuteNonQuery()
        

        FrmMain.log.Information($"ReplaceIntoDatabase: Rows affected -> {rowsAffected}")
    End Sub

    Friend Function GetFromDatabase(databaseFile As String, beatmapType As GameType, beatmapID As Integer) As Beatmap
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String
        Dim result As Beatmap = Nothing
    
        dataSource = $"Data Source={databaseFile};"
    
        conn = New SQLiteConnection(dataSource)
    
        cmd = conn.CreateCommand()

        'cmd.CommandText = $"SELECT * FROM {tableName} WHERE {columns(0)} = {values(0)}"

        conn.Open()

        Using reader As SQLiteDataReader = cmd.ExecuteReader()
            Dim maxLines As Integer = reader.FieldCount

            While reader.Read()
                For i As Integer = 0 To maxLines - 1
         '           result.Add(reader.GetName(i), reader.GetValue(i))
                Next
            End While
        End Using

        Return result
    End Function

    Friend Function GetBeatmapIDFromName(databaseFile As String, tableName As String, beatmapName As String) As Integer
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String
        Dim result As Integer = 0

        dataSource = $"Data Source={databaseFile};"
        conn = New SQLiteConnection(dataSource)
        cmd = conn.CreateCommand()

        cmd.CommandText = $"SELECT id FROM {tableName} WHERE name LIKE '%{beatmapName}%'"

        conn.Open()

        Using reader As SQLiteDataReader = cmd.ExecuteReader()
            While reader.Read()
                result = reader.GetInt32(0)
            End While
        End Using

        Return result
    End Function

    Friend Function DatabaseToBeatmap(databaseFile As String, tableName As String, beatmapID As Integer) As Beatmap
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim dataSource As String
        Dim result As Beatmap = New Beatmap

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
            Dim pack_downloaded As Integer = 0

            Dim columns() As Object = {"category", "mode", "url", "name", "code", "zip", "downloaded"}
            Dim values() As Object = {pack_category, pack_mode, pack_url, pack_name, pack_code, pack_zip, pack_downloaded}

            
            FrmMain.log.Information($"Adding {pack_name} to the database")
            ReplaceIntoDatabase(databaseFile, "tbl_packs", columns, values)
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

End Module
