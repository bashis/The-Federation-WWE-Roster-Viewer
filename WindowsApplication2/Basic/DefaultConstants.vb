Imports System.IO
Public Class DefaultConstants
    Public Shared pth As String = Application.StartupPath & "\"
    Public Shared perks_path = Path.Combine(pth, "logos", "perks\")
    Public Shared styles_path = Path.Combine(pth, "logos", "styles\")
    Public Shared gimmick_path = Path.Combine(pth, "logos", "gimmick\")
    '-----
    Public Shared n_of_promotions As Integer = 4 'RAW, Smackdown
    Public Shared n_of_titles As Integer = 6
    Public Shared n_of_stats As Integer = 6 'PUSH INCLUDED!!!
    Public Shared n_of_perks As Integer = 10
    Public Shared n_of_perks_at_once As Integer = 1
    Public Shared n_of_items_in_a_match As Integer = 5

    Public Structure idview
        Dim len As Integer
        Dim mask As Integer
    End Structure
    Public Shared id_def As idview

End Class
