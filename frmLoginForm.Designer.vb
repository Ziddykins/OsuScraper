<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginForm
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
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = My.Resources.Resources.os_logo_green
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(356, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Quicksand Light", 11.25F)
        GroupBox1.Location = New Point(0, 102)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(356, 169)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login: osu.ppy.sh "
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.output_AkFn1N
        PictureBox2.Location = New Point(17, 137)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 20)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.AcceptsReturn = True
        TextBox2.Font = New Font("Quicksand", 8.25F)
        TextBox2.Location = New Point(102, 66)
        TextBox2.MaxLength = 256
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(242, 21)
        TextBox2.TabIndex = 6
        TextBox2.TextAlign = HorizontalAlignment.Center
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Quicksand", 8.25F)
        TextBox1.Location = New Point(102, 39)
        TextBox1.MaxLength = 256
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(242, 21)
        TextBox1.TabIndex = 5
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Quicksand Light", 11.25F)
        Label2.Location = New Point(17, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Quicksand Light", 11.25F)
        Label1.Location = New Point(12, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 23)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.Font = New Font("Quicksand Light", 11.25F)
        Button3.ForeColor = Color.Firebrick
        Button3.Location = New Point(102, 98)
        Button3.Name = "Button3"
        Button3.Size = New Size(81, 38)
        Button3.TabIndex = 2
        Button3.Text = "&Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Quicksand Light", 11.25F)
        Button2.ForeColor = Color.DarkBlue
        Button2.Location = New Point(185, 98)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 38)
        Button2.TabIndex = 1
        Button2.Text = "Cl&ear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Quicksand Light", 11.25F)
        Button1.Location = New Point(268, 98)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 38)
        Button1.TabIndex = 0
        Button1.Text = "&Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(356, 271)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "OsuScraper - v2.2.1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
