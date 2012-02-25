Public Class PView
    Public images(2) As System.Windows.Media.ImageSource
    Public nametext As String
    Public Sub set_images()

        Image1.Source = images(1)
        Image2.Source = images(2)
    End Sub
    Public Sub set_text()
        Label1.Content = nametext
    End Sub
    Private Sub PView_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        images(1) = Resources.Item(0)
    End Sub
End Class
