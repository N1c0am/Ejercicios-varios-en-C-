Imports System

Module Program
    Sub Main(args As String())
        'Escribir un programa que lea n n�meros enteros y calcule la cantidad de valores mayores o iguales a 1000.
        Dim i, x, n1, n2, cantMayor, cantMenor As Integer

        Console.WriteLine("Ingrese la cantidad de n�meros enteros a ingresar: ")
        n1 = Console.ReadLine()

        For i = 1 To n1
            x = x + 1
            Console.WriteLine(x & ": Ingrese n�mero: ")
            n2 = Console.ReadLine()
            If (n2 >= 1000) Then
                cantMayor = cantMayor + 1
            Else
                cantMenor = cantMenor + 1
            End If
        Next

        Console.WriteLine("La cantidad de n�meros MAYOR o IGUAL a 1000: " & cantMayor)
        Console.WriteLine("La cantidad de n�meros MENOR a 1000: " & cantMenor)
    End Sub
End Module
