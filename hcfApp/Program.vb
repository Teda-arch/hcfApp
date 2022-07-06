Imports System

Module Program
    Sub Main()

        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim temp As Integer = 0

        Console.WriteLine("Enter first number: ")
        num1 = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Enter second number: ")
        num2 = Integer.Parse(Console.ReadLine())

        While Not (num2 = 0)
            temp = num1 Mod num2
            num2 = temp
        End While

        Console.WriteLine("Highest Common Factor is: {0}", num1)

    End Sub
End Module
