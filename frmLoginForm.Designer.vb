<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginForm))
        pbLoginLogo = New PictureBox()
        grpLoginControls = New GroupBox()
        pbInformation = New PictureBox()
        txtPasswordValue = New TextBox()
        txtUsernameValue = New TextBox()
        lblPasswordLabel = New Label()
        lblUsernameLabel = New Label()
        btnCancel = New Button()
        btnClear = New Button()
        btnSubmit = New Button()
        CType(pbLoginLogo, ComponentModel.ISupportInitialize).BeginInit()
        grpLoginControls.SuspendLayout()
        CType(pbInformation, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbLoginLogo
        ' 
        pbLoginLogo.Dock = DockStyle.Top
        pbLoginLogo.Image = My.Resources.Resources.os_logo_green
        pbLoginLogo.Location = New Point(0, 0)
        pbLoginLogo.Name = "pbLoginLogo"
        pbLoginLogo.Size = New Size(356, 81)
        pbLoginLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pbLoginLogo.TabIndex = 0
        pbLoginLogo.TabStop = False
        ' 
        ' grpLoginControls
        ' 
        grpLoginControls.AutoSize = True
        grpLoginControls.Controls.Add(pbInformation)
        grpLoginControls.Controls.Add(txtPasswordValue)
        grpLoginControls.Controls.Add(txtUsernameValue)
        grpLoginControls.Controls.Add(lblPasswordLabel)
        grpLoginControls.Controls.Add(lblUsernameLabel)
        grpLoginControls.Controls.Add(btnCancel)
        grpLoginControls.Controls.Add(btnClear)
        grpLoginControls.Controls.Add(btnSubmit)
        grpLoginControls.Dock = DockStyle.Fill
        grpLoginControls.Font = New Font("Quicksand Light", 11.25F)
        grpLoginControls.Location = New Point(0, 81)
        grpLoginControls.Name = "grpLoginControls"
        grpLoginControls.Size = New Size(356, 129)
        grpLoginControls.TabIndex = 1
        grpLoginControls.TabStop = False
        grpLoginControls.Text = "Login: osu.ppy.sh "
        ' 
        ' pbInformation
        ' 
        pbInformation.Image = My.Resources.Resources.icons8_about_241
        pbInformation.Location = New Point(326, 9)
        pbInformation.Name = "pbInformation"
        pbInformation.Size = New Size(24, 24)
        pbInformation.SizeMode = PictureBoxSizeMode.AutoSize
        pbInformation.TabIndex = 7
        pbInformation.TabStop = False
        ' 
        ' txtPasswordValue
        ' 
        txtPasswordValue.AcceptsReturn = True
        txtPasswordValue.Font = New Font("Quicksand", 9F)
        txtPasswordValue.Location = New Point(102, 62)
        txtPasswordValue.MaxLength = 256
        txtPasswordValue.Name = "txtPasswordValue"
        txtPasswordValue.PasswordChar = "*"c
        txtPasswordValue.Size = New Size(247, 22)
        txtPasswordValue.TabIndex = 1
        txtPasswordValue.TextAlign = HorizontalAlignment.Center
        txtPasswordValue.UseSystemPasswordChar = True
        ' 
        ' txtUsernameValue
        ' 
        txtUsernameValue.Font = New Font("Quicksand", 9F)
        txtUsernameValue.Location = New Point(102, 35)
        txtUsernameValue.MaxLength = 256
        txtUsernameValue.Name = "txtUsernameValue"
        txtUsernameValue.Size = New Size(247, 22)
        txtUsernameValue.TabIndex = 0
        txtUsernameValue.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPasswordLabel
        ' 
        lblPasswordLabel.AutoSize = True
        lblPasswordLabel.Font = New Font("Quicksand", 9F)
        lblPasswordLabel.Location = New Point(32, 62)
        lblPasswordLabel.Name = "lblPasswordLabel"
        lblPasswordLabel.Size = New Size(64, 18)
        lblPasswordLabel.TabIndex = 4
        lblPasswordLabel.Text = "Password:"
        lblPasswordLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblUsernameLabel
        ' 
        lblUsernameLabel.AutoSize = True
        lblUsernameLabel.Font = New Font("Quicksand", 9F)
        lblUsernameLabel.Location = New Point(27, 35)
        lblUsernameLabel.Name = "lblUsernameLabel"
        lblUsernameLabel.Size = New Size(69, 18)
        lblUsernameLabel.TabIndex = 3
        lblUsernameLabel.Text = "Username:"
        lblUsernameLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = True
        btnCancel.Font = New Font("Quicksand", 9F)
        btnCancel.ForeColor = Color.Firebrick
        btnCancel.Location = New Point(102, 94)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(81, 28)
        btnCancel.TabIndex = 2
        btnCancel.Text = "&Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.AutoSize = True
        btnClear.Font = New Font("Quicksand", 9F)
        btnClear.ForeColor = Color.DarkBlue
        btnClear.Location = New Point(188, 94)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(81, 28)
        btnClear.TabIndex = 3
        btnClear.Text = "Cl&ear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.AutoSize = True
        btnSubmit.Font = New Font("Quicksand", 9F)
        btnSubmit.Location = New Point(268, 94)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(81, 28)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' frmLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(356, 210)
        Controls.Add(grpLoginControls)
        Controls.Add(pbLoginLogo)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "OsuScraper - v2.2.1"
        CType(pbLoginLogo, ComponentModel.ISupportInitialize).EndInit()
        grpLoginControls.ResumeLayout(False)
        grpLoginControls.PerformLayout()
        CType(pbInformation, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbLoginLogo As PictureBox
    Friend WithEvents grpLoginControls As GroupBox
    Friend WithEvents txtPasswordValue As TextBox
    Friend WithEvents txtUsernameValue As TextBox
    Friend WithEvents lblPasswordLabel As Label
    Friend WithEvents lblUsernameLabel As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents pbInformation As PictureBox
End Class
