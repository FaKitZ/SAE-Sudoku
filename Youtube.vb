Public Class Youtube

    Private Async Sub Youtube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Await permet d'excuter en arrière tâche le chargement de la page
        Await WebView21_InitializeAsync()
        ' Naviguer vers YouTube
        WebView21.Source = New Uri("https://www.youtube.com")
    End Sub

    ' Méthode pour initialiser WebView2
    Private Async Function WebView21_InitializeAsync() As Task
        'Await permet d'excuter en arrière tâche le chargement de la page
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Function

End Class