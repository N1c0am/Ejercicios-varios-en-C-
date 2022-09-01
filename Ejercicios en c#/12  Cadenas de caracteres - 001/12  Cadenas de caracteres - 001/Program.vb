Imports System

Module Program
    Sub Main(args As String())
        'Solicitar el ingreso del nombre y edad de dos personas. Mostrar el nombre de la persona con mayor edad.
        Dim nombre As String
        Dim edad, i, x, edadMenor, edadMayor As Integer
        x = 0
        edadMayor = 0
        For i = 1 To 2
            x = x + 1
            Console.WriteLine(x & ": Ingrese nombre")
            nombre = Console.ReadLine
            Console.WriteLine("Ingrese edad")
            edad = Console.ReadLine()
            If (edad > edadMayor) Then
                edadMayor = edad
            End If
            Console.WriteLine("----------------------------")
        Next

        Console.WriteLine("La edad mayor de las 2 personas es de: " & edadMayor)
    End Sub
End Module
