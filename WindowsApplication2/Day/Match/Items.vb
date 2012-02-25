Public Class Items
    Public Id As Integer
    Public Name As String = ItemsConstants.Names(Id)
    Public Cost As Integer = ItemsConstants.Cost(Id)
    Public PBonus As Integer = ItemsConstants.PBonuses(Id)
    Public Danger As Integer = ItemsConstants.Danger(Id)
    Public Sub recount()

        Name = ItemsConstants.Names(Id)
        Cost = ItemsConstants.Cost(Id)
        PBonus = ItemsConstants.PBonuses(Id)
        Danger = ItemsConstants.Danger(Id)
    End Sub
End Class
