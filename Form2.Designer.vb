<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.LabelPseudo = New System.Windows.Forms.Label()
        Me.pseudoLabel = New System.Windows.Forms.Label()
        Me.leaveButon = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanelNew = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 420000
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Location = New System.Drawing.Point(511, 101)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(67, 13)
        Me.LabelTimer.TabIndex = 1
        Me.LabelTimer.Text = "LabelTimmer"
        '
        'LabelPseudo
        '
        Me.LabelPseudo.AutoSize = True
        Me.LabelPseudo.Location = New System.Drawing.Point(511, 64)
        Me.LabelPseudo.Name = "LabelPseudo"
        Me.LabelPseudo.Size = New System.Drawing.Size(69, 13)
        Me.LabelPseudo.TabIndex = 2
        Me.LabelPseudo.Text = "LabelPseudo"
        '
        'pseudoLabel
        '
        Me.pseudoLabel.AutoSize = True
        Me.pseudoLabel.Location = New System.Drawing.Point(511, 30)
        Me.pseudoLabel.Name = "pseudoLabel"
        Me.pseudoLabel.Size = New System.Drawing.Size(96, 13)
        Me.pseudoLabel.TabIndex = 3
        Me.pseudoLabel.Text = "Pseudo du joueur :"
        '
        'leaveButon
        '
        Me.leaveButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.leaveButon.ForeColor = System.Drawing.Color.Black
        Me.leaveButon.Location = New System.Drawing.Point(511, 207)
        Me.leaveButon.Name = "leaveButon"
        Me.leaveButon.Size = New System.Drawing.Size(91, 29)
        Me.leaveButon.TabIndex = 4
        Me.leaveButon.Text = "Back to menu"
        Me.leaveButon.UseVisualStyleBackColor = False
        '
        'PauseButton
        '
        Me.PauseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PauseButton.Location = New System.Drawing.Point(511, 139)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(64, 22)
        Me.PauseButton.TabIndex = 5
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = False
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayButton.Location = New System.Drawing.Point(511, 173)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(64, 22)
        Me.PlayButton.TabIndex = 6
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanelNew
        '
        Me.TableLayoutPanelNew.ColumnCount = 9
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanelNew.Name = "TableLayoutPanelNew"
        Me.TableLayoutPanelNew.RowCount = 9
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanelNew.Size = New System.Drawing.Size(452, 463)
        Me.TableLayoutPanelNew.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(650, 580)
        Me.Controls.Add(Me.TableLayoutPanelNew)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.leaveButon)
        Me.Controls.Add(Me.pseudoLabel)
        Me.Controls.Add(Me.LabelPseudo)
        Me.Controls.Add(Me.LabelTimer)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents LabelPseudo As Label
    Friend WithEvents pseudoLabel As Label
    Friend WithEvents leaveButon As Button
    Friend WithEvents PauseButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents TableLayoutPanelNew As TableLayoutPanel
End Class
