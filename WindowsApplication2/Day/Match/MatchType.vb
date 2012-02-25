Public Class MatchType
    Public id As Integer
    Public Shared descriptions() As String = {"Normal Match", "No DQ Match", "Over The Top Rope"}
    Public Shared Length As Integer = descriptions.Length
    Shared isExtremearray() As Boolean = {False, True, False}
    Shared isBattleRoyalarray() As Boolean = {False, False, True}
    Public value = descriptions(id)
    Public isBattleRoyal As Boolean = isBattleRoyalarray(id)
    Public isExtreme As Boolean = isExtremearray(id)
    Public Sub recount()
        value = descriptions(id)
        isExtreme = isExtremearray(id)
        isBattleRoyal = isBattleRoyalarray(id)
    End Sub
End Class
