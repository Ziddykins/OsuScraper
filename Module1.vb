Imports System.Text.RegularExpressions

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
        Featured
        Tournament
        Project
        Loved
        Spotlights
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

    Public Function LoadCacheFile() As String
        Dim cache_file As String = "cache.txt"
        Dim cache_contents As String = ""

        If IO.File.Exists(cache_file) Then
            cache_contents = IO.File.ReadAllText(cache_file)
        End If

        Return cache_contents
    End Function

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
End Module
