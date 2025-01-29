'Generar letras o numeros segun la entra del textbox
'Cambiar colores al clikear sobre el textbox
'VB: close,static,not,width,&,&=,

Public Class Form1

    Private Sub btnFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFin.Click
        Me.Close()
    End Sub

    Private Sub btnNumeros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumeros.Click
        Dim s As String = TextBox1.Text
        For j As Integer = 1 To TextBox2.Text
            s &= 4
        Next
        TextBox1.Text = s
    End Sub

    Private Sub btnLetras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLetras.Click
        Dim s As String = TextBox1.Text
        For j As Integer = 1 To TextBox2.Text
            s &= "a"
        Next
        TextBox1.Text = s
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
    End Sub


    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        Static onoff As Boolean
        onoff = Not onoff
        If onoff Then
            TextBox1.BackColor = Color.SteelBlue
            TextBox1.ForeColor = Color.White
        Else
            With TextBox1 'agrupar propiedades
                .BackColor = Color.White
                .ForeColor = Color.Black
            End With
        End If
    End Sub

End Class
