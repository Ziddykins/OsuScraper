Imports System.ComponentModel
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports Flurl.Http
Imports Newtonsoft.Json.Linq

Public Class FrmLoginForm


    Private Sub FrmLoginForm_Closed(sender As Object, e As EventArgs)
        Visible = False
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPasswordValue.Clear()
        txtUsernameValue.Clear()
    End Sub

    Private Sub TxtPasswordValue_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPasswordValue.KeyDown
        If e.KeyValue = 13 Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim username As String = txtUsernameValue.Text
        Dim password As String = txtPasswordValue.Text
        Dim baseUrl As String = "https://osu.ppy.sh"
        
        ' GET
        Dim firstResponse As IFlurlResponse = WebSubmit(baseUrl, "None", HttpMethod.Get, False)
        Dim headers As String = firstResponse.Headers.ToString

        Dim xsrfToken As String = headers.Split("XSRF-TOKEN=")(1).Split(";")(0)
        Dim osuSession As String = headers.Split("osu_session=")(1).Split(";")(0)

        Dim postData As String = $"_token={xsrfToken}&username={username}&password={password}"
        '&g-recaptcha-response=03AFcWeA5ZmD0WQbRYU7xiPdsECOUj2bn7Jahpj3LvPrKu7Y3GBL-mfaJFpIv2mWSd_U6zYj2cNatAGgto1RsxJ-6MchaPe-L8VltVMQ7ts7rFR-kJ12Tst4HUknLGaivzmYUQvBhgpM2te7qeyycAbexEEWTpCC5JO6fh575g96bx6X3npg9Mfpen8y8yYaKxyCoV4fKGxXHHJCXOEEeUCxaT6k_TKpV5OXiJM4VIZGC0wz9wC4QxzttvYC_i3ItSor9zXFpfBkAGrwXTDEYet5VdayrxEKSS9FNSrI-VlrKNm9EfRJhkBPpOXE-LNDrr1bzsLydfSJO4I6eZkkMwGMiCunJ4iBtzJJEAspSlZIk0FePyXvlPDUT2akQ5p_XxQK30MTD8MNWJ1pxDF3Skjyzk-HNR46gsVpP4cjA3MvVYMGo6IEIzBafwksUFctlS69oBE1m2nn47ySMft6LutOvjZoNhKlN2DYi2K6uNRSsIPp9uL3Qvf065uFsz16Ajk-HI2ns9mHfaPFsFsDwuHG7L3sCNK3te_yJ1WkX7pGTccKxzx0XLRi58uyxpy7FR68JJjCf8UaWtqQJDxxmR-ElmgoLf72ddOaMIHXWWZvWq3jERcA9Hn2u3vMvrENScWGqdYFi_LoIwSg_jYXg-ENZpX7Lhu9rjuw"

        FrmMain.txtSessionToken.Text = osuSession
        FrmMain.txtXSRFToken.Text = xsrfToken

        ' POST login data now that we have XSRF + session tokens
        Dim loginResponse As IFlurlResponse = WebSubmit(baseUrl & "/session", postData, HttpMethod.Post, False)

        MessageBox.Show(loginResponse.ResponseMessage.Content.ToString())
        
        





        ' If token_regex.Match(response_body).Success = True Then

        'End If


    End Sub
End Class