Imports System

Module Program
    Sub Main(args As String())
        'Realizar la carga de dos n�meros enteros por teclado e imprimir su suma y su producto.
        Dim n1, n2, suma, producto As Integer

        Console.WriteLine("Ingrese el 1er n�mero: ")
        n1 = Console.ReadLine()
        Console.WriteLine("Ingrese el 2do n�mero: ")
        n2 = Console.ReadLine()

        suma = n1 + n2
        producto = n1 * n2

        Console.WriteLine("La suma de " & n1 & "+" & n2 & " = " & suma)
        Console.WriteLine("El producto de " & n1 & "*" & n2 & " = " & producto)

        '--------------------------------------------------------------------------------------
        'Realizar la carga del lado de un cuadrado, mostrar por pantalla el per�metro del mismo
        '(El per�metro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
        Dim lado, perimetro As Integer

        Console.WriteLine("Ingrese el lado del cuadrado: ")
        lado = Console.ReadLine()

        perimetro = lado * 4

        Console.WriteLine("El perimetro del cuadrado es: " & perimetro)

        '--------------------------------------------------------------------------------------
        'Escribir un programa en el cual se ingresen cuatro n�meros,
        'calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.
        Dim num1, num2, num3, num4, sum, prod As Integer
        Console.WriteLine("Ingrese el 1er n�mero: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Ingrese el 2do n�mero: ")
        num2 = Console.ReadLine()
        Console.WriteLine("Ingrese el 3er n�mero: ")
        num3 = Console.ReadLine()
        Console.WriteLine("Ingrese el 4to n�mero: ")
        num4 = Console.ReadLine()

        sum = num1 + num2
        prod = num3 * num4
        Console.WriteLine("La suma es: " & sum)
        Console.WriteLine("El producto es: " & prod)
    End Sub
End Module
