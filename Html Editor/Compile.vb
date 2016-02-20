Public Class Compile
    Dim Temp As String = "C:\Users\" & Environment.UserName.ToString & "\AppData\Local\Temp\index.htm"
    Private Sub Compile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Document.Write(IO.File.ReadAllText(Temp))
    End Sub
End Class