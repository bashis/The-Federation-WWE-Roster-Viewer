Option Explicit On
Public Class Statviewer
    '//some usefull stuff

    ' Dim value As Integer
    Public description As String = "description"

    Private Sub MTech010VerticalProgessBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MTech010VerticalProgessBar1.Click

    End Sub
    'Private Sub value_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles stringvalue.TextChanged
    '    Dim x As Integer = CInt(stringvalue.Text)
    '    If (x >= 0) And (x <= 100) Then
    '        MTech010VerticalProgessBar1.Value = x
    '    End If
    'End Sub
    Public Sub rebuild() Handles stringvalue.TextChanged
        Dim x As Integer = CInt(stringvalue.Text)
        If (x >= 0) And (x <= 100) Then
            MTech010VerticalProgessBar1.Value = x
        End If
    End Sub
    Private Sub Statviewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Me.tip.SetToolTip(pic, description)
        '   Me.ToolTip1.SetToolTip(MTech010VerticalProgessBar1, description)
        '  Me.ToolTip2.SetToolTip(stringvalue, description)
    End Sub

    Private Sub stringvalue_Click(sender As System.Object, e As System.EventArgs) Handles stringvalue.Click

    End Sub
    Public desc_object As Object
    Private Sub change_desc_object() Handles pic.MouseEnter, pic.MouseHover, MTech010VerticalProgessBar1.MouseEnter, MTech010VerticalProgessBar1.MouseHover, stringvalue.MouseEnter, stringvalue.MouseHover
        desc_object.text = description
    End Sub
    Private Sub null_desc_object() Handles pic.MouseLeave, MTech010VerticalProgessBar1.MouseLeave, stringvalue.MouseLeave
        desc_object.text = ""
    End Sub

    Private Sub null_desc_object(sender As System.Object, e As System.EventArgs) Handles stringvalue.MouseLeave, pic.MouseLeave, MTech010VerticalProgessBar1.MouseLeave

    End Sub
    Private Sub change_desc_object(sender As System.Object, e As System.EventArgs) Handles stringvalue.MouseHover, stringvalue.MouseEnter, pic.MouseHover, pic.MouseEnter, MTech010VerticalProgessBar1.MouseHover, MTech010VerticalProgessBar1.MouseEnter

    End Sub
    Private Sub rebuild(sender As System.Object, e As System.EventArgs) Handles stringvalue.TextChanged

    End Sub
End Class
