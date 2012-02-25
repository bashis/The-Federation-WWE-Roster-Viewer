Public Class PushControl
    Public description As String = "Push"
    Public cur_wr As Object
    Public Sub rebuild() 'Handles Slider.Scroll
        value = bar.Value
        stringvalue.Text = bar.Value.ToString
    End Sub
    Dim value As Integer
    'Public Sub isChanged() Handles Slider.MouseCaptureChanged
    '    Dim value2 As Integer = Slider.Value
    '    If Slider.Capture = False Then
    '        If value2 <> value Then
    '            Dim res As MsgBoxResult = MsgBox("You have changed this wrestler's push." & vbCrLf & "Do you actually want to save changes?", MsgBoxStyle.YesNoCancel)
    '            If res = MsgBoxResult.Yes Then
    '                value = value2

    '            Else
    '                Slider.Value = value

    '            End If
    '        End If
    '        stringvalue.Text = bar.Value.ToString
    '    End If
    'End Sub
    Public desc_object As Object

    Private Sub stringvalue_DoubleClick(sender As Object, e As System.EventArgs)
      
    End Sub
    Private Sub change_desc_object() Handles pic.MouseEnter, pic.MouseHover, bar.MouseEnter, bar.MouseHover, stringvalue.MouseEnter, stringvalue.MouseHover
        desc_object.text = description
    End Sub
    Private Sub null_desc_object() Handles pic.MouseLeave, bar.MouseLeave, stringvalue.MouseLeave
        desc_object.text = ""
    End Sub

    Private Sub Slider_Scroll(sender As Object, e As System.EventArgs)
        stringvalue.Text = bar.Value.ToString
    End Sub

    Private Sub stringvalue_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub null_desc_object(sender As System.Object, e As System.EventArgs) Handles pic.MouseLeave, stringvalue.MouseLeave, bar.MouseLeave

    End Sub

    Private Sub change_desc_object(sender As System.Object, e As System.EventArgs) Handles pic.MouseHover, pic.MouseEnter, stringvalue.MouseHover, stringvalue.MouseEnter, bar.MouseHover, bar.MouseEnter

    End Sub

    Private Sub MTech010VerticalProgessBar1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub stringvalue_Click_1(sender As System.Object, e As System.EventArgs) Handles stringvalue.Click
        Dim res As String = InputBox("Input the new value", "Push", bar.Value)
        If res <> "" Then
            Dim n As Integer
            Try
                n = CInt(res)
                If (n >= 0) And (n <= 100) Then
                    bar.Value = n
                    cur_wr.stats(5) = n
                    rebuild()
                Else
                    MsgBox("The value should be between 0 and 100")
                End If
            Catch ex As Exception
                MsgBox("""" & res & """" & "is not a number")
            End Try
        End If
    End Sub

    Private Sub bar_Click(sender As System.Object, e As System.EventArgs) Handles bar.Click
    
    End Sub

    Private Sub PushControl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress, stringvalue.KeyPress

    End Sub

    Private Sub PushControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
