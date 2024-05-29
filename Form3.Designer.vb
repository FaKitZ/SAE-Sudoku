<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatSudoku
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
        Me.ListBoxName = New System.Windows.Forms.ListBox()
        Me.ListBoxBestTimer = New System.Windows.Forms.ListBox()
        Me.ComboBoxName = New System.Windows.Forms.ComboBox()
        Me.ListBoxTotalPartie = New System.Windows.Forms.ListBox()
        Me.nameLabel1 = New System.Windows.Forms.Label()
        Me.TimeLabel2 = New System.Windows.Forms.Label()
        Me.nbGameLabel3 = New System.Windows.Forms.Label()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxHeureDeJeu = New System.Windows.Forms.ListBox()
        Me.ButtonStatsAvance = New System.Windows.Forms.Button()
        Me.ButtonTriPseudo = New System.Windows.Forms.Button()
        Me.ButtonTriTimer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxName
        '
        Me.ListBoxName.FormattingEnabled = True
        Me.ListBoxName.Location = New System.Drawing.Point(16, 74)
        Me.ListBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxName.Name = "ListBoxName"
        Me.ListBoxName.Size = New System.Drawing.Size(104, 56)
        Me.ListBoxName.TabIndex = 0
        '
        'ListBoxBestTimer
        '
        Me.ListBoxBestTimer.FormattingEnabled = True
        Me.ListBoxBestTimer.Location = New System.Drawing.Point(302, 74)
        Me.ListBoxBestTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxBestTimer.Name = "ListBoxBestTimer"
        Me.ListBoxBestTimer.Size = New System.Drawing.Size(104, 43)
        Me.ListBoxBestTimer.TabIndex = 1
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(14, 134)
        Me.ComboBoxName.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxName.TabIndex = 2
        '
        'ListBoxTotalPartie
        '
        Me.ListBoxTotalPartie.FormattingEnabled = True
        Me.ListBoxTotalPartie.Location = New System.Drawing.Point(410, 74)
        Me.ListBoxTotalPartie.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxTotalPartie.Name = "ListBoxTotalPartie"
        Me.ListBoxTotalPartie.Size = New System.Drawing.Size(104, 43)
        Me.ListBoxTotalPartie.TabIndex = 3
        '
        'nameLabel1
        '
        Me.nameLabel1.AutoSize = True
        Me.nameLabel1.Location = New System.Drawing.Point(16, 58)
        Me.nameLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel1.Name = "nameLabel1"
        Me.nameLabel1.Size = New System.Drawing.Size(92, 13)
        Me.nameLabel1.TabIndex = 4
        Me.nameLabel1.Text = "Nom des joueurs :"
        '
        'TimeLabel2
        '
        Me.TimeLabel2.AutoSize = True
        Me.TimeLabel2.Location = New System.Drawing.Point(302, 58)
        Me.TimeLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TimeLabel2.Name = "TimeLabel2"
        Me.TimeLabel2.Size = New System.Drawing.Size(59, 13)
        Me.TimeLabel2.TabIndex = 5
        Me.TimeLabel2.Text = "Best timer :"
        '
        'nbGameLabel3
        '
        Me.nbGameLabel3.AutoSize = True
        Me.nbGameLabel3.Location = New System.Drawing.Point(410, 58)
        Me.nbGameLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nbGameLabel3.Name = "nbGameLabel3"
        Me.nbGameLabel3.Size = New System.Drawing.Size(82, 13)
        Me.nbGameLabel3.TabIndex = 6
        Me.nbGameLabel3.Text = "Total de Partie :"
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeaveButton.Location = New System.Drawing.Point(535, 134)
        Me.LeaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(86, 25)
        Me.LeaveButton.TabIndex = 7
        Me.LeaveButton.Text = "Back to menu"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(518, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Heure de jeu :"
        '
        'ListBoxHeureDeJeu
        '
        Me.ListBoxHeureDeJeu.FormattingEnabled = True
        Me.ListBoxHeureDeJeu.Location = New System.Drawing.Point(518, 74)
        Me.ListBoxHeureDeJeu.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxHeureDeJeu.Name = "ListBoxHeureDeJeu"
        Me.ListBoxHeureDeJeu.Size = New System.Drawing.Size(104, 43)
        Me.ListBoxHeureDeJeu.TabIndex = 8
        '
        'ButtonStatsAvance
        '
        Me.ButtonStatsAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonStatsAvance.Location = New System.Drawing.Point(164, 143)
        Me.ButtonStatsAvance.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonStatsAvance.Name = "ButtonStatsAvance"
        Me.ButtonStatsAvance.Size = New System.Drawing.Size(89, 20)
        Me.ButtonStatsAvance.TabIndex = 10
        Me.ButtonStatsAvance.Text = "Stats Avancé"
        Me.ButtonStatsAvance.UseVisualStyleBackColor = False
        '
        'ButtonTriPseudo
        '
        Me.ButtonTriPseudo.Location = New System.Drawing.Point(124, 74)
        Me.ButtonTriPseudo.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTriPseudo.Name = "ButtonTriPseudo"
        Me.ButtonTriPseudo.Size = New System.Drawing.Size(64, 39)
        Me.ButtonTriPseudo.TabIndex = 11
        Me.ButtonTriPseudo.Text = "Tri Pseudo"
        Me.ButtonTriPseudo.UseVisualStyleBackColor = True
        '
        'ButtonTriTimer
        '
        Me.ButtonTriTimer.Location = New System.Drawing.Point(232, 74)
        Me.ButtonTriTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonTriTimer.Name = "ButtonTriTimer"
        Me.ButtonTriTimer.Size = New System.Drawing.Size(64, 39)
        Me.ButtonTriTimer.TabIndex = 12
        Me.ButtonTriTimer.Text = "Tri Best timer"
        Me.ButtonTriTimer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(251, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Statistique"
        '
        'StatSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(632, 211)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonTriTimer)
        Me.Controls.Add(Me.ButtonTriPseudo)
        Me.Controls.Add(Me.ButtonStatsAvance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxHeureDeJeu)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.nbGameLabel3)
        Me.Controls.Add(Me.TimeLabel2)
        Me.Controls.Add(Me.nameLabel1)
        Me.Controls.Add(Me.ListBoxTotalPartie)
        Me.Controls.Add(Me.ComboBoxName)
        Me.Controls.Add(Me.ListBoxBestTimer)
        Me.Controls.Add(Me.ListBoxName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StatSudoku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxName As ListBox
    Friend WithEvents ListBoxBestTimer As ListBox
    Friend WithEvents ComboBoxName As ComboBox
    Friend WithEvents ListBoxTotalPartie As ListBox
    Friend WithEvents nameLabel1 As Label
    Friend WithEvents TimeLabel2 As Label
    Friend WithEvents nbGameLabel3 As Label
    Friend WithEvents LeaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxHeureDeJeu As ListBox
    Friend WithEvents ButtonStatsAvance As Button
    Friend WithEvents ButtonTriPseudo As Button
    Friend WithEvents ButtonTriTimer As Button
    Friend WithEvents Label2 As Label
End Class
