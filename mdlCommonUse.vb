Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports System.Text.RegularExpressions

Module mdlCommonUse

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

    Public Enum GroupColor
        Color
        Uncolor
    End Enum

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
        Dim userAnswer As DialogResult

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
            If FrmMain.togSkipCheckBrowser.Checked = False Then
                If browserType = BrowserType.MsEdge Then
                    userAnswer = MessageBox.Show(
                        "Found an open Edge process. The program must kill these to continue. Save any work you have in your tabs then click retry.",
                        "Found Open Browser Process",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Exclamation
                    )
                Else
                    userAnswer = MessageBox.Show(
                        $"Found an open {browserName} process. Would you like to close it?",
                        $"Found Open Browser Process",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    )
                End If
            Else
                userAnswer = DialogResult.Yes
            End If

            If userAnswer = DialogResult.Yes Or userAnswer = DialogResult.Retry Then
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

    Public Function GetSha256Hash(filePath As String) As String
        Dim sha256 As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
        Dim stream As FileStream = File.OpenRead(filePath)
        Dim hash As Byte() = sha256.ComputeHash(stream)
        stream.Close()

        Return BitConverter.ToString(hash).Replace("-", String.Empty)
    End Function

    Public Function FirstToUpper(convString As String) As String
        Dim chars() As Char = convString.ToCharArray()
        Dim outString As String = Nothing

        chars(0) = Char.ToUpper(chars(0))
        outString = String.Join("", chars)

        Return outString
    End Function

End Module