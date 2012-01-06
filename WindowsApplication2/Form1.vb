Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form
    Public pth As String = Application.StartupPath
    Dim pic_counter As Integer
    Dim nall As Integer
    Dim NUMBER_OF_TITLES As Integer = 6

    Public titlearray(NUMBER_OF_TITLES - 1, 2) As String
    Dim titlepic(NUMBER_OF_TITLES - 1, 2) As Image
    Dim titleholders(NUMBER_OF_TITLES - 1) As String
    Dim noneedlaternames(NUMBER_OF_TITLES - 1) As String
    Public wrestlers() As person
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
    End Structure
    Public Structure person
        Dim id_string As String
        Dim name As String
        Dim id As Integer
    End Structure
    Private Sub title_array_fill()

        'titlearray(0, 0) = "WWE Championship"
        'titlearray(1, 0) = "World Heavyweight Championship"
        'titlearray(2, 0) = "US Championship"
        'titlearray(3, 0) = "Intercontinental Championship"
        'titlearray(4, 0) = "Tag Team Championship"
        'titlearray(5, 0) = "Tag Team Championship"
        titlearray = filetoarray_oftitles(Path.Combine(pth, "sys\descriptions"))
        For i = 0 To NUMBER_OF_TITLES - 1
            ' FileOpen(1, pth & "\sys\descriptions\" & i & ".txt", OpenMode.Input)
            'Input(1, titlearray(i, 1))
            'FileClose(1)
            titlepic(i, 0) = Image.FromFile(Path.Combine(pth, "sys\descriptions", i & ".png"))
            titlepic(i, 1) = Image.FromFile(Path.Combine(pth, "fullsize", titleholders(i) & ".png"))
        Next

    End Sub
    Dim a() As pic_container
    Private Sub load_panel()
        Panel1.VerticalScroll.Enabled = True
        Panel1.HorizontalScroll.Enabled = True
        Panel1.HorizontalScroll.Visible = True
        Panel1.VerticalScroll.Visible = True


        a = return_pic(Path.Combine(pth, "renamed"))
        Dim numofel As Integer = a.Length - 1

        Dim count As Integer = 0

        InitPictureBoxArray(numofel)
        For i = 0 To numofel
            pics(i).ImageLocation = a(i).imagefile
            namelabels(i).Text = a(i).Name
        Next
        nall = numofel
        add_pics_to_panel(numofel)

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
    Private Function filetoarray_ofstring(ByVal filename As String)

        Dim str As String = ""
        Dim dim2 As Integer = -1
        Dim FinalArray(NUMBER_OF_TITLES - 1) As String
        Dim separator() As String = {"%"}
        ' For i = 0 To NUMBER_OF_TITLES - 1

        FileOpen(5, filename, OpenMode.Input)
        Input(5, str)
        FileClose(5)

        Dim data() As String 'тут будет строка из текстбокса, разбитая на одномерный массив с данными
        data = str.Split(separator, StringSplitOptions.RemoveEmptyEntries)
        For i = 0 To NUMBER_OF_TITLES - 1
            'MsgBox(i & ": " & data(i))
            FinalArray(i) = data(i)
        Next
        ' Next
        Dim myVariantArray As Object
        myVariantArray = FinalArray
        Return myVariantArray

    End Function
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  load_images()

        ' We can save the SimpleDatabase object somewhere else e.g. in the form class.
        Dim db As Databases.SimpleDatabase(Of person) = New Databases.SimpleDatabase(Of person)("renamed\ids\ids.xml")
        db.Load()
        wrestlers = db.Data.ToArray()

        titleholders = filetoarray_ofstring(Path.Combine(pth, "sys\descriptions\h.txt"))

        For j = 0 To NUMBER_OF_TITLES - 1
            If titleholders(j) = "" Then titleholders(j) = "9999"
            For i = 0 To wrestlers.Length - 1
                If wrestlers(i).id_string = titleholders(j) Then
                    noneedlaternames(j) = wrestlers(i).name
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

        ' Panel1.VerticalScroll.Value = 0
    End Sub
    Private Sub titleimageposition()
        title_image.Location = New Point(Int((wrestler.Width - title_image.Width) / 2), wrestler.Height - title_image.Height)
    End Sub
    Dim defaultimage As Image = Nothing
    Private Function return_pic(ByVal path As String) As Object
        Dim k As Integer = -1

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(path)
            k = k + 1
        Next
        Dim a(k) As String
        Dim obj(k) As pic_container
        Dim i As Integer = 0
        Dim l(), tmp As String


        For Each foundFile As String In My.Computer.FileSystem.GetFiles(path)
            obj(i).imagefile = foundFile

            obj(i).id = i


            '==========
            l = obj(i).imagefile.Split("\")
            tmp = l(l.Length - 1)
            l = tmp.Split(".")
            tmp = l(0)
            '  MsgBox(tmp)
            For j = 0 To wrestlers.Length - 1
                ' wrestlers(j).
                If wrestlers(j).id_string = tmp Then
                    wrestlers(j).id = i 'obj(i).id
                    'MsgBox(j)
                    obj(i).Name = wrestlers(j).name
                End If
            Next

            '==========

            i = i + 1

        Next

        defaultimage = Image.FromFile(obj(0).imagefile)

        Dim mas As Object = obj
        return_pic = mas

    End Function

    Private Sub add_pics_to_panel(ByVal noe As Integer)
        Dim leftp As Integer = 10
        Dim topp As Integer = 10
        Dim temp As Integer
        Dim count As Integer = 0
        Panel1.AutoScroll = True
        temp = leftp
        For i = 0 To Int(noe / 5) + 1

            For j = 0 To 5

                pics(count).Location = New System.Drawing.Point(leftp, topp)
                namelabels(count).Location = New System.Drawing.Point(leftp, topp + defaultimage.Height - 13)

                Panel1.Controls.Add(pics(count))
                Panel1.Controls.Add(namelabels(count))
                namelabels(count).BringToFront()
                count += 1
                If count >= noe Then GoTo 111
                leftp = leftp + 105
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
    Dim namelabels() As System.Windows.Forms.Label
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
                .ImageLocation = Path.Combine(pth, "sys\cntoff.jpg")
                .AutoSize = True
                .Location = New System.Drawing.Point(left, 0)
            End With
            left += 20
            AddHandler selectors(i).Click, AddressOf SelectorClick
            ' AddHandler selectors(i).MouseHover, AddressOf picClick
            'AddHandler selectors(i).MouseLeave, AddressOf picClick
            'AddHandler selectors(i).MouseEnter, AddressOf picClick
        Next
        selectors(0).ImageLocation = Path.Combine(pth, "sys\cnton.jpg")
    End Sub
    Private Sub make_selector_on(ByVal sel As Object)
        sel.ImageLocation = Path.Combine(pth, "sys\cnton.jpg")
    End Sub
    Private Sub make_selector_off(ByVal sel As Object)
        sel.ImageLocation = Path.Combine(pth, "sys\cntoff.jpg")
    End Sub

    Private Sub InitPictureBoxArray(ByVal Count As Integer)
        Dim i As Integer
        'Нижний индекс массива равен 0, поэтому, если мы хотим создать например
        'пять контролов, то должны иметь размер массива от 0 до 4
        'Count -= 1
        'Изменяем размерность массива
        ReDim Preserve pics(Count)
        ReDim Preserve namelabels(Count)
        For i = 0 To Count
            'Создаем новый экземпляр объекта, типа PictureBox
            pics(i) = New System.Windows.Forms.PictureBox()
            namelabels(i) = New System.Windows.Forms.Label()

            With namelabels(i)
                .BackColor = Color.Black
                .Font = SystemFonts.DefaultFont
                .ForeColor = Color.White
                .AutoSize = True
                .Cursor = Cursors.Hand
            End With
            With pics(i)
                'Ради примера, чтобы было видно все наши контролы,
                'Задаем каждому следующему PictureBox, разную Х координату (i*150)
                .Location = New System.Drawing.Point(i * 150, 0)
                'Задаем цвет
                ' .BackColor = System.Drawing.Color.AliceBlue
                'Здесь пишем любую нужную вам инициализацию экземпляров PictureBox
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Cursor = Cursors.Hand
            End With

            If namelabels(i).Width > pics(i).Width - 5 Then
                namelabels(i).Width = pics(i).Width - 5
            End If

            'Далее задаем функции для обработки событий 
            'MouseEnter, MouseLeave и Click соответственно
            ' AddHandler pics(i).MouseEnter, AddressOf picMEnter
            'AddHandler namelabels(i).MouseEnter, AddressOf picMEnter
            'AddHandler pics(i).MouseLeave, AddressOf picMLeave
            'AddHandler namelabels(i).MouseLeave, AddressOf picMLeave
            AddHandler pics(i).Click, AddressOf picClick
            AddHandler namelabels(i).Click, AddressOf labelclick
            'AddHandler pics(i).MouseHover, AddressOf picMHover
            'AddHandler namelabels(i).MouseHover, AddressOf picMHover
        Next i
        'Добавляем весь массив в коллекцию контролов формы
        Me.Controls.AddRange(Me.pics)
    End Sub
    Private Sub picMEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To nall
            pics(i).BorderStyle = BorderStyle.None
        Next
        sender.BorderStyle = BorderStyle.Fixed3D

    End Sub
    Private Sub picMLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.BorderStyle = BorderStyle.None
    End Sub
    Private Sub picMHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To nall
            pics(i).BorderStyle = BorderStyle.None
        Next
        sender.BorderStyle = BorderStyle.Fixed3D

    End Sub
    Private Sub labelclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        i = Array.IndexOf(namelabels, sender)
        Return_NAME(i)
    End Sub
    Private Sub picClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim j As Integer
        j = Array.IndexOf(pics, sender)
        '   MsgBox(j)
        '  Return_NAME(j)
        For i = wrestlers.Length - 1 To 0 Step -1

            If wrestlers(i).id = j Then
                ' MsgBox("")
                '   MsgBox(wrestlers(i).id)
                About_Wrestler.Wrestler_id = wrestlers(i).id_string
                About_Wrestler.Text = wrestlers(i).name
            End If
        Next
        About_Wrestler.Show()

    End Sub

    Private Sub Return_NAME(ByVal i As Integer)
        MsgBox(a(i).Name)
    End Sub
    Private Function random(ByVal lowerbound As Integer, ByVal upperbound As Integer)
        Randomize()
        Dim randomvalue As Integer
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
        'body.Text = titlearray(id, 1)
        'podselect(id)
    End Sub
    Private Sub podselect(ByVal id As Integer)
        cnterr = id
        text_fill(id)
        title_image.Image = titlepic(id, 0)
        wrestler.Image = titlepic(id, 1)
        ' title_image.Refresh()
        ' title_image.SizeMode = PictureBoxSizeMode.AutoSize
        titleimageposition()
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

    Private Sub underbody_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles underbody.Click
        About_Title.titleid = cnterr
        About_Title.Text = titlearray(cnterr, 0)
        About_Title.Show()
    End Sub

    Private Sub underbody_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles underbody.MouseLeave
        underbody.ForeColor = Color.White
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
