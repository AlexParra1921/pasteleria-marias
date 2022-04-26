Public Class AgregarProducto
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtNombreProducto.Text = "" Then
            MessageBox.Show("Favor de Capturar Nombre del Producto")
        Else
            Dim producto As New ClaseProductos(idProducto, descProd)

            producto.getSetdescProd = TxtNombreProducto.Text
            producto.insertaProducto() 'INSERTA NUEVO PRODUCTO
            MessageBox.Show("¡Producto Registrado con Éxito!")

        End If

    End Sub
End Class