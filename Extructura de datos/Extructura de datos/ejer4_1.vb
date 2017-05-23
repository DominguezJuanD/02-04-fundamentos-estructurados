Module ejer4_1
    Private Function Media(array() As Integer) As Single
        Dim suma As Integer
        For i = 0 To array.Length() - 1
            suma += array(i)
        Next
        Return suma / array.Length()
    End Function
    Private Sub Desviacion(Array() As Integer, media As Single)
        For i = 0 To Array.Length() - 1
            Console.WriteLine("numero {0} , su desviacion es {1} ", Array(i), Array(i) - media)
        Next
    End Sub
    Sub Main()
        Dim arreglo = New Integer() {3, 5, 6, 7, 8}
        Console.WriteLine("la media de los numeros es " & Media(arreglo))
        Desviacion(arreglo, Media(arreglo))
        Console.ReadKey()
    End Sub
End Module