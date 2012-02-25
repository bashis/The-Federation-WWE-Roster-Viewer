Public Class MatchMenu
    Public IsPPV As Boolean
    Public Structure Multiplyer
        Public Popularity As Double
        Public Danger As Double
        Public Cost As Double
    End Structure
    Public PPVMultiplyer As Double = 1.3
    Public number_of_wrestlers As Integer
    Public wr(number_of_wrestlers) As WModel
    Public TeamMatch As Boolean
    Public BelongsToTeam() As Integer
    '    Public NumberOfTeams As Integer
    Public items(DefaultConstants.n_of_items_in_a_match) As Items
    Public MType As MatchType = New MatchType
    Public ring As Ring = New Ring
    Public isForcedWin As Boolean
    Public forcedWinnerIndex As Integer
    Public ThisMatch As Match = New Match
    Private Sub Fill_Stats()
        IsPPV = True
        ring.lightings = 0 '3 'ring.lightings_array.Length - 1
        ring.seats = 0 '2 'ring.seats_array.Length - 1
        ring.titantron = False 'True
        ring.type = 0 '2 ' ring.type_array.Length - 1
        ring.recount()
        '===========================
        MType.id = 1
        MType.recount()
        ReDim Preserve items(5)
        '===========================
        For i = 0 To 5
            items(i) = New Items
        Next
        items(0).Id = 1
        items(1).Id = 1
        items(2).Id = 0
        items(3).Id = 4
        items(4).Id = 4
        items(5).Id = 4
        For i = 0 To 5
            items(i).recount()
        Next
        '===========================
        number_of_wrestlers = 2
        ReDim Preserve wr(number_of_wrestlers)
        wr(0) = MData.wrestlers(1)
        wr(1) = MData.wrestlers(2)
        ' wr(2) = MData.wrestlers(6)
        'wr(3) = MData.wrestlers(10)


        Me.Text = wr(0).name
        For i = 1 To number_of_wrestlers - 1
            '     Me.Text = Me.Text & " vs. " & wr(i).name
        Next

        TeamMatch = False
        If TeamMatch Then
            ReDim Preserve BelongsToTeam(number_of_wrestlers)
            BelongsToTeam(0) = 1
            BelongsToTeam(1) = 1
            BelongsToTeam(2) = 2
            BelongsToTeam(3) = 2
        End If
    End Sub

    Public Sub fillStats()

        number_of_wrestlers = ThisMatch.number_of_wrestlers
        wr = ThisMatch.wrestlers

        IsPPV = ThisMatch.isPPV
        MType = ThisMatch.MatchType
        TeamMatch = ThisMatch.isTeamMatch
        isForcedWin = ThisMatch.isForcedWin
        items = ThisMatch.items
        BelongsToTeam = ThisMatch.BelongsToTeam
        forcedWinnerIndex = ThisMatch.forcedWinnerIndex

    End Sub
    Dim Danger, Pop, Cost, MatchQuality As Integer
    Private Sub Fill_labels()
        NameLabel.Text = ""
        ItemsTypeLabel.Text = ""
       
        If number_of_wrestlers > 0 Then
            If number_of_wrestlers = 2 Then
                NameLabel.Text = NameLabel.Text & wr(0).name & " vs. " & wr(1).name
                NameLabel.Text = NameLabel.Text & vbCrLf
            Else
                NameLabel.Text = number_of_wrestlers & " Men"
            End If
            If MType.id <> 0 Then
                NameLabel.Text = " " & NameLabel.Text & MType.value
            End If
        End If
        NameLabel.Visible = False
        PView1.nametext = NameLabel.Text
        PView1.set_text()
        ' '  result.Top = NameLabel.Top
        ' result.Left = NameLabel.Right + 5

        ' MatchTypeLabel.Top = NameLabel.Bottom + 5
        ' tLabel2.Top = MatchTypeLabel.Top

        '  MatchTypeLabel.Text = MType.value
        '
        '       ItemsTypeLabel.Top = MatchTypeLabel.Bottom + 5
        '      tLabel3.Top = ItemsTypeLabel.Top

        If (items.Length > 0) And (MType.isExtreme) Then
            For i = 0 To items.Length - 1
                ItemsTypeLabel.Text = ItemsTypeLabel.Text & items(i).Name & vbCrLf
            Next
        Else
            ItemsTypeLabel.Text = "None"
        End If
        ' Stars_image.Text = stringstars(stars)
        MatchStars1.value = stars
        MatchStars1.rebuild()
        winner_label.Text = "Winner: " & ThisMatch.WinnerName ' return_winner_string()
        'R_info.Top = ItemsTypeLabel.Bottom + 5
        'tLabel4.Top = R_info.Top
        R_info.Text = ring.return_information
        tLabel3.Top = R_info.Bottom + 5
        ItemsTypeLabel.Top = tLabel3.Bottom + 5

    End Sub

    Dim isInterfere As Boolean
    Dim interfere As Integer
    Dim isWinner As Boolean = True
    Private Function winner() As Integer
        'Dim numbers(number_of_wrestlers) As Integer
        If MType.isBattleRoyal Then
            Return (countBattleRoyal())
        End If
        isWinner = True
        Dim cnt As Integer = 0
        Dim prepwinner As Integer
        Dim chance As Integer = 0
        'Check if drunkie
        For i = 0 To number_of_wrestlers - 1
            For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                If wr(i).perks(j) = 7 Then 'Drunkie
                    chance = Form1.random(0, 9)
                End If
            Next
        Next
        If chance = 1 Then
            isWinner = False 'No match
            Pop -= 100
            Danger = 0
            Cost = 0
        End If
        'End Check
        If isWinner Then
            If isForcedWin Then
                Return forcedWinnerIndex
            End If
            If Form1.random(0, 10) = 1 Then
                isInterfere = True
10:             cnt += 1
                If cnt >= MData.wrestlers.Length - 1 Then GoTo 20 'Haters gonna hate
                interfere = Form1.random(0, MData.wrestlers.Length - 1)
                If MData.wrestlers(interfere).id_string = "9999" Then GoTo 10
                For i = 0 To number_of_wrestlers - 1
                    If MData.wrestlers(interfere).id_string = wr(i).id_string Then
                        GoTo 10
                    End If
                Next
                prepwinner = Form1.random(0, number_of_wrestlers - 1)
                If MData.wrestlers(interfere).isFace = wr(prepwinner).isFace Then
                    Return (prepwinner)
                Else
                    GoTo 10
                End If
            Else
20:
                Dim increaser As Double = 1

                isInterfere = False
                Dim tmp, rkoef As Integer
                Dim max, imax As Integer
                rkoef = Form1.random(3, 9)
                For i = 0 To number_of_wrestlers - 1
                    increaser = 1
                    For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                        If wr(i).perks(j) = 4 Then
                            increaser *= 1.3
                        ElseIf wr(i).perks(j) = 5 Then
                            increaser *= 0.5
                        End If
                    Next

                    Dim lowerbound As Integer = wr(i).stats(5) * 0.1 * rkoef
                    Dim upperbound As Integer = Int(wr(i).stats(5) * increaser)
                    '  If upperbound < lowerbound Then upperbound = lowerbound
                    tmp = Form1.random(lowerbound, upperbound)
                    'MsgBox(lowerbound & " " & upperbound, , wr(i).name)
                    If tmp > max Then
                        imax = i
                        max = tmp
                    End If
                Next
                '   MsgBox(wr(imax).name)
                Return imax
            End If
        Else
            Return -1  'No winner
        End If
    End Function
    Private Sub count_match_overall()

        Danger = 0
        Pop = 0
        Cost = 0
        MatchQuality = 0
        If (items.Length > 0) And (MType.isExtreme) Then
            For i = 0 To items.Length - 1
                Danger += items(i).Danger
                Pop += items(i).PBonus
                Cost += items(i).Cost
            Next
        End If
        Pop += ring.return_overall()
        'tellmeaboutstuff() '!!
        Dim number_of_daredevils As Integer
        Dim wr_add As Double 'Addition to Matchquality from a single wrestler
        If number_of_wrestlers > 0 Then
            For i = 0 To number_of_wrestlers - 1
                Pop += Form1.random(wr(i).stats(0) * 2 / 3, wr(i).stats(0) * 3 / 2) 'Wrestling
                Pop += Form1.random(wr(i).stats(4) * 2 / 3, wr(i).stats(0) * 3 / 2) 'Fan-Base
                '                MatchQuality += Form1.random(wr(i).stats(0) / 2, wr(i).stats(0) * 3 / 2) ' Wrestling Again
                Danger += Form1.random(wr(i).stats(3) / 2, wr(i).stats(3)) 'Insanity


                'Check if the wresrler is perspective or worthless
                For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                    If wr(i).perks(j) = 4 Then
                        wr_add = Form1.random(CInt(wr(i).stats(0)), CInt(wr(i).stats(0) * 1.5)) * 1.5
                    ElseIf wr(i).perks(j) = 5 Then
                        wr_add = Form1.random(CInt(wr(i).stats(0) / 4), CInt(wr(i).stats(0) / 2)) / 2
                    ElseIf wr(i).perks(j) = 3 Then
                        number_of_daredevils += 1
                    Else
                        wr_add = Form1.random(wr(i).stats(0) * 2 / 3, wr(i).stats(0) * 4 / 3)
                    End If
                Next


                MatchQuality += wr_add
            Next

            If MType.isExtreme = True Then
                MatchQuality += Danger / 2 'Insanity
            End If

        Else
            MsgBox("No Wrestlers Selected")
            Danger = 0
            Pop = 0
            Cost = 0
        End If

        '===========================Koef Manipulations
        'tellmeaboutstuff() '11
        If IsPPV Then
            Pop *= PPVMultiplyer
        End If
        '==============================Define if evetyone is heel or not
        Dim isFace As Boolean = False
        For i = 0 To number_of_wrestlers - 1
            If wr(i).isFace Then
                isFace = True
            End If
        Next
        If Not isFace Then
            Pop /= 2
            MatchQuality /= 2
        End If
        '==============================End Defininiton
        'tellmeaboutstuff() '!!
        Danger /= (number_of_wrestlers - number_of_daredevils + 1)
        MatchQuality /= (number_of_wrestlers) ' - 1)
        Pop /= number_of_wrestlers
        '     If (number_of_wrestlers > 10) And (MatchQuality) Then
        ' MatchQuality+=
        '    End If
        Dim add_danger As Integer = 0
        If MType.isExtreme Then
            add_danger += 5 * number_of_daredevils
        End If
        If add_danger > 50 Then
            add_danger = 50
        End If
        Danger += add_danger
        '===========================/Koef Manipulations
    End Sub
    Dim const_winner As Integer
    Dim stars As Double
    Private Sub find_summ()
        Dim cycle As Integer = 1
        Dim five_star As Integer = 0
        result_stats.Text = "Popularity: " & ThisMatch.Popularity & vbCrLf &
                    "Match Quality: " & ThisMatch.Quality & vbCrLf &
                    "Danger: " & ThisMatch.Danger & vbCrLf &
                    "Cost: $" & ThisMatch.Cost & vbCrLf

        result_stats.Text = underline(result_stats.Text)
        Dim cnt(number_of_wrestlers + 1) As Integer
        Dim int(number_of_wrestlers) As Integer
        For i = 0 To number_of_wrestlers - 1
            cnt(i) = 0
        Next

        Dim winner_string As String = ""

        For i = 1 To cycle
            count_match_overall()
            winner_string = ""
            const_winner = winner()
            If isWinner Then
                If TeamMatch Then
                    For j = 0 To number_of_wrestlers - 1
                        If BelongsToTeam(j) = BelongsToTeam(const_winner) Then
                            winner_string = winner_string & wr(j).name & " "
                        End If
                    Next
                    If isInterfere Then
                        int(const_winner) += 1
                    End If
                    cnt(const_winner) += 1
                Else
                    '   result.Text = result.Text & "Winner: " & wr(t).name & vbCrLf
                    If isInterfere Then
                        int(const_winner) += 1
                        '     result.Text = result.Text & "Interfere: " & MData.wrestlers(interfere).name & vbCrLf
                    End If
                    cnt(const_winner) += 1
                    winner_string = wr(const_winner).name
                End If
                'ThisMatch.WinnerName = winner_string
                If ThisMatch.Quality >= 450 Then
                    five_star += 1
                    '       MsgBox(i)
                End If
                stars = ThisMatch.Quality * 1.4 / 90 'Not clear koef, TODO: Change it!
                If ThisMatch.isPPV And stars < 0.1 Then
                    stars = -5
                End If
                If stars >= 4.8 And number_of_wrestlers > 3 Then
                    stars = 4.8
                End If

            Else : cnt(number_of_wrestlers) += 1 'No Match
            End If

        Next
        result_stats.Text = result_stats.Text & winner_string & vbCrLf
        result_stats.Text = underline(result_stats.Text)
        result_stats.Text = result_stats.Text & "All in all:" & vbCrLf
        For i = 0 To number_of_wrestlers - 1

            result_stats.Text = result_stats.Text & wr(i).name '& " " & cnt(i) & vbCrLf

        Next

        result_stats.Text = result_stats.Text & "Interferes:" & vbCrLf
        For i = 0 To number_of_wrestlers - 1
            result_stats.Text = result_stats.Text & wr(i).name & " " & int(i) & vbCrLf
        Next
        result_stats.Text = result_stats.Text & "No match: " & cnt(number_of_wrestlers) & vbCrLf
        result_stats.Text = underline(result_stats.Text)
        '   result.Text = result.Text & "5-Star matches: " & five_star & vbCrLf
        Dim lindex As Integer = stars.ToString.Length
        result_stats.Text = result_stats.Text & "Stars: " & stars.ToString.Substring(0, Math.Min(4, lindex)) & vbCrLf

    End Sub
    Private Function underline(ByVal result As String) As String
        Return (result & "______________" & vbCrLf)
    End Function
    Public ShallGenerate As Boolean
    Dim cnt As Integer = 1
    Public Sub Simulate()
        fillStats()
        If ShallGenerate Then
            count_match_overall()
            ThisMatch.Quality = MatchQuality
            ThisMatch.Popularity = Pop
            ThisMatch.Cost = Cost
            ThisMatch.Danger = Danger
            ThisMatch.WinnerName = return_winner_string()

            '            ShowViewer.current_show.Matches(ShowViewer.index) = ThisMatch
        End If

       
        find_summ()
        Fill_labels()
        stat_edition()
    End Sub
    Private Sub MatchMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Simulate()
        '   MsgBox(ring.return_information)
        ' R_info.Text = ring.return_information



    End Sub
    Public Function toW_Output_Format(ByVal wr As WModel) As String
        Return ("|" & wr.name & " " & wr.id_string)
    End Function
    Private Sub stat_edition()
        Dim ind As Integer
        If isWinner Then
            'TODO: Add 5-star superperk
            If TeamMatch Then
                For i = 0 To number_of_wrestlers - 1
                    ind = wr(i).id
                    If BelongsToTeam(i) = BelongsToTeam(const_winner) Then

                        'This guy is a winner, do whatever you wish with MData.wrestlers(ind)
                    Else
                        'This guy is a looser, do whatever you wish with MData.wrestlers(ind)
                    End If
                Next
            Else
                Dim waverage, laverage, wcnt, lcnt As Double
                For i = 0 To number_of_wrestlers - 1
                    ind = wr(i).id
                    If i = const_winner Then
                        ' winner_stat_edition(MData.wrestlers(ind)) 'This guy is a winner, do whatever you wish with MData.wrestlers(ind)
                        waverage += MData.wrestlers(ind).stats(5)
                        wcnt += 1
                    Else
                        laverage += MData.wrestlers(ind).stats(5)
                        lcnt += 1
                    End If
                Next
                waverage /= wcnt
                laverage /= lcnt

                For i = 0 To number_of_wrestlers - 1
                    ind = wr(i).id
                    If i = const_winner Then
                        winner_stat_edition(MData.wrestlers(ind), waverage, laverage) 'This guy is a winner, do whatever you wish with MData.wrestlers(ind)
                    Else
                        looser_stat_edition(MData.wrestlers(ind), waverage, laverage) 'This guy is a looser, do whatever you wish with MData.wrestlers(ind)
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub winner_stat_edition(ByVal wrestler As WModel, ByVal winnerpoints As Double, ByVal looserpoints As Double)
        If wrestler.stats(5) > 0 Then
            wrestler.stats(5) += CInt(looserpoints / wrestler.stats(5)) 'push
        Else
            wrestler.stats(5) += CInt(looserpoints) 'push
        End If
        'TODO: Count realistic stats!!!
        If wrestler.stats(5) > 100 Then
            wrestler.stats(5) = 100
        End If
    End Sub
    Private Sub looser_stat_edition(ByVal wrestler As WModel, ByVal winnerpoints As Double, ByVal looserpoints As Double)
        If winnerpoints > 0 Then
            wrestler.stats(5) -= CInt(wrestler.stats(5) / winnerpoints) 'push
        Else
            wrestler.stats(5) /= 2
        End If

        If wrestler.stats(5) < 0 Then
            wrestler.stats(5) = 0
        End If
    End Sub
    Private Function find_wrestlers_id_from_idstring(ByVal idstring As String) As Integer

        For i = 0 To MData.wrestlers.Length
            If MData.wrestlers(i).id_string = idstring Then
                Return MData.wrestlers(i).id
            End If
        Next

        Return -1
    End Function
    Private Function return_winner_string()
        Dim result(number_of_wrestlers) As String
        Dim output As String
        Dim counter As Integer = 0
        If isWinner Then
            If TeamMatch Then
                For i = 0 To number_of_wrestlers - 1
                    If BelongsToTeam(i) = BelongsToTeam(const_winner) Then
                        result(counter) = wr(i).name 'This guy is a winner, do whatever you wish with MData.wrestlers(ind)
                        counter += 1
                    End If
                Next
                counter -= 1
            Else
                For i = 0 To number_of_wrestlers - 1
                    If i = const_winner Then
                        result(0) = wr(i).name
                    End If
                Next
            End If

            output = result(0)
            If counter > 0 Then
                For i = 1 To counter
                    output = output & ", " & result(i)
                Next
            End If
            Return output
        Else
            Return "No Contest"
        End If
    End Function
    Private Function stringstars(ByVal number As Double) As String
        Dim res As String = ""
        For i = 0 To CInt(number - 1)
            res = res & "*"
        Next
        Return res
    End Function
    Private Function countBattleRoyal()
        Dim w_id As Integer = 0
        If isForcedWin Then
            Return forcedWinnerIndex
        End If
        Dim local_fight() As WModel
        Dim eliminated(number_of_wrestlers - 1) As Boolean
        Dim remaining As Integer = number_of_wrestlers
        '        For i = 0 To number_of_wrestlers - 1
        For i = 0 To number_of_wrestlers - 1
            eliminated(i) = False
        Next
        'Next
        While remaining > 1
            ReDim local_fight(1)
            Dim temp1, temp2 As Integer
10:
            temp1 = Form1.random(0, number_of_wrestlers - 1)
            temp2 = Form1.random(0, number_of_wrestlers - 1)
            If temp1 = temp2 Then
                GoTo 10
            End If
            '   MsgBox("1")
20:
            '   MsgBox("2")
            If eliminated(temp1) = True Then
                temp1 += 1
                If temp1 > number_of_wrestlers - 1 Then
                    temp1 = 0
                End If
                GoTo 20
            End If
            If eliminated(temp2) = True Then
                temp2 += 1
                If temp2 > number_of_wrestlers - 1 Then
                    temp2 = 0
                End If
                GoTo 20
            End If


            local_fight(0) = wr(temp1)
            local_fight(1) = wr(temp2)
            Dim locallooser As Integer = Local_looser(local_fight)
            For i = 0 To number_of_wrestlers - 1
                If wr(i).name = local_fight(locallooser).name Then
                    eliminated(i) = True
                    MsgBox(wr(i).name)
                End If
            Next

            remaining -= 1
        End While
        Dim n As Integer
        For i = 0 To number_of_wrestlers - 1
            If eliminated(i) = False Then
                w_id = i
            Else
                n += 1
            End If
        Next
        '  MsgBox(n)
        Return w_id
    End Function

    Private Function Local_looser(ByVal people As Object) As Integer
        Dim increaser As Double = 1

        isInterfere = False
        Dim tmp, rkoef As Integer
        Dim max, imax As Integer
        max = 10000

        If people.length = 2 Then
            rkoef = Form1.random(3, 9)
            For i = 0 To people.length - 1
                increaser = 1
                For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                    If wr(i).perks(j) = 4 Then
                        increaser *= 1.3
                    ElseIf wr(i).perks(j) = 5 Then
                        increaser *= 0.5
                    End If
                Next

                Dim lowerbound As Integer = wr(i).stats(5) * 0.1 * rkoef
                Dim upperbound As Integer = Int(wr(i).stats(5) * increaser)
                '  If upperbound < lowerbound Then upperbound = lowerbound
                tmp = Form1.random(lowerbound, upperbound)
                'MsgBox(lowerbound & " " & upperbound, , wr(i).name)
                If tmp < max Then
                    imax = i
                    max = tmp
                End If
            Next
            '   MsgBox(wr(imax).name)
            Return imax
        ElseIf people.length = 3 Then
            Dim team(2, 1) As Integer
            For i = 0 To 2
                team(i, 0) = Form1.random(0, 2)
            Next
            If team(0, 0) = team(1, 0) And (team(1, 0) = team(2, 0)) Then
                Return -1
            Else
                Dim overall(2) As Integer
                For i = 0 To 2
                    '=========================================
                    increaser = 1
                    For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                        If people(i).perks(j) = 4 Then
                            increaser *= 1.3
                        ElseIf people(i).perks(j) = 5 Then
                            increaser *= 0.5
                        End If
                    Next

                    Dim lowerbound As Integer = wr(i).stats(5) * 0.1 * rkoef
                    Dim upperbound As Integer = Int(wr(i).stats(5) * increaser)
                    '  If upperbound < lowerbound Then upperbound = lowerbound
                    overall(i) = Form1.random(lowerbound, upperbound)
                    team(i, 1) = overall(i)
                Next
                '===============================================
                For i = 0 To 2

                Next

            End If


        End If
        Return 0
    End Function
End Class