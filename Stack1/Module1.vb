Module Module1

    Sub Main()

        Dim stack As New StringStack
        Dim S As String

        stack.Push("red")
        stack.Push("green")
        stack.Push("blue")
        stack.Push("yellow")

        S = stack.Pop
        Console.WriteLine(S)

        Console.ReadLine()

    End Sub

End Module
