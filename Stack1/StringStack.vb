Public Class StringStack

    Private items(3) As String
    Private top As Integer = -1

    Public Sub Push(newItem As String)

        If top < items.Length - 1 Then
            top += 1
            items(top) = newItem
        Else
            Console.WriteLine("ERROR: stack is full")
        End If

    End Sub

    Public Function Pop() As String

        Dim returnItem As String = ""

        If top >= 0 Then
            returnItem = items(top)
            top -= 1
        Else
            Console.WriteLine("ERROR: Stack is empty")
        End If

        Return returnItem

    End Function

End Class
