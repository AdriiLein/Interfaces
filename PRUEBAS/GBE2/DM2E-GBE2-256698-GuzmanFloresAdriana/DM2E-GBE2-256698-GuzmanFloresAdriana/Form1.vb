Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Private letrasTextBoxEscondido As String = "abcdefghijklmnopqrstuvwxyz"
    Private maximo As Integer = 255
    Private minimo As Integer = 125
    Private longitud As Double = (maximo - minimo) / letrasTextBoxEscondido.Length
    Private colorRojo As Integer = minimo
    Private colorVerde As Integer = minimo
    Private colorAzul As Integer = minimo
    Private direccionRojo As Integer = -1
    Private direccionVerde As Integer = -1
    Private direccionAzul As Integer = -1
    Private estadoRojo As Integer = 0
    Private estadoVerde As Integer = 0
    Private estadoAzul As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(702, 284)
        Me.TextBox1.ForeColor = System.Drawing.Color.Transparent
        Me.TextBox2.ForeColor = System.Drawing.Color.Transparent
        Me.TextBox3.ForeColor = System.Drawing.Color.Transparent

        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False

        Timer1.Interval = 30
        Timer2.Interval = 30
        Timer3.Interval = 30
    End Sub

    Private Sub Barra1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barra1ToolStripMenuItem.Click
        Barra1ToolStripMenuItem.Enabled = False
        TextBox5.Visible = True
        TextBox5.Text = letrasTextBoxEscondido
        TextBox5.Font = New System.Drawing.Font("Malgun Gothic Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox5.BackColor = System.Drawing.SystemColors.Control
        TextBox5.ReadOnly = True
    End Sub

    Private Sub Barra2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barra2ToolStripMenuItem.Click
        Barra2ToolStripMenuItem.Enabled = False
        TextBox6.Visible = True
        TextBox6.Text = letrasTextBoxEscondido
        TextBox6.Font = New System.Drawing.Font("Malgun Gothic Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox6.BackColor = System.Drawing.SystemColors.Control
        TextBox6.ReadOnly = True
    End Sub

    Private Sub Barra3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Barra3ToolStripMenuItem.Click
        Barra3ToolStripMenuItem.Enabled = False
        TextBox7.Visible = True
        TextBox7.Text = letrasTextBoxEscondido
        TextBox7.Font = New System.Drawing.Font("Malgun Gothic Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox7.BackColor = System.Drawing.SystemColors.Control
        TextBox7.ReadOnly = True
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ElegirColor()
    End Sub

    Public Sub ElegirColor()
        ColorDialog1.Color = SystemColors.Control
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub DefectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefectoToolStripMenuItem.Click
        Me.BackColor = System.Drawing.SystemColors.Control
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        CambiarEstadoContador(estadoRojo, direccionRojo, Timer1, Button1)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        CambiarEstadoContador(estadoVerde, direccionVerde, Timer2, Button2)
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        CambiarEstadoContador(estadoAzul, direccionAzul, Timer3, Button3)
    End Sub

    Private Sub CambiarEstadoContador(ByRef estado As Integer, ByRef direccion As Integer, ByVal timer As Timer, ByVal boton As Button)
        If estado = 0 Then
            estado = 1
            timer.Start()
            direccion = If(direccion = 1, -1, 1)
        Else
            estado = 0
            timer.Stop()
        End If
        boton.Text = DireccionDeLasFlechas(estado, direccion)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ActualizarContador(colorRojo, estadoRojo, direccionRojo, Timer1, Button1, TextBox1, Color.FromArgb(colorRojo, 0, 0), TextBox5)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        ActualizarContador(colorVerde, estadoVerde, direccionVerde, Timer2, Button2, TextBox2, Color.FromArgb(0, colorVerde, 0), TextBox6)
    End Sub

    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer3.Tick
        ActualizarContador(colorAzul, estadoAzul, direccionAzul, Timer3, Button3, TextBox3, Color.FromArgb(0, 0, colorAzul), TextBox7)
    End Sub

    Private Sub ActualizarContador(ByRef valor As Integer, ByRef estado As Integer, ByVal direccion As Integer, ByVal timer As Timer, ByVal boton As Button, ByVal textBox As TextBox, ByVal color As Color, ByVal barraBox As TextBox)
        textBox.Text = valor.ToString()
        textBox.BackColor = color
        ActualizarColorTextBox()
        barraBox.Text = letrasTextBoxEscondido.Substring(0, CInt(Math.Round((valor - minimo) / longitud)))
        valor += direccion
        VerificarLimites(valor, estado, direccion, timer, boton)
    End Sub


    Private Sub ActualizarColorTextBox()
        TextBox4.BackColor = Color.FromArgb(colorRojo, colorVerde, colorAzul)
    End Sub

    Private Sub VerificarLimites(ByRef valor As Integer, ByRef estado As Integer, ByVal direccion As Integer, ByVal timer As Timer, ByVal boton As Button)
        If valor > maximo Then
            valor = maximo
            estado = 0
        ElseIf valor < minimo Then
            valor = minimo
            estado = 0
        End If
        boton.Text = DireccionDeLasFlechas(estado, direccion)
    End Sub

    Private Function DireccionDeLasFlechas(ByVal estado As Integer, ByVal direccion As Integer) As String
        If estado = 0 Then
            Return "="
        ElseIf direccion = 1 Then
            Return ">>"
        Else
            Return "<<"
        End If
    End Function
End Class
