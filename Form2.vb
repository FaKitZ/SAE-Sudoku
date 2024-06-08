Imports System.Media
Public Class JeuSudoku

    Private remainingTime As TimeSpan
    Private initialTime As TimeSpan = TimeSpan.FromMinutes(7)
    Private Difficulte As Integer = 81 - 55 'Difficulté par defaut réglé à 26 case vide
    Private CurrentBackground As String
    Private CurrentColorScheme As String
    Private isDarkMode As Boolean = False
    Private couleurSudoku As New CouleurSudoku

    ' Chemin du fichier WAV (assurez-vous que le nom du fichier est correct)
    Dim wavFilePath As String = AppDomain.CurrentDomain.BaseDirectory & "audio.wav"

    ' Utiliser SoundPlayer pour lire le fichier WAV
    Dim music As New SoundPlayer(wavFilePath)
    Private Sub JeuSudoku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim textBox As New TextBox
                textBox.Multiline = True
                textBox.TextAlign = HorizontalAlignment.Center
                textBox.Dock = DockStyle.Fill
                textBox.Font = New Font("Arial", 22, FontStyle.Bold)
                AddHandler textBox.TextChanged, AddressOf TextBox_TextChanged
                textBox.MaxLength = 1
                TableLayoutPanelGrilleSudoku.Controls.Add(textBox, j, i)
            Next
        Next

        GenerateSudoku() 'génère le sudoku au démarrage
        couleurSudoku.ApplyMapCustomizationJeuSudoku(CurrentBackground)
    End Sub

    'Change le thème du fond en jeu
    Public Sub ChangeMap(background As String)
        CurrentBackground = background
        couleurSudoku.ApplyMapCustomizationJeuSudoku(CurrentBackground)
    End Sub

    Public Sub ChangeDarkMod(value As Boolean)
        isDarkMode = value
    End Sub

    Public Sub ApplyDarkMod()
        If isDarkMode = True Then
            couleurSudoku.SetDarkjeu()
        End If
    End Sub

    'méthode qui règle la variable remainingTime, et prends en comptes les changements effectuer par le joueur dans les paramètres 
    Public Sub SetTimerInterval(minutes As Integer)
        initialTime = TimeSpan.FromMinutes(minutes)
        remainingTime = initialTime
        LabelTimer.Text = "Temps restant : " & remainingTime.ToString("mm\:ss")
    End Sub

    'méthode qui affiche le timer sur le label avec les tick, et met fin à la partie lorsqu'il y a une fin de game
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1))
        LabelTimer.Text = "Temps restant : " & remainingTime.ToString("mm\:ss")
        If remainingTime.TotalSeconds <= 0 Then
            FinDePartieSiLoose()
            Timer1.Stop()
            MessageBox.Show("Le temps est écoulé! Fin de la partie vous avez perdu")
            MenuSudoku.Show()
            Me.Close()
        End If
    End Sub

    'Lance le timer de la partie
    Public Sub StartTimerGame()
        Timer1.Interval = 1000
        remainingTime = initialTime
        LabelTimer.Text = "Temps restant :"
        Timer1.Start()
        Timer1.Enabled = True
    End Sub

    'Verifie le chiffre placé dans une textBox et met en rouge si le chiffre est invalid
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = CType(sender, TextBox)
        Dim ligneIndex As Integer = TableLayoutPanelGrilleSudoku.GetRow(txtBox)
        Dim colonneIndex As Integer = TableLayoutPanelGrilleSudoku.GetColumn(txtBox)

        RemoveHandler txtBox.TextChanged, AddressOf TextBox_TextChanged

        If Not IsValidEntry(txtBox.Text, ligneIndex, colonneIndex) Then
            txtBox.BackColor = Color.Red
            MessageBox.Show("Entrée invalide!")
            txtBox.Clear()
        Else
            txtBox.BackColor = Color.White
            CheckIfGrilleComplete()
        End If

        AddHandler txtBox.TextChanged, AddressOf TextBox_TextChanged
    End Sub

    'Méthode qui vérifie le placement sur la ligne/colonne/régions du chiffre
    Private Function IsValidEntry(valeur As String, ligne As Integer, colonne As Integer) As Boolean
        If Not Char.IsDigit(valeur) OrElse valeur = "" Then
            Return False
        End If

        ' Check les lignes
        For j As Integer = 0 To 8
            If j <> colonne Then
                Dim otherBox As TextBox = CType(TableLayoutPanelGrilleSudoku.GetControlFromPosition(j, ligne), TextBox)
                If otherBox IsNot Nothing AndAlso otherBox.Text = valeur Then
                    Return False
                End If
            End If
        Next

        ' Check les colonnes
        For i As Integer = 0 To 8
            If i <> ligne Then
                Dim otherBox As TextBox = CType(TableLayoutPanelGrilleSudoku.GetControlFromPosition(colonne, i), TextBox)
                If otherBox IsNot Nothing AndAlso otherBox.Text = valeur Then
                    Return False
                End If
            End If
        Next

        ' Check les régions
        Dim startLigne As Integer = (ligne \ 3) * 3
        Dim startColonne As Integer = (colonne \ 3) * 3
        For i As Integer = startLigne To startLigne + 2
            For j As Integer = startColonne To startColonne + 2
                If (i <> ligne Or j <> colonne) Then
                    Dim otherBox As TextBox = CType(TableLayoutPanelGrilleSudoku.GetControlFromPosition(j, i), TextBox)
                    If otherBox IsNot Nothing AndAlso otherBox.Text = valeur Then
                        Return False
                    End If
                End If
            Next
        Next
        Return True
    End Function

    'Applique la difficulté choisie par le joueurs dans le formulaire des paramètre
    Public Sub ChangeDifficulte(valeur As Integer)
        Difficulte = valeur
    End Sub

    Private Sub GenerateSudoku()
        Dim generator As New SudokuGenerator()
        Dim grid(,) As Integer = generator.Generate()

        ' Nombre d'indices à afficher
        ' Plus le chiffre est grand, plus il y a de case vide
        ' à l'inverse si le chiffre est petit alors il y aura peu de case vide à remplir
        Dim nbDeChiffreAffiche As Integer = Difficulte
        CreatePuzzle(grid, nbDeChiffreAffiche)

        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim txtBox As TextBox = CType(TableLayoutPanelGrilleSudoku.GetControlFromPosition(j, i), TextBox)
                If grid(i, j) <> 0 Then
                    txtBox.Text = grid(i, j).ToString()
                    txtBox.ReadOnly = True
                Else
                    txtBox.Text = ""
                    txtBox.ReadOnly = False
                End If
            Next
        Next
    End Sub

    'Méthode qui crée le puzzle du sudoku soit une grille qui va générer aléatoirement des chiffres et vérifier si l'emplacement est bon
    Private Sub CreatePuzzle(ByRef grid(,) As Integer, nbDeChiffreAffiche As Integer)
        Dim rand As New Random()
        Dim positions As List(Of Tuple(Of Integer, Integer)) = New List(Of Tuple(Of Integer, Integer))()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                positions.Add(New Tuple(Of Integer, Integer)(i, j))
            Next
        Next
        positions = positions.OrderBy(Function(a) rand.Next()).ToList()

        For Each pos In positions
            If nbDeChiffreAffiche <= 0 Then Exit For
            Dim row As Integer = pos.Item1
            Dim col As Integer = pos.Item2
            Dim temp As Integer = grid(row, col)
            grid(row, col) = 0

            If Not IsSolvable(grid) Then
                grid(row, col) = temp
            Else
                nbDeChiffreAffiche -= 1
            End If
        Next
    End Sub

    Private Function IsSolvable(grid(,) As Integer) As Boolean
        ' Pour simplifier, supposons que c'est toujours solvable
        Return True
    End Function

    Private Sub CheckIfGrilleComplete()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim txtBox As TextBox = CType(TableLayoutPanelGrilleSudoku.GetControlFromPosition(j, i), TextBox)
                If txtBox Is Nothing OrElse String.IsNullOrEmpty(txtBox.Text) OrElse Not IsValidEntry(txtBox.Text, i, j) Then
                    Return
                End If
            Next
        Next
        ' Si la boucle se termine sans retourner, cela signifie que la grille est complète et valide
        MessageBox.Show("Félicitations, vous avez complété le Sudoku!", "Partie terminée", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FinDePartieSiWin()
        Timer1.Stop()
        MenuSudoku.Show()
        Me.Close()
    End Sub

    'Met à jours les stats d'un joueur s'il gagne
    Private Sub FinDePartieSiLoose()

        Dim nomJoueur As String = MenuSudoku.nameComboBox1.Text
        Dim tempsEcoule As TimeSpan = initialTime - remainingTime
        ModuleJoueur.MettreAJourJoueurSiLoose(nomJoueur, tempsEcoule)
    End Sub
    'Met a jours les stats d'un joueur s'il perds (ne prends pas en compte le temps jouer sur cette partie pour le best timer par exemple)
    Private Sub FinDePartieSiWin()
        Dim nomJoueur As String = MenuSudoku.nameComboBox1.Text
        Dim tempsEcoule As TimeSpan = initialTime - remainingTime
        ModuleJoueur.MettreAJourJoueurSiWin(nomJoueur, tempsEcoule)
    End Sub

    Private Sub leaveButon_Click(sender As Object, e As EventArgs) Handles leaveButon.Click
        Dim arret As Integer = MsgBox("Voulez-vous arrêter la partie ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Arrêt")
        If arret = vbYes Then
            music.Stop()
            FinDePartieSiLoose()
            Timer1.Stop()
            MenuSudoku.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        Timer1.Stop()
        PlayButton.Visible = True
        PauseButton.Visible = False
        TableLayoutPanelGrilleSudoku.Enabled = False
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Timer1.Start()
        TableLayoutPanelGrilleSudoku.Enabled = True
        PlayButton.Visible = False
        PauseButton.Visible = True
    End Sub

    'Bouton qui active la musique
    Private Sub ButtonMusic_Click(sender As Object, e As EventArgs) Handles ButtonMusic.Click
        ButtonMusic.Visible = False
        ButtonMusicOFF.Visible = True
        music.Play()
    End Sub
    'Bouton qui desactive la musique
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonMusicOFF.Click
        ButtonMusicOFF.Visible = False
        ButtonMusic.Visible = True
        music.Stop()
    End Sub
    'on joue avec les .visible pour superposer les boutons
    Private Sub ButtonYoutube_Click(sender As Object, e As EventArgs) Handles ButtonYoutube.Click
        Youtube.Show()
        ButtonYoutube.Visible = False
        ButtonFermeYoutube.Visible = True
    End Sub

    Private Sub ButtonNetflix_Click(sender As Object, e As EventArgs) Handles ButtonNetflix.Click
        Netflix.Show()
        ButtonNetflix.Visible = False
        ButtonFermeNetflix.Visible = True
    End Sub

    Private Sub ButtonFermeNetflix_Click(sender As Object, e As EventArgs) Handles ButtonFermeNetflix.Click
        Netflix.Close()
        ButtonNetflix.Visible = True
        ButtonFermeNetflix.Visible = False
    End Sub

    Private Sub ButtonFermeYoutube_Click(sender As Object, e As EventArgs) Handles ButtonFermeYoutube.Click
        Youtube.Close()
        ButtonFermeYoutube.Visible = False
        ButtonYoutube.Visible = True
    End Sub

    Private Sub ButtonInternet_Click(sender As Object, e As EventArgs) Handles ButtonInternet.Click
        Internet.Show()
        ButtonInternet.Visible = False
        ButtonFermeinternet.Visible = True
    End Sub

    Private Sub ButtonFermeinternet_Click(sender As Object, e As EventArgs) Handles ButtonFermeinternet.Click
        Internet.Close()
        ButtonFermeinternet.Visible = False
        ButtonInternet.Visible = True
    End Sub
End Class
