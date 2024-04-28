Imports System.Data.SQLite
Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports System.Text.RegularExpressions

Public Class OsuCatelogue
    Protected beatmapsets() As beatmapsets

    Private Function AddToCatelogue(beatmapset As Beatmapset)

        Return 1
    End Function

    Private Function GetPropertyValue(propertyName As String) As Object
        Dim propertyInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(propertyName)
        If propertyInfo IsNot Nothing Then
            Return propertyInfo.GetValue(Me)
        Else
            Throw New ArgumentException("Invalid property name")
        End If
    End Function

    Private Sub SetPropertyValue(propertyName As String, value As Object)
        Dim propertyInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(propertyName)
        If propertyInfo IsNot Nothing Then
            propertyInfo.SetValue(Me, value)
        Else
            Throw New ArgumentException("Invalid property name")
        End If
    End Sub

End Class

Public Class Rootobject
    Public Property beatmapsets() As Beatmapset
    Public Property search As Search
    Public Property recommended_difficulty As Single
    Public Property _error As Object
    Public Property total As Integer
    Public Property cursor As Cursor
    Public Property cursor_string As String
End Class

Public Class Search
    Public Property sort As String
End Class

Public Class Cursor
    Public Property last_update As Long
    Public Property id As Integer
End Class

Public Class Beatmapset
    Public Property artist As String
    Public Property artist_unicode As String
    Public Property covers As Covers
    Public Property creator As String
    Public Property favourite_count As Integer
    Public Property hype As Hype
    Public Property id As Integer
    Public Property nsfw As Boolean
    Public Property offset As Integer
    Public Property play_count As Integer
    Public Property preview_url As String
    Public Property source As String
    Public Property spotlight As Boolean
    Public Property status As String
    Public Property title As String
    Public Property title_unicode As String
    Public Property track_id As Integer?
    Public Property user_id As Integer
    Public Property video As Boolean
    Public Property bpm As Single
    Public Property can_be_hyped As Boolean
    Public Property deleted_at As Object
    Public Property discussion_enabled As Boolean
    Public Property discussion_locked As Boolean
    Public Property is_scoreable As Boolean
    Public Property last_updated As Date
    Public Property legacy_thread_url As String
    Public Property nominations_summary As Nominations_Summary
    Public Property ranked As Integer
    Public Property ranked_date As Object
    Public Property storyboard As Boolean
    Public Property submitted_date As Date
    Public Property tags As String
    Public Property availability As Availability
    Public Property has_favourited As Boolean
    Public Property beatmaps() As Beatmap
    Public Property pack_tags() As String
End Class

Public Class Covers
    Public Property cover As String
    Public Property cover2x As String
    Public Property card As String
    Public Property card2x As String
    Public Property list As String
    Public Property list2x As String
    Public Property slimcover As String
    Public Property slimcover2x As String
End Class

Public Class Hype
    Public Property current As Integer
    Public Property required As Integer
End Class

Public Class Nominations_Summary
    Public Property current As Integer
    Public Property required As Integer
End Class

Public Class Availability
    Public Property download_disabled As Boolean
    Public Property more_information As Object
End Class

Public Class Beatmap
    Public Property beatmapset_id As Integer
    Public Property difficulty_rating As Single
    Public Property id As Integer
    Public Property mode As String
    Public Property status As String
    Public Property total_length As Integer
    Public Property user_id As Integer
    Public Property version As String
    Public Property accuracy As Single
    Public Property ar As Single
    Public Property bpm As Single
    Public Property convert As Boolean
    Public Property count_circles As Integer
    Public Property count_sliders As Integer
    Public Property count_spinners As Integer
    Public Property cs As Single
    Public Property deleted_at As Object
    Public Property drain As Single
    Public Property hit_length As Integer
    Public Property is_scoreable As Boolean
    Public Property last_updated As Date
    Public Property mode_int As Integer
    Public Property passcount As Integer
    Public Property playcount As Integer
    Public Property ranked As Integer
    Public Property url As String
    Public Property checksum As String
    Public Property max_combo As Integer
End Class