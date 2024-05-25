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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.nameLabel1 = New System.Windows.Forms.Label()
        Me.TimeLabel2 = New System.Windows.Forms.Label()
        Me.nbGameLabel3 = New System.Windows.Forms.Label()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ButtonStatsAvance = New System.Windows.Forms.Button()
        Me.ButtonTriPseudo = New System.Windows.Forms.Button()
        Me.ButtonTriTimer = New System.Windows.Forms.Button()
        Me.ButtonRemiseà0 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(21, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 68)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(402, 91)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(137, 52)
        Me.ListBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(19, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(546, 91)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(137, 52)
        Me.ListBox3.TabIndex = 3
        '
        'nameLabel1
        '
        Me.nameLabel1.AutoSize = True
        Me.nameLabel1.Location = New System.Drawing.Point(21, 71)
        Me.nameLabel1.Name = "nameLabel1"
        Me.nameLabel1.Size = New System.Drawing.Size(115, 16)
        Me.nameLabel1.TabIndex = 4
        Me.nameLabel1.Text = "Nom des joueurs :"
        '
        'TimeLabel2
        '
        Me.TimeLabel2.AutoSize = True
        Me.TimeLabel2.Location = New System.Drawing.Point(402, 71)
        Me.TimeLabel2.Name = "TimeLabel2"
        Me.TimeLabel2.Size = New System.Drawing.Size(72, 16)
        Me.TimeLabel2.TabIndex = 5
        Me.TimeLabel2.Text = "Best timer :"
        '
        'nbGameLabel3
        '
        Me.nbGameLabel3.AutoSize = True
        Me.nbGameLabel3.Location = New System.Drawing.Point(546, 71)
        Me.nbGameLabel3.Name = "nbGameLabel3"
        Me.nbGameLabel3.Size = New System.Drawing.Size(101, 16)
        Me.nbGameLabel3.TabIndex = 6
        Me.nbGameLabel3.Text = "Total de Partie :"
        '
        'LeaveButton
        '
        Me.LeaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LeaveButton.Location = New System.Drawing.Point(713, 165)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(114, 31)
        Me.LeaveButton.TabIndex = 7
        Me.LeaveButton.Text = "Back to menu"
        Me.LeaveButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(690, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Heure de jeu :"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 16
        Me.ListBox4.Location = New System.Drawing.Point(690, 91)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(137, 52)
        Me.ListBox4.TabIndex = 8
        '
        'ButtonStatsAvance
        '
        Me.ButtonStatsAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonStatsAvance.Location = New System.Drawing.Point(219, 176)
        Me.ButtonStatsAvance.Name = "ButtonStatsAvance"
        Me.ButtonStatsAvance.Size = New System.Drawing.Size(119, 25)
        Me.ButtonStatsAvance.TabIndex = 10
        Me.ButtonStatsAvance.Text = "Stats Avancé"
        Me.ButtonStatsAvance.UseVisualStyleBackColor = False
        '
        'ButtonTriPseudo
        '
        Me.ButtonTriPseudo.Location = New System.Drawing.Point(165, 91)
        Me.ButtonTriPseudo.Name = "ButtonTriPseudo"
        Me.ButtonTriPseudo.Size = New System.Drawing.Size(86, 48)
        Me.ButtonTriPseudo.TabIndex = 11
        Me.ButtonTriPseudo.Text = "Tri Pseudo"
        Me.ButtonTriPseudo.UseVisualStyleBackColor = True
        '
        'ButtonTriTimer
        '
        Me.ButtonTriTimer.Location = New System.Drawing.Point(310, 91)
        Me.ButtonTriTimer.Name = "ButtonTriTimer"
        Me.ButtonTriTimer.Size = New System.Drawing.Size(86, 48)
        Me.ButtonTriTimer.TabIndex = 12
        Me.ButtonTriTimer.Text = "Tri Best timer"
        Me.ButtonTriTimer.UseVisualStyleBackColor = True
        '
        'ButtonRemiseà0
        '
        Me.ButtonRemiseà0.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonRemiseà0.Location = New System.Drawing.Point(238, 145)
        Me.ButtonRemiseà0.Name = "ButtonRemiseà0"
        Me.ButtonRemiseà0.Size = New System.Drawing.Size(86, 25)
        Me.ButtonRemiseà0.TabIndex = 13
        Me.ButtonRemiseà0.Text = "Remise à 0"
        Me.ButtonRemiseà0.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(335, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 41)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Statistique"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(843, 260)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonRemiseà0)
        Me.Controls.Add(Me.ButtonTriTimer)
        Me.Controls.Add(Me.ButtonTriPseudo)
        Me.Controls.Add(Me.ButtonStatsAvance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.nbGameLabel3)
        Me.Controls.Add(Me.TimeLabel2)
        Me.Controls.Add(Me.nameLabel1)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
