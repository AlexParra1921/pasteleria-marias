Imports Oracle.DataAccess.Client

Public Class ClaseLogin
    Private Const V As String = "usuario"
    Private usuario As String

    'Método constructor inicializa variables
    Public Sub New()
        'Si tus variables son de otro tipo (numeric,Integer, etc) tendrías que iniciarlas en 0
        usuario = ""
        contraseña = ""
    End Sub


    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal nom As String, ByVal contra As String)
        'Aquí recibimos los datos
        usuario = nom
        contraseña = contra
    End Sub

    'Metodos get y set
    Public Property getSetNombre() As String
        Get
            Return usuario
        End Get
        Set(ByVal Value As String)
            usuario = Value
        End Set
    End Property

    Public Property getSetContraseña() As String
        Get
            Return contraseña
        End Get
        Set(ByVal Value As String)
            contraseña = Value
        End Set
    End Property

    Public Function consultaTipoCuenta() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle


        strSQL = "SELECT IDCUENTA FROM USUARIOS WHERE IDCUENTA = 1"

        'consultaTipoCuenta = False

        consultaTipoCuenta = True

    End Function



    Public Function consultaUsuario() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM Usuarios " & "WHERE usuario='" & usuario & "' and contrasena='" & contraseña & "'"

        consultaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then

            If IsDBNull(xDT.Rows(0)("usuario")) Then
                UsuarioConectado = ""

            Else
                UsuarioConectado = CStr(xDT.Rows(0)("usuario")) & " " '& 'CStr(xDT.Rows(0)("paterno"))
                consultaUsuario = True
            End If

        End If

    End Function
End Class
