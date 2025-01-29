Public Class Form1
    ' nuestra clase contenedora del formulario generada plantilla
    ' ( en el designer del form tenemos todos los objetos que maneja el formulario )

    'boton de ejecucion del sorteo
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not chequea() Then
            Return
        End If
        ' uso de un objeto, instanciacion
        Dim aleatorio As New Random


        'declaracion de variables
        'obtener el numero del sorteo
        Dim resultado As Integer
        'uso del metodo de un objeto

        resultado = aleatorio.Next(CInt(TextBox1.Text), CInt(TextBox2.Text) + 1)
        ' imprimir el resultado
        'concaternar
        Label4.ForeColor = Color.Black
        Label4.Text = "Yeahhh: " & resultado
    End Sub

    ' declaramos un procedimiento
    Private Sub aviso(ByVal a As String)
        Label4.ForeColor = Color.Red
        Label4.Text = a
    End Sub

    'centralizamos en un funcion todos los chequeos
    'true si todo va bien
    Private Function chequea()
        'vaciar el mensaje del status
        aviso("")
        'general
        If ((TextBox1.Text = "") And (TextBox2.Text = "")) Then
            aviso("Introduce los datos de entrada")
            Return False
        End If
        'caja 1
        If (TextBox1.Text = "") Then
            aviso("La primera entrada esta vacia")
            Return False
        End If
        If (Not IsNumeric(TextBox1.Text)) Then
            aviso("La primera entrada no es numerica")
            Return False
        End If
        If (Not (CInt(TextBox1.Text) = TextBox1.Text)) Then
            aviso("El primer numero no es entero")
            Return False
        End If
        If (TextBox1.Text > 2147483647) Then
            aviso("El numero no puede pasar de 2147483647")
            Return False
        End If
        If (TextBox1.Text < 0) Then
            aviso("El primer numero no puede ser negativo")
            Return False
        End If
        'caja 2
        If (TextBox2.Text = "") Then
            aviso("La segunda entrada esta vacia")
            Return False
        End If
        If (Not IsNumeric(TextBox2.Text)) Then
            aviso("La segunda entrada no es numerica")
            Return False
        End If
        If (Not (CInt(TextBox2.Text) = TextBox2.Text)) Then
            aviso("La segunda numero no es entero")
            Return False
        End If
        If (TextBox2.Text > 2147483647) Then
            aviso("El numero no puede pasar de 2147483647")
            Return False
        End If
        If (TextBox2.Text < 0) Then
            aviso("El segundo numero no puede ser negativo")
            Return False
        End If
        ' ambas cajas
        'conversion a enteros para hacer la comparacion
        'sino comparariamos cadenas
        If CInt(TextBox2.Text) <= CInt(TextBox1.Text) Then
            aviso("El segundo numero debe ser mayor que el primero")
            Return False
        End If
        Return True
    End Function

    ' procedimiento COPIADO de internet
    ' usamos el guion bajo para un salto de linea
    Private Sub TextBox_KeyPress(ByVal sender As Object, _
          ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        Dim pattern As String = "*[.]*"
        Dim result As Boolean = e.KeyChar Like pattern
        If (result) Then
            ' Cancelamos la pulsación de la tecla indicando que el evento ya fue manejado y terminado
            ' pero no hemos impreso el caracter, en este caso el . , podriamos usar lo mismo para cualquier
            ' cosa que no fuera un numero, en vez de sacar mensajes de error
            e.Handled = True
        End If
    End Sub

    ' entramos desde dos origenes
    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        chequea()
    End Sub

End Class
