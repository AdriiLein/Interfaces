Public Class frmCalculadora

    Dim Operador As String
    Dim ValorAux As Double


    Private Sub Bton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click, btnCero.Click, btnCinco.Click, btnCuatro.Click, _
    btnDos.Click, btnIgual.Click, btnMasMenos.Click, btnMultiplicar.Click, btnResta.Click, btnRetroceso.Click, btnSuma.Click, btnTres.Click, btnUno.Click, _
    btnSiete.Click, btnOcho.Click, btnNueve.Click, btnPunto.Click, btnSeis.Click, btnDivision.Click

        'Trnasformo el boton q manda la llamada en un objeto del tipo boton
        Dim Boton As Button = DirectCast(sender, Button)

        Select Case Boton.Name
            Case btnC.Name
                txtDysplay.Text = ""
                ValorAux = 0
            Case btnCero.Name
                txtDysplay.Text &= 0
            Case btnCinco.Name
                txtDysplay.Text &= 5
            Case btnCuatro.Name
                txtDysplay.Text &= 4
            Case btnDos.Name
                txtDysplay.Text &= 2
            Case btnMultiplicar.Name, btnResta.Name, btnSuma.Name, btnDivision.Name
                Operador = Boton.Text
                Dim Aux As Double
                Aux = Calculo()
                If Aux = Nothing Then
                    ValorAux = CDbl(txtDysplay.Text)
                    txtDysplay.Text = ""
                Else
                    ValorAux = 0
                    txtDysplay.Text = Aux.ToString
                End If
            Case btnIgual.Name
                Dim Aux As Double
                Aux = Calculo()
                If Aux = Nothing Then
                    ValorAux = CDbl(txtDysplay.Text)
                    txtDysplay.Text = ""
                Else
                    ValorAux = 0
                    txtDysplay.Text = Aux.ToString
                End If
            Case btnMasMenos.Name
                If CDbl(txtDysplay.Text) > 0 Then
                    txtDysplay.Text = "-" & txtDysplay.Text
                Else
                    txtDysplay.Text = txtDysplay.Text
                End If
            Case btnRetroceso.Name
                txtDysplay.Text = Mid(txtDysplay.Text, 1, Len(txtDysplay.Text) - 1)
            Case btnTres.Name
                txtDysplay.Text &= 3
            Case btnUno.Name
                txtDysplay.Text &= 1
            Case btnSiete.Name
                txtDysplay.Text &= 7
            Case btnOcho.Name
                txtDysplay.Text &= 8
            Case btnNueve.Name
                txtDysplay.Text &= 9
            Case btnNueve.Name
                txtDysplay.Text &= 6
            Case btnPunto.Name
                txtDysplay.Text &= "."

        End Select

    End Sub

    Private Function Calculo() As Double
        If ValorAux = 0 Then
            Return Nothing
        ElseIf ValorAux <> 0 Then
            Select Case Operador
                Case "+"
                    Return ValorAux + CDbl(txtDysplay.Text)
                Case "-"
                    Return ValorAux - CDbl(txtDysplay.Text)
                Case "x"
                    Return ValorAux * CDbl(txtDysplay.Text)
                Case "/"
                    Return ValorAux / CDbl(txtDysplay.Text)
                Case "="
                    Return ValorAux / CDbl(txtDysplay.Text)
            End Select
        End If
    End Function

    

End Class