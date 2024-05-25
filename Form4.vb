Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Xml

Public Class Form4
    Dim input As String
    Dim minute As Integer
    Dim timeInterval As TimeSpan
    Dim difficulte As Integer = 71
    Dim SelectedMap As String
    Private isDarkMode As Boolean = False

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        isDarkMode = Form1.IsDark
        If isDarkMode Then
            Button1.BackgroundImage = My.Resources.Lightmod
            SetDark()
        Else
            ApplyLightTheme()
        End If
    End Sub

    Private Sub ChangeTimerButton_Click(sender As Object, e As EventArgs) Handles ChangeTimerButton.Click
        input = InputBox("Combien de temps voulez-vous mettre (en minutes) :")
        If IsNumeric(input) Then
            minute = CInt(input)
            timeInterval = TimeSpan.FromMinutes(minute)
            Form2.SetTimerInterval(minute)
            MsgBox("L'intervalle du timer a été modifié à " & minute & " minute(s).")
        Else
            MsgBox("Veuillez entrer un nombre valide.")
        End If
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked Then
            difficulte = 60
            Form2.ChangeDifficulte(difficulte)
        End If
    End Sub
    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked Then
            difficulte = 74
            Form2.ChangeDifficulte(difficulte)
        End If
    End Sub
    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        If RadioButton3.Checked Then
            difficulte = 79
            Form2.ChangeDifficulte(difficulte)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            SelectedMap = "RIVER"
            ApplyMapChanges()
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            SelectedMap = "SNOW"
            ApplyMapChanges()
        End If
    End Sub
    Private Sub ApplyMapChanges()
        Form2.ChangeMap(SelectedMap)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isDarkMode = Not isDarkMode
        If isDarkMode Then
            Button1.BackgroundImage = My.Resources.Lightmod
        Else
            Button1.BackgroundImage = My.Resources.Darkmod
        End If
        UpdateMenu()
        Form1.IsDark = Not Form1.IsDark

    End Sub

    Private Sub UpdateMenu()
        If isDarkMode Then
            Form1.BackColor = Form1.darkBackground
            Form1.Label1.ForeColor = Form1.highlight4
            Form1.nameLabel.ForeColor = Form1.highlight4
            Form1.nameComboBox1.BackColor = Form1.darkAccent1
            Form1.nameComboBox1.ForeColor = Form1.highlight4
            Form1.playButton.ForeColor = Form1.highlight4
            Form1.ScoreButton1.ForeColor = Form1.highlight4
            Form1.ButtonParametre.ForeColor = Form1.highlight4
            Form1.leaveBoutton.ForeColor = Form1.highlight4
            Form1.playButton.BackColor = Form1.darkAccent2
            Form1.ScoreButton1.BackColor = Form1.darkAccent2
            Form1.ButtonParametre.BackColor = Form1.darkAccent2
            Form1.leaveBoutton.BackColor = Form1.darkAccent2
            SetDark()
        Else
            ApplyLightTheme()
            Form2.ApplyLightTheme()
            Form3.ApplyLightTheme()
            Form1.ApplyLightTheme()
        End If
    End Sub

    Private Sub SetDark()
        Me.BackColor = Form1.darkBackground
        Me.Label1.ForeColor = Form1.highlight4
        Me.Label3.ForeColor = Form1.highlight4
        Me.Label4.ForeColor = Form1.highlight4
        Me.Label5.ForeColor = Form1.highlight4
        Me.ChangeTimerButton.BackColor = Form1.darkAccent2
        Me.LeaveButton.BackColor = Form1.darkAccent2
        Me.Button1.BackColor = Form1.darkAccent2
        Me.LeaveButton.ForeColor = Form1.highlight4
        Me.RadioButton1.ForeColor = Form1.highlight4
        Me.RadioButton2.ForeColor = Form1.highlight4
        Me.RadioButton3.ForeColor = Form1.highlight4
        Me.RadioButton4.ForeColor = Form1.highlight4
        Me.RadioButton5.ForeColor = Form1.highlight4
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
        Me.RadioButton1.ForeColor = DefaultForeColor
        Me.RadioButton2.ForeColor = DefaultForeColor
        Me.RadioButton3.ForeColor = DefaultForeColor
        Me.RadioButton4.ForeColor = DefaultForeColor
        Me.RadioButton5.ForeColor = DefaultForeColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Folderbrowser()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Folderbrowser()
        ModuleJoueur.ChargerJoueursDepuisFichier("joueurs.txt")
    End Sub

    Public Sub Folderbrowser()
        Using dossierDialog As New FolderBrowserDialog()
            If dossierDialog.ShowDialog() = DialogResult.OK Then
                ModuleJoueur.CheminDossier = dossierDialog.SelectedPath
                MsgBox("Chemin de dossier sélectionné: " & ModuleJoueur.CheminDossier)
            End If
        End Using
    End Sub
End Class