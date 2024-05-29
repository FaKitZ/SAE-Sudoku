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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.ChangeTimerButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RadioButtonHard = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LeaveButton.Location = New System.Drawing.Point(80, 235)
        Me.LeaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(125, 20)
        Me.LeaveButton.TabIndex = 8
        Me.LeaveButton.Text = "Back to menu"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Temps (defaut 7min) : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Difficulté :"
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.Location = New System.Drawing.Point(94, 103)
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
        Me.RadioButtonMoyen.Location = New System.Drawing.Point(148, 103)
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
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(204, 103)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(177, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 34)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Paramètres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Map :"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Location = New System.Drawing.Point(121, 135)
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
        Me.RadioButton5.Location = New System.Drawing.Point(177, 135)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton5.TabIndex = 20
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "SNOW"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(113, 167)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 42)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Choix du dossier info stats :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 25)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Chemin du dossier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(293, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 24)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Charger une save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RadioButtonHard
        '
        Me.RadioButtonHard.AutoSize = True
        Me.RadioButtonHard.Location = New System.Drawing.Point(267, 105)
        Me.RadioButtonHard.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonHard.Name = "RadioButtonHard"
        Me.RadioButtonHard.Size = New System.Drawing.Size(95, 17)
        Me.RadioButtonHard.TabIndex = 25
        Me.RadioButtonHard.TabStop = True
        Me.RadioButtonHard.Text = "Paix à ton âme"
        Me.RadioButtonHard.UseVisualStyleBackColor = True
        '
        'ParametreSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(492, 284)
        Me.Controls.Add(Me.RadioButtonHard)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChangeTimerButton)
        Me.Controls.Add(Me.RadioButtonDifficile)
        Me.Controls.Add(Me.RadioButtonMoyen)
        Me.Controls.Add(Me.RadioButtonFacile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ParametreSudoku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LeaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents RadioButtonMoyen As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents ChangeTimerButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButtonHard As RadioButton
End Class
