Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text.RegularExpressions
Imports Flurl.Http

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
        Standard
        FeaturedArtist
        Tournament
        ProjectLoved
        Spotlights
        Theme
        ArtistAlbum
    End Enum

    Public Enum BrowserType
        MsEdge
        Chrome
        Firefox
        Other
    End Enum

    Public HttpResponseContent As String = Nothing

    Public Function LoadCacheFile() As String
        Dim cacheFile As String = "cache.txt"
        Dim cacheContents As String = ""

        If IO.File.Exists(cacheFile) Then
            cacheContents = IO.File.ReadAllText(cacheFile)
        End If

        Return cacheContents
    End Function

    Public Function GetDefaultBrowser As BrowserType
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

 '   Public Function WebSubmit(url As String, data As String, method As HttpMethod, authenticated As Boolean) As HttpResponseMessage
 '       Dim client As HttpClient = New HttpClient()
 '       Dim request As HttpRequestMessage = New HttpRequestMessage(method, url)
 '       Dim response As HttpResponseMessage
'
'        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0")'''''
'
'        If method = HttpMethod.Post Then
'            request.Headers.Add("X-CSRF-Token", frmMain.txtXSRFToken.Text)
'            request.Headers.Add("Cookie", $"osu_session={frmMain.txtSessionToken.Text}; XSRF-TOKEN={frmMain.txtXSRFToken.Text};")
'            'request.Headers.Add("Cookie", "XSRF-TOKEN=YHln1tbue96RPqCGX6FpZhljzV3Vwvce9nVNo6bB; osu_session=eyJpdiI6Ikw1Q2tBQ2x4UkZFSDdLZVFxT3o1Rnc9PSIsInZhbHVlIjoiYUhvK0RUK2xobkZQVko0Ujh2cUtBWWJBTkI2K2FVNzVpY3JtM21jNWhuS0xtWGVVSlNuT2ZMUE9GR0o1aHRwVTlRcjZ6b1JnVkw3NWdjZFoxN3JwNDBjUm8vSVRReWViYmV5NEMzaFJlZFhLSzRQTHhBdHUrMmRlQTVuTCs0VWQ3SGFOVW5XSnRHcHVZaWpiblNjRUpnPT0iLCJtYWMiOiIyZWQ1OTg0MDg0MGQ5ZWE1ZjcwNzlmZGJlMjAzOTcyY2I0NTIzNDY3OTRhMWE0YWQ5ZmViMDJlMzhlYjk0MjQ4IiwidGFnIjoiIn0%3D")
'
'
'            request.Content = New StringContent(data)
'            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded; charset=UTF-8")
'        End If''''

        'response = client.Send(request)
        'response.EnsureSuccessStatusCode()
       '

        'Return response
    'End Function

    Public Function WebSubmit(url As String, data As String, method As HttpMethod, authenticated As Boolean) As IFlurlResponse
        Dim lol As String = FrmMain.txtSessionToken.Text
        Dim response = url _
                        .PostUrlEncodedAsync(New With {
                            .Token = {FrmMain.txtXSRFToken},
                            .Username = {frmLoginForm.txtUsernameValue.Text},
                            .Password = {frmLoginForm.txtPasswordValue.Text}
                        })
        Return response.Result
    End Function
End Module
