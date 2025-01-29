'Importo el espacio de nombres System.IO
Imports System.IO

Public Class Fichero

    'constructor por defecto
    Public Sub New()
        nombrefichero = "fichero.txt"
    End Sub

    'Constructor parametrizado
    Public Sub New(ByVal nombre As String)
        nombrefichero = nombre
    End Sub

    Private nombrefichero As String

    'guardar: retorna todo el contenido
    Public Function guardar(ByVal contenido As String) As String
        Dim fichTMP As StreamWriter = Nothing
        Dim resultado As String
        Dim car As Char

        resultado = ""

        Try
            fichTMP = New StreamWriter(My.Computer.FileSystem.CurrentDirectory & "\" & nombrefichero, False)

            For Each car In contenido
                fichTMP.Write(car)
            Next

        Catch ex As Exception
            resultado = ex.Message
        Finally
            If Not fichTMP Is Nothing Then
                fichTMP.Close()
                fichTMP = Nothing
            End If
        End Try

        Return resultado

    End Function


    'cargar: retorna todo el contenido
    Public Function cargar() As String
        Dim fichTMP As StreamReader
        fichTMP = Nothing 'inicializacion
        Dim resultado As String

        resultado = ""

        Try
            fichTMP = New StreamReader(My.Computer.FileSystem.CurrentDirectory & "\" & nombrefichero)
            resultado = fichTMP.ReadToEnd()

        Catch ex As Exception
            'si no se encuentra el fichero lo creo y le pongo el simbolo $ q significa q esta vacio
            If ex.Message.Substring(0, 31) = "No se pudo encontrar el archivo" Then
                File.Create((My.Computer.FileSystem.CurrentDirectory & "\" & nombrefichero))
                guardar("$")
                cargar()
            Else
                resultado = ex.Message & " Error al leer de: " & nombrefichero
            End If

        Finally
            'en cualquier caso destruye el objeto
            If Not fichTMP Is Nothing Then
                fichTMP.Close()
                fichTMP = Nothing
            End If
        End Try

        Return resultado

    End Function
End Class

