'vb: handles multiple, addhandler, val, select case, CInt, StringBuilder, substring, new, DirectCast o CType

Option Strict On

Imports System.Text
Imports System.Drawing.Drawing2D


Public Class frmCalc2
    Private entrada As New StringBuilder
    Private oGraf As Graphics
    Private oGraf2 As Graphics
    Private c As New System.Drawing.Color
    Private ancho As Integer
    Dim ofont As Font

    'en designer al final del InitializeComponent podemos añadimos codigo y definimos evento para B1 tb se podria en el load

    Private Sub frmCalc2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oGraf = TextBox2.CreateGraphics() ' segunda forma de imprimir
        oGraf2 = PictureBox1.CreateGraphics() 'tercera forma de imprimir
        c = System.Drawing.Color.FromName("black")
        ofont = New Font(New FontFamily("Verdana"), 20)
    End Sub

    Private Sub teclas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click, _
    B0.Click, bMenos.Click, bMas.Click, bIgual.Click, bPunto.Click, bLimpiar.Click, _
    bEntre.Click, bPor.Click, B1.Click

        'salida3 resultado inmediato , caja3
        'salida12 resultado almacenado , caja1 y caja2

        Dim tecla As String = ""
        If sender IsNot bLimpiar Then
            tecla = DirectCast(sender, System.Windows.Forms.Button).Text ' enlace tardio poner option strict off
            entrada.Append(tecla)
            salida3(tecla)
            If tecla = "=" Then
                salida12(evalua())
                entrada.Remove(0, entrada.Length)
            Else
                salida12(entrada.ToString)
            End If
        Else
            entrada.Remove(0, entrada.Length)
            salida12(entrada.ToString)
            salida3("C")
        End If
    End Sub

    Private Function evalua() As String
        Dim c, operacion As String
        Dim resul, op2 As Double
        Dim top1 As Integer
        TextBox1.Text = ""
        operacion = ""
        top1 = 0
        op2 = 0
        resul = 0
        For x As Integer = 0 To entrada.Length - 1
            c = entrada.ToString.Substring(x, 1)
            If operador(c) Then
                If operacion = "" Then
                    'almacena la operacion
                    operacion = c
                    'almecena primer operando
                    resul = Val(entrada.ToString.Substring(top1, x - top1))
                    'inicio segundo operando
                    top1 = x + 1
                Else
                    'lee segundo operando
                    op2 = Val(entrada.ToString.Substring(top1, x - top1))
                    Select Case operacion
                        Case "+"
                            resul = resul + op2
                        Case "-"
                            resul = resul - op2
                        Case "*"
                            resul = resul * op2
                        Case "/"
                            resul = resul / op2
                        Case "="
                            Exit For
                        Case Else
                    End Select
                    operacion = c
                End If
            End If
        Next x
        Return resul.ToString
    End Function

    Function operador(ByVal a As String) As Boolean
        If a = "+" Or a = "-" Or a = "*" Or a = "/" Or a = "=" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub salida3(ByVal tecla As String)

        Static Dim borra As Boolean = False
        Static Dim numero As String = ""
        Dim texto As String
        Dim cursor As Single

        oGraf2.Clear(TextBox2.BackColor)

        If tecla = "C" Then
            numero = ""
        End If

        If tecla = "=" Then
            numero = ""
            texto = evalua()
        Else
            texto = tecla
        End If

        If operador(tecla) Then
            numero = ""
        Else
            numero = numero & tecla
            texto = numero
        End If

        'caja3
        ancho = CInt(oGraf.MeasureString(texto, ofont, 0).Width)
        cursor = PictureBox1.Size.Width - ancho
        oGraf2.DrawString( _
            texto, _
            ofont, _
            New Drawing2D.HatchBrush(HatchStyle.LargeGrid, c, c), _
            cursor, 0)
    End Sub


    Private Sub salida12(ByVal texto As String)

        'caja1
        TextBox1.Text = texto 'primera forma de imprimir

        'caja2
        oGraf.Clear(TextBox2.BackColor)
        oGraf.DrawString( _
            texto, _
            New Font(New FontFamily("Verdana"), 20), _
            New Drawing2D.HatchBrush(HatchStyle.LargeGrid, c, c), _
            0, 0)

    End Sub

End Class