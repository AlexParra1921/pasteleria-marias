Public Class ConsultarClientes
    Dim consulta As New ClaseClientes

    Private Sub ConsultarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta.PoblarDataGridConsultaCliente(DGVConsultaCliente)
        'cnx.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'consulta.consultaNumCliente()
        'consulta.PoblarDataGridConsultaCliente(DGVConsultaCliente)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtPaterno.Text = vbNullString
        TxtMaterno.Text = vbNullString
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        MenuPrincipal.Show()
        Me.Hide()

    End Sub

    Private Sub DGVConsultaCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim renglon As Integer

        renglon = DGVConsultaCliente.CurrentCellAddress.Y


    End Sub
End Class