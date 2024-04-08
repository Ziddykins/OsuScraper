<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        btnClose = New Button()
        lblHelpText = New Label()
        pbHelpLogo = New PictureBox()
        llOsuSite = New LinkLabel()
        CType(pbHelpLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
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
        lblHelpText.Font = New Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHelpText.Location = New Point(12, 127)
        lblHelpText.Name = "lblHelpText"
        lblHelpText.Size = New Size(362, 133)
        lblHelpText.TabIndex = 5
        lblHelpText.Text = "1. Login to         with your browser" & vbCrLf & vbCrLf & "2. Click the AutoFill button in OsuScraper" & vbCrLf & vbCrLf & "3. The session cookies should be pulled from your browser" & vbCrLf & vbCrLf & "4. You should now be able to browse/download"
        ' 
        ' pbHelpLogo
        ' 
        pbHelpLogo.Dock = DockStyle.Top
        pbHelpLogo.Image = My.Resources.Resources.os_logo_green
        pbHelpLogo.Location = New Point(0, 0)
        pbHelpLogo.Name = "pbHelpLogo"
        pbHelpLogo.Size = New Size(414, 102)
        pbHelpLogo.SizeMode = PictureBoxSizeMode.AutoSize
        pbHelpLogo.TabIndex = 4
        pbHelpLogo.TabStop = False
        ' 
        ' llOsuSite
        ' 
        llOsuSite.AutoSize = True
        llOsuSite.Location = New Point(79, 128)
        llOsuSite.Name = "llOsuSite"
        llOsuSite.Size = New Size(31, 15)
        llOsuSite.TabIndex = 7
        llOsuSite.TabStop = True
        llOsuSite.Text = "Osu!"
        ' 
        ' frmHelp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 332)
        Controls.Add(llOsuSite)
        Controls.Add(btnClose)
        Controls.Add(lblHelpText)
        Controls.Add(pbHelpLogo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmHelp"
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
End Class
