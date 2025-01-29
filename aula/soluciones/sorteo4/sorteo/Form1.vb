Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambiar la entrada de datos por inputbox
        Label1.Text = "Introduce dos numeros y pulsa SORTEO"
        TextBox1.Text = InputBox("primer numero", "entrada")
        TextBox2.Text = InputBox("segundo numero", "entrada")
        sortea()
    End Sub

    Private Sub sortea()
        Dim a As Integer
        Dim b As Integer
        If (IsNumeric(TextBox1.Text)) Then
            a = CInt(TextBox1.Text)
        End If
        If (IsNumeric(TextBox2.Text)) Then
            b = CInt(TextBox2.Text)
        End If
        Dim c As Integer
        Dim r As New Random
        c = r.Next(a, b)
        Label1.Text = c
        ComboBox1.Items.Add(c)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sortea()
    End Sub

    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub

End Class
