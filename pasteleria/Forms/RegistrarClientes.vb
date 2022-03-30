Public Class RegistrarClientes
    Private Sub RegistrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNumCliente.Text = vbNullString
        TxtNombre.Text = vbNullString
        TxtPaterno.Text = vbNullString
        TxtMaterno.Text = vbNullString
        TxtCorreo.Text = vbNullString
        TxtTelefono.Text = vbNullString
        TxtDomicilio.Text = vbNullString

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If TxtNombre.Text = "" Then
            MessageBox.Show("Favor de Capturar Nombre(s) del Cliente")
        ElseIf TxtPaterno.Text = "" Then
            MessageBox.Show("Favor de Capturar Apellido Paterno del Cliente")
        ElseIf TxtMaterno.Text = "" Then
            MessageBox.Show("Favor de Capturar Apellido Materno del Cliente")
        ElseIf TxtCorreo.Text = "" Then
            MessageBox.Show("Favor de Capturar Correo Electronico del Cliente")
        ElseIf TxtTelefono.Text = "" Then
            MessageBox.Show("Favor de Capturar Telefono del Cliente")
        ElseIf TxtDomicilio.Text = "" Then
            MessageBox.Show("Favor de Capturar Domicilio del Cliente")
        End If

    End Sub


End Class