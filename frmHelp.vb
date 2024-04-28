Public Class FrmHelp

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Visible = False
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        Guna2Transition1.Show(Guna2TileButton3)
    End Sub

End Class