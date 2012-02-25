Public Class Basic
    Public Shared Promotion As Integer
    Public Shared PromotionName As String
    Public Shared Color1 As Color
    Public Shared BackImage1 As Image
    Public Shared P_Names() As String = {"Free Agent", "RAW", "SmackDown", "Impact Wrestling"}
    Public Shared Colors() As Color = {Color.DarkGray, Color.LightCoral, Color.RoyalBlue, Color.DodgerBlue}
    Public Shared Colors2() As Color = {Color.Black, Color.Black, Color.Black, Color.Black}
    Public Shared P_Images1() As Image = {My.Resources.bg_free, My.Resources.bg_raw, My.Resources.bg_sd, My.Resources.bg_tna}
    Public Shared P_ImagesBG() As Image = {My.Resources.background2, My.Resources.background2, My.Resources.background2, My.Resources.SbgTNA}
    Public Shared Sub recount()
        PromotionName = P_Names(Promotion)
        Color1 = Colors(Promotion)
        BackImage1 = P_Images1(Promotion)
    End Sub

End Class
