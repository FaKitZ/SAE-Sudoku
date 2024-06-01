Public Class MenuSudoku
    Dim i As Integer
    Dim color1 As Color = Color.FromArgb(255, 165, 0)   ' Orange (feuilles d'automne)
    Dim color2 As Color = Color.FromArgb(255, 223, 0)   ' Jaune (feuilles d'automne)
    Dim color3 As Color = Color.FromArgb(205, 92, 92)   ' Rouge adouci (feuilles d'automne)
    Dim color4 As Color = Color.FromArgb(0, 191, 255)
    Private itemsListComboBoxF1 As New List(Of String)  'Liste de joueurs pour la comboBox du menu
    Private CurrentBackground As String

    Private Sub MenuSudoku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModuleJoueur.CheminDossier IsNot Nothing Then
            ModuleJoueur.ChargerJoueursDepuisFichier("joueurs.txt")
        End If
        itemsListComboBoxF1.AddRange(New String() {nameComboBox1.Text})
        UpdateComboBoxItemsF1()
    End Sub

    Private Sub leaveBoutton_Click(sender As Object, e As EventArgs) Handles leaveBoutton.Click
        Dim arret As Integer = MsgBox("Voulez-vous arrêter le jeu ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Arrêt")
        If arret = vbYes Then
            If ModuleJoueur.CheminDossier IsNot Nothing Then
                ModuleJoueur.EnregistrerJoueursDansFichier("joueurs.txt")
            End If
            Me.Close()
        End If
    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        Dim erreur As Boolean = False
        Dim Pseudo As String = nameComboBox1.Text
        If nameComboBox1.Text = "" Then
            nameLabel.BackColor = Color.Red
            erreur = True
        End If

        If erreur = True Then
            MsgBox("Aucun nom saisie", MsgBoxStyle.Information)
        Else
            If Not String.IsNullOrWhiteSpace(Pseudo) Then
                If Not itemsListComboBoxF1.Contains(Pseudo) Then
                    itemsListComboBoxF1.Add(Pseudo)  ' Ajouter à la liste
                    UpdateComboBoxItemsF1()   ' Mettre à jour la ComboBox
                    UpdateModuleJoueur(Pseudo)    ' Mettre à jours le module
                Else
                    UpdateModuleJoueur(Pseudo)  'Actualise les stats du joueurs s'il existe déjà
                End If
            End If
            JeuSudoku.Show()
            Me.Hide()
        End If
    End Sub

    'Méthode qui prends en paramètre le pseudo du joueurs pour le crée dans le module en lui mettant des stats par défaut
    Private Sub UpdateModuleJoueur(Pseudo As String)
        Dim index As Integer = ModuleJoueur.TrouverJoueur(Pseudo)
        If index = -1 Then
            Dim nouveauJoueur As New ModuleJoueur.JOUEUR With {
                .Nom = Pseudo,
                .BestTemps = TimeSpan.Zero,
                .NbGamePlay = 0,
                .CumulTimmer = TimeSpan.Zero,
                .LastGameTime = TimeSpan.Zero
            }
            ModuleJoueur.AjouterJoueur(nouveauJoueur)
        End If
    End Sub

    'Méthode qui met à jours la liste de la comboBox
    Private Sub UpdateComboBoxItemsF1()
        nameComboBox1.Items.Clear()
        nameComboBox1.Items.AddRange(itemsListComboBoxF1.ToArray())
    End Sub

    Private Sub ScoreButton1_Click(sender As Object, e As EventArgs) Handles ScoreButton1.Click
        StatSudoku.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonParametre_Click(sender As Object, e As EventArgs) Handles ButtonParametre.Click
        Me.Hide()
        ParametreSudoku.Show()
    End Sub

    Public Sub ApplyLightTheme()
        Me.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = DefaultForeColor
            End If
        Next
        For Each ctrl As Control In Me.GroupBox1.Controls
            If CurrentBackground = "River" Then
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = color2
                    ctrl.ForeColor = color1
                ElseIf TypeOf ctrl Is Label Then
                    ctrl.ForeColor = color1
                ElseIf TypeOf ctrl Is ComboBox Then
                    ctrl.BackColor = color4
                    ctrl.ForeColor = color1
                End If

            Else
            End If
        Next
    End Sub
    Public Sub ChangeMap(background As String)
        CurrentBackground = background
        ApplyMapCustomization(CurrentBackground)
    End Sub

    Private Sub ApplyMapCustomization(CurrentBackground)
        Select Case CurrentBackground
            Case "RIVER"
                Me.BackgroundImage = My.Resources.River
            Case "SNOW"
                Me.BackgroundImage = My.Resources.Neige
        End Select
    End Sub

End Class
