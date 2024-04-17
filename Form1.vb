Imports System.Data.SQLite
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports WinRT
Imports Serilog
Imports Serilog.Events
Imports Serilog.Sinks.File



Public Class FrmMain
    Public FrmHelp As Form
    Public log As Core.Logger
    Public databaseFile As String


    Public Sub New()
        InitializeComponent()
        Dim version As String = Application.ProductVersion.Split("+")(0)
        Dim progName As String = Application.ProductName

        log = New LoggerConfiguration().WriteTo.File("log.txt").CreateLogger()

        FrmHelp = New frmHelp
        FrmHelp.Show()
        FrmHelp.Visible = False

        FrmHelp.Text = $"Help - {progName} v{version}"
        Text = $"Help - {progName} v{version}"

        databaseFile = $"{My.Application.Info.DirectoryPath}osu_data.db"
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
                    $"XSRF Token does not appear to be valid - Should be in the format: XSRF-TOKEN={Chr(34)}{ _
                                   StrDup(40, "X").ToString}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(
                $"Osu Session Token does not appear to be valid - Should be in the format: osu_session={Chr(34)}{ _
                               StrDup(300, "X").ToString}%3D", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAutoFill_Click(sender As Object, e As EventArgs) Handles btnAutoFill.Click
        Dim defaultBrowser As BrowserType
        Dim cookies As Dictionary(Of String, String)

        defaultBrowser = GetDefaultBrowser
        cookies = GetCookieJar("'%ppy.sh%'", defaultBrowser)

        If cookies IsNot Nothing Then
            For Each item In cookies
                If item.Key = "XSRF-TOKEN" Then
                    txtXSRFToken.Text = item.Value
                ElseIf item.Key = "osu_session" Then
                    txtSessionToken.Text = item.Value
                End If
                btnCheckSession.Enabled = True
            Next
        Else
            MessageBox.Show(
                $"Failed to extract and/or decrypt cookies from database - Please manually supply the session cookies{ _
                               vbCrLf}{vbCrLf _
                               }These cookies can be found in your browser after logging into your Osu! account.{vbCrLf _
                               }{vbCrLf}Chrome: F12 -> Storage -> Cookies{vbCrLf}Firefox: F12 -> Storage -> Cookies{ _
                               vbCrLf}Opera: CTRL + SHIFT + J -> Application -> Cookies",
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If
    End Sub

    Private Sub txtSessionToken_TextChanged(sender As Object, e As EventArgs) Handles txtSessionToken.TextChanged
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

    Private Sub txtXSRFToken_TextChanged(sender As Object, e As EventArgs) Handles txtXSRFToken.TextChanged
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim defaultBrowser As BrowserType = GetDefaultBrowser()
        Dim arrCategories As String() = [Enum].GetNames(GetType(GamePackCategories))
        Dim arrSingles As String() = [Enum].GetNames(GetType(GameSingleCategories))
        Dim arrModes As String() = [Enum].GetNames(GetType(GameModes))

        MaximizeBox = False

        If defaultBrowser = BrowserType.Chrome Then
            tslBrowser.Image = My.Resources.icons8_chrome_24
        ElseIf defaultBrowser = BrowserType.Firefox Then
            tslBrowser.Image = My.Resources.icons8_firefox_24
        ElseIf defaultBrowser = BrowserType.MsEdge Then
            tslBrowser.Image = My.Resources.icons8_edge_24
        End If

        For Each category As String In arrCategories
            Dim categoryEnum = StringToEnum(Of GamePackCategories)(category)

            tvListings.Nodes(0).Nodes.Add(category.ToString())
            tvListings.Nodes(1).Nodes.Add(category.ToString())
            For Each mode As String In arrModes
                Dim currentEnum = StringToEnum(Of GameModes)(mode)
                tvListings.Nodes(0).Nodes(categoryEnum).Nodes.Add(mode)
            Next
        Next

        For Each category As String In arrSingles
            Dim categoryEnum = StringToEnum(Of GameSingleCategories)(category)

            For Each mode As String In arrModes
                Dim currentEnum = StringToEnum(Of GameModes)(mode)
                tvListings.Nodes(0).Nodes(categoryEnum).Nodes.Add(mode)
            Next
        Next

        LoadCacheFile()

        cbFilter.AutoCompleteCustomSource = New AutoCompleteStringCollection()

        PrintRecursive(tvListings.Nodes(0))
    End Sub
    Private Sub PrintRecursive(n As TreeNode)
        log.Information("Layer: {n}", n.Text)
        Dim aNode As TreeNode
        For Each aNode In n.Nodes
            PrintRecursive(aNode)
        Next
    End Sub

    ' Call the procedure using the top nodes of the treeview.  
    Private Sub CallRecursive(aTreeView As TreeView)
        Dim n As TreeNode
        For Each n In aTreeView.Nodes
            PrintRecursive(n)
        Next
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
        If FrmHelp.IsDisposed = False Then
            FrmHelp.Visible = True
        Else
            FrmHelp = New frmHelp
            FrmHelp.Show()
            FrmHelp.Visible = True
        End If
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If FrmHelp IsNot Nothing Then
            FrmHelp.Dispose()
        End If
    End Sub

    Private Function HttpGet(url As String) As HttpResponseMessage
        Dim request As New HttpRequestMessage(HttpMethod.[Get], url)

        request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0")
        request.Headers.Add("Accept", "text/html, application/xhtml+xml")
        request.Headers.Add("Accept-Language", "en-CA,en-US;q=0.7,en;q=0.3")
        request.Headers.Add("Connection", "keep-alive")
        request.Headers.Add("Referer", "https://osu.ppy.sh/")
        request.Headers.Add("Cookie", $"XSRF-TOKEN={txtXSRFToken.Text}; osu_session={txtSessionToken.Text};")
        request.Headers.Add("Sec-Fetch-Dest", "empty")
        request.Headers.Add("Sec-Fetch-Mode", "cors")
        request.Headers.Add("Sec-Fetch-Site", "same-origin")

        Dim response As HttpResponseMessage = New HttpClient().SendAsync(request).Result
        response.EnsureSuccessStatusCode()

        Return response
    End Function

    Private Sub PullPacks()
        Dim types As New List(Of String)
        Dim response As HttpResponseMessage
        Dim content As String
        Dim lines() As String
        Dim dataSource As String
        Dim conn As SQLiteConnection
        Dim cmd As SQLiteCommand
        Dim count As Integer

        For Each cb As CheckBox in tpPacks.Controls
            If cb.Checked = True Then
                types.Add(cb.Name.ToLower())
            End If
        Next

        count = types.Count()

        prgPrimaryTask.Maximum = count
        prgPrimaryTask.Step = 1
        prgPrimaryTask.Value = 1

        For Each selected As String In Types
            prgPrimaryTask.PerformStep()
            Dim type As String = selected.split("pack")(1)

            If type = "spotlight" Then
                type = "chart"
            End If

            response = HttpGet($"https://osu.ppy.sh/beatmaps/packs?type={type}")
            content = response.Content.ReadAsStringAsync.Result.ToString()

            content = Regex.Replace(content, "(?:[\r\n]+|\s{2,})", " ")
            lines = content.Split($"class={Chr(34)}beatmap-pack js-beatmap-pack js-accordion__item")

            dataSource = $"Data Source={databaseFile};"
            conn = New SQLiteConnection(dataSource)
            cmd = conn.CreateCommand()

            prgSecondaryTask.Maximum = lines.Length
            prgSecondaryTask.Step = 1
            prgSecondaryTask.Value = 1

            For Each line As String In lines
                prgSecondaryTask.PerformStep()
                Dim matched As Match = Regex.Match(line,
                                                   $"{Chr(34)} data-pack-tag={Chr(34)}(.*?){Chr(34)}.*?href={Chr(34) _
                                                      }(.*?){Chr(34)}.*?pack__name{Chr(34)}>(.*?)<\/div>.*?__date{ _
                                                      Chr(34)}>(.*?)<\/span>.*?__author--bold{Chr(34)}>(.*?)<\/span>")
                Dim packTitle As String = matched.Groups(3).Value
                Dim packAuthor As String = matched.Groups(4).Value
                Dim packDate As String = matched.Groups(2).Value
                Dim packCode As String = matched.Groups(1).Value
                StringToEnum(Of GamePackCategories)(type)

                If packTitle IsNot Nothing Then
                    tvListings.Nodes(0).Nodes(GamePackCategories.Standard).Nodes.Add(packTitle)
                End If
            Next
        Next
    End Sub

    Private Sub cbFilter_Click(sender As Object, e As EventArgs) Handles cbFilter.Click
        cbFilter.Text = ""
    End Sub

    Private Sub cbFilter_LostFocus(sender As Object, e As EventArgs) Handles cbFilter.LostFocus
        If cbFilter.Text = "" Then
            cbFilter.Text = "<Filter ... >"
        End If
    End Sub

    Private Sub btnPullSelected_Click(sender As Object, e As EventArgs) Handles btnPullSelected.Click
        PullPacks()
    End Sub

    Private Sub btnCheckSession_Click(sender As Object, e As EventArgs) Handles btnCheckSession.Click
        If VerifySession() = True Then
            tslAuthenticatedValue.ForeColor = Color.DarkGreen
        Else
            tslAuthenticatedValue.ForeColor = Color.Yellow
            tslStatus.Text = My.Resources.MAIN_BTN_INVALID_SESSION
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class