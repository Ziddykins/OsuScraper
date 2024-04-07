<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        pbLogo = New PictureBox()
        grpModes = New GroupBox()
        chkModeTaiko = New CheckBox()
        imlModes = New ImageList(components)
        chkModeMania = New CheckBox()
        chkModeCatch = New CheckBox()
        chkModeOsu = New CheckBox()
        imlCategories = New ImageList(components)
        msMainMenu = New MenuStrip()
        tsmFile = New ToolStripMenuItem()
        OpenCacheFileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        tsmListings = New ToolStripMenuItem()
        UpdateToolStripMenuItem = New ToolStripMenuItem()
        UpdateToolStripMenuItem1 = New ToolStripMenuItem()
        ReloadCacheFileToolStripMenuItem = New ToolStripMenuItem()
        PullFromServerToolStripMenuItem = New ToolStripMenuItem()
        tsmOptions = New ToolStripMenuItem()
        tsmHelp = New ToolStripMenuItem()
        grpConfiguration = New GroupBox()
        Button1 = New Button()
        lblBatchSizeValue = New Label()
        lblBatchSizeLabel = New Label()
        tbBatchSize = New TrackBar()
        btnOpenListings = New Button()
        btnLogin = New Button()
        btnAutoFill = New Button()
        lblXSRFTokenLabel = New Label()
        lblSessionLabel = New Label()
        txtXSRFToken = New TextBox()
        txtSessionToken = New TextBox()
        lblSleepInterval = New Label()
        lblSleepIntervalLabel = New Label()
        tbSleepInterval = New TrackBar()
        lblForkValue = New Label()
        lblForkLabel = New Label()
        tbForkValue = New TrackBar()
        chkOverwriteExistingFiles = New CheckBox()
        chkVerboseLogging = New CheckBox()
        chkNoExtractArchives = New CheckBox()
        chkDisregardCache = New CheckBox()
        ttGeneralHover = New ToolTip(components)
        StatusStrip1 = New StatusStrip()
        tslBrowser = New ToolStripStatusLabel()
        tslStatusesLabel = New ToolStripStatusLabel()
        tssAuthenticatedValue = New ToolStripStatusLabel()
        tssSep1 = New ToolStripStatusLabel()
        tslCacheValue = New ToolStripStatusLabel()
        tslSep2 = New ToolStripStatusLabel()
        tslPulledValue = New ToolStripStatusLabel()
        tslSpacer = New ToolStripStatusLabel()
        tspbProgressBar = New ToolStripProgressBar()
        TabControl1 = New TabControl()
        tpSingles = New TabPage()
        chkCatGraveyard = New CheckBox()
        chkCatPersonal = New CheckBox()
        chkCatWorkInProgress = New CheckBox()
        chkCatLeaderBoard = New CheckBox()
        chkCatPending = New CheckBox()
        chkCatQualified = New CheckBox()
        chkCatLoved = New CheckBox()
        chkCatRanked = New CheckBox()
        chkCatFaves = New CheckBox()
        tpPacks = New TabPage()
        CheckBox1 = New CheckBox()
        chkCatAny = New CheckBox()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        grpModes.SuspendLayout()
        msMainMenu.SuspendLayout()
        grpConfiguration.SuspendLayout()
        CType(tbBatchSize, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbSleepInterval, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbForkValue, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tpSingles.SuspendLayout()
        tpPacks.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Top
        pbLogo.Image = My.Resources.Resources.os_logo
        pbLogo.Location = New Point(0, 24)
        pbLogo.Margin = New Padding(3, 4, 3, 4)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(448, 108)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' grpModes
        ' 
        grpModes.Controls.Add(chkModeTaiko)
        grpModes.Controls.Add(chkModeMania)
        grpModes.Controls.Add(chkModeCatch)
        grpModes.Controls.Add(chkModeOsu)
        grpModes.Location = New Point(0, 140)
        grpModes.Margin = New Padding(3, 4, 3, 4)
        grpModes.Name = "grpModes"
        grpModes.Padding = New Padding(3, 4, 3, 4)
        grpModes.Size = New Size(258, 97)
        grpModes.TabIndex = 1
        grpModes.TabStop = False
        grpModes.Text = "Mode"
        ' 
        ' chkModeTaiko
        ' 
        chkModeTaiko.Appearance = Appearance.Button
        chkModeTaiko.AutoSize = True
        chkModeTaiko.ImageKey = "Taiko.png"
        chkModeTaiko.ImageList = imlModes
        chkModeTaiko.Location = New Point(203, 26)
        chkModeTaiko.Margin = New Padding(3, 4, 3, 4)
        chkModeTaiko.Name = "chkModeTaiko"
        chkModeTaiko.Size = New Size(47, 63)
        chkModeTaiko.TabIndex = 3
        chkModeTaiko.Text = "Taiko"
        chkModeTaiko.TextAlign = ContentAlignment.MiddleCenter
        chkModeTaiko.TextImageRelation = TextImageRelation.ImageAboveText
        chkModeTaiko.UseVisualStyleBackColor = True
        ' 
        ' imlModes
        ' 
        imlModes.ColorDepth = ColorDepth.Depth8Bit
        imlModes.ImageStream = CType(resources.GetObject("imlModes.ImageStream"), ImageListStreamer)
        imlModes.TransparentColor = Color.Transparent
        imlModes.Images.SetKeyName(0, "FruitDrop.png")
        imlModes.Images.SetKeyName(1, "Mania.png")
        imlModes.Images.SetKeyName(2, "Osu.png")
        imlModes.Images.SetKeyName(3, "Taiko.png")
        ' 
        ' chkModeMania
        ' 
        chkModeMania.Appearance = Appearance.Button
        chkModeMania.AutoSize = True
        chkModeMania.ImageKey = "Mania.png"
        chkModeMania.ImageList = imlModes
        chkModeMania.Location = New Point(135, 26)
        chkModeMania.Margin = New Padding(3, 4, 3, 4)
        chkModeMania.Name = "chkModeMania"
        chkModeMania.Size = New Size(52, 63)
        chkModeMania.TabIndex = 2
        chkModeMania.Text = "Mania"
        chkModeMania.TextAlign = ContentAlignment.MiddleCenter
        chkModeMania.TextImageRelation = TextImageRelation.ImageAboveText
        chkModeMania.UseVisualStyleBackColor = True
        ' 
        ' chkModeCatch
        ' 
        chkModeCatch.Appearance = Appearance.Button
        chkModeCatch.AutoSize = True
        chkModeCatch.ImageKey = "FruitDrop.png"
        chkModeCatch.ImageList = imlModes
        chkModeCatch.Location = New Point(69, 26)
        chkModeCatch.Margin = New Padding(3, 4, 3, 4)
        chkModeCatch.Name = "chkModeCatch"
        chkModeCatch.Size = New Size(50, 63)
        chkModeCatch.TabIndex = 1
        chkModeCatch.Text = "Catch"
        chkModeCatch.TextAlign = ContentAlignment.MiddleCenter
        chkModeCatch.TextImageRelation = TextImageRelation.ImageAboveText
        chkModeCatch.UseVisualStyleBackColor = True
        ' 
        ' chkModeOsu
        ' 
        chkModeOsu.Appearance = Appearance.Button
        chkModeOsu.AutoSize = True
        chkModeOsu.ImageKey = "Osu.png"
        chkModeOsu.ImageList = imlModes
        chkModeOsu.Location = New Point(11, 26)
        chkModeOsu.Margin = New Padding(3, 4, 3, 4)
        chkModeOsu.Name = "chkModeOsu"
        chkModeOsu.Size = New Size(42, 63)
        chkModeOsu.TabIndex = 0
        chkModeOsu.Text = "Osu!"
        chkModeOsu.TextAlign = ContentAlignment.MiddleCenter
        chkModeOsu.TextImageRelation = TextImageRelation.ImageAboveText
        chkModeOsu.UseVisualStyleBackColor = True
        ' 
        ' imlCategories
        ' 
        imlCategories.ColorDepth = ColorDepth.Depth8Bit
        imlCategories.ImageStream = CType(resources.GetObject("imlCategories.ImageStream"), ImageListStreamer)
        imlCategories.TransparentColor = Color.Transparent
        imlCategories.Images.SetKeyName(0, "icons8-all-24.png")
        imlCategories.Images.SetKeyName(1, "icons8-test-account-24.png")
        imlCategories.Images.SetKeyName(2, "icons8-mine-24.png")
        imlCategories.Images.SetKeyName(3, "icons8-cemetery-24.png")
        imlCategories.Images.SetKeyName(4, "icons8-in-progress-24.png")
        imlCategories.Images.SetKeyName(5, "icons8-pending-24.png")
        imlCategories.Images.SetKeyName(6, "icons8-favorite-24.png")
        imlCategories.Images.SetKeyName(7, "icons8-heart-24.png")
        imlCategories.Images.SetKeyName(8, "icons8-qualified-24.png")
        imlCategories.Images.SetKeyName(9, "icons8-leaderboard-24.png")
        imlCategories.Images.SetKeyName(10, "icons8-edit-none.png")
        ' 
        ' msMainMenu
        ' 
        msMainMenu.ImageScalingSize = New Size(24, 24)
        msMainMenu.Items.AddRange(New ToolStripItem() {tsmFile, tsmListings, tsmOptions, tsmHelp})
        msMainMenu.Location = New Point(0, 0)
        msMainMenu.Name = "msMainMenu"
        msMainMenu.Size = New Size(448, 24)
        msMainMenu.TabIndex = 3
        msMainMenu.Text = "MenuStrip1"
        ' 
        ' tsmFile
        ' 
        tsmFile.DropDownItems.AddRange(New ToolStripItem() {OpenCacheFileToolStripMenuItem, ExitToolStripMenuItem, ExitToolStripMenuItem1})
        tsmFile.Name = "tsmFile"
        tsmFile.Size = New Size(37, 20)
        tsmFile.Text = "&File"
        ' 
        ' OpenCacheFileToolStripMenuItem
        ' 
        OpenCacheFileToolStripMenuItem.Name = "OpenCacheFileToolStripMenuItem"
        OpenCacheFileToolStripMenuItem.Size = New Size(164, 22)
        OpenCacheFileToolStripMenuItem.Text = "Op&en cache file"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(164, 22)
        ExitToolStripMenuItem.Text = "O&pen Debug Log"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(164, 22)
        ExitToolStripMenuItem1.Text = "E&xit"
        ' 
        ' tsmListings
        ' 
        tsmListings.DropDownItems.AddRange(New ToolStripItem() {UpdateToolStripMenuItem, UpdateToolStripMenuItem1})
        tsmListings.Name = "tsmListings"
        tsmListings.Size = New Size(59, 20)
        tsmListings.Text = "&Listings"
        ' 
        ' UpdateToolStripMenuItem
        ' 
        UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        UpdateToolStripMenuItem.Size = New Size(112, 22)
        UpdateToolStripMenuItem.Text = "&Clear"
        ' 
        ' UpdateToolStripMenuItem1
        ' 
        UpdateToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ReloadCacheFileToolStripMenuItem, PullFromServerToolStripMenuItem})
        UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1"
        UpdateToolStripMenuItem1.Size = New Size(112, 22)
        UpdateToolStripMenuItem1.Text = "&Update"
        ' 
        ' ReloadCacheFileToolStripMenuItem
        ' 
        ReloadCacheFileToolStripMenuItem.Name = "ReloadCacheFileToolStripMenuItem"
        ReloadCacheFileToolStripMenuItem.Size = New Size(167, 22)
        ReloadCacheFileToolStripMenuItem.Text = "&Reload Cache File"
        ' 
        ' PullFromServerToolStripMenuItem
        ' 
        PullFromServerToolStripMenuItem.Name = "PullFromServerToolStripMenuItem"
        PullFromServerToolStripMenuItem.Size = New Size(167, 22)
        PullFromServerToolStripMenuItem.Text = "&Pull From Server"
        ' 
        ' tsmOptions
        ' 
        tsmOptions.Name = "tsmOptions"
        tsmOptions.Size = New Size(61, 20)
        tsmOptions.Text = "&Options"
        ' 
        ' tsmHelp
        ' 
        tsmHelp.Name = "tsmHelp"
        tsmHelp.Size = New Size(44, 20)
        tsmHelp.Text = "&Help"
        ' 
        ' grpConfiguration
        ' 
        grpConfiguration.Controls.Add(Button1)
        grpConfiguration.Controls.Add(lblBatchSizeValue)
        grpConfiguration.Controls.Add(lblBatchSizeLabel)
        grpConfiguration.Controls.Add(tbBatchSize)
        grpConfiguration.Controls.Add(btnOpenListings)
        grpConfiguration.Controls.Add(btnLogin)
        grpConfiguration.Controls.Add(btnAutoFill)
        grpConfiguration.Controls.Add(lblXSRFTokenLabel)
        grpConfiguration.Controls.Add(lblSessionLabel)
        grpConfiguration.Controls.Add(txtXSRFToken)
        grpConfiguration.Controls.Add(txtSessionToken)
        grpConfiguration.Controls.Add(lblSleepInterval)
        grpConfiguration.Controls.Add(lblSleepIntervalLabel)
        grpConfiguration.Controls.Add(tbSleepInterval)
        grpConfiguration.Controls.Add(lblForkValue)
        grpConfiguration.Controls.Add(lblForkLabel)
        grpConfiguration.Controls.Add(tbForkValue)
        grpConfiguration.Location = New Point(267, 146)
        grpConfiguration.Name = "grpConfiguration"
        grpConfiguration.Size = New Size(176, 355)
        grpConfiguration.TabIndex = 4
        grpConfiguration.TabStop = False
        grpConfiguration.Text = "Configuration"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.IndianRed
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Quicksand", 9F)
        Button1.Location = New Point(91, 306)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 40)
        Button1.TabIndex = 19
        Button1.Text = "Test"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblBatchSizeValue
        ' 
        lblBatchSizeValue.AutoSize = True
        lblBatchSizeValue.Location = New Point(143, 117)
        lblBatchSizeValue.Name = "lblBatchSizeValue"
        lblBatchSizeValue.Size = New Size(14, 18)
        lblBatchSizeValue.TabIndex = 18
        lblBatchSizeValue.Text = "3"
        lblBatchSizeValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBatchSizeLabel
        ' 
        lblBatchSizeLabel.AutoSize = True
        lblBatchSizeLabel.Location = New Point(78, 116)
        lblBatchSizeLabel.Name = "lblBatchSizeLabel"
        lblBatchSizeLabel.Size = New Size(68, 18)
        lblBatchSizeLabel.TabIndex = 17
        lblBatchSizeLabel.Text = "Batch Size:"
        lblBatchSizeLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tbBatchSize
        ' 
        tbBatchSize.AutoSize = False
        tbBatchSize.LargeChange = 100
        tbBatchSize.Location = New Point(10, 134)
        tbBatchSize.Maximum = 1000
        tbBatchSize.Name = "tbBatchSize"
        tbBatchSize.Size = New Size(161, 24)
        tbBatchSize.SmallChange = 25
        tbBatchSize.TabIndex = 16
        tbBatchSize.TickStyle = TickStyle.TopLeft
        tbBatchSize.Value = 25
        ' 
        ' btnOpenListings
        ' 
        btnOpenListings.FlatAppearance.BorderColor = Color.IndianRed
        btnOpenListings.FlatStyle = FlatStyle.Popup
        btnOpenListings.Font = New Font("Quicksand", 8.25F)
        btnOpenListings.Location = New Point(14, 306)
        btnOpenListings.Margin = New Padding(1)
        btnOpenListings.Name = "btnOpenListings"
        btnOpenListings.Size = New Size(71, 40)
        btnOpenListings.TabIndex = 15
        btnOpenListings.Text = "Open Listings"
        btnOpenListings.TextAlign = ContentAlignment.TopCenter
        btnOpenListings.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Quicksand", 9F)
        btnLogin.Location = New Point(91, 261)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(71, 40)
        btnLogin.TabIndex = 14
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnAutoFill
        ' 
        btnAutoFill.FlatStyle = FlatStyle.Popup
        btnAutoFill.Font = New Font("Quicksand", 8.25F)
        btnAutoFill.Location = New Point(14, 261)
        btnAutoFill.Margin = New Padding(1)
        btnAutoFill.Name = "btnAutoFill"
        btnAutoFill.Size = New Size(71, 40)
        btnAutoFill.TabIndex = 5
        btnAutoFill.Text = "Auto-Fill"
        btnAutoFill.UseVisualStyleBackColor = True
        ' 
        ' lblXSRFTokenLabel
        ' 
        lblXSRFTokenLabel.AutoSize = True
        lblXSRFTokenLabel.Location = New Point(81, 214)
        lblXSRFTokenLabel.Name = "lblXSRFTokenLabel"
        lblXSRFTokenLabel.Size = New Size(75, 18)
        lblXSRFTokenLabel.TabIndex = 12
        lblXSRFTokenLabel.Text = "XSRF Token:"
        ' 
        ' lblSessionLabel
        ' 
        lblSessionLabel.AutoSize = True
        lblSessionLabel.Location = New Point(36, 167)
        lblSessionLabel.Name = "lblSessionLabel"
        lblSessionLabel.Size = New Size(121, 18)
        lblSessionLabel.TabIndex = 11
        lblSessionLabel.Text = "Osu! Session Cookie:"
        ' 
        ' txtXSRFToken
        ' 
        txtXSRFToken.Location = New Point(10, 232)
        txtXSRFToken.Name = "txtXSRFToken"
        txtXSRFToken.PlaceholderText = "XSRF-TOKEN:""<TOKEN>"""
        txtXSRFToken.Size = New Size(147, 22)
        txtXSRFToken.TabIndex = 10
        ' 
        ' txtSessionToken
        ' 
        txtSessionToken.Location = New Point(10, 185)
        txtSessionToken.Name = "txtSessionToken"
        txtSessionToken.PlaceholderText = "osu_session:""<TOKEN>"""
        txtSessionToken.Size = New Size(148, 22)
        txtSessionToken.TabIndex = 9
        ' 
        ' lblSleepInterval
        ' 
        lblSleepInterval.AutoSize = True
        lblSleepInterval.Location = New Point(143, 72)
        lblSleepInterval.Name = "lblSleepInterval"
        lblSleepInterval.Size = New Size(14, 18)
        lblSleepInterval.TabIndex = 5
        lblSleepInterval.Text = "3"
        lblSleepInterval.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSleepIntervalLabel
        ' 
        lblSleepIntervalLabel.AutoSize = True
        lblSleepIntervalLabel.Location = New Point(59, 71)
        lblSleepIntervalLabel.Name = "lblSleepIntervalLabel"
        lblSleepIntervalLabel.Size = New Size(87, 18)
        lblSleepIntervalLabel.TabIndex = 4
        lblSleepIntervalLabel.Text = "Sleep Interval:"
        lblSleepIntervalLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tbSleepInterval
        ' 
        tbSleepInterval.AutoSize = False
        tbSleepInterval.Location = New Point(10, 89)
        tbSleepInterval.Maximum = 25
        tbSleepInterval.Name = "tbSleepInterval"
        tbSleepInterval.Size = New Size(161, 24)
        tbSleepInterval.TabIndex = 3
        tbSleepInterval.TickStyle = TickStyle.TopLeft
        tbSleepInterval.Value = 3
        ' 
        ' lblForkValue
        ' 
        lblForkValue.AutoSize = True
        lblForkValue.Location = New Point(143, 26)
        lblForkValue.Name = "lblForkValue"
        lblForkValue.Size = New Size(15, 18)
        lblForkValue.TabIndex = 2
        lblForkValue.Text = "0"
        lblForkValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblForkLabel
        ' 
        lblForkLabel.AutoSize = True
        lblForkLabel.Location = New Point(44, 26)
        lblForkLabel.Name = "lblForkLabel"
        lblForkLabel.Size = New Size(102, 18)
        lblForkLabel.TabIndex = 1
        lblForkLabel.Text = "Amount of Forks:"
        ' 
        ' tbForkValue
        ' 
        tbForkValue.AutoSize = False
        tbForkValue.Location = New Point(10, 43)
        tbForkValue.Maximum = 25
        tbForkValue.Name = "tbForkValue"
        tbForkValue.Size = New Size(161, 24)
        tbForkValue.TabIndex = 0
        tbForkValue.TickStyle = TickStyle.TopLeft
        ' 
        ' chkOverwriteExistingFiles
        ' 
        chkOverwriteExistingFiles.AutoSize = True
        chkOverwriteExistingFiles.Location = New Point(15, 533)
        chkOverwriteExistingFiles.Name = "chkOverwriteExistingFiles"
        chkOverwriteExistingFiles.Size = New Size(129, 22)
        chkOverwriteExistingFiles.TabIndex = 13
        chkOverwriteExistingFiles.Text = "Overwrite Existing"
        ttGeneralHover.SetToolTip(chkOverwriteExistingFiles, "Re-downloads and overwrites any archive with the same name, already in the output folder")
        chkOverwriteExistingFiles.UseVisualStyleBackColor = True
        ' 
        ' chkVerboseLogging
        ' 
        chkVerboseLogging.AutoSize = True
        chkVerboseLogging.Location = New Point(15, 511)
        chkVerboseLogging.Name = "chkVerboseLogging"
        chkVerboseLogging.Size = New Size(118, 22)
        chkVerboseLogging.TabIndex = 8
        chkVerboseLogging.Text = "Verbose logging"
        ttGeneralHover.SetToolTip(chkVerboseLogging, "More detailed logs, in case something isn't working and you need to pinpoint where")
        chkVerboseLogging.UseVisualStyleBackColor = True
        ' 
        ' chkNoExtractArchives
        ' 
        chkNoExtractArchives.AutoSize = True
        chkNoExtractArchives.Location = New Point(161, 533)
        chkNoExtractArchives.Name = "chkNoExtractArchives"
        chkNoExtractArchives.Size = New Size(149, 22)
        chkNoExtractArchives.TabIndex = 7
        chkNoExtractArchives.Text = "Don't extract archives"
        ttGeneralHover.SetToolTip(chkNoExtractArchives, "Archives will remain in the download folder and not extracted to the output folder")
        chkNoExtractArchives.UseVisualStyleBackColor = True
        ' 
        ' chkDisregardCache
        ' 
        chkDisregardCache.AutoSize = True
        chkDisregardCache.Location = New Point(161, 511)
        chkDisregardCache.Name = "chkDisregardCache"
        chkDisregardCache.Size = New Size(145, 22)
        chkDisregardCache.TabIndex = 6
        chkDisregardCache.Text = "Disregard cache files"
        ttGeneralHover.SetToolTip(chkDisregardCache, "Ignores any cached songs and re-pulls the list and download locations fresh from the server")
        chkDisregardCache.UseVisualStyleBackColor = True
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {tslBrowser, tslStatusesLabel, tssAuthenticatedValue, tssSep1, tslCacheValue, tslSep2, tslPulledValue, tslSpacer, tspbProgressBar})
        StatusStrip1.Location = New Point(0, 581)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(448, 24)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tslBrowser
        ' 
        tslBrowser.Name = "tslBrowser"
        tslBrowser.Size = New Size(65, 19)
        tslBrowser.Text = "<Browser>"
        ' 
        ' tslStatusesLabel
        ' 
        tslStatusesLabel.Name = "tslStatusesLabel"
        tslStatusesLabel.Size = New Size(53, 19)
        tslStatusesLabel.Text = "Statuses:"
        ' 
        ' tssAuthenticatedValue
        ' 
        tssAuthenticatedValue.BorderStyle = Border3DStyle.Etched
        tssAuthenticatedValue.ForeColor = Color.Red
        tssAuthenticatedValue.Name = "tssAuthenticatedValue"
        tssAuthenticatedValue.Size = New Size(82, 19)
        tssAuthenticatedValue.Text = "Authenticated"
        ' 
        ' tssSep1
        ' 
        tssSep1.Name = "tssSep1"
        tssSep1.Size = New Size(10, 19)
        tssSep1.Text = "|"
        ' 
        ' tslCacheValue
        ' 
        tslCacheValue.ForeColor = Color.Red
        tslCacheValue.Name = "tslCacheValue"
        tslCacheValue.Size = New Size(40, 19)
        tslCacheValue.Text = "Cache"
        ' 
        ' tslSep2
        ' 
        tslSep2.Name = "tslSep2"
        tslSep2.Size = New Size(10, 19)
        tslSep2.Text = "|"
        ' 
        ' tslPulledValue
        ' 
        tslPulledValue.ForeColor = Color.Red
        tslPulledValue.Name = "tslPulledValue"
        tslPulledValue.Size = New Size(40, 19)
        tslPulledValue.Text = "Pulled"
        ' 
        ' tslSpacer
        ' 
        tslSpacer.Name = "tslSpacer"
        tslSpacer.Size = New Size(31, 19)
        tslSpacer.Spring = True
        ' 
        ' tspbProgressBar
        ' 
        tspbProgressBar.Name = "tspbProgressBar"
        tspbProgressBar.Size = New Size(100, 18)
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpSingles)
        TabControl1.Controls.Add(tpPacks)
        TabControl1.Location = New Point(11, 240)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(247, 261)
        TabControl1.TabIndex = 6
        ' 
        ' tpSingles
        ' 
        tpSingles.Controls.Add(chkCatGraveyard)
        tpSingles.Controls.Add(chkCatPersonal)
        tpSingles.Controls.Add(chkCatWorkInProgress)
        tpSingles.Controls.Add(chkCatLeaderBoard)
        tpSingles.Controls.Add(chkCatPending)
        tpSingles.Controls.Add(chkCatQualified)
        tpSingles.Controls.Add(chkCatLoved)
        tpSingles.Controls.Add(chkCatRanked)
        tpSingles.Controls.Add(chkCatFaves)
        tpSingles.Location = New Point(4, 27)
        tpSingles.Name = "tpSingles"
        tpSingles.Padding = New Padding(3)
        tpSingles.Size = New Size(239, 230)
        tpSingles.TabIndex = 0
        tpSingles.Text = "Singles"
        tpSingles.UseVisualStyleBackColor = True
        ' 
        ' chkCatGraveyard
        ' 
        chkCatGraveyard.Appearance = Appearance.Button
        chkCatGraveyard.Font = New Font("Quicksand", 8.25F)
        chkCatGraveyard.ImageKey = "icons8-cemetery-24.png"
        chkCatGraveyard.ImageList = imlCategories
        chkCatGraveyard.Location = New Point(163, 151)
        chkCatGraveyard.Name = "chkCatGraveyard"
        chkCatGraveyard.Size = New Size(70, 62)
        chkCatGraveyard.TabIndex = 13
        chkCatGraveyard.Text = "Grvyrd"
        chkCatGraveyard.TextAlign = ContentAlignment.MiddleCenter
        chkCatGraveyard.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatGraveyard.UseVisualStyleBackColor = True
        ' 
        ' chkCatPersonal
        ' 
        chkCatPersonal.Appearance = Appearance.Button
        chkCatPersonal.Font = New Font("Quicksand", 8.25F)
        chkCatPersonal.ImageKey = "icons8-test-account-24.png"
        chkCatPersonal.ImageList = imlCategories
        chkCatPersonal.Location = New Point(84, 9)
        chkCatPersonal.Name = "chkCatPersonal"
        chkCatPersonal.Size = New Size(70, 62)
        chkCatPersonal.TabIndex = 12
        chkCatPersonal.Text = "Mine"
        chkCatPersonal.TextAlign = ContentAlignment.MiddleCenter
        chkCatPersonal.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatPersonal.UseVisualStyleBackColor = True
        ' 
        ' chkCatWorkInProgress
        ' 
        chkCatWorkInProgress.Appearance = Appearance.Button
        chkCatWorkInProgress.Font = New Font("Quicksand", 8.25F)
        chkCatWorkInProgress.ImageKey = "icons8-in-progress-24.png"
        chkCatWorkInProgress.ImageList = imlCategories
        chkCatWorkInProgress.Location = New Point(83, 151)
        chkCatWorkInProgress.Name = "chkCatWorkInProgress"
        chkCatWorkInProgress.Size = New Size(70, 62)
        chkCatWorkInProgress.TabIndex = 14
        chkCatWorkInProgress.Text = "WIP"
        chkCatWorkInProgress.TextAlign = ContentAlignment.MiddleCenter
        chkCatWorkInProgress.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatWorkInProgress.UseVisualStyleBackColor = True
        ' 
        ' chkCatLeaderBoard
        ' 
        chkCatLeaderBoard.Appearance = Appearance.Button
        chkCatLeaderBoard.Font = New Font("Quicksand", 8.25F)
        chkCatLeaderBoard.ImageKey = "icons8-leaderboard-24.png"
        chkCatLeaderBoard.ImageList = imlCategories
        chkCatLeaderBoard.Location = New Point(5, 80)
        chkCatLeaderBoard.Name = "chkCatLeaderBoard"
        chkCatLeaderBoard.Size = New Size(70, 62)
        chkCatLeaderBoard.TabIndex = 11
        chkCatLeaderBoard.Text = "Ldr. Board"
        chkCatLeaderBoard.TextAlign = ContentAlignment.MiddleCenter
        chkCatLeaderBoard.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatLeaderBoard.UseVisualStyleBackColor = True
        ' 
        ' chkCatPending
        ' 
        chkCatPending.Appearance = Appearance.Button
        chkCatPending.Font = New Font("Quicksand", 8.25F)
        chkCatPending.ImageKey = "icons8-pending-24.png"
        chkCatPending.ImageList = imlCategories
        chkCatPending.Location = New Point(5, 151)
        chkCatPending.Name = "chkCatPending"
        chkCatPending.Size = New Size(70, 62)
        chkCatPending.TabIndex = 15
        chkCatPending.Text = "Pending"
        chkCatPending.TextAlign = ContentAlignment.MiddleCenter
        chkCatPending.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatPending.UseVisualStyleBackColor = True
        ' 
        ' chkCatQualified
        ' 
        chkCatQualified.Appearance = Appearance.Button
        chkCatQualified.Font = New Font("Quicksand", 8.25F)
        chkCatQualified.ImageKey = "icons8-qualified-24.png"
        chkCatQualified.ImageList = imlCategories
        chkCatQualified.Location = New Point(163, 80)
        chkCatQualified.Name = "chkCatQualified"
        chkCatQualified.Size = New Size(70, 62)
        chkCatQualified.TabIndex = 18
        chkCatQualified.Text = "Qualified"
        chkCatQualified.TextAlign = ContentAlignment.MiddleCenter
        chkCatQualified.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatQualified.UseVisualStyleBackColor = True
        ' 
        ' chkCatLoved
        ' 
        chkCatLoved.Appearance = Appearance.Button
        chkCatLoved.Font = New Font("Quicksand", 8.25F)
        chkCatLoved.ImageKey = "icons8-heart-24.png"
        chkCatLoved.ImageList = imlCategories
        chkCatLoved.Location = New Point(163, 9)
        chkCatLoved.Name = "chkCatLoved"
        chkCatLoved.Size = New Size(70, 62)
        chkCatLoved.TabIndex = 17
        chkCatLoved.Text = "Loved"
        chkCatLoved.TextAlign = ContentAlignment.MiddleCenter
        chkCatLoved.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatLoved.UseVisualStyleBackColor = True
        ' 
        ' chkCatRanked
        ' 
        chkCatRanked.Appearance = Appearance.Button
        chkCatRanked.Font = New Font("Quicksand", 8.25F)
        chkCatRanked.ImageKey = "icons8-leaderboard-24.png"
        chkCatRanked.ImageList = imlCategories
        chkCatRanked.Location = New Point(83, 80)
        chkCatRanked.Name = "chkCatRanked"
        chkCatRanked.Size = New Size(70, 62)
        chkCatRanked.TabIndex = 19
        chkCatRanked.Text = "Ranked"
        chkCatRanked.TextAlign = ContentAlignment.MiddleCenter
        chkCatRanked.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatRanked.UseVisualStyleBackColor = True
        ' 
        ' chkCatFaves
        ' 
        chkCatFaves.Appearance = Appearance.Button
        chkCatFaves.Font = New Font("Quicksand", 8.25F)
        chkCatFaves.ImageKey = "icons8-favorite-24.png"
        chkCatFaves.ImageList = imlCategories
        chkCatFaves.Location = New Point(5, 9)
        chkCatFaves.Name = "chkCatFaves"
        chkCatFaves.Size = New Size(70, 62)
        chkCatFaves.TabIndex = 16
        chkCatFaves.Text = "Faves"
        chkCatFaves.TextAlign = ContentAlignment.MiddleCenter
        chkCatFaves.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatFaves.UseVisualStyleBackColor = True
        ' 
        ' tpPacks
        ' 
        tpPacks.Controls.Add(CheckBox1)
        tpPacks.Controls.Add(chkCatAny)
        tpPacks.Location = New Point(4, 24)
        tpPacks.Name = "tpPacks"
        tpPacks.Padding = New Padding(3)
        tpPacks.Size = New Size(239, 233)
        tpPacks.TabIndex = 1
        tpPacks.Text = "Packs"
        tpPacks.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.Font = New Font("Quicksand", 8.25F)
        CheckBox1.ImageKey = "icons8-edit-none.png"
        CheckBox1.ImageList = imlCategories
        CheckBox1.Location = New Point(124, 9)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(97, 53)
        CheckBox1.TabIndex = 23
        CheckBox1.Text = "No Packs"
        CheckBox1.TextAlign = ContentAlignment.MiddleCenter
        CheckBox1.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' chkCatAny
        ' 
        chkCatAny.Appearance = Appearance.Button
        chkCatAny.Font = New Font("Quicksand", 8.25F)
        chkCatAny.ImageKey = "icons8-all-24.png"
        chkCatAny.ImageList = imlCategories
        chkCatAny.Location = New Point(21, 9)
        chkCatAny.Name = "chkCatAny"
        chkCatAny.Size = New Size(97, 53)
        chkCatAny.TabIndex = 22
        chkCatAny.Text = "All Packs"
        chkCatAny.TextAlign = ContentAlignment.MiddleCenter
        chkCatAny.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatAny.UseVisualStyleBackColor = True
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(448, 605)
        Controls.Add(TabControl1)
        Controls.Add(StatusStrip1)
        Controls.Add(grpConfiguration)
        Controls.Add(grpModes)
        Controls.Add(pbLogo)
        Controls.Add(msMainMenu)
        Controls.Add(chkOverwriteExistingFiles)
        Controls.Add(chkVerboseLogging)
        Controls.Add(chkDisregardCache)
        Controls.Add(chkNoExtractArchives)
        Font = New Font("Quicksand", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = msMainMenu
        Margin = New Padding(3, 4, 3, 4)
        Name = "FrmMain"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Osu!Scraper"
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        grpModes.ResumeLayout(False)
        grpModes.PerformLayout()
        msMainMenu.ResumeLayout(False)
        msMainMenu.PerformLayout()
        grpConfiguration.ResumeLayout(False)
        grpConfiguration.PerformLayout()
        CType(tbBatchSize, ComponentModel.ISupportInitialize).EndInit()
        CType(tbSleepInterval, ComponentModel.ISupportInitialize).EndInit()
        CType(tbForkValue, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tpSingles.ResumeLayout(False)
        tpPacks.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents grpModes As GroupBox
    Friend WithEvents chkModeOsu As CheckBox
    Friend WithEvents chkModeTaiko As CheckBox
    Friend WithEvents chkModeMania As CheckBox
    Friend WithEvents chkModeCatch As CheckBox
    Friend WithEvents msMainMenu As MenuStrip
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents tsmOptions As ToolStripMenuItem
    Friend WithEvents tsmHelp As ToolStripMenuItem
    Friend WithEvents tsmListings As ToolStripMenuItem
    Friend WithEvents imlModes As ImageList
    Friend WithEvents imlCategories As ImageList
    Friend WithEvents grpConfiguration As GroupBox
    Friend WithEvents lblForkLabel As Label
    Friend WithEvents tbForkValue As TrackBar
    Friend WithEvents OpenCacheFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReloadCacheFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PullFromServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSleepInterval As Label
    Friend WithEvents lblSleepIntervalLabel As Label
    Friend WithEvents tbSleepInterval As TrackBar
    Friend WithEvents lblForkValue As Label
    Friend WithEvents chkNoExtractArchives As CheckBox
    Friend WithEvents chkDisregardCache As CheckBox
    Friend WithEvents lblXSRFTokenLabel As Label
    Friend WithEvents lblSessionLabel As Label
    Friend WithEvents txtXSRFToken As TextBox
    Friend WithEvents chkVerboseLogging As CheckBox
    Friend WithEvents chkOverwriteExistingFiles As CheckBox
    Friend WithEvents ttGeneralHover As ToolTip
    Friend WithEvents btnAutoFill As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnOpenListings As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslStatusesLabel As ToolStripStatusLabel
    Friend WithEvents tssAuthenticatedValue As ToolStripStatusLabel
    Friend WithEvents tssSep1 As ToolStripStatusLabel
    Friend WithEvents tslCacheValue As ToolStripStatusLabel
    Friend WithEvents tslPulledValue As ToolStripStatusLabel
    Friend WithEvents tslSep2 As ToolStripStatusLabel
    Friend WithEvents tslSpacer As ToolStripStatusLabel
    Friend WithEvents tspbProgressBar As ToolStripProgressBar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpSingles As TabPage
    Friend WithEvents tpPacks As TabPage
    Friend WithEvents chkCatGraveyard As CheckBox
    Friend WithEvents chkCatPersonal As CheckBox
    Friend WithEvents chkCatWorkInProgress As CheckBox
    Friend WithEvents chkCatLeaderBoard As CheckBox
    Friend WithEvents chkCatPending As CheckBox
    Friend WithEvents chkCatQualified As CheckBox
    Friend WithEvents chkCatLoved As CheckBox
    Friend WithEvents chkCatRanked As CheckBox
    Friend WithEvents chkCatFaves As CheckBox
    Friend WithEvents lblBatchSizeValue As Label
    Friend WithEvents lblBatchSizeLabel As Label
    Friend WithEvents tbBatchSize As TrackBar
    Friend WithEvents tslBrowser As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents chkCatAny As CheckBox
    Friend WithEvents txtSessionToken As TextBox
End Class
