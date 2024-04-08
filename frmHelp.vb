Public Class frmHelp

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Visible = False
    End Sub

    Private Sub llOsuSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llOsuSite.LinkClicked
        Process.Start("firefox https://osu.ppy.sh")
    End Sub
End Class