Imports System.Xml

Public Class Form1
    Dim i As Integer
    Private itemsListComboBoxF1 As New List(Of String)
    Public IsDark As Boolean

    'couleurs'
    Public darkBackground As Color = Color.FromArgb(18, 18, 18)  ' Fond sombre
    Public darkAccent1 As Color = Color.FromArgb(48, 48, 48)     ' Accent sombre 1
    Public darkAccent2 As Color = Color.FromArgb(72, 72, 72)     ' Accent sombre 2
    Public darkAccent3 As Color = Color.FromArgb(96, 96, 96)     ' Accent sombre 3
    Public highlight1 As Color = Color.FromArgb(255, 140, 0)     ' Orange vif pour les points de mise en évidence
    Public highlight2 As Color = Color.FromArgb(255, 215, 0)     ' Jaune doré pour les points de mise en évidence
    Public highlight3 As Color = Color.FromArgb(205, 92, 92)     ' Rouge adouci pour les points de mise en évidence
    Public highlight4 As Color = Color.FromArgb(0, 206, 209)     ' Turquoise pour les points de mise en évidence
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemsListComboBoxF1.AddRange(New String() {nameComboBox1.Text})
        UpdateComboBoxItemsF1()
    End Sub

    Private Sub leaveBoutton_Click(sender As Object, e As EventArgs) Handles leaveBoutton.Click
        Dim arret As Integer = MsgBox("Voulez-vous arrêter le jeu ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "Arrêt")
        If arret = vbYes Then
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
                    UpdateModuleJoueur(Pseudo)
                End If
            End If
            Form2.Show()
            Me.Hide()
        End If
    End Sub

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

    Private Sub UpdateComboBoxItemsF1()
        nameComboBox1.Items.Clear()
        nameComboBox1.Items.AddRange(itemsListComboBoxF1.ToArray())

    End Sub

    Private Sub ScoreButton1_Click(sender As Object, e As EventArgs) Handles ScoreButton1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonParametre_Click(sender As Object, e As EventArgs) Handles ButtonParametre.Click
        Me.Hide()
        Form4.Show()
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
            If TypeOf ctrl Is Button Then
                ctrl.BackColor = DefaultBackColor
                ctrl.ForeColor = DefaultForeColor
            ElseIf TypeOf ctrl Is Label Then
                ctrl.ForeColor = DefaultForeColor
            ElseIf TypeOf ctrl Is ComboBox Then
                ctrl.BackColor = DefaultBackColor
                ctrl.ForeColor = DefaultForeColor
            End If
        Next
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
