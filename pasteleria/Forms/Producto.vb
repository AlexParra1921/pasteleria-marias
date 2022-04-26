Public Class Producto
    Dim producto As New ClaseProductos()

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        producto.poblarComboIdProducto(ComboIdProducto)

    End Sub

    Private Sub BtnAgregarTam_Click(sender As Object, e As EventArgs) Handles BtnTamano.Click
        Dim tamano As New ClaseProductos(idTamano, descTamano, cantTamano, costo, ComboIdProducto.Text)
        tamano.getSetdescTamano = TxtTamano.Text
        tamano.getSetcosto = TxtCosto.Text
        'tamano.consultaIdProducto()
        If tamano.consultaUnTamano() = False Then
            tamano.insertaTamano()
            MessageBox.Show("¡Tamaño de Producto Registrado con Éxito!")
        End If
        'TxtTamano.Clear()
        'TxtCosto.Clear()


    End Sub


    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtTamano.Text = vbNullString
        TxtCosto.Text = vbNullString
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
    End Sub

    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click
        If TxtNombreProducto.Text = "" Then
            MessageBox.Show("Favor de Capturar Nombre del Producto")
        End If

        Dim producto As New ClaseProductos(ComboIdProducto.Text, TxtNombreProducto.Text)
        producto.getSetidProducto = ComboIdProducto.Text
        producto.getSetdescProd = TxtNombreProducto.Text
        producto.insertaProducto() 'INSERTA NUEVO PRODUCTO
        MessageBox.Show("¡Producto Registrado con Éxito!")

        BtnProducto.Visible = False

    End Sub

    Private Sub ComboIdProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboIdProducto.SelectedIndexChanged
        producto.consultaIdProducto()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        producto.PoblarDataGridConsultaTamano(DGVTamanos)
    End Sub
End Class