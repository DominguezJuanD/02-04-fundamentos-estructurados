Module ejer4_2
    Sub main()
        Dim codigoProducto = New Integer() {101, 102, 103, 104}
        Dim productos = New String() {"teclado", "masue", "gabinete", "monitor"}
        Dim P_unitario = New Single() {35, 30, 60, 150}
        Dim codigo, valor, totalprecio, totalgeneral As Integer
        Dim cantidad As Integer
        Do
            Console.WriteLine("Ingrese Codigo: ")
            codigo = Console.ReadLine()
            valor = Buscar(codigo, codigoProducto)
            If valor >= 0 Then
                Console.WriteLine("codigo del progucto es: '{0}', nombre: '{1}', precio: '${2}'", codigoProducto(valor), productos(valor), P_unitario(valor))
                Console.WriteLine("Ingrese Cantidad: ")
                cantidad = Console.ReadLine()
                totalprecio = P_unitario(valor) * cantidad
                totalgeneral += totalprecio
                Console.WriteLine("producto: '{0}', cantidad a comprar: '{1}', total del producto: '${2}'", productos(valor), cantidad, totalprecio)
                Console.WriteLine("total general a pagar: $" & totalgeneral)
            ElseIf valor < 0 And codigo <> 0 Then
                Console.WriteLine("codigo no existe")
            End If
        Loop Until (codigo = 0)
        Console.ReadKey()
    End Sub
    Private Function Buscar(cod As Integer, array() As Integer)
        For i = 0 To array.Length - 1
            If cod = array(i) Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module