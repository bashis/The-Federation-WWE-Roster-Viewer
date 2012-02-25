Imports System.IO
Public Class Ability_control
    Public abilities(DefaultConstants.n_of_perks_at_once) As Integer
    Dim k(DefaultConstants.n_of_perks_at_once) As PictureBox
    Dim defw As Integer = 36
    Dim between As Integer = 5
    Dim otstup As Integer = (Me.Width - DefaultConstants.n_of_perks_at_once * defw - between * DefaultConstants.n_of_perks_at_once) / 2

    Private Sub Ability_control_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i = 0 To DefaultConstants.n_of_perks_at_once
            k(i) = New PictureBox
            With k(i)
                .Width = defw
                .Height = defw
                .Image = Image.FromFile(DefaultConstants.perks_path & abilities(i).ToString & ".jpg")
                .Left = otstup + between * (i) + defw * i
                .Top = (Me.Height - k(i).Height) / 2
                .SizeMode = PictureBoxSizeMode.Zoom
            End With
            Me.Controls.Add(k(i))
        Next

        Me.Anchor = AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
    End Sub
    Public Sub rebuild()
        otstup = (Me.Width - DefaultConstants.n_of_perks_at_once * defw - between * DefaultConstants.n_of_perks_at_once) / 2
        For i = 0 To DefaultConstants.n_of_perks_at_once
            '           k(i) = New PictureBox
            '            k(i).Image = Image.FromFile(DefaultConstants.perks_path & abilities(i).ToString & ".jpg")
            If k(i) Is Nothing Then
                k(i) = New PictureBox
            End If
            k(i).Left = otstup + between * (i) + defw * i
            k(i).Top = (Me.Height - k(i).Height) / 2
            k(i).SizeMode = PictureBoxSizeMode.Zoom

            Me.Controls.Add(k(i))
        Next

    End Sub
End Class
