<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMueveFrm2
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
        Me.btnArrIzq = New System.Windows.Forms.Button
        Me.btnArrDch = New System.Windows.Forms.Button
        Me.btnAbjIzq = New System.Windows.Forms.Button
        Me.btnAbjDch = New System.Windows.Forms.Button
        Me.btnAleatoria = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnArrIzq
        '
        Me.btnArrIzq.Location = New System.Drawing.Point(12, 12)
        Me.btnArrIzq.Name = "btnArrIzq"
        Me.btnArrIzq.Size = New System.Drawing.Size(61, 47)
        Me.btnArrIzq.TabIndex = 0
        Me.btnArrIzq.Text = "Arriba Izquierda"
        Me.btnArrIzq.UseVisualStyleBackColor = True
        '
        'btnArrDch
        '
        Me.btnArrDch.Location = New System.Drawing.Point(219, 12)
        Me.btnArrDch.Name = "btnArrDch"
        Me.btnArrDch.Size = New System.Drawing.Size(61, 47)
        Me.btnArrDch.TabIndex = 1
        Me.btnArrDch.Text = "Arriba Derecha"
        Me.btnArrDch.UseVisualStyleBackColor = True
        '
        'btnAbjIzq
        '
        Me.btnAbjIzq.Location = New System.Drawing.Point(12, 214)
        Me.btnAbjIzq.Name = "btnAbjIzq"
        Me.btnAbjIzq.Size = New System.Drawing.Size(61, 47)
        Me.btnAbjIzq.TabIndex = 2
        Me.btnAbjIzq.Text = "Abajo Izquierda"
        Me.btnAbjIzq.UseVisualStyleBackColor = True
        '
        'btnAbjDch
        '
        Me.btnAbjDch.Location = New System.Drawing.Point(219, 214)
        Me.btnAbjDch.Name = "btnAbjDch"
        Me.btnAbjDch.Size = New System.Drawing.Size(61, 47)
        Me.btnAbjDch.TabIndex = 3
        Me.btnAbjDch.Text = "Abajo Derecha"
        Me.btnAbjDch.UseVisualStyleBackColor = True
        '
        'btnAleatoria
        '
        Me.btnAleatoria.Location = New System.Drawing.Point(115, 113)
        Me.btnAleatoria.Name = "btnAleatoria"
        Me.btnAleatoria.Size = New System.Drawing.Size(61, 47)
        Me.btnAleatoria.TabIndex = 4
        Me.btnAleatoria.Text = "Poscion Aleatoria"
        Me.btnAleatoria.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(100, 240)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 21)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"pequeña", "mediana", "grande"})
        Me.ComboBox1.Location = New System.Drawing.Point(85, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'frmMueveFrm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 273)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAleatoria)
        Me.Controls.Add(Me.btnAbjDch)
        Me.Controls.Add(Me.btnAbjIzq)
        Me.Controls.Add(Me.btnArrDch)
        Me.Controls.Add(Me.btnArrIzq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMueveFrm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mueve tu formulario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArrIzq As System.Windows.Forms.Button
    Friend WithEvents btnArrDch As System.Windows.Forms.Button
    Friend WithEvents btnAbjIzq As System.Windows.Forms.Button
    Friend WithEvents btnAbjDch As System.Windows.Forms.Button
    Friend WithEvents btnAleatoria As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
