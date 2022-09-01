Imports System

Module Program
    Sub Main(args As String())
        'Realizar un programa que solicite ingresar dos números distintos y muestre por pantalla el mayor de ellos.
        Dim n1, n2 As Integer

        Console.WriteLine("Ingrese el 1er numero")
        n1 = Console.ReadLine()
        Console.WriteLine("Ingrese el 2do numero")
        n2 = Console.ReadLine()

        If n1 > n2 Then
            Console.WriteLine(n1 & " es > a " & n2)
        ElseIf n1 < n2 Then
            Console.WriteLine(n2 & " es > a " & n1)
        Else
            Console.WriteLine("Los números son iguales")
        End If
    End Sub
End Module
