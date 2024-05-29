Public Class StatSudoku
    Private joueurs As List(Of ModuleJoueur.JOUEUR)
    Public IsDark As Boolean


    Private Sub StatSudoku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ModuleJoueur.LoadData()
        IsDark = MenuSudoku.IsDark
        If IsDark Then
            BackColor = MenuSudoku.darkBackground
            ButtonStatsAvance.ForeColor = MenuSudoku.highlight4
            ButtonStatsAvance.BackColor = MenuSudoku.darkAccent2
            Label1.ForeColor = MenuSudoku.highlight4
            Label2.ForeColor = MenuSudoku.highlight4
            nameLabel1.ForeColor = MenuSudoku.highlight4
            nbGameLabel3.ForeColor = MenuSudoku.highlight4
            TimeLabel2.ForeColor = MenuSudoku.highlight4
        End If
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
        MenuSudoku.Show()
    End Sub

    'Synchronise les listeBoxIndex par rapport aux bon joueur sélectionné
    Private Sub ListBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxName.SelectedIndexChanged
        SyncSelections(ListBoxName.SelectedIndex)
    End Sub
    'Synchronise les listeBoxIndex par rapport aux bon joueur sélectionné
    Private Sub ComboBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxName.SelectedIndexChanged
        SyncSelections(ComboBoxName.SelectedIndex)

    End Sub

    Private Sub SyncSelections(index As Integer)
        If index >= 0 Then
            ListBoxName.SelectedIndex = index
            ComboBoxName.SelectedIndex = index
            ListBoxBestTimer.SelectedIndex = index
            ListBoxTotalPartie.SelectedIndex = index
            ListBoxHeureDeJeu.SelectedIndex = index
        End If
    End Sub

    Private Sub ButtonTriPseudo_Click(sender As Object, e As EventArgs) Handles ButtonTriPseudo.Click
        ModuleJoueur.TriPseudo()
    End Sub

    Private Sub ButtonTriTimer_Click(sender As Object, e As EventArgs) Handles ButtonTriTimer.Click
        ModuleJoueur.TriBestTimer()
    End Sub

    Private Sub ButtonStatsAvance_Click(sender As Object, e As EventArgs) Handles ButtonStatsAvance.Click
        MsgBox("Pseudo du joueur : " & ListBoxName.Text & vbCrLf & "Meilleur temps : " & ListBoxBestTimer.Text & vbCrLf & "Total Partie : " & ListBoxTotalPartie.Text & vbCrLf & "Heure de jeu :" & ListBoxHeureDeJeu.Text & MsgBoxStyle.Information)
    End Sub

    Public Sub ApplyLightTheme()
        Me.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = DefaultForeColor
            End If
        Next
    End Sub
End Class