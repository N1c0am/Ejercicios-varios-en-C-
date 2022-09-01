Imports System

Module Program
    Sub Main(args As String())
        'Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.
        Dim n1, n2, n3 As Double

        Console.WriteLine("Ingrese el 1er número: ")
        n1 = Console.ReadLine()
        Console.WriteLine("Ingrese el 2do número: ")
        n2 = Console.ReadLine()
        Console.WriteLine("Ingrese el 3er número: ")
        n3 = Console.ReadLine()

        If n1 > n2 Then
            If n1 > n3 Then
                Console.WriteLine("El número " & n1 & " es el mayor")
            Else
                Console.WriteLine("El número " & n2 & " es el mayor")
            End If
        ElseIf n2 > n1 Then
            If n2 > n3 Then
                Console.WriteLine("El número " & n2 & " es el mayor")
            Else
                Console.WriteLine("El número " & n3 & " es el mayor")
            End If
        End If
    End Sub
End Module
