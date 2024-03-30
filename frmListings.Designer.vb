<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListings
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
        Dim TreeNode2 As TreeNode = New TreeNode("Packs")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListings))
        PictureBox1 = New PictureBox()
        tvListings = New TreeView()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = My.Resources.Resources.os_logo_blue
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(416, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' tvListings
        ' 
        tvListings.CheckBoxes = True
        tvListings.Dock = DockStyle.Left
        tvListings.FullRowSelect = True
        tvListings.Location = New Point(0, 112)
        tvListings.Name = "tvListings"
        TreeNode2.Name = "tndPacks"
        TreeNode2.NodeFont = New Font("Quicksand", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TreeNode2.Text = "Packs"
        tvListings.Nodes.AddRange(New TreeNode() {TreeNode2})
        tvListings.Size = New Size(179, 280)
        tvListings.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 102)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(416, 10)
        Panel1.TabIndex = 2
        ' 
        ' FrmListings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 392)
        Controls.Add(tvListings)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FrmListings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OsuScraper - Listings"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tvListings As TreeView
    Friend WithEvents Panel1 As Panel
End Class
