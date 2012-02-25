Imports System
Imports System.IO
Imports System.Xml.Serialization
Public Class About_Title
    Public titleid As Integer

    Dim num_of_columns As Integer = 3
    '  Dim table_content(1000, 3) As String
    Public Structure TitleDescriptionArray
        Dim titlename As String
        Dim description As String
    End Structure
    Dim descarr() As TitleDescriptionArray
    Public Structure title_table
        Dim winner As String
        Dim looser As String
        Dim w_event As String
    End Structure
    Dim tc() As title_table
    Private Sub About_Title_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        header.Parent = Panel1
        body.Parent = Panel1
        listview1.Parent = Panel1

        readtitleinfo()
        header.Text = descarr(titleid).titlename
        body.Text = descarr(titleid).description

        body.Top = header.Bottom + 5
        body.Left = header.Left
        listview1.Top = body.Bottom + 5
        listview1.Left = body.Left
        listview1.Width = Panel1.Width - (listview1.Left * 2)
        listview1.Height = Panel1.Height - listview1.Top - 10
        readtitlehistory(Path.Combine(Form1.pth, "sys\descriptions", titleid & "hi.txt"))
        createtable()
    End Sub
    Private Sub readtitleinfo()
        Dim infdb As Databases.SimpleDatabase(Of TitleDescriptionArray) = New Databases.SimpleDatabase(Of TitleDescriptionArray)("sys\descriptions\titleinf.xml")
        infdb.Load()
        descarr = infdb.Data.ToArray

    End Sub
    Dim dim2 As Integer
    Private Sub readtitlehistory(ByVal path As String)

        Dim tcdb As Databases.SimpleDatabase(Of title_table) = New Databases.SimpleDatabase(Of title_table)("sys\descriptions\" & titleid & "hi.xml")
        tcdb.Load()
        tc = tcdb.Data.ToArray

    End Sub
    ' Dim len As Integer
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

        For i As Integer = 0 To tc.Length - 1

            Dim lvi As New ListViewItem
            lvi.Text = i + 1
            ' For j = 1 To num_of_columns
            lvi.SubItems.Add(tc(i).winner)

            lvi.SubItems.Add(tc(i).looser)

            lvi.SubItems.Add(tc(i).w_event)
            ' Next
            listview1.Items.Add(lvi)

        Next
        For Each column As ColumnHeader In Me.listview1.Columns
            column.Width = -2
        Next
    End Sub

    Private Sub listview1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listview1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


        Dim objStreamWriter As New StreamWriter(Path.Combine("sys", "descriptions", titleid & "hi.xml"))
        Dim ser As New XmlSerializer(tc.GetType)
        ser.Serialize(objStreamWriter, tc)
        objStreamWriter.Close() 'сериализация массива
        MsgBox("Done")
    End Sub
    Private Sub custom_fill()
        ReDim Preserve descarr(5)
        For i = 0 To 5
            descarr(i).titlename = "N " & i.ToString
            descarr(i).description = "D " & i.ToString
        Next
    End Sub
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        For i = 0 To 5
            'descarr(i).description = readtitleinfo(Path.Combine(Form1.pth, "sys\descriptions", i & "inf.txt"))
            descarr(i).titlename = Form1.titlearray(i, 0)
        Next
        ' custom_fill()
        Dim objStreamWriter As New StreamWriter(Path.Combine("sys", "descriptions", "titleinf.xml"))
        Dim ser As New XmlSerializer(descarr.GetType)
        ser.Serialize(objStreamWriter, descarr)
        objStreamWriter.Close() 'сериализация массива
        MsgBox("Done")
    End Sub
End Class