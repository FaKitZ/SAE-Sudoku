Public Class CouleurSudoku

    'couleurs thème
    Private color1River As Color = Color.FromArgb(255, 165, 0)   ' Orange (feuilles d'automne)
    Private color2River As Color = Color.FromArgb(255, 223, 0)   ' Jaune (feuilles d'automne)
    Private color3River As Color = Color.FromArgb(205, 92, 92)   ' Rouge adouci (feuilles d'automne)
    Private color4River As Color = Color.FromArgb(0, 191, 255)   ' Bleu (ciel clair)
    Private color1Snow As Color = Color.FromArgb(255, 255, 255)   ' Blanc (neige)
    Private color2Snow As Color = Color.FromArgb(0, 191, 255)     ' Bleu clair (ciel et ombres sur la neige)
    Private color3Snow As Color = Color.FromArgb(64, 224, 208)    ' Bleu turquoise
    Private color4Snow As Color = Color.FromArgb(139, 69, 19)     ' Marron (tronc d'arbres et cabane)

    'couleur darkMode
    Private darkBackground As Color = Color.FromArgb(18, 18, 18)  ' Fond sombre
    Private darkAccent1 As Color = Color.FromArgb(48, 48, 48)     ' Accent sombre 1
    Private darkAccent2 As Color = Color.FromArgb(72, 72, 72)     ' Accent sombre 2
    Private darkAccent3 As Color = Color.FromArgb(96, 96, 96)     ' Accent sombre 3
    Private highlight1 As Color = Color.FromArgb(255, 140, 0)     ' Orange vif pour les points de mise en évidence
    Private highlight2 As Color = Color.FromArgb(255, 215, 0)     ' Jaune doré pour les points de mise en évidence
    Private highlight3 As Color = Color.FromArgb(205, 92, 92)     ' Rouge adouci pour les points de mise en évidence
    Private highlight4 As Color = Color.FromArgb(0, 206, 209)     ' Turquoise pour les points de mise en évidence

    Public Shared ReadOnly LightColors As Color() = {Color.LightBlue, Color.LightGreen, Color.LightCoral, Color.LightGoldenrodYellow, Color.LightPink, Color.LightSalmon}
    Public Shared ReadOnly DarkColors As Color() = {Color.DarkBlue, Color.DarkGreen, Color.DarkRed, Color.DarkGoldenrod, Color.DarkMagenta, Color.DarkSalmon}

    Public Shared Function GetColors(isDarkMode As Boolean, theme As String) As Color()
        If isDarkMode Then
            Return DarkColors
        Else
            Return LightColors
        End If
    End Function
    'Couleur defaut pour les formulaire
    Private defaultColorFore As Color
    Private defaultColorBack As Color

    'Map & theme
    Private CurrentBackground As String

    Private Sub ColorForeChangeToDefault()
        defaultColorFore = ParametreSudoku.DefaultcolorFore
    End Sub
    Private Sub ColorBackChangeToDefault()
        defaultColorBack = ParametreSudoku.DefaultcolorBack
    End Sub


    'Applique DARK MODE ----------------------------------------------------------------------------------

    'Applique le darkMode sur le formulaire Parametre
    Public Sub SetDarkParametre()
        ParametreSudoku.BackColor = darkBackground
        ParametreSudoku.LabelChangeTimer.ForeColor = highlight4
        ParametreSudoku.LabelChoixDossier.ForeColor = highlight4
        ParametreSudoku.LabelTitre.ForeColor = highlight4
        ParametreSudoku.GroupBoxDifficulte.ForeColor = highlight4
        ParametreSudoku.GroupBoxMap.ForeColor = highlight4
        ParametreSudoku.ChangeTimerButton.BackColor = darkAccent2
        ParametreSudoku.LeaveButton.BackColor = darkAccent2
        ParametreSudoku.ButtonDarkMode.BackColor = darkAccent2
        ParametreSudoku.LeaveButton.ForeColor = highlight4
        ParametreSudoku.ButtonCheminDossier.BackColor = darkAccent2
        ParametreSudoku.ButtonCheminDossier.ForeColor = highlight4
        ParametreSudoku.ButtonCheminChargerSave.BackColor = darkAccent2
        ParametreSudoku.ButtonCheminChargerSave.ForeColor = highlight4
        ParametreSudoku.RadioButtonFacile.ForeColor = highlight4
        ParametreSudoku.RadioButtonMoyen.ForeColor = highlight4
        ParametreSudoku.RadioButtonDifficile.ForeColor = highlight4
        ParametreSudoku.RadioButton4.ForeColor = highlight4
        ParametreSudoku.RadioButton5.ForeColor = highlight4
        ParametreSudoku.RadioButtonHard.ForeColor = highlight4
        ParametreSudoku.RadioButtonMapDefaut.ForeColor = highlight4

    End Sub

    'Applique le darkMode sur le formulaire du menu du jeu
    Public Sub SetDarkMenu()
        MenuSudoku.BackColor = darkBackground
        MenuSudoku.LabelTitre.ForeColor = highlight4
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

    'Applique le darkMode sur le formulaire du jeu sudoku (grille)
    Public Sub SetDarkjeu()
        For Each ctrl As Control In JeuSudoku.TableLayoutPanelGrilleSudoku.Controls
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
        JeuSudoku.LabelPseudoDuJoueur.ForeColor = highlight4
        JeuSudoku.LabelTimer.ForeColor = highlight4
        JeuSudoku.BackColor = darkBackground
    End Sub

    'Applique LIGHT MODE ----------------------------------------------------------------------------------

    'Applique le darkMode sur le formulaire des statistique
    Public Sub SetDarkStat()
        StatSudoku.BackColor = darkBackground
        StatSudoku.ButtonStatsAvance.ForeColor = highlight4
        StatSudoku.ButtonStatsAvance.BackColor = darkAccent2
        StatSudoku.ButtonTriPseudo.BackColor = darkAccent2
        StatSudoku.ButtonTriPseudo.ForeColor = highlight4
        StatSudoku.ButtonTriTimer.BackColor = darkAccent2
        StatSudoku.ButtonTriTimer.ForeColor = highlight4
        StatSudoku.LabelTotalHeure.ForeColor = highlight4
        StatSudoku.LabelTitre.ForeColor = highlight4
        StatSudoku.LabelBestTimer.ForeColor = highlight4
        StatSudoku.LabelNameLstBox.ForeColor = highlight4
        StatSudoku.LabelNombreGame.ForeColor = highlight4

    End Sub

    'Methode qui change la couleur du theme sur le formulaire
    Public Sub ApplyLightThemeParametre()
        ParametreSudoku.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In ParametreSudoku.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = defaultColorFore
            ElseIf TypeOf ctrl Is Button Then
                ctrl.BackColor = defaultColorBack
                ctrl.ForeColor = defaultColorFore
            End If
        Next
        ParametreSudoku.RadioButtonFacile.ForeColor = defaultColorFore
        ParametreSudoku.RadioButtonMoyen.ForeColor = defaultColorFore
        ParametreSudoku.RadioButtonDifficile.ForeColor = defaultColorFore
        ParametreSudoku.RadioButton4.ForeColor = defaultColorFore
        ParametreSudoku.RadioButton5.ForeColor = defaultColorFore
        ParametreSudoku.RadioButtonHard.ForeColor = defaultColorFore
        ParametreSudoku.RadioButtonMapDefaut.ForeColor = defaultColorFore
        ParametreSudoku.GroupBoxDifficulte.ForeColor = defaultColorFore
        ParametreSudoku.GroupBoxMap.ForeColor = defaultColorFore
    End Sub

    'Méthode qui met le mode classique sur le formulaire
    Public Sub ApplyLightThemeMenu()
        MenuSudoku.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In MenuSudoku.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = defaultColorFore
            ElseIf TypeOf ctrl Is Button Then
                ctrl.BackColor = defaultColorBack
                ctrl.ForeColor = defaultColorFore
            End If
        Next
        For Each ctrl As Control In MenuSudoku.GroupBox1.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = defaultColorFore
            ElseIf TypeOf ctrl Is Button Then
                ctrl.BackColor = defaultColorBack
                ctrl.ForeColor = defaultColorFore
            End If
        Next

        MenuSudoku.nameComboBox1.BackColor = defaultColorBack
        MenuSudoku.nameComboBox1.ForeColor = defaultColorFore
    End Sub

    'change le thème du formulaire
    Public Sub ApplyLightThemeStats()
        StatSudoku.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In StatSudoku.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = defaultColorFore
            ElseIf TypeOf ctrl Is Button Then
                ctrl.BackColor = defaultColorBack
                ctrl.ForeColor = defaultColorFore
            End If
        Next
    End Sub

    'Change les couleurs en fonctions du thème choisis par le joueur
    Public Sub ApplyLightThemeJeu()
        JeuSudoku.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In JeuSudoku.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = defaultColorFore
            End If
        Next
        For Each ctrl As Control In JeuSudoku.TableLayoutPanelGrilleSudoku.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = ctrl
                txtBox.BackColor = defaultColorBack
                txtBox.ForeColor = defaultColorFore
            End If
        Next
    End Sub

    'Change MAP ---------------------------------------------------------------------------

    Public Sub ApplyMapChanges(SelectedMap)
        JeuSudoku.ChangeMap(SelectedMap)
        ApplyMapCustomizationMenuSudoku(SelectedMap)
        ApplyMapCustomizationStatSudoku(CurrentBackground)
        ApplyMapCustomizationParametreSudoku(SelectedMap)
    End Sub


    'Methode qui applique le change du backgrounds
    Private Sub ApplyMapCustomizationParametreSudoku(CurrentBackground)
        Select Case CurrentBackground
            Case "RIVER"
                ParametreSudoku.BackgroundImage = My.Resources.River
            Case "SNOW"
                ParametreSudoku.BackgroundImage = My.Resources.Neige
            Case "DEFAUT"
                ParametreSudoku.BackgroundImage = Nothing
                ParametreSudoku.BackColor = SystemColors.ActiveCaption
        End Select
    End Sub

    'Methode qui applique le changement de theme
    Private Sub ApplyMapCustomizationMenuSudoku(CurrentBackground)
        Select Case CurrentBackground
            Case "RIVER"
                MenuSudoku.BackgroundImage = My.Resources.River
                For Each ctrl As Control In MenuSudoku.GroupBox1.Controls
                    If CurrentBackground = "RIVER" Then
                        If TypeOf ctrl Is Button Then
                            ctrl.BackColor = color2River
                            ctrl.ForeColor = color1River
                        ElseIf TypeOf ctrl Is Label Then
                            ctrl.ForeColor = color1River
                        ElseIf TypeOf ctrl Is ComboBox Then
                            ctrl.BackColor = color4River
                            ctrl.ForeColor = color1River
                        End If

                    Else
                    End If
                Next
            Case "SNOW"
                MenuSudoku.BackgroundImage = My.Resources.Neige
                For Each ctrl As Control In MenuSudoku.GroupBox1.Controls
                    If CurrentBackground = "SNOW" Then
                        If TypeOf ctrl Is Button Then
                            ctrl.BackColor = color2Snow
                            ctrl.ForeColor = color1Snow
                        ElseIf TypeOf ctrl Is Label Then
                            ctrl.ForeColor = color1Snow
                        ElseIf TypeOf ctrl Is ComboBox Then
                            ctrl.BackColor = color4Snow
                            ctrl.ForeColor = color1Snow
                        End If
                    Else
                    End If
                Next
            Case "DEFAUT"
                MenuSudoku.BackgroundImage = Nothing
                MenuSudoku.BackColor = SystemColors.ActiveCaption
        End Select
    End Sub

    'Apllique les changement du background
    Private Sub ApplyMapCustomizationStatSudoku(CurrentBackground)
        Select Case CurrentBackground
            Case "RIVER"
                StatSudoku.BackgroundImage = My.Resources.River
            Case "SNOW"
                StatSudoku.BackgroundImage = My.Resources.Neige
            Case "DEFAUT"
                StatSudoku.BackgroundImage = Nothing
                StatSudoku.BackColor = SystemColors.ActiveCaption
        End Select
    End Sub

    'Méthode qui change le background et les couleurs du jeu sudoku
    Public Sub ApplyMapCustomizationJeuSudoku(CurrentBackground)
        ' Change background image
        Select Case CurrentBackground
            Case "RIVER"
                JeuSudoku.BackgroundImage = My.Resources.River
                ApplyGridColors(color1River, color2River, color3River, color4River)
            Case "SNOW"
                ApplyGridColors(color1Snow, color2Snow, color3Snow, color4Snow)
                JeuSudoku.BackgroundImage = My.Resources.Neige
            Case "DEFAUT"
                JeuSudoku.BackgroundImage = Nothing
                JeuSudoku.BackColor = SystemColors.ActiveCaption
        End Select
    End Sub
    Private Sub ApplyGridColors(gridBackColor As Color, gridForeColor As Color, readOnlyBackColor As Color, readOnlyForeColor As Color)
        For Each ctrl As Control In JeuSudoku.TableLayoutPanelGrilleSudoku.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = ctrl
                If txtBox.ReadOnly Then
                    txtBox.BackColor = readOnlyBackColor
                    txtBox.ForeColor = readOnlyForeColor
                Else
                    txtBox.BackColor = gridBackColor
                    txtBox.ForeColor = gridForeColor
                End If
            End If
        Next
    End Sub
End Class
