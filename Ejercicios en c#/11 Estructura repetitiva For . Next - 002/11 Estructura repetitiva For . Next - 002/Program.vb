Imports System

Module Program
    Sub Main(args As String())
        'Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente la suma de los valores
        'ingresados y su promedio. Este problema ya lo desarrollamos, lo resolveremos empleando la estructura for.
        Dim i, x, num, suma, promedio As Integer
        x = 0
        suma = 0
        For i = 1 To 10
            x = x + 1
            Console.WriteLine(x & ".- Ingrese número: ")
            num = Console.ReadLine()
            suma = suma + num
        Next
        promedio = suma / x
        Console.WriteLine("El promedio de los números ingresados es de: " & promedio)
    End Sub
End Module
