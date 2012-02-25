Public Class WModel
    Public id As Integer
    Public id_string As String
    Public name As String
    Public description As String
    Public isFace As Boolean
    Public Finisher As String

    Public Promotion As Integer

    Public FeudAllies() As WModel
    Public FeudEnemies() As WModel

    Public Tired As Double
    Public Relationship As Double

    Public height As String
    Public weight As String

    Public Titles(DefaultConstants.n_of_titles) As Integer

    '=================
    Dim number_of_perks_on As Integer = DefaultConstants.n_of_perks_at_once
    Public perks(number_of_perks_on) As Integer
    Public s_perk As Integer 'superperk's id
    '=================
    Dim number_of_stats As Integer = DefaultConstants.n_of_stats
    Public stats(number_of_stats) As Integer
    '=================
    Public style As Integer
    '=================
    Public picture As Image
    Public Shared Function bring_id_to_string_form(ByVal i As Object) As String
        Dim t As String = i.ToString
        If t.Length < 4 Then
            While t.Length < 4
                t = "0" & t
            End While
            Return t
        ElseIf t.Length > 4 Then
            Return (t.Substring(0, 4))
        Else
            Return t
        End If
    End Function

    
End Class
