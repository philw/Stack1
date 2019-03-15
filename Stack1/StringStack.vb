Public Class StringStack

    Private items(3) As String
    Private top As Integer = -1

    Public Sub Push(newItem As String)
        top += 1
        items(top) = newItem
    End Sub

    Public Function Pop() As String
        Dim returnItem As String

        returnItem = items(top)
        top -= 1
        Return returnItem
    End Function

End Class
