Imports System

Module Program
    Sub Main(args As String())
        'Se ingresa por teclado un n�mero positivo de uno o dos d�gitos (1..99) mostrar un mensaje indicando
        'si el n�mero tiene uno o dos d�gitos.
        '(Tener en cuenta que condici�n debe cumplirse para tener dos d�gitos, un n�mero entero)

        Console.WriteLine("Ingrese un n�mero positivo, m�ximo 2 d�gitos: ")
        Dim num As Integer = Console.ReadLine()

        If num <= 99 & num >= 0 Then
            If num / 10 >= 1 Then
                Console.WriteLine("El n�mero ingresado tiene 2 d�gitos")
            Else
                Console.WriteLine("El n�mero ingresado tiene 1 d�gito")
            End If
        Else
            Console.WriteLine("Ingrese un n�mero que tengo m�ximo 2 d�gitos")
        End If



    End Sub
End Module
