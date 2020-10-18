Imports System



Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.Write(vbCrLf) 'salto de línea
        Console.Write("Cuál es tu nombre? ")
        Dim nombre = Console.ReadLine()
        'Console.WriteLine(vbCrLf & "Hola " & nombre)
        Console.WriteLine("Hola " & nombre)
        Dim fecha As Date
        Dim currentDate = DateTime.Now
        fecha = DateTime.Now
        Dim dia, mes, anio As Integer
        dia = fecha.Day
        mes = fecha.Month
        anio = fecha.Year
        Console.Write(vbCrLf + "Hoy es " & dia & "/" & mes & "/" & anio)
        Console.Write(vbCrLf + "Presisona una tecla para acabar... ")
        Console.ReadLine()         'Console.ReadKey(True)

    End Sub
End Module
