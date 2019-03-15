Module Module1

    Sub Main()

        Dim stack As New StringStack
        Dim S As String

        stack.Push("red")
        stack.Push("green")
        stack.Push("blue")
        stack.Push("yellow")
        stack.Push("cyan")

        For i = 1 To 5
            S = stack.Pop
            Console.WriteLine(S)
        Next

        Console.ReadLine()

    End Sub

End Module
