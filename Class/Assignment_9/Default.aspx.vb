Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Console.WriteLine("hello, world")
        Console.ReadKey()
    End Sub
End Class