Public Class Show
    Public model As String
    Public modeltemplates() As String = {"mmpmpm", "pmmpmp", "mpmpmp", "mmmmpm"}
    Public Events() As Integer
    Public Matches() As Match
    Public Promos() As Promo
    Public BGPic As Image
    'Events:
    '1 - Match
    '2 - Promo

    Public Sub GetEventOrder()
        ReDim Matches(model.Length - 1)
        ReDim Promos(model.Length - 1)

        For i = 0 To model.Length - 1
            If Matches(i) Is Nothing Then
                Matches(i) = New Match
            End If

            If Promos(i) Is Nothing Then
                Promos(i) = New Promo
            End If
        Next

        If model.Length > 0 Then
            ReDim Events(model.Length - 1)
            For i = 0 To model.Length - 1
                If model(i) = "m" Then
                    Events(i) = 1
                ElseIf model(i) = "p" Then
                    Events(i) = 2
                End If
            Next
        End If
    End Sub

    Public Function ReturnEvent(ByVal index As Integer)
        If Events(index) = 1 Then
            Return Matches(index)
        ElseIf Events(index) = 2 Then
            Return Promos(index)
        Else
            Return Nothing
        End If
    End Function
    Public Sub rebuild()
        GetEventOrder()
    End Sub
    Public Sub RandomModel()
        model = modeltemplates(Form1.random(0, modeltemplates.Length - 1))
        rebuild()
    End Sub
End Class
