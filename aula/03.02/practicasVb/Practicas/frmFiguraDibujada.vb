'Espacio de nombres del sistema para poder realizar dibujos 
Imports System.Drawing


Public Class frmFiguraDibujada
    'Variable que se cargaran con los datos seleccionado en frmDibuja figuras 
    Public Shared Color As String
    Public Shared Figura As String


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        'Indico que el formulario se ha cerrado para que se pueda volver a mostrar
        frmDibujaFiguras.Activo = False
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub PintaFigura()
        Dim color_borde As New Pen(Drawing.Color.AliceBlue)
        Dim color_fondo As New SolidBrush(Drawing.Color.AliceBlue)
        Dim alto As Integer = 100
        Dim ancho As Integer = 180
        Dim x As Integer = 100
        Dim y As Integer = 20

        Dim gr As Graphics = Pic.CreateGraphics

        'Selecciono el color de la linea y de el interior de la figura
        Select Case Color
            Case "Rojo"
                lbl.ForeColor = Drawing.Color.Red
                color_fondo.Color = Drawing.Color.Red
                color_borde = Pens.Red
            Case "Amarillo"
                lbl.ForeColor = Drawing.Color.Yellow
                color_fondo.Color = Drawing.Color.Yellow
                color_borde = Pens.Yellow
            Case "Blanco"
                lbl.ForeColor = Drawing.Color.White
                color_fondo.Color = Drawing.Color.White
                color_borde = Pens.White
            Case "Negro"
                lbl.ForeColor = Drawing.Color.Black
                color_fondo.Color = Drawing.Color.Black
                color_borde = Pens.Black
            Case "Verde"
                lbl.ForeColor = Drawing.Color.Green
                color_fondo.Color = Drawing.Color.Green
                color_borde = Pens.Green
            Case "Marron"
                lbl.ForeColor = Drawing.Color.Brown
                color_fondo.Color = Drawing.Color.Brown
                color_borde = Pens.Brown
            Case "Violeta"
                color_fondo.Color = Drawing.Color.Violet
                color_borde = Pens.Violet
            Case "Azul"
                lbl.ForeColor = Drawing.Color.Blue
                color_fondo.Color = Drawing.Color.Blue
                color_borde = Pens.Blue
        End Select

        'Dibujo el tipo de figura que va a ser y la relleno con el color seleccionado
        'el gr.Draw+figura dibuja la figura y el gr.Fill+figura la reyena
        Select Case Figura
            Case "Cuadrado"
                gr.DrawRectangle(color_borde, x, y, alto, (ancho - 80))
                gr.FillRectangle(color_fondo, x + 1, y + 1, alto + 1, (ancho - 80) + 1)
            Case "Rectángulo"
                gr.DrawRectangle(color_borde, x, y, alto, ancho)
                gr.FillRectangle(color_fondo, x + 1, y + 1, alto + 1, ancho + 1)
            Case "Círculo"
                gr.DrawEllipse(color_borde, x, y, alto, ancho - 80)
                gr.FillEllipse(color_fondo, x + 1, y + 1, alto + 1, (ancho - 80) + 1)
            Case "Triángulo"
                Dim Pts(2) As Point
                Pts(0) = New Point(5, 180)
                Pts(1) = New Point(126, 30)
                Pts(2) = New Point(255, 180)
                gr.DrawPolygon(color_borde, Pts)
                gr.FillPolygon(color_fondo, Pts)
        End Select

        gr.Dispose() 'Libreo recursos

    End Sub

    Private Sub frmFiguraDibujada_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        'Llamada al procedimiento donde se se pintará y se coloreará la figura
        PintaFigura()
    End Sub

End Class