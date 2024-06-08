Imports Microsoft.Web.WebView2.Core

Public Class Internet
    Private Async Sub Youtube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assurez-vous que le SDK WebView2 est installé et initialisé
        Await WebView21_InitializeAsync()
        ' Naviguer vers internet
        WebView21.Source = New Uri("https://www.google.fr/")
    End Sub

    ' Méthode pour initialiser WebView2
    Private Async Function WebView21_InitializeAsync() As Task
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Function
End Class