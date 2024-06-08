Public Class ParametreSudoku
    Dim input As String
    Dim minute As Integer
    Dim timeInterval As TimeSpan
    Dim difficulte As Integer = 71 'difficulté par défaut (correspond au nombre de case vide à remplir)
    Dim SelectedMap As String
    Private isDarkMode As Boolean = False
    Private CurrentBackground As String

    'couleurs
    Public color1 As Color = Color.FromArgb(255, 165, 0)   ' Orange (feuilles d'automne)
    Public color2 As Color = Color.FromArgb(255, 223, 0)   ' Jaune (feuilles d'automne)
    Public color3 As Color = Color.FromArgb(205, 92, 92)   ' Rouge adouci (feuilles d'automne)
    Public color4 As Color = Color.FromArgb(0, 191, 255)
    Private darkBackground As Color = Color.FromArgb(18, 18, 18)  ' Fond sombre
    Private darkAccent1 As Color = Color.FromArgb(48, 48, 48)     ' Accent sombre 1
    Private darkAccent2 As Color = Color.FromArgb(72, 72, 72)     ' Accent sombre 2
    Private darkAccent3 As Color = Color.FromArgb(96, 96, 96)     ' Accent sombre 3
    Private highlight1 As Color = Color.FromArgb(255, 140, 0)     ' Orange vif pour les points de mise en évidence
    Private highlight2 As Color = Color.FromArgb(255, 215, 0)     ' Jaune doré pour les points de mise en évidence
    Private highlight3 As Color = Color.FromArgb(205, 92, 92)     ' Rouge adouci pour les points de mise en évidence
    Private highlight4 As Color = Color.FromArgb(0, 206, 209)     ' Turquoise pour les points de mise en évidence

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        If isDarkMode = False Then
        End If
        Me.Hide()
        MenuSudoku.Show()
    End Sub

    Private Sub ParametreSudoku_Load(sender As Object, e As EventArgs) Handles Me.Load

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
            ApplyMapChanges(SelectedMap)
        End If
    End Sub
    'RadioButton qui applique la thème choisi par le joueur
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            SelectedMap = "SNOW"
            ApplyMapChanges(SelectedMap)
        End If
    End Sub

    Private Sub RadioButtonMapDefaut_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMapDefaut.CheckedChanged
        If RadioButtonMapDefaut.Checked Then
            SelectedMap = "DEFAUT"
            ApplyMapChanges(SelectedMap)
        End If
    End Sub

    'RadioButton qui applique la thème choisi par le joueur
    Private Sub ApplyMapChanges(SelectedMap)
        JeuSudoku.ChangeMap(SelectedMap)
        MenuSudoku.ChangeMap(SelectedMap)
        StatSudoku.ChangeMap(SelectedMap)
        Me.ChangeMap(SelectedMap)
    End Sub

    'Button DarkMode
    Private Sub ButtonDarkMode_Click(sender As Object, e As EventArgs) Handles ButtonDarkMode.Click
        If isDarkMode = True Then
            isDarkMode = False
        Else
            isDarkMode = True
        End If

        JeuSudoku.ChangeDarkMod(isDarkMode)
        If isDarkMode Then
            ButtonDarkMode.BackgroundImage = My.Resources.Lightmod
        Else
            ButtonDarkMode.BackgroundImage = My.Resources.Darkmod
        End If
        UpdateMenu()
    End Sub

    'méthode qui change le theme si le darkmode est activé
    Private Sub UpdateMenu()
        If isDarkMode Then
            SetDarkParametre()
            SetDarkMenu()
            SetDarkStat()
        Else
            ApplyLightTheme()
            JeuSudoku.ApplyLightTheme()
            MenuSudoku.ApplyLightTheme()
            StatSudoku.ApplyLightTheme()
        End If
    End Sub

    'Applique le darkMode sur le formulaire Parametre
    Private Sub SetDarkParametre()
        Me.BackColor = darkBackground
        Me.Label1.ForeColor = highlight4
        Me.Label2.ForeColor = highlight4
        Me.Label5.ForeColor = highlight4
        Me.GroupBoxDifficulte.ForeColor = highlight4
        Me.GroupBoxMap.ForeColor = highlight4
        Me.ChangeTimerButton.BackColor = darkAccent2
        Me.LeaveButton.BackColor = darkAccent2
        Me.ButtonDarkMode.BackColor = darkAccent2
        Me.LeaveButton.ForeColor = highlight4
        Me.RadioButtonFacile.ForeColor = highlight4
        Me.RadioButtonMoyen.ForeColor = highlight4
        Me.RadioButtonDifficile.ForeColor = highlight4
        Me.RadioButton4.ForeColor = highlight4
        Me.RadioButton5.ForeColor = highlight4
        Me.RadioButtonHard.ForeColor = highlight4
        Me.RadioButtonMapDefaut.ForeColor = highlight4

    End Sub
    'Applique le darkMode sur le formulaire du menu du jeu
    Private Sub SetDarkMenu()
        MenuSudoku.BackColor = darkBackground
        MenuSudoku.Label1.ForeColor = highlight4
        MenuSudoku.nameLabel.ForeColor = highlight4
        MenuSudoku.nameComboBox1.BackColor = darkAccent1
        MenuSudoku.nameComboBox1.ForeColor = highlight4
        MenuSudoku.playButton.ForeColor = highlight4
        MenuSudoku.ScoreButton1.ForeColor = highlight4
        MenuSudoku.ButtonParametre.ForeColor = highlight4
        MenuSudoku.leaveBoutton.ForeColor = highlight4
        MenuSudoku.playButton.BackColor = darkAccent2
        MenuSudoku.ScoreButton1.BackColor = darkAccent2
        MenuSudoku.ButtonParametre.BackColor = darkAccent2
        MenuSudoku.leaveBoutton.BackColor = darkAccent2
    End Sub

    Public Sub SetDarkjeu()
        For Each ctrl As Control In JeuSudoku.TableLayoutPanel1.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = ctrl
                If txtBox.ReadOnly Then
                    txtBox.BackColor = darkAccent1
                    txtBox.ForeColor = highlight1
                Else
                    txtBox.BackColor = darkAccent2
                    txtBox.ForeColor = highlight4
                End If
            End If
        Next
        JeuSudoku.LabelPseudo.ForeColor = highlight4
        JeuSudoku.pseudoLabel.ForeColor = highlight4
        JeuSudoku.LabelTimer.ForeColor = highlight4
        JeuSudoku.BackColor = darkBackground
    End Sub

    'Applique le darkMode sur le formulaire des statistique
    Private Sub SetDarkStat()
        StatSudoku.BackColor = darkBackground
        StatSudoku.ButtonStatsAvance.ForeColor = highlight4
        StatSudoku.ButtonStatsAvance.BackColor = darkAccent2
        StatSudoku.Label1.ForeColor = highlight4
        StatSudoku.Label2.ForeColor = highlight4
        StatSudoku.nameLabel1.ForeColor = highlight4
        StatSudoku.nbGameLabel3.ForeColor = highlight4
        StatSudoku.TimeLabel2.ForeColor = highlight4
    End Sub
    'Methode qui change la couleur du theme sur le formulaire
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
        Me.RadioButtonHard.ForeColor = DefaultForeColor
        Me.RadioButtonMapDefaut.ForeColor = DefaultForeColor
        Me.GroupBoxDifficulte.ForeColor = DefaultForeColor
        Me.GroupBoxMap.ForeColor = DefaultForeColor

    End Sub

    'Methode qui change le background du formulaire
    Public Sub ChangeMap(background As String)
        CurrentBackground = background
        ApplyMapCustomization(CurrentBackground)
    End Sub

    'Methode qui applique le change du backgrounds=
    Private Sub ApplyMapCustomization(CurrentBackground)
        Select Case CurrentBackground
            Case "RIVER"
                Me.BackgroundImage = My.Resources.River
            Case "SNOW"
                Me.BackgroundImage = My.Resources.Neige
            Case "DEFAUT"
                Me.BackgroundImage = Nothing
                Me.BackColor = SystemColors.ActiveCaption
        End Select
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