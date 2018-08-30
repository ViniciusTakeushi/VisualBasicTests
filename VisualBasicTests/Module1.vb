Module Module1

    Sub Main()
        Console.WriteLine("Hello Visual Basic")

        'Declaration of the variable
        Dim a As Integer = 0

        'Conditional
        If a = 10 Then
            Console.WriteLine("Ok")
        Else
            Console.WriteLine("not Ok")
        End If

        'Loop while
        While a = 10
        End While

        'List
        Dim list As List(Of String) = New List(Of String)
        list.Add("1")

        'Loop foreach
        For Each item As String In list
            Console.WriteLine("Item da lista: " + item)
        Next



        Dim t As Teste = New Teste()
        Console.WriteLine(t.ReturnMessage("Vinicius"))

        Dim n As TesteG = New TesteG()
        n.A = ""

        Console.ReadKey()
    End Sub

    'Build a class
    Public Class TesteG
        'A property
        Private newPropertyValue As String
        Public Property A() As String
            Get
                Return newPropertyValue
            End Get
            Set(ByVal value As String)
                newPropertyValue = value
            End Set
        End Property
    End Class

End Module
