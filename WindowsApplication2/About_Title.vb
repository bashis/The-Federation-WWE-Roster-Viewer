Imports System
Imports System.IO

Public Class About_Title
    Public titleid As Integer
    Dim num_of_columns As Integer = 3
    Dim table_content(1000, 3) As String
    Private Sub About_Title_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Parent = Panel1
        body.Parent = Panel1
        listview1.Parent = Panel1
        header.Text = Form1.titlearray(titleid, 0)
        body.Top = header.Bottom + 5
        body.Left = header.Left
        body.Text = readtitleinfo(Path.Combine(Form1.pth, "sys\descriptions", titleid, "inf.txt"))
        listview1.Top = body.Bottom + 5
        listview1.Left = body.Left
        listview1.Width = Panel1.Width - (listview1.Left * 2)
        listview1.Height = Panel1.Height - listview1.Top - 10
        readtitlehistory(Path.Combine(Form1.pth, "sys\descriptions", titleid, "hi.txt"))
        createtable()
    End Sub
    Private Function readtitleinfo(ByVal path As String)
        Dim result As String = ""
        FileOpen(9, path, OpenMode.Input)
        Input(9, result)
        FileClose(9)
        Return result
    End Function
    Dim dim2 As Integer
    Private Sub readtitlehistory(ByVal path As String
                                      )
        Dim result As String = ""
        FileOpen(10, path, OpenMode.Input)
        Input(10, result)
        FileClose(10)


        For i = 0 To result.Length - 1
            If result(i) = "%" Then dim2 += 1
        Next

        Dim data() As String
        data = result.Split("%")
        Dim cnt As Integer = 0
        For j = 0 To dim2 / 3
            For i = 1 To num_of_columns
                table_content(j, i) = data(cnt)
                cnt += 1
            Next
        Next
    End Sub
    Private Sub createtable()
        listview1.Clear()




        ' Set ListView Properties  
        listview1.View = View.Details
        listview1.GridLines = True
        listview1.FullRowSelect = True
        listview1.HideSelection = False
        listview1.MultiSelect = False

        ' Create Columns Headers  
        listview1.Columns.Add("№")
        listview1.Columns.Add("Champion")
        listview1.Columns.Add("Defeated")
        listview1.Columns.Add("Show")
        'ListView1.Columns.Add("Place of birth")
        'ListView1.Columns.Add("Finisher")
        'ListView1.Columns.Add("Special")
        '  ListView1.Columns.Add("Picture")

        ' Dim tempValue As Integer = 0

        For i As Integer = 0 To dim2 / 3 - 1

            Dim lvi As New ListViewItem
            lvi.Text = i + 1
            For j = 1 To num_of_columns
                lvi.SubItems.Add(table_content(i, j))
            Next
            listview1.Items.Add(lvi)

        Next
        For Each column As ColumnHeader In Me.listview1.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub listview1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listview1.SelectedIndexChanged

    End Sub
End Class