Imports System.IO

Public Class About_Wrestler
    Public Wrestler_id As String

    Private Sub About_Wrestler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namelabel.Parent = Wrestler_Header
        wrestler_image.Parent = Wrestler_Header
        namelabel.Text = Form1.wrestlers(Wrestler_id).name
        Try
            wrestler_image.Image = Image.FromFile(Path.Combine(Form1.pth, "fullsize", Form1.wrestlers(Wrestler_id).id_string & ".png"))
        Catch ex As Exception
            Try
                wrestler_image.Image = Image.FromFile(Path.Combine(Form1.pth, "fullsize\9999.png"))
            Catch ex2 As Exception
            End Try

        End Try
        '/    namelabel.MaximumSize.Width = wrestler_image.Left - namelabel.Left - 10
        Me.Text = Wrestler_id
    End Sub

    Private Sub wrestler_image_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wrestler_image.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(sender.ToString)
    End Sub
End Class