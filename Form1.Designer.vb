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
        Dim TreeNode3 As TreeNode = New TreeNode("Packs", 0, 1)
        Dim TreeNode4 As TreeNode = New TreeNode("Singles")
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
        tslAuthenticatedValue = New ToolStripStatusLabel()
        tssSep1 = New ToolStripStatusLabel()
        tslDatabase = New ToolStripStatusLabel()
        tslSep4 = New ToolStripStatusLabel()
        tslCacheValue = New ToolStripStatusLabel()
        tslSep2 = New ToolStripStatusLabel()
        tslPulledValue = New ToolStripStatusLabel()
        tslSpacer = New ToolStripStatusLabel()
        tslStatus = New ToolStripStatusLabel()
        ilBrowsers = New ImageList(components)
        tvListings = New TreeView()
        imlLists = New ImageList(components)
        btnPullSelected = New Button()
        grpSession = New GroupBox()
        btnCheckSession = New Button()
        lblProgressSecondaryLabel = New Label()
        lblProgressPrimaryLabel = New Label()
        prgPrimaryTask = New ProgressBar()
        prgSecondaryTask = New ProgressBar()
        grpOptions = New GroupBox()
        grpListings = New GroupBox()
        Button3 = New Button()
        Button2 = New Button()
        grpDownloads = New GroupBox()
        Label6 = New Label()
        btnSetOsuFolder = New Button()
        Label4 = New Label()
        btnSetTempFolder = New Button()
        Label1 = New Label()
        btnSetDownloadFolder = New Button()
        cbFilter = New ComboBox()
        tpSingles = New TabPage()
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
        chkPackArtist = New CheckBox()
        chkPackTheme = New CheckBox()
        chkPackFeatured = New CheckBox()
        chkPackTournament = New CheckBox()
        chkPackLoved = New CheckBox()
        chkPackSpotlight = New CheckBox()
        chkPackStandard = New CheckBox()
        tcMainTabs = New TabControl()
        fdbDownloadFolder = New FolderBrowserDialog()
        fdbTempFolder = New FolderBrowserDialog()
        fdbOsuFolder = New FolderBrowserDialog()
        Label2 = New Label()
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
        chkModeTaiko.ImageIndex = 7
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
        imlModes.Images.SetKeyName(4, "catch.png")
        imlModes.Images.SetKeyName(5, "mania.png")
        imlModes.Images.SetKeyName(6, "standard.png")
        imlModes.Images.SetKeyName(7, "taiko.png")
        ' 
        ' chkModeMania
        ' 
        chkModeMania.Appearance = Appearance.Button
        chkModeMania.ImageIndex = 5
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
        chkModeCatch.ImageKey = "catch.png"
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
        chkModeOsu.ImageIndex = 6
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
        btnAutoFill.Location = New Point(13, 114)
        btnAutoFill.Name = "btnAutoFill"
        btnAutoFill.Size = New Size(67, 32)
        btnAutoFill.TabIndex = 5
        btnAutoFill.Text = "Fill"
        btnAutoFill.TextAlign = ContentAlignment.MiddleRight
        btnAutoFill.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAutoFill.UseVisualStyleBackColor = True
        ' 
        ' lblXSRFTokenLabel
        ' 
        lblXSRFTokenLabel.AutoSize = True
        lblXSRFTokenLabel.Location = New Point(86, 60)
        lblXSRFTokenLabel.Name = "lblXSRFTokenLabel"
        lblXSRFTokenLabel.Size = New Size(75, 18)
        lblXSRFTokenLabel.TabIndex = 12
        lblXSRFTokenLabel.Text = "XSRF Token:"
        ' 
        ' lblSessionLabel
        ' 
        lblSessionLabel.AutoSize = True
        lblSessionLabel.Location = New Point(40, 20)
        lblSessionLabel.Name = "lblSessionLabel"
        lblSessionLabel.Size = New Size(121, 18)
        lblSessionLabel.TabIndex = 11
        lblSessionLabel.Text = "Osu! Session Cookie:"
        ' 
        ' txtXSRFToken
        ' 
        txtXSRFToken.Location = New Point(14, 77)
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
        StatusStrip1.Items.AddRange(New ToolStripItem() {tslBrowser, tslSep3, tslAuthenticatedValue, tssSep1, tslDatabase, tslSep4, tslCacheValue, tslSep2, tslPulledValue, tslSpacer, tslStatus})
        StatusStrip1.Location = New Point(0, 600)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(949, 29)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tslBrowser
        ' 
        tslBrowser.Image = My.Resources.Resources.icons8_browser_24
        tslBrowser.Margin = New Padding(5, 3, 0, 2)
        tslBrowser.Name = "tslBrowser"
        tslBrowser.Size = New Size(24, 24)
        ' 
        ' tslSep3
        ' 
        tslSep3.Name = "tslSep3"
        tslSep3.Size = New Size(10, 24)
        tslSep3.Text = "|"
        ' 
        ' tslAuthenticatedValue
        ' 
        tslAuthenticatedValue.BorderStyle = Border3DStyle.Etched
        tslAuthenticatedValue.Font = New Font("Quicksand", 9F)
        tslAuthenticatedValue.ForeColor = Color.Red
        tslAuthenticatedValue.Image = My.Resources.Resources.icons8_lock_24_red
        tslAuthenticatedValue.Name = "tslAuthenticatedValue"
        tslAuthenticatedValue.Size = New Size(65, 24)
        tslAuthenticatedValue.Text = "AUTH"
        ' 
        ' tssSep1
        ' 
        tssSep1.Name = "tssSep1"
        tssSep1.Size = New Size(10, 24)
        tssSep1.Text = "|"
        ' 
        ' tslDatabase
        ' 
        tslDatabase.Font = New Font("Quicksand", 9F)
        tslDatabase.ForeColor = Color.Red
        tslDatabase.Image = My.Resources.Resources.icons8_database_24
        tslDatabase.Name = "tslDatabase"
        tslDatabase.Size = New Size(62, 24)
        tslDatabase.Text = "DATA"
        ' 
        ' tslSep4
        ' 
        tslSep4.Name = "tslSep4"
        tslSep4.Size = New Size(10, 24)
        tslSep4.Text = "|"
        ' 
        ' tslCacheValue
        ' 
        tslCacheValue.Font = New Font("Quicksand", 9F)
        tslCacheValue.ForeColor = Color.Red
        tslCacheValue.Image = My.Resources.Resources.icons8_cache_24_red
        tslCacheValue.Name = "tslCacheValue"
        tslCacheValue.Size = New Size(72, 24)
        tslCacheValue.Text = "CACHE"
        ' 
        ' tslSep2
        ' 
        tslSep2.Name = "tslSep2"
        tslSep2.Size = New Size(10, 24)
        tslSep2.Text = "|"
        ' 
        ' tslPulledValue
        ' 
        tslPulledValue.Font = New Font("Quicksand", 9F)
        tslPulledValue.ForeColor = Color.Red
        tslPulledValue.Image = My.Resources.Resources.icons8_update_24_red
        tslPulledValue.Name = "tslPulledValue"
        tslPulledValue.Size = New Size(87, 24)
        tslPulledValue.Text = "UPDATED"
        ' 
        ' tslSpacer
        ' 
        tslSpacer.Name = "tslSpacer"
        tslSpacer.Size = New Size(379, 24)
        tslSpacer.Spring = True
        ' 
        ' tslStatus
        ' 
        tslStatus.AutoSize = False
        tslStatus.BackColor = SystemColors.ControlLight
        tslStatus.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Top Or ToolStripStatusLabelBorderSides.Right Or ToolStripStatusLabelBorderSides.Bottom
        tslStatus.Name = "tslStatus"
        tslStatus.Size = New Size(200, 24)
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
        tvListings.ImageList = imlLists
        tvListings.Location = New Point(457, 177)
        tvListings.Name = "tvListings"
        TreeNode3.ImageIndex = 0
        TreeNode3.Name = "tvnPacks"
        TreeNode3.SelectedImageIndex = 1
        TreeNode3.Text = "Packs"
        TreeNode4.Name = "tvnSingles"
        TreeNode4.Text = "Singles"
        tvListings.Nodes.AddRange(New TreeNode() {TreeNode3, TreeNode4})
        tvListings.SelectedImageIndex = 0
        tvListings.Size = New Size(306, 413)
        tvListings.TabIndex = 7
        ' 
        ' imlLists
        ' 
        imlLists.ColorDepth = ColorDepth.Depth32Bit
        imlLists.ImageStream = CType(resources.GetObject("imlLists.ImageStream"), ImageListStreamer)
        imlLists.TransparentColor = Color.Transparent
        imlLists.Images.SetKeyName(0, "icons8-one-page-16.png")
        imlLists.Images.SetKeyName(1, "icons8-package-16.png")
        imlLists.Images.SetKeyName(2, "catch.png")
        imlLists.Images.SetKeyName(3, "mania.png")
        imlLists.Images.SetKeyName(4, "standard.png")
        imlLists.Images.SetKeyName(5, "taiko.png")
        ' 
        ' btnPullSelected
        ' 
        btnPullSelected.Location = New Point(32, 25)
        btnPullSelected.Name = "btnPullSelected"
        btnPullSelected.Size = New Size(105, 23)
        btnPullSelected.TabIndex = 8
        btnPullSelected.Text = "Pull Selected"
        btnPullSelected.UseVisualStyleBackColor = True
        ' 
        ' grpSession
        ' 
        grpSession.Controls.Add(btnCheckSession)
        grpSession.Controls.Add(lblProgressSecondaryLabel)
        grpSession.Controls.Add(lblProgressPrimaryLabel)
        grpSession.Controls.Add(prgPrimaryTask)
        grpSession.Controls.Add(prgSecondaryTask)
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
        ' btnCheckSession
        ' 
        btnCheckSession.AutoSize = True
        btnCheckSession.FlatStyle = FlatStyle.Popup
        btnCheckSession.Font = New Font("Quicksand", 9F)
        btnCheckSession.Image = My.Resources.Resources.icons8_login_24
        btnCheckSession.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckSession.Location = New Point(86, 114)
        btnCheckSession.Name = "btnCheckSession"
        btnCheckSession.Size = New Size(75, 32)
        btnCheckSession.TabIndex = 17
        btnCheckSession.Text = "Check"
        btnCheckSession.TextAlign = ContentAlignment.MiddleRight
        btnCheckSession.UseVisualStyleBackColor = True
        ' 
        ' lblProgressSecondaryLabel
        ' 
        lblProgressSecondaryLabel.AutoSize = True
        lblProgressSecondaryLabel.Font = New Font("Quicksand", 8.25F)
        lblProgressSecondaryLabel.Location = New Point(70, 222)
        lblProgressSecondaryLabel.Name = "lblProgressSecondaryLabel"
        lblProgressSecondaryLabel.Size = New Size(91, 16)
        lblProgressSecondaryLabel.TabIndex = 16
        lblProgressSecondaryLabel.Text = "Secondary Task:"
        ' 
        ' lblProgressPrimaryLabel
        ' 
        lblProgressPrimaryLabel.AutoSize = True
        lblProgressPrimaryLabel.Font = New Font("Quicksand", 8.25F)
        lblProgressPrimaryLabel.Location = New Point(85, 183)
        lblProgressPrimaryLabel.Name = "lblProgressPrimaryLabel"
        lblProgressPrimaryLabel.Size = New Size(76, 16)
        lblProgressPrimaryLabel.TabIndex = 15
        lblProgressPrimaryLabel.Text = "Primary Task:"
        ' 
        ' prgPrimaryTask
        ' 
        prgPrimaryTask.Location = New Point(14, 202)
        prgPrimaryTask.Name = "prgPrimaryTask"
        prgPrimaryTask.Size = New Size(147, 10)
        prgPrimaryTask.TabIndex = 14
        ' 
        ' prgSecondaryTask
        ' 
        prgSecondaryTask.Location = New Point(14, 241)
        prgSecondaryTask.Name = "prgSecondaryTask"
        prgSecondaryTask.Size = New Size(147, 10)
        prgSecondaryTask.TabIndex = 13
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
        grpListings.Controls.Add(Button3)
        grpListings.Controls.Add(Button2)
        grpListings.Controls.Add(btnPullSelected)
        grpListings.Location = New Point(769, 139)
        grpListings.Name = "grpListings"
        grpListings.Size = New Size(168, 125)
        grpListings.TabIndex = 21
        grpListings.TabStop = False
        grpListings.Text = "Listings"
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
        grpDownloads.Controls.Add(Label2)
        grpDownloads.Controls.Add(Label6)
        grpDownloads.Controls.Add(btnSetOsuFolder)
        grpDownloads.Controls.Add(Label4)
        grpDownloads.Controls.Add(btnSetTempFolder)
        grpDownloads.Controls.Add(Label1)
        grpDownloads.Controls.Add(btnSetDownloadFolder)
        grpDownloads.Location = New Point(769, 270)
        grpDownloads.Name = "grpDownloads"
        grpDownloads.Size = New Size(168, 191)
        grpDownloads.TabIndex = 22
        grpDownloads.TabStop = False
        grpDownloads.Text = "Paths"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Quicksand", 8.25F)
        Label6.Location = New Point(87, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 16)
        Label6.TabIndex = 7
        Label6.Text = "Osu! Folder :"
        ' 
        ' btnSetOsuFolder
        ' 
        btnSetOsuFolder.Image = My.Resources.Resources.icons8_browse_folder_20
        btnSetOsuFolder.ImageAlign = ContentAlignment.MiddleLeft
        btnSetOsuFolder.Location = New Point(84, 149)
        btnSetOsuFolder.Name = "btnSetOsuFolder"
        btnSetOsuFolder.Size = New Size(79, 23)
        btnSetOsuFolder.TabIndex = 6
        btnSetOsuFolder.Text = "Browse"
        btnSetOsuFolder.TextAlign = ContentAlignment.MiddleRight
        btnSetOsuFolder.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Quicksand", 8.25F)
        Label4.Location = New Point(80, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 16)
        Label4.TabIndex = 4
        Label4.Text = "Temp Folder :"
        ' 
        ' btnSetTempFolder
        ' 
        btnSetTempFolder.Image = My.Resources.Resources.icons8_browse_folder_20
        btnSetTempFolder.ImageAlign = ContentAlignment.MiddleLeft
        btnSetTempFolder.Location = New Point(84, 97)
        btnSetTempFolder.Name = "btnSetTempFolder"
        btnSetTempFolder.Size = New Size(79, 23)
        btnSetTempFolder.TabIndex = 3
        btnSetTempFolder.Text = "Browse"
        btnSetTempFolder.TextAlign = ContentAlignment.MiddleRight
        btnSetTempFolder.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Quicksand", 8.25F)
        Label1.Location = New Point(63, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 16)
        Label1.TabIndex = 1
        Label1.Text = "Download Folder :"
        ' 
        ' btnSetDownloadFolder
        ' 
        btnSetDownloadFolder.Image = My.Resources.Resources.icons8_browse_folder_20
        btnSetDownloadFolder.ImageAlign = ContentAlignment.MiddleLeft
        btnSetDownloadFolder.Location = New Point(84, 30)
        btnSetDownloadFolder.Name = "btnSetDownloadFolder"
        btnSetDownloadFolder.Size = New Size(79, 23)
        btnSetDownloadFolder.TabIndex = 0
        btnSetDownloadFolder.Text = "Browse"
        btnSetDownloadFolder.TextAlign = ContentAlignment.MiddleRight
        btnSetDownloadFolder.UseVisualStyleBackColor = True
        ' 
        ' cbFilter
        ' 
        cbFilter.AutoCompleteMode = AutoCompleteMode.Suggest
        cbFilter.AutoCompleteSource = AutoCompleteSource.CustomSource
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
        chkSingleGraveyard.Location = New Point(165, 214)
        chkSingleGraveyard.Name = "chkSingleGraveyard"
        chkSingleGraveyard.Size = New Size(70, 90)
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
        chkSinglePersonal.Location = New Point(87, 10)
        chkSinglePersonal.Name = "chkSinglePersonal"
        chkSinglePersonal.Size = New Size(70, 90)
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
        chkSingleWIP.Location = New Point(87, 214)
        chkSingleWIP.Name = "chkSingleWIP"
        chkSingleWIP.Size = New Size(70, 90)
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
        chkSingleLeaderBoard.Location = New Point(9, 112)
        chkSingleLeaderBoard.Name = "chkSingleLeaderBoard"
        chkSingleLeaderBoard.Size = New Size(70, 90)
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
        chkSinglePending.Location = New Point(9, 214)
        chkSinglePending.Name = "chkSinglePending"
        chkSinglePending.Size = New Size(70, 90)
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
        chkSingleQualified.Location = New Point(165, 112)
        chkSingleQualified.Name = "chkSingleQualified"
        chkSingleQualified.Size = New Size(70, 90)
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
        chkSingleLoved.Location = New Point(165, 10)
        chkSingleLoved.Name = "chkSingleLoved"
        chkSingleLoved.Size = New Size(70, 90)
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
        chkSingleRanked.Location = New Point(87, 112)
        chkSingleRanked.Name = "chkSingleRanked"
        chkSingleRanked.Size = New Size(70, 90)
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
        chkSingleFaves.Location = New Point(9, 10)
        chkSingleFaves.Name = "chkSingleFaves"
        chkSingleFaves.Size = New Size(70, 90)
        chkSingleFaves.TabIndex = 25
        chkSingleFaves.Text = "Faves"
        chkSingleFaves.TextAlign = ContentAlignment.MiddleCenter
        chkSingleFaves.TextImageRelation = TextImageRelation.ImageAboveText
        chkSingleFaves.UseVisualStyleBackColor = False
        ' 
        ' tpPacks
        ' 
        tpPacks.Controls.Add(chkPackArtist)
        tpPacks.Controls.Add(chkPackTheme)
        tpPacks.Controls.Add(chkPackFeatured)
        tpPacks.Controls.Add(chkPackTournament)
        tpPacks.Controls.Add(chkPackLoved)
        tpPacks.Controls.Add(chkPackSpotlight)
        tpPacks.Controls.Add(chkPackStandard)
        tpPacks.Location = New Point(4, 27)
        tpPacks.Name = "tpPacks"
        tpPacks.Padding = New Padding(3)
        tpPacks.Size = New Size(245, 315)
        tpPacks.TabIndex = 0
        tpPacks.Text = "Packs"
        tpPacks.UseVisualStyleBackColor = True
        ' 
        ' chkPackArtist
        ' 
        chkPackArtist.Appearance = Appearance.Button
        chkPackArtist.BackColor = SystemColors.Control
        chkPackArtist.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackArtist.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackArtist.FlatStyle = FlatStyle.Flat
        chkPackArtist.Font = New Font("Quicksand", 9F)
        chkPackArtist.ImageKey = "icons8-album-24.png"
        chkPackArtist.ImageList = ilCategoriesColor
        chkPackArtist.Location = New Point(9, 71)
        chkPackArtist.Name = "chkPackArtist"
        chkPackArtist.Size = New Size(70, 113)
        chkPackArtist.TabIndex = 33
        chkPackArtist.Text = "Artst"
        chkPackArtist.TextAlign = ContentAlignment.BottomCenter
        chkPackArtist.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackArtist.UseVisualStyleBackColor = False
        ' 
        ' chkPackTheme
        ' 
        chkPackTheme.Appearance = Appearance.Button
        chkPackTheme.BackColor = SystemColors.Control
        chkPackTheme.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackTheme.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackTheme.FlatStyle = FlatStyle.Flat
        chkPackTheme.Font = New Font("Quicksand", 9F)
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
        chkPackFeatured.Font = New Font("Quicksand", 9F)
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
        chkPackTournament.Font = New Font("Quicksand", 9F)
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
        chkPackLoved.Font = New Font("Quicksand", 9F)
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
        ' chkPackSpotlight
        ' 
        chkPackSpotlight.Appearance = Appearance.Button
        chkPackSpotlight.BackColor = SystemColors.Control
        chkPackSpotlight.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackSpotlight.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackSpotlight.FlatStyle = FlatStyle.Flat
        chkPackSpotlight.Font = New Font("Quicksand", 9F)
        chkPackSpotlight.ImageKey = "icons8-spotlight-24-col.png"
        chkPackSpotlight.ImageList = ilCategoriesColor
        chkPackSpotlight.Location = New Point(87, 193)
        chkPackSpotlight.Name = "chkPackSpotlight"
        chkPackSpotlight.Size = New Size(70, 113)
        chkPackSpotlight.TabIndex = 28
        chkPackSpotlight.Text = "Spotlight"
        chkPackSpotlight.TextAlign = ContentAlignment.BottomCenter
        chkPackSpotlight.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackSpotlight.UseVisualStyleBackColor = False
        ' 
        ' chkPackStandard
        ' 
        chkPackStandard.Appearance = Appearance.Button
        chkPackStandard.BackColor = SystemColors.Control
        chkPackStandard.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        chkPackStandard.FlatAppearance.CheckedBackColor = SystemColors.ActiveCaption
        chkPackStandard.FlatStyle = FlatStyle.Flat
        chkPackStandard.Font = New Font("Quicksand", 9.75F)
        chkPackStandard.ImageKey = "icons8-osu-24-col.png"
        chkPackStandard.ImageList = ilCategoriesColor
        chkPackStandard.Location = New Point(9, 9)
        chkPackStandard.Name = "chkPackStandard"
        chkPackStandard.Size = New Size(227, 53)
        chkPackStandard.TabIndex = 27
        chkPackStandard.Text = "Standard"
        chkPackStandard.TextAlign = ContentAlignment.MiddleCenter
        chkPackStandard.TextImageRelation = TextImageRelation.ImageAboveText
        chkPackStandard.UseVisualStyleBackColor = False
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
        ' fdbDownloadFolder
        ' 
        fdbDownloadFolder.InitialDirectory = "C:\"
        ' 
        ' fdbTempFolder
        ' 
        fdbTempFolder.InitialDirectory = "C:\"
        ' 
        ' fdbOsuFolder
        ' 
        fdbOsuFolder.InitialDirectory = "C:\"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Quicksand", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 14)
        Label2.TabIndex = 8
        Label2.Text = "C:\users\butt\wee\omgwoo.png"
        ' 
        ' FrmMain
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
        Name = "FrmMain"
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
        grpDownloads.PerformLayout()
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
    Friend WithEvents tslAuthenticatedValue As ToolStripStatusLabel
    Friend WithEvents tssSep1 As ToolStripStatusLabel
    Friend WithEvents tslCacheValue As ToolStripStatusLabel
    Friend WithEvents tslPulledValue As ToolStripStatusLabel
    Friend WithEvents tslSep2 As ToolStripStatusLabel
    Friend WithEvents tslSpacer As ToolStripStatusLabel
    Friend WithEvents lblBatchSizeValue As Label
    Friend WithEvents lblBatchSizeLabel As Label
    Friend WithEvents tbBatchSize As TrackBar
    Friend WithEvents tslBrowser As ToolStripStatusLabel
    Friend WithEvents ilBrowsers As ImageList
    Friend WithEvents tvListings As TreeView
    Friend WithEvents btnPullSelected As Button
    Friend WithEvents grpSession As GroupBox
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents grpListings As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents grpDownloads As GroupBox
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents imlLists As ImageList
    Friend WithEvents tpSingles As TabPage
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
    Friend WithEvents chkPackArtist As CheckBox
    Friend WithEvents chkPackTheme As CheckBox
    Friend WithEvents chkPackFeatured As CheckBox
    Friend WithEvents chkPackTournament As CheckBox
    Friend WithEvents chkPackLoved As CheckBox
    Friend WithEvents chkPackSpotlight As CheckBox
    Friend WithEvents chkPackStandard As CheckBox
    Friend WithEvents tcMainTabs As TabControl
    Friend WithEvents ilCategoriesColor As ImageList
    Friend WithEvents prgPrimaryTask As ProgressBar
    Friend WithEvents prgSecondaryTask As ProgressBar
    Friend WithEvents lblProgressSecondaryLabel As Label
    Friend WithEvents lblProgressPrimaryLabel As Label
    Friend WithEvents tslDatabase As ToolStripStatusLabel
    Friend WithEvents tslSep4 As ToolStripStatusLabel
    Friend WithEvents btnCheckSession As Button
    Friend WithEvents tslStatus As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSetDownloadFolder As Button
    Friend WithEvents fdbDownloadFolder As FolderBrowserDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSetOsuFolder As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSetTempFolder As Button
    Friend WithEvents fdbTempFolder As FolderBrowserDialog
    Friend WithEvents fdbOsuFolder As FolderBrowserDialog
    Friend WithEvents Label2 As Label
End Class
