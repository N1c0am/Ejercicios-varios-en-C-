Imports System

Module Program
    Sub Main(args As String())
        'Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.
        Dim i, x, n1, n2, cantMayor, cantMenor As Integer

        Console.WriteLine("Ingrese la cantidad de números enteros a ingresar: ")
        n1 = Console.ReadLine()

        For i = 1 To n1
            x = x + 1
            Console.WriteLine(x & ": Ingrese número: ")
            n2 = Console.ReadLine()
            If (n2 >= 1000) Then
                cantMayor = cantMayor + 1
            Else
                cantMenor = cantMenor + 1
            End If
        Next

        Console.WriteLine("La cantidad de números MAYOR o IGUAL a 1000: " & cantMayor)
        Console.WriteLine("La cantidad de números MENOR a 1000: " & cantMenor)
    End Sub
End Module
