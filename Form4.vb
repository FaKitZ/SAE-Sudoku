﻿Public Class ParametreSudoku
    Dim input As String
    Dim minute As Integer
    Dim timeInterval As TimeSpan
    Dim difficulte As Integer = 71
    Dim SelectedMap As String
    Private isDarkMode As Boolean = False

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
        MenuSudoku.Show()
    End Sub

    Private Sub ParametreSudoku_Load(sender As Object, e As EventArgs) Handles Me.Load
        isDarkMode = MenuSudoku.IsDark
        If isDarkMode Then
            Button1.BackgroundImage = My.Resources.Lightmod
            SetDark()
        Else
            ApplyLightTheme()
        End If
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
            ApplyMapChanges()
        End If
    End Sub
    'RadioButton qui applique la thème choisi par le joueur
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            SelectedMap = "SNOW"
            ApplyMapChanges()
        End If
    End Sub
    'RadioButton qui applique la thème choisi par le joueur
    Private Sub ApplyMapChanges()
        JeuSudoku.ChangeMap(SelectedMap)
    End Sub
    'Button DarkMode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isDarkMode = Not isDarkMode
        If isDarkMode Then
            Button1.BackgroundImage = My.Resources.Lightmod
        Else
            Button1.BackgroundImage = My.Resources.Darkmod
        End If
        UpdateMenu()
        MenuSudoku.IsDark = Not MenuSudoku.IsDark

    End Sub

    Private Sub UpdateMenu()
        If isDarkMode Then
            MenuSudoku.BackColor = MenuSudoku.darkBackground
            MenuSudoku.Label1.ForeColor = MenuSudoku.highlight4
            MenuSudoku.nameLabel.ForeColor = MenuSudoku.highlight4
            MenuSudoku.nameComboBox1.BackColor = MenuSudoku.darkAccent1
            MenuSudoku.nameComboBox1.ForeColor = MenuSudoku.highlight4
            MenuSudoku.playButton.ForeColor = MenuSudoku.highlight4
            MenuSudoku.ScoreButton1.ForeColor = MenuSudoku.highlight4
            MenuSudoku.ButtonParametre.ForeColor = MenuSudoku.highlight4
            MenuSudoku.leaveBoutton.ForeColor = MenuSudoku.highlight4
            MenuSudoku.playButton.BackColor = MenuSudoku.darkAccent2
            MenuSudoku.ScoreButton1.BackColor = MenuSudoku.darkAccent2
            MenuSudoku.ButtonParametre.BackColor = MenuSudoku.darkAccent2
            MenuSudoku.leaveBoutton.BackColor = MenuSudoku.darkAccent2
            SetDark()
        Else
            ApplyLightTheme()
            JeuSudoku.ApplyLightTheme()
            MenuSudoku.ApplyLightTheme()
            StatSudoku.ApplyLightTheme()
        End If
    End Sub

    Private Sub SetDark()
        Me.BackColor = MenuSudoku.darkBackground
        Me.Label1.ForeColor = MenuSudoku.highlight4
        Me.Label3.ForeColor = MenuSudoku.highlight4
        Me.Label4.ForeColor = MenuSudoku.highlight4
        Me.Label5.ForeColor = MenuSudoku.highlight4
        Me.ChangeTimerButton.BackColor = MenuSudoku.darkAccent2
        Me.LeaveButton.BackColor = MenuSudoku.darkAccent2
        Me.Button1.BackColor = MenuSudoku.darkAccent2
        Me.LeaveButton.ForeColor = MenuSudoku.highlight4
        Me.RadioButtonFacile.ForeColor = MenuSudoku.highlight4
        Me.RadioButtonMoyen.ForeColor = MenuSudoku.highlight4
        Me.RadioButtonDifficile.ForeColor = MenuSudoku.highlight4
        Me.RadioButton4.ForeColor = MenuSudoku.highlight4
        Me.RadioButton5.ForeColor = MenuSudoku.highlight4
    End Sub
    Public Sub ApplyLightTheme()
        Me.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = DefaultForeColor
            ElseIf TypeOf ctrl Is Button Then
                ctrl.BackColor = DefaultBackColor
                ctrl.ForeColor = DefaultForeColor
            End If

        Next
        Me.RadioButtonFacile.ForeColor = DefaultForeColor
        Me.RadioButtonMoyen.ForeColor = DefaultForeColor
        Me.RadioButtonDifficile.ForeColor = DefaultForeColor
        Me.RadioButton4.ForeColor = DefaultForeColor
        Me.RadioButton5.ForeColor = DefaultForeColor
    End Sub

    'Bouton qui fait choisir au joueurs le choix d'emplacement de sa sauvegarde
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Folderbrowser()
    End Sub
    'Bouton qui fait choisir au joueurs l'emplacement de sa sauvegarde pour la charger
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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