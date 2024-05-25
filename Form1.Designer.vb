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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonParametre = New System.Windows.Forms.Button()
        Me.ScoreButton1 = New System.Windows.Forms.Button()
        Me.leaveBoutton = New System.Windows.Forms.Button()
        Me.playButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(94, 20)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(76, 13)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Nom du joueur"
        '
        'nameComboBox1
        '
        Me.nameComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.nameComboBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.nameComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.nameComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nameComboBox1.FormattingEnabled = True
        Me.nameComboBox1.Location = New System.Drawing.Point(81, 35)
        Me.nameComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameComboBox1.Name = "nameComboBox1"
        Me.nameComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.nameComboBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonParametre)
        Me.GroupBox1.Controls.Add(Me.ScoreButton1)
        Me.GroupBox1.Controls.Add(Me.leaveBoutton)
        Me.GroupBox1.Controls.Add(Me.playButton)
        Me.GroupBox1.Controls.Add(Me.nameLabel)
        Me.GroupBox1.Controls.Add(Me.nameComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 38)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(269, 180)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'ButtonParametre
        '
        Me.ButtonParametre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ButtonParametre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonParametre.Location = New System.Drawing.Point(70, 132)
        Me.ButtonParametre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonParametre.MaximumSize = New System.Drawing.Size(75, 28)
        Me.ButtonParametre.Name = "ButtonParametre"
        Me.ButtonParametre.Size = New System.Drawing.Size(64, 28)
        Me.ButtonParametre.TabIndex = 5
        Me.ButtonParametre.Text = "Paramètre"
        Me.ButtonParametre.UseVisualStyleBackColor = True
        '
        'ScoreButton1
        '
        Me.ScoreButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ScoreButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ScoreButton1.Location = New System.Drawing.Point(101, 92)
        Me.ScoreButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ScoreButton1.MaximumSize = New System.Drawing.Size(75, 28)
        Me.ScoreButton1.Name = "ScoreButton1"
        Me.ScoreButton1.Size = New System.Drawing.Size(64, 28)
        Me.ScoreButton1.TabIndex = 4
        Me.ScoreButton1.Text = "Scores"
        Me.ScoreButton1.UseVisualStyleBackColor = True
        '
        'leaveBoutton
        '
        Me.leaveBoutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.leaveBoutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.leaveBoutton.Location = New System.Drawing.Point(139, 132)
        Me.leaveBoutton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.leaveBoutton.MaximumSize = New System.Drawing.Size(75, 28)
        Me.leaveBoutton.Name = "leaveBoutton"
        Me.leaveBoutton.Size = New System.Drawing.Size(64, 28)
        Me.leaveBoutton.TabIndex = 3
        Me.leaveBoutton.Text = "Exit"
        Me.leaveBoutton.UseVisualStyleBackColor = True
        '
        'playButton
        '
        Me.playButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.playButton.Location = New System.Drawing.Point(101, 67)
        Me.playButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.playButton.MaximumSize = New System.Drawing.Size(75, 28)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(64, 28)
        Me.playButton.TabIndex = 2
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(98, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu Sudoku"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(354, 243)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "è"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
