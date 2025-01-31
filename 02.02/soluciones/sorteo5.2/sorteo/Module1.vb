Module Module1
    'Inicio desde main en module1
    'no usar formulario
    Public Sub main()
        Dim a As Integer = InputBox("primer numero", "entrada")
        Dim b As Integer = InputBox("segundo numero", "entrada")
        Dim c As New Random
        Dim s As String = CStr(a) & ":" & CStr(b) & "=" & CStr(c.Next(a, b))
        MessageBox.Show(s)
    End Sub
End Module
