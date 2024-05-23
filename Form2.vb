Public Class Form2

    Private remainingTime As TimeSpan
    Private initialTime As TimeSpan = TimeSpan.FromMinutes(7)
    Private Difficulte As Integer = 71
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
                TableLayoutPanelNew.Controls.Add(textBox, j, i)
            Next
        Next

        GenerateSudoku()
        StartTimmerGame()
        LabelPseudo.Text = Form1.nameComboBox1.Text
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
        Dim ligneIndex As Integer = TableLayoutPanelNew.GetRow(txtBox)
        Dim colonneIndex As Integer = TableLayoutPanelNew.GetColumn(txtBox)

        If Not IsValidEntry(txtBox.Text, ligneIndex, colonneIndex) Then
            txtBox.BackColor = Color.Red
            MessageBox.Show("Entrée invalide!")
            txtBox.Clear()
        Else
            txtBox.BackColor = DefaultBackColor
            CheckIfGrilleComplete()
        End If

    End Sub

    Private Function IsValidEntry(valeur As String, ligne As Integer, colonne As Integer) As Boolean
        If Not Char.IsDigit(valeur) OrElse valeur = "" Then
            Return False
        End If

        ' Check les lignes
        For j As Integer = 0 To 8
            If j <> colonne Then
                Dim otherBox As TextBox = CType(TableLayoutPanelNew.GetControlFromPosition(j, ligne), TextBox)
                If otherBox IsNot Nothing AndAlso otherBox.Text = valeur Then
                    Return False
                End If
            End If
        Next

        ' Check les colonnes
        For i As Integer = 0 To 8
            If i <> ligne Then
                Dim otherBox As TextBox = CType(TableLayoutPanelNew.GetControlFromPosition(colonne, i), TextBox)
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
                    Dim otherBox As TextBox = CType(TableLayoutPanelNew.GetControlFromPosition(j, i), TextBox)
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
                Dim txtBox As TextBox = CType(TableLayoutPanelNew.GetControlFromPosition(j, i), TextBox)
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
                Dim txtBox As TextBox = CType(TableLayoutPanelNew.GetControlFromPosition(j, i), TextBox)
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
            FinDePartieSiLoose()
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As EventArgs) Handles PauseButton.Click
        Timer1.Stop()
        PauseButton.Visible = False
        PlayButton.Visible = True
        TableLayoutPanelNew.Enabled = False
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Timer1.Start()
        PlayButton.Visible = False
        PauseButton.Visible = True
        TableLayoutPanelNew.Enabled = True
    End Sub
End Class