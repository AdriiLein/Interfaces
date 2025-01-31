Imports System.IO

Public Class Form1

    Dim a As usuario
    Dim estado As Boolean = False 'boton de borrado solo si un item esta seleccionado

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abrelista()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cierralista()
        a = New usuario(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        addlista(a)
    End Sub

    Private Sub salir()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        salir()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cierralista()
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        pinta()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim a As String = ListBox1.SelectedItem
        MessageBox.Show(a)
        If ListBox1.SelectedItem <> "" Then
            estado = True
            pinta()
        End If
    End Sub

    Private Sub borra()
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        estado = False
        pinta()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        borra()
    End Sub

    Private Sub exportar()
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName = "" Then Exit Sub


        'montar el texto
        Dim texto As String = ""
        For Each linea In ListBox1.Items
            texto &= linea & vbCrLf
        Next

        'salvar al fichero de texto
        Dim oEscritor As StreamWriter
        oEscritor = File.CreateText(SaveFileDialog1.FileName)
        oEscritor.Write(texto)
        oEscritor.Close()
        pinta()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        exportar()
    End Sub

    Private Sub importar()
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt"
        OpenFileDialog1.ShowDialog()
        'open file y cargar el listbox
        Dim linea As String
        ListBox1.Items.Clear()
        Dim oLector As New StreamReader(OpenFileDialog1.FileName)
        linea = oLector.ReadLine()
        Do While Not (linea Is Nothing)
            ListBox1.Items.Add(linea)
            linea = oLector.ReadLine()
        Loop
        oLector.Close()
        estado = False
        pinta()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        importar()
    End Sub

    Private Sub limpiar()
        ListBox1.Items.Clear()
        estado = False
        pinta()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        limpiar()
    End Sub

    Private Sub pinta()
        boton2(estado)
        '        Button2.Enabled = estado
    End Sub

    Private Sub abrelista()
        ListBox1.Visible = False
        GroupBox1.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        boton2(False)
        '        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub cierralista()
        GroupBox1.Visible = False
        ListBox1.Visible = True
        boton2(estado)
        '        Button2.Enabled = estado
        Button3.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub addlista(ByVal a)
        ListBox1.Items.Add(a.out)
    End Sub

    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        importar()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        exportar()
    End Sub

    Private Sub NuevoContactoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoContactoToolStripMenuItem.Click
        abrelista()
    End Sub

    Private Sub BorrarContactoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarContactoToolStripMenuItem.Click
        borra()
    End Sub

    Private Sub LimpiarPantallaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarPantallaToolStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        Dim ofrmDialogo As New Dialog1()
        ' dar una posición al formulario
        ofrmDialogo.StartPosition = FormStartPosition.CenterParent
        ' mostrarlo de forma modal, como cuadro de diálogo
        ofrmDialogo.ShowDialog()
    End Sub

    Private Sub boton2(ByVal a As Boolean)
        Button2.Enabled = a
        BorrarContactoToolStripMenuItem.Enabled = a
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiar()
    End Sub
End Class

Public Class usuario
    Dim nombre As String
    Dim telefono As String
    Dim direccion As String

    Sub New(ByVal a As String, ByVal b As String, ByVal c As String)
        nombre = a
        telefono = b
        direccion = c
    End Sub

    ReadOnly Property out()
        Get
            Return nombre & " " & telefono & " " & direccion
        End Get
    End Property
End Class
