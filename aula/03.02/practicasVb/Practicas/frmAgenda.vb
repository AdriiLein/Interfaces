Public Class frmAgenda

    'La inicializo a -1 para q en la primera redimension de los arrays se ponga a 0
    Public Shared x As Integer = -1
    Public Shared arrNombre() As String
    Public Shared arrDireccion() As String
    Public Shared arrTelefono() As Integer
    'Indica en q posicion estamos en el array
    Public Shared pos As Integer


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        frmMantenimientoAgenda.ShowDialog()
    End Sub

    Private Sub frmAgenda_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Llamo a la funcion donde se guardan los datos en un fichero, si no se guardan bien muestro un mensaje
        If Not GuardarFichero() Then MessageBox.Show("Los datos de los contactos nos se han guardado correctamente")

        LiberaVariables()
    End Sub

    Private Sub frmAgenda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Genero una instancia nueva de la clase q guarda los ficheros
        'Indico en el constructor de la clase fichero el nombre del fichero , tiene sobrecarga
        Dim fich As New Fichero("Agenda.txt")

        'Cargo el fichero de texto en una cadena
        Dim strAux As String = fich.cargar

        'Si empieza por $ es q no hay datos y no cargo nada en la lista
        If strAux.Substring(0, 1) = "$" Then Exit Sub

        'Meto cada cadena separada por un | en el array estos son los bloques de datos de cada contacto
        Dim arrAux1() As String = strAux.Split("|"c)

        'Por si se ha quedado pillado u otro error
        LiberaVariables()

        'por cada cadena en el array la separo y la meto en un array auxiliar q contiene los campos
        For Each st As String In arrAux1
            'despues meto cada campo en su dimension correspondiente del array de conatactos los campos estan separados por *
            Dim arrAux2() As String = st.Split("*"c)

            'Redimensiono el array
            Redimensiona()

            'Asigno los valores a los arrays como es la primera vez no lo redimensiono
            arrNombre(x) = arrAux2(0)
            arrDireccion(x) = arrAux2(1)
            arrTelefono(x) = CInt(arrAux2(2))
        Next

        'Cargo el primero en el form 
        CargarContacto(0)
    End Sub
    'Este procedimiento indica q campo se desea cargar es public para q se pueda acceder a el atraves del frm de mantenimiento
    Public Shared Sub CargarContacto(ByVal Posicion As Integer)
        'Para poder hacer referencia a un obj privado de la clase tengo q llamar a su clase y luego a el objeto
        frmAgenda.txtNombre.Text = arrNombre(Posicion)
        frmAgenda.txtDireccion.Text = arrDireccion(Posicion)
        frmAgenda.txtTelefono.Text = arrTelefono(Posicion).ToString

        pos = Posicion
        frmAgenda.txtPos.Text = pos.ToString
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        'Libero recursos
        Me.Dispose()
    End Sub


    'Procedimiento q incrementa los arrays
    Public Shared Sub Redimensiona()
        x = x + 1

        ReDim Preserve arrNombre(x)
        ReDim Preserve arrDireccion(x)
        ReDim Preserve arrTelefono(x)

    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click, btnSiguiente.Click, btnAnterior.Click, btnUltimo.Click
        'Trnasformo el boton q manda la llamada en un objeto del tipo boton
        Dim btn As Button = DirectCast(sender, Button)

        Select Case btn.Name
            Case btnPrimero.Name
                CargarContacto(0)
            Case btnSiguiente.Name
                If pos < arrNombre.GetUpperBound(0) Then
                    pos = pos + 1
                    CargarContacto(pos)
                End If
            Case btnAnterior.Name
                If pos > 0 Then
                    pos = pos - 1
                    CargarContacto(pos)
                End If
            Case btnUltimo.Name
                CargarContacto(arrNombre.GetUpperBound(0))
        End Select

    End Sub

    Private Function GuardarFichero() As Boolean
        'Genero una instancia nueva de la clase q guarda los ficheros
        'Indico en el constructor de la clase fichero el nombre del fichero , tiene sobrecarga
        Dim fich As New Fichero("Agenda.txt")

        Dim strAux As String = ""

        'Si no tiene elementos meto un $ en el fichero q indica q viene vacio
        If arrNombre.GetUpperBound(0) = 0 Then
            strAux = "$"
        Else
            'Para guardar los elementos de los arrayses los meto en un string y separo los campos con * y los registros con el simbolo |
            For i As Integer = 0 To arrNombre.GetUpperBound(0)
                If i = arrNombre.GetUpperBound(0) Then
                    strAux = strAux & arrNombre(i) & "*" & arrDireccion(i) & "*" & arrTelefono(i)
                Else
                    strAux = strAux & arrNombre(i) & "*" & arrDireccion(i) & "*" & arrTelefono(i) & "|"
                End If
            Next
        End If

        'Guardo la cadena en el fichero
        fich.guardar(strAux)

        Return True
    End Function

    Private Sub LiberaVariables()
        'Libro los arrays sino cuando volvamos a entrar estarán cargados
        arrNombre = Nothing
        arrDireccion = Nothing
        arrTelefono = Nothing
        pos = 0
        x = -1
    End Sub


    Private Sub mnuOrdenaPorNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrdenaPorNombre.Click
        'Esto no vale xq solo coloca el nombre
        'Array.Sort(arrNombre)

        Dim staux As String = Nothing
        Dim nAux As Integer

        For i As Integer = 0 To arrNombre.GetUpperBound(0)
            For x As Integer = i + 1 To arrNombre.GetUpperBound(0)
                'Comparo las cadenasa de texto y si es mayor realizo una burbuja
                If Microsoft.VisualBasic.StrComp(arrNombre(i), arrNombre(x), CompareMethod.Text) = 1 Then
                    staux = arrNombre(i)
                    arrNombre(i) = arrNombre(x)
                    arrNombre(x) = staux

                    staux = arrDireccion(i)
                    arrDireccion(i) = arrDireccion(x)
                    arrDireccion(x) = staux

                    nAux = arrTelefono(i)
                    arrTelefono(i) = arrTelefono(x)
                    arrTelefono(x) = nAux

                End If
            Next
        Next

        CargarContacto(0)

    End Sub

    Private Sub mnuOrdenaPorDireccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrdenaPorDireccion.Click
        'Esto no vale xq solo coloca la direccion
        'Array.Sort(arrDireccion)

        Dim staux As String = Nothing
        Dim nAux As Integer

        For i As Integer = 0 To arrDireccion.GetUpperBound(0)
            For x As Integer = i + 1 To arrDireccion.GetUpperBound(0)
                'Comparo las cadenasa de texto y si es mayor realizo una burbuja
                If Microsoft.VisualBasic.StrComp(arrDireccion(i), arrDireccion(x), CompareMethod.Text) = 1 Then

                    staux = arrDireccion(i)
                    arrDireccion(i) = arrDireccion(x)
                    arrDireccion(x) = staux

                    staux = arrNombre(i)
                    arrNombre(i) = arrNombre(x)
                    arrNombre(x) = staux

                    nAux = arrTelefono(i)
                    arrTelefono(i) = arrTelefono(x)
                    arrTelefono(x) = nAux

                End If
            Next
        Next

        CargarContacto(0)

    End Sub

    Private Sub mnuOrdenaPorTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrdenaPorTelefono.Click
        'Esto no vale xq solo coloca el telefono
        'Array.Sort(arrTelefono)

        Dim staux As String = Nothing
        Dim nAux As Integer

        For i As Integer = 0 To arrTelefono.GetUpperBound(0)
            For x As Integer = i + 1 To arrTelefono.GetUpperBound(0)
                If arrTelefono(i) > arrTelefono(x) Then

                    nAux = arrTelefono(i)
                    arrTelefono(i) = arrTelefono(x)
                    arrTelefono(x) = nAux

                    staux = arrDireccion(i)
                    arrDireccion(i) = arrDireccion(x)
                    arrDireccion(x) = staux

                    staux = arrNombre(i)
                    arrNombre(i) = arrNombre(x)
                    arrNombre(x) = staux

                End If
            Next
        Next

        CargarContacto(0)

    End Sub
End Class

