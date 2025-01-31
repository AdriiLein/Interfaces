<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DialogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FicherosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorDeLetrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContarPalabrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContarLetrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContarBlancosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContarNumerosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.dlgGrabar = New System.Windows.Forms.SaveFileDialog
        Me.dlgAbrir = New System.Windows.Forms.OpenFileDialog
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DialogosToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(409, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DialogosToolStripMenuItem
        '
        Me.DialogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicherosToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.FuentesToolStripMenuItem, Me.ColoresToolStripMenuItem, Me.ColorDeLetrasToolStripMenuItem})
        Me.DialogosToolStripMenuItem.Name = "DialogosToolStripMenuItem"
        Me.DialogosToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        Me.DialogosToolStripMenuItem.Text = "opciones"
        '
        'FicherosToolStripMenuItem
        '
        Me.FicherosToolStripMenuItem.Name = "FicherosToolStripMenuItem"
        Me.FicherosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.FicherosToolStripMenuItem.Text = "abrir texto"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.GuardarToolStripMenuItem.Text = "guardar texto"
        '
        'FuentesToolStripMenuItem
        '
        Me.FuentesToolStripMenuItem.Name = "FuentesToolStripMenuItem"
        Me.FuentesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.FuentesToolStripMenuItem.Text = "cambiar fuente"
        '
        'ColoresToolStripMenuItem
        '
        Me.ColoresToolStripMenuItem.Name = "ColoresToolStripMenuItem"
        Me.ColoresToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ColoresToolStripMenuItem.Text = "color de fondo"
        '
        'ColorDeLetrasToolStripMenuItem
        '
        Me.ColorDeLetrasToolStripMenuItem.Name = "ColorDeLetrasToolStripMenuItem"
        Me.ColorDeLetrasToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ColorDeLetrasToolStripMenuItem.Text = "color de letras"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContarPalabrasToolStripMenuItem, Me.ContarLetrasToolStripMenuItem, Me.ContarBlancosToolStripMenuItem, Me.ContarNumerosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.HerramientasToolStripMenuItem.Text = "herramientas"
        '
        'ContarPalabrasToolStripMenuItem
        '
        Me.ContarPalabrasToolStripMenuItem.Name = "ContarPalabrasToolStripMenuItem"
        Me.ContarPalabrasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ContarPalabrasToolStripMenuItem.Text = "contar palabras"
        '
        'ContarLetrasToolStripMenuItem
        '
        Me.ContarLetrasToolStripMenuItem.Name = "ContarLetrasToolStripMenuItem"
        Me.ContarLetrasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ContarLetrasToolStripMenuItem.Text = "contar letras"
        '
        'ContarBlancosToolStripMenuItem
        '
        Me.ContarBlancosToolStripMenuItem.Name = "ContarBlancosToolStripMenuItem"
        Me.ContarBlancosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ContarBlancosToolStripMenuItem.Text = "contar blancos"
        '
        'ContarNumerosToolStripMenuItem
        '
        Me.ContarNumerosToolStripMenuItem.Name = "ContarNumerosToolStripMenuItem"
        Me.ContarNumerosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ContarNumerosToolStripMenuItem.Text = "contar numeros"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(60, 22)
        Me.AyudaToolStripMenuItem.Text = "ayuda"
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(16, 48)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 237)
        Me.TextBox1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 26)
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LimpiarToolStripMenuItem.Text = "limpiar"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowApply = True
        '
        'dlgAbrir
        '
        Me.dlgAbrir.FileName = "OpenFileDialog1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(16, 293)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(376, 48)
        Me.TextBox2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 358)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Control 5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DialogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FicherosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents dlgGrabar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarPalabrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarLetrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarBlancosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContarNumerosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ColorDeLetrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
