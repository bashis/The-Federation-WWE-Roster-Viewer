Public Class WPFButton

    Private Sub UserControl_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        onButton.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub onButton_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles onButton.Click
        offButton.Visibility = Windows.Visibility.Visible
        onButton.Visibility = Windows.Visibility.Hidden
    End Sub

    Private Sub offButton_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles offButton.Click
        onButton.Visibility = Windows.Visibility.Visible
        offButton.Visibility = Windows.Visibility.Hidden
    End Sub
    Public Sub CheckedChanged()

    End Sub
End Class
