Imports System.IO
Imports System.Xml.Serialization
Public Class Form1

    Inherits System.Windows.Forms.Form
    Public pth As String = DefaultConstants.pth ' Application.StartupPath & "\" '"C:\wrestlers\"
    Dim pic_counter As Integer
    Dim nall As Integer
    Dim NUMBER_OF_TITLES As Integer = DefaultConstants.n_of_titles

    Public titlearray(NUMBER_OF_TITLES - 1, 2) As String
    Dim titlepic(NUMBER_OF_TITLES - 1, 2) As Image
    Dim titleholders(NUMBER_OF_TITLES - 1) As String
    Dim noneedlaternames(NUMBER_OF_TITLES - 1) As String
    'Public wrestlers() As person  'CCC
    ' Public Shared wrestlers() As WModel
    '============ NEWSTYPE ============
    Private Structure NewsType
        Dim type As Integer
        Dim title As String
        Dim info As String
        Dim wrestler1 As String
        Dim wrestler2 As String
        Dim wrestler3 As String
        Dim wrestler4 As String
        Dim wrestler5 As String
        Dim wrestler6 As String
        Dim wrestler0 As String
    End Structure
    Dim ev As NewsType
    'Type:
    ' 1 - New champion, wrestler1 - Champion's name
    ' 2 - New rivalry, wrestler1, wrestler2 - Rivals' names
    ' 3 - Face Turn, wrestler1 - wrestler's name
    ' 4 - Heel Turn, wrestler1 - wrestler's name
    ' 5 - Unexpectable victory, wrestler1 - winner, wrestler2 - looser
    ' 
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '===================================



    Private Structure pic_container
        Dim imagefile As String
        Dim id As Integer
        Dim Name As String
        Dim imgname As String
        Dim id_string As String
    End Structure
    Public Structure person
        Dim id_string As String
        Dim name As String
        Dim id As Integer
    End Structure
    Private Sub title_array_fill()

        titlearray = filetoarray_oftitles(Path.Combine(pth, "sys\descriptions"))
        For i = 0 To NUMBER_OF_TITLES - 1
            '===============
            For j = 0 To MData.wrestlers.Length - 1
                If MData.imcontainer(j).idstring = titleholders(i) Then
                    titlepic(i, 1) = MData.imcontainer(j).bigimage 'Image.FromFile(Path.Combine(pth, "fullsize", titleholders(i) & ".png"))
                    Exit For
                End If
            Next
            '================
            titlepic(i, 0) = Image.FromFile(Path.Combine(pth, "sys\descriptions", i & ".png"))
            '            titlepic(i, 1) = Image.FromFile(Path.Combine(pth, "fullsize", titleholders(i) & ".png"))
        Next

    End Sub


    Dim a() As pic_container
    Private Sub load_panel()
        Panel1.VerticalScroll.Enabled = True
        Panel1.HorizontalScroll.Enabled = True
        Panel1.HorizontalScroll.Visible = True
        Panel1.VerticalScroll.Visible = True


        ' a = normal_return_pic(Path.Combine(pth, "renamed"))
        ReDim Preserve a(MData.wrestlers.Length - 1)
        For i = 0 To a.Length - 1
            a(i).id_string = MData.wrestlers(i).id_string
            a(i).Name = MData.wrestlers(i).name
        Next
        defaultimage = My.Resources._99991


        Dim numofel As Integer = a.Length - 1

        Dim count As Integer = 0

        InitPictureBoxArray(numofel + 1)
        For i = 0 To numofel
            ' pics(i).ImageLocation = a(i).imagefile
            pics(i).Image = MData.imcontainer(i).smallimage
            'pics(i).Visible = True
            pics(i).InitialImage = Nothing
            pics(i).WaitOnLoad = True
            namelabels(i).Text = a(i).Name
        Next

        nall = numofel
        add_pics_to_panel(numofel + 1)

    End Sub

    Public Function filetoarray_oftitles(ByVal foldername As String)
        Dim str As String = ""
        Dim dim2 As Integer = -1
        Dim FinalArray(NUMBER_OF_TITLES, 2) As String
        Dim separator() As String = {"%"}
        For i = 0 To NUMBER_OF_TITLES - 1

            FileOpen(4, Path.Combine(foldername, i & ".txt"), OpenMode.Input)
            Input(4, str)
            FileClose(4)
            Dim data() As String 'тут будет строка из текстбокса, разбитая на одномерный массив с данными
            data = str.Split(separator, StringSplitOptions.RemoveEmptyEntries)
            FinalArray(i, 0) = data(0)

            FinalArray(i, 1) = data(1)

        Next
        Dim myVariantArray As Object
        myVariantArray = FinalArray
        Return myVariantArray
    End Function
    'Private Function filetoarray_ofstring(ByVal filename As String)

    '    Dim str As String = ""
    '    Dim dim2 As Integer = -1
    '    Dim FinalArray(NUMBER_OF_TITLES - 1) As String
    '    Dim separator() As String = {"%"}
    '    ' For i = 0 To NUMBER_OF_TITLES - 1

    '    FileOpen(5, filename, OpenMode.Input)
    '    Input(5, str)
    '    FileClose(5)

    '    Dim data() As String 'тут будет строка из текстбокса, разбитая на одномерный массив с данными
    '    data = str.Split(separator, StringSplitOptions.RemoveEmptyEntries)
    '    For i = 0 To NUMBER_OF_TITLES - 1
    '        'MsgBox(i & ": " & data(i))
    '        FinalArray(i) = data(i)
    '    Next
    '    ' Next
    '    Dim myVariantArray As Object
    '    myVariantArray = FinalArray
    '    Return myVariantArray

    'End Function
    Private Sub Title_Won()
        title_array_fill()
        text_fill(0)
    End Sub
    Private Sub text_fill(ByVal id As Integer)
        header.Text = noneedlaternames(id)
        body.Top = header.Bottom '+ 5
        body.Left = header.Left
        body.Text = titlearray(id, 1)
        underbody.Top = body.Bottom '+ 5
        underbody.Left = body.Left
        underbody.Text = "Full history"
    End Sub

    Private Sub FillPromColors()
        Panel1.BackColor = Basic.Colors2(Basic.Promotion)
        Me.BackgroundImage = Basic.P_ImagesBG(Basic.Promotion)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillPromColors()

        Dim dbtitleholders As Databases.SimpleDatabase(Of String) = New Databases.SimpleDatabase(Of String)("sys\descriptions\h.xml")
        dbtitleholders.Load()
        titleholders = dbtitleholders.Data.ToArray

        For j = 0 To NUMBER_OF_TITLES - 1
            If titleholders(j) = "" Then titleholders(j) = "9999"
            For i = 0 To MData.wrestlers.Length - 1
                If MData.wrestlers(i).id_string = titleholders(j) Then
                    noneedlaternames(j) = MData.wrestlers(i).name

                    If MData.wrestlers(i).Promotion = Basic.Promotion Then
                        wrestler.Cursor = Cursors.Hand
                    Else
                        wrestler.Cursor = Cursors.Arrow
                    End If

                End If
            Next
        Next

        load_panel()
        init_selector_pic_array(NUMBER_OF_TITLES - 1)
        Title_Won()
        title_image.Parent = wrestler
        titleimageposition()
        Selector_timer.Start()
        Select_Title(0)

        MData.ok()
    End Sub
    Private Sub titleimageposition()
        title_image.Location = New Point(Int((wrestler.Width - title_image.Width) / 2), wrestler.Height - title_image.Height)
    End Sub
    Dim defaultimage As Image = Nothing
    Dim obj() As pic_container
    Private Function normal_return_pic(ByVal path As String) As Object
        Dim num As Integer = MData.wrestlers.Length - 1

        'Dim obj(num) As pic_container

        ReDim Preserve obj(num)
        Dim picpath As String
        Dim defpath As String = path & "\9999.jpg"

        For i = 0 To num
            picpath = path & "\" & MData.wrestlers(i).id_string & ".jpg"

            'If File.Exists(picpath) Then
            'obj(i).imagefile = picpath
            'Else
            'obj(i).imagefile = defpath
            'End If
            obj(i).id_string = MData.wrestlers(i).id_string
            obj(i).Name = MData.wrestlers(i).name
        Next

        defaultimage = My.Resources._99991 'Image.FromFile(obj(0).imagefile)

        Dim mas As Object = obj
        Return mas

    End Function


    Private Sub add_pics_to_panel(ByVal noe As Integer)
        Dim leftp As Integer = 10
        Dim topp As Integer = 10
        Dim temp As Integer
        Dim count As Integer = 0
        Panel1.AutoScroll = True
        temp = leftp
        Dim defh As Integer = defaultimage.Height

        For i = 0 To Int(noe / 5) + 1


            '  Me.Controls.Remove(pics(count))
            For j = 0 To 5
                If (MData.wrestlers(count).id_string) <> "9999" And MData.wrestlers(count).Promotion = Basic.Promotion Then
                    pics(count).Location = New System.Drawing.Point(leftp, topp)
                    namelabels(count).Location = New System.Drawing.Point(leftp, topp + defh - 13)
                    '  j = Array.IndexOf(pics, sender)

                    Panel1.Controls.Add(pics(count))
                    Panel1.Controls.Add(namelabels(count))
                    namelabels(count).BringToFront()
                    leftp = leftp + 105
                Else
                    'If j > 0 Then
                    j -= 1
                    '  End If
                End If
                count += 1
                If count >= noe Then GoTo 111

                '     End If
            Next

            leftp = temp
            topp += 110
        Next

111:    Dim nullpb As System.Windows.Forms.PictureBox
        nullpb = New System.Windows.Forms.PictureBox
        nullpb.Image = Nothing
        topp += 70
        nullpb.Location = New System.Drawing.Point(leftp, topp)
        'Panel1.Controls.Add(nullpb)

    End Sub
    Dim pics() As System.Windows.Forms.PictureBox
    Public namelabels() As System.Windows.Forms.Label
    Dim selectors() As System.Windows.Forms.PictureBox
    Private Sub init_selector_pic_array(ByVal count As Integer)
        ReDim Preserve selectors(count)
        Dim left As Integer = 0
        For i = 0 To count
            selectors(i) = New System.Windows.Forms.PictureBox()

            With selectors(i)
                .Width = 5
                .Parent = Selector_panel
                .BackColor = Color.Transparent
                '.Font = SystemFonts.DefaultFont
                .SizeMode = PictureBoxSizeMode.AutoSize
                .BorderStyle = BorderStyle.None
                .Image = My.Resources.cntoff
                .AutoSize = True
                .Location = New System.Drawing.Point(left, 0)
            End With
            left += 20
            AddHandler selectors(i).Click, AddressOf SelectorClick
            ' AddHandler selectors(i).MouseHover, AddressOf picClick
            'AddHandler selectors(i).MouseLeave, AddressOf picClick
            'AddHandler selectors(i).MouseEnter, AddressOf picClick
        Next
        selectors(0).Image = My.Resources.cnton
    End Sub
    Private Sub make_selector_on(ByVal sel As Object)
        sel.Image = My.Resources.cnton
    End Sub
    Private Sub make_selector_off(ByVal sel As Object)
        sel.Image = My.Resources.cntoff
    End Sub

    Private Sub InitPictureBoxArray(ByVal Count As Integer)
        Dim i As Integer
        ReDim Preserve pics(Count)
        ReDim Preserve namelabels(Count)
        For i = 0 To Count
            pics(i) = New System.Windows.Forms.PictureBox()
            namelabels(i) = New System.Windows.Forms.Label()

            With namelabels(i)
                .BackColor = Color.Black
                .Font = SystemFonts.DefaultFont
                .ForeColor = Color.White
                .AutoSize = True
                .Cursor = Cursors.Hand
                Dim s As Size
                s.Width = 105
                .MaximumSize = s
            End With
            With pics(i)
                '    .Parent = Panel1
                '  .Location = New System.Drawing.Point(i * 150, 0)

                .Height = 105 '105
                .Width = 98 '98
                .SizeMode = PictureBoxSizeMode.Zoom
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Cursor = Cursors.Hand
            End With

            If namelabels(i).Width > pics(i).Width - 5 Then
                namelabels(i).Width = pics(i).Width - 5
            End If

            AddHandler pics(i).Click, AddressOf picClick
            AddHandler namelabels(i).Click, AddressOf labelclick
        Next i
        '     Me.Controls.AddRange(Me.pics)
    End Sub

    Private Sub labelclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim j As Integer
        j = Array.IndexOf(namelabels, sender)
        ' MsgBox(pics(j).Height)
        open_About_Window(j)
    End Sub
    Dim About_Wrestler_Array() As Object
    Dim k As Integer = 0
    Private Sub picClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim j As Integer
        j = Array.IndexOf(pics, sender)
        open_About_Window(j)
    End Sub
    Public Sub open_About_Window(ByVal j As Integer)
        k += 1
        ReDim Preserve About_Wrestler_Array(k)
        About_Wrestler_Array(k) = New About_Wrestler
        About_Wrestler_Array(k).Wrestler_id = MData.wrestlers(j).id_string
        About_Wrestler_Array(k).selected_wrestler = MData.wrestlers(j)
        About_Wrestler_Array(k).Show()
    End Sub
    Private Sub Return_NAME(ByVal i As Integer)
        MsgBox(a(i).Name)
    End Sub
    Public Function random(ByVal lowerbound As Integer, ByVal upperbound As Integer)
        Randomize()
        Dim randomvalue As Integer
        ' Math.()
        randomvalue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Return randomvalue
    End Function
    Private Sub SelectorClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        i = Array.IndexOf(selectors, sender)
        'Return_NAME(i)
        For j = 0 To selectors.Length - 1
            make_selector_off(selectors(j))
        Next
        make_selector_on(sender)
        podselect(i)
        Selector_timer.Stop()
        Selector_timer.Start()

    End Sub
    Dim cnterr As Integer = 0
    Private Sub Select_Title(ByVal id As Integer)
        SelectorClick(selectors(id), System.EventArgs.Empty)
    End Sub
    Private Sub podselect(ByVal id As Integer)
        cnterr = id
        text_fill(id)
        title_image.Image = titlepic(id, 0)
        wrestler.Image = titlepic(id, 1)
        ' title_image.Refresh()
        ' title_image.SizeMode = PictureBoxSizeMode.AutoSize
        titleimageposition()
        Dim ind As Integer

        For i = 0 To MData.wrestlers.Length - 1
            If (MData.wrestlers(i).id_string = titleholders(cnterr)) And (titleholders(cnterr) <> "9999") Then
                ind = i
            End If
        Next

        If MData.wrestlers(ind).Promotion = Basic.Promotion Then
            wrestler.Cursor = Cursors.Hand
        Else
            wrestler.Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub Selector_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Selector_timer.Tick
        cnterr += 1
        If cnterr = NUMBER_OF_TITLES Then
            cnterr = 0
        End If
        Select_Title(cnterr)
    End Sub


    Private Sub underbody_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles underbody.MouseHover, underbody.MouseEnter
        ' sender.icon = ""
        underbody.ForeColor = Color.Red
    End Sub

    Private Sub underbody_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles underbody.Click, title_image.Click
        About_Title.titleid = cnterr
        About_Title.Text = titlearray(cnterr, 0)
        About_Title.Show()
    End Sub

    Private Sub underbody_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles underbody.MouseLeave
        underbody.ForeColor = Color.White
    End Sub

    Private Sub wrestler_Click(sender As System.Object, e As System.EventArgs) Handles wrestler.Click

        For i = 0 To MData.wrestlers.Length - 1
            If (MData.wrestlers(i).id_string = titleholders(cnterr)) And (titleholders(cnterr) <> "9999") And (MData.wrestlers(i).Promotion = Basic.Promotion) Then
                open_About_Window(i)
            End If
        Next
    End Sub
    Private Sub Form1_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel

        Dim delta As Integer = Panel1.VerticalScroll.Value - e.Delta

        If delta < Panel1.VerticalScroll.Minimum Then
            delta = Panel1.VerticalScroll.Minimum
        ElseIf delta > Panel1.VerticalScroll.Maximum Then
            delta = Panel1.VerticalScroll.Maximum
        End If

        Panel1.VerticalScroll.Value = delta
        Panel1.AutoScroll = True

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        Dim dbtitleholders As Databases.SimpleDatabase(Of String) = New Databases.SimpleDatabase(Of String)("sys\descriptions\h.xml")
        dbtitleholders.Load()
        titleholders = dbtitleholders.Data.ToArray

        For j = 0 To NUMBER_OF_TITLES - 1
            If titleholders(j) = "" Then titleholders(j) = "9999"
            For i = 0 To MData.wrestlers.Length - 1
                If MData.wrestlers(i).id_string = titleholders(j) Then
                    noneedlaternames(j) = MData.wrestlers(i).name
                End If
            Next
        Next

        load_panel()
        init_selector_pic_array(NUMBER_OF_TITLES - 1)
        Title_Won()
        title_image.Parent = wrestler
        titleimageposition()
        Selector_timer.Start()
        Select_Title(0)

        MData.ok()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MData.Sort_WModel_By_Name(MData.wrestlers)
        Close()
    End Sub
End Class
