Public Class Form1

    ' Algunos elementos para la interfaz del usuario

    'MenuStrip   0) click 1) arbol 2) visible 3) enabled
    'ContextMenuStrip , menu contextual
    'ToolStrip , barra de iconos
    'ProgressBar , barra de progreso , 1) maximun
    'Timer , 1) start 2) stop 3) initial 4) tick

    'Doevents
    'http://msdn.microsoft.com/es-es/library/bd65th41(v=vs.90).aspx

    'Designer
    'Acceso a todo el codigo de mi aplicacion

    Dim contador As Integer = 0

    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoToolStripMenuItem.Click
        EjecutarToolStripMenuItem.Visible = True
    End Sub

    Private Sub OtraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtraToolStripMenuItem.Click
        Label1.Text = "otra"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Label1.Text = "open"
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Label1.Text = "close"
    End Sub

    Private Sub BastaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BastaToolStripMenuItem.Click
        ApagadoToolStripMenuItem.Enabled = True
        ApagadoToolStripMenuItem.Text = "encendido"
    End Sub

    Private Sub SoyAzulToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoyAzulToolStripMenuItem.Click
        Label1.BackColor = Color.Blue
    End Sub

    Private Sub SoyRojoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoyRojoToolStripMenuItem.Click
        Label1.BackColor = Color.Red
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Label1.Text = "soy un icono"
    End Sub

    Private Sub ToolStripProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripProgressBar1.Click
        ToolStripProgressBar1.Value = 20
        ToolStripProgressBar1.Maximum = 100
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        contador += 1
        If contador = 100 Then
            Timer1.Stop()
            Label2.Visible = False
            ToolStripProgressBar1.Visible = False
        End If
        Label2.Text = contador
        ToolStripProgressBar1.Value = contador
    End Sub

    Private Sub dale()
        For j As Integer = 1 To 10000
            'My.Application.DoEvents()
            Button1.Text = j
        Next j
        Button1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dale()
    End Sub

    Public Sub DoEvents()

    End Sub

    Private Sub SssToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SssToolStripMenuItem.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ApagadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApagadoToolStripMenuItem.Click

    End Sub

    Private Sub EjecutarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjecutarToolStripMenuItem.Click

    End Sub
End Class
