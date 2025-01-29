'Importo el espacio de nombre System.Drawing
Imports System.Drawing

Public Class frmDibujaFiguras

    Public Shared Activo As Boolean

    Private Sub btnDibujar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDibujar.Click

        'Si el formulario FiguraDibujada no esta activo lo genero
        If Not Activo Then
            If Not ValidaDatos() Then Exit Sub 'Valido lo datos para ver si esta todo seleccionado
            Activo = True 'Activo la bandera de formulario activo 

            'Indico al otro formulario que tipo de figura he selecionado
            If optCuadrado.Checked Then
                frmFiguraDibujada.Figura = optCuadrado.Text
            ElseIf optRectangulo.Checked Then
                frmFiguraDibujada.Figura = optRectangulo.Text
            ElseIf optCirculo.Checked Then
                frmFiguraDibujada.Figura = optCirculo.Text
            ElseIf optTriangulo.Checked Then
                frmFiguraDibujada.Figura = optTriangulo.Text
            End If

            'Indico al otro formulario que tipo color tendrá la figura selecionada
            For i As Integer = 0 To lstColores.Items.Count - 1
                If lstColores.Items.Item(i) Is lstColores.SelectedItem Then
                    frmFiguraDibujada.Color = lstColores.Items.Item(i).ToString
                    Exit For
                End If
            Next
        End If

        'Indico al otro formulario la figura y el color de esta q aparecerá como texto 
        frmFiguraDibujada.lbl.Text = frmFiguraDibujada.Figura & " de color: " & frmFiguraDibujada.Color

        frmFiguraDibujada.ShowDialog()
    End Sub

    Private Function ValidaDatos() As Boolean
        Dim flag As Boolean

        If optCuadrado.Checked Or optRectangulo.Checked Or optCirculo.Checked Or optTriangulo.Checked Then flag = True

        If Not flag Then
            MessageBox.Show("Seleccione una figura")
            Exit Function
        End If

        For i As Integer = 0 To lstColores.Items.Count - 1
            If lstColores.Items.Item(i) Is lstColores.SelectedItem Then
                flag = True
                Exit For
            End If
        Next

        If Not flag Then
            MessageBox.Show("Seleccione un color para la figura")
            Exit Function
        End If

        ValidaDatos = True
    End Function
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class