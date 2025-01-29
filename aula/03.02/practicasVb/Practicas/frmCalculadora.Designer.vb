<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnC = New System.Windows.Forms.Button
        Me.btnRetroceso = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtDysplay = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnDivision = New System.Windows.Forms.Button
        Me.btnMultiplicar = New System.Windows.Forms.Button
        Me.btnResta = New System.Windows.Forms.Button
        Me.btnSuma = New System.Windows.Forms.Button
        Me.btnIgual = New System.Windows.Forms.Button
        Me.btnMasMenos = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPunto = New System.Windows.Forms.Button
        Me.btnNueve = New System.Windows.Forms.Button
        Me.btnCero = New System.Windows.Forms.Button
        Me.btnOcho = New System.Windows.Forms.Button
        Me.btnSiete = New System.Windows.Forms.Button
        Me.btnSeis = New System.Windows.Forms.Button
        Me.btnCinco = New System.Windows.Forms.Button
        Me.btnCuatro = New System.Windows.Forms.Button
        Me.btnTres = New System.Windows.Forms.Button
        Me.btnDos = New System.Windows.Forms.Button
        Me.btnUno = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnC)
        Me.GroupBox4.Controls.Add(Me.btnRetroceso)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 231)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'btnC
        '
        Me.btnC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnC.Location = New System.Drawing.Point(151, 57)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(67, 24)
        Me.btnC.TabIndex = 24
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnRetroceso
        '
        Me.btnRetroceso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRetroceso.Location = New System.Drawing.Point(20, 57)
        Me.btnRetroceso.Name = "btnRetroceso"
        Me.btnRetroceso.Size = New System.Drawing.Size(67, 24)
        Me.btnRetroceso.TabIndex = 23
        Me.btnRetroceso.Text = "Retroceso"
        Me.btnRetroceso.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDysplay)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 37)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'txtDysplay
        '
        Me.txtDysplay.Location = New System.Drawing.Point(6, 11)
        Me.txtDysplay.MaxLength = 10
        Me.txtDysplay.Name = "txtDysplay"
        Me.txtDysplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDysplay.Size = New System.Drawing.Size(190, 20)
        Me.txtDysplay.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDivision)
        Me.GroupBox2.Controls.Add(Me.btnMultiplicar)
        Me.GroupBox2.Controls.Add(Me.btnResta)
        Me.GroupBox2.Controls.Add(Me.btnSuma)
        Me.GroupBox2.Controls.Add(Me.btnIgual)
        Me.GroupBox2.Controls.Add(Me.btnMasMenos)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(82, 141)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'btnDivision
        '
        Me.btnDivision.ForeColor = System.Drawing.Color.Red
        Me.btnDivision.Location = New System.Drawing.Point(45, 49)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(30, 24)
        Me.btnDivision.TabIndex = 22
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.ForeColor = System.Drawing.Color.Red
        Me.btnMultiplicar.Location = New System.Drawing.Point(8, 49)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(30, 24)
        Me.btnMultiplicar.TabIndex = 21
        Me.btnMultiplicar.Text = "x"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.ForeColor = System.Drawing.Color.Red
        Me.btnResta.Location = New System.Drawing.Point(44, 19)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(30, 24)
        Me.btnResta.TabIndex = 20
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.ForeColor = System.Drawing.Color.Red
        Me.btnSuma.Location = New System.Drawing.Point(8, 19)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(30, 24)
        Me.btnSuma.TabIndex = 19
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.ForeColor = System.Drawing.Color.Red
        Me.btnIgual.Location = New System.Drawing.Point(8, 109)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(67, 24)
        Me.btnIgual.TabIndex = 18
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnMasMenos
        '
        Me.btnMasMenos.ForeColor = System.Drawing.Color.Red
        Me.btnMasMenos.Location = New System.Drawing.Point(44, 79)
        Me.btnMasMenos.Name = "btnMasMenos"
        Me.btnMasMenos.Size = New System.Drawing.Size(30, 24)
        Me.btnMasMenos.TabIndex = 17
        Me.btnMasMenos.Text = "+/-"
        Me.btnMasMenos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPunto)
        Me.GroupBox1.Controls.Add(Me.btnNueve)
        Me.GroupBox1.Controls.Add(Me.btnCero)
        Me.GroupBox1.Controls.Add(Me.btnOcho)
        Me.GroupBox1.Controls.Add(Me.btnSiete)
        Me.GroupBox1.Controls.Add(Me.btnSeis)
        Me.GroupBox1.Controls.Add(Me.btnCinco)
        Me.GroupBox1.Controls.Add(Me.btnCuatro)
        Me.GroupBox1.Controls.Add(Me.btnTres)
        Me.GroupBox1.Controls.Add(Me.btnDos)
        Me.GroupBox1.Controls.Add(Me.btnUno)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 141)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnPunto
        '
        Me.btnPunto.ForeColor = System.Drawing.Color.Red
        Me.btnPunto.Location = New System.Drawing.Point(78, 109)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(30, 24)
        Me.btnPunto.TabIndex = 22
        Me.btnPunto.Text = "."
        Me.btnPunto.UseVisualStyleBackColor = True
        '
        'btnNueve
        '
        Me.btnNueve.Location = New System.Drawing.Point(78, 19)
        Me.btnNueve.Name = "btnNueve"
        Me.btnNueve.Size = New System.Drawing.Size(30, 24)
        Me.btnNueve.TabIndex = 20
        Me.btnNueve.Text = "9"
        Me.btnNueve.UseVisualStyleBackColor = True
        '
        'btnCero
        '
        Me.btnCero.Location = New System.Drawing.Point(6, 109)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(30, 24)
        Me.btnCero.TabIndex = 19
        Me.btnCero.Text = "0"
        Me.btnCero.UseVisualStyleBackColor = True
        '
        'btnOcho
        '
        Me.btnOcho.Location = New System.Drawing.Point(42, 19)
        Me.btnOcho.Name = "btnOcho"
        Me.btnOcho.Size = New System.Drawing.Size(30, 24)
        Me.btnOcho.TabIndex = 18
        Me.btnOcho.Text = "8"
        Me.btnOcho.UseVisualStyleBackColor = True
        '
        'btnSiete
        '
        Me.btnSiete.Location = New System.Drawing.Point(6, 19)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(30, 24)
        Me.btnSiete.TabIndex = 17
        Me.btnSiete.Text = "7"
        Me.btnSiete.UseVisualStyleBackColor = True
        '
        'btnSeis
        '
        Me.btnSeis.Location = New System.Drawing.Point(78, 49)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(30, 24)
        Me.btnSeis.TabIndex = 16
        Me.btnSeis.Text = "6"
        Me.btnSeis.UseVisualStyleBackColor = True
        '
        'btnCinco
        '
        Me.btnCinco.Location = New System.Drawing.Point(42, 49)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(30, 24)
        Me.btnCinco.TabIndex = 15
        Me.btnCinco.Text = "5"
        Me.btnCinco.UseVisualStyleBackColor = True
        '
        'btnCuatro
        '
        Me.btnCuatro.Location = New System.Drawing.Point(6, 49)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(30, 24)
        Me.btnCuatro.TabIndex = 14
        Me.btnCuatro.Text = "4"
        Me.btnCuatro.UseVisualStyleBackColor = True
        '
        'btnTres
        '
        Me.btnTres.Location = New System.Drawing.Point(78, 79)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(30, 24)
        Me.btnTres.TabIndex = 13
        Me.btnTres.Text = "3"
        Me.btnTres.UseVisualStyleBackColor = True
        '
        'btnDos
        '
        Me.btnDos.Location = New System.Drawing.Point(42, 79)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(30, 24)
        Me.btnDos.TabIndex = 12
        Me.btnDos.Text = "2"
        Me.btnDos.UseVisualStyleBackColor = True
        '
        'btnUno
        '
        Me.btnUno.Location = New System.Drawing.Point(6, 79)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(30, 24)
        Me.btnUno.TabIndex = 11
        Me.btnUno.Text = "1"
        Me.btnUno.UseVisualStyleBackColor = True
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 240)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCalculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents btnRetroceso As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDysplay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents btnMultiplicar As System.Windows.Forms.Button
    Friend WithEvents btnResta As System.Windows.Forms.Button
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents btnIgual As System.Windows.Forms.Button
    Friend WithEvents btnMasMenos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNueve As System.Windows.Forms.Button
    Friend WithEvents btnCero As System.Windows.Forms.Button
    Friend WithEvents btnOcho As System.Windows.Forms.Button
    Friend WithEvents btnSiete As System.Windows.Forms.Button
    Friend WithEvents btnSeis As System.Windows.Forms.Button
    Friend WithEvents btnCinco As System.Windows.Forms.Button
    Friend WithEvents btnCuatro As System.Windows.Forms.Button
    Friend WithEvents btnTres As System.Windows.Forms.Button
    Friend WithEvents btnDos As System.Windows.Forms.Button
    Friend WithEvents btnUno As System.Windows.Forms.Button
    Friend WithEvents btnPunto As System.Windows.Forms.Button
End Class
