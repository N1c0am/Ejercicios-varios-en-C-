Imports System

Module Program
    Sub Main(args As String())
        'Se cargan por teclado tres n�meros distintos. Mostrar por pantalla el mayor de ellos.
        Dim n1, n2, n3 As Double

        Console.WriteLine("Ingrese el 1er n�mero: ")
        n1 = Console.ReadLine()
        Console.WriteLine("Ingrese el 2do n�mero: ")
        n2 = Console.ReadLine()
        Console.WriteLine("Ingrese el 3er n�mero: ")
        n3 = Console.ReadLine()

        If n1 > n2 Then
            If n1 > n3 Then
                Console.WriteLine("El n�mero " & n1 & " es el mayor")
            Else
                Console.WriteLine("El n�mero " & n2 & " es el mayor")
            End If
        ElseIf n2 > n1 Then
            If n2 > n3 Then
                Console.WriteLine("El n�mero " & n2 & " es el mayor")
            Else
                Console.WriteLine("El n�mero " & n3 & " es el mayor")
            End If
        End If
    End Sub
End Module
