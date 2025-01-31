Imports Practicas.aux

Public Class frmPruebaTuMente2
    Dim numero As Integer
    Dim ColorControl As System.Drawing.Color
    Private CuentaAtras As Integer
    Private a_rango As Integer
    Private b_rango As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        lblEstado.Text = ""
        txtNumero.Text = ""
        lblEstado.BackColor = ColorControl
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnGeneraNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneraNumero.Click
        Randomize()
        'numero = CInt(100 * Rnd() + 0)
        lblEstado.Text = ""
        txtNumero.Text = ""
        lblEstado.BackColor = ColorControl
        Timer1.Enabled = True
        CuentaAtras = 50
        a_rango = aleatorio(0, 50)
        b_rango = a_rango + aleatorio(0, 50)
        numero = aleatorio(a_rango, b_rango)
        Label3.Text = a_rango & " " & numero.ToString & " " & b_rango
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        examina()
    End Sub

    Private Sub examina()
        If Not txtNumero.Text = "" Then
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
            lblEstado.Refresh()
        End If
    End Sub

    Private Sub frmPruebaTuMente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ColorControl = lblEstado.BackColor
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = CuentaAtras.ToString
        CuentaAtras -= 1
        If CuentaAtras = 0 Then Me.Close()
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            Label4.Text = "Enter"
            examina()
            txtNumero.Text = ""
        End If
    End Sub


End Class

Class aux
    Shared Function aleatorio(ByVal min As Integer, ByVal max As Integer) As Integer
        Return CType((max - min) * Rnd() + min, Integer)
    End Function
End Class