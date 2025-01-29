Imports System.Windows.Forms
Public Class frmMueveFrm
    Dim AlturaPantalla As Integer = Screen.PrimaryScreen.Bounds.Height - Me.Height
    Dim AnchuraPantalla As Integer = Screen.PrimaryScreen.Bounds.Width - Me.Width


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub MoverFrm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrIzq.Click, btnArrDch.Click, btnAbjIzq.Click, btnAbjDch.Click, btnAleatoria.Click
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
            Me.Top = CInt(AlturaPantalla * Rnd()) + 0
            Me.Left = CInt(AnchuraPantalla * Rnd()) + 0
        End If
    End Sub
End Class