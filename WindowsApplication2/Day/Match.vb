Public Class Match
    Public number_of_wrestlers As Integer
    Public number_of_teams As Integer
    Public wrestlers() As WModel
    Public isTeamMatch As Boolean
    Public BelongsToTeam() As Integer
    Public teams() As Integer
    Public MatchType As MatchType
    Public items(DefaultConstants.n_of_items_in_a_match) As Items
    Public isPPV As Boolean
    Public isForcedWin As Boolean
    Public forcedWinnerIndex As Integer
    Public Quality, Popularity, Danger, Cost As Double
    Public WinnerName As String
    'Public Name As String

    Public Sub rebuild()
        If isTeamMatch Then
            ReDim teams(number_of_wrestlers - 1)

        End If

    End Sub

    Public Function Name()
        Name = ""
        If number_of_wrestlers <= 3 Then
            If isTeamMatch Then
                Dim team(number_of_teams) As String
                For i = 0 To number_of_wrestlers - 1
                    team(teams(i)) += "& " & wrestlers(i).name
                Next

                For i = 0 To number_of_teams
                    team(i) = team(i).Substring(2)
                    Name += " vs. " & team(i)
                Next
                Name = Name.Substring(5)
            Else
                For i = 0 To number_of_wrestlers - 1
                    Name += " vs. " & wrestlers(i).name
                Next
                Name = Name.Substring(5)
            End If
        Else
            Name = number_of_wrestlers.ToString & " Men " & MatchType.descriptions(MatchType.id)
        End If
    End Function
End Class
