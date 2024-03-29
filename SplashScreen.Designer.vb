<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Version = New Label()
        Copyright = New Label()
        ApplicationTitle = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Version
        ' 
        Version.AutoSize = True
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Version.Location = New Point(240, 174)
        Version.Name = "Version"
        Version.Size = New Size(101, 15)
        Version.TabIndex = 4
        Version.Text = "Version {0}.{1:00}"
        ' 
        ' Copyright
        ' 
        Copyright.AutoSize = True
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Copyright.Location = New Point(240, 156)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(58, 15)
        Copyright.TabIndex = 5
        Copyright.Text = "Copyright"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.AutoSize = True
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ApplicationTitle.Location = New Point(240, 127)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(186, 29)
        ApplicationTitle.TabIndex = 3
        ApplicationTitle.Text = "Application Title"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.os_logo
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(414, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 50000
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(445, 208)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(Version)
        Controls.Add(Copyright)
        Controls.Add(ApplicationTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer

End Class
