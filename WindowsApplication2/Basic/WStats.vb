Public Class WStats

    Public Shared description() As String = {"Wrestling", "Microphone",
                                     "Calmness", "Insanity", "Fan-Base", "Push"}
    Public ids As Integer = description.Length - 1

    Public Function descr(ByVal id As Integer)
        'useless
        Return (description(id))
    End Function
End Class
