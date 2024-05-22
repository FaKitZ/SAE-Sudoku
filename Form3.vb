Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private joueurs As List(Of ModuleJoueur.JOUEUR)
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        ListBox1.Items.Clear()
        ComboBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()

        If ModuleJoueur.Joueurs IsNot Nothing Then
            joueurs = ModuleJoueur.Joueurs.ToList()
            For Each joueur As ModuleJoueur.JOUEUR In ModuleJoueur.Joueurs
                ListBox1.Items.Add(joueur.Nom)
                ComboBox1.Items.Add(joueur.Nom)
                ListBox3.Items.Add(joueur.NbGamePlay.ToString())
                ListBox2.Items.Add(joueur.BestTemps.ToString("mm\:ss"))
                ListBox4.Items.Add(joueur.CumulTimmer.ToString("hh\:mm\:ss"))
            Next
        End If
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        SyncSelections(ListBox1.SelectedIndex)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        SyncSelections(ComboBox1.SelectedIndex)

    End Sub

    Private Sub SyncSelections(index As Integer)
        If index >= 0 Then
            ListBox1.SelectedIndex = index
            ComboBox1.SelectedIndex = index
            ListBox2.SelectedIndex = index
            ListBox3.SelectedIndex = index
            ListBox4.SelectedIndex = index
        End If
    End Sub
    Private Sub ButtonTriPseudo_Click(sender As Object, e As EventArgs) Handles ButtonTriPseudo.Click
        If ModuleJoueur.Joueurs IsNot Nothing Then
            joueurs = joueurs.OrderBy(Function(j) j.Nom).ToList()
            ReloadListBoxes()
        End If

    End Sub

    Private Sub ButtonTriTimer_Click(sender As Object, e As EventArgs) Handles ButtonTriTimer.Click
        If ModuleJoueur.Joueurs IsNot Nothing Then
            joueurs = joueurs.OrderBy(Function(j) j.BestTemps).ToList()
            ReloadListBoxes()
        End If
    End Sub

    Private Sub ButtonStatsAvance_Click(sender As Object, e As EventArgs) Handles ButtonStatsAvance.Click
        MsgBox("Pseudo du joueur : " & ListBox1.Text & vbCrLf & "Meilleur temps : " & ListBox2.Text & vbCrLf & "Total Partie : " & ListBox3.Text & vbCrLf & "Heure de jeu :" & ListBox4.Text & MsgBoxStyle.Information)

    End Sub

    Private Sub ButtonRemiseà0_Click(sender As Object, e As EventArgs) Handles ButtonRemiseà0.Click
        If ModuleJoueur.Joueurs IsNot Nothing Then
            LoadData()
        End If

    End Sub
    Private Sub ReloadListBoxes()
        ListBox1.Items.Clear()
        ComboBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()

        For Each joueur As ModuleJoueur.JOUEUR In joueurs
            ListBox1.Items.Add(joueur.Nom)
            ComboBox1.Items.Add(joueur.Nom)
            ListBox3.Items.Add(joueur.NbGamePlay.ToString())
            ListBox2.Items.Add(joueur.BestTemps.ToString("mm\:ss"))
            ListBox4.Items.Add(joueur.CumulTimmer.ToString("hh\:mm\:ss"))
        Next
    End Sub

End Class