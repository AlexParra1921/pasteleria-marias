Imports Oracle.DataAccess.Client
Public Class ClaseClientes

    Public Sub New()
        idCliente = 0
        nombre = ""
        paterno = ""
        materno = ""
        correo = ""
        telefono = ""
        domicilio = ""
    End Sub

    Public Sub New(ByVal numCliente As Integer, ByVal nom As String, ByVal pat As String, ByVal mat As String, ByVal corr As String, ByVal tel As String, ByVal dom As String)
        idCliente = 0
        nombre = ""
        paterno = ""
        materno = ""
        correo = ""
        telefono = ""
        domicilio = ""

    End Sub

    Public Property getSetnumCliente() As Integer
        Get
            Return idCliente
        End Get
        Set(ByVal Value As Integer)
            idCliente = Value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    Public Property getSetPaterno() As String
        Get
            Return paterno
        End Get
        Set(ByVal Value As String)
            paterno = Value
        End Set
    End Property

    Public Property getSetMaterno() As String
        Get
            Return materno
        End Get
        Set(ByVal Value As String)
            materno = Value
        End Set
    End Property

    Public Property getSetCorreo() As String
        Get
            Return correo
        End Get
        Set(ByVal Value As String)
            correo = Value
        End Set
    End Property
    Public Property getSetTelefono() As String
        Get
            Return telefono
        End Get
        Set(ByVal Value As String)
            telefono = Value
        End Set
    End Property
    Public Property getSetDomicilio() As String
        Get
            Return domicilio
        End Get
        Set(ByVal Value As String)
            domicilio = Value
        End Set
    End Property


    Public Sub insertaCliente()
        Dim strSql As String
        Dim xCnx As New Oracle

        'Con el IF validamos que no falten datos y que sean del tipo de dato requerido

        'If idPais <> 0 And idEstado <> 0 And idCiudad <> 0 And nombre <> "" Then
        'Realiza inserción de datos

        ' ----------------------------------------------------------------------------------------------------------
        'La parte que corresponde a la sintaxis del INSERT se escriben entre comillas 
        '        "INSERT INTO nombretabla VALUES(" 
        ' para indicar que hay continuación en la sintaxis se usa el simbolo & 
        ' Si el dato entra en un atributo tipo NUMERICO, ENTERO se escribe sin apóstrofe 
        '   "INSERT INTO nombretabla VALUES(" & primerdato 
        ' la como es parte de la sintaxis del INSERT entonces se escribe entre comillas
        '   "INSERT INTO nombretabla VALUES(" & primerdato & ", " 
        ' los datos que entran en campos VARCHAR o DATE se encierran entre apóstrofe
        '"INSERT INTO Ciudades VALUES(" & idPais & ", " & idEstado & ", " & idCiudad & ", '" & nombre & "')"
        ' ----------------------------------------------------------------------------------------------------------

        strSql = "INSERT INTO CLIENTES VALUES(" & idCliente & ", '" & nombre & "', '" & paterno & "', '" & materno & "', " & correo & "', '" & telefono & "', '" & domicilio & "')"


        xCnx.objetoCommand(strSql)
        'Else
        'Notificamos al usuario final por medio de un mensaje 

        'MsgBox("Faltan datos para la ciudad del estado seleccionado, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        'End If
    End Sub



End Class
