Public Class Netflix
    Private Async Sub Youtube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Await permet d'excuter en arrière tâche le chargement de la page
        Await WebView21_InitializeAsync()
        ' Naviguer vers netflix
        WebView21.Source = New Uri("https://www.netflix.com/fr/")
    End Sub

    ' Méthode pour initialiser WebView2
    Private Async Function WebView21_InitializeAsync() As Task
        'Await permet d'excuter en arrière tâche le chargement de la page
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Function
End Class