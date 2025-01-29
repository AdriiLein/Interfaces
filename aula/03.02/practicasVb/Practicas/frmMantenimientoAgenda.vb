Public Class frmMantenimientoAgenda

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        'Libero recursos
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Not Verificardatos() Then Exit Sub

        frmAgenda.Redimensiona()
        frmAgenda.arrNombre(frmAgenda.x) = txtNombre.Text
        frmAgenda.arrDireccion(frmAgenda.x) = txtDireccion.Text
        frmAgenda.arrTelefono(frmAgenda.x) = CInt(txtTelefono.Text)
        frmAgenda.CargarContacto(frmAgenda.x)

        Me.Close()
        'Libero recursos
        Me.Dispose()
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        'Verifico q solo puedan meter numeros y puedan usar el retorno de carro
        If (CInt(AscW(e.KeyChar)) < 48 Or CInt(AscW(e.KeyChar)) > 57) Then
            If Not CInt(AscW(e.KeyChar)) = 8 Then
                e.KeyChar = CChar("")
            End If
        End If
    End Sub

    'Verifica si están los datos correctos sino devuelve false y no se continua con el alta del contacto
    Private Function Verificardatos() As Boolean

        If txtNombre.Text = "" Then
            MessageBox.Show("Introduzca un nombre")
            txtNombre.Focus()
            Exit Function
        ElseIf txtDireccion.Text = "" Then
            MessageBox.Show("Introduzca una dirección")
            txtNombre.Focus()
            Exit Function
        ElseIf txtTelefono.Text = "" Then
            MessageBox.Show("Introduzca un telefono")
            txtNombre.Focus()
            Exit Function
        End If

        Return True

    End Function
End Class