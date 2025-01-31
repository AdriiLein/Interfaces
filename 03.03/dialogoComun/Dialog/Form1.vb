Imports System.IO

Public Class Form1

    Dim i1 = "SelectedPath : "
    Dim i2 = "DirectoryName : "
    Dim i3 = "FileName : "

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ruta As String = "", directorio As String = ""

        'Dialogos comunes me permiten seleccionar una carpeta
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ruta = FolderBrowserDialog1.SelectedPath
            Label1.Text = i1 & ruta
            'path tenemos funciones para manupular rutas
            Label2.Text = i2 & Path.GetDirectoryName(ruta)
            Label3.Text = i3 & Path.GetFileName(ruta)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = i1
        Label2.Text = i2
        Label3.Text = i3
    End Sub
End Class
