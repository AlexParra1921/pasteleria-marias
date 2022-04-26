Public Class Login
    Dim us As New ClaseLogin()
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim usuario As New ClaseLogin(TextBoxUsuario.Text, TextBoxContrasena.Text)

        If (us.consultaTipoCuenta) Then
            MenuAdmin.Show()
        Else
            MenuPrincipal.Show()
        End If

        If usuario.consultaUsuario = False Then
            MsgBox("Usuario no Registrado, Favor de Llamar al Administrador del Sistema", MsgBoxStyle.Exclamation)
            cnx.Close()

        Else
            cnx.Close()
            'MenuPrincipal.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
