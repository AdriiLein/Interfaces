Option Strict On
Imports System.Windows.Forms
Public Class frmSorteo

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

        'Libero recursos
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Not Verificardatos() Then 'Verifico si los datos están bien
            Exit Sub
        Else 'Si lo estan los guardo en la lista
            lstParticipantes.Items.Add(txtDNI.Text & " - " & txtNombre.Text)
        End If
    End Sub
    'Verifica si están los datos correctos sino devuelve false y no se vcntinua con el alta en la lista
    Private Function Verificardatos() As Boolean

        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            txtNombre.Focus()
            Exit Function
        ElseIf CLng(txtDNI.Text) < 10000000 Then
            MessageBox.Show("Introduzca un DNI Valido")
            txtDNI.Focus()
            Exit Function
        End If

        For i As Integer = 1 To lstParticipantes.Items.Count
            If Mid(CStr(lstParticipantes.Items.Item(i - 1)), 1, InStr(CStr(lstParticipantes.Items.Item(i - 1)), "-") - 2) = txtDNI.Text Then
                MessageBox.Show("El DNI ya existe")
                txtDNI.Focus()
                Exit Function
            End If
        Next

        Return True

    End Function

    Private Function GuardarFichero() As Boolean
        'Genero una instancia nueva de la clase q guarda los ficheros
        'Indico en el constructor de la clase fichero el nombre del fichero , tiene sobrecarga
        Dim fich As New Fichero("Sorteo.txt")

        Dim strAux As String = ""

        'Si no tiene elementos meto un $ en el fichero q indica q viene vacio
        If lstParticipantes.Items.Count = 0 Then
            strAux = "$"
        Else
            'Para guardar los elementos de la lista los meto en un string y separo los registros con el simbolo |
            For i As Integer = 0 To lstParticipantes.Items.Count - 1
                If i = lstParticipantes.Items.Count - 1 Then
                    strAux = strAux & CStr(lstParticipantes.Items.Item(i)).ToString
                Else
                    strAux = strAux & CStr(lstParticipantes.Items.Item(i)).ToString & "|"
                End If
            Next
        End If

        'Guardo la cadena en el fichero
        fich.guardar(strAux)

        Return True
    End Function

    Private Sub frmSorteo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Llamo a la funcion donde se guardan los datos en un fichero, si no se guardan bien muestro un mensaje
        If Not GuardarFichero() Then MessageBox.Show("Los datos de los participantes nos se han guardado correctamente")
        'Limpio la lista
        lstParticipantes.Items.Clear()

    End Sub

    Private Sub frmSorteo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Genero una instancia nueva de la clase q guarda los ficheros
        'Indico en el constructor de la clase fichero el nombre del fichero , tiene sobrecarga
        Dim fich As New Fichero("Sorteo.txt")

        'Cargo el fichero de texto en una cadena
        Dim strAux As String = fich.cargar
        
        'Si empieza por $ es q no hay datos y no cargo nada en la lista
        If strAux.Substring(1, 1) = "$" Then Exit Sub

        'Meto cada cadena separada por un | en el array
        Dim arr() As String = strAux.Split("|"c)

        'por cada cadena en el array se mete en la lista
        For Each st As String In arr
            lstParticipantes.Items.Add(st)
        Next
    End Sub

    Private Sub BtnSorteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSorteo.Click
        'inicializo la funcion randomize para q sp me de un numero aleatorio diferente
        Randomize()

        'Busco un ganador aletaroiamente entre el numero de participantes
        Dim ganador As Integer = CInt(lstParticipantes.Items.Count * Rnd() + 0)

        'Muestro los datos del ganador
        txtDNIGanador.Text = Mid(lstParticipantes.Items.Item(ganador).ToString, 1, InStr(lstParticipantes.Items.Item(ganador).ToString, "-") - 2)
        txtNombreGanador.Text = Mid(lstParticipantes.Items.Item(ganador).ToString, InStr(lstParticipantes.Items.Item(ganador).ToString, "-") + 2, Len(lstParticipantes.Items.Item(ganador).ToString))

    End Sub
End Class