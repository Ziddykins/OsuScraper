Public Class frmListings
    Private Sub frmListings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.CleanUpListings()
    End Sub
End Class