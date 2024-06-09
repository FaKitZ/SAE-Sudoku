Public Class StatSudoku
    Private joueurs As List(Of ModuleJoueur.JOUEUR)
    Private CurrentBackground As String


    Private Sub StatSudoku_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LoadStats()
        ModuleJoueur.LoadData()
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Hide()
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

    'Methode qui synchronise les indexe de listBox
    Private Sub SyncSelections(index As Integer)
        If index >= 0 Then
            ListBoxName.SelectedIndex = index
            ComboBoxName.SelectedIndex = index
            ListBoxBestTimer.SelectedIndex = index
            ListBoxTotalPartie.SelectedIndex = index
            ListBoxHeureDeJeu.SelectedIndex = index
        End If
    End Sub

    'Methode qui appelle la methode pour trié les pseudo dans la listBox
    Private Sub ButtonTriPseudo_Click(sender As Object, e As EventArgs) Handles ButtonTriPseudo.Click
        ModuleJoueur.TriPseudo()
    End Sub
    'Methode qui appelle la methode pour trié les best timer dans la listBox
    Private Sub ButtonTriTimer_Click(sender As Object, e As EventArgs) Handles ButtonTriTimer.Click
        ModuleJoueur.TriBestTimer()
    End Sub

    'Methode qui fait apparaitre une message box avec les infos du joueurs sélectionné
    Private Sub ButtonStatsAvance_Click(sender As Object, e As EventArgs) Handles ButtonStatsAvance.Click
        MsgBox("Pseudo du joueur : " & ListBoxName.Text & vbCrLf & "Meilleur temps : " & ListBoxBestTimer.Text & vbCrLf & "Total Partie : " & ListBoxTotalPartie.Text & vbCrLf & "Heure de jeu :" & ListBoxHeureDeJeu.Text & MsgBoxStyle.Information)
    End Sub
End Class