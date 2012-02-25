Public Class TrainingForm
    Dim averagelabel(DefaultConstants.n_of_stats - 1) As Label
    Public Selected_Wrestler As WModel
    Public Sub load_wrestler(ByVal w As WModel)
        Selected_Wrestler = w
        Label2.Text = "Training " & Selected_Wrestler.name
        FormLoad()
    End Sub
    Private Sub TrainingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_wrestler(MData.wrestlers(22))
    End Sub
    Private Sub FormLoad()

        Load_Average_Labels()

    End Sub
    Dim averagestats(DefaultConstants.n_of_stats - 1) As Double
    Private Sub findaverage()
        For i = 0 To MData.wrestlers.Length - 1
            If MData.wrestlers(i).id_string <> "9999" Then
                For j = 0 To DefaultConstants.n_of_stats - 1
                    averagestats(j) += MData.wrestlers(i).stats(j)
                Next
            End If
        Next

        For j = 0 To DefaultConstants.n_of_stats - 1
            If MData.wrestlers.Length > 1 Then
                averagestats(j) /= (MData.wrestlers.Length - 1)
            End If
        Next

    End Sub
    Private Sub Load_Average_Labels()
        'tmplabel.Visible = False
        findaverage()
        Dim newh, neww As Integer
        newh = tmplabel.Top - (fullsize_image.Top)
        neww = tmplabel.Left - (fullsize_image.Left)

        tmplabel.Parent = fullsize_image
        fullsize_image.Controls.Add(tmplabel)

        tmplabel.Left = neww
        tmplabel.Top = newh

        tmplabel.BringToFront()
        fullsize_image.SendToBack()


        '      MsgBox(tmplabel.Left & " " & tmplabel.Top)
        For i = 0 To DefaultConstants.n_of_stats - 1
            averagelabel(i) = New Label
            With averagelabel(i)
                .Left = tmplabel.Left
                If i = 0 Then
                    .Top = tmplabel.Top

                Else
                    .Top = averagelabel(i - 1).Bottom
                End If
                .Font = tmplabel.Font
                .Text = WStats.description(i) & ": " & averagestats(i).ToString.Substring(0, Math.Min(averagestats(i).ToString.Length, 4))
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .AutoSize = True
                .Parent = fullsize_image
                fullsize_image.Controls.Add(averagelabel(i))
                fullsize_image.SendToBack()
                .BringToFront()
            End With

        Next
    End Sub
    Dim TrOp(DefaultConstants.n_of_stats - 2) As TrainingOption
    Private Sub LoadTraining()
        For i = 0 To DefaultConstants.n_of_stats - 2
            TrOp(i) = New TrainingOption



        Next
    End Sub
End Class