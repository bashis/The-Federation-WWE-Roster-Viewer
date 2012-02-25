Imports System.IO
Imports System.Xml.Serialization
Public Class MData
    Public wrestlers() As WModel
    Public Titles(DefaultConstants.n_of_titles - 1) As Title
    Public Currency As Currency = New Currency
    Public pth As String = DefaultConstants.pth
    Public status As Object = st
    Public Sub fillWSD(ByVal Dialog As Object)
        Dim stclass As WStats = New WStats
        Dim defclass As DefaultConstants = New DefaultConstants
        Dialog.statclass = stclass
        Dialog.defclass = defclass
        Dialog.autofill(wrestlers)
    End Sub
    Public Sub FillMoney() 'To Be Deleted
        Currency.Money = 1000000
        UpdateMoney()
    End Sub
    Public Sub UpdateMoney()
        ToolStripStatusLabel1.Text = "Money: $" & ToDotView(Currency.Money)
    End Sub
    Public Structure image_Container
        Dim idstring As String
        Dim bigimage As Image
        Dim smallimage As Image
    End Structure
    Public imcontainer() As image_Container
    Private Sub load_wimages()
        ReDim imcontainer(wrestlers.Length - 1)
        Dim picpath As String
        For i = 0 To wrestlers.Length - 1
            imcontainer(i).idstring = wrestlers(i).id_string
            Dim path1 As String = DefaultConstants.pth & "renamed"
            picpath = path1 & "\" & wrestlers(i).id_string & ".jpg"

            If File.Exists(picpath) Then
                Try
                    imcontainer(i).smallimage = Image.FromFile(picpath)
                Catch ex As Exception
                    imcontainer(i).smallimage = My.Resources._99991
                End Try
            Else
                imcontainer(i).smallimage = My.Resources._99991
            End If

            Dim path2 As String = DefaultConstants.pth & "fullsize"
            picpath = path2 & "\" & wrestlers(i).id_string & ".png"


            If File.Exists(picpath) Then
                Try
                    imcontainer(i).bigimage = Image.FromFile(picpath)
                Catch ex As Exception
                    imcontainer(i).bigimage = My.Resources._9999
                End Try

            Else
                imcontainer(i).bigimage = My.Resources._9999
            End If
            imcontainer(i).idstring = wrestlers(i).id_string

        Next
    End Sub
    Private Sub FillBrands()
        For i = 0 To Basic.P_Names.Length - 1
            ComboBox1.Items.Add(Basic.P_Names(i))
        Next
        ComboBox1.SelectedIndex = 1
        Basic.Promotion = 1
        Basic.recount()
    End Sub

    Public Sub change_TitleHolder(ByVal TitleID As Integer, ByVal NewOwner As WModel)

        Titles(TitleID).Holder_ID_String = NewOwner.id_string

    End Sub
    Private Sub MData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        FillBrands() 'TODO: Delete this sub
        '   WrestlerSelectionDialog1.autofill(wrestlers)
        FillMoney() ' TODO: Delete this sub



        st.Text = "Loading wrestlers DataBase..."
        Dim wrestlersdb As Databases.SimpleDatabase(Of WModel) = New Databases.SimpleDatabase(Of WModel)("renamed\ids\Wrestlers_table.xml")
        wrestlersdb.Load()
        wrestlers = wrestlersdb.Data.ToArray


        CheckDB()

        st.Text = "Idle"
        load_wimages()
        fillWSD(WrestlerSelectionDialog1)

        '==
        SelectionDialog21.imageclass = Me
        SelectionDialog21.warr = wrestlers
        SelectionDialog21.build()
        '==

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        st.Text = "Opening RosterViewer..."
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        st.Text = "Opening MatchSetup..."
        MatchSetup.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        st.Text = "Opening DataBase Editor..."
        DBEdit.Show()
    End Sub
    Public Sub ok()
        st.Text = "Idle"
    End Sub
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        st.Text = "Saving wrestlers DataBase..."
        SaveWrestlers()
        MsgBox("Done")
        st.Text = "Idle"
    End Sub
    Public Sub SaveWrestlers()
        Dim objStreamWriter As New StreamWriter(Path.Combine(pth, "renamed\ids\Wrestlers_table.xml"))
        Dim ser As New XmlSerializer(Me.wrestlers.GetType)
        ser.Serialize(objStreamWriter, Me.wrestlers)
        objStreamWriter.Close() 'сериализация массива
    End Sub

    Private Sub AutosaveTimer_Tick(sender As System.Object, e As System.EventArgs) Handles AutosaveTimer.Tick
        st.Text = "Autosaving..."
        SaveWrestlers()
        notifycnt1 = 0
        Notify1.Start()
    End Sub
    Dim notifycnt1 As Integer
    Private Sub Notify1_Tick(sender As System.Object, e As System.EventArgs) Handles Notify1.Tick
        If notifycnt1 > 5 Then
            st.Text = "Idle"
            Notify1.Stop()
        Else
            st.Text = "Autosaved"
            notifycnt1 += 1
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            If Not AutosaveTimer.Enabled Then
                AutosaveTimer.Start() '
            End If
        ElseIf Not CheckBox1.Checked Then
            If AutosaveTimer.Enabled Then
                AutosaveTimer.Stop()
            End If
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As System.EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        Dim x As System.Media.SoundPlayer = New System.Media.SoundPlayer
        '   x.SoundLocation = "C:\1.wav"
        '  x.Play()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        PromoForm.Show()

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        Dim stclass As WStats = New WStats
        Dim defclass As DefaultConstants = New DefaultConstants
        WrestlerSelectionDialog1.statclass = stclass
        WrestlerSelectionDialog1.defclass = defclass
        WrestlerSelectionDialog1.autofill(wrestlers)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        MsgBox(WSelect.ShowDialog)
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        ShowViewer.Show()
    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        WrestlerGenerator.Show()
    End Sub

    Public Sub CheckDB()
        Dim noerr As Boolean = True

        For i = 0 To wrestlers.Length - 1
            For j = 0 To wrestlers.Length - 1
                If i <> j Then
                    If wrestlers(i).id_string = wrestlers(j).id_string Then
                        noerr = False
                        MsgBox("Wrestlers with the same ids found! The programm may work incorrectly! Please, check your database!")
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        TrainingForm.Show()
    End Sub
    Public Function HowMuchTitlesDoesHeOwn(ByVal Wrestler As WModel) As Integer
        Dim cnt As Integer = 0
        For i = 0 To DefaultConstants.n_of_titles - 1
            If Wrestler.Titles(i) <> 0 Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Sub WrestlerSelectionDialog1_Load(sender As System.Object, e As System.EventArgs) Handles WrestlerSelectionDialog1.Load

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        '    Dim s As WModel = 'WSelect.WrestlerSelectionDialog1.'ShowDialog()
        Dim seldial As WSelect = New WSelect
        Dim res As DialogResult = seldial.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            MsgBox(seldial.WrestlerSelectionDialog1.current_selection.name)
        End If
    End Sub
    Public Function SelectWrestler()

        Dim wsd As WSelect = New WSelect
        wsd.ShowDialog()
        If wsd.DialogResult = Windows.Forms.DialogResult.OK Then
            Return wsd.WrestlerSelectionDialog1.current_selection
        Else
            Return Nothing
        End If

    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Basic.Promotion = ComboBox1.SelectedIndex
        Basic.recount()
    End Sub
    Public Sub Sort_WModel_By_Name(ByRef Arr() As WModel)
        Dim temp As WModel
        Dim temp2 As image_Container
        For i = 0 To Arr.Length - 1
            For j = i To Arr.Length - 1
                If Arr(i).name > Arr(j).name Then
                    temp = Arr(i)
                    Arr(i) = Arr(j)
                    Arr(j) = temp
                    temp2 = imcontainer(i)
                    imcontainer(i) = imcontainer(j)
                    imcontainer(j) = temp2
                End If
            Next
        Next
    End Sub
    Public Function ToDotView(ByVal num As Integer) As String

        Dim res As String = ""

        Dim ost As Integer = num.ToString.Length Mod 3
        Dim str As String = num.ToString
        ' MsgBox(ost)
        'For i = 0 To num.ToString.Length - 1
        If ost <> 0 Then
            For j = 0 To ost - 1
                res += str(j)
            Next
            res += "."
        End If
        ' MsgBox(res)
        For i = ost To num.ToString.Length - 1 Step 3
            res += str(i) & str(i + 1) & str(i + 2) & "."

        Next
        'Next
        res = res.Substring(0, res.Length - 1)

        Return res
    End Function
End Class