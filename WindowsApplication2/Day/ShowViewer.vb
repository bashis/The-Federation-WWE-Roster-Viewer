Public Class ShowViewer
    Dim number_of_events As Integer
    Dim someshow As Show = New Show 'TODO: Delete this, replace with actual show
    Public current_show As Show = New Show
    Private Sub fillDesign()

        newEventButton.Parent = Header
        newEventButton.Left = 0
        newEventButton.Width = Header.Width - 2
        newEventButton.Visible = False
        RandomButton.Parent = Header
        RandomButton.Left = 0
        RandomButton.Width = newEventButton.Width
        RandomButton.Visible = False

    End Sub
    Private Sub ShowViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillDesign()
        ShowFill()

        current_show = someshow
        fillButtons()
    End Sub

    Public Sub ShowFill()
        someshow.RandomModel()
        someshow.BGPic = Basic.BackImage1
        someshow.rebuild()
    End Sub
    Dim EventButtons() As Button
    Public Sub fillButtons()
        ReDim EventButtons(current_show.model.Length - 1)
        For i = 0 To current_show.model.Length - 1
            EventButtons(i) = New Button
            With EventButtons(i)
                .Parent = Panel1
                If current_show.Events(i) = 1 Then
                    .Text = "Match"
                ElseIf current_show.Events(i) = 2 Then
                    .Text = "Promo"
                End If
                'Dim maxSize As Size
                .AutoSizeMode = Windows.Forms.AutoSizeMode.GrowOnly
                .AutoSize = True
                '.MaximumSize = maxSize
                .Top = templateButton.Top
                .Left = templateButton.Left + templateButton.Width * i + 5 * i
                .Height = templateButton.Height
                .Width = templateButton.Width
                AddHandler EventButtons(i).Click, AddressOf EventClicked
                Panel1.Controls.Add(EventButtons(i))
            End With
        Next

        Header.Image = current_show.BGPic
    End Sub
    Public index As Integer
    Public Sub EventClicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        index = Array.IndexOf(EventButtons, sender)
        If current_show.Events(index) = 1 Then
            NewEventType = 1
            If current_show.Matches(index).wrestlers Is Nothing Then
                newEventButton.Text = "New Match"
                RandomButton.Text = "Random Match"
                newEventButton.Visible = True
                RandomButton.Visible = True
                'MatchMenu.ThisMatch = RandomMatch()
                'MatchMenu.Show()
            Else
                newEventButton.Visible = False
                RandomButton.Visible = False
                MatchMenu.ThisMatch = current_show.Matches(index)
                MatchMenu.ShallGenerate = False
                MatchMenu.Show()
            End If
           ElseIf current_show.Events(index) = 2 Then
            NewEventType = 2
            PromoForm.Show()
        End If
    End Sub
    Public Function RandomMatch() As Match
        Dim match As Match = New Match
        With match
            .MatchType = New MatchType
            .MatchType.id = Form1.random(-10, MatchType.descriptions.Length - 1)
            If .MatchType.id < 0 Then
                .MatchType.id = 0
            End If
            .MatchType.recount()

            .number_of_wrestlers = Form1.random(-5, 6)

            If .number_of_wrestlers < 2 Then
                .number_of_wrestlers = 2
            End If
            ReDim Preserve .wrestlers(.number_of_wrestlers - 1)
            .rebuild()
            For i = 0 To .number_of_wrestlers - 1
                .wrestlers(i) = New WModel
10:             Dim wrnum As Integer = Form1.random(0, MData.wrestlers.Length - 1)
                If MData.wrestlers(wrnum).id_string <> "9999" Then
                    .wrestlers(i) = MData.wrestlers(wrnum)

                Else : GoTo 10
                End If
            Next

            .isTeamMatch = False

            .isForcedWin = False
            For i = 0 To DefaultConstants.n_of_items_in_a_match
                If .items(i) Is Nothing Then
                    .items(i) = New Items
                End If
                .items(i).Id = 0
                .items(i).recount()
            Next

            Dim str As String = .wrestlers(0).name
            '   For i = 1 To .number_of_wrestlers - 1
            'str = str & " vs. " & .wrestlers(i).name
            'Next
            'MsgBox(str)
            'MatchMenu.ThisMatch = match

            'MatchMenu.Show()


        End With
        Return match
    End Function

    Dim NewEventType As Integer
    Private Sub newEventButton_Click(sender As System.Object, e As System.EventArgs) Handles newEventButton.Click
        If NewEventType = 1 Then
            MatchSetup.Show()
        ElseIf NewEventType = 2 Then
            PromoForm.Show()
        End If
    End Sub

    Private Sub RandomButton_Click(sender As System.Object, e As System.EventArgs) Handles RandomButton.Click
        If NewEventType = 1 Then
            current_show.Matches(index) = RandomMatch()
            MatchMenu.ThisMatch = current_show.Matches(index)
            MatchMenu.ShallGenerate = True
            MatchMenu.Show()
            EventButtons(index).Text = current_show.Matches(index).Name
            fixButtonsLocation()

            current_show.Matches(index) = MatchMenu.ThisMatch

            newEventButton.Visible = False
            RandomButton.Visible = False
        ElseIf NewEventType = 2 Then
            PromoForm.Show()
        End If
    End Sub

    Private Sub templateButton_Click(sender As System.Object, e As System.EventArgs) Handles templateButton.Click

    End Sub
    Private Sub fixButtonsLocation()
        EventButtons(0).Left = templateButton.Left
        For i = 1 To current_show.model.Length - 1
            With EventButtons(i)
                .Left = EventButtons(i - 1).Right + 5
            End With
        Next
    End Sub
End Class