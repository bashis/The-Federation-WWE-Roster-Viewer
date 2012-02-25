Public Class SelectionDialog2
    Public warr() As WModel
    Public imageclass As Object
    Private Sub SelectionDialog2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel1.VerticalScroll.Visible = False
    End Sub
    Dim pb() As PictureBox
    Public Sub build()
        ReDim pb(warr.Length)
        innerPanel.AutoSize = True
        For i = 0 To warr.Length - 1
            pb(i) = New PictureBox
            With pb(i)
                .Parent = innerPanel
                If i = 0 Then
                    .Top = 10
                Else
                    .Top = pb(i - 1).Top + 110
                End If
                .Left = 10
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Image = imageclass.imcontainer(i).smallimage
                innerPanel.Controls.Add(pb(i))

            End With
        Next
       

        Panel1.AutoScroll = True
        Panel1.VerticalScroll.Visible = False
    End Sub

    Private Sub SelectionDialog2_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Dim delta As Integer = Panel1.VerticalScroll.Value - e.Delta

        If delta < Panel1.VerticalScroll.Minimum Then
            delta = Panel1.VerticalScroll.Minimum
        ElseIf delta > Panel1.VerticalScroll.Maximum Then
            delta = Panel1.VerticalScroll.Minimum
        End If

        Panel1.VerticalScroll.Value = delta
        Panel1.AutoScroll = True

    End Sub
End Class
