Public Class Ring

    ' Public type As TypeTemplate = 
    Public type As Integer
    Dim type_array() As String = {"Poor", "Good", "Excellent"}
    Public titantron As Boolean
    Public seats As Integer
    Dim seats_array() As String = {"Few", "Normal", "A Lot"}
    Public lightings As Integer
    Dim lightings_array() As String = {"No", "Few", "Normal", "A lot"}
    Public s_type As String = type_array(type)
    Public s_seats As String = seats_array(seats)
    Public s_lightings As String = lightings_array(lightings)
    Public Sub recount()
        s_type = type_array(type)
        s_seats = seats_array(seats)
        s_lightings = lightings_array(lightings)
    End Sub
    Public Function return_overall()
        Dim overall As Integer = 0
        Dim k_type, k_titantron, k_seats, k_lightings As Integer
        k_type = 50
        k_titantron = 25
        k_seats = 15
        k_lightings = 40

        overall = k_type * Type + k_titantron * bool_to_int(titantron) + k_seats * seats + k_lightings * lightings

        Return overall
    End Function
    Private Function bool_to_int(ByVal bool As Boolean) As Integer
        If bool Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function return_information() As String
        Dim result As String
        result = "Type: " & s_type & vbCrLf &
            "Titantron: " & titantron.ToString & vbCrLf &
            "Seats: " & s_seats & vbCrLf &
            "Lightings: " & s_lightings & vbCrLf &
            "____________" & vbCrLf &
            "Overall: " & return_overall.ToString
        Return result
    End Function

End Class
