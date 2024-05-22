<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ComboBox1 = New ComboBox()
        ListBox3 = New ListBox()
        nameLabel1 = New Label()
        TimeLabel2 = New Label()
        nbGameLabel3 = New Label()
        LeaveButton = New Button()
        Label1 = New Label()
        ListBox4 = New ListBox()
        ButtonStatsAvance = New Button()
        ButtonTriPseudo = New Button()
        ButtonTriTimer = New Button()
        ButtonRemiseà0 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(18, 85)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 64)
        ListBox1.TabIndex = 0
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(352, 85)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(120, 49)
        ListBox2.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(17, 155)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 15
        ListBox3.Location = New Point(478, 85)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(120, 49)
        ListBox3.TabIndex = 3
        ' 
        ' nameLabel1
        ' 
        nameLabel1.AutoSize = True
        nameLabel1.Location = New Point(18, 67)
        nameLabel1.Name = "nameLabel1"
        nameLabel1.Size = New Size(103, 15)
        nameLabel1.TabIndex = 4
        nameLabel1.Text = "Nom des joueurs :"
        ' 
        ' TimeLabel2
        ' 
        TimeLabel2.AutoSize = True
        TimeLabel2.Location = New Point(352, 67)
        TimeLabel2.Name = "TimeLabel2"
        TimeLabel2.Size = New Size(66, 15)
        TimeLabel2.TabIndex = 5
        TimeLabel2.Text = "Best timer :"
        ' 
        ' nbGameLabel3
        ' 
        nbGameLabel3.AutoSize = True
        nbGameLabel3.Location = New Point(478, 67)
        nbGameLabel3.Name = "nbGameLabel3"
        nbGameLabel3.Size = New Size(87, 15)
        nbGameLabel3.TabIndex = 6
        nbGameLabel3.Text = "Total de Partie :"
        ' 
        ' LeaveButton
        ' 
        LeaveButton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        LeaveButton.Location = New Point(624, 155)
        LeaveButton.Name = "LeaveButton"
        LeaveButton.Size = New Size(100, 29)
        LeaveButton.TabIndex = 7
        LeaveButton.Text = "Back to menu"
        LeaveButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(604, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 9
        Label1.Text = "Heure de jeu :"
        ' 
        ' ListBox4
        ' 
        ListBox4.FormattingEnabled = True
        ListBox4.ItemHeight = 15
        ListBox4.Location = New Point(604, 85)
        ListBox4.Name = "ListBox4"
        ListBox4.Size = New Size(120, 49)
        ListBox4.TabIndex = 8
        ' 
        ' ButtonStatsAvance
        ' 
        ButtonStatsAvance.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ButtonStatsAvance.Location = New Point(192, 165)
        ButtonStatsAvance.Name = "ButtonStatsAvance"
        ButtonStatsAvance.Size = New Size(104, 23)
        ButtonStatsAvance.TabIndex = 10
        ButtonStatsAvance.Text = "Stats Avancé"
        ButtonStatsAvance.UseVisualStyleBackColor = False
        ' 
        ' ButtonTriPseudo
        ' 
        ButtonTriPseudo.Location = New Point(144, 85)
        ButtonTriPseudo.Name = "ButtonTriPseudo"
        ButtonTriPseudo.Size = New Size(75, 45)
        ButtonTriPseudo.TabIndex = 11
        ButtonTriPseudo.Text = "Tri Pseudo"
        ButtonTriPseudo.UseVisualStyleBackColor = True
        ' 
        ' ButtonTriTimer
        ' 
        ButtonTriTimer.Location = New Point(271, 85)
        ButtonTriTimer.Name = "ButtonTriTimer"
        ButtonTriTimer.Size = New Size(75, 45)
        ButtonTriTimer.TabIndex = 12
        ButtonTriTimer.Text = "Tri Best timer"
        ButtonTriTimer.UseVisualStyleBackColor = True
        ' 
        ' ButtonRemiseà0
        ' 
        ButtonRemiseà0.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ButtonRemiseà0.Location = New Point(208, 136)
        ButtonRemiseà0.Name = "ButtonRemiseà0"
        ButtonRemiseà0.Size = New Size(75, 23)
        ButtonRemiseà0.TabIndex = 13
        ButtonRemiseà0.Text = "Remise à 0"
        ButtonRemiseà0.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.Location = New Point(293, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 32)
        Label2.TabIndex = 14
        Label2.Text = "Statistique"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(738, 244)
        Controls.Add(Label2)
        Controls.Add(ButtonRemiseà0)
        Controls.Add(ButtonTriTimer)
        Controls.Add(ButtonTriPseudo)
        Controls.Add(ButtonStatsAvance)
        Controls.Add(Label1)
        Controls.Add(ListBox4)
        Controls.Add(LeaveButton)
        Controls.Add(nbGameLabel3)
        Controls.Add(TimeLabel2)
        Controls.Add(nameLabel1)
        Controls.Add(ListBox3)
        Controls.Add(ComboBox1)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents nameLabel1 As Label
    Friend WithEvents TimeLabel2 As Label
    Friend WithEvents nbGameLabel3 As Label
    Friend WithEvents LeaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ButtonStatsAvance As Button
    Friend WithEvents ButtonTriPseudo As Button
    Friend WithEvents ButtonTriTimer As Button
    Friend WithEvents ButtonRemiseà0 As Button
    Friend WithEvents Label2 As Label
End Class
