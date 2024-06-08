<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametreSudoku
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParametreSudoku))
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.LabelChangeTimer = New System.Windows.Forms.Label()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.ChangeTimerButton = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.ButtonDarkMode = New System.Windows.Forms.Button()
        Me.LabelChoixDossier = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonCheminDossier = New System.Windows.Forms.Button()
        Me.ButtonCheminChargerSave = New System.Windows.Forms.Button()
        Me.RadioButtonHard = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDifficulte = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBoxMap = New System.Windows.Forms.GroupBox()
        Me.RadioButtonMapDefaut = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDifficulte.SuspendLayout()
        Me.GroupBoxMap.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LeaveButton.Location = New System.Drawing.Point(374, 180)
        Me.LeaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(136, 20)
        Me.LeaveButton.TabIndex = 8
        Me.LeaveButton.Text = "Back to menu"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'LabelChangeTimer
        '
        Me.LabelChangeTimer.AutoSize = True
        Me.LabelChangeTimer.Location = New System.Drawing.Point(31, 66)
        Me.LabelChangeTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelChangeTimer.Name = "LabelChangeTimer"
        Me.LabelChangeTimer.Size = New System.Drawing.Size(112, 13)
        Me.LabelChangeTimer.TabIndex = 9
        Me.LabelChangeTimer.Text = "Temps (defaut 7min) : "
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(14, 25)
        Me.RadioButtonFacile.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(53, 17)
        Me.RadioButtonFacile.TabIndex = 12
        Me.RadioButtonFacile.TabStop = True
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'RadioButtonMoyen
        '
        Me.RadioButtonMoyen.AutoSize = True
        Me.RadioButtonMoyen.Location = New System.Drawing.Point(68, 25)
        Me.RadioButtonMoyen.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonMoyen.Name = "RadioButtonMoyen"
        Me.RadioButtonMoyen.Size = New System.Drawing.Size(56, 17)
        Me.RadioButtonMoyen.TabIndex = 13
        Me.RadioButtonMoyen.TabStop = True
        Me.RadioButtonMoyen.Text = "moyen"
        Me.RadioButtonMoyen.UseVisualStyleBackColor = True
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(124, 25)
        Me.RadioButtonDifficile.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDifficile.TabIndex = 14
        Me.RadioButtonDifficile.TabStop = True
        Me.RadioButtonDifficile.Text = "Difficile"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = True
        '
        'ChangeTimerButton
        '
        Me.ChangeTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeTimerButton.Location = New System.Drawing.Point(148, 59)
        Me.ChangeTimerButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ChangeTimerButton.Name = "ChangeTimerButton"
        Me.ChangeTimerButton.Size = New System.Drawing.Size(56, 27)
        Me.ChangeTimerButton.TabIndex = 15
        Me.ChangeTimerButton.Text = "Changer"
        Me.ChangeTimerButton.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTitre.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.LabelTitre.Location = New System.Drawing.Point(200, 9)
        Me.LabelTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(133, 34)
        Me.LabelTitre.TabIndex = 17
        Me.LabelTitre.Text = "Paramètres"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Location = New System.Drawing.Point(18, 18)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton4.TabIndex = 19
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RIVER"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(74, 18)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton5.TabIndex = 20
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "SNOW"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'ButtonDarkMode
        '
        Me.ButtonDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDarkMode.BackgroundImage = CType(resources.GetObject("ButtonDarkMode.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDarkMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonDarkMode.Location = New System.Drawing.Point(247, 158)
        Me.ButtonDarkMode.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDarkMode.Name = "ButtonDarkMode"
        Me.ButtonDarkMode.Size = New System.Drawing.Size(52, 42)
        Me.ButtonDarkMode.TabIndex = 21
        Me.ButtonDarkMode.UseVisualStyleBackColor = False
        '
        'LabelChoixDossier
        '
        Me.LabelChoixDossier.AutoSize = True
        Me.LabelChoixDossier.Location = New System.Drawing.Point(375, 66)
        Me.LabelChoixDossier.Name = "LabelChoixDossier"
        Me.LabelChoixDossier.Size = New System.Drawing.Size(135, 13)
        Me.LabelChoixDossier.TabIndex = 22
        Me.LabelChoixDossier.Text = "Choix du dossier info stats :"
        '
        'ButtonCheminDossier
        '
        Me.ButtonCheminDossier.Location = New System.Drawing.Point(374, 94)
        Me.ButtonCheminDossier.Name = "ButtonCheminDossier"
        Me.ButtonCheminDossier.Size = New System.Drawing.Size(136, 25)
        Me.ButtonCheminDossier.TabIndex = 23
        Me.ButtonCheminDossier.Text = "Chemin du dossier"
        Me.ButtonCheminDossier.UseVisualStyleBackColor = True
        '
        'ButtonCheminChargerSave
        '
        Me.ButtonCheminChargerSave.Location = New System.Drawing.Point(374, 132)
        Me.ButtonCheminChargerSave.Name = "ButtonCheminChargerSave"
        Me.ButtonCheminChargerSave.Size = New System.Drawing.Size(136, 24)
        Me.ButtonCheminChargerSave.TabIndex = 24
        Me.ButtonCheminChargerSave.Text = "Charger une save"
        Me.ButtonCheminChargerSave.UseVisualStyleBackColor = True
        '
        'RadioButtonHard
        '
        Me.RadioButtonHard.AutoSize = True
        Me.RadioButtonHard.Location = New System.Drawing.Point(187, 25)
        Me.RadioButtonHard.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonHard.Name = "RadioButtonHard"
        Me.RadioButtonHard.Size = New System.Drawing.Size(95, 17)
        Me.RadioButtonHard.TabIndex = 25
        Me.RadioButtonHard.TabStop = True
        Me.RadioButtonHard.Text = "Paix à ton âme"
        Me.RadioButtonHard.UseVisualStyleBackColor = True
        '
        'GroupBoxDifficulte
        '
        Me.GroupBoxDifficulte.Controls.Add(Me.RadioButtonHard)
        Me.GroupBoxDifficulte.Controls.Add(Me.RadioButtonFacile)
        Me.GroupBoxDifficulte.Controls.Add(Me.RadioButtonMoyen)
        Me.GroupBoxDifficulte.Controls.Add(Me.RadioButtonDifficile)
        Me.GroupBoxDifficulte.Location = New System.Drawing.Point(34, 89)
        Me.GroupBoxDifficulte.Name = "GroupBoxDifficulte"
        Me.GroupBoxDifficulte.Size = New System.Drawing.Size(287, 58)
        Me.GroupBoxDifficulte.TabIndex = 26
        Me.GroupBoxDifficulte.TabStop = False
        Me.GroupBoxDifficulte.Text = "Difficulte"
        '
        'GroupBoxMap
        '
        Me.GroupBoxMap.Controls.Add(Me.RadioButtonMapDefaut)
        Me.GroupBoxMap.Controls.Add(Me.RadioButton5)
        Me.GroupBoxMap.Controls.Add(Me.RadioButton4)
        Me.GroupBoxMap.Location = New System.Drawing.Point(34, 153)
        Me.GroupBoxMap.Name = "GroupBoxMap"
        Me.GroupBoxMap.Size = New System.Drawing.Size(208, 47)
        Me.GroupBoxMap.TabIndex = 27
        Me.GroupBoxMap.TabStop = False
        Me.GroupBoxMap.Text = "Map"
        '
        'RadioButtonMapDefaut
        '
        Me.RadioButtonMapDefaut.AutoSize = True
        Me.RadioButtonMapDefaut.Location = New System.Drawing.Point(135, 18)
        Me.RadioButtonMapDefaut.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonMapDefaut.Name = "RadioButtonMapDefaut"
        Me.RadioButtonMapDefaut.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonMapDefaut.TabIndex = 21
        Me.RadioButtonMapDefaut.TabStop = True
        Me.RadioButtonMapDefaut.Text = "DEFAUT"
        Me.RadioButtonMapDefaut.UseVisualStyleBackColor = True
        '
        'ParametreSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(546, 236)
        Me.Controls.Add(Me.GroupBoxMap)
        Me.Controls.Add(Me.GroupBoxDifficulte)
        Me.Controls.Add(Me.ButtonCheminChargerSave)
        Me.Controls.Add(Me.ButtonCheminDossier)
        Me.Controls.Add(Me.LabelChoixDossier)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ChangeTimerButton)
        Me.Controls.Add(Me.LabelChangeTimer)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.ButtonDarkMode)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(561, 274)
        Me.Name = "ParametreSudoku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        Me.GroupBoxDifficulte.ResumeLayout(False)
        Me.GroupBoxDifficulte.PerformLayout()
        Me.GroupBoxMap.ResumeLayout(False)
        Me.GroupBoxMap.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeaveButton As Button
    Friend WithEvents LabelChangeTimer As Label
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents RadioButtonMoyen As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents ChangeTimerButton As Button
    Friend WithEvents LabelTitre As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents ButtonDarkMode As Button
    Friend WithEvents LabelChoixDossier As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonCheminDossier As Button
    Friend WithEvents ButtonCheminChargerSave As Button
    Friend WithEvents RadioButtonHard As RadioButton
    Friend WithEvents GroupBoxDifficulte As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBoxMap As GroupBox
    Friend WithEvents RadioButtonMapDefaut As RadioButton
End Class
