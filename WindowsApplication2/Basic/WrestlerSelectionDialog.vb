Imports System.IO
Public Class WrestlerSelectionDialog
    Public arr() As WModel
    Public noe As Integer
    Public curind As Integer
    Dim between As Integer = 10
    Public current_selection As WModel

    Private Sub WrestlerSelectionDialog_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, Button1.KeyDown, Button2.KeyDown
        If e.KeyData = Keys.W Then
            Button2.PerformClick()
        ElseIf e.KeyData = Keys.S Then
            Button1.PerformClick()
        End If
    End Sub
    Private Sub WrestlerSelectionDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PictureBox1.Top = PictureBox2.Top - between - PictureBox1.Height
        PictureBox3.Top = PictureBox2.Bottom + between

        defaultcoordinates(0, 0) = PictureBox1.Left
        defaultcoordinates(0, 1) = PictureBox1.Top
        defaultcoordinates(1, 0) = PictureBox2.Left
        defaultcoordinates(1, 1) = PictureBox2.Top
        defaultcoordinates(2, 0) = PictureBox3.Left
        defaultcoordinates(2, 1) = PictureBox3.Top

        CheckBox1.Checked = True
        NumericUpDown1.Value = 20
        CheckBox1.Visible = False
        NumericUpDown1.Visible = False
        Label3.Visible = False
    End Sub

    Public Sub autofill(ByVal source As Object)
       
        arr = source
        ReDim labs(defclass.n_of_stats - 1, 1)
        For i = 0 To defclass.n_of_stats - 1
            For j = 0 To 1
                labs(i, j) = New Label
                Panel1.Controls.Add(labs(i, j))
            Next
        Next
        curind = 0
        current_selection = arr(curind)
        curindch(0)
    End Sub
    Dim labs(,) As Label
    Public statclass As Object
    Public defclass As Object
    Private Sub normalize()
        wname.Text = arr(curind).name
        wstyle.Text = WStyles.description(arr(curind).style)

        Label2.Top = Label1.Bottom + 3

        wname.Left = Label1.Right + 3
        wname.Top = Label1.Top
        wstyle.Left = Label2.Right + 3
        wstyle.Top = Label2.Top

        For i = 0 To defclass.n_of_stats - 1

            With labs(i, 0)
                .Text = statclass.description(i) & ":"
                .AutoSize = True
                .Left = Label2.Right - .Width
                .Font = Label1.Font
                If i > 0 Then
                    .Top = labs(i - 1, 0).Bottom + 3
                Else
                    .Top = Label2.Bottom + 3
                End If
            End With
            With labs(i, 1)
                .Font = Label1.Font
                .Text = arr(curind).stats(i)
                .AutoSize = True
                .Left = labs(i, 0).Right + 3
                .Top = labs(i, 0).Top
            End With
        Next


    End Sub
    Private Function getpicfromidstring(ByVal w As WModel)
        Dim pic As Image = My.Resources._99991
        For i = 0 To arr.Length - 1
            If MData.imcontainer(i).idstring = w.id_string Then
                Try
                    pic = MData.imcontainer(i).smallimage 'Image.FromFile(Path.Combine(Form1.pth, "renamed", w.id_string & ".jpg"))
                Catch ex As Exception
                    Try
                        pic = My.Resources._99991
                    Catch ex2 As Exception
                    End Try
                End Try
            End If
        Next
        Return pic
    End Function
    Dim ind As Integer
    Public Sub curindch(ByVal index As Integer)
        curind += index
        ind = index

        If CheckBox1.Checked Then
            height_changer = NumericUpDown1.Value
            defheightchanger = height_changer
            startmoving(index) 'Starting Move Animation. Doesn't work perfect for now. Need something to change.
        End If

        If arr.Length = 1 Then
            PictureBox1.Image = Nothing
            PictureBox2.Image = getpicfromidstring(arr(curind))
            PictureBox3.Image = Nothing
        ElseIf curind < 0 Then
            curind = arr.Length - 1
            PictureBox1.Image = getpicfromidstring(arr(curind - 1))
            PictureBox2.Image = getpicfromidstring(arr(curind))
            PictureBox3.Image = getpicfromidstring(arr(0))
        ElseIf curind > arr.Length - 1 Then
            curind = 0
            PictureBox1.Image = getpicfromidstring(arr(arr.Length - 1))
            PictureBox2.Image = getpicfromidstring(arr(curind))
            PictureBox3.Image = getpicfromidstring(arr(curind + 1))

        ElseIf curind = arr.Length - 1 Then
            PictureBox1.Image = getpicfromidstring(arr(curind - 1))
            PictureBox2.Image = getpicfromidstring(arr(curind))
            PictureBox3.Image = getpicfromidstring(arr(0))
        ElseIf curind = 0 Then
            PictureBox1.Image = getpicfromidstring(arr(arr.Length - 1))
            PictureBox2.Image = getpicfromidstring(arr(curind))
            PictureBox3.Image = getpicfromidstring(arr(curind + 1))
        Else
            PictureBox1.Image = getpicfromidstring(arr(curind - 1))
            PictureBox2.Image = getpicfromidstring(arr(curind))
            PictureBox3.Image = getpicfromidstring(arr(curind + 1))
        End If
        current_selection = arr(curind)
        normalize()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        curindch(-1)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        curindch(1)
    End Sub
    Public Function selected_wrestler() As WModel
        Return (arr(curind))
    End Function
    Dim defaultcoordinates(2, 1) As Integer
    Dim temppb As PictureBox = New PictureBox

    Public Sub startmoving(ByVal index As Integer)
        height_changer = defheightchanger
        If index = -1 Then
            ' MsgBox("")
            ' height_changer = 5
            With temppb
                .Image = PictureBox3.Image
                .Left = PictureBox3.Left
                .Top = PictureBox3.Top
                .Height = PictureBox3.Height
                .Width = PictureBox3.Width
                .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                .SizeMode = PictureBoxSizeMode.AutoSize
                .BringToFront()
                If Not Me.Controls.Contains(temppb) Then
                    Me.Controls.Add(temppb)
                End If
            End With
            PictureBox1.Visible = False
            PictureBox1.Left = defaultcoordinates(0, 0)
            PictureBox1.Top = defaultcoordinates(0, 0) - PictureBox1.Height - between * 1.74 'No idea why *1.74,  it just works correct this way...
            PictureBox1.Visible = True

            PictureBox2.Visible = False
            PictureBox2.Left = defaultcoordinates(0, 0)
            PictureBox2.Top = defaultcoordinates(0, 1)
            PictureBox2.Visible = True

            PictureBox3.Visible = False
            PictureBox3.Left = defaultcoordinates(1, 0)
            PictureBox3.Top = defaultcoordinates(1, 1)
            PictureBox3.Visible = True

            temppb.Visible = False
            temppb.Left = defaultcoordinates(2, 0)
            temppb.Top = defaultcoordinates(2, 1)
            temppb.Visible = True



            ' timercntlimit = 20
            timercnt = 0
            Timer1.Start()
        ElseIf index = 1 Then
            height_changer = -1 * height_changer
            With temppb
                .Image = PictureBox1.Image
                .Left = PictureBox1.Left
                .Top = PictureBox1.Top
                .Height = PictureBox1.Height
                .Width = PictureBox1.Width
                .BringToFront()
                If Not Me.Controls.Contains(temppb) Then
                    Me.Controls.Add(temppb)
                End If
            End With

            PictureBox1.Visible = False
            PictureBox1.Left = defaultcoordinates(1, 0)
            PictureBox1.Top = defaultcoordinates(1, 1)
            PictureBox1.Visible = True

            PictureBox2.Visible = False
            PictureBox2.Left = defaultcoordinates(2, 0)
            PictureBox2.Top = defaultcoordinates(2, 1)
            PictureBox2.Visible = True

            PictureBox3.Visible = False
            PictureBox3.Left = defaultcoordinates(2, 0)
            PictureBox3.Top = defaultcoordinates(2, 1) + PictureBox1.Height + between
            PictureBox3.Visible = True

            temppb.Visible = False
            temppb.Left = defaultcoordinates(0, 0)
            temppb.Top = defaultcoordinates(0, 1)
            temppb.Visible = True

            timercnt = 0
            Timer1.Start()

        End If
    End Sub
    Dim height_changer As Integer = 20
    Dim defheightchanger = height_changer
    Private Sub movepics()

        PictureBox1.Top += height_changer
        PictureBox2.Top += height_changer
        PictureBox3.Top += height_changer
        temppb.Top += height_changer
    End Sub
    Dim timercnt, timercntlimit As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        movepics()
        If ind = -1 Then
            If PictureBox1.Top >= defaultcoordinates(0, 1) Then

                PictureBox1.Left = defaultcoordinates(0, 0)
                PictureBox1.Top = defaultcoordinates(0, 1)
                PictureBox2.Left = defaultcoordinates(1, 0)
                PictureBox2.Top = defaultcoordinates(1, 1)
                PictureBox3.Left = defaultcoordinates(2, 0)
                PictureBox3.Top = defaultcoordinates(2, 1)
                temppb.Visible = False
                Timer1.Stop()
            End If
        ElseIf ind = 1 Then
            If PictureBox1.Top <= defaultcoordinates(0, 1) Then
                PictureBox1.Left = defaultcoordinates(0, 0)
                PictureBox1.Top = defaultcoordinates(0, 1)
                PictureBox2.Left = defaultcoordinates(1, 0)
                PictureBox2.Top = defaultcoordinates(1, 1)
                PictureBox3.Left = defaultcoordinates(2, 0)
                PictureBox3.Top = defaultcoordinates(2, 1)
                temppb.Visible = False
                Timer1.Stop()
            End If
        End If

    End Sub

    Private Sub WrestlerSelectionDialog_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

    End Sub

    Private Sub WrestlerSelectionDialog_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            Button2.PerformClick()
        ElseIf e.Delta < 0 Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            NumericUpDown1.Enabled = True
        Else
            NumericUpDown1.Enabled = False
        End If
    End Sub
    Private Sub Panel1_Resize(sender As Object, e As System.EventArgs) Handles Panel1.Resize
        Button1.Top = Panel1.Bottom + 5
    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDown1.KeyDown
        e.Handled = True
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class
