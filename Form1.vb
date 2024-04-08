Imports System.ComponentModel
Imports System.Text.RegularExpressions



Public Class frmMain
    Public frmListings As Form
    Public frmLoginForm As Form
    Public frmHelp As Form

    Public Sub New()
        InitializeComponent()

        frmHelp = New frmHelp
        frmHelp.Show()
        frmHelp.Visible = False

        Dim arrCategories As String() = [Enum].GetNames(GetType(CommonUse.GamePackCategories))


        For Each category As String In arrCategories
            tvListings.Nodes(0).Nodes _
                      .Add(category.ToString())
        Next
    End Sub

    Private Sub CheckBox14_Click(sender As Object, e As EventArgs)
        If chkCatAny.Checked = True Then
            For Each cb In tpPacks.Controls.OfType(Of CheckBox)
                cb.Checked = False
            Next
            chkCatAny.Checked = True
        End If
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
            MessageBox.Show("Osu Session Token does not appear to be valid - Should be in the format: osu-session=" & Chr(34) & StrDup(300, "X").ToString & "%3D", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAutoFill_Click(sender As Object, e As EventArgs) Handles btnAutoFill.Click
        Dim default_browser As BrowserType
        Dim cookies As Dictionary(Of String, String)

        default_browser = GetDefaultBrowser()
        cookies = GetCookieJar("'%ppy.sh%'", default_browser)

        If cookies IsNot Nothing Then
            For Each item As KeyValuePair(Of String, String) in cookies
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

        MaximizeBox = False

        For Each control As Control In tpPacks.Controls
            If TypeOf control Is CheckBox Then
                If StrComp(control.Name, "chkCatAny") <> 0 Then
                    AddHandler control.Click, AddressOf uncheckAllCategories
                End IF
            End If
        Next

        If default_browser = BrowserType.Chrome Then
            tslBrowser.Image = My.Resources.icons8_chrome_24
        Else If default_browser = BrowserType.Firefox Then
            tslBrowser.Image = My.Resources.icons8_firefox_24
        Else If default_browser = BrowserType.MSEdge Then
            tslBrowser.Image = My.Resources.icons8_edge_24
        Else


        End If
    End Sub

    Private Sub uncheckAllCategories(sender As Object, e As EventArgs)
        If chkCatAny.Checked = True Then
            chkCatAny.Checked = False
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

        If frmListings IsNot Nothing Then
            frmListings.Dispose
        End If

        Close()
    End Sub

    Private Sub FrmListings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Visible = False
    End Sub
End Class
