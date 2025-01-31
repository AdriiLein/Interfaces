<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDibujaFiguras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnDibujar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lstColores = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optTriangulo = New System.Windows.Forms.RadioButton
        Me.optCirculo = New System.Windows.Forms.RadioButton
        Me.optRectangulo = New System.Windows.Forms.RadioButton
        Me.optCuadrado = New System.Windows.Forms.RadioButton
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(193, 210)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnDibujar)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 195)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleciona una figura y un color"
        '
        'btnDibujar
        '
        Me.btnDibujar.Location = New System.Drawing.Point(168, 166)
        Me.btnDibujar.Name = "btnDibujar"
        Me.btnDibujar.Size = New System.Drawing.Size(87, 23)
        Me.btnDibujar.TabIndex = 5
        Me.btnDibujar.Text = "Dibujar"
        Me.btnDibujar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstColores)
        Me.GroupBox2.Location = New System.Drawing.Point(140, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 135)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Colores"
        '
        'lstColores
        '
        Me.lstColores.FormattingEnabled = True
        Me.lstColores.Items.AddRange(New Object() {"Blanco", "Azul", "Rojo", "Negro", "Verde", "Amarillo", "Marron", "Violeta"})
        Me.lstColores.Location = New System.Drawing.Point(6, 19)
        Me.lstColores.Name = "lstColores"
        Me.lstColores.Size = New System.Drawing.Size(101, 108)
        Me.lstColores.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optTriangulo)
        Me.GroupBox1.Controls.Add(Me.optCirculo)
        Me.GroupBox1.Controls.Add(Me.optRectangulo)
        Me.GroupBox1.Controls.Add(Me.optCuadrado)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 135)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Figuras"
        '
        'optTriangulo
        '
        Me.optTriangulo.AutoSize = True
        Me.optTriangulo.Location = New System.Drawing.Point(16, 95)
        Me.optTriangulo.Name = "optTriangulo"
        Me.optTriangulo.Size = New System.Drawing.Size(69, 17)
        Me.optTriangulo.TabIndex = 3
        Me.optTriangulo.TabStop = True
        Me.optTriangulo.Text = "Triángulo"
        Me.optTriangulo.UseVisualStyleBackColor = True
        '
        'optCirculo
        '
        Me.optCirculo.AutoSize = True
        Me.optCirculo.Location = New System.Drawing.Point(16, 72)
        Me.optCirculo.Name = "optCirculo"
        Me.optCirculo.Size = New System.Drawing.Size(59, 17)
        Me.optCirculo.TabIndex = 2
        Me.optCirculo.TabStop = True
        Me.optCirculo.Text = "Círculo"
        Me.optCirculo.UseVisualStyleBackColor = True
        '
        'optRectangulo
        '
        Me.optRectangulo.AutoSize = True
        Me.optRectangulo.Location = New System.Drawing.Point(16, 49)
        Me.optRectangulo.Name = "optRectangulo"
        Me.optRectangulo.Size = New System.Drawing.Size(80, 17)
        Me.optRectangulo.TabIndex = 1
        Me.optRectangulo.TabStop = True
        Me.optRectangulo.Text = "Rectángulo"
        Me.optRectangulo.UseVisualStyleBackColor = True
        '
        'optCuadrado
        '
        Me.optCuadrado.AutoSize = True
        Me.optCuadrado.Location = New System.Drawing.Point(16, 26)
        Me.optCuadrado.Name = "optCuadrado"
        Me.optCuadrado.Size = New System.Drawing.Size(71, 17)
        Me.optCuadrado.TabIndex = 0
        Me.optCuadrado.TabStop = True
        Me.optCuadrado.Text = "Cuadrado"
        Me.optCuadrado.UseVisualStyleBackColor = True
        '
        'frmDibujaFiguras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 239)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDibujaFiguras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dibuja Figuras"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstColores As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optTriangulo As System.Windows.Forms.RadioButton
    Friend WithEvents optCirculo As System.Windows.Forms.RadioButton
    Friend WithEvents optRectangulo As System.Windows.Forms.RadioButton
    Friend WithEvents optCuadrado As System.Windows.Forms.RadioButton
    Friend WithEvents btnDibujar As System.Windows.Forms.Button
End Class
