<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiguraDibujada
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
        Me.Pic = New System.Windows.Forms.PictureBox
        Me.lbl = New System.Windows.Forms.Label
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(206, 188)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Pic
        '
        Me.Pic.InitialImage = Nothing
        Me.Pic.Location = New System.Drawing.Point(12, 23)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(276, 159)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Pic.TabIndex = 5
        Me.Pic.TabStop = False
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(12, 7)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(276, 13)
        Me.lbl.TabIndex = 6
        '
        'frmFiguraDibujada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 219)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFiguraDibujada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Figura Dibujada"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents lbl As System.Windows.Forms.Label
End Class
