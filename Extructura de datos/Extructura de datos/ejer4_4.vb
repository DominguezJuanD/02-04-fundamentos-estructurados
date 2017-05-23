Module ejer4_4

    Sub main()
        Dim Paises As New Collection
        Paises.Add("Argentina", "Arg")
        Paises.Add("Brasil", "Br")
        Paises.Add("Paraguay", "Py")
        Paises.Add("Uruguay", "Uy")
        Paises.Add("chile", "Ch")
        Dim dominio As String
        Do
            Console.WriteLine("Ingrese el Dominio a Buscar: ")
            dominio = Console.ReadLine()
        Loop Until Validar(dominio, Paises)
        Console.ReadKey()
    End Sub
    Private Function Validar(dominio As String, col As Collection)
        Dim valor As Boolean
        If dominio = Nothing Then
            valor = True
        ElseIf col.Contains(dominio) = False Then
            Console.WriteLine("dominio no encontrado")
            valor = False
        Else
            Console.WriteLine("el dominio '{0}' le pertenece a '{1}'", dominio, col.Item(dominio))
        End If
        Return valor
    End Function
End Module
