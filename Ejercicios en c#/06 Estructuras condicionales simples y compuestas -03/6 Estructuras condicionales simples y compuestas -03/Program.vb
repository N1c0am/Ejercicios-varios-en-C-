Imports System

Module Program
    Sub Main(args As String())
        'Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando
        'si el número tiene uno o dos dígitos.
        '(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

        Console.WriteLine("Ingrese un número positivo, máximo 2 dígitos: ")
        Dim num As Integer = Console.ReadLine()

        If num <= 99 & num >= 0 Then
            If num / 10 >= 1 Then
                Console.WriteLine("El número ingresado tiene 2 dígitos")
            Else
                Console.WriteLine("El número ingresado tiene 1 dígito")
            End If
        Else
            Console.WriteLine("Ingrese un número que tengo máximo 2 dígitos")
        End If



    End Sub
End Module
