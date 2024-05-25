Imports System.Media

Public Class Form2

    Private remainingTime As TimeSpan
    Private initialTime As TimeSpan = TimeSpan.FromMinutes(7)
    Private Difficulte As Integer = 81 - 55
    Private CurrentBackground As String
    Private CurrentColorScheme As String
    Public IsDark As Boolean

    'Couleurs'
    Dim darkAccent1 As Color = Color.FromArgb(48, 48, 48)     ' Accent sombre 1
    Dim darkAccent2 As Color = Color.FromArgb(72, 72, 72)     ' Accent sombre 2
    Dim darkAccent3 As Color = Color.FromArgb(96, 96, 96)     ' Accent sombre 3
    Dim highlight1 As Color = Color.FromArgb(255, 140, 0)     ' Orange vif pour les points de mise en évidence
    Dim highlight4 As Color = Color.FromArgb(0, 206, 209)     ' Turquoise pour les points de mise en évidence
    ' Chemin du fichier WAV (assurez-vous que le nom du fichier est correct)
    Dim wavFilePath As String = "C:\Users\Administrateur\Source\Repos\FaKitZ\Sudoku-VB-LE-BON\Resources\audio.wav"

    ' Utiliser SoundPlayer pour lire le fichier WAV
    Dim player As New SoundPlayer(wavFilePath)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim textBox As New TextBox
                textBox.Multiline = True
                textBox.TextAlign = HorizontalAlignment.Center
                textBox.Dock = DockStyle.Fill
                textBox.Font = New Font("Arial", 22, FontStyle.Bold)
                AddHandler textBox.TextChanged, AddressOf TextBox_TextChanged
                textBox.MaxLength = 1
                TableLayoutPanel1.Controls.Add(textBox, j, i)
            Next
        Next
        GenerateSudoku()
        StartTimmerGame()
        IsDark = Form1.IsDark
        If IsDark Then
            ApplyGridColors(darkAccent2, highlight4, darkAccent1, highlight1)
        End If
        ApplyMapCustomization()
        LabelPseudo.Text = Form1.nameComboBox1.Text

    End Sub

    Public Sub ChangeMap(background As String)
        CurrentBackground = background
        ApplyMapCustomization()
    End Sub

    Private Sub ApplyMapCustomization()
        ' Change background image
        Select Case CurrentBackground
            Case "RIVER"
                Me.BackgroundImage = My.Resources.River
                Dim color1 As Color = Color.FromArgb(255, 165, 0)   ' Orange (feuilles d'automne)
                Dim color2 As Color = Color.FromArgb(255, 223, 0)   ' Jaune (feuilles d'automne)
                Dim color3 As Color = Color.FromArgb(205, 92, 92)   ' Rouge adouci (feuilles d'automne)
                Dim color4 As Color = Color.FromArgb(0, 191, 255)   ' Bleu (ciel clair)
                ApplyGridColors(color1, color2, color3, color4)
            Case "SNOW"
                Dim color1 As Color = Color.FromArgb(255, 255, 255)   ' Blanc (neige)
                Dim color2 As Color = Color.FromArgb(0, 191, 255)     ' Bleu clair (ciel et ombres sur la neige)
                Dim color3 As Color = Color.FromArgb(64, 224, 208)    ' Bleu turquoise
                Dim color4 As Color = Color.FromArgb(139, 69, 19)     ' Marron (tronc d'arbres et cabane)
                ApplyGridColors(color1, color2, color3, color4)
                Me.BackgroundImage = My.Resources.Neige

        End Select
    End Sub

    Public Sub ApplyGridColors(gridBackColor As Color, gridForeColor As Color, readOnlyBackColor As Color, readOnlyForeColor As Color)
        For Each ctrl As Control In TableLayoutPanel1.Controls
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

    Public Sub SetTimerInterval(minutes As Integer)
        initialTime = TimeSpan.FromMinutes(minutes)
        remainingTime = initialTime
        LabelTimer.Text = "Temps restant : " & remainingTime.ToString("mm\:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1))
        LabelTimer.Text = "Temps restant : " & remainingTime.ToString("mm\:ss")

        If remainingTime.TotalSeconds <= 0 Then
            FinDePartieSiLoose()
            Timer1.Stop()
            MessageBox.Show("Le temps est écoulé! Fin de la partie vous avez perdu")
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub StartTimmerGame()
        Timer1.Interval = 1000
        remainingTime = initialTime
        LabelTimer.Text = "Temps restant :"
        Timer1.Start()
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = CType(sender, TextBox)
        Dim ligneIndex As Integer = TableLayoutPanel1.GetRow(txtBox)
        Dim colonneIndex As Integer = TableLayoutPanel1.GetColumn(txtBox)

        RemoveHandler txtBox.TextChanged, AddressOf TextBox_TextChanged

        If Not IsValidEntry(txtBox.Text, ligneIndex, colonneIndex) Then
            txtBox.BackColor = Color.Red
            MessageBox.Show("Entrée invalide!")
            txtBox.Clear()
        Else
            If IsDark Then
                txtBox.BackColor = darkAccent3
            Else
                txtBox.BackColor = DefaultBackColor
            End If
            CheckIfGrilleComplete()
        End If

        AddHandler txtBox.TextChanged, AddressOf TextBox_TextChanged
    End Sub

    Private Function IsValidEntry(valeur As String, ligne As Integer, colonne As Integer) As Boolean
        If Not Char.IsDigit(valeur) OrElse valeur = "" Then
            Return False
        End If

        ' Check les lignes
        For j As Integer = 0 To 8
            If j <> colonne Then
                Dim otherBox As TextBox = CType(TableLayoutPanel1.GetControlFromPosition(j, ligne), TextBox)
                If otherBox IsNot Nothing AndAlso otherBox.Text = valeur Then
                    Return False
                End If
            End If
        Next

        ' Check les colonnes
        For i As Integer = 0 To 8
            If i <> ligne Then
                Dim otherBox As TextBox = CType(TableLayoutPanel1.GetControlFromPosition(colonne, i), TextBox)
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
                    Dim otherBox As TextBox = CType(TableLayoutPanel1.GetControlFromPosition(j, i), TextBox)
                    If otherBox IsNot Nothing AndAlso otherBox.Text = valeur Then
                        Return False
                    End If
                End If
            Next
        Next
        Return True
    End Function

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
                Dim txtBox As TextBox = CType(TableLayoutPanel1.GetControlFromPosition(j, i), TextBox)
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
                Dim txtBox As TextBox = CType(TableLayoutPanel1.GetControlFromPosition(j, i), TextBox)
                If txtBox Is Nothing OrElse String.IsNullOrEmpty(txtBox.Text) OrElse Not IsValidEntry(txtBox.Text, i, j) Then
                    Return
                End If
            Next
        Next
        ' Si la boucle se termine sans retourner, cela signifie que la grille est complète et valide
        MessageBox.Show("Félicitations, vous avez complété le Sudoku!", "Partie terminée", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FinDePartieSiWin()
        Timer1.Stop()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub FinDePartieSiLoose()
        Dim nomJoueur As String = Form1.nameComboBox1.Text
        Dim tempsEcoule As TimeSpan = initialTime - remainingTime
        ModuleJoueur.MettreAJourJoueurSiLoose(nomJoueur, tempsEcoule)
    End Sub
    Private Sub FinDePartieSiWin()
        Dim nomJoueur As String = Form1.nameComboBox1.Text
        Dim tempsEcoule As TimeSpan = initialTime - remainingTime
        ModuleJoueur.MettreAJourJoueurSiWin(nomJoueur, tempsEcoule)
    End Sub

    Private Sub leaveButon_Click(sender As Object, e As EventArgs) Handles leaveButon.Click
        Dim arret As Integer = MsgBox("Voulez-vous arrêter la partie ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Arrêt")
        If arret = vbYes Then
            player.Stop()
            FinDePartieSiLoose()
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        Timer1.Stop()
        PlayButton.Visible = True
        PauseButton.Visible = False
        TableLayoutPanel1.Enabled = False
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Timer1.Start()
        TableLayoutPanel1.Enabled = True
        PlayButton.Visible = False
        PauseButton.Visible = True
    End Sub
    Public Sub ApplyLightTheme()
        Me.BackColor = SystemColors.ActiveCaption
        ' Changez les autres propriétés de contrôle si nécessaire
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = DefaultForeColor
            End If
        Next
        For Each ctrl As Control In TableLayoutPanel1.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = ctrl
                txtBox.BackColor = DefaultBackColor
                txtBox.ForeColor = DefaultForeColor
            End If
        Next
    End Sub

    Private Sub ButtonMusic_Click(sender As Object, e As EventArgs) Handles ButtonMusic.Click
        ButtonMusic.Visible = False
        ButtonMusicOFF.Visible = True
        player.Play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonMusicOFF.Click
        ButtonMusicOFF.Visible = False
        ButtonMusic.Visible = True
        player.Stop()
    End Sub
End Class