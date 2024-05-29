Public Class SudokuGenerator
    Private grid(8, 8) As Integer
    Private rand As New Random()

    'génère le sudoku dans le form2 (jeuSudoku) et return la grille (grid)
    Public Function Generate() As Integer(,)
        Array.Clear(grid, 0, grid.Length)
        FillGrid()
        Return grid
    End Function

    'Crée la grille avec des chiffres mélangé
    Private Function FillGrid() As Boolean
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If grid(i, j) = 0 Then
                    Dim numbers As List(Of Integer) = GetShuffledNumbers()
                    For Each number In numbers
                        If IsValid(i, j, number) Then
                            grid(i, j) = number
                            If FillGrid() Then
                                Return True
                            Else
                                grid(i, j) = 0
                            End If
                        End If
                    Next
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    'Mélange les chiffres random de la liste
    Private Function GetShuffledNumbers() As List(Of Integer)
        Dim numbers As List(Of Integer) = Enumerable.Range(1, 9).ToList()
        Dim shuffled As List(Of Integer) = numbers.OrderBy(Function(a) rand.Next()).ToList()
        Return shuffled
    End Function

    'Vérifie si les chiffres sont valides par rapport aux règle de jeux
    Private Function IsValid(row As Integer, col As Integer, num As Integer) As Boolean

        For j As Integer = 0 To 8
            If grid(row, j) = num Then Return False
        Next

        For i As Integer = 0 To 8
            If grid(i, col) = num Then Return False
        Next

        Dim startRow As Integer = (row \ 3) * 3
        Dim startCol As Integer = (col \ 3) * 3
        For i As Integer = startRow To startRow + 2
            For j As Integer = startCol To startCol + 2
                If grid(i, j) = num Then Return False
            Next
        Next
        Return True
    End Function
End Class
