Public Class FrmListings
    Public Enum GameModes
        Osu
        Taiko
        CatchTheBeat
        Mania
    End Enum

    Public Enum Categories
        Any
        Ranked
        Qualified
        Loved
        Pending
        Graveyard
        Leaderboards
        Favorites
        Mine
        WorkInProgress
    End Enum
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim arrCategories As String() = [Enum].GetNames(GetType(Categories))

        For Each category As String In arrCategories
            tvListings.Nodes(0).Nodes.Add(category.ToString())
        Next
    End Sub

    Private Sub FrmListings_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Me.Visible = False
    End Sub


    Private Sub FrmListings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class