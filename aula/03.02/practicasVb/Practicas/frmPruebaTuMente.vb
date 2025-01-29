'vb: rnd, close dispose, cint, 

Public Class frmPruebaTuMente

    Dim numero As Integer
    Dim ColorControl As System.Drawing.Color

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        lblEstado.Text = ""
        txtNumero.Text = ""
        lblEstado.BackColor = ColorControl
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnGeneraNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraNumero.Click
        Randomize()
        numero = CInt(100 * Rnd() + 0)
        lblEstado.Text = ""
        txtNumero.Text = ""
        lblEstado.BackColor = ColorControl
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Not txtNumero.Text = "" Then

            'seria necesario chequear try cath de los enteros
            If CInt(txtNumero.Text) = numero Then
                lblEstado.Text = "¡¡¡ACERTASTE!!!"
                lblEstado.BackColor = Color.Green
            ElseIf CInt(txtNumero.Text) > numero Then
                lblEstado.Text = "EL NUMERO ES MENOR"
                lblEstado.BackColor = Color.Red
                txtNumero.Focus()
            ElseIf CInt(txtNumero.Text) < numero Then
                lblEstado.Text = "EL NUMERO ES MAYOR"
                lblEstado.BackColor = Color.Turquoise
                txtNumero.Focus()
            End If
            lblEstado.Refresh() ' no es necesario
        End If
    End Sub

    Private Sub frmPruebaTuMente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ColorControl = lblEstado.BackColor
    End Sub

End Class