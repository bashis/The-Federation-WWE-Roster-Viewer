Public Class WStyles
    'Public ids As Integer = 10
    Public Shared description() As String = {
"Basic", "Technical", "Highflyer", "Brawler", "Giant", "Powerhouse", "Hardcore"
}
    Public ids As Integer = description.Length - 1

    Public Function descr(ByVal id As Integer)
        'useless
        Return (description(id))
    End Function
End Class
