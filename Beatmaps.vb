Public Class Beatmap
    Private mode As GameModes
    Private type As GameType
    Private status As [Enum]
    
    Private convert As Boolean
    Private is_scoreable As Boolean
    
    Private last_updated As DateTime

    Private bpm As Double
    Private cs As Double
    Private difficulty_rating As Double
    Private drain As Double
    
    
    Private accuracy As Integer
    Private beatmapset_id As Integer
    Private count_circles As Integer
    Private count_sliders As Integer
    Private count_spinners As Integer
    
    Private id As Integer
    Private total_length As Integer
    Private user_id As Integer
    
    
    Private hit_length As Integer
    Private mode_int As Integer
    Private passcount As Integer
    Private playcount As Integer
    Private ranked As Integer
    Private max_combo As Integer

    Private version As String
    Private deleted_at As String
    Private url As String
    Private checksum As String

    Friend Function GetMode() As GameModes
        Return mode
    End Function

    Public Function GetPropertyValue(propertyName As String) As Object
        Dim propertyInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(propertyName)
        If propertyInfo IsNot Nothing Then
            Return propertyInfo.GetValue(Me)
        Else
            Throw New ArgumentException("Invalid property name")
        End If
    End Function

    Public Sub SetPropertyValue(propertyName As String, value As Object)
        Dim propertyInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(propertyName)
        If propertyInfo IsNot Nothing Then
            propertyInfo.SetValue(Me, value)
        Else
            Throw New ArgumentException("Invalid property name")
        End If
    End Sub
End Class
Public Enum GameModes
    Osu
    Taiko
    CatchTheBeat
    Mania
End Enum

Public Enum GameSingleCategories
    Ranked
    Qualified
    Loved
    Favorites
    Pending
    Wip
    Graveyard
    Leaderboard
    Mine
End Enum

Public Enum GamePackCategories
    Standard
    Featured
    Tournament
    Loved
    Chart
    Theme
    Artist
End Enum

Public Enum GameType
    Packs
    Singles
End Enum
