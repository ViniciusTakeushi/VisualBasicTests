Public Class Teste
    Public Function ReturnMessage(ByVal name As String, Optional ByVal age As Integer = 0) As String
        Return name + " - " + age.ToString()
    End Function
End Class
