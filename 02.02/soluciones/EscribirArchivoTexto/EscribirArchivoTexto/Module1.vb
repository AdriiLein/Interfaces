Imports System.IO

Module Module1
    Public Sub main()
        'MessageBox.Show("inicio")

        Dim fichero = "TextFileCreado.txt"
        Dim texto = "soy un texto 2222" & vbCrLf

        ' declarar una variable para la escritura
        ' de texto en un fichero
        Dim oEscritor As StreamWriter
        ' crear un fichero de texto vacío
        ' y obtener un objeto StreamWriter
        ' para escribir en el fichero
        ' oEscritor = File.CreateText(Environment.CurrentDirectory & "\" & fichero)

        oEscritor = New IO.StreamWriter("..\..\" & fichero, True)

        ' escribir en el fichero el contenido del
        ' control TextBox
        oEscritor.Write(texto)
        ' cerrar el objeto, lo que cierra también el
        ' fichero, y eliminar el objeto
        oEscritor.Close()
        oEscritor = Nothing


    End Sub

End Module
