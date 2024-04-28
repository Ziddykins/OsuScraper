<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnClose = New Button()
        lblHelpText = New Label()
        pbHelpLogo = New PictureBox()
        llOsuSite = New LinkLabel()
        Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        CType(pbHelpLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        Guna2Transition1.SetDecoration(btnClose, Guna.UI2.AnimatorNS.DecorationType.None)
        btnClose.FlatStyle = FlatStyle.Popup
        btnClose.Location = New Point(360, 303)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(44, 23)
        btnClose.TabIndex = 6
        btnClose.Text = "&Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblHelpText
        ' 
        lblHelpText.AutoSize = True
        Guna2Transition1.SetDecoration(lblHelpText, Guna.UI2.AnimatorNS.DecorationType.None)
        lblHelpText.Font = New Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHelpText.Location = New Point(12, 127)
        lblHelpText.Name = "lblHelpText"
        lblHelpText.Size = New Size(362, 133)
        lblHelpText.TabIndex = 5
        lblHelpText.Text = "1. Login to         with your browser" & vbCrLf & vbCrLf & "2. Click the AutoFill button in OsuScraper" & vbCrLf & vbCrLf & "3. The session cookies should be pulled from your browser" & vbCrLf & vbCrLf & "4. You should now be able to browse/download"
        ' 
        ' pbHelpLogo
        ' 
        Guna2Transition1.SetDecoration(pbHelpLogo, Guna.UI2.AnimatorNS.DecorationType.None)
        pbHelpLogo.Dock = DockStyle.Top
        pbHelpLogo.Image = My.Resources.Resources.os_logo_green
        pbHelpLogo.Location = New Point(0, 0)
        pbHelpLogo.Name = "pbHelpLogo"
        pbHelpLogo.Size = New Size(892, 102)
        pbHelpLogo.SizeMode = PictureBoxSizeMode.AutoSize
        pbHelpLogo.TabIndex = 4
        pbHelpLogo.TabStop = False
        ' 
        ' llOsuSite
        ' 
        llOsuSite.AutoSize = True
        Guna2Transition1.SetDecoration(llOsuSite, Guna.UI2.AnimatorNS.DecorationType.None)
        llOsuSite.Location = New Point(79, 128)
        llOsuSite.Name = "llOsuSite"
        llOsuSite.Size = New Size(31, 15)
        llOsuSite.TabIndex = 7
        llOsuSite.TabStop = True
        llOsuSite.Text = "Osu!"
        ' 
        ' Guna2Transition1
        ' 
        Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf
        Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), PointF)
        Animation1.LeafCoeff = 1F
        Animation1.MaxTime = 1F
        Animation1.MinTime = 0F
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0F
        Animation1.RotateLimit = 0F
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), PointF)
        Animation1.TimeCoeff = 0F
        Animation1.TransparencyCoeff = 0F
        Guna2Transition1.DefaultAnimation = Animation1
        ' 
        ' Guna2TileButton1
        ' 
        Guna2TileButton1.BorderThickness = 1
        Guna2TileButton1.CustomizableEdges = CustomizableEdges1
        Guna2Transition1.SetDecoration(Guna2TileButton1, Guna.UI2.AnimatorNS.DecorationType.BottomMirror)
        Guna2TileButton1.DialogResult = DialogResult.TryAgain
        Guna2TileButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2TileButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2TileButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2TileButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2TileButton1.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TileButton1.Font = New Font("Quicksand Light", 11.25F)
        Guna2TileButton1.ForeColor = Color.White
        Guna2TileButton1.Location = New Point(521, 0)
        Guna2TileButton1.Name = "Guna2TileButton1"
        Guna2TileButton1.PressedColor = Color.DarkRed
        Guna2TileButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TileButton1.Size = New Size(97, 102)
        Guna2TileButton1.TabIndex = 8
        Guna2TileButton1.Text = "U"
        ' 
        ' Guna2TileButton2
        ' 
        Guna2TileButton2.BorderThickness = 1
        Guna2TileButton2.CustomizableEdges = CustomizableEdges3
        Guna2Transition1.SetDecoration(Guna2TileButton2, Guna.UI2.AnimatorNS.DecorationType.BottomMirror)
        Guna2TileButton2.DialogResult = DialogResult.TryAgain
        Guna2TileButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2TileButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2TileButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2TileButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2TileButton2.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TileButton2.Font = New Font("Quicksand Light", 11.25F)
        Guna2TileButton2.ForeColor = Color.White
        Guna2TileButton2.Location = New Point(424, 0)
        Guna2TileButton2.Name = "Guna2TileButton2"
        Guna2TileButton2.PressedColor = Color.LightGreen
        Guna2TileButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2TileButton2.Size = New Size(97, 102)
        Guna2TileButton2.TabIndex = 9
        Guna2TileButton2.Text = "F"
        Guna2TileButton2.TextAlign = HorizontalAlignment.Left
        ' 
        ' Guna2TileButton3
        ' 
        Guna2TileButton3.BorderThickness = 1
        Guna2TileButton3.CustomizableEdges = CustomizableEdges5
        Guna2Transition1.SetDecoration(Guna2TileButton3, Guna.UI2.AnimatorNS.DecorationType.BottomMirror)
        Guna2TileButton3.DialogResult = DialogResult.TryAgain
        Guna2TileButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2TileButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2TileButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2TileButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2TileButton3.FillColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Guna2TileButton3.Font = New Font("Quicksand Light", 11.25F)
        Guna2TileButton3.ForeColor = Color.White
        Guna2TileButton3.Location = New Point(618, 0)
        Guna2TileButton3.Name = "Guna2TileButton3"
        Guna2TileButton3.PressedColor = SystemColors.ActiveCaption
        Guna2TileButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2TileButton3.Size = New Size(97, 102)
        Guna2TileButton3.TabIndex = 10
        Guna2TileButton3.Text = "G"
        Guna2TileButton3.TextAlign = HorizontalAlignment.Right
        ' 
        ' FrmHelp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(892, 621)
        Controls.Add(Guna2TileButton3)
        Controls.Add(Guna2TileButton2)
        Controls.Add(Guna2TileButton1)
        Controls.Add(llOsuSite)
        Controls.Add(btnClose)
        Controls.Add(lblHelpText)
        Controls.Add(pbHelpLogo)
        Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FrmHelp"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmHelp"
        CType(pbHelpLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblHelpText As Label
    Friend WithEvents pbHelpLogo As PictureBox

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents llOsuSite As LinkLabel
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
End Class
