Public Class Produccion
    Dim produccion As New ClaseProduccion()

    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        produccion.poblarComboProducto(ComboBoxProducto)
        produccion.poblarComboUsuario(ComboBoxEmpleado)

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        ComboBoxEmpleado.Text = vbNullString
        ComboBoxProducto.Text = vbNullString
        ComboBoxTamano.Text = vbNullString
        TxtCantidad.Text = vbNullString
        DTPFechaProduccion.Text = vbNullString

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim prodGral As New ClaseProduccion(idProdGral, ComboBoxEmpleado.Text, miProducto, DTPFechaProduccion.Text)
        prodGral.getSetFechaProd = DTPFechaProduccion.Text
        prodGral.insertaProduccionGral()
        MessageBox.Show("¡Producción Registrada con Éxito!")

    End Sub

    Private Sub ComboBoxEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEmpleado.SelectedIndexChanged
        produccion.consultaIdUsuario()
    End Sub

    Private Sub ComboBoxProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProducto.SelectedIndexChanged
        produccion.consultaIdProducto()
    End Sub

    Private Sub ComboBoxTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTamano.SelectedIndexChanged
        produccion.consultaIdTamano()

    End Sub
End Class