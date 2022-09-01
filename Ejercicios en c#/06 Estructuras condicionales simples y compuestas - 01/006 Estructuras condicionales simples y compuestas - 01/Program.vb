Imports System

Module Program
    Sub Main(args As String())
        'Ingresar el sueldo de una persona, si supera los 3000 pesos mostrar un mensaje en pantalla indicando que debe abonar impuestos.
        Dim sueldo As Integer
        Dim abono As Boolean = False

        Console.WriteLine("Ingrese el sueldo: ")
        sueldo = Console.ReadLine()

        If sueldo > 3000 Then
            abono = True
        End If

        If abono = True Then
            Console.WriteLine("La persona debe abonar impuestos")
        Else
            Console.WriteLine("La persona no debe abonar impuestos")
        End If
    End Sub
End Module
