Imports System.Dynamic
Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports Windows.Management.Deployment


Module CommonUse
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
        Leaderboards
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

    Public Enum BrowserType
        MsEdge
        Chrome
        Firefox
        Other
    End Enum

    Public Sub LoadCacheFile()
        Dim cacheFile As String = ".packs_cache"
        Dim cacheFilepath = Path.Combine(My.Application.Info.DirectoryPath, cacheFile)
        Dim cacheContents As String() = Nothing

        If File.Exists(cacheFilepath) Then
            cacheContents = File.ReadAllLines(cacheFilepath)
            FrmMain.tslCacheValue.ForeColor = Color.Green
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
                FrmMain.tvListings.Nodes(0).Nodes(modeEnum).Nodes(categoryEnum).Nodes.Add(packName)
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
                "Found an open " & browserName & " process. Would you like to close it?",
                "Found Open Browser",
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

    Public Function VerifySession() As Boolean
        Dim response As HttpResponseMessage = HttpGet("https://osu.ppy.sh/beatmapsets")
        Dim responseText As String = response.Content.ReadAsStringAsync().Result.ToString()
        Dim checkString As Match = Regex.Match(responseText, "Sign in to search", RegexOptions.Multiline)

        If checkString.Success Then
            Return False
        End If

        Return True
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

    Public Function GetSHA256Hash(filePath As String) As String
        Dim sha256 As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
        Dim stream As FileStream = File.OpenRead(filePath)
        Dim hash As Byte() = sha256.ComputeHash(stream)
        stream.Close()

        Return BitConverter.ToString(hash).Replace("-", String.Empty)
    End Function

    Public Sub ProcessBeatmap(filePath As String)
        ZipFile.ExtractToDirectory(filePath, Path.Combine(CStr(Environment.SpecialFolder.Windows), "temp"))
                

    End Sub
End Module