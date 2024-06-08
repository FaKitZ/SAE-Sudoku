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
        Me.LabelNameLstBox = New System.Windows.Forms.Label()
        Me.LabelBestTimer = New System.Windows.Forms.Label()
        Me.LabelNombreGame = New System.Windows.Forms.Label()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.LabelTotalHeure = New System.Windows.Forms.Label()
        Me.ListBoxHeureDeJeu = New System.Windows.Forms.ListBox()
        Me.ButtonStatsAvance = New System.Windows.Forms.Button()
        Me.ButtonTriPseudo = New System.Windows.Forms.Button()
        Me.ButtonTriTimer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxName
        '
        Me.ListBoxName.FormattingEnabled = True
        Me.ListBoxName.Location = New System.Drawing.Point(16, 74)
        Me.ListBoxName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxName.Name = "ListBoxName"
        Me.ListBoxName.Size = New System.Drawing.Size(104, 56)
        Me.ListBoxName.TabIndex = 0
        '
        'ListBoxBestTimer
        '
        Me.ListBoxBestTimer.FormattingEnabled = True
        Me.ListBoxBestTimer.Location = New System.Drawing.Point(302, 74)
        Me.ListBoxBestTimer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxBestTimer.Name = "ListBoxBestTimer"
        Me.ListBoxBestTimer.Size = New System.Drawing.Size(104, 43)
        Me.ListBoxBestTimer.TabIndex = 1
        '
        'ComboBoxName
        '
        Me.ComboBoxName.FormattingEnabled = True
        Me.ComboBoxName.Location = New System.Drawing.Point(16, 134)
        Me.ComboBoxName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxName.Name = "ComboBoxName"
        Me.ComboBoxName.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxName.TabIndex = 2
        '
        'ListBoxTotalPartie
        '
        Me.ListBoxTotalPartie.FormattingEnabled = True
        Me.ListBoxTotalPartie.Location = New System.Drawing.Point(410, 74)
        Me.ListBoxTotalPartie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxTotalPartie.Name = "ListBoxTotalPartie"
        Me.ListBoxTotalPartie.Size = New System.Drawing.Size(104, 43)
        Me.ListBoxTotalPartie.TabIndex = 3
        '
        'LabelNameLstBox
        '
        Me.LabelNameLstBox.AutoSize = True
        Me.LabelNameLstBox.Location = New System.Drawing.Point(16, 58)
        Me.LabelNameLstBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNameLstBox.Name = "LabelNameLstBox"
        Me.LabelNameLstBox.Size = New System.Drawing.Size(92, 13)
        Me.LabelNameLstBox.TabIndex = 4
        Me.LabelNameLstBox.Text = "Nom des joueurs :"
        '
        'LabelBestTimer
        '
        Me.LabelBestTimer.AutoSize = True
        Me.LabelBestTimer.Location = New System.Drawing.Point(302, 58)
        Me.LabelBestTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelBestTimer.Name = "LabelBestTimer"
        Me.LabelBestTimer.Size = New System.Drawing.Size(59, 13)
        Me.LabelBestTimer.TabIndex = 5
        Me.LabelBestTimer.Text = "Best timer :"
        '
        'LabelNombreGame
        '
        Me.LabelNombreGame.AutoSize = True
        Me.LabelNombreGame.Location = New System.Drawing.Point(410, 58)
        Me.LabelNombreGame.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNombreGame.Name = "LabelNombreGame"
        Me.LabelNombreGame.Size = New System.Drawing.Size(82, 13)
        Me.LabelNombreGame.TabIndex = 6
        Me.LabelNombreGame.Text = "Total de Partie :"
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeaveButton.Location = New System.Drawing.Point(535, 134)
        Me.LeaveButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(86, 25)
        Me.LeaveButton.TabIndex = 7
        Me.LeaveButton.Text = "Back to menu"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'LabelTotalHeure
        '
        Me.LabelTotalHeure.AutoSize = True
        Me.LabelTotalHeure.Location = New System.Drawing.Point(518, 58)
        Me.LabelTotalHeure.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalHeure.Name = "LabelTotalHeure"
        Me.LabelTotalHeure.Size = New System.Drawing.Size(74, 13)
        Me.LabelTotalHeure.TabIndex = 9
        Me.LabelTotalHeure.Text = "Heure de jeu :"
        '
        'ListBoxHeureDeJeu
        '
        Me.ListBoxHeureDeJeu.FormattingEnabled = True
        Me.ListBoxHeureDeJeu.Location = New System.Drawing.Point(518, 74)
        Me.ListBoxHeureDeJeu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxHeureDeJeu.Name = "ListBoxHeureDeJeu"
        Me.ListBoxHeureDeJeu.Size = New System.Drawing.Size(104, 43)
        Me.ListBoxHeureDeJeu.TabIndex = 8
        '
        'ButtonStatsAvance
        '
        Me.ButtonStatsAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonStatsAvance.Location = New System.Drawing.Point(164, 143)
        Me.ButtonStatsAvance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonStatsAvance.Name = "ButtonStatsAvance"
        Me.ButtonStatsAvance.Size = New System.Drawing.Size(89, 20)
        Me.ButtonStatsAvance.TabIndex = 10
        Me.ButtonStatsAvance.Text = "Stats Avancé"
        Me.ButtonStatsAvance.UseVisualStyleBackColor = False
        '
        'ButtonTriPseudo
        '
        Me.ButtonTriPseudo.Location = New System.Drawing.Point(124, 74)
        Me.ButtonTriPseudo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonTriPseudo.Name = "ButtonTriPseudo"
        Me.ButtonTriPseudo.Size = New System.Drawing.Size(64, 39)
        Me.ButtonTriPseudo.TabIndex = 11
        Me.ButtonTriPseudo.Text = "Tri Pseudo"
        Me.ButtonTriPseudo.UseVisualStyleBackColor = True
        '
        'ButtonTriTimer
        '
        Me.ButtonTriTimer.Location = New System.Drawing.Point(232, 74)
        Me.ButtonTriTimer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonTriTimer.Name = "ButtonTriTimer"
        Me.ButtonTriTimer.Size = New System.Drawing.Size(64, 39)
        Me.ButtonTriTimer.TabIndex = 12
        Me.ButtonTriTimer.Text = "Tri Best timer"
        Me.ButtonTriTimer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.LabelTitre.Location = New System.Drawing.Point(251, 8)
        Me.LabelTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(125, 32)
        Me.LabelTitre.TabIndex = 14
        Me.LabelTitre.Text = "Statistique"
        '
        'StatSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 211)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonTriTimer)
        Me.Controls.Add(Me.ButtonTriPseudo)
        Me.Controls.Add(Me.ButtonStatsAvance)
        Me.Controls.Add(Me.LabelTotalHeure)
        Me.Controls.Add(Me.ListBoxHeureDeJeu)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.LabelNombreGame)
        Me.Controls.Add(Me.LabelBestTimer)
        Me.Controls.Add(Me.LabelNameLstBox)
        Me.Controls.Add(Me.ListBoxTotalPartie)
        Me.Controls.Add(Me.ComboBoxName)
        Me.Controls.Add(Me.ListBoxBestTimer)
        Me.Controls.Add(Me.ListBoxName)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(648, 249)
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
    Friend WithEvents LabelNameLstBox As Label
    Friend WithEvents LabelBestTimer As Label
    Friend WithEvents LabelNombreGame As Label
    Friend WithEvents LeaveButton As Button
    Friend WithEvents LabelTotalHeure As Label
    Friend WithEvents ListBoxHeureDeJeu As ListBox
    Friend WithEvents ButtonStatsAvance As Button
    Friend WithEvents ButtonTriPseudo As Button
    Friend WithEvents ButtonTriTimer As Button
    Friend WithEvents LabelTitre As Label
End Class
