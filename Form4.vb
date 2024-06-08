Public Class ParametreSudoku

    Dim input As String
    Dim minute As Integer
    Dim timeInterval As TimeSpan
    Dim difficulte As Integer = 71 'difficulté par défaut (correspond au nombre de case vide à remplir)
    Dim SelectedMap As String
    Private isDarkMode As Boolean = False
    Private CurrentBackground As String
    Private CouleurSudoku As New CouleurSudoku

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        If isDarkMode = False Then
        End If
        Me.Hide()
        MenuSudoku.Show()
    End Sub

    'méthode qui met à jours le timer en fonction du choix du joueur
    Private Sub ChangeTimerButton_Click(sender As Object, e As EventArgs) Handles ChangeTimerButton.Click
        input = InputBox("Combien de temps voulez-vous mettre (en minutes) :")
        If IsNumeric(input) Then
            minute = CInt(input)
            timeInterval = TimeSpan.FromMinutes(minute)
            JeuSudoku.SetTimerInterval(minute)
            MsgBox("L'intervalle du timer a été modifié à " & minute & " minute(s).")
        Else
            MsgBox("Veuillez entrer un nombre valide.")
        End If
    End Sub

    'RadioButton qui applique la difficulté choisi par le joueur
    Private Sub RadioButtonFacile_Click(sender As Object, e As EventArgs) Handles RadioButtonFacile.Click
        If RadioButtonFacile.Checked Then
            difficulte = 81 - 65
            JeuSudoku.ChangeDifficulte(difficulte)
        End If
    End Sub
    'RadioButton qui applique la difficulté choisi par le joueur
    Private Sub RadioButtonMoyen_Click(sender As Object, e As EventArgs) Handles RadioButtonMoyen.Click
        If RadioButtonMoyen.Checked Then
            difficulte = 81 - 55
            JeuSudoku.ChangeDifficulte(difficulte)
        End If
    End Sub
    'RadioButton qui applique la difficulté choisi par le joueur
    Private Sub RadioButtonDifficile_Click(sender As Object, e As EventArgs) Handles RadioButtonDifficile.Click
        If RadioButtonDifficile.Checked Then
            difficulte = 81 - 40
            JeuSudoku.ChangeDifficulte(difficulte)
        End If
    End Sub
    'RadioButton qui applique la difficulté choisi par le joueur
    Private Sub RadioButtonHard_Click(sender As Object, e As EventArgs) Handles RadioButtonHard.Click
        If RadioButtonHard.Checked Then
            difficulte = 81 - 20
            JeuSudoku.ChangeDifficulte(difficulte)
        End If
    End Sub

    'RadioButton qui applique la thème choisi par le joueur
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            SelectedMap = "RIVER"
            CouleurSudoku.ApplyMapChanges(SelectedMap)
        End If
    End Sub
    'RadioButton qui applique la thème choisi par le joueur
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            SelectedMap = "SNOW"
            CouleurSudoku.ApplyMapChanges(SelectedMap)
        End If
    End Sub

    'RadioButton qui applique la thème choisi par le joueur
    Private Sub RadioButtonMapDefaut_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMapDefaut.CheckedChanged
        If RadioButtonMapDefaut.Checked Then
            SelectedMap = "DEFAUT"
            CouleurSudoku.ApplyMapChanges(SelectedMap)
        End If
    End Sub

    'Button DarkMode
    Private Sub ButtonDarkMode_Click(sender As Object, e As EventArgs) Handles ButtonDarkMode.Click
        If isDarkMode = True Then
            isDarkMode = False
        Else
            isDarkMode = True
        End If

        If isDarkMode Then
            ButtonDarkMode.BackgroundImage = My.Resources.Lightmod
        Else
            ButtonDarkMode.BackgroundImage = My.Resources.Darkmod
        End If

        JeuSudoku.ChangeDarkMod(isDarkMode)
        UpdateMenu()
    End Sub

    'méthode qui change le theme si le darkmode est activé
    Private Sub UpdateMenu()
        If isDarkMode Then
            CouleurSudoku.SetDarkParametre()
            CouleurSudoku.SetDarkMenu()
            CouleurSudoku.SetDarkStat()
        Else
            CouleurSudoku.ApplyLightThemeParametre()
            CouleurSudoku.ApplyLightThemeJeu()
            CouleurSudoku.ApplyLightThemeMenu()
            CouleurSudoku.ApplyLightThemeStats()
        End If
    End Sub
    'Méthode qui return les couleur par default
    Public Function DefaultcolorFore() As Color
        Return DefaultForeColor
    End Function
    'Méthode qui return les couleur par default
    Public Function DefaultcolorBack() As Color
        Return DefaultBackColor
    End Function

    'Bouton qui fait choisir au joueurs le choix d'emplacement de sa sauvegarde
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonCheminDossier.Click
        Folderbrowser()
    End Sub
    'Bouton qui fait choisir au joueurs l'emplacement de sa sauvegarde pour la charger
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonCheminChargerSave.Click
        Folderbrowser()
        ModuleJoueur.ChargerJoueursDepuisFichier("joueurs.txt")
    End Sub

    'méthode qui met a jours le chemin de la save ou charge du save en fonctions du joueurs
    Public Sub Folderbrowser()
        Using dossierDialog As New FolderBrowserDialog()
            If dossierDialog.ShowDialog() = DialogResult.OK Then
                ModuleJoueur.CheminDossier = dossierDialog.SelectedPath
                MsgBox("Chemin de dossier sélectionné: " & ModuleJoueur.CheminDossier)
            End If
        End Using
    End Sub

End Class