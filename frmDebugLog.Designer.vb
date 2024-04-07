<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDebugLog
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
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        clmType = New DataGridViewTextBoxColumn()
        clmName = New DataGridViewTextBoxColumn()
        clmMessage = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Dock = DockStyle.Left
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"All", "Debug", "Info", "Warning", "Error", "HTTP"})
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(65, 460)
        ListBox1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {clmType, clmName, clmMessage})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(65, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(467, 460)
        DataGridView1.TabIndex = 1
        ' 
        ' clmType
        ' 
        clmType.HeaderText = "Type"
        clmType.Name = "clmType"
        clmType.ReadOnly = True
        ' 
        ' clmName
        ' 
        clmName.HeaderText = "Name"
        clmName.Name = "clmName"
        clmName.ReadOnly = True
        ' 
        ' clmMessage
        ' 
        clmMessage.HeaderText = "Message"
        clmMessage.MaxInputLength = 1000000
        clmMessage.Name = "clmMessage"
        clmMessage.ReadOnly = True
        ' 
        ' frmDebugLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(532, 460)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Name = "frmDebugLog"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DebugLog"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents clmType As DataGridViewTextBoxColumn
    Friend WithEvents clmName As DataGridViewTextBoxColumn
    Friend WithEvents clmMessage As DataGridViewTextBoxColumn
End Class
