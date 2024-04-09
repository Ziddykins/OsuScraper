<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TreeNode1 As TreeNode = New TreeNode("Packs")
        Dim TreeNode2 As TreeNode = New TreeNode("Singles")
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
        tsmListings = New ToolStripMenuItem()
        UpdateToolStripMenuItem = New ToolStripMenuItem()
        UpdateToolStripMenuItem1 = New ToolStripMenuItem()
        ReloadCacheFileToolStripMenuItem = New ToolStripMenuItem()
        PullFromServerToolStripMenuItem = New ToolStripMenuItem()
        tsmOptions = New ToolStripMenuItem()
        tsmHelp = New ToolStripMenuItem()
        grpConfiguration = New GroupBox()
        lblBatchSizeValue = New Label()
        lblBatchSizeLabel = New Label()
        tbBatchSize = New TrackBar()
        lblSleepInterval = New Label()
        lblSleepIntervalLabel = New Label()
        tbSleepInterval = New TrackBar()
        lblForkValue = New Label()
        lblForkLabel = New Label()
        tbForkValue = New TrackBar()
        chkOverwriteExistingFiles = New CheckBox()
        btnAutoFill = New Button()
        lblXSRFTokenLabel = New Label()
        lblSessionLabel = New Label()
        txtXSRFToken = New TextBox()
        txtSessionToken = New TextBox()
        chkVerboseLogging = New CheckBox()
        chkNoExtractArchives = New CheckBox()
        chkDisregardCache = New CheckBox()
        ttGeneralHover = New ToolTip(components)
        StatusStrip1 = New StatusStrip()
        tslBrowser = New ToolStripStatusLabel()
        tslSep3 = New ToolStripStatusLabel()
        tssAuthenticatedValue = New ToolStripStatusLabel()
        tssSep1 = New ToolStripStatusLabel()
        tslCacheValue = New ToolStripStatusLabel()
        tslSep2 = New ToolStripStatusLabel()
        tslPulledValue = New ToolStripStatusLabel()
        tslSpacer = New ToolStripStatusLabel()
        tspbProgressBar = New ToolStripProgressBar()
        ilBrowsers = New ImageList(components)
        tvListings = New TreeView()
        ilLists = New ImageList(components)
        Button1 = New Button()
        grpSession = New GroupBox()
        grpOptions = New GroupBox()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        GroupBox2 = New GroupBox()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        cbFilter = New ComboBox()
        tpSingles = New TabPage()
        CheckBox4 = New CheckBox()
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
        chkPackAlArt = New CheckBox()
        chkPackTheme = New CheckBox()
        chkPackFeatured = New CheckBox()
        chkPackTournament = New CheckBox()
        chkPackLoved = New CheckBox()
        chkPackSpotlights = New CheckBox()
        chkPackStandard = New CheckBox()
        chkCatAny = New CheckBox()
        TabControl1 = New TabControl()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        grpModes.SuspendLayout()
        msMainMenu.SuspendLayout()
        grpConfiguration.SuspendLayout()
        CType(tbBatchSize, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbSleepInterval, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbForkValue, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        grpSession.SuspendLayout()
        grpOptions.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        tpSingles.SuspendLayout()
        tpPacks.SuspendLayout()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Top
        pbLogo.Image = My.Resources.Resources.os_logo
        pbLogo.Location = New Point(0, 24)
        pbLogo.Margin = New Padding(3, 4, 3, 4)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(901, 108)
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
        grpModes.Location = New Point(194, 139)
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
        chkModeTaiko.ImageKey = "Taiko.png"
        chkModeTaiko.ImageList = imlModes
        chkModeTaiko.Location = New Point(191, 21)
        chkModeTaiko.Margin = New Padding(3, 4, 3, 4)
        chkModeTaiko.Name = "chkModeTaiko"
        chkModeTaiko.Size = New Size(50, 63)
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
        chkModeMania.ImageKey = "Mania.png"
        chkModeMania.ImageList = imlModes
        chkModeMania.Location = New Point(133, 21)
        chkModeMania.Margin = New Padding(3, 4, 3, 4)
        chkModeMania.Name = "chkModeMania"
        chkModeMania.Size = New Size(50, 63)
        chkModeMania.TabIndex = 2
        chkModeMania.Text = "Mania"
        chkModeMania.TextAlign = ContentAlignment.MiddleCenter
        chkModeMania.TextImageRelation = TextImageRelation.ImageAboveText
        chkModeMania.UseVisualStyleBackColor = True
        ' 
        ' chkModeCatch
        ' 
        chkModeCatch.Appearance = Appearance.Button
        chkModeCatch.ImageKey = "FruitDrop.png"
        chkModeCatch.ImageList = imlModes
        chkModeCatch.Location = New Point(75, 21)
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
        chkModeOsu.ImageKey = "Osu.png"
        chkModeOsu.ImageList = imlModes
        chkModeOsu.Location = New Point(17, 21)
        chkModeOsu.Margin = New Padding(3, 4, 3, 4)
        chkModeOsu.Name = "chkModeOsu"
        chkModeOsu.Size = New Size(50, 63)
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
        msMainMenu.Size = New Size(901, 24)
        msMainMenu.TabIndex = 3
        msMainMenu.Text = "MenuStrip1"
        ' 
        ' tsmFile
        ' 
        tsmFile.DropDownItems.AddRange(New ToolStripItem() {OpenCacheFileToolStripMenuItem, ExitToolStripMenuItem})
        tsmFile.Name = "tsmFile"
        tsmFile.Size = New Size(37, 20)
        tsmFile.Text = "&File"
        ' 
        ' OpenCacheFileToolStripMenuItem
        ' 
        OpenCacheFileToolStripMenuItem.Name = "OpenCacheFileToolStripMenuItem"
        OpenCacheFileToolStripMenuItem.Size = New Size(156, 22)
        OpenCacheFileToolStripMenuItem.Text = "Op&en cache file"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(156, 22)
        ExitToolStripMenuItem.Text = "&Exit"
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
        grpConfiguration.Controls.Add(lblBatchSizeValue)
        grpConfiguration.Controls.Add(lblBatchSizeLabel)
        grpConfiguration.Controls.Add(tbBatchSize)
        grpConfiguration.Controls.Add(lblSleepInterval)
        grpConfiguration.Controls.Add(lblSleepIntervalLabel)
        grpConfiguration.Controls.Add(tbSleepInterval)
        grpConfiguration.Controls.Add(lblForkValue)
        grpConfiguration.Controls.Add(lblForkLabel)
        grpConfiguration.Controls.Add(tbForkValue)
        grpConfiguration.Location = New Point(12, 139)
        grpConfiguration.Name = "grpConfiguration"
        grpConfiguration.Size = New Size(176, 181)
        grpConfiguration.TabIndex = 4
        grpConfiguration.TabStop = False
        grpConfiguration.Text = "Configuration"
        ' 
        ' lblBatchSizeValue
        ' 
        lblBatchSizeValue.AutoSize = True
        lblBatchSizeValue.Location = New Point(141, 117)
        lblBatchSizeValue.Name = "lblBatchSizeValue"
        lblBatchSizeValue.Size = New Size(14, 18)
        lblBatchSizeValue.TabIndex = 18
        lblBatchSizeValue.Text = "3"
        lblBatchSizeValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblBatchSizeLabel
        ' 
        lblBatchSizeLabel.AutoSize = True
        lblBatchSizeLabel.Location = New Point(76, 116)
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
        tbBatchSize.Location = New Point(8, 134)
        tbBatchSize.Maximum = 1000
        tbBatchSize.Name = "tbBatchSize"
        tbBatchSize.Size = New Size(161, 24)
        tbBatchSize.SmallChange = 25
        tbBatchSize.TabIndex = 16
        tbBatchSize.TickStyle = TickStyle.TopLeft
        tbBatchSize.Value = 25
        ' 
        ' lblSleepInterval
        ' 
        lblSleepInterval.AutoSize = True
        lblSleepInterval.Location = New Point(141, 72)
        lblSleepInterval.Name = "lblSleepInterval"
        lblSleepInterval.Size = New Size(14, 18)
        lblSleepInterval.TabIndex = 5
        lblSleepInterval.Text = "3"
        lblSleepInterval.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSleepIntervalLabel
        ' 
        lblSleepIntervalLabel.AutoSize = True
        lblSleepIntervalLabel.Location = New Point(57, 71)
        lblSleepIntervalLabel.Name = "lblSleepIntervalLabel"
        lblSleepIntervalLabel.Size = New Size(87, 18)
        lblSleepIntervalLabel.TabIndex = 4
        lblSleepIntervalLabel.Text = "Sleep Interval:"
        lblSleepIntervalLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' tbSleepInterval
        ' 
        tbSleepInterval.AutoSize = False
        tbSleepInterval.Location = New Point(8, 89)
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
        lblForkValue.Location = New Point(141, 26)
        lblForkValue.Name = "lblForkValue"
        lblForkValue.Size = New Size(15, 18)
        lblForkValue.TabIndex = 2
        lblForkValue.Text = "0"
        lblForkValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblForkLabel
        ' 
        lblForkLabel.AutoSize = True
        lblForkLabel.Location = New Point(42, 26)
        lblForkLabel.Name = "lblForkLabel"
        lblForkLabel.Size = New Size(102, 18)
        lblForkLabel.TabIndex = 1
        lblForkLabel.Text = "Amount of Forks:"
        ' 
        ' tbForkValue
        ' 
        tbForkValue.AutoSize = False
        tbForkValue.Location = New Point(8, 43)
        tbForkValue.Maximum = 25
        tbForkValue.Name = "tbForkValue"
        tbForkValue.Size = New Size(161, 24)
        tbForkValue.TabIndex = 0
        tbForkValue.TickStyle = TickStyle.TopLeft
        ' 
        ' chkOverwriteExistingFiles
        ' 
        chkOverwriteExistingFiles.AutoSize = True
        chkOverwriteExistingFiles.Location = New Point(14, 93)
        chkOverwriteExistingFiles.Name = "chkOverwriteExistingFiles"
        chkOverwriteExistingFiles.Size = New Size(129, 22)
        chkOverwriteExistingFiles.TabIndex = 13
        chkOverwriteExistingFiles.Text = "Overwrite Existing"
        ttGeneralHover.SetToolTip(chkOverwriteExistingFiles, "Re-downloads and overwrites any archive with the same name, already in the output folder")
        chkOverwriteExistingFiles.UseVisualStyleBackColor = True
        ' 
        ' btnAutoFill
        ' 
        btnAutoFill.AutoSize = True
        btnAutoFill.FlatStyle = FlatStyle.Popup
        btnAutoFill.Font = New Font("Quicksand", 9F)
        btnAutoFill.Image = My.Resources.Resources.icons8_fill_color_24
        btnAutoFill.Location = New Point(13, 130)
        btnAutoFill.Name = "btnAutoFill"
        btnAutoFill.Size = New Size(150, 40)
        btnAutoFill.TabIndex = 5
        btnAutoFill.Text = "Auto-Fill"
        btnAutoFill.TextAlign = ContentAlignment.MiddleRight
        btnAutoFill.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAutoFill.UseVisualStyleBackColor = True
        ' 
        ' lblXSRFTokenLabel
        ' 
        lblXSRFTokenLabel.AutoSize = True
        lblXSRFTokenLabel.Location = New Point(86, 72)
        lblXSRFTokenLabel.Name = "lblXSRFTokenLabel"
        lblXSRFTokenLabel.Size = New Size(75, 18)
        lblXSRFTokenLabel.TabIndex = 12
        lblXSRFTokenLabel.Text = "XSRF Token:"
        ' 
        ' lblSessionLabel
        ' 
        lblSessionLabel.AutoSize = True
        lblSessionLabel.Location = New Point(40, 16)
        lblSessionLabel.Name = "lblSessionLabel"
        lblSessionLabel.Size = New Size(121, 18)
        lblSessionLabel.TabIndex = 11
        lblSessionLabel.Text = "Osu! Session Cookie:"
        ' 
        ' txtXSRFToken
        ' 
        txtXSRFToken.Location = New Point(14, 93)
        txtXSRFToken.Name = "txtXSRFToken"
        txtXSRFToken.PlaceholderText = "XSRF-TOKEN:""<TOKEN>"""
        txtXSRFToken.Size = New Size(147, 22)
        txtXSRFToken.TabIndex = 10
        ' 
        ' txtSessionToken
        ' 
        txtSessionToken.Location = New Point(13, 37)
        txtSessionToken.Name = "txtSessionToken"
        txtSessionToken.PlaceholderText = "osu_session:""<TOKEN>"""
        txtSessionToken.Size = New Size(148, 22)
        txtSessionToken.TabIndex = 9
        ' 
        ' chkVerboseLogging
        ' 
        chkVerboseLogging.AutoSize = True
        chkVerboseLogging.Location = New Point(14, 71)
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
        chkNoExtractArchives.Location = New Point(14, 49)
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
        chkDisregardCache.Location = New Point(14, 27)
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
        StatusStrip1.Items.AddRange(New ToolStripItem() {tslBrowser, tslSep3, tssAuthenticatedValue, tssSep1, tslCacheValue, tslSep2, tslPulledValue, tslSpacer, tspbProgressBar})
        StatusStrip1.Location = New Point(0, 646)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(901, 29)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tslBrowser
        ' 
        tslBrowser.Image = My.Resources.Resources.icons8_browser_24
        tslBrowser.Margin = New Padding(5, 0, 0, 2)
        tslBrowser.Name = "tslBrowser"
        tslBrowser.Size = New Size(24, 27)
        ' 
        ' tslSep3
        ' 
        tslSep3.Name = "tslSep3"
        tslSep3.Size = New Size(10, 24)
        tslSep3.Text = "|"
        ' 
        ' tssAuthenticatedValue
        ' 
        tssAuthenticatedValue.BorderStyle = Border3DStyle.Etched
        tssAuthenticatedValue.ForeColor = Color.Red
        tssAuthenticatedValue.Image = My.Resources.Resources.icons8_lock_24_red
        tssAuthenticatedValue.Name = "tssAuthenticatedValue"
        tssAuthenticatedValue.Size = New Size(24, 24)
        ' 
        ' tssSep1
        ' 
        tssSep1.Name = "tssSep1"
        tssSep1.Size = New Size(10, 24)
        tssSep1.Text = "|"
        ' 
        ' tslCacheValue
        ' 
        tslCacheValue.ForeColor = Color.Red
        tslCacheValue.Image = My.Resources.Resources.icons8_cache_24_red
        tslCacheValue.Name = "tslCacheValue"
        tslCacheValue.Size = New Size(24, 24)
        ' 
        ' tslSep2
        ' 
        tslSep2.Name = "tslSep2"
        tslSep2.Size = New Size(10, 24)
        tslSep2.Text = "|"
        ' 
        ' tslPulledValue
        ' 
        tslPulledValue.ForeColor = Color.Red
        tslPulledValue.Image = My.Resources.Resources.icons8_update_24_red
        tslPulledValue.Name = "tslPulledValue"
        tslPulledValue.Size = New Size(24, 24)
        ' 
        ' tslSpacer
        ' 
        tslSpacer.Name = "tslSpacer"
        tslSpacer.Size = New Size(653, 24)
        tslSpacer.Spring = True
        ' 
        ' tspbProgressBar
        ' 
        tspbProgressBar.Name = "tspbProgressBar"
        tspbProgressBar.Size = New Size(100, 23)
        ' 
        ' ilBrowsers
        ' 
        ilBrowsers.ColorDepth = ColorDepth.Depth32Bit
        ilBrowsers.ImageSize = New Size(16, 16)
        ilBrowsers.TransparentColor = Color.Transparent
        ' 
        ' tvListings
        ' 
        tvListings.ImageIndex = 0
        tvListings.ImageList = ilLists
        tvListings.Location = New Point(457, 177)
        tvListings.Name = "tvListings"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "tvnPacks"
        TreeNode1.Text = "Packs"
        TreeNode2.Name = "tvnSingles"
        TreeNode2.Text = "Singles"
        tvListings.Nodes.AddRange(New TreeNode() {TreeNode1, TreeNode2})
        tvListings.SelectedImageIndex = 0
        tvListings.Size = New Size(306, 462)
        tvListings.TabIndex = 7
        ' 
        ' ilLists
        ' 
        ilLists.ColorDepth = ColorDepth.Depth32Bit
        ilLists.ImageStream = CType(resources.GetObject("ilLists.ImageStream"), ImageListStreamer)
        ilLists.TransparentColor = Color.Transparent
        ilLists.Images.SetKeyName(0, "icons8-one-page-16.png")
        ilLists.Images.SetKeyName(1, "icons8-package-16.png")
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 32)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 23)
        Button1.TabIndex = 8
        Button1.Text = "Pull Selected"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' grpSession
        ' 
        grpSession.Controls.Add(txtSessionToken)
        grpSession.Controls.Add(txtXSRFToken)
        grpSession.Controls.Add(lblSessionLabel)
        grpSession.Controls.Add(btnAutoFill)
        grpSession.Controls.Add(lblXSRFTokenLabel)
        grpSession.Location = New Point(12, 326)
        grpSession.Name = "grpSession"
        grpSession.Size = New Size(176, 184)
        grpSession.TabIndex = 19
        grpSession.TabStop = False
        grpSession.Text = "Session"
        ' 
        ' grpOptions
        ' 
        grpOptions.Controls.Add(chkDisregardCache)
        grpOptions.Controls.Add(chkNoExtractArchives)
        grpOptions.Controls.Add(chkVerboseLogging)
        grpOptions.Controls.Add(chkOverwriteExistingFiles)
        grpOptions.Location = New Point(12, 516)
        grpOptions.Name = "grpOptions"
        grpOptions.Size = New Size(176, 123)
        grpOptions.TabIndex = 20
        grpOptions.TabStop = False
        grpOptions.Text = "Options"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(769, 139)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(132, 181)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "Listings"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(14, 125)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 23)
        Button4.TabIndex = 11
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(14, 94)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 23)
        Button3.TabIndex = 10
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(14, 63)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 23)
        Button2.TabIndex = 9
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Location = New Point(769, 329)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(132, 310)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Downloads"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(15, 128)
        Button5.Name = "Button5"
        Button5.Size = New Size(105, 23)
        Button5.TabIndex = 15
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(15, 97)
        Button6.Name = "Button6"
        Button6.Size = New Size(105, 23)
        Button6.TabIndex = 14
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(15, 66)
        Button7.Name = "Button7"
        Button7.Size = New Size(105, 23)
        Button7.TabIndex = 13
        Button7.Text = "Button7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(15, 35)
        Button8.Name = "Button8"
        Button8.Size = New Size(105, 23)
        Button8.TabIndex = 12
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' cbFilter
        ' 
        cbFilter.AutoCompleteMode = AutoCompleteMode.Suggest
        cbFilter.AutoCompleteSource = AutoCompleteSource.ListItems
        cbFilter.FormattingEnabled = True
        cbFilter.Location = New Point(458, 145)
        cbFilter.MaxDropDownItems = 15
        cbFilter.Name = "cbFilter"
        cbFilter.Size = New Size(305, 26)
        cbFilter.TabIndex = 23
        ' 
        ' tpSingles
        ' 
        tpSingles.Controls.Add(CheckBox4)
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
        tpSingles.Size = New Size(229, 301)
        tpSingles.TabIndex = 1
        tpSingles.Text = "Singles"
        tpSingles.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Appearance = Appearance.Button
        CheckBox4.BackColor = SystemColors.Control
        CheckBox4.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CheckBox4.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        CheckBox4.FlatStyle = FlatStyle.Flat
        CheckBox4.Font = New Font("Quicksand", 8.25F)
        CheckBox4.ImageKey = "icons8-all-24.png"
        CheckBox4.ImageList = imlCategories
        CheckBox4.Location = New Point(9, 6)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(210, 45)
        CheckBox4.TabIndex = 29
        CheckBox4.Text = "All Packs"
        CheckBox4.TextAlign = ContentAlignment.MiddleRight
        CheckBox4.TextImageRelation = TextImageRelation.ImageBeforeText
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' chkCatGraveyard
        ' 
        chkCatGraveyard.Appearance = Appearance.Button
        chkCatGraveyard.BackColor = SystemColors.Control
        chkCatGraveyard.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatGraveyard.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatGraveyard.FlatStyle = FlatStyle.Flat
        chkCatGraveyard.Font = New Font("Quicksand", 8.25F)
        chkCatGraveyard.ImageKey = "icons8-cemetery-24.png"
        chkCatGraveyard.ImageList = imlCategories
        chkCatGraveyard.Location = New Point(149, 173)
        chkCatGraveyard.Name = "chkCatGraveyard"
        chkCatGraveyard.Size = New Size(70, 62)
        chkCatGraveyard.TabIndex = 22
        chkCatGraveyard.Text = "Grvyrd"
        chkCatGraveyard.TextAlign = ContentAlignment.MiddleCenter
        chkCatGraveyard.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatGraveyard.UseVisualStyleBackColor = False
        ' 
        ' chkCatPersonal
        ' 
        chkCatPersonal.Appearance = Appearance.Button
        chkCatPersonal.BackColor = SystemColors.Control
        chkCatPersonal.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatPersonal.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatPersonal.FlatStyle = FlatStyle.Flat
        chkCatPersonal.Font = New Font("Quicksand", 8.25F)
        chkCatPersonal.ImageKey = "icons8-test-account-24.png"
        chkCatPersonal.ImageList = imlCategories
        chkCatPersonal.Location = New Point(79, 49)
        chkCatPersonal.Name = "chkCatPersonal"
        chkCatPersonal.Size = New Size(70, 62)
        chkCatPersonal.TabIndex = 21
        chkCatPersonal.Text = "Mine"
        chkCatPersonal.TextAlign = ContentAlignment.MiddleCenter
        chkCatPersonal.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatPersonal.UseVisualStyleBackColor = False
        ' 
        ' chkCatWorkInProgress
        ' 
        chkCatWorkInProgress.Appearance = Appearance.Button
        chkCatWorkInProgress.BackColor = SystemColors.Control
        chkCatWorkInProgress.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatWorkInProgress.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatWorkInProgress.FlatStyle = FlatStyle.Flat
        chkCatWorkInProgress.Font = New Font("Quicksand", 8.25F)
        chkCatWorkInProgress.ImageKey = "icons8-in-progress-24.png"
        chkCatWorkInProgress.ImageList = imlCategories
        chkCatWorkInProgress.Location = New Point(79, 173)
        chkCatWorkInProgress.Name = "chkCatWorkInProgress"
        chkCatWorkInProgress.Size = New Size(70, 62)
        chkCatWorkInProgress.TabIndex = 23
        chkCatWorkInProgress.Text = "WIP"
        chkCatWorkInProgress.TextAlign = ContentAlignment.MiddleCenter
        chkCatWorkInProgress.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatWorkInProgress.UseVisualStyleBackColor = False
        ' 
        ' chkCatLeaderBoard
        ' 
        chkCatLeaderBoard.Appearance = Appearance.Button
        chkCatLeaderBoard.BackColor = SystemColors.Control
        chkCatLeaderBoard.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatLeaderBoard.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatLeaderBoard.FlatStyle = FlatStyle.Flat
        chkCatLeaderBoard.Font = New Font("Quicksand", 8.25F)
        chkCatLeaderBoard.ImageKey = "icons8-leaderboard-24.png"
        chkCatLeaderBoard.ImageList = imlCategories
        chkCatLeaderBoard.Location = New Point(9, 111)
        chkCatLeaderBoard.Name = "chkCatLeaderBoard"
        chkCatLeaderBoard.Size = New Size(70, 62)
        chkCatLeaderBoard.TabIndex = 20
        chkCatLeaderBoard.Text = "Ldr. Board"
        chkCatLeaderBoard.TextAlign = ContentAlignment.MiddleCenter
        chkCatLeaderBoard.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatLeaderBoard.UseVisualStyleBackColor = False
        ' 
        ' chkCatPending
        ' 
        chkCatPending.Appearance = Appearance.Button
        chkCatPending.BackColor = SystemColors.Control
        chkCatPending.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatPending.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatPending.FlatStyle = FlatStyle.Flat
        chkCatPending.Font = New Font("Quicksand", 8.25F)
        chkCatPending.ImageKey = "icons8-pending-24.png"
        chkCatPending.ImageList = imlCategories
        chkCatPending.Location = New Point(9, 173)
        chkCatPending.Name = "chkCatPending"
        chkCatPending.Size = New Size(70, 62)
        chkCatPending.TabIndex = 24
        chkCatPending.Text = "Pending"
        chkCatPending.TextAlign = ContentAlignment.MiddleCenter
        chkCatPending.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatPending.UseVisualStyleBackColor = False
        ' 
        ' chkCatQualified
        ' 
        chkCatQualified.Appearance = Appearance.Button
        chkCatQualified.BackColor = SystemColors.Control
        chkCatQualified.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatQualified.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatQualified.FlatStyle = FlatStyle.Flat
        chkCatQualified.Font = New Font("Quicksand", 8.25F)
        chkCatQualified.ImageKey = "icons8-qualified-24.png"
        chkCatQualified.ImageList = imlCategories
        chkCatQualified.Location = New Point(149, 111)
        chkCatQualified.Name = "chkCatQualified"
        chkCatQualified.Size = New Size(70, 62)
        chkCatQualified.TabIndex = 27
        chkCatQualified.Text = "Qualified"
        chkCatQualified.TextAlign = ContentAlignment.MiddleCenter
        chkCatQualified.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatQualified.UseVisualStyleBackColor = False
        ' 
        ' chkCatLoved
        ' 
        chkCatLoved.Appearance = Appearance.Button
        chkCatLoved.BackColor = SystemColors.Control
        chkCatLoved.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatLoved.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatLoved.FlatStyle = FlatStyle.Flat
        chkCatLoved.Font = New Font("Quicksand", 8.25F)
        chkCatLoved.ImageKey = "icons8-heart-24.png"
        chkCatLoved.ImageList = imlCategories
        chkCatLoved.Location = New Point(149, 49)
        chkCatLoved.Name = "chkCatLoved"
        chkCatLoved.Size = New Size(70, 62)
        chkCatLoved.TabIndex = 26
        chkCatLoved.Text = "Loved"
        chkCatLoved.TextAlign = ContentAlignment.MiddleCenter
        chkCatLoved.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatLoved.UseVisualStyleBackColor = False
        ' 
        ' chkCatRanked
        ' 
        chkCatRanked.Appearance = Appearance.Button
        chkCatRanked.BackColor = SystemColors.Control
        chkCatRanked.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatRanked.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatRanked.FlatStyle = FlatStyle.Flat
        chkCatRanked.Font = New Font("Quicksand", 8.25F)
        chkCatRanked.ImageKey = "icons8-leaderboard-24.png"
        chkCatRanked.ImageList = imlCategories
        chkCatRanked.Location = New Point(79, 111)
        chkCatRanked.Name = "chkCatRanked"
        chkCatRanked.Size = New Size(70, 62)
        chkCatRanked.TabIndex = 28
        chkCatRanked.Text = "Ranked"
        chkCatRanked.TextAlign = ContentAlignment.MiddleCenter
        chkCatRanked.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatRanked.UseVisualStyleBackColor = False
        ' 
        ' chkCatFaves
        ' 
        chkCatFaves.Appearance = Appearance.Button
        chkCatFaves.BackColor = SystemColors.Control
        chkCatFaves.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkCatFaves.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkCatFaves.FlatStyle = FlatStyle.Flat
        chkCatFaves.Font = New Font("Quicksand", 8.25F)
        chkCatFaves.ImageKey = "icons8-favorite-24.png"
        chkCatFaves.ImageList = imlCategories
        chkCatFaves.Location = New Point(9, 49)
        chkCatFaves.Name = "chkCatFaves"
        chkCatFaves.Size = New Size(70, 62)
        chkCatFaves.TabIndex = 25
        chkCatFaves.Text = "Faves"
        chkCatFaves.TextAlign = ContentAlignment.MiddleCenter
        chkCatFaves.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatFaves.UseVisualStyleBackColor = False
        ' 
        ' tpPacks
        ' 
        tpPacks.Controls.Add(chkPackAlArt)
        tpPacks.Controls.Add(chkPackTheme)
        tpPacks.Controls.Add(chkPackFeatured)
        tpPacks.Controls.Add(chkPackTournament)
        tpPacks.Controls.Add(chkPackLoved)
        tpPacks.Controls.Add(chkPackSpotlights)
        tpPacks.Controls.Add(chkPackStandard)
        tpPacks.Controls.Add(chkCatAny)
        tpPacks.Location = New Point(4, 27)
        tpPacks.Name = "tpPacks"
        tpPacks.Padding = New Padding(3)
        tpPacks.Size = New Size(229, 301)
        tpPacks.TabIndex = 0
        tpPacks.Text = "Packs"
        tpPacks.UseVisualStyleBackColor = True
        ' 
        ' chkPackAlArt
        ' 
        chkPackAlArt.Appearance = Appearance.Button
        chkPackAlArt.Font = New Font("Quicksand", 8.25F)
        chkPackAlArt.ImageKey = "icons8-heart-24.png"
        chkPackAlArt.ImageList = imlCategories
        chkPackAlArt.Location = New Point(9, 214)
        chkPackAlArt.Name = "chkPackAlArt"
        chkPackAlArt.Size = New Size(82, 62)
        chkPackAlArt.TabIndex = 33
        chkPackAlArt.Text = "Album/Artist"
        chkPackAlArt.TextAlign = ContentAlignment.MiddleCenter
        chkPackAlArt.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackAlArt.UseVisualStyleBackColor = True
        ' 
        ' chkPackTheme
        ' 
        chkPackTheme.Appearance = Appearance.Button
        chkPackTheme.Font = New Font("Quicksand", 8.25F)
        chkPackTheme.ImageKey = "icons8-heart-24.png"
        chkPackTheme.ImageList = imlCategories
        chkPackTheme.Location = New Point(154, 146)
        chkPackTheme.Name = "chkPackTheme"
        chkPackTheme.Size = New Size(82, 62)
        chkPackTheme.TabIndex = 32
        chkPackTheme.Text = "Theme"
        chkPackTheme.TextAlign = ContentAlignment.MiddleCenter
        chkPackTheme.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackTheme.UseVisualStyleBackColor = True
        ' 
        ' chkPackFeatured
        ' 
        chkPackFeatured.Appearance = Appearance.Button
        chkPackFeatured.Font = New Font("Quicksand", 8.25F)
        chkPackFeatured.ImageKey = "icons8-heart-24.png"
        chkPackFeatured.ImageList = imlCategories
        chkPackFeatured.Location = New Point(82, 78)
        chkPackFeatured.Name = "chkPackFeatured"
        chkPackFeatured.Size = New Size(82, 62)
        chkPackFeatured.TabIndex = 31
        chkPackFeatured.Text = "Featured"
        chkPackFeatured.TextAlign = ContentAlignment.MiddleCenter
        chkPackFeatured.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackFeatured.UseVisualStyleBackColor = True
        ' 
        ' chkPackTournament
        ' 
        chkPackTournament.Appearance = Appearance.Button
        chkPackTournament.Font = New Font("Quicksand", 8.25F)
        chkPackTournament.ImageKey = "icons8-heart-24.png"
        chkPackTournament.ImageList = imlCategories
        chkPackTournament.Location = New Point(157, 78)
        chkPackTournament.Name = "chkPackTournament"
        chkPackTournament.Size = New Size(82, 62)
        chkPackTournament.TabIndex = 30
        chkPackTournament.Text = "Tournament"
        chkPackTournament.TextAlign = ContentAlignment.MiddleCenter
        chkPackTournament.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackTournament.UseVisualStyleBackColor = True
        ' 
        ' chkPackLoved
        ' 
        chkPackLoved.Appearance = Appearance.Button
        chkPackLoved.Font = New Font("Quicksand", 8.25F)
        chkPackLoved.ImageKey = "icons8-heart-24.png"
        chkPackLoved.ImageList = imlCategories
        chkPackLoved.Location = New Point(9, 147)
        chkPackLoved.Name = "chkPackLoved"
        chkPackLoved.Size = New Size(82, 62)
        chkPackLoved.TabIndex = 29
        chkPackLoved.Text = "Loved"
        chkPackLoved.TextAlign = ContentAlignment.MiddleCenter
        chkPackLoved.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackLoved.UseVisualStyleBackColor = True
        ' 
        ' chkPackSpotlights
        ' 
        chkPackSpotlights.Appearance = Appearance.Button
        chkPackSpotlights.Font = New Font("Quicksand", 8.25F)
        chkPackSpotlights.ImageKey = "icons8-heart-24.png"
        chkPackSpotlights.ImageList = imlCategories
        chkPackSpotlights.Location = New Point(85, 146)
        chkPackSpotlights.Name = "chkPackSpotlights"
        chkPackSpotlights.Size = New Size(82, 62)
        chkPackSpotlights.TabIndex = 28
        chkPackSpotlights.Text = "Spotlights"
        chkPackSpotlights.TextAlign = ContentAlignment.MiddleCenter
        chkPackSpotlights.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackSpotlights.UseVisualStyleBackColor = True
        ' 
        ' chkPackStandard
        ' 
        chkPackStandard.Appearance = Appearance.Button
        chkPackStandard.Font = New Font("Quicksand", 8.25F)
        chkPackStandard.ImageKey = "icons8-heart-24.png"
        chkPackStandard.ImageList = imlCategories
        chkPackStandard.Location = New Point(9, 78)
        chkPackStandard.Name = "chkPackStandard"
        chkPackStandard.Size = New Size(82, 62)
        chkPackStandard.TabIndex = 27
        chkPackStandard.Text = "Standard"
        chkPackStandard.TextAlign = ContentAlignment.MiddleCenter
        chkPackStandard.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackStandard.UseVisualStyleBackColor = True
        ' 
        ' chkCatAny
        ' 
        chkCatAny.Appearance = Appearance.Button
        chkCatAny.Font = New Font("Quicksand", 8.25F)
        chkCatAny.ImageKey = "icons8-all-24.png"
        chkCatAny.ImageList = imlCategories
        chkCatAny.Location = New Point(78, 19)
        chkCatAny.Name = "chkCatAny"
        chkCatAny.Size = New Size(97, 53)
        chkCatAny.TabIndex = 20
        chkCatAny.Text = "All Packs"
        chkCatAny.TextAlign = ContentAlignment.MiddleCenter
        chkCatAny.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatAny.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpPacks)
        TabControl1.Controls.Add(tpSingles)
        TabControl1.Location = New Point(198, 244)
        TabControl1.Multiline = True
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(237, 332)
        TabControl1.TabIndex = 6
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(901, 675)
        Controls.Add(cbFilter)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(grpOptions)
        Controls.Add(grpSession)
        Controls.Add(tvListings)
        Controls.Add(TabControl1)
        Controls.Add(StatusStrip1)
        Controls.Add(grpConfiguration)
        Controls.Add(grpModes)
        Controls.Add(pbLogo)
        Controls.Add(msMainMenu)
        Font = New Font("Quicksand", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = msMainMenu
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmMain"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Osu!Scraper"
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        grpModes.ResumeLayout(False)
        msMainMenu.ResumeLayout(False)
        msMainMenu.PerformLayout()
        grpConfiguration.ResumeLayout(False)
        grpConfiguration.PerformLayout()
        CType(tbBatchSize, ComponentModel.ISupportInitialize).EndInit()
        CType(tbSleepInterval, ComponentModel.ISupportInitialize).EndInit()
        CType(tbForkValue, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        grpSession.ResumeLayout(False)
        grpSession.PerformLayout()
        grpOptions.ResumeLayout(False)
        grpOptions.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        tpSingles.ResumeLayout(False)
        tpPacks.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
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
    Friend WithEvents txtSessionToken As TextBox
    Friend WithEvents chkVerboseLogging As CheckBox
    Friend WithEvents chkOverwriteExistingFiles As CheckBox
    Friend WithEvents ttGeneralHover As ToolTip
    Friend WithEvents btnAutoFill As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslSep3 As ToolStripStatusLabel
    Friend WithEvents tssAuthenticatedValue As ToolStripStatusLabel
    Friend WithEvents tssSep1 As ToolStripStatusLabel
    Friend WithEvents tslCacheValue As ToolStripStatusLabel
    Friend WithEvents tslPulledValue As ToolStripStatusLabel
    Friend WithEvents tslSep2 As ToolStripStatusLabel
    Friend WithEvents tslSpacer As ToolStripStatusLabel
    Friend WithEvents tspbProgressBar As ToolStripProgressBar
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblBatchSizeValue As Label
    Friend WithEvents lblBatchSizeLabel As Label
    Friend WithEvents tbBatchSize As TrackBar
    Friend WithEvents tslBrowser As ToolStripStatusLabel
    Friend WithEvents ilBrowsers As ImageList
    Friend WithEvents tvListings As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents grpSession As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents ilLists As ImageList
    Friend WithEvents tpSingles As TabPage
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents chkCatGraveyard As CheckBox
    Friend WithEvents chkCatPersonal As CheckBox
    Friend WithEvents chkCatWorkInProgress As CheckBox
    Friend WithEvents chkCatLeaderBoard As CheckBox
    Friend WithEvents chkCatPending As CheckBox
    Friend WithEvents chkCatQualified As CheckBox
    Friend WithEvents chkCatLoved As CheckBox
    Friend WithEvents chkCatRanked As CheckBox
    Friend WithEvents chkCatFaves As CheckBox
    Friend WithEvents tpPacks As TabPage
    Friend WithEvents chkPackAlArt As CheckBox
    Friend WithEvents chkPackTheme As CheckBox
    Friend WithEvents chkPackFeatured As CheckBox
    Friend WithEvents chkPackTournament As CheckBox
    Friend WithEvents chkPackLoved As CheckBox
    Friend WithEvents chkPackSpotlights As CheckBox
    Friend WithEvents chkPackStandard As CheckBox
    Friend WithEvents chkCatAny As CheckBox
    Friend WithEvents TabControl1 As TabControl
End Class
