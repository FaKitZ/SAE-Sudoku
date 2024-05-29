Module ModuleJoueur
    Public Structure JOUEUR
        Public Nom As String
        Public BestTemps As TimeSpan
        Public NbGamePlay As Integer
        Public CumulTimmer As TimeSpan
        Public LastGameTime As TimeSpan
    End Structure

    Private TableauJoueurs() As JOUEUR
    Public CheminDossier As String
    Sub New()
        ' Définir CheminDossier à la racine du projet
        CheminDossier = AppDomain.CurrentDomain.BaseDirectory
    End Sub

    'Ajoute un joueur dans le Tableau
    Public Sub AjouterJoueur(joueur As JOUEUR)
        Dim taille As Integer = If(TableauJoueurs Is Nothing, 0, TableauJoueurs.Length)
        ReDim Preserve TableauJoueurs(taille)
        TableauJoueurs(taille) = joueur
    End Sub

    'Trouve un joueur dans le Tableau
    Public Function TrouverJoueur(nom As String) As Integer
        If TableauJoueurs IsNot Nothing Then
            For i As Integer = 0 To TableauJoueurs.Length - 1
                If TableauJoueurs(i).Nom = nom Then
                    Return i
                End If
            Next
        End If
        Return -1
    End Function

    'Met à jours les stats d'un joueurs s'il gagne une partie
    Public Sub MettreAJourJoueurSiWin(nom As String, dernierTempsDeJeu As TimeSpan)
        Dim index As Integer = TrouverJoueur(nom)
        If index <> -1 Then
            TableauJoueurs(index).NbGamePlay += 1
            TableauJoueurs(index).CumulTimmer += dernierTempsDeJeu
            TableauJoueurs(index).LastGameTime = dernierTempsDeJeu
            If TableauJoueurs(index).BestTemps = TimeSpan.Zero OrElse dernierTempsDeJeu < TableauJoueurs(index).BestTemps Then
                TableauJoueurs(index).BestTemps = dernierTempsDeJeu
            End If
        End If
    End Sub
    'Met à jours les stats d'un joueurs s'il perd une partie
    Public Sub MettreAJourJoueurSiLoose(nom As String, dernierTempsDeJeu As TimeSpan)
        Dim index As Integer = TrouverJoueur(nom)
        If index <> -1 Then
            TableauJoueurs(index).NbGamePlay += 1
            TableauJoueurs(index).CumulTimmer += dernierTempsDeJeu
        End If
    End Sub

    'Enregistre un joueurs dans un bloc note
    Public Sub EnregistrerJoueursDansFichier(nomFichier As String)
        If CheminDossier IsNot Nothing Then
            Dim cheminFichier As String = System.IO.Path.Combine(CheminDossier, nomFichier)
            Dim fileNum As Integer = FreeFile()
            FileOpen(fileNum, cheminFichier, OpenMode.Output)
            If TableauJoueurs IsNot Nothing Then
                For Each joueur In TableauJoueurs
                    PrintLine(fileNum, $"{joueur.Nom},{joueur.BestTemps},{joueur.NbGamePlay},{joueur.CumulTimmer},{joueur.LastGameTime}")
                Next
            End If
            FileClose(fileNum)
        End If
    End Sub

    'Charge une save depuis un bloc note
    Public Sub ChargerJoueursDepuisFichier(nomFichier As String)
        If CheminDossier IsNot Nothing Then
            Dim cheminFichier As String = System.IO.Path.Combine(CheminDossier, nomFichier)
            If Dir(cheminFichier) <> "" Then
                Dim fileNum As Integer = FreeFile()
                FileOpen(fileNum, cheminFichier, OpenMode.Input)
                Dim lignes As New List(Of JOUEUR)
                While Not EOF(fileNum)
                    Dim ligne As String = LineInput(fileNum)
                    Dim parties() As String = ligne.Split(","c)
                    If parties.Length = 5 Then
                        Dim joueur As New JOUEUR With {
                            .Nom = parties(0),
                            .BestTemps = TimeSpan.Parse(parties(1)),
                            .NbGamePlay = Integer.Parse(parties(2)),
                            .CumulTimmer = TimeSpan.Parse(parties(3)),
                            .LastGameTime = TimeSpan.Parse(parties(4))
                        }
                        lignes.Add(joueur)
                    End If
                End While
                TableauJoueurs = lignes.ToArray()
                FileClose(fileNum)
            End If
        End If
    End Sub

    'Méthode général qui charge les ListeBox des stats
    Public Sub LoadData()
        StatSudoku.ListBoxName.Items.Clear()
        StatSudoku.ComboBoxName.Items.Clear()
        StatSudoku.ListBoxBestTimer.Items.Clear()
        StatSudoku.ListBoxTotalPartie.Items.Clear()
        StatSudoku.ListBoxHeureDeJeu.Items.Clear()

        If TableauJoueurs IsNot Nothing Then
            TableauJoueurs = TableauJoueurs.ToArray()
            For Each joueur As JOUEUR In TableauJoueurs
                StatSudoku.ListBoxName.Items.Add(joueur.Nom)
                StatSudoku.ComboBoxName.Items.Add(joueur.Nom)
                StatSudoku.ListBoxTotalPartie.Items.Add(joueur.NbGamePlay.ToString())
                StatSudoku.ListBoxBestTimer.Items.Add(joueur.BestTemps.ToString("mm\:ss"))
                StatSudoku.ListBoxHeureDeJeu.Items.Add(joueur.CumulTimmer.ToString("hh\:mm\:ss"))
            Next
        End If
    End Sub

    Public Sub TriPseudo()
        If TableauJoueurs IsNot Nothing Then
            TableauJoueurs = TableauJoueurs.OrderBy(Function(j) j.Nom).ToArray()
            LoadData()
        End If
    End Sub

    Public Sub TriBestTimer()
        If TableauJoueurs IsNot Nothing Then
            TableauJoueurs = TableauJoueurs.OrderBy(Function(j) j.BestTemps).ToArray()
            LoadData()
        End If
    End Sub

End Module
