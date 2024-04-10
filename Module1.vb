Imports System.Text.RegularExpressions
Imports System.Net.Http


Module CommonUse
    Public Enum GameModes
        Osu
        Taiko
        CatchTheBeat
        Mania
    End Enum


    Public Enum GameSingleCategories
        Any
        Ranked
        Qualified
        Loved
        Pending
        Graveyard
        Leaderboards
        Favorites
        Mine
        WorkInProgress
    End Enum

    Public Enum GamePackCategories
        Any
        Standard
        Featured
        Tournament
        Project
        Loved
        Spotlight
        Theme
        Artist
        Album 
    End Enum

    Public Enum BrowserType
        MSEdge
        Chrome
        Firefox
        Other
    End Enum

    Public Sub LoadCacheFile()
        Dim cache_file As String = ".packs_cache"
        Dim cache_filepath = My.Application.Info.DirectoryPath & $"\{cache_file}"
        Dim cache_contents As String() = Nothing

        If IO.File.Exists(cache_filepath) Then
            cache_contents = IO.File.ReadAllText(cache_filepath).Split(vbCrLf)
            frmMain.tslCacheValue.ForeColor = Color.Green
        End If

        For Each pack As String In cache_contents
            Dim packData As String()
            packData = pack.Split(":::")

            Dim packCategory As String = packData(0)
            Dim packMode As String = packData(1)
            Dim packURL As String = packData(2)
            Dim packName As String = packData(3)

            Dim modeEnum As GameModes = StringToEnum(Of GameModes)(packMode)
            Dim categoryEnum As GamePackCategories = StringToEnum(Of GamePackCategories)(packCategory)
            Try
                frmMain.tvListings.Nodes(0).Nodes(modeEnum).Nodes(categoryEnum).Nodes.Add(packName)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            
        Next
    End Sub

    Public Function GetDefaultBrowser As BrowserType
        Dim browser_regex As Match
        Dim default_browser As String = "None"
        Dim browser_check_regkey As String = My.Computer.Registry.GetValue(
            "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice",
            "ProgId",
            Nothing
        ).ToString()

        browser_regex = Regex.Match(browser_check_regkey, "(ChromeHTML|FirefoxURL|MSEdge).*?")
        
        If browser_regex.Success Then
            default_browser = browser_regex.Groups(1).Value
        End If

        If default_browser = "ChromeHTML" Then
            Return BrowserType.Chrome
        Else If default_browser = "FirefoxURL" Then
            Return BrowserType.Firefox
        Else If default_browser = "MSEdge" Then
            Return BrowserType.MSEdge
        Else          
            Return BrowserType.Other
        End If
    End Function

    Public Sub KillOpenBrowser(ByRef browser_type As BrowserType)
        Dim browser_name As String = ""
        Dim processes() As Process

        Select Case browser_type
            Case BrowserType.Chrome
                browser_name = "chrome"
            Case BrowserType.Firefox
                browser_name = "firefox"
            Case BrowserType.MSEdge
                browser_name = "msedge"
            Case BrowserType.Other

        End Select

        processes = Process.GetProcessesByName(browser_name)
        
        If processes.Length() > 0 Then
            Dim user_answer As DialogResult = MessageBox.Show(
                "Found an open " & browser_name & " process. Would you like to close it?",
                "Found Open Browser",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )
            If user_answer = DialogResult.Yes Then
                For Each process As Process In processes
                    process.Kill()
                Next
            End If
        End If
    End Sub

    Public Function VerifySession() As Boolean
        Dim response As HttpResponseMessage = HTTPGet("https://osu.ppy.sh/beatmapsets")
        Dim response_text As String = response.Content.ReadAsStringAsync().Result.ToString()
        Dim check_string As Match = Regex.Match(response_text, "Sign in to search")

        If check_string.Success Then
            Return False
        End If

        Return True        
    End Function

    Public Function HTTPGet(url As String) As HttpResponseMessage
        Dim client As HttpClient = New HttpClient()
        Dim request As HttpRequestMessage = New HttpRequestMessage(HttpMethod.[Get], url)

        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0")
        request.Headers.Add("Accept", "text/html, application/xhtml+xml")
        request.Headers.Add("Accept-Language", "en-CA,en-US;q=0.7,en;q=0.3")
        request.Headers.Add("Connection", "keep-alive")
        request.Headers.Add("Referer", "https://osu.ppy.sh/")
        request.Headers.Add("Cookie", $"XSRF-TOKEN={frmMain.txtXSRFToken.Text}; osu_session={frmMain.txtSessionToken.Text};")
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
End Module