Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubMenu()
    End Sub

    Private Sub ocultarSubMenu()
        PanelSubMenuClientes.Visible = False
        PanelSubMenuPedidos.Visible = False
        PanelSubMenuProductos.Visible = False

    End Sub

    Private Sub mostrarSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            ocultarSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If

    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        mostrarSubMenu(PanelSubMenuClientes)

    End Sub

    Private Sub BtnPedidos_Click(sender As Object, e As EventArgs) Handles BtnPedidos.Click
        mostrarSubMenu(PanelSubMenuPedidos)
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        mostrarSubMenu(PanelSubMenuProductos)

    End Sub

    Private Sub BtnRegCliente_Click(sender As Object, e As EventArgs) Handles BtnRegCliente.Click
        abrirFormActual(New RegistrarClientes())
        ocultarSubMenu()

    End Sub

    Private Sub BtnConsultaCliente_Click(sender As Object, e As EventArgs) Handles BtnConsultaCliente.Click

        abrirFormActual(New ConsultarClientes())
        ocultarSubMenu()
    End Sub

    Private Sub BtnRegProducto_Click(sender As Object, e As EventArgs) Handles BtnRegProducto.Click
        abrirFormActual(New Productos())
        ocultarSubMenu()
    End Sub

    Private Sub BtnRegProduccion_Click(sender As Object, e As EventArgs) Handles BtnRegProduccion.Click
        abrirFormActual(New Produccion())
        ocultarSubMenu()
    End Sub

    Private Sub BtnRegPedido_Click(sender As Object, e As EventArgs) Handles BtnRegPedido.Click
        abrirFormActual(New RegistrarPedidos())
        ocultarSubMenu()
    End Sub

    Private Sub BtnConsultarPedido_Click(sender As Object, e As EventArgs) Handles BtnConsultarPedido.Click
        abrirFormActual(New ConsultarPedidos())
        ocultarSubMenu()
    End Sub

    Private formActual As Form = Nothing
    Private Sub abrirFormActual(form As Form)
        If formActual IsNot Nothing Then formActual.Close()
        formActual = form
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        PanelFormHijo.Controls.Add(form)
        PanelFormHijo.Tag = form
        form.BringToFront()
        form.Show()
    End Sub

    Private Sub BtnAgenda_Click(sender As Object, e As EventArgs) Handles BtnAgenda.Click
        abrirFormActual(New Agenda())
    End Sub
End Class