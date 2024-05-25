Module ModuleJoueur
    Public Structure JOUEUR
        Public Nom As String
        Public BestTemps As TimeSpan
        Public NbGamePlay As Integer
        Public CumulTimmer As TimeSpan
        Public LastGameTime As TimeSpan
    End Structure

    Public Joueurs() As JOUEUR

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
            Joueurs(index).NbGamePlay = Joueurs(index).NbGamePlay + 1
            Joueurs(index).CumulTimmer += dernierTempsDeJeu
            Joueurs(index).LastGameTime = dernierTempsDeJeu
            ' Mettre à jour le meilleur temps si c'est le cas
            If Joueurs(index).BestTemps = TimeSpan.Zero OrElse dernierTempsDeJeu < Joueurs(index).BestTemps Then
                Joueurs(index).BestTemps = dernierTempsDeJeu
            End If
        End If
    End Sub

    Public Sub MettreAJourJoueurSiLoose(nom As String, dernierTempsDeJeu As TimeSpan)
        Dim index As Integer = TrouverJoueur(nom)
        If index <> -1 Then
            Joueurs(index).NbGamePlay = Joueurs(index).NbGamePlay + 1
            Joueurs(index).CumulTimmer += dernierTempsDeJeu
        End If
    End Sub

    'fichier texte
End Module