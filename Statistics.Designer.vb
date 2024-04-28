<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim ChartFont1 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont2 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont3 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont4 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid1 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick1 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont5 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid2 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick2 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont6 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid3 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim PointLabel1 As Guna.Charts.WinForms.PointLabel = New Guna.Charts.WinForms.PointLabel()
        Dim ChartFont7 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Tick3 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont8 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim LPoint1 As Guna.Charts.WinForms.LPoint = New Guna.Charts.WinForms.LPoint()
        Dim LPoint2 As Guna.Charts.WinForms.LPoint = New Guna.Charts.WinForms.LPoint()
        Dim LPoint3 As Guna.Charts.WinForms.LPoint = New Guna.Charts.WinForms.LPoint()
        Dim LPoint4 As Guna.Charts.WinForms.LPoint = New Guna.Charts.WinForms.LPoint()
        GunaRadarDataset1 = New Guna.Charts.WinForms.GunaRadarDataset()
        GunaChart1 = New Guna.Charts.WinForms.GunaChart()
        GunaPieDataset1 = New Guna.Charts.WinForms.GunaPieDataset()
        SuspendLayout()
        ' 
        ' GunaRadarDataset1
        ' 
        GunaRadarDataset1.BorderColor = Color.Empty
        GunaRadarDataset1.FillColor = Color.Empty
        GunaRadarDataset1.Label = "Radar1"
        GunaRadarDataset1.PointFillColors.AddRange(New Color() {Color.Lime, Color.Red, Color.Blue, Color.Yellow})
        ' 
        ' GunaChart1
        ' 
        GunaChart1.Datasets.AddRange(New Guna.Charts.Interfaces.IGunaDataset() {GunaPieDataset1})
        ChartFont1.FontName = "Arial"
        GunaChart1.Legend.LabelFont = ChartFont1
        GunaChart1.Location = New Point(-1, -1)
        GunaChart1.Name = "GunaChart1"
        GunaChart1.Size = New Size(653, 353)
        GunaChart1.TabIndex = 0
        ChartFont2.FontName = "Arial"
        ChartFont2.Size = 12
        ChartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart1.Title.Font = ChartFont2
        ChartFont3.FontName = "Arial"
        GunaChart1.Tooltips.BodyFont = ChartFont3
        ChartFont4.FontName = "Arial"
        ChartFont4.Size = 9
        ChartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart1.Tooltips.TitleFont = ChartFont4
        GunaChart1.XAxes.GridLines = Grid1
        ChartFont5.FontName = "Arial"
        Tick1.Font = ChartFont5
        GunaChart1.XAxes.Ticks = Tick1
        GunaChart1.YAxes.GridLines = Grid2
        ChartFont6.FontName = "Arial"
        Tick2.Font = ChartFont6
        GunaChart1.YAxes.Ticks = Tick2
        GunaChart1.ZAxes.GridLines = Grid3
        ChartFont7.FontName = "Arial"
        PointLabel1.Font = ChartFont7
        GunaChart1.ZAxes.PointLabels = PointLabel1
        ChartFont8.FontName = "Arial"
        Tick3.Font = ChartFont8
        GunaChart1.ZAxes.Ticks = Tick3
        ' 
        ' GunaPieDataset1
        ' 
        LPoint1.Label = "Catch"
        LPoint1.Y = 234R
        LPoint2.Label = "Mania"
        LPoint2.Y = 123R
        LPoint3.Label = "Taiko"
        LPoint3.Y = 78R
        LPoint4.Label = "Osu"
        LPoint4.Y = 5R
        GunaPieDataset1.DataPoints.AddRange(New Guna.Charts.WinForms.LPoint() {LPoint1, LPoint2, LPoint3, LPoint4})
        GunaPieDataset1.Label = "Pie1"
        GunaPieDataset1.TargetChart = GunaChart1
        ' 
        ' Statistics
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GunaChart1)
        Name = "Statistics"
        Text = "Statistics"
        ResumeLayout(False)
    End Sub
    Friend WithEvents GunaRadarDataset1 As Guna.Charts.WinForms.GunaRadarDataset
    Friend WithEvents GunaChart1 As Guna.Charts.WinForms.GunaChart
    Friend WithEvents GunaPieDataset1 As Guna.Charts.WinForms.GunaPieDataset
End Class
