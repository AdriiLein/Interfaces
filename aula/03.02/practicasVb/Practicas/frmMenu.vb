Public Class frmMenu

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub MoverFormularioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverFormularioToolStripMenuItem.Click
        frmMueveFrm.ShowDialog()
    End Sub

    Private Sub PruenaTuMente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PruenaTuMente.Click
        frmPruebaTuMente.ShowDialog()
    End Sub

    Private Sub Sorteo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorteo.Click
        frmSorteo.ShowDialog()
    End Sub

    Private Sub Calculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculadora.Click
        frmCalculadora.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmDibujaFiguras.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        frmAgenda.ShowDialog()
    End Sub

    Private Sub mnuAcercaDe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show("Practicas Dait " & Microsoft.VisualBasic.ChrW(13) & "Autor: Francisco Muñoz Aguado" & Microsoft.VisualBasic.ChrW(13) & "Curso: 2006/2007" _
        & Microsoft.VisualBasic.ChrW(13) & "Turno: Tarde" & Microsoft.VisualBasic.ChrW(13) & "Centro: I.E.S Clara del Rey", "Acerda de : Practicas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MoverForm2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoverForm2ToolStripMenuItem.Click
        frmMueveFrm2.ShowDialog()
    End Sub

    Private Sub Sorteo2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPruebaTuMente2.ShowDialog()
    End Sub

    Private Sub Calc2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calc2ToolStripMenuItem.Click
        frmCalc2.ShowDialog()
    End Sub

End Class
