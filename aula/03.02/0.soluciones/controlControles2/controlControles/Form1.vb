' vb: Option Strict on/off, Dim as =, New, Me, items, items.clear, coleccion controls for each, enlace tardio, TypeOf, Contains,  AddHandler AdrdressOf,Dock,IntegralHeight,Me,Dispose,comillas dobles escapadas,&,ToString

Option Strict Off

Public Class Form1

    Sub imprimirControles()
        Dim z = 0
        ListBox1.Items.Clear()
        ' recorrer los controles existentes en el formulario
        For Each x In Me.Controls
            ' x es un objeto, pasar el puntero sobre el para verlo
            ' enlace tardio necesita option strict OFF con enlaces tempranos usa ON
            ' todos los controles tienen la propiedad name no necesito directcast
            z += 1 'un contador
            ' los presenta en el formulario
            ListBox1.Items.Add(z.ToString & ".""" & x.name & """")
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' anañidr evento por codigo a un control existente
        AddHandler Button1.Click, AddressOf borrarControl1
        crearControles()
        imprimirControles()
    End Sub

    Private Sub clickLabel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label2.Click, Label3.Click
        ' imprimir quier envio evento
        ListBox1.Items.Add("evento click=" & sender.Text)
        'imprimirControles()
    End Sub

    Private Sub ponerEventoBoton(ByVal x)
        ' Añadir evento de click por codigo a un control que entra como parametro, directcast establece enlace temprano
        AddHandler DirectCast(x, Button).Click, AddressOf borrarControl1
    End Sub

    Private Sub borrarControl1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Button2.Enabled = True 'el boton de añadir boton1 se enciende y apaga segun este o no boton1
        Me.Controls.Remove(sender) ' eliminarlo de la lista
        sender.dispose() ' borrar el objeto
        imprimirControles()
    End Sub

    Private Sub otroBoton1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' deshabilitar para no crear button1 si ya esta en el formulario
        Button2.Enabled = False
        'crear un control
        If Not Me.Controls.Contains(Button1) Then 'comprobar si existe
            'copiado del form.designer
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer))
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Location = New System.Drawing.Point(12, 12)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(105, 23)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            Me.Controls.Add(Me.Button1) ' añadir control al formulario
            ponerEventoBoton(Button1) ' volver ponerlo como antes
        End If
        imprimirControles()
    End Sub

    Sub crearControles()
        Dim ancho As Integer = 20
        Dim margen As Integer = 5
        For j = 1 To 9
            Dim x As New System.Windows.Forms.Control
            'x.BackColor = System.Drawing.SystemColors.
            'x.Location = New System.Drawing.Point(0, 0)
            'x.Visible = True
            'x.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            x.Name = "dummmmmmy " & j
            'x.Size = New System.Drawing.Size(20, 40)
            'x.TabIndex = 4
            'x.TabStop = False
            Me.Controls.Add(x)
        Next
    End Sub

    Private Sub borrarControl(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button4.Click
        ' como borrar un control existente del formulario
        ' eventos multiples en el handles
        ' volvemos a imprimir los controles antes de salir del sub
        Me.Controls.Remove(sender)
        sender.dispose()
        imprimirControles()
    End Sub
End Class
