Imports System.IO
Imports System.Linq
Imports System.Xml.Serialization
Public Class DBEdit

    Private Sub DBEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MData.ok()

        load_headers()
        PopulateDataGridView()

    End Sub
    Dim new_wrestlers() As WModel
    Private Sub save_DB()
        ReDim Preserve new_wrestlers(k)
        For i = 0 To k
            new_wrestlers(i) = New WModel

            With new_wrestlers(i)

                .id = i
                .id_string = DataGridView1.Item(0, i).Value
                .name = DataGridView1.Item(1, i).Value

                For j = 0 To column_header.Length - 3
                    .stats(j) = DataGridView1.Item(j + 2, i).Value
                Next
                For j = 0 To DefaultConstants.n_of_perks_at_once
                    Dim tmp As Object
                    tmp = DataGridView1.Rows(i).Cells(j + column_header.Length).Value
                    If tmp = Nothing Then
                        .perks(j) = 0
                    Else
                        .perks(j) = Array.IndexOf(Perk.description, tmp)
                    End If
                Next
                Dim tmp2 As Object
                tmp2 = DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 1 + column_header.Length).Value
                If tmp2 = Nothing Then
                    .style = 0
                Else
                    .style = Array.IndexOf(WStyles.description, tmp2)
                End If
                tmp2 = DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 2 + column_header.Length).Value
                If tmp2 = Nothing Then
                    .isFace = True
                Else
                    If tmp2 = "Face" Then
                        .isFace = True
                    Else
                        .isFace = False
                    End If
                End If

                tmp2 = DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 3 + column_header.Length).Value
                If tmp2 = Nothing Then
                    .Promotion = 0
                Else
                    .Promotion = Array.IndexOf(Basic.P_Names, tmp2)
                End If
                .Finisher = DataGridView1.Item(DefaultConstants.n_of_perks_at_once + 4 + column_header.Length, i).Value
            End With
        Next

        Dim objStreamWriter As New StreamWriter(Path.Combine(Form1.pth, "renamed", "ids", "Wrestlers_table.xml"))
        Dim ser As New XmlSerializer(new_wrestlers.GetType)
        ser.Serialize(objStreamWriter, new_wrestlers)
        objStreamWriter.Close() 'сериализация массива
        MsgBox("Done")

    End Sub

    Dim column_header As String() = {"id_string", "Name", "Wrestling", "Microphone",
            "Calmness", "Insanity", "Fan-Base", "Push"}
    Private Sub load_headers()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.ColumnCount = column_header.Length



        With DataGridView1.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(DataGridView1.Font, FontStyle.Regular)
        End With

        With DataGridView1
            .AutoSizeRowsMode = _
               DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .RowHeadersVisible = False

            For i = 0 To column_header.Length - 1
                .Columns(i).Name = column_header(i)
            Next
            '

            '
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            .Dock = DockStyle.Fill

        End With
        defdgv = DataGridView1
    End Sub
    Dim k As Integer
    Dim combocolumn(DefaultConstants.n_of_perks_at_once + 3) As DataGridViewComboBoxColumn
    Dim defdgv As DataGridView
     Private Sub PopulateDataGridView()

        '     Dim db As Databases.SimpleDatabase(Of WModel) = New Databases.SimpleDatabase(Of WModel)("renamed\ids\Wrestlers_table.xml")

        'db.Load()
        Dim wr() As WModel
        wr = MData.wrestlers
        k = wr.Length - 1

        Dim row As String()

        For i = 0 To k
            row = {wr(i).id_string, wr(i).name, wr(i).stats(0), wr(i).stats(1), wr(i).stats(2),
                   wr(i).stats(3), wr(i).stats(4), wr(i).stats(5)}

            Me.DataGridView1.Rows.Add(row)
            If i Mod 2 = 0 Then
                Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.WhiteSmoke
            End If
        Next

        'Me.DataGridView1.Rows.Remove(DataGridView1.Rows.Item(wr.Length - 1))
        '  Dim cbo As DataGridViewEditingControlShowingEventArgs
        For i = 0 To DefaultConstants.n_of_perks_at_once
            combocolumn(i) = New DataGridViewComboBoxColumn()
            combocolumn(i).DataSource = Perk.description
            combocolumn(i).HeaderText = "Perk " & (i + 1).ToString
            combocolumn(i).DefaultCellStyle.NullValue = "None"
            combocolumn(i).DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            combocolumn(i).FlatStyle = FlatStyle.Flat
            ' combocolumn(i).DisplayIndex = 10

            DataGridView1.Columns.Add(combocolumn(i))
            '    AddHandler combocolumn(i).HeaderText.changed(), AddressOf htc
            ' AddHandler selectors(i).MouseHover, AddressOf picClick
        Next
        combocolumn(DefaultConstants.n_of_perks_at_once + 1) = New DataGridViewComboBoxColumn()
        With combocolumn(DefaultConstants.n_of_perks_at_once + 1) 'Style Column
            .DataSource = WStyles.description
            .HeaderText = "Style"
            .DefaultCellStyle.NullValue = WStyles.description(0)
            .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            .FlatStyle = FlatStyle.Flat
            DataGridView1.Columns.Add(combocolumn(DefaultConstants.n_of_perks_at_once + 1))
        End With

        combocolumn(DefaultConstants.n_of_perks_at_once + 2) = New DataGridViewComboBoxColumn()
        With combocolumn(DefaultConstants.n_of_perks_at_once + 2) 'Role Column
            .DataSource = {"Face", "Heel"}
            .HeaderText = "Role"
            .DefaultCellStyle.NullValue = "Face"
            .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            .FlatStyle = FlatStyle.Flat
            DataGridView1.Columns.Add(combocolumn(DefaultConstants.n_of_perks_at_once + 2))
        End With

        combocolumn(DefaultConstants.n_of_perks_at_once + 3) = New DataGridViewComboBoxColumn()
        With combocolumn(DefaultConstants.n_of_perks_at_once + 3) 'Promotion Column
            .DataSource = Basic.P_Names
            .HeaderText = "Promotion"
            .DefaultCellStyle.NullValue = Basic.P_Names(0)
            .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            .FlatStyle = FlatStyle.Flat
            DataGridView1.Columns.Add(combocolumn(DefaultConstants.n_of_perks_at_once + 3))
        End With

        Dim finishercol As DataGridViewColumn = New DataGridViewColumn()
        With finishercol
            .CellTemplate = DataGridView1.Item(0, 0)
            .HeaderText = "Finisher"
            .DefaultCellStyle.NullValue = ""
            DataGridView1.Columns.Add(finishercol)
        End With



        For i = 0 To k
            For j = 0 To DefaultConstants.n_of_perks_at_once
                DataGridView1.Rows(i).Cells(j + column_header.Length).Value = Perk.description(wr(i).perks(j))
            Next
            DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 1 + column_header.Length).Value = WStyles.description(wr(i).style)

            If wr(i).isFace Then
                DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 2 + column_header.Length).Value = "Face"
            Else
                DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 2 + column_header.Length).Value = "Heel"
            End If

            DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 3 + column_header.Length).Value = Basic.P_Names(wr(i).Promotion)
    
            DataGridView1.Rows(i).Cells(DefaultConstants.n_of_perks_at_once + 4 + column_header.Length).Value = wr(i).Finisher

        Next
        'Dim c As DataGridViewColumn = New DataGridViewColumn
        '    For i = 0 To DataGridView1.Rows.Count - 2

        'Next
        'c = DataGridView1.Columns.Item(1)
        'DataGridView1.Columns.Add(c)

    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        save_DB()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        Dim ans As MsgBoxResult
        ans = MsgBox("All unsaved changes will be lost. Continue?", MsgBoxStyle.YesNoCancel)
        If ans = MsgBoxResult.Yes Then
            For i = 0 To k
                'DataGridView1.ClearSelection()
            Next
            DataGridView1.DataSource = Nothing
            load_headers()
            PopulateDataGridView()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AddWrestlerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub RemoveWrestlerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveWrestlerToolStripMenuItem.Click
        Dim res As String = InputBox("Input the id of wrestler to remove: ", "Remove")
        Dim ar(DataGridView1.Rows.Count) As String
        For i = 0 To DataGridView1.Rows.Count - 2
            ar(i) = DataGridView1.Item(0, i).Value.ToString
        Next
        Dim index1 As Integer
        index1 = Array.IndexOf(ar, res)
        If index1 <> -1 Then
            DataGridView1.Rows.Remove(DataGridView1.Rows.Item(index1))
            '  index2 = Array.IndexOf(new_wrestlers, res)
        Else
            MsgBox("Wrestler not found")
        End If
        'Array.IndexOf()
    End Sub

    Private Sub NormalizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NormalizeToolStripMenuItem.Click
        '  Dim r As MsgBoxResult
        '  r = MsgBox("Sure?", MsgBoxStyle.OkCancel, "Force Normalize ids")
        ' If r = MsgBoxResult.Ok Then
        For i = 0 To DataGridView1.Rows.Count - 2
            DataGridView1.Item(0, i).Value = WModel.bring_id_to_string_form(DataGridView1.Item(0, i).Value)
        Next
        'End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AddWrestlerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AddWrestlerToolStripMenuItem1.Click
        Dim n As String = InputBox("What's his name?", "Adding a wrestler", "Wrestler " & k)
        If n <> "" Then

            k += 1
            Dim addrow As String() = {WModel.bring_id_to_string_form(k), n, "0", "0", "0", "0", "0", "0"}
            DataGridView1.Rows.Add(addrow)

        End If
    End Sub

    Private Sub CheckIfAlreadyExistsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CheckIfAlreadyExistsToolStripMenuItem.Click
        Dim n As String = InputBox("Input the name to check", "Finding a wrestler", "")
        Dim s As String = ""
        Dim k As Integer = 1
        Dim x As Integer
        If n <> "" Then
            For i = 0 To DataGridView1.Rows.Count - 2
                If DataGridView1.Item(1, i).Value = n Then
                    s = s & k.ToString & ". Row " & i.ToString & ", Id " & DataGridView1.Item(0, i).Value & vbCrLf
                    x = i
                    k += 1
                End If
            Next
        End If

        Dim t As String = " times"
        If k > 1 Then
            If k = 2 Then t = " time"
            MsgBox("This wrestler already exists in database!" & vbCrLf & "All in all: " &
                   k - 1 & t & vbCrLf & vbCrLf & s)
            ' DataGridView1.Item(0,x).Visible
            '
        Else
            MsgBox("There is no wrestler named " & n & " in the database")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub
End Class