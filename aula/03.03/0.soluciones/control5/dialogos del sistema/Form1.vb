'vb: new, showdialog, streamwriter, streamreader, string, replace, split, for each, &, 

'Control 5
'---------
'(1) barra de menus
'(1) manejo opciones: colores, fuentes
'(3) menu herramientas
'(1) menu opciones: abrir y guardar
'(1) ventana de ayuda
'(1) menu contextual
'(1) opcion limpiar
'(1) manejar el apagado/encendido de las opciones si no hay ningun texto,
'    abrir quedara siempre activada

' herramientas: opciones: palabras , letras , numeros , blancos
' opcion limpiar: eliminar texto, colores iniciales

Public Class Form1

    'valores iniciales
    Dim fuente As New Object
    Dim color As New Object
    Dim color2 As New Object

    Private Sub ColorDeLetrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorDeLetrasToolStripMenuItem.Click
        Me.ColorDialog1.ShowDialog()
        Me.TextBox1.ForeColor = Me.ColorDialog1.Color
    End Sub

    Private Sub ColoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColoresToolStripMenuItem.Click
        Me.ColorDialog1.ShowDialog()
        Me.TextBox1.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub aplicarfuente()
        Me.TextBox1.Font = Me.FontDialog1.Font
    End Sub

    Private Sub FuentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuentesToolStripMenuItem.Click
        Me.FontDialog1.ShowDialog()
        Me.aplicarfuente()
    End Sub

    Private Sub FontDialog1_Apply(ByVal sender As Object, ByVal e As System.EventArgs) Handles FontDialog1.Apply
        Me.aplicarfuente()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click

        Me.dlgGrabar.Filter = "Texto (*.txt)|*.txt"
        Me.dlgGrabar.FilterIndex = 2
        Me.dlgGrabar.ValidateNames = True
        Me.dlgGrabar.ShowDialog()

    End Sub



    Private Sub FicherosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FicherosToolStripMenuItem.Click

        ' Configurar el cuadro de diálogo por código
        Me.dlgAbrir.Title = "Seleccionar archivo a leer"
        Me.dlgAbrir.InitialDirectory = "."
        Me.dlgAbrir.Filter = "Código fuente (*.vb)|*.vb|Texto (*.txt)|*.txt"
        Me.dlgAbrir.FilterIndex = 2
        Me.dlgAbrir.ShowDialog()

        ' Abrir el primer archivo con un Stream y volcarlo al TextBox
        Dim srLector As New IO.StreamReader(Me.dlgAbrir.FileName)
        Me.TextBox1.Text = srLector.ReadToEnd()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim texto As String
        texto = "Control 5" & vbNewLine
        TextBox2.Text = texto
        fuente = TextBox1.Font
        color = TextBox1.ForeColor
        color2 = TextBox1.BackColor
    End Sub

    Private Sub ContarLetrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarLetrasToolStripMenuItem.Click
        Dim item As Char
        Dim j As Integer = 0
        For Each item In TextBox1.Text
            If (item >= "A" And item <= "Z") Or (item >= "a" And item <= "z") Then
                j += 1
            End If
        Next
        TextBox2.Text = "Numero de letras " & j
    End Sub

    Private Sub ContarPalabrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarPalabrasToolStripMenuItem.Click
        Dim lee As String
        Dim a As String()

        lee = TextBox1.Text
        lee = lee.Replace(" "c, "-"c)
        lee = lee.Replace(vbCr, "-"c)
        lee = lee.Replace(vbLf, "")
        a = Split(lee, "-"c)
        Dim c As Integer
        c = a.Length
        For Each item As String In a
            If item = " " Or item = "" Then c -= 1
        Next
        TextBox2.Text = "Numero de palabras " & c
    End Sub

    Private Sub ContarBlancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarBlancosToolStripMenuItem.Click
        Dim item As Char
        Dim j As Integer = 0
        For Each item In TextBox1.Text
            If (item = " ") Then
                j += 1
            End If
        Next
        TextBox2.Text = "Numero de blancos " & j
    End Sub

    Private Sub ContarNumerosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContarNumerosToolStripMenuItem.Click
        Dim item As Char
        Dim j As Integer = 0
        For Each item In TextBox1.Text
            If (item >= "0" And item <= "9") Then
                j += 1
            End If
        Next
        TextBox2.Text = "Numero de numeros " & j
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox1.Font = fuente
        TextBox1.ForeColor = color
        TextBox1.BackColor = color2
    End Sub

    Private Sub DialogosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogosToolStripMenuItem.Click

    End Sub

    Private Sub dlgGrabar_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dlgGrabar.FileOk
        Dim swEscritor As IO.StreamWriter
        swEscritor = New IO.StreamWriter(Me.dlgGrabar.FileName)
        swEscritor.Write(Me.TextBox1.Text)
        swEscritor.Close()
    End Sub
End Class
