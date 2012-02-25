Imports System.IO
Imports System.Linq
Public Class About_Wrestler
    Public Wrestler_id As String
    Dim actual_id As Integer = 0
    Public selected_wrestler As WModel

    Private Sub BrandColors()
        Wrestler_Header.Image = Basic.BackImage1
        Button1.BackColor = Basic.Color1
        Button2.BackColor = Basic.Color1
    End Sub
    Private Sub About_Wrestler_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Right Then
            Button2.PerformClick()
        ElseIf Asc(e.KeyChar) = Keys.Left Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub FillPromColors()
         Me.BackgroundImage = Basic.P_ImagesBG(Basic.Promotion)
    End Sub
    Dim isFacePicArray(1) As Image
    Dim StylesPicArray(WStyles.description.Length - 1) As Image
    Dim PerksPicArray(DefaultConstants.n_of_perks - 1) As Image
    Private Sub picarraysfill()

        isFacePic.SizeMode = PictureBoxSizeMode.Zoom
        isFacePic.BorderStyle = BorderStyle.None

        isFacePicArray(0) = Image.FromFile(Path.Combine(DefaultConstants.gimmick_path, "face.png"))
        isFacePicArray(1) = Image.FromFile(Path.Combine(DefaultConstants.gimmick_path, "heel.png"))

        For i = 0 To WStyles.description.Length - 1
            StylesPicArray(i) = Image.FromFile(Path.Combine(DefaultConstants.styles_path, i & ".png"))
        Next

        For i = 0 To DefaultConstants.n_of_perks - 1
            PerksPicArray(i) = Image.FromFile(DefaultConstants.perks_path & i & ".jpg")
        Next

    End Sub
    Private Sub About_Wrestler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillPromColors()
        picarraysfill()
        '  Wrestler_Header.Image = Basic.BackImage1
        ' Me.ParentForm = Form1
        BrandColors()
        find_actual_id()
        FormLoad()
        fix_panel_size()

          End Sub
    Private Sub fix_panel_size() 'doesnt work correctly
        Dim sz As Size
        sz.Height = SplitContainer1.Panel1.Height
        SplitContainer1.Panel1MinSize = sz.Height
        'SplitContainer1.Panel1.MaximumSize = sz
        sz.Height = SplitContainer1.Panel2.Height
        SplitContainer1.Panel2MinSize = sz.Height
        'SplitContainer1.Panel2.MaximumSize = sz

    End Sub
    Private Sub find_actual_id()
        For i = 0 To MData.wrestlers.Length - 1
            If MData.wrestlers(i).id_string = Wrestler_id Then
                actual_id = i 'May be for later usage. Doubt though.
            End If
        Next
    End Sub
    Private Sub FormLoad()
        ' info.MaximumSize.Width = Infopanel.Width

        desc_label.Parent = Panel1
        desc_label.Left = 0
        desc_label.Width = Panel1.Width
        namelabel.Parent = Wrestler_Header
        wrestler_image.Parent = Wrestler_Header
        template_stviewer.Parent = SplitContainer1.Panel1


        namelabel.Text = selected_wrestler.name
        Try
            'wrestler_image.Image = Image.FromFile(Path.Combine(Form1.pth, "fullsize", selected_wrestler.id_string & ".png"))
            wrestler_image.Image = MData.imcontainer(actual_id).bigimage
        Catch ex As Exception
            Try
                wrestler_image.Image = My.Resources._9999
            Catch ex2 As Exception
            End Try
        End Try
        Push.cur_wr = MData.wrestlers(actual_id)
        Me.Text = selected_wrestler.name

        fillstats()
        load_stats()

        infLabel.Parent = namelabel.Parent
        infLabel.Top = namelabel.Bottom
        infLabel.Left = namelabel.Left
        Dim h, weight, finisher As String
        h = "0"
        weight = "0"
        finisher = ""
     
        ReDim Preserve inflabels(4)

        For i = 0 To inflabels.Length - 1
            If inflabels(i) Is Nothing Then
                inflabels(i) = New Label
            Else
                inflabels(i).Text = ""
            End If
        Next

        inflabels(0).Text = "Style: " & WStyles.description(selected_wrestler.style)
        inflabels(1).Text = "Height: " & selected_wrestler.height
        inflabels(2).Text = "Weight: " & selected_wrestler.weight
        inflabels(3).Text = "Finisher: " & selected_wrestler.Finisher
        inflabels(4).Text = "Gimmick: " & Gimmick_from_Boolean(selected_wrestler)

        For i = 0 To inflabels.Length - 1
            With inflabels(i)
                .AutoSize = True
                .Parent = namelabel.Parent
                .ForeColor = Color.White
                .BackColor = Color.Black
                If i = 0 Then
                    .Top = namelabel.Bottom
                Else
                    .Top = inflabels(i - 1).Bottom
                End If
                .Left = namelabel.Left
                .Font = infLabel.Font

                If Not Wrestler_Header.Controls.Contains(inflabels(i)) Then
                    Wrestler_Header.Controls.Add(inflabels(i))
                End If

                AddHandler (inflabels(i).MouseEnter), (AddressOf showname)
                AddHandler (inflabels(i).MouseHover), (AddressOf showname)
                AddHandler (inflabels(i).MouseLeave), (AddressOf deletename)

            End With
        Next

        '   d = New Timer
        '  d.Interval = 1000
        ' d.Start()
        'AddHandler d.Tick, AddressOf Valuerchange
        'Valuer1.Value = 10 'selected_wrestler.Tired
        'Valuer1.ReCount(100)

    End Sub
    'Dim d As Timer
    Private Sub Valuerchange()
        ' d.Stop()
        '   Valuer1.Value = 10 'selected_wrestler.Tired
        '  Valuer1.ReCount(100)
        '  d.Stop()
    End Sub
    Public inflabels() As Label
    Dim n_stats As Integer = DefaultConstants.n_of_stats - 1
    Private Sub fillstats() 'to be deleted
        '  Dim abilities(DefaultConstants.n_of_perks_at_once - 1) As Integer
        ' abilities(0) = 0
        'abilities(1) = 1

        p1Pic.Image = PerksPicArray(selected_wrestler.perks(0))
        p2Pic.Image = PerksPicArray(selected_wrestler.perks(1))

        If selected_wrestler.isFace Then
            isFacePic.Image = isFacePicArray(0)
        Else
            isFacePic.Image = isFacePicArray(1)
        End If

        StylePic.Image = StylesPicArray(selected_wrestler.style)

        '=======================================
        ' Dim ab As Ability_control = New Ability_control
        'ab.Parent = SplitContainer1.Panel2
        'ab.Top = 0
        'ab.Left = 0
        'ab.abilities(0) = 0
        'ab.abilities(1) = 1

        'ab.Width = SplitContainer1.Panel2.Width
        'ab.Height = SplitContainer1.Panel2.Height

        '        SplitContainer1.Panel2.Controls.Add(ab)
        '       ab.rebuild()
    End Sub
    Dim stbar(n_stats) As Statviewer
    Private Sub load_stats()
        template_stviewer.Visible = False
        Dim img As Image ' = Image.FromFile("C:\img1.jpg")
        'template_stviewer.pic.Image = img

        For i = 0 To n_stats - 1
            img = Image.FromFile(Path.Combine(Form1.pth, "logos\" & i & ".jpg"))

            '   If SplitContainer1.Panel1.Controls.Contains(stbar(i)) Then
            '  SplitContainer1.Panel1.Controls.Remove(stbar(i))
            '  End If

            '  stbar(i) = Nothing
            If SplitContainer1.Panel1.Controls.Contains(stbar(i)) = False Then
                stbar(i) = New Statviewer()
            End If
            With stbar(i)
                .description = WStats.description(i)
                .desc_object = desc_label
                .Parent = SplitContainer1.Panel1
                .Width = template_stviewer.Width
                .Height = template_stviewer.Height
                .Left = template_stviewer.Left + (template_stviewer.Width + 5) * i
                .Top = template_stviewer.Top
                .Visible = True
                'stbar(i).Show()
                .stringvalue.Text = selected_wrestler.stats(i).ToString
                .rebuild()
                stbar(i).pic.Image = img
            End With

            If SplitContainer1.Panel1.Controls.Contains(stbar(i)) = False Then
                SplitContainer1.Panel1.Controls.Add(stbar(i))
            End If
        Next

        With (Push)
            .Top = template_stviewer.Top
            .Left = stbar(n_stats - 1).Right + 7
            .desc_object = desc_label
            .bar.Value = selected_wrestler.stats(n_stats)
            .rebuild()
        End With

        ' Valuer1.Value = selected_wrestler.Tired
        'Valuer1.ReCount(100)

    End Sub

    Private Sub template_stviewer_MouseEnter(sender As Object, e As System.EventArgs) Handles template_stviewer.MouseEnter
        desc_label.Text = sender.description
    End Sub

    Private Sub showname() Handles wrestler_image.MouseHover, wrestler_image.MouseEnter, Wrestler_Header.MouseEnter, Wrestler_Header.MouseHover, namelabel.MouseEnter, namelabel.MouseHover
        desc_label.Text = selected_wrestler.name
    End Sub

    Private Sub isFacePic_MouseEnter(sender As Object, e As System.EventArgs) Handles isFacePic.MouseEnter, isFacePic.MouseHover
        If selected_wrestler.isFace = True Then
            desc_label.Text = "Face"
        Else
            desc_label.Text = "Heel"
        End If
    End Sub

    Private Sub p1Pic_MouseEnter(sender As Object, e As System.EventArgs) Handles p1Pic.MouseEnter, p1Pic.MouseHover
        desc_label.Text = Perk.description(selected_wrestler.perks(0))
    End Sub
    Private Sub p2Pic_MouseEnter(sender As Object, e As System.EventArgs) Handles p2Pic.MouseEnter, p2Pic.MouseHover
        desc_label.Text = Perk.description(selected_wrestler.perks(1))
    End Sub

    Private Sub deletename() Handles Wrestler_Header.MouseLeave, wrestler_image.MouseLeave, namelabel.MouseLeave, p1Pic.MouseLeave, p2Pic.MouseLeave, isFacePic.MouseLeave, StylePic.MouseLeave
        desc_label.Text = ""
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim new_id As Integer = actual_id + 1
10:

        If new_id >= MData.wrestlers.Length Then
            new_id = 0
        End If

        If MData.wrestlers(new_id).id_string = "9999" Or MData.wrestlers(new_id).Promotion <> Basic.Promotion Then
            new_id += 1
            GoTo 10  '    Button2.PerformClick()
        End If

        If new_id >= MData.wrestlers.Length Then
            new_id = 0
        End If

        Me.selected_wrestler = MData.wrestlers(new_id)
        actual_id = new_id
        FormLoad()

        desc_label.Text = ""

        ' About_Wrestler_Load(sender, e) ' Handles MyBase.Load
        Me.Focus()
        '  Form1.open_About_Window(new_id)
        ' Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim new_id As Integer = actual_id - 1
10:

        If new_id < 0 Then
            new_id = MData.wrestlers.Length - 1
        End If

        If MData.wrestlers(new_id).id_string = "9999" Or MData.wrestlers(new_id).Promotion <> Basic.Promotion Then
            new_id -= 1
            GoTo 10
        End If

        If new_id < 0 Then
            new_id = MData.wrestlers.Length - 1
        End If

        Me.selected_wrestler = MData.wrestlers(new_id)
        actual_id = new_id
        '   Form1.open_About_Window(new_id)
        '  Me.Close()
        'About_Wrestler_Load(sender, e) ' Handles MyBase.Load
        FormLoad()
        Me.Focus()
    End Sub

    Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabControl1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TabControl1.KeyDown
        ' If Asc(e.KeyCha
    End Sub

    Private Sub TabControl1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TabControl1.KeyPress
        '  MsgBox("rrr")
        Dim RightcharU, RightcharL, LeftcharU, LeftcharL As Char
        RightcharL = "d"
        RightcharU = "D"
        LeftcharL = "a"
        LeftcharU = "A"
        If Asc(e.KeyChar) = Asc(RightcharL) Or Asc(e.KeyChar) = Asc(RightcharU) Then
            Button2.PerformClick()
        ElseIf Asc(e.KeyChar) = Asc(LeftcharL) Or Asc(e.KeyChar) = Asc(LeftcharU) Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub rightleft(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        MsgBox("")
        If e.KeyCode = Keys.Right Then

            Button2.PerformClick()
        ElseIf e.KeyCode = Keys.Left Then
            Button1.PerformClick()
        End If

    End Sub

    Private Sub About_Wrestler_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Dim delta As Integer = Infopanel.VerticalScroll.Value - e.Delta

        If delta < Infopanel.VerticalScroll.Minimum Then
            delta = Infopanel.VerticalScroll.Minimum
        ElseIf delta > Infopanel.VerticalScroll.Maximum Then
            delta = Infopanel.VerticalScroll.Maximum
        End If

        Infopanel.VerticalScroll.Value = delta
        Infopanel.AutoScroll = True
    End Sub

    Private Sub About_Wrestler_Move(sender As Object, e As System.EventArgs) Handles Me.Move

    End Sub

    Private Sub rightleft(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub Push_Load(sender As System.Object, e As System.EventArgs) Handles Push.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim r As MsgBoxResult = MsgBox("Sure?", MsgBoxStyle.OkCancel)
        If r = MsgBoxResult.Ok Then
            If MData.imcontainer.Length > actual_id + 1 Then
                'MData.imcontainer = RemoveElementIMC(MData.imcontainer, actual_id)
            End If
            MData.wrestlers(actual_id).Promotion = 0
            ' MData.wrestlers = RemoveElementWMODEL(MData.wrestlers, actual_id)
            Form1.Close()
            Form1.Show()
            Me.Close()
        End If

    End Sub
    Public Function RemoveElementWMODEL(ByVal array As Object, ByVal index As Integer)
        Dim n As Integer = array.length

        Dim t As Type = array.GetType

        Dim result() As WModel
        If array.length >= 1 Then
            ReDim result(array.length - 2)
        Else
            Return Nothing
        End If

        If index = 0 Then
            For i = 1 To n - 1
                result(i - 1) = array(i)
            Next
        ElseIf index = array.length - 1 Then
            For i = 0 To n - 2
                result(i) = array(i)
            Next
        Else
            For i = 0 To index - 1
                result(i) = array(i)
            Next
            For j = index + 1 To n - 1
                result(j - 1) = array(j)
            Next
        End If
        Return result
    End Function
    Public Function RemoveElementIMC(ByVal array As Object, ByVal index As Integer)
        Dim n As Integer = array.length

        Dim result() As MData.image_Container
        If array.length >= 1 Then
            ReDim result(array.length - 2)
        Else
            Return Nothing
        End If

        If index = 0 Then
            For i = 1 To n - 1
                result(i - 1) = array(i)
            Next
        ElseIf index = array.length - 1 Then
            For i = 0 To n - 2
                result(i) = array(i)
            Next
        Else
            For i = 0 To index - 1
                result(i) = array(i)
            Next
            For j = index + 1 To n - 1
                result(j - 1) = array(j)
            Next
        End If
        Return result
    End Function
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim s As String = InputBox("Enter the new name:", "Changing the name", selected_wrestler.name)
        If s <> "" Then
            MData.wrestlers(actual_id).name = s
            If Form1.CanFocus Then
                Form1.namelabels(actual_id).Text = s
            End If
            FormLoad()
            Me.Focus()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim s As String = InputBox("Enter the new finisher:", "Changing the finisher", selected_wrestler.Finisher)
        If s <> "" Then
            MData.wrestlers(actual_id).Finisher = s
            FormLoad()
            Me.Focus()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim temp1, temp2 As String

        If selected_wrestler.isFace Then
            temp1 = "Face"
            temp2 = "Heel"
        Else
            temp1 = "Heel"
            temp2 = "Face"
        End If
        Dim res As MsgBoxResult = MsgBox("This person is currently " & temp1 & "." & vbCrLf & "Change his gimmick to " & temp2 & "?", MsgBoxStyle.YesNo, "Changing the gimmick")
        If res = MsgBoxResult.Yes Then
            selected_wrestler.isFace = Not selected_wrestler.isFace
            FormLoad()
            MsgBox("Gimmick changed!")
        End If


    End Sub
    Public Function Gimmick_from_Boolean(ByVal w As WModel)
        If w.isFace Then
            Return "Face"
        Else
            Return "Heel"
        End If
    End Function

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim exchWModel As WModel = MData.SelectWrestler
        '  MsgBox()
        Dim valfrom, valto As Double
        Dim ind As Integer
        For i = 0 To MData.wrestlers.Length - 1
            If exchWModel.id_string = MData.wrestlers(i).id_string Then
                ind = i
            End If
        Next

        valfrom = WValue(actual_id)
        valto = WValue(ind)

        Dim ShallExchange As Boolean = False
        If valfrom < valto Then
            Dim ToPay As Integer = (valto - valfrom) * 10000
            Dim r As MsgBoxResult = MsgBox("The promotion didn't accept the deal. Though it will if we pay $" & MData.ToDotView(ToPay) & vbCrLf &
     "Shall we pay?", MsgBoxStyle.YesNo)
            If r = MsgBoxResult.Yes Then
                If MData.Currency.Money >= ToPay Then
                    MData.Currency.Money -= ToPay
                    MData.UpdateMoney()
                    'TODO: ADD PROMOTION MONEY EXCHANGE!!!
                    ShallExchange = True
                Else
                    MsgBox("We don't have enough money!")
                End If

            End If
        Else
            ShallExchange = True
        End If

        If ShallExchange Then
            MData.wrestlers(actual_id).Promotion = MData.wrestlers(ind).Promotion
            MData.wrestlers(ind).Promotion = Basic.Promotion
            MData.wrestlers(ind).stats(5) = Val(InputBox("Input the new Push:", "Push", MData.wrestlers(ind).stats(5)))
            Form1.Close()
            Form1.Show()
            Me.Close()
        End If

    End Sub

    Public Function WValue(ByVal id As Integer)
        Dim value As Double = 0
        For i = 0 To DefaultConstants.n_of_stats - 2
            value += MData.wrestlers(id).stats(i)
        Next
        value += MData.wrestlers(id).stats(0)
        value += MData.wrestlers(id).stats(1)

        Return value
    End Function

    Private Sub ExchangeWrestlers()

    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs)
        Dim ins As Integer = CInt(Val(InputBox("Value=?")))
        '    Valuer1.Value = ins
        '   Valuer1.ReCount(100)
    End Sub

    Private Sub StylePic_Click(sender As System.Object, e As System.EventArgs) Handles StylePic.Click

    End Sub

    Private Sub StylePic_MouseHover(sender As Object, e As System.EventArgs) Handles StylePic.MouseHover, StylePic.MouseEnter
        desc_label.Text = WStyles.description(selected_wrestler.style)
    End Sub

    Private Sub isFacePic_Click(sender As System.Object, e As System.EventArgs) Handles isFacePic.Click

    End Sub

    Private Sub p1Pic_Click(sender As System.Object, e As System.EventArgs) Handles p1Pic.Click

    End Sub
End Class