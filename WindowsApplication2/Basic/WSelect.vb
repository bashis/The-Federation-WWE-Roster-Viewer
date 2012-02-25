Imports System.Windows.Forms
Public Class WSelect
    Dim w As WModel ' = MData.wrestlers(0)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub WSelect_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, OK_Button.KeyDown
        If e.KeyData = Keys.W Or e.KeyData = Keys.Up Then
            WrestlerSelectionDialog1.curindch(1)
        ElseIf e.KeyData = Keys.S Or e.KeyData = Keys.Down Then
            WrestlerSelectionDialog1.curindch(-1)
        End If
    End Sub

    Private Sub WSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim stclass As WStats = New WStats
        Dim defclass As DefaultConstants = New DefaultConstants
        WrestlerSelectionDialog1.statclass = stclass
        WrestlerSelectionDialog1.defclass = defclass
        WrestlerSelectionDialog1.autofill(MData.wrestlers)
    End Sub
End Class
