'vb: form showdialog, screen(Height,Width,Top,Left,ClientSize)designer,MaximizeBox MinimizeBox Dialog,random randomize,
'vb: messagebox,imports,if :, 

Imports System.Windows.Forms

Public Class frmMueveFrm2

    Dim AlturaPantalla As Integer
    Dim AnchuraPantalla As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub MoverFrm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrIzq.Click, btnArrDch.Click, btnAbjIzq.Click, btnAbjDch.Click, btnAleatoria.Click
        Dim r As New Random 'clase usada para obtener valores aleatorio
        AlturaPantalla = Screen.PrimaryScreen.Bounds.Height - Me.Height
        AnchuraPantalla = Screen.PrimaryScreen.Bounds.Width - Me.Width
        If sender Is btnArrIzq Then
            Me.Top = 0
            Me.Left = 0
        ElseIf sender Is btnArrDch Then
            Me.Top = 0
            Me.Left = AnchuraPantalla
        ElseIf sender Is btnAbjIzq Then
            Me.Top = AlturaPantalla
            Me.Left = 0
        ElseIf sender Is btnAbjDch Then
            Me.Top = AlturaPantalla
            Me.Left = AnchuraPantalla
        ElseIf sender Is btnAleatoria Then
            Randomize()
            'Me.Top = CInt(AlturaPantalla * Rnd()) + 0
            'Me.Left = CInt(AnchuraPantalla * Rnd()) + 0
            Me.Top = r.Next(AlturaPantalla)
            Me.Left = r.Next(AnchuraPantalla)
        End If
    End Sub

    Private Sub frmMueveFrm2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MessageBox.Show("Pulsa los botones, foco")
    End Sub

    Private Sub frmMueveFrm2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        MessageBox.Show("Pulsa los botones")
    End Sub

    Private Sub frmMueveFrm2_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Me.Text = Me.Location.X.ToString & ":" & Me.Location.Y.ToString
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim w, h As Integer
        If ComboBox1.SelectedItem Is "pequeña" Then
            w = 300 : h = 300 'operador : ejecuta las instrucciones en orden
        ElseIf ComboBox1.SelectedItem Is "mediana" Then
            w = 500 : h = 450
        ElseIf ComboBox1.SelectedItem Is "grande" Then
            w = 800 : h = 600
        End If
        'obtenido del designer
        Me.ClientSize = New System.Drawing.Size(w, h)
        Me.Top = CInt((Screen.PrimaryScreen.Bounds.Height - h) / 2)
        Me.Left = CInt((Screen.PrimaryScreen.Bounds.Width - w) / 2)
    End Sub

End Class