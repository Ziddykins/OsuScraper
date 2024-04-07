Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports Flurl.Http

Public Class FrmMain
    Private _frmListings As Form
    Private _frmLoginForm As Form

    Private Sub New()
        InitializeComponent()
        _frmListings = New FrmListings
        _frmLoginForm = New FrmLoginForm

        _frmListings.Show()
        _frmLoginForm.Show()

        _frmListings.Visible = False
        _frmLoginForm.Visible = False
    End Sub

    Private Sub CheckBox14_Click(sender As Object, e As EventArgs)
        If chkCatAny.Checked = True Then
            For Each cb In tpSingles.Controls.OfType (Of CheckBox)
                cb.Checked = False
            Next
            chkCatAny.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim xsrfRegex = "[a-zA-Z0-9]{40}"
        Dim osuSessionRegex = "[a-zA-Z0-9]{100,}.*?%3D"
        Dim rgxCheck As New Regex(osuSessionRegex)

        If rgxCheck.IsMatch(txtSessionToken.Text) Then
            rgxCheck = New Regex(xsrfRegex)
            If rgxCheck.IsMatch(txtXSRFToken.Text) Then
                ' Do listings pull
            Else
                MessageBox.Show(
                    $"XSRF Token does not appear to be valid - Should be in the format: " &
                    $"XSRF-TOKEN={Chr(34)} " & StrDup(40, "X").ToString(),
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    )
            End If
        Else
            MessageBox.Show(
                "Osu Session Token does not appear to be valid - Should be in the format: osu-session=" & Chr(34) &
                StrDup(300, "X").ToString & "%3D", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnAutoFill_Click(sender As Object, e As EventArgs) Handles btnAutoFill.Click
        Dim defaultBrowser As BrowserType
        Dim cookies As Dictionary(Of String, String)

        defaultBrowser = GetDefaultBrowser()
        cookies = GetCookieJar("'%ppy.sh%'", defaultBrowser)

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
                $"Failed to extract and/or decrypt cookies from database - " &
                $"Please use the 'Login' button instead, or manually supply them." & vbCrLf & vbCrLf &
                $"These cookies can be found in your browser after logging into your Osu! account." & vbCrLf & vbCrLf &
                $"Chrome: F12 -> Storage -> Cookies" & vbCrLf &
                $"Firefox: F12 -> Storage -> Cookies" & vbCrLf &
                $"Opera: CTRL + SHIFT + J -> Application -> Cookies",
                $"Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
                )
        End If
    End Sub

    Private Sub TxtSessionToken_TextChanged(sender As Object, e As EventArgs) Handles txtSessionToken.TextChanged
        Dim sessionToken As Match

        sessionToken = Regex.Match(
            txtSessionToken.Text,
            Chr(34) & "?(?:osu_session[:=])?" & Chr(34) & "?([a-zA-Z0-9]{100,}%3D)" & Chr(34) & "?"
            )

        If sessionToken.Success Then
            txtSessionToken.Text = sessionToken.Groups(1).Value.ToString()
            txtSessionToken.ForeColor = Color.DarkGreen
        Else
            txtSessionToken.ForeColor = Color.IndianRed
        End If
    End Sub

    Private Sub TxtXSRFToken_TextChanged(sender As Object, e As EventArgs) Handles txtXSRFToken.TextChanged
        Dim xsrfToken As Match

        xsrfToken = Regex.Match(
            txtXSRFToken.Text,
            Chr(34) & "?(?:XSRF-TOKEN[:=])?" & Chr(34) & "?([a-zA-Z0-9]{40})" & Chr(34) & "?"
            )

        If xsrfToken.Success Then
            txtXSRFToken.Text = xsrfToken.Groups(1).Value.ToString()
            txtXSRFToken.ForeColor = Color.DarkGreen
        Else
            txtXSRFToken.ForeColor = Color.IndianRed
        End If
    End Sub

    Private Sub BtnOpenListings_Click(sender As Object, e As EventArgs) Handles btnOpenListings.Click
        If _frmListings.IsDisposed = False Then
            _frmListings.Visible = True
        Else
            _frmListings = New FrmListings
            _frmListings.Show
            _frmListings.Visible = True
        End If
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim defaultBrowser As BrowserType = GetDefaultBrowser()

        MaximizeBox = False

        For Each control As Control In tpSingles.Controls
            If TypeOf control Is CheckBox Then
                If StrComp(control.Name, "chkCatAny") <> 0 Then
                    AddHandler control.Click, AddressOf UncheckAllCategories
                End If
            End If
        Next

        If defaultBrowser = BrowserType.Chrome Then
            tslBrowser.Text = "Chrome"
            tslBrowser.ForeColor = Color.DarkGreen
        ElseIf defaultBrowser = BrowserType.Firefox Then
            tslBrowser.Text = "Firefox"
            tslBrowser.ForeColor = Color.IndianRed
        ElseIf defaultBrowser = BrowserType.MsEdge Then
            tslBrowser.Text = "MSEdge"
            tslBrowser.ForeColor = Color.CadetBlue
        Else
            tslBrowser.Text = "Unsupported"
            tslBrowser.ForeColor = Color.HotPink
        End If
    End Sub

    Private Sub UncheckAllCategories(sender As Object, e As EventArgs)
        If chkCatAny.Checked = True Then
            chkCatAny.Checked = False
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtSessionToken.Text <> "" And txtXSRFToken.Text <> "" Then
            Dim response = LoginAsync(
                "https://osu.ppy.sh/session",
                FrmLoginForm.txtUsernameValue.Text,
                FrmLoginForm.txtPasswordValue.Text
            )
        Else
            If _frmLoginForm.IsDisposed = False Then
                _frmLoginForm.Visible = True
            Else
                _frmLoginForm = New FrmLoginForm
                _frmLoginForm.Show()
                _frmLoginForm.Visible = True
            End If
        End If
    End Sub

    Public Shared Async Function GetSessionVariablesAsync(url As String) As Task(Of String)
        Dim client As HttpClient = New HttpClient

        Dim response As HttpResponseMessage = Await client.GetAsync(url)
        If response.IsSuccessStatusCode Then
            Dim sessionVariables As String = Await response.Content.ReadAsStringAsync()
            Return sessionVariables
        Else
            Throw New Exception($"Failed to fetch session variables: {response.StatusCode}")
        End If
    End Function

    Public Shared Async Function LoginAsync(url As String, username As String, password As String) As Task(Of String)
        Dim client As HttpClient = New HttpClient

        Dim content As New FormUrlEncodedContent(New Dictionary(Of String, String) From {
            {"username", username},
            {"password", password}
        })

        Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
        If response.IsSuccessStatusCode Then
            Dim result As String = Await response.Content.ReadAsStringAsync()
            Return result
        Else
            Throw New Exception($"Failed to login: {response.StatusCode}")
        End If
    End Function

    Private Sub tbBatchSize_Scroll(sender As Object, e As EventArgs) Handles tbBatchSize.Scroll
        lblBatchSizeValue.Text = tbBatchSize.Value.ToString()
    End Sub

    Private Sub tbForkValue_Scroll(sender As Object, e As EventArgs) Handles tbForkValue.Scroll
        lblForkValue.Text = tbForkValue.Value.ToString()
    End Sub

    Private Sub tbSleepInterval_Scroll(sender As Object, e As EventArgs) Handles tbSleepInterval.Scroll
        lblSleepInterval.Text = tbSleepInterval.Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim response As IFlurlResponse = WebSubmit("https://osu.ppy.sh/beatmaps/packs/S1405", "None", HttpMethod.Get,
                                                   False)
        MessageBox.Show(response.ResponseMessage.Content.ToString())
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If _frmListings.IsDisposed = False Then
            _frmListings.Close()
        End If

        If _frmLoginForm.IsDisposed = False Then
            _frmLoginForm.Close()
        End If

        If FrmDebugLog.IsDisposed = False Then
            FrmDebugLog.Close()
        End If

        Me.Close()
    End Sub

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End Sub
End Class
