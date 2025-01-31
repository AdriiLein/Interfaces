Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pinta()
    End Sub
    Sub pinta()
        ' si hacemos un dock podemos saber el tamaño de la ClientSize
        ' para hacer dock debemos anular el autosize
        '
        Label1.AutoSize = True
        Label2.AutoSize = True
        Label3.AutoSize = False
        Label1.Dock = DockStyle.Top
        Label3.Dock = DockStyle.Bottom
        Label1.Text = "form.size: " & Me.Size.Width
        Label2.Text = "form.clientsize: " & Me.ClientSize.Width
        Label3.Text = "labe3.size: " & Label3.Size.Width
    End Sub
    Sub borrarLabels()
        'como borrar controles: 
        'nopodemos recorrer y borrar el mismo array
        'copiamos los controles que quiero borrar
        'uso el arraylist para luego borrarlos
        '
        Dim lista As New ArrayList
        For Each z In Me.Controls
            If (TypeOf z Is Label) Then
                lista.Add(z)
            End If
        Next
        For Each z In lista
            Me.Controls.Remove(z)
            z.Dispose()
        Next
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pinta()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        borrarLabels()
    End Sub
End Class
