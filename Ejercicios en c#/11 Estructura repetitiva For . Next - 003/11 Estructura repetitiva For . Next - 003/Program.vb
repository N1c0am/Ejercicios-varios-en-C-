Imports System

Module Program
    Sub Main(args As String())
        'Escribir un programa que solicite por teclado 10 notas de alumnos y nos informe cu�ntos tienen notas mayores o iguales a 7 y cu�ntos menores.
        Dim i, x, nota, cantNotMayor, cantNotMenor As Integer
        cantNotMayor = 0
        cantNotMenor = 0
        x = 0

        For i = 1 To 10
            x = x + 1
            Console.WriteLine(x & ": Ingrese n�mero: ")
            nota = Console.ReadLine()
            If nota >= 1 And nota <= 10 Then
                If nota >= 7 Then
                    cantNotMayor = cantNotMayor + 1
                Else
                    cantNotMenor = cantNotMenor + 1
                End If
            End If
        Next

        Console.WriteLine("La cantidad de notas mayores a 7 es de: " & cantNotMayor)
        Console.WriteLine("La cantidad de notas menores a 7 es de: " & cantNotMenor)
    End Sub
End Module
