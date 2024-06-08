<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JeuSudoku
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JeuSudoku))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.LabelPseudo = New System.Windows.Forms.Label()
        Me.LabelPseudoDuJoueur = New System.Windows.Forms.Label()
        Me.leaveButon = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanelGrilleSudoku = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonMusic = New System.Windows.Forms.Button()
        Me.ButtonMusicOFF = New System.Windows.Forms.Button()
        Me.ButtonYoutube = New System.Windows.Forms.Button()
        Me.ButtonNetflix = New System.Windows.Forms.Button()
        Me.ButtonInternet = New System.Windows.Forms.Button()
        Me.ButtonFermeinternet = New System.Windows.Forms.Button()
        Me.ButtonFermeNetflix = New System.Windows.Forms.Button()
        Me.ButtonFermeYoutube = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 420000
        '
        'LabelTimer
        '
        Me.LabelTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Location = New System.Drawing.Point(547, 136)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(67, 13)
        Me.LabelTimer.TabIndex = 1
        Me.LabelTimer.Text = "LabelTimmer"
        '
        'LabelPseudo
        '
        Me.LabelPseudo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPseudo.AutoSize = True
        Me.LabelPseudo.Location = New System.Drawing.Point(547, 99)
        Me.LabelPseudo.Name = "LabelPseudo"
        Me.LabelPseudo.Size = New System.Drawing.Size(69, 13)
        Me.LabelPseudo.TabIndex = 2
        Me.LabelPseudo.Text = "LabelPseudo"
        '
        'LabelPseudoDuJoueur
        '
        Me.LabelPseudoDuJoueur.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPseudoDuJoueur.AutoSize = True
        Me.LabelPseudoDuJoueur.Location = New System.Drawing.Point(547, 65)
        Me.LabelPseudoDuJoueur.Name = "LabelPseudoDuJoueur"
        Me.LabelPseudoDuJoueur.Size = New System.Drawing.Size(96, 13)
        Me.LabelPseudoDuJoueur.TabIndex = 3
        Me.LabelPseudoDuJoueur.Text = "Pseudo du joueur :"
        '
        'leaveButon
        '
        Me.leaveButon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leaveButon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.leaveButon.ForeColor = System.Drawing.Color.Black
        Me.leaveButon.Location = New System.Drawing.Point(547, 242)
        Me.leaveButon.Name = "leaveButon"
        Me.leaveButon.Size = New System.Drawing.Size(91, 29)
        Me.leaveButon.TabIndex = 4
        Me.leaveButon.Text = "Back to menu"
        Me.leaveButon.UseVisualStyleBackColor = False
        '
        'PauseButton
        '
        Me.PauseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PauseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PauseButton.Location = New System.Drawing.Point(547, 187)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(91, 22)
        Me.PauseButton.TabIndex = 5
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = False
        '
        'PlayButton
        '
        Me.PlayButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayButton.Location = New System.Drawing.Point(547, 187)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(91, 22)
        Me.PlayButton.TabIndex = 6
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        Me.PlayButton.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(470, 365)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanelGrilleSudoku
        '
        Me.TableLayoutPanelGrilleSudoku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelGrilleSudoku.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanelGrilleSudoku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanelGrilleSudoku.ColumnCount = 9
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.Location = New System.Drawing.Point(36, 11)
        Me.TableLayoutPanelGrilleSudoku.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanelGrilleSudoku.MaximumSize = New System.Drawing.Size(470, 448)
        Me.TableLayoutPanelGrilleSudoku.MinimumSize = New System.Drawing.Size(470, 441)
        Me.TableLayoutPanelGrilleSudoku.Name = "TableLayoutPanelGrilleSudoku"
        Me.TableLayoutPanelGrilleSudoku.RowCount = 9
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelGrilleSudoku.Size = New System.Drawing.Size(470, 448)
        Me.TableLayoutPanelGrilleSudoku.TabIndex = 10
        '
        'ButtonMusic
        '
        Me.ButtonMusic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMusic.Location = New System.Drawing.Point(547, 215)
        Me.ButtonMusic.Name = "ButtonMusic"
        Me.ButtonMusic.Size = New System.Drawing.Size(91, 23)
        Me.ButtonMusic.TabIndex = 11
        Me.ButtonMusic.Text = "MUSIC ON"
        Me.ButtonMusic.UseVisualStyleBackColor = True
        '
        'ButtonMusicOFF
        '
        Me.ButtonMusicOFF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMusicOFF.Location = New System.Drawing.Point(547, 215)
        Me.ButtonMusicOFF.Name = "ButtonMusicOFF"
        Me.ButtonMusicOFF.Size = New System.Drawing.Size(91, 23)
        Me.ButtonMusicOFF.TabIndex = 0
        Me.ButtonMusicOFF.Text = "MUSIC OFF"
        Me.ButtonMusicOFF.UseVisualStyleBackColor = True
        Me.ButtonMusicOFF.Visible = False
        '
        'ButtonYoutube
        '
        Me.ButtonYoutube.Location = New System.Drawing.Point(133, 505)
        Me.ButtonYoutube.Name = "ButtonYoutube"
        Me.ButtonYoutube.Size = New System.Drawing.Size(91, 25)
        Me.ButtonYoutube.TabIndex = 12
        Me.ButtonYoutube.Text = "Youtube"
        Me.ButtonYoutube.UseVisualStyleBackColor = True
        '
        'ButtonNetflix
        '
        Me.ButtonNetflix.Location = New System.Drawing.Point(230, 505)
        Me.ButtonNetflix.Name = "ButtonNetflix"
        Me.ButtonNetflix.Size = New System.Drawing.Size(91, 25)
        Me.ButtonNetflix.TabIndex = 13
        Me.ButtonNetflix.Text = "Netflix"
        Me.ButtonNetflix.UseVisualStyleBackColor = True
        '
        'ButtonInternet
        '
        Me.ButtonInternet.Location = New System.Drawing.Point(36, 505)
        Me.ButtonInternet.Name = "ButtonInternet"
        Me.ButtonInternet.Size = New System.Drawing.Size(91, 25)
        Me.ButtonInternet.TabIndex = 14
        Me.ButtonInternet.Text = "Internet"
        Me.ButtonInternet.UseVisualStyleBackColor = True
        '
        'ButtonFermeinternet
        '
        Me.ButtonFermeinternet.Location = New System.Drawing.Point(36, 505)
        Me.ButtonFermeinternet.Name = "ButtonFermeinternet"
        Me.ButtonFermeinternet.Size = New System.Drawing.Size(91, 25)
        Me.ButtonFermeinternet.TabIndex = 17
        Me.ButtonFermeinternet.Text = "Ferme Internet"
        Me.ButtonFermeinternet.UseVisualStyleBackColor = True
        Me.ButtonFermeinternet.Visible = False
        '
        'ButtonFermeNetflix
        '
        Me.ButtonFermeNetflix.Location = New System.Drawing.Point(230, 505)
        Me.ButtonFermeNetflix.Name = "ButtonFermeNetflix"
        Me.ButtonFermeNetflix.Size = New System.Drawing.Size(91, 25)
        Me.ButtonFermeNetflix.TabIndex = 16
        Me.ButtonFermeNetflix.Text = "Ferme Netflix"
        Me.ButtonFermeNetflix.UseVisualStyleBackColor = True
        Me.ButtonFermeNetflix.Visible = False
        '
        'ButtonFermeYoutube
        '
        Me.ButtonFermeYoutube.Location = New System.Drawing.Point(133, 505)
        Me.ButtonFermeYoutube.Name = "ButtonFermeYoutube"
        Me.ButtonFermeYoutube.Size = New System.Drawing.Size(91, 25)
        Me.ButtonFermeYoutube.TabIndex = 15
        Me.ButtonFermeYoutube.Text = "FermeYoutube"
        Me.ButtonFermeYoutube.UseVisualStyleBackColor = True
        Me.ButtonFermeYoutube.Visible = False
        '
        'JeuSudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 581)
        Me.Controls.Add(Me.ButtonFermeinternet)
        Me.Controls.Add(Me.ButtonFermeNetflix)
        Me.Controls.Add(Me.ButtonFermeYoutube)
        Me.Controls.Add(Me.ButtonInternet)
        Me.Controls.Add(Me.ButtonNetflix)
        Me.Controls.Add(Me.ButtonYoutube)
        Me.Controls.Add(Me.ButtonMusicOFF)
        Me.Controls.Add(Me.ButtonMusic)
        Me.Controls.Add(Me.TableLayoutPanelGrilleSudoku)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.leaveButon)
        Me.Controls.Add(Me.LabelPseudoDuJoueur)
        Me.Controls.Add(Me.LabelPseudo)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(697, 620)
        Me.Name = "JeuSudoku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents LabelPseudo As Label
    Friend WithEvents LabelPseudoDuJoueur As Label
    Friend WithEvents leaveButon As Button
    Friend WithEvents PauseButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanelGrilleSudoku As TableLayoutPanel
    Friend WithEvents ButtonMusic As Button
    Friend WithEvents ButtonMusicOFF As Button
    Friend WithEvents ButtonYoutube As Button
    Friend WithEvents ButtonNetflix As Button
    Friend WithEvents ButtonInternet As Button
    Friend WithEvents ButtonFermeinternet As Button
    Friend WithEvents ButtonFermeNetflix As Button
    Friend WithEvents ButtonFermeYoutube As Button
End Class
