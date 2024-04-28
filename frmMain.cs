Imports System.ComponentModel
Imports System.Data.SQLite
Imports System.IO
Imports System.Net.Http
Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms
Imports PeanutButter.INI
Imports Serilog

Public Class FrmMain
    Public log As Core.Logger = New LoggerConfiguration().WriteTo.File("log.txt").CreateLogger()
    Public settings As INIFile

    Private iniFile As String = Path.Combine(My.Application.Info.DirectoryPath, "settings.ini")
    Private FrmHelp As Form
    Private databaseFile As String = Path.Combine(My.Application.Info.DirectoryPath, "osu_data.db")

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAutoFill_Click(sender As Object, e As EventArgs) Handles btnAutoFill.Click
        Dim defaultBrowser As BrowserType
        Dim cookies As Dictionary(Of String, String)

        defaultBrowser = GetDefaultBrowser()
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
                $"Error!",
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
            txtSessionToken.Text = sessionToken.Groups(1).Value.ToString
            txtSessionToken.ForeColor = Drawing.Color.DarkGreen
        Else
            txtSessionToken.ForeColor = Drawing.Color.IndianRed
        End If
    End Sub

    Private Sub txtXSRFToken_TextChanged(sender As Object, e As EventArgs) Handles txtXSRFToken.TextChanged
        Dim xsrfToken As Match

        xsrfToken = Regex.Match(
            txtXSRFToken.Text,
            Chr(34) & "?(?:XSRF-TOKEN[:=])?" & Chr(34) & "?([a-zA-Z0-9]{40})" & Chr(34) & "?"
            )

        If xsrfToken.Success Then
            txtXSRFToken.Text = xsrfToken.Groups(1).Value.ToString
            txtXSRFToken.ForeColor = Drawing.Color.DarkGreen
        Else
            txtXSRFToken.ForeColor = Drawing.Color.IndianRed
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim defaultBrowser As BrowserType = GetDefaultBrowser()
        Dim arrCategories As String() = [Enum].GetNames(GetType(GamePackCategories))
        Dim arrSingles As String() = [Enum].GetNames(GetType(GameSingleCategories))
        Dim arrModes As String() = [Enum].GetNames(GetType(GameModes))
        Dim version As String = Application.ProductVersion.Split("+")(0)
        Dim progName As String = Application.ProductName

        If File.Exists(iniFile) = True Then
            HandleIni("load")
        Else
            HandleIni("generate")
        End If

        MaximizeBox = False

        If defaultBrowser = BrowserType.Chrome Then
            tslBrowser.Image = My.Resources.icons8_chrome_24
        ElseIf defaultBrowser = BrowserType.Firefox Then
            tslBrowser.Image = My.Resources.icons8_firefox_24
        ElseIf defaultBrowser = BrowserType.MsEdge Then
            tslBrowser.Image = My.Resources.icons8_edge_24
            togSkipCheckBrowser.Enabled = False
            togSkipCheckBrowser.Checked = False
        End If

        If CInt(settings.GetValue("Statistics", "RunCount")) = 1 Then
            CacheFileImport(databaseFile, "tbl_packs")
        End If

        mdlBeatmaps.ProcessBeatmaps(Nothing, True)

        FrmHelp = New FrmHelp
        FrmHelp.Show()
        FrmHelp.Visible = False

        FrmHelp.Text = $"Help - {progName} v{version}"
        Text = $"{progName} v{version}"

        For Each cntl As Control In Me.Controls
            If TypeOf cntl Is Guna2GroupBox Then
                AddHandler cntl.MouseEnter, AddressOf GroupHoverColor
                AddHandler cntl.MouseLeave, AddressOf GroupHoverColor
                log.Verbose($"Added focus/unfocus handlers for {cntl.Name}")
            End If
        Next

        For Each tile As Guna2TileButton In grpModes.Controls
            AddHandler tile.Click, AddressOf TileClick
            log.Verbose($"Added click handler for {tile.Name}")
        Next

        PopulateDataGridView()

        cbFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub TileClick(sender As Object, e As EventArgs)
        Dim tile As Guna2TileButton = DirectCast(sender, Guna2TileButton)

        If tile.Checked = True Then
            tile.Checked = False
        Else
            tile.Checked = True
        End If
    End Sub

    Private Sub GroupHoverColor(sender As Object, e As EventArgs)
        Dim grp As Guna2GroupBox = DirectCast(sender, Guna2GroupBox)

        If grp.FillColor = Drawing.Color.White Then
            grp.FillColor = Drawing.Color.FromArgb(213, 218, 223)
        ElseIf grp.FillColor = Drawing.Color.FromArgb(213, 218, 223) Then
            grp.FillColor = Drawing.Color.White
        End If
    End Sub

    Private Sub PopulateDataGridView()
        Dim dataSource As String = $"Datasource={databaseFile};"
        Dim conn As New SQLiteConnection(dataSource)
        Dim query As String = "SELECT * FROM tbl_packs"
        Dim command As New SQLiteCommand(query, conn)
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        dgvListings.DataSource = dataTable
        cbFilter.AutoCompleteCustomSource.AddRange(dataTable.Columns.Cast(Of DataColumn).Select(Function(x) x.ColumnName).ToArray())
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
        lblBatchSizeValue.Text = tbBatchSize.Value.ToString
    End Sub

    Private Sub tbForkValue_Scroll(sender As Object, e As EventArgs) Handles tbForkValue.Scroll
        lblForkValue.Text = tbForkValue.Value.ToString
    End Sub

    Private Sub tbSleepInterval_Scroll(sender As Object, e As EventArgs) Handles tbSleepInterval.Scroll
        lblSleepInterval.Text = tbSleepInterval.Value.ToString
    End Sub

    Private Sub tsmHelp_Click(sender As Object, e As EventArgs) Handles tsmHelp.Click
        If FrmHelp.IsDisposed = False Then
            FrmHelp.Visible = True
        Else
            FrmHelp = New FrmHelp
            FrmHelp.Show()
            FrmHelp.Visible = True
        End If
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        HandleIni("close")

        If FrmHelp IsNot Nothing Then
            FrmHelp.Dispose()
        End If
    End Sub

    Private Function HttpGet(url As String) As HttpResponseMessage
        Dim request As New HttpRequestMessage(HttpMethod.[Get], url)

        request.Headers.Add("User-Agent",
                            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:124.0) Gecko/20100101 Firefox/124.0")
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

    Private Sub cbFilter_Click(sender As Object, e As EventArgs) Handles cbFilter.Click
        If cbFilter.Text = $"<Filter ... >" Then
            cbFilter.Text = ""
        End If
    End Sub

    Private Sub cbFilter_LostFocus(sender As Object, e As EventArgs) Handles cbFilter.LostFocus
        If cbFilter.Text = "" Then
            cbFilter.Text = $"<Filter ... >"
        End If
    End Sub

    Private Sub btnPullSelected_Click(sender As Object, e As EventArgs) Handles btnSyncSelected.Click
        mdlBeatmaps.PullPacks()
    End Sub

    Private Sub btnCheckSession_Click(sender As Object, e As EventArgs) Handles btnCheckSession.Click
        Dim xsrfRegex = "[a-zA-Z0-9]{40}"
        Dim osuSessionRegex = "[a-zA-Z0-9]{100,}.*?%3D"
        Dim rgxCheck As New Regex(osuSessionRegex)
        Dim sessionCheck As OsuSession
        If rgxCheck.IsMatch(txtSessionToken.Text) Then
            rgxCheck = New Regex(xsrfRegex)
            If rgxCheck.IsMatch(txtXSRFToken.Text) Then
                ' Do listings pull
            Else
                MessageBox.Show(
                    $"XSRF Token does not appear to be valid - Should be in the format: XSRF-TOKEN={Chr(34)}{ _
                                   StrDup(40, "X").ToString}", $"Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show(
                $"Osu Session Token does not appear to be valid - Should be in the format: osu_session={Chr(34)}{ _
                               StrDup(300, "X").ToString}%3D", $"Error!", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
        End If

        sessionCheck = VerifySession()

        If sessionCheck = OsuSession.Valid Then
            tslAuthenticatedValue.ForeColor = Drawing.Color.DarkGreen
            tslAuthenticatedValue.Image = My.Resources.icons8_lock_24_green
        Else
            tslAuthenticatedValue.ForeColor = Drawing.Color.Goldenrod
            tslAuthenticatedValue.Text = My.Resources.MAIN_BTN_INVALID_SESSION
            tslAuthenticatedValue.Image = My.Resources.icons8_lock_24_yellow
        End If
    End Sub

    Private Sub btnSetDownloadFolder_Click(sender As Object, e As EventArgs) Handles btnSetDownloadFolder.Click
        fdbDownloadFolder.ShowDialog()
    End Sub

    Private Sub btnSetTempFolder_Click(sender As Object, e As EventArgs) Handles btnSetTempFolder.Click
        fdbTempFolder.ShowDialog()
    End Sub

    Private Sub btnSetOsuFolder_Click(sender As Object, e As EventArgs) Handles btnSetOsuFolder.Click
        fdbOsuFolder.ShowDialog()
    End Sub

    Private Sub HandleIni(how As String)
        settings = New INIFile(iniFile)

        If how = "generate" Then
            Dim downloadFolder = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%").ToString(), "Downloads")
            Dim tempFolder = Path.Combine(Environment.ExpandEnvironmentVariables("%WINDIR%").ToString(), "temp", "beatfiles")
            Dim osuFolder = Path.Combine(Environment.ExpandEnvironmentVariables("%APPDATA%").ToString(), "osu")

            Dim cacheFile = Path.Combine(My.Application.Info.DirectoryPath, ".packs_cache")
            Dim databaseFile = Path.Combine(My.Application.Info.DirectoryPath, "osu_data.db")

            If settings.HasSection("Options") = False Then
                settings.AddSection("Options")
                settings.SetValue("Options", "BatchSize", "100")
                settings.SetValue("Options", "ForkValue", "5")
                settings.SetValue("Options", "SleepInterval", "25")
                settings.SetValue("Options", "DontExtractArchives", "False")
                settings.SetValue("Options", "DisregardCache", "False")
                settings.SetValue("Options", "VerboseLogging", "False")
                settings.SetValue("Options", "OverwriteExisting", "False")
            End If

            If settings.HasSection("Paths") = False Then
                settings.AddSection("Paths")
                settings.SetValue("Paths", "DownloadFolder", downloadFolder)
                settings.SetValue("Paths", "TempFolder", tempFolder)
                settings.SetValue("Paths", "OsuFolder", osuFolder)
                settings.SetValue("Paths", "CacheFile", cacheFile)
            End If

            If settings.HasSection("Cookies") = False Then
                settings.AddSection("Cookies")
                settings.SetValue("Cookies", "XSRF-TOKEN", "")
                settings.SetValue("Cookies", "osu_session", "")
            End If

            If settings.HasSection("Database") = False Then
                settings.AddSection("Database")
                settings.SetValue("Database", "DatabaseFile", databaseFile)
            End If

            If settings.HasSection("Statistics") = False Then
                settings.AddSection("Statistics")
                settings.SetValue("Statistics", "TotalPacks", "0")
                settings.SetValue("Statistics", "TotalSingles", "0")
                settings.SetValue("Statistics", "RunCount", "1")
            End If

            settings.Persist(iniFile)
        ElseIf how = "load" Then
            tbBatchSize.Value = CInt(settings.GetValue("Options", "BatchSize"))
            lblBatchSizeValue.Text = tbBatchSize.Value.ToString()

            tbForkValue.Value = CInt(settings.GetValue("Options", "ForkValue"))
            lblForkValue.Text = tbForkValue.Value.ToString()

            tbSleepInterval.Value = CInt(settings.GetValue("Options", "SleepInterval"))
            lblSleepInterval.Text = tbSleepInterval.Value.ToString()

            togDontExtractArchives.Checked = CBool((settings.GetValue("Options", "DontExtractArchives").ToString()))
            togSkipCheckBrowser.Checked = CBool(settings.GetValue("Options", "DisregardCache"))
            togVerboseLogging.Checked = CBool(settings.GetValue("Options", "VerboseLogging"))
            togOverwriteExisting.Checked = CBool(settings.GetValue("Options", "OverwriteExisting"))

            fdbOsuFolder.SelectedPath = settings.GetValue("Paths", "OsuFolder")
            fdbTempFolder.SelectedPath = settings.GetValue("Paths", "TempFolder")
            fdbDownloadFolder.SelectedPath = settings.GetValue("Paths", "DownloadFolder")

            txtXSRFToken.Text = settings.GetValue("Cookies", "XSRF-TOKEN")
            txtSessionToken.Text = settings.GetValue("Cookies", "osu_session")
            databaseFile = settings.GetValue("Database", "DatabaseFile")
        ElseIf how = "close" Then
            settings.SetValue("Options", "BatchSize", tbBatchSize.Value.ToString())
            settings.SetValue("Options", "ForkValue", tbForkValue.Value.ToString())
            settings.SetValue("Options", "SleepInterval", tbSleepInterval.Value.ToString())
            settings.SetValue("Options", "DontExtractArchives", togDontExtractArchives.Checked.ToString())
            settings.SetValue("Options", "DisregardCache", togSkipCheckBrowser.Checked.ToString())
            settings.SetValue("Options", "VerboseLogging", togVerboseLogging.Checked.ToString())
            settings.SetValue("Options", "OverwriteExisting", togOverwriteExisting.Checked.ToString())

            settings.SetValue("Paths", "DownloadFolder", fdbDownloadFolder.SelectedPath)
            settings.SetValue("Paths", "TempFolder", fdbTempFolder.SelectedPath)
            settings.SetValue("Paths", "OsuFolder", fdbOsuFolder.SelectedPath)

            settings.SetValue("Cookies", "XSRF-TOKEN", txtXSRFToken.Text)
            settings.SetValue("Cookies", "osu_session", txtSessionToken.Text)

            settings.SetValue("Database", "DatabaseFile", databaseFile)
            settings.SetValue("Statistics", "RunCount",
                              (CInt(settings.GetValue("Statistics", "RunCount")) + 1).ToString())

            settings.Persist(iniFile)
        End If
    End Sub

    Private Sub btnCheckDownloadFolder_Click(sender As Object, e As EventArgs) Handles btnCheckDownloadFolder.Click
        Guna2MessageDialog1.Caption = "Current Download Path"
        Guna2MessageDialog1.Text = fdbDownloadFolder.SelectedPath
        Guna2MessageDialog1.Show()
        Guna2MessageDialog1.Style = MessageDialogStyle.Dark
    End Sub

    Private Sub btnCheckTempFolder_Click(sender As Object, e As EventArgs) Handles btnCheckTempFolder.Click
        Guna2MessageDialog1.Caption = "Current Temp Path"
        Guna2MessageDialog1.Text = fdbTempFolder.SelectedPath
        Guna2MessageDialog1.Show()
        Guna2MessageDialog1.Style = MessageDialogStyle.Dark
    End Sub

    Private Sub btnCheckOsuFolder_Click(sender As Object, e As EventArgs) Handles btnCheckOsuFolder.Click
        Guna2MessageDialog1.Caption = "Current Osu! Path"
        Guna2MessageDialog1.Text = fdbOsuFolder.SelectedPath
        Guna2MessageDialog1.Show()
        Guna2MessageDialog1.Style = MessageDialogStyle.Dark
    End Sub

    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        HandleIni("close")
    End Sub

    Private Sub FrmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        HandleIni("close")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub togSkipCheckBrowser_Click(sender As Object, e As EventArgs) Handles togSkipCheckBrowser.Click
        If togSkipCheckBrowser.Enabled = False Then
            Guna2MessageDialog1.Caption = "Unsupported Browser"
            Guna2MessageDialog1.Text = "This feature is not supported for Microsoft Edge"
            Guna2MessageDialog1.Buttons = MessageDialogButtons.OK
            Guna2MessageDialog1.Style = MessageDialogStyle.Light
        End If
    End Sub

End Class