Public Class WrestlerGenerator
    '  Const notmax = 10
    Dim number As Integer
    Dim nickname(500) As String
    Dim usname(5000) As String
    Dim unusname(500) As String
    Dim lastname(5000) As String
    Dim styles(50) As String
    Dim pic(100) As String
    Dim num1, num2, num3, num4, num5 As Integer
    Dim res As String = Application.StartupPath & "\wrestlergen\"
    Dim managerkoef As Integer = 4 'Коэфицент менеджера по найму персонала. Чем меньше, тем лучше.
    Dim notify() As String
    Dim isfirst As Boolean = True
    Dim method2 As Boolean = False
    Dim mypics As New List(Of PictureBox)

    Private Sub fillpic()
        'add the PB's to the List
        '  mypics.Add(

        For Each pb As PictureBox In mypics
            pb.Top += 1
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        method2 = False
        createtable()
    End Sub
    Private Sub createtable()
        ListView1.Clear()
        For i = 0 To 99
            pic(i) = ""
        Next
        managerkoef = 11 - udk.Value
        '   TextBox1.Text = returnfinisher()
        '  TextBox2.Text = returnname()

        ' Set ListView Properties  
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False
        ListView1.MultiSelect = False

        ' Create Columns Headers  
        ListView1.Columns.Add("Name")
        ListView1.Columns.Add("Style")
        For i = 0 To WStats.description.Length - 2
            ListView1.Columns.Add(WStats.description(i))
        Next
        ListView1.Columns.Add("Age")
        ListView1.Columns.Add("Cost ($)")
        ListView1.Columns.Add("Finisher")
        ListView1.Columns.Add("Special")
        '  ListView1.Columns.Add("Picture")

        Dim tempValue As Integer = 0

        For i As Integer = 0 To 19

            ' Create List View Item (Row)  
            Dim lvi As New ListViewItem

            Dim cost As Integer
            lvi.Text = returnname() ' Добавить имя


            lvi.SubItems.Add(getstyle2())
           


            Dim s As String = special(managerkoef)
            For j = 0 To WStats.description.Length - 2
                lvi.SubItems.Add(random(10, 100 - managerkoef * 7)) ' Add stats
                cost += lvi.SubItems(2 + j).Text * 50 'TODO: Add realistic prices
            Next
            cost -= random(0, (11 - managerkoef)) * 100

            lvi.SubItems.Add(random(18, 30)) ' Добавить возраст
            lvi.SubItems.Add(cost) ' Добавить возраст
            lvi.SubItems.Add(returnfinisher) 'Добавить финишер

            cost = 0
            Dim tempn As Integer
            For x = 0 To notify.Length - 1
                If notify(x) = s Then
                    tempn = x
                End If
            Next

            If tempn Mod 2 = 0 Then
                lvi.SubItems.Add(s).ForeColor = Color.Green 'Special
            Else
                lvi.SubItems.Add(s).ForeColor = Color.DarkRed 'Special
            End If
            pic(i) = Nothing
            '    MsgBox(pic(i))

            ' Add the ListViewItem to the ListView  
            ListView1.Items.Add(lvi)

        Next
        For Each column As ColumnHeader In Me.ListView1.Columns
            column.Width = -2
        Next
    End Sub
    Private Function make_stronger(ByVal current As Integer, ByVal max As Integer, ByVal increasement As Integer)
        make_stronger = Int(Math.Abs(current + (max - current) / increasement))
    End Function
    Private Function special(ByVal koef As Integer)
        Dim s As String = ""
        Dim chance As Integer = random(0, 100 * koef)
        'TODO: Add chances
        Dim n As Integer = random(0, koef + 1)
        If n = 1 Then
            s = Perk.description(random(0, Perk.description.Length - 1))
        End If

        'If chance = 1 Then
        '    s = notify(0) '5 star match
        'ElseIf chance > 10 And chance < 20 Then
        '    s = notify(4) 'Fan favourite
        'ElseIf chance > 20 And chance < 30 Then
        '    s = notify(2) 'Perspective wrestler
        'ElseIf chance > 95 * koef Then
        '    s = notify(1) 'Trouble Maker
        'ElseIf chance = 2 Then
        '    s = notify(6) 'Indie Legend
        'End If

        Return s

    End Function
    'Private Sub ListView1_SelectedIndexChanged(ByVal sender As  _
    '    System.Object, ByVal e As System.EventArgs) _
    '    Handles ListView1.SelectedIndexChanged

    '    If ListView1.SelectedIndices.Count = 0 Then Return

    '    Dim lvi As ListViewItem = _
    '        ListView1.SelectedItems(0)

    '    MessageBox.Show(lvi.Text + " has been selected.")
    'End Sub

    Private Function returnfinisher()
        Dim pre() As String
        Dim mid() As String
        Dim post() As String
        ' Dim res As String = Application.StartupPath & "\"

        Dim result As String
        Dim chance As Integer


        pre = filetoarray("finishergenprefix.txt", res)

        chance = random(CInt(-number * 1.5), number)
        If chance < 0 Then
            result = ""
        Else
            result = pre(chance) & " "
        End If

        Dim s As String
        mid = filetoarray("finishergenmiddle.txt", res)

        chance = random(0, number)
        s = mid(chance)
        If s(0) = "*" Then
            result = ""
        End If

        result = result & mid(chance)
        s = Replace(s, "*", "")

        post = filetoarray("finishergenpostfix.txt", res)

        chance = random(-3 * number, number)
        If chance < 0 Then

        Else
            If s(0) <> "!" Then
                result = result & " " & post(chance)

            End If
        End If
        result = Replace(result, "*", "")
        result = Replace(result, "!", "")
        Return (result)

    End Function
    Private Function returnname()
        Dim result As String = ""
        Dim x As Integer = random(1, 100)
        Dim ch1, ch2, ch3, ch4 As Integer
        ch1 = 10
        ch2 = 100
        ch3 = 65
        ch4 = 75

        '1) Только никнейм - 10%
        '2) Только имя и фамилия - 35%
        '3) "Ник" Имя Фамилия - 20%
        '4) Имя "Ник" - 5%
        '5) Имя "Ник" Фамилия - 30%

        'Right(s, Len(s) - 1) 
        Dim t As String = ""
        If x < ch1 Then
            '  If method2 Then
            result = "The " & getnickname2()
            '   Else
            '       result = "The " & getnickname()
            '  End If


        ElseIf x >= ch1 And x < ch2 Then
            '  If method2 Then
            result = getrandomname2() & " " & getlastname2()
            'Else
            '    result = getrandomname() & " " & getlastname()
            '   End If


        ElseIf x >= ch2 And x < ch3 Then
            ' If method2 Then
            result = """" & getnickname2() & """" & " " & getrandomname2() & " " & getlastname2()
            'Else
            '    result = """" & getnickname() & """" & " " & getrandomname() & " " & getlastname()
            'End If



        ElseIf x >= ch3 And x < ch4 Then
            '    If method2 Then
            result = getrandomname2() & " " & getnickname2()
            'Else
            '   result = getrandomname() & " " & getnickname()
            ' End If


        ElseIf x >= ch4 Then
            '    If method2 Then
            result = getrandomname2() & " " & """" & "The " & getnickname2() & """" & " " & getlastname2()
            ' Else
            '    result = getrandomname() & " " & """" & "The " & getnickname() & """" & " " & getlastname()
            ' End If


        End If

        Return (result)
    End Function
    'Private Function getrandomname()
    '    Dim chance As Integer = random(1, 4)
    '    Dim result As String

    '    If chance = 3 Then
    '        result = getunusname()
    '    Else
    '        result = getusname()
    '    End If

    '    Return result
    'End Function
    'Private Function getusname()
    '    Return fast_return_random_string_from_file("commonfirst.txt", res)
    'End Function
    'Private Function getunusname()
    '    Return fast_return_random_string_from_file("uncommonfirst.txt", res)
    'End Function
    'Private Function getnickname()
    '    Return fast_return_random_string_from_file("nicknames.txt", res)
    'End Function
    'Private Function getlastname()
    '    Return fast_return_random_string_from_file("last.txt", res)
    'End Function

    Private Function return_pic(ByVal path As String) As String
        Dim k As Integer = -1

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
  path)
            k = k + 1
            ' listBox1.Items.Add(foundFile)
        Next
        Dim a(k) As String
        Dim i As Integer = 0
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(
path)
            a(i) = foundFile
            i = i + 1
            '  k = k + 1
            ' listBox1.Items.Add(foundFile)
        Next
        return_pic = a(random(0, k))

    End Function
    Private Function random(ByVal lowerbound As Integer, ByVal upperbound As Integer)
        Randomize()
        Dim randomvalue As Integer
        randomvalue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Return randomvalue
    End Function

    Private Function filetoarray(ByVal filename As String, ByVal resources As String)
        Dim str As String = ""
        Dim dim2 As Integer = -1
        FileOpen(1, resources & filename, OpenMode.Input)
        Input(1, str)
        FileClose(1)
        Dim i, L As Integer

        For i = 0 To str.Length - 1
            If str(i) = "%" Then dim2 = dim2 + 1
        Next

        number = dim2

        i = 0
        L = 0
        Dim rowcount As Integer ' сюда запишем число строк
        Dim separator() As String = {"%"} ' по % мы делим данные

        Dim data() As String 'тут будет строка из текстбокса, разбитая на одномерный массив с данными
        data = str.Split(separator, StringSplitOptions.RemoveEmptyEntries)
        rowcount = 26
        Dim FinalArray(dim2) As String ' сюда мы сформируем окончательный массив

        For i = 0 To dim2
            FinalArray.SetValue(data.GetValue(L), i)
            L = L + 1
        Next
        Dim myVariantArray As Object
        myVariantArray = FinalArray
        Return myVariantArray
    End Function

    Private Sub WrestlerGenerator_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MData.CanFocus Then
            MData.Focus()
        End If
    End Sub

    'Private Function fast_return_random_string_from_file(ByVal filename As String, ByVal resources As String)
    '    Dim result As String = ""
    '    Dim str As String = ""
    '    Dim dim2 As Integer = -1
    '    FileOpen(1, resources & filename, OpenMode.Input)
    '    Input(1, str)
    '    FileClose(1)
    '    Dim i As Integer

    '    For i = 0 To str.Length - 1
    '        If str(i) = "%" Then dim2 = dim2 + 1
    '    Next

    '    Dim x As Integer = random(0, dim2)
    '    Dim temp As Integer = 0
    '    For i = 0 To str.Length - 1

    '        If temp = x Then
    '            For j = i To str.Length - 1
    '                If str(j) = "%" Then
    '                    Exit For
    '                Else
    '                    result = result & str(j)
    '                End If
    '            Next
    '            Exit For
    '        Else
    '            If str(i) = "%" Then temp = temp + 1
    '        End If
    '    Next

    '    Return result
    'End Function




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        heelface.SelectedIndex = 0
        notify = WStats.description
        Button2.PerformClick()
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Text = returnfinisher()
    End Sub

    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        TextBox1.Text = returnfinisher()
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click, TextBox2.DoubleClick
        TextBox2.Text = returnname()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        method2 = True
        If isfirst Then
            usname = filetoarray("commonfirst.txt", res)
            num1 = number
            unusname = filetoarray("uncommonfirst.txt", res)
            num2 = number
            lastname = filetoarray("last.txt", res)
            num3 = number
            nickname = filetoarray("nicknames.txt", res)
            num4 = number
            styles = WStyles.description 'filetoarray("styles.txt", res)
            num5 = styles.Length - 1
        End If
        createtable()

        ListView1.Focus()
        ListView1.Items(0).Selected = True

        '   ListView1.foc


    End Sub
    Private Function getrandomname2()
        Dim chance As Integer = random(1, 4)
        Dim result As String

        If chance = 3 Then
            result = getunusname2()
        Else
            result = getusname2()
        End If

        Return result

    End Function
    Private Function getunusname2() As String

        getunusname2 = unusname(random(0, num2))

    End Function
    Private Function getusname2() As String

        getusname2 = usname(random(0, num1))
    End Function

    Private Function getlastname2() As String
        getlastname2 = lastname(random(0, num3))
    End Function

    Private Function getnickname2() As String
        getnickname2 = nickname(random(0, num4))
    End Function
    Private Function getstyle2() As String
        getstyle2 = styles(random(0, num5))
    End Function

    Private Sub ListView1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Hire()
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click, ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Hire()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim s As Image = Nothing

        s = open_image(".jpg")

        If s Is Nothing Then
            mini_image.Image = My.Resources._99991
            im2changed = False
        Else
            mini_image.Image = s
            im2changed = True
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim s As Image = Nothing

        s = open_image(".png")

        If s Is Nothing Then
            fullsize_image.Image = My.Resources._9999
            im1changed = False
        Else
            fullsize_image.Image = s
            im1changed = True
        End If
    End Sub
    Public Function open_image(ByVal format As String) As Image
        Dim s As OpenFileDialog = New OpenFileDialog
        s.InitialDirectory = Application.StartupPath
        s.Multiselect = False

        s.Filter = "Image Files (*" & format & ") | *" & format
        s.ShowDialog()

        If s.FileName = "" Then
            Return Nothing
        End If

        Dim result As Image
        Try
            result = Image.FromFile(s.FileName)
        Catch ex As Exception
            MsgBox("Couldn't open the selected image." & vbCrLf & "Error description:" & vbCrLf & ex.ToString)
            result = Nothing
        End Try
        Return result
    End Function

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        mini_image.Image = My.Resources._99991
        fullsize_image.Image = My.Resources._9999
        im1changed = False
        im2changed = False
    End Sub

    Private Sub Button3_Click_2(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Hire()
    End Sub
    Dim im1changed As Boolean = False
    Dim im2changed As Boolean = False
    Private Sub Hire()

        Dim lvi As ListViewItem = _
            ListView1.SelectedItems(0)
        Dim s As MsgBoxResult
        Dim wroverall, micoverall As Integer
        wroverall = CInt(lvi.SubItems.Item(2).Text.ToString)
        micoverall = CInt(lvi.SubItems.Item(3).Text.ToString)

        Dim tempmoney As Double = MData.Currency.Money - lvi.SubItems.Item(8).Text
        If tempmoney > 0 Then
            MData.Currency.Money -= lvi.SubItems.Item(8).Text
            s = MessageBox.Show("Are you sure you want to hire " & lvi.Text & vbCrLf &
                                "(Wrestling Overall: " & wroverall.ToString & "; Microphone Overall: " & micoverall & ")" & vbCrLf &
                                "as " & heelface.SelectedItem.ToString & " with push = " & NumericUpDown1.Value.ToString & "?", "Recruit Agency", MessageBoxButtons.YesNoCancel)
            If s = MsgBoxResult.Yes Then
                '  MsgBox("Recruitment is not available for now", MsgBoxStyle.OkOnly, "Sorry")
                Dim new_wr As WModel = New WModel
                new_wr.name = lvi.Text

                For i = 0 To WStyles.description.Length - 1
                    If WStyles.description(i) = lvi.SubItems.Item(1).Text Then
                        new_wr.style = i
                    End If
                Next

                For i = 0 To DefaultConstants.n_of_stats - 2
                    new_wr.stats(i) = CInt(lvi.SubItems.Item(i + 2).Text.ToString)
                Next
                new_wr.stats(5) = NumericUpDown1.Value
                new_wr.Finisher = lvi.SubItems.Item(9).Text

                'new_wr.isFace
                If heelface.SelectedItem.ToString = "Heel" Then
                    new_wr.isFace = False
                ElseIf heelface.SelectedItem.ToString = "Face" Then
                    new_wr.isFace = True
                End If



                new_wr.id_string = WModel.bring_id_to_string_form(MData.wrestlers.Length)
                ReDim Preserve MData.wrestlers(MData.wrestlers.Length)
                ReDim Preserve MData.imcontainer(MData.wrestlers.Length - 1)
                MData.wrestlers(MData.wrestlers.Length - 1) = new_wr
                If im1changed Then
                    Dim bigimage As Image = fullsize_image.Image
                    Try
                        bigimage.Save(DefaultConstants.pth & "fullsize\" & new_wr.id_string & ".png")
                    Catch ex As Exception
                        ' MsgBox("Error saving wrestler's pic. Error description: " & vbCrLf & ex.Message)
                    End Try

                End If
                If im2changed Then
                    Dim smallimage As Image = mini_image.Image
                    smallimage.Save(DefaultConstants.pth & "renamed\" & new_wr.id_string & ".jpg")
                End If

                With MData.imcontainer(MData.wrestlers.Length - 1)
                    .bigimage = fullsize_image.Image
                    .smallimage = mini_image.Image
                End With

                MData.UpdateMoney()
                ListView1.Items.Remove(ListView1.SelectedItems.Item(0))

                MsgBox("Wrestler hired!")

                MData.Sort_WModel_By_Name(MData.wrestlers)

                If ListView1.Items.Count > 0 Then
                    ListView1.Items.Item(0).Selected = True
                  Else
                    MsgBox("You have hired all the available wrestlers!")
                    Me.Close()
                End If
            End If
        Else
            MsgBox("You don't have enough money to hire this wrestler.")
        End If
    End Sub

End Class
