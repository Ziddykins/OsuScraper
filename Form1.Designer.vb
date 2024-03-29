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
        pbLogo = New PictureBox()
        grpModes = New GroupBox()
        chkModeTaiko = New CheckBox()
        imlModes = New ImageList(components)
        chkModeMania = New CheckBox()
        chkModeCatch = New CheckBox()
        chkModeOsu = New CheckBox()
        grpCategories = New GroupBox()
        chkCatGraveyard = New CheckBox()
        imlCategories = New ImageList(components)
        chkCatPersonal = New CheckBox()
        chkCatWorkInProgress = New CheckBox()
        chkCatLeaderBoard = New CheckBox()
        chkCatPending = New CheckBox()
        chkCatQualified = New CheckBox()
        chkCatLoved = New CheckBox()
        chkCatRanked = New CheckBox()
        chkCatFaves = New CheckBox()
        chkCatAny = New CheckBox()
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
        btnOpenListings = New Button()
        btnLogin = New Button()
        btnScrape = New Button()
        chkOverwriteExistingFiles = New CheckBox()
        btnAutoFill = New Button()
        lblXSRFTokenLabel = New Label()
        lblSessionLabel = New Label()
        txtXSRFToken = New TextBox()
        txtSessionToken = New TextBox()
        chkVerboseLogging = New CheckBox()
        chkNoExtractArchives = New CheckBox()
        chkDisregardCache = New CheckBox()
        lblSleepInterval = New Label()
        lblSleepIntervalLabel = New Label()
        tbSleepInterval = New TrackBar()
        lblForkValue = New Label()
        lblForkLabel = New Label()
        tbForkValue = New TrackBar()
        ttGeneralHover = New ToolTip(components)
        StatusStrip1 = New StatusStrip()
        tslAuthenticatedLabel = New ToolStripStatusLabel()
        tssAuthenticatedValue = New ToolStripStatusLabel()
        tssSep1 = New ToolStripStatusLabel()
        tssListingsLabel = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        grpModes.SuspendLayout()
        grpCategories.SuspendLayout()
        msMainMenu.SuspendLayout()
        grpConfiguration.SuspendLayout()
        CType(tbSleepInterval, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbForkValue, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Top
        pbLogo.Image = My.Resources.Resources.os_logo
        pbLogo.Location = New Point(0, 24)
        pbLogo.Margin = New Padding(3, 4, 3, 4)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(443, 108)
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
        ' grpCategories
        ' 
        grpCategories.Controls.Add(chkCatGraveyard)
        grpCategories.Controls.Add(chkCatPersonal)
        grpCategories.Controls.Add(chkCatWorkInProgress)
        grpCategories.Controls.Add(chkCatLeaderBoard)
        grpCategories.Controls.Add(chkCatPending)
        grpCategories.Controls.Add(chkCatQualified)
        grpCategories.Controls.Add(chkCatLoved)
        grpCategories.Controls.Add(chkCatRanked)
        grpCategories.Controls.Add(chkCatFaves)
        grpCategories.Controls.Add(chkCatAny)
        grpCategories.Location = New Point(2, 238)
        grpCategories.Margin = New Padding(3, 4, 3, 4)
        grpCategories.Name = "grpCategories"
        grpCategories.Padding = New Padding(3, 4, 3, 4)
        grpCategories.Size = New Size(256, 293)
        grpCategories.TabIndex = 2
        grpCategories.TabStop = False
        grpCategories.Text = "Category"
        ' 
        ' chkCatGraveyard
        ' 
        chkCatGraveyard.Appearance = Appearance.Button
        chkCatGraveyard.Font = New Font("Quicksand", 8.25F)
        chkCatGraveyard.ImageKey = "icons8-cemetery-24.png"
        chkCatGraveyard.ImageList = imlCategories
        chkCatGraveyard.Location = New Point(170, 220)
        chkCatGraveyard.Name = "chkCatGraveyard"
        chkCatGraveyard.Size = New Size(70, 62)
        chkCatGraveyard.TabIndex = 2
        chkCatGraveyard.Text = "Grvyrd"
        chkCatGraveyard.TextAlign = ContentAlignment.MiddleCenter
        chkCatGraveyard.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatGraveyard.UseVisualStyleBackColor = True
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
        ' 
        ' chkCatPersonal
        ' 
        chkCatPersonal.Appearance = Appearance.Button
        chkCatPersonal.Font = New Font("Quicksand", 8.25F)
        chkCatPersonal.ImageKey = "icons8-test-account-24.png"
        chkCatPersonal.ImageList = imlCategories
        chkCatPersonal.Location = New Point(92, 85)
        chkCatPersonal.Name = "chkCatPersonal"
        chkCatPersonal.Size = New Size(70, 62)
        chkCatPersonal.TabIndex = 1
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
        chkCatWorkInProgress.Location = New Point(92, 220)
        chkCatWorkInProgress.Name = "chkCatWorkInProgress"
        chkCatWorkInProgress.Size = New Size(70, 62)
        chkCatWorkInProgress.TabIndex = 3
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
        chkCatLeaderBoard.Location = New Point(14, 152)
        chkCatLeaderBoard.Name = "chkCatLeaderBoard"
        chkCatLeaderBoard.Size = New Size(70, 62)
        chkCatLeaderBoard.TabIndex = 0
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
        chkCatPending.Location = New Point(14, 220)
        chkCatPending.Name = "chkCatPending"
        chkCatPending.Size = New Size(70, 62)
        chkCatPending.TabIndex = 4
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
        chkCatQualified.Location = New Point(170, 152)
        chkCatQualified.Name = "chkCatQualified"
        chkCatQualified.Size = New Size(70, 62)
        chkCatQualified.TabIndex = 7
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
        chkCatLoved.Location = New Point(170, 85)
        chkCatLoved.Name = "chkCatLoved"
        chkCatLoved.Size = New Size(70, 62)
        chkCatLoved.TabIndex = 6
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
        chkCatRanked.Location = New Point(92, 152)
        chkCatRanked.Name = "chkCatRanked"
        chkCatRanked.Size = New Size(70, 62)
        chkCatRanked.TabIndex = 8
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
        chkCatFaves.Location = New Point(14, 85)
        chkCatFaves.Name = "chkCatFaves"
        chkCatFaves.Size = New Size(70, 62)
        chkCatFaves.TabIndex = 5
        chkCatFaves.Text = "Faves"
        chkCatFaves.TextAlign = ContentAlignment.MiddleCenter
        chkCatFaves.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatFaves.UseVisualStyleBackColor = True
        ' 
        ' chkCatAny
        ' 
        chkCatAny.Appearance = Appearance.Button
        chkCatAny.Font = New Font("Quicksand", 8.25F)
        chkCatAny.ImageKey = "icons8-all-24.png"
        chkCatAny.ImageList = imlCategories
        chkCatAny.Location = New Point(14, 26)
        chkCatAny.Name = "chkCatAny"
        chkCatAny.Size = New Size(226, 53)
        chkCatAny.TabIndex = 9
        chkCatAny.Text = "Any"
        chkCatAny.TextAlign = ContentAlignment.MiddleCenter
        chkCatAny.TextImageRelation = TextImageRelation.ImageAboveText
        chkCatAny.UseVisualStyleBackColor = True
        ' 
        ' msMainMenu
        ' 
        msMainMenu.ImageScalingSize = New Size(24, 24)
        msMainMenu.Items.AddRange(New ToolStripItem() {tsmFile, tsmListings, tsmOptions, tsmHelp})
        msMainMenu.Location = New Point(0, 0)
        msMainMenu.Name = "msMainMenu"
        msMainMenu.Size = New Size(443, 24)
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
        grpConfiguration.Controls.Add(btnOpenListings)
        grpConfiguration.Controls.Add(btnLogin)
        grpConfiguration.Controls.Add(btnScrape)
        grpConfiguration.Controls.Add(chkOverwriteExistingFiles)
        grpConfiguration.Controls.Add(btnAutoFill)
        grpConfiguration.Controls.Add(lblXSRFTokenLabel)
        grpConfiguration.Controls.Add(lblSessionLabel)
        grpConfiguration.Controls.Add(txtXSRFToken)
        grpConfiguration.Controls.Add(txtSessionToken)
        grpConfiguration.Controls.Add(chkVerboseLogging)
        grpConfiguration.Controls.Add(chkNoExtractArchives)
        grpConfiguration.Controls.Add(chkDisregardCache)
        grpConfiguration.Controls.Add(lblSleepInterval)
        grpConfiguration.Controls.Add(lblSleepIntervalLabel)
        grpConfiguration.Controls.Add(tbSleepInterval)
        grpConfiguration.Controls.Add(lblForkValue)
        grpConfiguration.Controls.Add(lblForkLabel)
        grpConfiguration.Controls.Add(tbForkValue)
        grpConfiguration.Location = New Point(264, 140)
        grpConfiguration.Name = "grpConfiguration"
        grpConfiguration.Size = New Size(176, 391)
        grpConfiguration.TabIndex = 4
        grpConfiguration.TabStop = False
        grpConfiguration.Text = "Configuration"
        ' 
        ' btnOpenListings
        ' 
        btnOpenListings.AutoSize = True
        btnOpenListings.FlatAppearance.BorderColor = Color.IndianRed
        btnOpenListings.FlatStyle = FlatStyle.Popup
        btnOpenListings.Font = New Font("Quicksand", 9F)
        btnOpenListings.Location = New Point(13, 243)
        btnOpenListings.Name = "btnOpenListings"
        btnOpenListings.Size = New Size(145, 36)
        btnOpenListings.TabIndex = 15
        btnOpenListings.Text = "Open Listings"
        btnOpenListings.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.Font = New Font("Quicksand", 9F)
        btnLogin.Location = New Point(86, 209)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(70, 36)
        btnLogin.TabIndex = 14
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnScrape
        ' 
        btnScrape.AutoSize = True
        btnScrape.FlatAppearance.BorderColor = Color.IndianRed
        btnScrape.FlatStyle = FlatStyle.Flat
        btnScrape.Font = New Font("Quicksand", 9F)
        btnScrape.Location = New Point(12, 279)
        btnScrape.Name = "btnScrape"
        btnScrape.Size = New Size(145, 38)
        btnScrape.TabIndex = 6
        btnScrape.Text = "Scrape"
        btnScrape.UseVisualStyleBackColor = True
        ' 
        ' chkOverwriteExistingFiles
        ' 
        chkOverwriteExistingFiles.AutoSize = True
        chkOverwriteExistingFiles.Location = New Point(10, 368)
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
        btnAutoFill.Font = New Font("Quicksand", 9F)
        btnAutoFill.Location = New Point(10, 209)
        btnAutoFill.Name = "btnAutoFill"
        btnAutoFill.Size = New Size(90, 36)
        btnAutoFill.TabIndex = 5
        btnAutoFill.Text = "Auto-Fill"
        btnAutoFill.UseVisualStyleBackColor = True
        ' 
        ' lblXSRFTokenLabel
        ' 
        lblXSRFTokenLabel.AutoSize = True
        lblXSRFTokenLabel.Location = New Point(81, 163)
        lblXSRFTokenLabel.Name = "lblXSRFTokenLabel"
        lblXSRFTokenLabel.Size = New Size(75, 18)
        lblXSRFTokenLabel.TabIndex = 12
        lblXSRFTokenLabel.Text = "XSRF Token:"
        ' 
        ' lblSessionLabel
        ' 
        lblSessionLabel.AutoSize = True
        lblSessionLabel.Location = New Point(36, 119)
        lblSessionLabel.Name = "lblSessionLabel"
        lblSessionLabel.Size = New Size(121, 18)
        lblSessionLabel.TabIndex = 11
        lblSessionLabel.Text = "Osu! Session Cookie:"
        ' 
        ' txtXSRFToken
        ' 
        txtXSRFToken.Location = New Point(10, 181)
        txtXSRFToken.Name = "txtXSRFToken"
        txtXSRFToken.PlaceholderText = "XSRF-TOKEN:""<TOKEN>"""
        txtXSRFToken.Size = New Size(147, 22)
        txtXSRFToken.TabIndex = 10
        ' 
        ' txtSessionToken
        ' 
        txtSessionToken.Location = New Point(10, 137)
        txtSessionToken.Name = "txtSessionToken"
        txtSessionToken.PlaceholderText = "osu_session:""<TOKEN>"""
        txtSessionToken.Size = New Size(148, 22)
        txtSessionToken.TabIndex = 9
        ' 
        ' chkVerboseLogging
        ' 
        chkVerboseLogging.AutoSize = True
        chkVerboseLogging.Location = New Point(10, 350)
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
        chkNoExtractArchives.Location = New Point(10, 332)
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
        chkDisregardCache.Location = New Point(10, 314)
        chkDisregardCache.Name = "chkDisregardCache"
        chkDisregardCache.Size = New Size(145, 22)
        chkDisregardCache.TabIndex = 6
        chkDisregardCache.Text = "Disregard cache files"
        ttGeneralHover.SetToolTip(chkDisregardCache, "Ignores any cached songs and re-pulls the list and download locations fresh from the server")
        chkDisregardCache.UseVisualStyleBackColor = True
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
        tbSleepInterval.Location = New Point(4, 89)
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
        tbForkValue.Location = New Point(4, 43)
        tbForkValue.Maximum = 25
        tbForkValue.Name = "tbForkValue"
        tbForkValue.Size = New Size(161, 24)
        tbForkValue.TabIndex = 0
        tbForkValue.TickStyle = TickStyle.TopLeft
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {tslAuthenticatedLabel, tssAuthenticatedValue, tssSep1, tssListingsLabel, ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 540)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(443, 22)
        StatusStrip1.TabIndex = 5
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tslAuthenticatedLabel
        ' 
        tslAuthenticatedLabel.Name = "tslAuthenticatedLabel"
        tslAuthenticatedLabel.Size = New Size(85, 17)
        tslAuthenticatedLabel.Text = "Authenticated:"
        ' 
        ' tssAuthenticatedValue
        ' 
        tssAuthenticatedValue.ForeColor = Color.Red
        tssAuthenticatedValue.Name = "tssAuthenticatedValue"
        tssAuthenticatedValue.Size = New Size(23, 17)
        tssAuthenticatedValue.Text = "No"
        ' 
        ' tssSep1
        ' 
        tssSep1.Name = "tssSep1"
        tssSep1.Size = New Size(10, 17)
        tssSep1.Text = "|"
        ' 
        ' tssListingsLabel
        ' 
        tssListingsLabel.Name = "tssListingsLabel"
        tssListingsLabel.Size = New Size(50, 17)
        tssListingsLabel.Text = "Listings:"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(120, 17)
        ToolStripStatusLabel1.Text = "No Cache/Not Pulled"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(443, 562)
        Controls.Add(StatusStrip1)
        Controls.Add(grpConfiguration)
        Controls.Add(grpCategories)
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
        grpModes.PerformLayout()
        grpCategories.ResumeLayout(False)
        msMainMenu.ResumeLayout(False)
        msMainMenu.PerformLayout()
        grpConfiguration.ResumeLayout(False)
        grpConfiguration.PerformLayout()
        CType(tbSleepInterval, ComponentModel.ISupportInitialize).EndInit()
        CType(tbForkValue, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents grpModes As GroupBox
    Friend WithEvents grpCategories As GroupBox
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
    Friend WithEvents chkCatGraveyard As CheckBox
    Friend WithEvents imlCategories As ImageList
    Friend WithEvents chkCatPersonal As CheckBox
    Friend WithEvents chkCatWorkInProgress As CheckBox
    Friend WithEvents chkCatLeaderBoard As CheckBox
    Friend WithEvents chkCatPending As CheckBox
    Friend WithEvents chkCatQualified As CheckBox
    Friend WithEvents chkCatLoved As CheckBox
    Friend WithEvents chkCatRanked As CheckBox
    Friend WithEvents chkCatFaves As CheckBox
    Friend WithEvents chkCatAny As CheckBox
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
    Friend WithEvents btnScrape As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnOpenListings As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslAuthenticatedLabel As ToolStripStatusLabel
    Friend WithEvents tssAuthenticatedValue As ToolStripStatusLabel
    Friend WithEvents tssSep1 As ToolStripStatusLabel
    Friend WithEvents tssListingsLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
