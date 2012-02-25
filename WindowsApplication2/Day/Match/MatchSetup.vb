Public Class MatchSetup
    Dim number_of_wrestlers As Integer
    Dim number_of_teams As Integer
    Public ThisMatch As Match = New Match
    Private Sub MatchSetup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        get_number_of_wrestlers(sender)
        get_number_of_teams(sender)
        load_matchtype()
        load_items()
        ItemsDGV.Left = 15
        ItemsDGV.Top = 178
        load_wrestlers()
        WrestlersDGV.Left = 15
        WrestlersDGV.Top = 350
        MData.ok()
    End Sub
    Private Sub get_number_of_wrestlers(ByVal sender As System.Object)
        Dim n As Integer
10:
        Dim res As String = InputBox("Input the number of wrestlers:", "Number of wrestlers", "2")
        If res <> "" Then
            ' Dim n As Integer
            Try
                n = CInt(res)
                If (n >= 2) And (n <= MData.wrestlers.Length) Then
                    number_of_wrestlers = n
                Else
                    MsgBox("The value should be between 2 and " & MData.wrestlers.Length)
                    GoTo 10
                End If
            Catch ex As Exception
                MsgBox("""" & res & """" & "is not a number")
                GoTo 10
            End Try
        Else
            sender.close()
        End If
    End Sub
    Private Sub get_number_of_teams(ByVal sender As System.Object)
        Dim n As Integer
10:     If number_of_wrestlers > 2 Then
            Dim res As String = InputBox("Input the number of teams:" & vbCrLf & "If this is not a team-match, write 0", "Number of teams", "0")
            If res <> "" Then
                Try
                    n = CInt(res)
                    If (n = 0) Or ((n >= 2) And (n < number_of_wrestlers)) Then
                        number_of_teams = n
                    Else
                        MsgBox("The value should be either 0 or something between 2 and " & number_of_wrestlers)
                        GoTo 10
                    End If
                Catch ex As Exception
                    MsgBox("""" & res & """" & "is not a number")
                    GoTo 10
                End Try
            Else
                sender.close()
            End If
        Else
            number_of_teams = 0
        End If
    End Sub

    Dim mtypearray(MatchType.Length) As MatchType
    Private Sub load_matchtype()
        For i = 0 To MatchType.Length - 1
            mtypearray(i) = New MatchType
            mtypearray(i).id = i
            mtypearray(i).recount()
            MatchTypeBox.Items.Add(mtypearray(i).value)
        Next
        MatchTypeBox.SelectedIndex = 0
    End Sub
    Private Sub load_items()
        Dim headers() As String = {"#Number"}
        ItemsDGV.ColumnCount = 1

        With ItemsDGV.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(ItemsDGV.Font, FontStyle.Regular)
        End With

        With ItemsDGV
            .GridColor = Color.Black
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            .EditMode = DataGridViewEditMode.EditOnEnter
            For i = 0 To headers.Length - 1
                .Columns(i).Name = headers(i)
            Next
        End With
        'Fill itself
        Dim row() As String
        For i = 0 To DefaultConstants.n_of_items_in_a_match
            row = {(i + 1).ToString}
            ItemsDGV.Rows.Add(row)
        Next

        Dim itemscolumn As DataGridViewComboBoxColumn
        itemscolumn = New DataGridViewComboBoxColumn
        With itemscolumn
            itemscolumn.DataSource = ItemsConstants.Names
            .HeaderText = "Item"
            .DefaultCellStyle.NullValue = ItemsConstants.Names(0)
            .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            .FlatStyle = FlatStyle.Flat
            ItemsDGV.Columns.Add(itemscolumn)
        End With
        ItemsDGV.ClearSelection()


    End Sub

    Dim names(MData.wrestlers.Length - 1) As String
    Dim ids(MData.wrestlers.Length - 1) As String
    Private Sub load_wrestlers()
        Dim headers() As String = {"#Number"}
        WrestlersDGV.ColumnCount = 1

        With WrestlersDGV.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(WrestlersDGV.Font, FontStyle.Regular)
        End With

        With WrestlersDGV
            .AutoSizeRowsMode = _
               DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            .EditMode = DataGridViewEditMode.EditOnEnter
            For i = 0 To headers.Length - 1
                .Columns(i).Name = headers(i)
            Next
        End With
        'Fill itself
        Dim row() As String
        For i = 0 To number_of_wrestlers - 1
            row = {(i + 1).ToString()}
            WrestlersDGV.Rows.Add(row)
        Next

        'WRESTLERS
        Dim wrestlerscolumn As DataGridViewComboBoxColumn
        wrestlerscolumn = New DataGridViewComboBoxColumn
        ' Dim names() As String = {"F", "u", "c", "k"}
        'Dim names(MData.wrestlers.Length) As String
        Dim ids(MData.wrestlers.Length) As String
        For i = 0 To MData.wrestlers.Length - 1
            names(i) = MData.wrestlers(i).name
            ids(i) = MData.wrestlers(i).id_string
        Next

        With wrestlerscolumn
            .DataSource = names
            .HeaderText = "Wrestler"
            .DefaultCellStyle.NullValue = names(0)
            .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            .FlatStyle = FlatStyle.Flat
            WrestlersDGV.Columns.Add(wrestlerscolumn)
        End With


        'TEAMS
        If number_of_teams > 0 Then
            Dim teamscolumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn

            Dim teams(number_of_teams - 1) As String
            For i = 0 To number_of_teams - 1
                teams(i) = (i + 1).ToString
            Next
            With teamscolumn
                .DataSource = teams
                .HeaderText = "Team"
                .DefaultCellStyle.NullValue = teams(0)
                .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                .FlatStyle = FlatStyle.Flat

                WrestlersDGV.Columns.Add(teamscolumn)
            End With
        Else

        End If

        For i = 0 To number_of_wrestlers - 1
            WrestlersDGV.Item(1, i).Value = fill_different(WrestlersDGV, 1, MData.wrestlers)
        Next

    End Sub
    Public Structure Wname
    End Structure
    Private Sub Start_Simulation()
        ThisMatch.MatchType = New MatchType
        '==Ring

        MatchMenu.ring.lightings = 0 '3 'ring.lightings_array.Length - 1
        MatchMenu.ring.seats = 0 '2 'ring.seats_array.Length - 1
        MatchMenu.ring.titantron = False 'True
        MatchMenu.ring.type = 0 '2 ' ring.type_array.Length - 1
        MatchMenu.ring.recount()

        '==isPPV
        If isPPV.Checked Then
            ThisMatch.isPPV = True
        Else
            ThisMatch.isPPV = False
        End If
        '==MType
        ThisMatch.MatchType.id = MatchTypeBox.SelectedIndex
        ThisMatch.MatchType.recount()
        '==ReDim wr
        ThisMatch.number_of_wrestlers = number_of_wrestlers
        ReDim Preserve ThisMatch.wrestlers(number_of_wrestlers)

        '==ReDim teams
        If number_of_teams > 0 Then
            ThisMatch.isTeamMatch = True

            ReDim Preserve ThisMatch.BelongsToTeam(number_of_wrestlers)
        Else
            ThisMatch.isTeamMatch = False
        End If

        '==Items
        If ThisMatch.MatchType.isExtreme Then
            For i = 0 To DefaultConstants.n_of_items_in_a_match
                ThisMatch.items(i) = New Items
                Dim r As Object = ItemsDGV.Rows(i).Cells(1).Value
                If r = Nothing Then
                    ThisMatch.items(i).Id = 0
                Else
                    For k = 0 To ItemsConstants.Length - 1
                        If ItemsConstants.Names(k) = r Then
                            ThisMatch.items(i).Id = k
                        End If
                    Next
                    '  Dim k As Integer = Array.FindIndex(ItemsConstants.Names, r)

                End If
                ThisMatch.items(i).recount()
            Next
        End If
        '==Wrestlers
        For i = 0 To number_of_wrestlers - 1
            For j = 0 To MData.wrestlers.Length - 1
                Dim r2 As Object = WrestlersDGV.Rows(i).Cells(1).Value
                If r2 = Nothing Then
                    ThisMatch.wrestlers(i) = MData.wrestlers(0)
                Else
                    If WrestlersDGV.Rows(i).Cells(1).Value = MData.wrestlers(j).name Then
                        ThisMatch.wrestlers(i) = MData.wrestlers(j)
                        If number_of_teams > 0 Then
                            '==Teams
                            ThisMatch.BelongsToTeam(i) = WrestlersDGV.Rows(i).Cells(2).Value
                        End If
                    End If
                End If
            Next
        Next
        Dim shall_show As Boolean = True 'Depends on the Forced Winner index (correct/incorrect)
        If CheckBox1.Checked Then
            ThisMatch.isForcedWin = True
            Dim ind As Integer = -1
            For i = 0 To number_of_wrestlers - 1
                If ThisMatch.wrestlers(i).name = TextBox1.Text Then
                    ind = i
                End If
            Next
            If ind = -1 Then
                MsgBox("The Forced Winner name is not correct!", MsgBoxStyle.Critical)
                shall_show = False
            Else
                ThisMatch.forcedWinnerIndex = ind
            End If
        Else
            ThisMatch.isForcedWin = False
        End If
        MatchMenu.ThisMatch = ThisMatch
        If shall_show Then
            MatchMenu.ShallGenerate = True
            MatchMenu.Show()
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Start_Simulation()
    End Sub

    Private Sub MatchTypeBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles MatchTypeBox.SelectedIndexChanged
        If mtypearray(MatchTypeBox.SelectedIndex).isExtreme Then
            ItemsDGV.Enabled = True
            ItemsDGV.ForeColor = Color.Black

        Else
            ItemsDGV.Enabled = False
            ItemsDGV.ForeColor = Color.LightGray
            ItemsDGV.ClearSelection()
        End If
    End Sub
    Private Function fill_different(ByVal dgv As DataGridView, ByVal col As Integer, ByVal ar As Object)
        Dim value As String = ""
        Dim bool As Boolean
        For k = 0 To ar.length - 1
            bool = False
            For i = 0 To dgv.Rows.Count - 1
                If dgv.Item(col, i).Value = ar(k).name Then
                    bool = True
                End If
            Next
            If bool = False Then
                Return ar(k).name
            End If
        Next
        Return ar(0)
        'Return 0
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Enabled = True
        Else
            TextBox1.Text = ""
            TextBox1.Enabled = False
        End If
    End Sub



End Class