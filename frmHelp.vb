Public Class FrmHelp

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Visible = False
    End Sub
End Class