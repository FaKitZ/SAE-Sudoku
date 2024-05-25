Imports System.IO

Module ModuleJoueur
    Public Structure JOUEUR
        Public Nom As String
        Public BestTemps As TimeSpan
        Public NbGamePlay As Integer
        Public CumulTimmer As TimeSpan
        Public LastGameTime As TimeSpan
    End Structure

    Public Joueurs() As JOUEUR
    Public CheminDossier As String
    Sub New()
        ' Définir CheminDossier à la racine du projet
        CheminDossier = AppDomain.CurrentDomain.BaseDirectory
    End Sub

    Public Sub AjouterJoueur(joueur As JOUEUR)
        Dim taille As Integer = If(Joueurs Is Nothing, 0, Joueurs.Length)
        ReDim Preserve Joueurs(taille)
        Joueurs(taille) = joueur
    End Sub

    Public Function TrouverJoueur(nom As String) As Integer
        If Joueurs IsNot Nothing Then
            For i As Integer = 0 To Joueurs.Length - 1
                If Joueurs(i).Nom = nom Then
                    Return i
                End If
            Next
        End If
        Return -1
    End Function

    Public Sub MettreAJourJoueurSiWin(nom As String, dernierTempsDeJeu As TimeSpan)
        Dim index As Integer = TrouverJoueur(nom)
        If index <> -1 Then
            Joueurs(index).NbGamePlay += 1
            Joueurs(index).CumulTimmer += dernierTempsDeJeu
            Joueurs(index).LastGameTime = dernierTempsDeJeu
            If Joueurs(index).BestTemps = TimeSpan.Zero OrElse dernierTempsDeJeu < Joueurs(index).BestTemps Then
                Joueurs(index).BestTemps = dernierTempsDeJeu
            End If
        End If
    End Sub

    Public Sub MettreAJourJoueurSiLoose(nom As String, dernierTempsDeJeu As TimeSpan)
        Dim index As Integer = TrouverJoueur(nom)
        If index <> -1 Then
            Joueurs(index).NbGamePlay += 1
            Joueurs(index).CumulTimmer += dernierTempsDeJeu
        End If
    End Sub

    Public Sub EnregistrerJoueursDansFichier(nomFichier As String)
        If CheminDossier IsNot Nothing Then
            Dim cheminFichier As String = System.IO.Path.Combine(CheminDossier, nomFichier)
            Dim fileNum As Integer = FreeFile()
            FileOpen(fileNum, cheminFichier, OpenMode.Output)
            If Joueurs IsNot Nothing Then
                For Each joueur In Joueurs
                    PrintLine(fileNum, $"{joueur.Nom},{joueur.BestTemps},{joueur.NbGamePlay},{joueur.CumulTimmer},{joueur.LastGameTime}")
                Next
            End If
            FileClose(fileNum)
        End If
    End Sub

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
                Joueurs = lignes.ToArray()
                FileClose(fileNum)
            End If
        End If
    End Sub

End Module
