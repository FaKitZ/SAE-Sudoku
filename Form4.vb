Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form4
    Dim input As String
    Dim minute As Integer
    Dim timeInterval As TimeSpan
    Dim difficulte As Integer = 71

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
        Form1.Show()
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
End Class