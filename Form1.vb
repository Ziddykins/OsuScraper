Imports System.Text.RegularExpressions


Public Class frmMain
    Public frmListings As Form = New frmListings
      
    Private Sub CheckBox14_Click(sender As Object, e As EventArgs) Handles chkCatAny.Click
        If chkCatAny.Checked = True Then
            For Each cb As CheckBox In grpCategories.Controls.OfType(Of CheckBox)
                cb.Checked = False
            Next
            chkCatAny.Checked = True
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnScrape.Click
        Dim xsrf_regex = "[a-zA-Z0-9]{40}"
        Dim osu_session_regex = "[a-zA-Z0-9]{100,}.*?%3D"
        Dim rgx_check As New Regex(osu_session_regex)

        If rgx_check.IsMatch(txtSessionToken.Text) Then
            rgx_check = New Regex(xsrf_regex)
            If rgx_check.IsMatch(txtXSRFToken.Text) Then
                ' Do listings pull
            Else
                MessageBox.Show("XSRF Token does not appear to be valid - Should be in the format: XSRF-TOKEN=" & Chr(34) & StrDup(40, "X").ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Osu Session Token does not appear to be valid - Should be in the format: osu-session=" & Chr(34) & StrDup(300, "X").ToString() & "%3D", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAutoFill_Click(sender As Object, e As EventArgs) Handles btnAutoFill.Click
        Dim cookies = GetCookieJar("'%ppy.sh%'", BrowserType.Chrome)

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
                "Failed to extract and/or decrypt cookies from Chrome database - " &
                    "Please use the 'Login' button instead to pull values, or manually supply them." & vbCrLf & vbCrLf &
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

    Private Sub tbForkValue_Scroll(sender As Object, e As EventArgs) Handles tbForkValue.Scroll
        lblForkValue.Text = tbForkValue.Value.ToString()
    End Sub

    Private Sub tbSleepInterval_Scroll(sender As Object, e As EventArgs) Handles tbSleepInterval.Scroll
        lblSleepInterval.Text = tbSleepInterval.Value.ToString()
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

    Private Sub btnOpenListings_Click(sender As Object, e As EventArgs) Handles btnOpenListings.Click
        If frmListings Is Nothing Then
            frmListings = New frmListings   
            frmListings.Show()
        Else 
            frmListings.Show()
        End If
    End Sub
    Public Sub CleanUpListings()

        frmListings.Dispose()
        frmListings = Nothing
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaximizeBox = False
        
        For Each control As Control In grpCategories.Controls
            If TypeOf control Is CheckBox Then
                If StrComp(control.Name, "chkCatAny") <> 0 Then
                    AddHandler control.Click, AddressOf uncheckAllCategories
                    MessageBox.Show("Added handler for " & control.Name.ToString())
                End IF
            End If
        Next
    End Sub

    Private Sub uncheckAllCategories (sender As Object, e As EventArgs)
        If chkCatAny.Checked = True Then
            chkCatAny.Checked = False
        End If
    End Sub
End Class
