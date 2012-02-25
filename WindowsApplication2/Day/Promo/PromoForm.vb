Imports System.IO
Public Class PromoForm
    Dim number_of_wrestlers As Integer
    Dim wr() As WModel
    Dim PromoQuality As Integer
    Dim showLogo As Image = Basic.BackImage1 'My.Resources.bg_sd
    Private Sub PromoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        array_fill()
        PromoQuality = CInt(Count_Promo_Overall())
        fillDesign()
        If PromoQuality > 0 Then
            Label1.Text = "Promo Quality: " & PromoQuality
        Else
            Label1.Text = "Promo Failed!"
        End If
    End Sub
    Private Sub array_fill()
10:     Dim res As String = InputBox("Input the number of wrestlers:", "Number of wrestlers", "1")
        If res <> "" Then
            Dim n As Integer
            Try
                n = CInt(res)
                If (n >= 1) And (n <= 3) Then
                    number_of_wrestlers = n
                    res = ""
                Else
                    MsgBox("The value should be between 1 and 3")
                    GoTo 10
                End If
            Catch ex As Exception
                MsgBox("""" & res & """" & "is not a number")
                GoTo 10
            End Try
        Else
            '        MsgBox("!")
            Me.Close()
        End If
        res = ""
        ReDim wr(number_of_wrestlers - 1)
        ReDim wr(number_of_wrestlers - 1)
        For i = 0 To number_of_wrestlers - 1
            wr(i) = New WModel
        Next

        For i = 0 To number_of_wrestlers - 1
            Dim hap As Boolean = False

20:         hap = False

            'Dim res2 As String = InputBox("Input the name of the wrestler №" & i + 1 & ":", (i + 1).ToString & "/" & number_of_wrestlers, "Alberto del Rio")
            wr(i) = MData.SelectWrestler
            If wr(i) Is Nothing Then
                GoTo 10
            End If
            'If res2 <> "" Then
            '    For j = 0 To MData.wrestlers.Length - 1
            '        If MData.wrestlers(j).name.ToLower = res2.ToLower Then
            '            wr(i) = MData.wrestlers(j)
            '            hap = True
            '        End If
            '    Next
            '    If Not hap Then
            '        MsgBox("Wrestler " & res2 & " not found! Did you make a mistake?")
            '        res2 = ""
            '        GoTo 20
            '    End If
            'Else
            '    GoTo 10
            'End If
        Next

    End Sub
    Private Sub fillDesign()
        Header.Image = showLogo
        Dim wrimages(number_of_wrestlers - 1) As PictureBox
        Dim defw As Integer = 221
        Dim defh As Integer = Header.Height
        Dim otstup As Integer = CInt((Header.Width - (defw * number_of_wrestlers)) / 2) ' - (5 * number_of_wrestlers - 1)) / 2)
        For i = 0 To number_of_wrestlers - 1

            wrimages(i) = New PictureBox()

            With wrimages(i)
                .AutoSize = True
                .Parent = Header
                .BackColor = Color.Transparent
                .SizeMode = PictureBoxSizeMode.Zoom
                .Width = wrestler_image.Width
                .Height = wrestler_image.Height
                .BackgroundImageLayout = ImageLayout.Tile
                .Top = 0 'wrestler_image.Top 'templatepb.Top '+ Header.Top
                .Left = otstup + defw * i ' + templatepb.Left ' + Header.Left
                .Visible = True
                .SizeMode = PictureBoxSizeMode.Zoom
                .Height = wrestler_image.Height
                For j = 0 To MData.wrestlers.Length - 1
                    If MData.wrestlers(j).id_string = wr(i).id_string Then
                        Try
                            wrimages(i).Image = MData.imcontainer(j).bigimage
                        Catch ex As Exception
                            Try
                                wrimages(i).Image = My.Resources._9999
                            Catch ex2 As Exception
                                MsgBox(ex2.ToString)
                            End Try
                        End Try

                    End If
                Next
               
                '   .Top = Header.Height - .Height
                wrimages(i).BringToFront()
                Header.Controls.Add(wrimages(i))
                .Top = Header.Height - .Height
                wrimages(i).BringToFront()
                '    MsgBox()

            End With
        Next
    End Sub
    Private Function Count_Promo_Overall() As Double
        Dim res As Double = 0
        Dim add As Integer = 0
        For i = 0 To number_of_wrestlers - 1
            add = 0

            For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                If wr(i).perks(j) = 6 Then 'is FanFav
                    add += Form1.random(CInt(wr(i).stats(1) / 2), wr(i).stats(1) * 2)
                Else
                    add += Form1.random(CInt(wr(i).stats(1) / 2), wr(i).stats(1))
                End If
            Next

            For j = 0 To DefaultConstants.n_of_perks_at_once - 1
                If wr(i).perks(j) = 9 Then 'is Showman
                    add *= 2
                ElseIf wr(i).perks(j) = 7 Then 'is Drunkie
                    Return -100
                End If
            Next

            res += add
        Next
        res /= 2
        Return res
    End Function
    Private Sub fillwrestlers()
        number_of_wrestlers = 2
       
        wr(0) = MData.wrestlers(10)
        wr(1) = MData.wrestlers(5)
    End Sub

    Private Sub Header_Click(sender As System.Object, e As System.EventArgs) Handles Header.Click

    End Sub
End Class