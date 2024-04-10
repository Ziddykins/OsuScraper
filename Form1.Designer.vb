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
        grpListings = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        grpDownloads = New GroupBox()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        cbFilter = New ComboBox()
        tpSingles = New TabPage()
        chkSingleAll = New CheckBox()
        chkSingleGraveyard = New CheckBox()
        ilCategoriesColor = New ImageList(components)
        chkSinglePersonal = New CheckBox()
        chkSingleWIP = New CheckBox()
        chkSingleLeaderBoard = New CheckBox()
        chkSinglePending = New CheckBox()
        chkSingleQualified = New CheckBox()
        chkSingleLoved = New CheckBox()
        chkSingleRanked = New CheckBox()
        chkSingleFaves = New CheckBox()
        tpPacks = New TabPage()
        chkPackAlArt = New CheckBox()
        chkPackTheme = New CheckBox()
        chkPackFeatured = New CheckBox()
        chkPackTournament = New CheckBox()
        chkPackLoved = New CheckBox()
        chkPackSpotlights = New CheckBox()
        chkPackStandard = New CheckBox()
        chkPackAll = New CheckBox()
        tcMainTabs = New TabControl()
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
        grpListings.SuspendLayout()
        grpDownloads.SuspendLayout()
        tpSingles.SuspendLayout()
        tpPacks.SuspendLayout()
        tcMainTabs.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Top
        pbLogo.Image = My.Resources.Resources.os_logo_banner
        pbLogo.Location = New Point(0, 24)
        pbLogo.Margin = New Padding(3, 4, 3, 4)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(949, 108)
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
        imlCategories.Images.SetKeyName(11, "icons8-osu-24.png")
        imlCategories.Images.SetKeyName(12, "icons8-spotlight-24.png")
        ' 
        ' msMainMenu
        ' 
        msMainMenu.ImageScalingSize = New Size(24, 24)
        msMainMenu.Items.AddRange(New ToolStripItem() {tsmFile, tsmListings, tsmOptions, tsmHelp})
        msMainMenu.Location = New Point(0, 0)
        msMainMenu.Name = "msMainMenu"
        msMainMenu.Size = New Size(949, 24)
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
        btnAutoFill.Image = My.Resources.Resources.icons8_wand_24
        btnAutoFill.ImageAlign = ContentAlignment.MiddleLeft
        btnAutoFill.Location = New Point(13, 130)
        btnAutoFill.Name = "btnAutoFill"
        btnAutoFill.Size = New Size(150, 40)
        btnAutoFill.TabIndex = 5
        btnAutoFill.Text = "Auto-Fill"
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
        StatusStrip1.Location = New Point(0, 600)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(949, 29)
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
        tslSpacer.Size = New Size(701, 24)
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
        tvListings.Size = New Size(306, 413)
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
        Button1.Location = New Point(32, 25)
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
        grpSession.Size = New Size(176, 260)
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
        grpOptions.Location = New Point(769, 467)
        grpOptions.Name = "grpOptions"
        grpOptions.Size = New Size(168, 123)
        grpOptions.TabIndex = 20
        grpOptions.TabStop = False
        grpOptions.Text = "Options"
        ' 
        ' grpListings
        ' 
        grpListings.Controls.Add(Button4)
        grpListings.Controls.Add(Button3)
        grpListings.Controls.Add(Button2)
        grpListings.Controls.Add(Button1)
        grpListings.Location = New Point(769, 139)
        grpListings.Name = "grpListings"
        grpListings.Size = New Size(168, 158)
        grpListings.TabIndex = 21
        grpListings.TabStop = False
        grpListings.Text = "Listings"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(32, 118)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 23)
        Button4.TabIndex = 11
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(32, 87)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 23)
        Button3.TabIndex = 10
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(32, 56)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 23)
        Button2.TabIndex = 9
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' grpDownloads
        ' 
        grpDownloads.Controls.Add(Button5)
        grpDownloads.Controls.Add(Button6)
        grpDownloads.Controls.Add(Button7)
        grpDownloads.Controls.Add(Button8)
        grpDownloads.Location = New Point(769, 303)
        grpDownloads.Name = "grpDownloads"
        grpDownloads.Size = New Size(168, 158)
        grpDownloads.TabIndex = 22
        grpDownloads.TabStop = False
        grpDownloads.Text = "Downloads"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(32, 118)
        Button5.Name = "Button5"
        Button5.Size = New Size(105, 23)
        Button5.TabIndex = 15
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(32, 87)
        Button6.Name = "Button6"
        Button6.Size = New Size(105, 23)
        Button6.TabIndex = 14
        Button6.Text = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(32, 56)
        Button7.Name = "Button7"
        Button7.Size = New Size(105, 23)
        Button7.TabIndex = 13
        Button7.Text = "Button7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(32, 25)
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
        cbFilter.Text = "<Filter ... >"
        ' 
        ' tpSingles
        ' 
        tpSingles.Controls.Add(chkSingleAll)
        tpSingles.Controls.Add(chkSingleGraveyard)
        tpSingles.Controls.Add(chkSinglePersonal)
        tpSingles.Controls.Add(chkSingleWIP)
        tpSingles.Controls.Add(chkSingleLeaderBoard)
        tpSingles.Controls.Add(chkSinglePending)
        tpSingles.Controls.Add(chkSingleQualified)
        tpSingles.Controls.Add(chkSingleLoved)
        tpSingles.Controls.Add(chkSingleRanked)
        tpSingles.Controls.Add(chkSingleFaves)
        tpSingles.Location = New Point(4, 24)
        tpSingles.Name = "tpSingles"
        tpSingles.Padding = New Padding(3)
        tpSingles.Size = New Size(245, 318)
        tpSingles.TabIndex = 1
        tpSingles.Text = "Singles"
        tpSingles.UseVisualStyleBackColor = True
        ' 
        ' chkSingleAll
        ' 
        chkSingleAll.Appearance = Appearance.Button
        chkSingleAll.BackColor = SystemColors.Control
        chkSingleAll.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleAll.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleAll.FlatStyle = FlatStyle.Flat
        chkSingleAll.Font = New Font("Quicksand", 8.25F)
        chkSingleAll.ImageKey = "icons8-all-24.png"
        chkSingleAll.ImageList = imlCategories
        chkSingleAll.Location = New Point(9, 9)
        chkSingleAll.Name = "chkSingleAll"
        chkSingleAll.Size = New Size(226, 45)
        chkSingleAll.TabIndex = 29
        chkSingleAll.Text = "All Packs"
        chkSingleAll.TextAlign = ContentAlignment.MiddleRight
        chkSingleAll.TextImageRelation = TextImageRelation.ImageBeforeText
        chkSingleAll.UseVisualStyleBackColor = False
        ' 
        ' chkSingleGraveyard
        ' 
        chkSingleGraveyard.Appearance = Appearance.Button
        chkSingleGraveyard.BackColor = SystemColors.Control
        chkSingleGraveyard.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleGraveyard.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleGraveyard.FlatStyle = FlatStyle.Flat
        chkSingleGraveyard.Font = New Font("Quicksand", 8.25F)
        chkSingleGraveyard.ImageKey = "icons8-tombstone-32.png"
        chkSingleGraveyard.ImageList = ilCategoriesColor
        chkSingleGraveyard.Location = New Point(165, 228)
        chkSingleGraveyard.Name = "chkSingleGraveyard"
        chkSingleGraveyard.Size = New Size(70, 77)
        chkSingleGraveyard.TabIndex = 22
        chkSingleGraveyard.Text = "Grvyrd"
        chkSingleGraveyard.TextAlign = ContentAlignment.MiddleCenter
        chkSingleGraveyard.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleGraveyard.UseVisualStyleBackColor = False
        ' 
        ' ilCategoriesColor
        ' 
        ilCategoriesColor.ColorDepth = ColorDepth.Depth32Bit
        ilCategoriesColor.ImageStream = CType(resources.GetObject("ilCategoriesColor.ImageStream"), ImageListStreamer)
        ilCategoriesColor.TransparentColor = Color.Transparent
        ilCategoriesColor.Images.SetKeyName(0, "icons8-star-filled-24.png")
        ilCategoriesColor.Images.SetKeyName(1, "icons8-spotlight-24-col.png")
        ilCategoriesColor.Images.SetKeyName(2, "icons8-love-24.png")
        ilCategoriesColor.Images.SetKeyName(3, "icons8-osu-24-col.png")
        ilCategoriesColor.Images.SetKeyName(4, "icons8-album-24.png")
        ilCategoriesColor.Images.SetKeyName(5, "icons8-theme-32.png")
        ilCategoriesColor.Images.SetKeyName(6, "icons8-tournament-32.png")
        ilCategoriesColor.Images.SetKeyName(7, "icons8-tombstone-32.png")
        ilCategoriesColor.Images.SetKeyName(8, "icons8-qualified-32.png")
        ilCategoriesColor.Images.SetKeyName(9, "icons8-progress-indicator-32.png")
        ilCategoriesColor.Images.SetKeyName(10, "icons8-pending-32.png")
        ilCategoriesColor.Images.SetKeyName(11, "icons8-rank-32.png")
        ilCategoriesColor.Images.SetKeyName(12, "icons8-mine-32.png")
        ' 
        ' chkSinglePersonal
        ' 
        chkSinglePersonal.Appearance = Appearance.Button
        chkSinglePersonal.BackColor = SystemColors.Control
        chkSinglePersonal.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSinglePersonal.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSinglePersonal.FlatStyle = FlatStyle.Flat
        chkSinglePersonal.Font = New Font("Quicksand", 8.25F)
        chkSinglePersonal.ImageKey = "icons8-mine-32.png"
        chkSinglePersonal.ImageList = ilCategoriesColor
        chkSinglePersonal.Location = New Point(87, 64)
        chkSinglePersonal.Name = "chkSinglePersonal"
        chkSinglePersonal.Size = New Size(70, 77)
        chkSinglePersonal.TabIndex = 21
        chkSinglePersonal.Text = "Mine"
        chkSinglePersonal.TextAlign = ContentAlignment.MiddleCenter
        chkSinglePersonal.TextImageRelation = TextImageRelation.ImageAboveText
        chkSinglePersonal.UseVisualStyleBackColor = False
        ' 
        ' chkSingleWIP
        ' 
        chkSingleWIP.Appearance = Appearance.Button
        chkSingleWIP.BackColor = SystemColors.Control
        chkSingleWIP.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleWIP.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleWIP.FlatStyle = FlatStyle.Flat
        chkSingleWIP.Font = New Font("Quicksand", 8.25F)
        chkSingleWIP.ImageKey = "icons8-progress-indicator-32.png"
        chkSingleWIP.ImageList = ilCategoriesColor
        chkSingleWIP.Location = New Point(87, 228)
        chkSingleWIP.Name = "chkSingleWIP"
        chkSingleWIP.Size = New Size(70, 77)
        chkSingleWIP.TabIndex = 23
        chkSingleWIP.Text = "WIP"
        chkSingleWIP.TextAlign = ContentAlignment.MiddleCenter
        chkSingleWIP.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleWIP.UseVisualStyleBackColor = False
        ' 
        ' chkSingleLeaderBoard
        ' 
        chkSingleLeaderBoard.Appearance = Appearance.Button
        chkSingleLeaderBoard.BackColor = SystemColors.Control
        chkSingleLeaderBoard.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleLeaderBoard.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleLeaderBoard.FlatStyle = FlatStyle.Flat
        chkSingleLeaderBoard.Font = New Font("Quicksand", 8.25F)
        chkSingleLeaderBoard.ImageKey = "icons8-tournament-32.png"
        chkSingleLeaderBoard.ImageList = ilCategoriesColor
        chkSingleLeaderBoard.Location = New Point(9, 146)
        chkSingleLeaderBoard.Name = "chkSingleLeaderBoard"
        chkSingleLeaderBoard.Size = New Size(70, 77)
        chkSingleLeaderBoard.TabIndex = 20
        chkSingleLeaderBoard.Text = "Ldr. Board"
        chkSingleLeaderBoard.TextAlign = ContentAlignment.MiddleCenter
        chkSingleLeaderBoard.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleLeaderBoard.UseVisualStyleBackColor = False
        ' 
        ' chkSinglePending
        ' 
        chkSinglePending.Appearance = Appearance.Button
        chkSinglePending.BackColor = SystemColors.Control
        chkSinglePending.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSinglePending.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSinglePending.FlatStyle = FlatStyle.Flat
        chkSinglePending.Font = New Font("Quicksand", 8.25F)
        chkSinglePending.ImageKey = "icons8-pending-32.png"
        chkSinglePending.ImageList = ilCategoriesColor
        chkSinglePending.Location = New Point(9, 228)
        chkSinglePending.Name = "chkSinglePending"
        chkSinglePending.Size = New Size(70, 77)
        chkSinglePending.TabIndex = 24
        chkSinglePending.Text = "Pending"
        chkSinglePending.TextAlign = ContentAlignment.MiddleCenter
        chkSinglePending.TextImageRelation = TextImageRelation.ImageAboveText
        chkSinglePending.UseVisualStyleBackColor = False
        ' 
        ' chkSingleQualified
        ' 
        chkSingleQualified.Appearance = Appearance.Button
        chkSingleQualified.BackColor = SystemColors.Control
        chkSingleQualified.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleQualified.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleQualified.FlatStyle = FlatStyle.Flat
        chkSingleQualified.Font = New Font("Quicksand", 8.25F)
        chkSingleQualified.ImageKey = "icons8-qualified-32.png"
        chkSingleQualified.ImageList = ilCategoriesColor
        chkSingleQualified.Location = New Point(165, 146)
        chkSingleQualified.Name = "chkSingleQualified"
        chkSingleQualified.Size = New Size(70, 77)
        chkSingleQualified.TabIndex = 27
        chkSingleQualified.Text = "Qualified"
        chkSingleQualified.TextAlign = ContentAlignment.MiddleCenter
        chkSingleQualified.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleQualified.UseVisualStyleBackColor = False
        ' 
        ' chkSingleLoved
        ' 
        chkSingleLoved.Appearance = Appearance.Button
        chkSingleLoved.BackColor = SystemColors.Control
        chkSingleLoved.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleLoved.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleLoved.FlatStyle = FlatStyle.Flat
        chkSingleLoved.Font = New Font("Quicksand", 8.25F)
        chkSingleLoved.ImageKey = "icons8-love-24.png"
        chkSingleLoved.ImageList = ilCategoriesColor
        chkSingleLoved.Location = New Point(165, 64)
        chkSingleLoved.Name = "chkSingleLoved"
        chkSingleLoved.Size = New Size(70, 77)
        chkSingleLoved.TabIndex = 26
        chkSingleLoved.Text = "Loved"
        chkSingleLoved.TextAlign = ContentAlignment.MiddleCenter
        chkSingleLoved.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleLoved.UseVisualStyleBackColor = False
        ' 
        ' chkSingleRanked
        ' 
        chkSingleRanked.Appearance = Appearance.Button
        chkSingleRanked.BackColor = SystemColors.Control
        chkSingleRanked.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleRanked.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleRanked.FlatStyle = FlatStyle.Flat
        chkSingleRanked.Font = New Font("Quicksand", 8.25F)
        chkSingleRanked.ImageKey = "icons8-rank-32.png"
        chkSingleRanked.ImageList = ilCategoriesColor
        chkSingleRanked.Location = New Point(87, 146)
        chkSingleRanked.Name = "chkSingleRanked"
        chkSingleRanked.Size = New Size(70, 77)
        chkSingleRanked.TabIndex = 28
        chkSingleRanked.Text = "Ranked"
        chkSingleRanked.TextAlign = ContentAlignment.MiddleCenter
        chkSingleRanked.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleRanked.UseVisualStyleBackColor = False
        ' 
        ' chkSingleFaves
        ' 
        chkSingleFaves.Appearance = Appearance.Button
        chkSingleFaves.BackColor = SystemColors.Control
        chkSingleFaves.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkSingleFaves.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkSingleFaves.FlatStyle = FlatStyle.Flat
        chkSingleFaves.Font = New Font("Quicksand", 8.25F)
        chkSingleFaves.ImageKey = "icons8-star-filled-24.png"
        chkSingleFaves.ImageList = ilCategoriesColor
        chkSingleFaves.Location = New Point(9, 64)
        chkSingleFaves.Name = "chkSingleFaves"
        chkSingleFaves.Size = New Size(70, 77)
        chkSingleFaves.TabIndex = 25
        chkSingleFaves.Text = "Faves"
        chkSingleFaves.TextAlign = ContentAlignment.MiddleCenter
        chkSingleFaves.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleFaves.UseVisualStyleBackColor = False
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
        tpPacks.Controls.Add(chkPackAll)
        tpPacks.Location = New Point(4, 27)
        tpPacks.Name = "tpPacks"
        tpPacks.Padding = New Padding(3)
        tpPacks.Size = New Size(245, 315)
        tpPacks.TabIndex = 0
        tpPacks.Text = "Packs"
        tpPacks.UseVisualStyleBackColor = True
        ' 
        ' chkPackAlArt
        ' 
        chkPackAlArt.Appearance = Appearance.Button
        chkPackAlArt.BackColor = SystemColors.Control
        chkPackAlArt.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackAlArt.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackAlArt.FlatStyle = FlatStyle.Flat
        chkPackAlArt.Font = New Font("Quicksand", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkPackAlArt.ImageKey = "icons8-album-24.png"
        chkPackAlArt.ImageList = ilCategoriesColor
        chkPackAlArt.Location = New Point(9, 71)
        chkPackAlArt.Name = "chkPackAlArt"
        chkPackAlArt.Size = New Size(70, 113)
        chkPackAlArt.TabIndex = 33
        chkPackAlArt.Text = "Abm/Artst"
        chkPackAlArt.TextAlign = ContentAlignment.BottomCenter
        chkPackAlArt.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackAlArt.UseVisualStyleBackColor = False
        ' 
        ' chkPackTheme
        ' 
        chkPackTheme.Appearance = Appearance.Button
        chkPackTheme.BackColor = SystemColors.Control
        chkPackTheme.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackTheme.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackTheme.FlatStyle = FlatStyle.Flat
        chkPackTheme.Font = New Font("Quicksand", 8.25F)
        chkPackTheme.ImageKey = "icons8-theme-32.png"
        chkPackTheme.ImageList = ilCategoriesColor
        chkPackTheme.Location = New Point(165, 193)
        chkPackTheme.Name = "chkPackTheme"
        chkPackTheme.Size = New Size(70, 113)
        chkPackTheme.TabIndex = 32
        chkPackTheme.Text = "Theme"
        chkPackTheme.TextAlign = ContentAlignment.BottomCenter
        chkPackTheme.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackTheme.UseVisualStyleBackColor = False
        ' 
        ' chkPackFeatured
        ' 
        chkPackFeatured.Appearance = Appearance.Button
        chkPackFeatured.BackColor = SystemColors.Control
        chkPackFeatured.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackFeatured.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackFeatured.FlatStyle = FlatStyle.Flat
        chkPackFeatured.Font = New Font("Quicksand", 8.25F)
        chkPackFeatured.ImageKey = "icons8-star-filled-24.png"
        chkPackFeatured.ImageList = ilCategoriesColor
        chkPackFeatured.Location = New Point(87, 71)
        chkPackFeatured.Name = "chkPackFeatured"
        chkPackFeatured.Size = New Size(70, 113)
        chkPackFeatured.TabIndex = 31
        chkPackFeatured.Text = "Featured"
        chkPackFeatured.TextAlign = ContentAlignment.BottomCenter
        chkPackFeatured.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackFeatured.UseVisualStyleBackColor = False
        ' 
        ' chkPackTournament
        ' 
        chkPackTournament.Appearance = Appearance.Button
        chkPackTournament.BackColor = SystemColors.Control
        chkPackTournament.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackTournament.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackTournament.FlatStyle = FlatStyle.Flat
        chkPackTournament.Font = New Font("Quicksand", 8.25F)
        chkPackTournament.ImageKey = "icons8-tournament-32.png"
        chkPackTournament.ImageList = ilCategoriesColor
        chkPackTournament.Location = New Point(165, 71)
        chkPackTournament.Name = "chkPackTournament"
        chkPackTournament.Size = New Size(70, 113)
        chkPackTournament.TabIndex = 30
        chkPackTournament.Text = "Tourny"
        chkPackTournament.TextAlign = ContentAlignment.BottomCenter
        chkPackTournament.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackTournament.UseVisualStyleBackColor = False
        ' 
        ' chkPackLoved
        ' 
        chkPackLoved.Appearance = Appearance.Button
        chkPackLoved.BackColor = SystemColors.Control
        chkPackLoved.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackLoved.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackLoved.FlatStyle = FlatStyle.Flat
        chkPackLoved.Font = New Font("Quicksand", 8.25F)
        chkPackLoved.ImageKey = "icons8-love-24.png"
        chkPackLoved.ImageList = ilCategoriesColor
        chkPackLoved.Location = New Point(9, 193)
        chkPackLoved.Name = "chkPackLoved"
        chkPackLoved.Size = New Size(70, 113)
        chkPackLoved.TabIndex = 29
        chkPackLoved.Text = "Loved"
        chkPackLoved.TextAlign = ContentAlignment.BottomCenter
        chkPackLoved.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackLoved.UseVisualStyleBackColor = False
        ' 
        ' chkPackSpotlights
        ' 
        chkPackSpotlights.Appearance = Appearance.Button
        chkPackSpotlights.BackColor = SystemColors.Control
        chkPackSpotlights.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackSpotlights.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackSpotlights.FlatStyle = FlatStyle.Flat
        chkPackSpotlights.Font = New Font("Quicksand", 8.25F)
        chkPackSpotlights.ImageKey = "icons8-spotlight-24-col.png"
        chkPackSpotlights.ImageList = ilCategoriesColor
        chkPackSpotlights.Location = New Point(87, 193)
        chkPackSpotlights.Name = "chkPackSpotlights"
        chkPackSpotlights.Size = New Size(70, 113)
        chkPackSpotlights.TabIndex = 28
        chkPackSpotlights.Text = "Spotlights"
        chkPackSpotlights.TextAlign = ContentAlignment.BottomCenter
        chkPackSpotlights.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackSpotlights.UseVisualStyleBackColor = False
        ' 
        ' chkPackStandard
        ' 
        chkPackStandard.Appearance = Appearance.Button
        chkPackStandard.BackColor = SystemColors.Control
        chkPackStandard.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackStandard.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackStandard.FlatStyle = FlatStyle.Flat
        chkPackStandard.Font = New Font("Quicksand", 8.25F)
        chkPackStandard.ImageKey = "icons8-osu-24-col.png"
        chkPackStandard.ImageList = ilCategoriesColor
        chkPackStandard.Location = New Point(124, 9)
        chkPackStandard.Name = "chkPackStandard"
        chkPackStandard.Size = New Size(112, 53)
        chkPackStandard.TabIndex = 27
        chkPackStandard.Text = "Standard"
        chkPackStandard.TextAlign = ContentAlignment.MiddleCenter
        chkPackStandard.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackStandard.UseVisualStyleBackColor = False
        ' 
        ' chkPackAll
        ' 
        chkPackAll.Appearance = Appearance.Button
        chkPackAll.BackColor = SystemColors.Control
        chkPackAll.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackAll.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackAll.FlatStyle = FlatStyle.Flat
        chkPackAll.Font = New Font("Quicksand", 8.25F)
        chkPackAll.ImageKey = "icons8-all-24.png"
        chkPackAll.ImageList = imlCategories
        chkPackAll.Location = New Point(9, 9)
        chkPackAll.Name = "chkPackAll"
        chkPackAll.Size = New Size(112, 53)
        chkPackAll.TabIndex = 20
        chkPackAll.Text = "All Packs"
        chkPackAll.TextAlign = ContentAlignment.MiddleCenter
        chkPackAll.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackAll.UseVisualStyleBackColor = False
        ' 
        ' tcMainTabs
        ' 
        tcMainTabs.Controls.Add(tpPacks)
        tcMainTabs.Controls.Add(tpSingles)
        tcMainTabs.Location = New Point(198, 244)
        tcMainTabs.Multiline = True
        tcMainTabs.Name = "tcMainTabs"
        tcMainTabs.SelectedIndex = 0
        tcMainTabs.Size = New Size(253, 346)
        tcMainTabs.TabIndex = 6
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(949, 629)
        Controls.Add(cbFilter)
        Controls.Add(grpDownloads)
        Controls.Add(grpListings)
        Controls.Add(grpOptions)
        Controls.Add(grpSession)
        Controls.Add(tvListings)
        Controls.Add(tcMainTabs)
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
        grpListings.ResumeLayout(False)
        grpDownloads.ResumeLayout(False)
        tpSingles.ResumeLayout(False)
        tpPacks.ResumeLayout(False)
        tcMainTabs.ResumeLayout(False)
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
    Friend WithEvents lblBatchSizeValue As Label
    Friend WithEvents lblBatchSizeLabel As Label
    Friend WithEvents tbBatchSize As TrackBar
    Friend WithEvents tslBrowser As ToolStripStatusLabel
    Friend WithEvents ilBrowsers As ImageList
    Friend WithEvents tvListings As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents grpSession As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpListings As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grpDownloads As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents ilLists As ImageList
    Friend WithEvents tpSingles As TabPage
    Friend WithEvents chkSingleAll As CheckBox
    Friend WithEvents chkSingleGraveyard As CheckBox
    Friend WithEvents chkSinglePersonal As CheckBox
    Friend WithEvents chkSingleWIP As CheckBox
    Friend WithEvents chkSingleLeaderBoard As CheckBox
    Friend WithEvents chkSinglePending As CheckBox
    Friend WithEvents chkSingleQualified As CheckBox
    Friend WithEvents chkSingleLoved As CheckBox
    Friend WithEvents chkSingleRanked As CheckBox
    Friend WithEvents chkSingleFaves As CheckBox
    Friend WithEvents tpPacks As TabPage
    Friend WithEvents chkPackAlArt As CheckBox
    Friend WithEvents chkPackTheme As CheckBox
    Friend WithEvents chkPackFeatured As CheckBox
    Friend WithEvents chkPackTournament As CheckBox
    Friend WithEvents chkPackLoved As CheckBox
    Friend WithEvents chkPackSpotlights As CheckBox
    Friend WithEvents chkPackStandard As CheckBox
    Friend WithEvents chkPackAll As CheckBox
    Friend WithEvents tcMainTabs As TabControl
    Friend WithEvents ilCategoriesColor As ImageList
End Class
