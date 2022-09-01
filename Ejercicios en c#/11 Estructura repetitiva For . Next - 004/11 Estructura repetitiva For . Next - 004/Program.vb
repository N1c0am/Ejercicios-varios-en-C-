Imports System

Module Program
    Sub Main(args As String())
        'Escribir un programa que lea 10 números enteros y luego muestre cuántos valores ingresados fueron múltiplos de 3 y cuántos de 5.
        'Debemos tener en cuenta que hay números que son múltiplos de 3 y de 5 a la vez.
        Dim i, num, x, mulTres, mulCinco, mulTresYCinco As Integer
        x = 0
        mulTres = 0
        mulCinco = 0
        mulTresYCinco = 0

        For i = 1 To 10
            x = x + 1
            Console.WriteLine(x & ": Ingrese número: ")
            num = Console.ReadLine()

            If (num Mod 3 = 0) Then
                mulTres = mulTres + 1
            End If

            If (num Mod 5 = 0) Then
                mulCinco = mulCinco + 1
            End If

            If (num Mod 5 = 0 And num Mod 3 = 0) Then
                mulTresYCinco = mulTresYCinco + 1
            End If
        Next

        Console.WriteLine("La cantidad de números múltiplos de 3 es de: " & mulTres)
        Console.WriteLine("La cantidad de números múltiplos de 5 es de: " & mulCinco)
        Console.WriteLine("La cantidad de números múltiplos de 3 y 5 (a la misma vez) es de: " & mulTresYCinco)
    End Sub
End Module
