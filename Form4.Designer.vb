﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.ChangeTimerButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.ButtonDarkMode = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadioButtonHard = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDifficulte = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBoxMap = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDifficulte.SuspendLayout()
        Me.GroupBoxMap.SuspendLayout()
        Me.SuspendLayout()
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LeaveButton.Location = New System.Drawing.Point(499, 222)
        Me.LeaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(181, 25)
        Me.LeaveButton.TabIndex = 8
        Me.LeaveButton.Text = "Back to menu"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Temps (defaut 7min) : "
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(19, 31)
        Me.RadioButtonFacile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(65, 20)
        Me.RadioButtonFacile.TabIndex = 12
        Me.RadioButtonFacile.TabStop = True
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'RadioButtonMoyen
        '
        Me.RadioButtonMoyen.AutoSize = True
        Me.RadioButtonMoyen.Location = New System.Drawing.Point(91, 31)
        Me.RadioButtonMoyen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonMoyen.Name = "RadioButtonMoyen"
        Me.RadioButtonMoyen.Size = New System.Drawing.Size(69, 20)
        Me.RadioButtonMoyen.TabIndex = 13
        Me.RadioButtonMoyen.TabStop = True
        Me.RadioButtonMoyen.Text = "moyen"
        Me.RadioButtonMoyen.UseVisualStyleBackColor = True
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(165, 31)
        Me.RadioButtonDifficile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(71, 20)
        Me.RadioButtonDifficile.TabIndex = 14
        Me.RadioButtonDifficile.TabStop = True
        Me.RadioButtonDifficile.Text = "Difficile"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = True
        '
        'ChangeTimerButton
        '
        Me.ChangeTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChangeTimerButton.Location = New System.Drawing.Point(197, 73)
        Me.ChangeTimerButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChangeTimerButton.Name = "ChangeTimerButton"
        Me.ChangeTimerButton.Size = New System.Drawing.Size(75, 33)
        Me.ChangeTimerButton.TabIndex = 15
        Me.ChangeTimerButton.Text = "Changer"
        Me.ChangeTimerButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(267, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 43)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Paramètres"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Location = New System.Drawing.Point(24, 22)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(69, 20)
        Me.RadioButton4.TabIndex = 19
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RIVER"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(99, 22)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(70, 20)
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
        Me.ButtonDarkMode.Location = New System.Drawing.Point(329, 194)
        Me.ButtonDarkMode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDarkMode.Name = "ButtonDarkMode"
        Me.ButtonDarkMode.Size = New System.Drawing.Size(69, 52)
        Me.ButtonDarkMode.TabIndex = 21
        Me.ButtonDarkMode.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(500, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Choix du dossier info stats :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 116)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 31)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Chemin du dossier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(499, 162)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 30)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Charger une save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RadioButtonHard
        '
        Me.RadioButtonHard.AutoSize = True
        Me.RadioButtonHard.Location = New System.Drawing.Point(249, 31)
        Me.RadioButtonHard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButtonHard.Name = "RadioButtonHard"
        Me.RadioButtonHard.Size = New System.Drawing.Size(116, 20)
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
        Me.GroupBoxDifficulte.Location = New System.Drawing.Point(45, 110)
        Me.GroupBoxDifficulte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxDifficulte.Name = "GroupBoxDifficulte"
        Me.GroupBoxDifficulte.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxDifficulte.Size = New System.Drawing.Size(383, 71)
        Me.GroupBoxDifficulte.TabIndex = 26
        Me.GroupBoxDifficulte.TabStop = False
        Me.GroupBoxDifficulte.Text = "Difficulte"
        '
        'GroupBoxMap
        '
        Me.GroupBoxMap.Controls.Add(Me.RadioButton5)
        Me.GroupBoxMap.Controls.Add(Me.RadioButton4)
        Me.GroupBoxMap.Location = New System.Drawing.Point(45, 188)
        Me.GroupBoxMap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxMap.Name = "GroupBoxMap"
        Me.GroupBoxMap.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxMap.Size = New System.Drawing.Size(212, 58)
        Me.GroupBoxMap.TabIndex = 27
        Me.GroupBoxMap.TabStop = False
        Me.GroupBoxMap.Text = "Map"
        '
        'ParametreSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 290)
        Me.Controls.Add(Me.GroupBoxMap)
        Me.Controls.Add(Me.GroupBoxDifficulte)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChangeTimerButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.ButtonDarkMode)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(743, 328)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents RadioButtonMoyen As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents ChangeTimerButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents ButtonDarkMode As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButtonHard As RadioButton
    Friend WithEvents GroupBoxDifficulte As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBoxMap As GroupBox
End Class
