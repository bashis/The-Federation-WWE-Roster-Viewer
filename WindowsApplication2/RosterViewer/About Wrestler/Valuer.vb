Public Class Valuer
    Dim pb() As PictureBox
    Public Value As Integer
    Public WillWidth As Integer
    Dim n As Integer = 256
    Private Sub Valuer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim h1 As Integer = PictureBox1.Height
        Dim w1 As Integer = 2 'PictureBox1.Width
        Dim dh As Integer = 5
        Dim sep As Integer = 0
        Dim n As Integer = 256
        'PictureBox1.Width = n * (sep + w1)
        'PictureBox1.Height = n * dh + w1

        Dim defcX As Integer = 0
        Dim defcY As Integer = 0 'PictureBox1.Height
        PictureBox1.Visible = False
        ReDim pb(n)
        For i = 0 To n - 1
            pb(i) = New PictureBox
            With pb(i)
                .Width = PictureBox1.Width
                .Height = PictureBox1.Height
                ' .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                .Left = PictureBox1.Left + i * (w1 + sep)
                .Top = PictureBox1.Top
                .BackColor = Color.FromArgb(255, 255 - i, 0)
            End With
            Panel1.Controls.Add(pb(i))
        Next
        WillWidth = Me.Width

        'For i = 0 To n - 1
            'Dim p As Point
            'p.X = defcX + i * (sep + w1)
            '  PictureBox1.CreateGraphics.DrawRectangle(Pens.Black, p.X, defcY - h1 + i * dh, w1, h1 + i * dh)
            'Next
            'MsgBox(Me.Height & vbCrLf & Me.Width)
    End Sub

    Public Sub ReCount(ByVal Ending As Integer)
        If Ending < Value Then
            MsgBox("Ending<Value! Error!")

        End If
        Dim part As Double = 256 * Value / Ending
        Dim intpart As Integer = CInt(part) - 1
        For i = 0 To intpart
            Try
                pb(i).BackColor = Color.FromArgb(255, 255 - i, 0)
            Catch ex As Exception
                '  MsgBox("Error on cycle: i=" & i & vbCrLf & ex.Message)
            End Try

        Next
        For i = n - 1 To intpart + 1 Step -1
            pb(i).BackColor = Color.Transparent
        Next
    End Sub
End Class
