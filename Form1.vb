Imports System.ComponentModel
Imports System.Net.Http
Imports System.Text.RegularExpressions



Public Class frmMain
    Public frmListings As Form
    Public frmLoginForm As Form
    Public frmHelp As Form

    Public Sub New()
        InitializeComponent()

        Dim version As String = Application.ProductVersion.Split("+")(0)
        Dim progName As String = Application.ProductName

        frmHelp = New frmHelp
        frmHelp.Show()
        frmHelp.Visible = False

        frmHelp.Text = $"Help - {progName} v{version}"
        Text = $"Help - {progName} v{version}"

        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim xsrf_regex = "[a-zA-Z0-9]{40}"
        Dim osu_session_regex = "[a-zA-Z0-9]{100,}.*?%3D"
        Dim rgx_check As New Regex(osu_session_regex)

        If rgx_check.IsMatch(txtSessionToken.Text) Then
            rgx_check = New Regex(xsrf_regex)
            If rgx_check.IsMatch(txtXSRFToken.Text) Then
                ' Do listings pull
            Else
                MessageBox.Show("XSRF Token does not appear to be valid - Should be in the format: XSRF-TOKEN=" & Chr(34) & StrDup(40, "X").ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Osu Session Token does not appear to be valid - Should be in the format: osu_session=" & Chr(34) & StrDup(300, "X").ToString & "%3D", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAutoFill_Click(sender As Object, e As EventArgs) Handles btnAutoFill.Click
        Dim default_browser As BrowserType
        Dim cookies As Dictionary(Of String, String)
        Dim response As HttpResponseMessage

        default_browser = GetDefaultBrowser()
        cookies = GetCookieJar("'%ppy.sh%'", default_browser)

        If cookies IsNot Nothing Then
            For Each item As KeyValuePair(Of String, String) In cookies
                If item.Key = "XSRF-TOKEN" Then
                    txtXSRFToken.Text = item.Value
                Else
                    txtSessionToken.Text = item.Value
                End If
            Next
        Else
            MessageBox.Show(
                    "Failed to extract and/or decrypt cookies from database - " &
                    "Please use the 'Login' button instead, or manually supply them." & vbCrLf & vbCrLf &
                    "These cookies can be found in your browser after logging into your Osu! account." & vbCrLf & vbCrLf &
                    "Chrome: F12 -> Storage -> Cookies" & vbCrLf &
                    "Firefox: F12 -> Storage -> Cookies" & vbCrLf &
                    "Opera: CTRL + SHIFT + J -> Application -> Cookies",
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If

        response = HTTPGet("https://osu.ppy.sh/beatmaps/packs")
        PullPacks()

    End Sub

    Private Sub txtSessionToken_TextChanged(sender As Object, e As EventArgs) Handles txtSessionToken.TextChanged
        Dim session_token As Match

        session_token = Regex.Match(
            txtSessionToken.Text,
            Chr(34) & "?(?:osu_session[:=])?" & Chr(34) & "?([a-zA-Z0-9]{100,}%3D)" & Chr(34) & "?"
        )

        If session_token.Success Then
            txtSessionToken.Text = session_token.Groups(1).Value.ToString()
            txtSessionToken.ForeColor = Color.DarkGreen
        Else
            txtSessionToken.ForeColor = Color.IndianRed
        End If
    End Sub

    Private Sub txtXSRFToken_TextChanged(sender As Object, e As EventArgs) Handles txtXSRFToken.TextChanged
        Dim xsrf_token As Match

        xsrf_token = Regex.Match(
            txtXSRFToken.Text,
            Chr(34) & "?(?:XSRF-TOKEN[:=])?" & Chr(34) & "?([a-zA-Z0-9]{40})" & Chr(34) & "?"
        )

        If xsrf_token.Success Then
            txtXSRFToken.Text = xsrf_token.Groups(1).Value.ToString()
            txtXSRFToken.ForeColor = Color.DarkGreen
        Else
            txtXSRFToken.ForeColor = Color.IndianRed
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim default_browser As BrowserType = GetDefaultBrowser()
        Dim arrCategories As String() = [Enum].GetNames(GetType(CommonUse.GamePackCategories))
        Dim arrSingles As String() = [Enum].GetNames(GetType(CommonUse.GameSingleCategories))
        Dim arrModes As String() = [Enum].GetNames(GetType(CommonUse.GameModes))

        MaximizeBox = False

        For Each control As CheckBox In tpPacks.Controls
            If StrComp(control.Name, "chkCatAny") <> 0 Then
                AddHandler control.Click, AddressOf uncheckAllCategories
            End If
        Next

        If default_browser = BrowserType.Chrome Then
            tslBrowser.Image = My.Resources.icons8_chrome_24
        ElseIf default_browser = BrowserType.Firefox Then
            tslBrowser.Image = My.Resources.icons8_firefox_24
        ElseIf default_browser = BrowserType.MSEdge Then
            tslBrowser.Image = My.Resources.icons8_edge_24
        End If

        For Each category As String In arrCategories
            Dim categoryEnum = StringToEnum(Of CommonUse.GamePackCategories)(category)

            tvListings.Nodes(0).Nodes.Add(category.ToString())
            tvListings.Nodes(1).Nodes.Add(category.ToString())
            For Each mode As String In arrModes
                Dim currentEnum = StringToEnum(Of CommonUse.GameModes)(mode)
                tvListings.Nodes(0).Nodes(categoryEnum).Nodes.Add(mode)
            Next
        Next

        For Each category As String In arrSingles
            Dim categoryEnum = StringToEnum(Of CommonUse.GameSingleCategories)(category)

            For Each mode As String In arrModes
                Dim currentEnum = StringToEnum(Of CommonUse.GameModes)(mode)
                tvListings.Nodes(0).Nodes(categoryEnum).Nodes.Add(mode)
            Next
        Next
        
        LoadCacheFile()
    End Sub

    Private Sub uncheckAllCategories(sender As Object, e As EventArgs)
        If chkPackAll.Checked = True Then
            chkPackAll.Checked = False
        End If
    End Sub

    Private Sub tbBatchSize_Scroll(sender As Object, e As EventArgs) Handles tbBatchSize.Scroll
        lblBatchSizeValue.Text = tbBatchSize.Value.ToString()
    End Sub

    Private Sub tbForkValue_Scroll(sender As Object, e As EventArgs) Handles tbForkValue.Scroll
        lblForkValue.Text = tbForkValue.Value.ToString()
    End Sub

    Private Sub tbSleepInterval_Scroll(sender As Object, e As EventArgs) Handles tbSleepInterval.Scroll
        lblSleepInterval.Text = tbSleepInterval.Value.ToString
    End Sub

    Private Sub tsmHelp_Click(sender As Object, e As EventArgs) Handles tsmHelp.Click
        If frmHelp.IsDisposed = False Then
            frmHelp.Visible = True
        Else
            frmHelp = New frmHelp
            frmHelp.Show()
            frmHelp.Visible = True
        End If
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If frmHelp IsNot Nothing Then
            frmHelp.Dispose
        End If
    End Sub

    Private Function HTTPGet(url As String) As HttpResponseMessage
        Dim client As HttpClient = New HttpClient()
        Dim request As HttpRequestMessage = New HttpRequestMessage(HttpMethod.[Get], url)

        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0")
        request.Headers.Add("Accept", "text/html, application/xhtml+xml")
        request.Headers.Add("Accept-Language", "en-CA,en-US;q=0.7,en;q=0.3")
        request.Headers.Add("Connection", "keep-alive")
        request.Headers.Add("Referer", "https://osu.ppy.sh/")
        request.Headers.Add("Cookie", $"XSRF-TOKEN={txtXSRFToken.Text}; osu_session={txtSessionToken.Text};")
        request.Headers.Add("Sec-Fetch-Dest", "empty")
        request.Headers.Add("Sec-Fetch-Mode", "cors")
        request.Headers.Add("Sec-Fetch-Site", "same-origin")

        Dim response As HttpResponseMessage = client.SendAsync(request).Result
        response.EnsureSuccessStatusCode()

        Return response
    End Function

    Private Sub PullPacks()
        Dim type As String = Nothing
        Dim response As HttpResponseMessage
        Dim content As String
        Dim lines() As String

        If chkPackStandard.Checked = True
            type = "standard"
        End If

        response = HTTPGet($"https://osu.ppy.sh/beatmaps/packs?type={type}")
        content = response.Content.ReadAsStringAsync.Result.ToString()

        'content = content.Replace(vbCr, "").Replace(vbLf, "").Replace(vbCrLf, "")
        content = Regex.Replace(content, "(?:[\r\n]+|\s{2,})", " ")
        lines = content.Split("class=" & Chr(34) & "beatmap-pack js-beatmap-pack js-accordion__item")

        For Each line As String In lines
            Dim matched As Match = Regex.Match(line, Chr(34) & " data-pack-tag=" & Chr(34) & "(.*?)" & Chr(34) & ".*?href=" & Chr(34) & "(.*?)" & Chr(34) & ".*?pack__name" & Chr(34) & ">(.*?)<\/div>.*?__date" & Chr(34) & ">(.*?)<\/span>.*?__author--bold" & Chr(34) & ">(.*?)<\/span>")
            Dim pack_title As String = matched.Groups(3).Value
            Dim pack_author As String = matched.Groups(4).Value
            Dim pack_date As String = matched.Groups(2).Value
            Dim pack_code As String = matched.Groups(1).Value

            If pack_title IsNot Nothing Then
                Dim pack As ListViewItem = New ListViewItem(pack_title)
                tvListings.Nodes(0).Nodes(GamePackCategories.Standard).Nodes.Add(pack_title)
            End If
        Next
    End Sub

    Private Sub chkPackAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkPackAll.CheckedChanged
        For Each control As CheckBox In tpPacks.Controls
            If Not control.Name = "chkPackAll" Then
                control.Checked = False
            End IF
        Next
        chkPackAll.Checked = True
    End Sub

    Private Sub cbFilter_Click(sender As Object, e As EventArgs) Handles cbFilter.Click
        cbFilter.Text = ""
    End Sub

    Private Sub cbFilter_LostFocus(sender As Object, e As EventArgs) Handles cbFilter.LostFocus
        If cbFilter.Text = "" Then
            cbFilter.Text = "<Filter ... >"
        End If
    End Sub

End Class
