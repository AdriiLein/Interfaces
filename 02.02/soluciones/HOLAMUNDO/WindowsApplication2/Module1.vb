Module Module1
    ' creo un main para arrancar aqui el proyecto
    Public Sub Main()
        'abro como modal del form1
        Form1.ShowDialog()
        ' instancio form2
        Dim form2 = New Form2
        form2.Text = "form2"
        ' abro como modal form2 primero hay que cerrar form1 porque esta como modal
        form2.ShowDialog()
    End Sub


    Class Form2
        Inherits Form
    End Class



End Module
