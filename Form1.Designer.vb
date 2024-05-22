<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        nameLabel = New Label()
        nameComboBox1 = New ComboBox()
        GroupBox1 = New GroupBox()
        ButtonParametre = New Button()
        ScoreButton1 = New Button()
        leaveBoutton = New Button()
        playButton = New Button()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(20, 25)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(88, 15)
        nameLabel.TabIndex = 0
        nameLabel.Text = "Nom du joueur"
        ' 
        ' nameComboBox1
        ' 
        nameComboBox1.BackColor = SystemColors.ActiveBorder
        nameComboBox1.FormattingEnabled = True
        nameComboBox1.Location = New Point(160, 22)
        nameComboBox1.Name = "nameComboBox1"
        nameComboBox1.Size = New Size(121, 23)
        nameComboBox1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ButtonParametre)
        GroupBox1.Controls.Add(ScoreButton1)
        GroupBox1.Controls.Add(leaveBoutton)
        GroupBox1.Controls.Add(playButton)
        GroupBox1.Controls.Add(nameLabel)
        GroupBox1.Controls.Add(nameComboBox1)
        GroupBox1.Location = New Point(46, 44)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(314, 185)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' ButtonParametre
        ' 
        ButtonParametre.Location = New Point(34, 124)
        ButtonParametre.Name = "ButtonParametre"
        ButtonParametre.Size = New Size(75, 23)
        ButtonParametre.TabIndex = 5
        ButtonParametre.Text = "Paramètre"
        ButtonParametre.UseVisualStyleBackColor = True
        ' 
        ' ScoreButton1
        ' 
        ScoreButton1.Location = New Point(34, 73)
        ScoreButton1.Name = "ScoreButton1"
        ScoreButton1.Size = New Size(74, 23)
        ScoreButton1.TabIndex = 4
        ScoreButton1.Text = "Scores"
        ScoreButton1.UseVisualStyleBackColor = True
        ' 
        ' leaveBoutton
        ' 
        leaveBoutton.Location = New Point(197, 124)
        leaveBoutton.Name = "leaveBoutton"
        leaveBoutton.Size = New Size(75, 23)
        leaveBoutton.TabIndex = 3
        leaveBoutton.Text = "Exit"
        leaveBoutton.UseVisualStyleBackColor = True
        ' 
        ' playButton
        ' 
        playButton.Location = New Point(197, 73)
        playButton.Name = "playButton"
        playButton.Size = New Size(75, 23)
        playButton.TabIndex = 2
        playButton.Text = "Play"
        playButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(114, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 32)
        Label1.TabIndex = 3
        Label1.Text = "Menu Sudoku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(413, 280)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents nameComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents playButton As Button
    Friend WithEvents leaveBoutton As Button
    Friend WithEvents ScoreButton1 As Button
    Friend WithEvents ButtonParametre As Button
    Friend WithEvents Label1 As Label

End Class
