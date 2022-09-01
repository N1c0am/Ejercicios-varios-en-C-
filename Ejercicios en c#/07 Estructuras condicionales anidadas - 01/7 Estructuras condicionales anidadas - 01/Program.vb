Imports System

Module Program
    Sub Main(args As String())
        'Confeccionar un programa que pida por teclado tres notas de un alumno, calcule el promedio e imprima alguno de estos mensajes
        'Si el promedio es >=7 mostrar "Promocionado".
        'Si el promedio es >=4 y <7 mostrar "Regular".
        'Si el promedio es <4 mostrar "Reprobado".

        Dim nota1, nota2, nota3, promedio As Double
        Console.WriteLine("Ingrese el 1er número: ")
        nota1 = Console.ReadLine()
        Console.WriteLine("Ingrese el 2do número: ")
        nota2 = Console.ReadLine()
        Console.WriteLine("Ingrese el 3er número: ")
        nota3 = Console.ReadLine()

        promedio = (nota1 + nota2 + nota3) / 3

        If promedio >= 7 Then
            Console.WriteLine("Promocionado")
        ElseIf promedio >= 4 Then
            Console.WriteLine("Regular")
        Else
            Console.WriteLine("Reprobado")
        End If
    End Sub
End Module
