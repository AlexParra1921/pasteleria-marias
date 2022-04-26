Imports Oracle.DataAccess.Client
Module Variable
    Public usuario As String
    Public contraseña As String
    Public UsuarioConectado As String
    Public cnx As OracleConnection


    ' CLASE ALUMNO'

    Public idCliente As Integer
    Public miIdCliente As Integer
    Public nombre As String
    Public paterno As String
    Public materno As String
    Public correo As String
    Public telefono As String
    Public domicilio As String

    'CLASE PRODUCTOS
    Public idTamano As Integer
    Public miTamano As Integer
    Public descTamano As String
    Public costo As Integer
    Public cantTamano As Integer
    Public idProducto As Integer
    Public miProducto As Integer
    Public descProd As String

    'CLASE PRODUCCION
    Public idProdGral As Integer
    Public idProdEsp As Integer
    Public fechaProd As String
    Public cantProd As Integer

    'CLASE USUARIO
    Public idUsuario As Integer
    Public miUsuario As Integer

End Module
