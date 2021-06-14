Imports System

Module Program11
    Sub Main()
        Dim r As Double, area As Double
        Console.Write("Enter the Radius of the circle: ")
        r = Console.ReadLine()
        area = 3.14 * r * r
        Console.WriteLine("The area of the circle is {0}", area)
        Console.ReadKey()
    End Sub
End Module
