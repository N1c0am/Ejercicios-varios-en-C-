Imports System

Module Program
    Sub Main(args As String())
        'Solicitar el ingreso de dos nombres de personas. Mostrar un mensaje si son iguales o distintos.
        Dim nombre1, nombre2 As String

        Console.WriteLine("1: Ingrese el 1er nombre: ")
        nombre1 = Console.ReadLine()
        Console.WriteLine("2: Ingrese el 2do nombre: ")
        nombre2 = Console.ReadLine()

        If (nombre1 = nombre2) Then
            Console.WriteLine("Los nombres SON iguales")
        Else
            Console.WriteLine("Los nombres NO SON iguales")
        End If

    End Sub
End Module
