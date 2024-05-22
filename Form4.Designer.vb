<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        LeaveButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        ChangeTimerButton = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' LeaveButton
        ' 
        LeaveButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        LeaveButton.Location = New Point(104, 227)
        LeaveButton.Name = "LeaveButton"
        LeaveButton.Size = New Size(123, 23)
        LeaveButton.TabIndex = 8
        LeaveButton.Text = "Back to menu"
        LeaveButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 9
        Label1.Text = "Temps :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 10
        Label2.Text = "(defaut 7min)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 11
        Label3.Text = "Difficulté :"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(132, 122)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(55, 19)
        RadioButton1.TabIndex = 12
        RadioButton1.TabStop = True
        RadioButton1.Text = "Facile"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(132, 147)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 19)
        RadioButton2.TabIndex = 13
        RadioButton2.TabStop = True
        RadioButton2.Text = "moyen"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(132, 172)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(65, 19)
        RadioButton3.TabIndex = 14
        RadioButton3.TabStop = True
        RadioButton3.Text = "Difficile"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' ChangeTimerButton
        ' 
        ChangeTimerButton.Location = New Point(132, 61)
        ChangeTimerButton.Name = "ChangeTimerButton"
        ChangeTimerButton.Size = New Size(65, 31)
        ChangeTimerButton.TabIndex = 15
        ChangeTimerButton.Text = "Changer"
        ChangeTimerButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Segoe UI", 18F)
        Label5.Location = New Point(104, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 34)
        Label5.TabIndex = 17
        Label5.Text = "Paramètre"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(327, 319)
        Controls.Add(Label5)
        Controls.Add(ChangeTimerButton)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LeaveButton)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LeaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ChangeTimerButton As Button
    Friend WithEvents Label5 As Label
End Class
