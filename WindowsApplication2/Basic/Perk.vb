Public Class Perk

    'Public ids As Integer = 10
    Public Shared description() As String = {"None", "Trouble Maker", "Indie Legend", "Daredevil", "Perspective wrestler",
                                  "Worthless", "Fan Favourite", "Drunkie", "Straight-Edger", "Showman"}
    Public ids As Integer = description.Length - 1

    Public Function descr(ByVal id As Integer)
        'useless
        Return (description(id))
    End Function
End Class
