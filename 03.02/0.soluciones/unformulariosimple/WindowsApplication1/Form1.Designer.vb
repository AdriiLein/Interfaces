<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnFin = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnLetras = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNumeros = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(17, 180)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(75, 23)
        Me.btnFin.TabIndex = 0
        Me.btnFin.Text = "SALIR"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox1.Location = New System.Drawing.Point(113, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(187, 191)
        Me.TextBox1.TabIndex = 1
        '
        'btnLetras
        '
        Me.btnLetras.Location = New System.Drawing.Point(17, 15)
        Me.btnLetras.Name = "btnLetras"
        Me.btnLetras.Size = New System.Drawing.Size(75, 23)
        Me.btnLetras.TabIndex = 2
        Me.btnLetras.Text = "LETRAS"
        Me.btnLetras.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "LIMPIA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNumeros
        '
        Me.btnNumeros.Location = New System.Drawing.Point(17, 44)
        Me.btnNumeros.Name = "btnNumeros"
        Me.btnNumeros.Size = New System.Drawing.Size(75, 23)
        Me.btnNumeros.TabIndex = 4
        Me.btnNumeros.Text = "NUMEROS"
        Me.btnNumeros.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 102)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(22, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 221)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnNumeros)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLetras)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnFin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFin As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnLetras As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNumeros As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
