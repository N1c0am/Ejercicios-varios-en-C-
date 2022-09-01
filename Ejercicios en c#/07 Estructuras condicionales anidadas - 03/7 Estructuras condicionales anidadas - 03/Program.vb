Imports System

Module Program
    Sub Main(args As String())
        'Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información:
        'cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente.
        'Se pide confeccionar un programa que ingrese los dos datos por teclado e
        'informe el nivel del mismo según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
        'Nivel máximo: Porcentaje>= 90%.
        'Nivel medio:	Porcentaje>= 75% y <90%.
        'Nivel regular: Porcentaje>= 50% y <75%.
        'Fuera de nivel: Porcentaje<50%.

        Dim cantPreguntas, cantCorrectas, porcentaje As Integer

        Console.WriteLine("Ingrese la cantidad de preguntas del test de capacitación: ")
        cantPreguntas = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad de preguntas contestadas correctamente: ")
        cantCorrectas = Console.ReadLine()

        porcentaje = (100 * cantCorrectas) / cantPreguntas

        If porcentaje >= 90 Then
            Console.WriteLine(porcentaje & "%: Obtuvo un Nivel máximo")
        ElseIf porcentaje >= 75 Then
            Console.WriteLine(porcentaje & "%: Obtuvo un Nivel medio")
        ElseIf porcentaje >= 50 Then
            Console.WriteLine(porcentaje & "%: Obtuvo un Nivel regular")
        Else
            Console.WriteLine(porcentaje & "%: Obtuvo un Fuera de nivel")
        End If

    End Sub
End Module
