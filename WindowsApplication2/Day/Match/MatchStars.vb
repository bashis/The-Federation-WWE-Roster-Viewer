Public Class MatchStars
    Public value As Double
    Dim one As Integer = 53
    Private Sub MatchStars_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub rebuild()
        front.Left = back.Left
        front.Top = back.Top
        If value > 0 Then
            front.Left += one * value
        End If
        vlabel.Text = value.ToString.Substring(0, Math.Min(4, value.ToString.Length)) & " stars"
    End Sub
End Class
