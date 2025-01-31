Public Class Form1

    ' la primera funcion es form1_Load
    ' Me hace referencia a propio objeto instanciado de la clase Form1
    ' Podemos copiar codigo del Form1.Designer.vb para poner atributos a los objetos
    ' En los selectores podemos crear cualquier evento sobre los objetos existentes
    ' 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' cambiar el tamaño de la ventana
        Me.ClientSize = New System.Drawing.Size(500, 200)
        ' mostrar un testo en label1
        Label1.Text = "Dbl click para maximizar la ventana"

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.ClientSize = New System.Drawing.Size(600, 200)
    End Sub

    Private Sub Form1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Me.WindowState = FormWindowState.Maximized
        ' click en minimizar llama a form1_click
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.BackColor = System.Drawing.SystemColors.ControlDark
        BackColor = System.Drawing.SystemColors.ControlDark
    End Sub

    ' si usamos el evento checked para cambiar el checked entramos en bucle y hace cosas extrañas
    ' usamos el evento click

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        BackColor = Color.Red
        reset()
        CheckBox2.Checked = False
        CheckBox3.Checked = False

    End Sub

    Private Sub CheckBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        BackColor = Color.Green
        reset()
        CheckBox1.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        BackColor = Color.Blue
        reset()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Sub reset()
        '.cheked llama al evento uso checkstate que solo lee el estado
        If (CheckBox1.CheckState = CheckState.Unchecked And CheckBox2.CheckState = CheckState.Unchecked And CheckBox3.CheckState = CheckState.Unchecked) Then
            Me.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub botonVacio(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button3.Click
        MsgBox("boton sin contenido")
        'popup y dos eventos enviados al mismo sub, tambien se le cambia el nombre el sub
    End Sub

End Class
