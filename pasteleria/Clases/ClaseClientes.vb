
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

        strSql = "INSERT INTO CLIENTES VALUES(usuarioSeq.NEXTVAL" & ", '" & nombre & "', '" & paterno & "', '" & materno & "', '" & correo & "', '" & telefono & "', '" & domicilio & "')"


        xCnx.objetoCommand(strSql)
        'Else
        'Notificamos al usuario final por medio de un mensaje 

        'MsgBox("Faltan datos para la ciudad del estado seleccionado, verifique !!", MsgBoxStyle.Critical, "ATENCIÓN!!")
        'End If
    End Sub

    Public Function consultaUnAlumnoFrm() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT IDCLIENTE, NOMBRE, PATERNO, MATERNO " &
                  " FROM CLIENTES " &
                  " WHERE IDCLIENTE = '" & RegistrarClientes.TxtNumCliente.Text & "' AND " &
                        " NOMBRE = '" & RegistrarClientes.TxtNombre.Text & "' AND" &
                        " PATERNO = '" & RegistrarClientes.TxtPaterno.Text & "' AND " &
                        " MATERNO = '" & RegistrarClientes.TxtMaterno.Text & "'"


        consultaUnAlumnoFrm = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDCLIENTE")) Then
                idCliente = 0
            Else
                idCliente = CStr(xDT.Rows(0)("IDCLIENTE"))
                RegistrarClientes.TxtNombre.Text = CStr(xDT.Rows(0)("NOMBRE"))
                RegistrarClientes.TxtPaterno.Text = CStr(xDT.Rows(0)("PATERNO"))
                RegistrarClientes.TxtMaterno.Text = CStr(xDT.Rows(0)("MATERNO"))

            End If

            consultaUnAlumnoFrm = True
        End If
    End Function

    Public Function consultaNumCliente() As Boolean

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT IDCLIENTE " &
                 " FROM CLIENTES " &
                 " WHERE PATERNO ='" & ConsultarClientes.TxtPaterno.Text & "' AND " &
                    " MATERNO = '" & ConsultarClientes.TxtMaterno.Text & "'"
        consultaNumCliente = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDCLIENTE")) Then
                idCliente = ""
            Else
                idCliente = CStr(xDT.Rows(0)("IDCLIENTE"))
                miIdCliente = idCliente
            End If
            consultaNumCliente = True
        End If
    End Function

    Public Function consultaUnCliente() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT IDCLIENTE, NOMBRE, PATERNO, MATERNO, CORREO, TELEFONO, DOMICILIO " &
                  " FROM CLIENTES " &
                  " WHERE NOMBRE = '" & RegistrarClientes.TxtNombre.Text & "' AND " &
                        " PATERNO = '" & RegistrarClientes.TxtPaterno.Text & "' AND " &
                        " MATERNO = '" & RegistrarClientes.TxtMaterno.Text & "'"



        consultaUnCliente = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDCLIENTE")) Then
                idCliente = 0
            Else
                idCliente = CStr(xDT.Rows(0)("IDCLIENTE"))
                RegistrarClientes.TxtNombre.Text = CStr(xDT.Rows(0)("NOMBRE"))
                RegistrarClientes.TxtPaterno.Text = CStr(xDT.Rows(0)("PATERNO"))
                RegistrarClientes.TxtMaterno.Text = CStr(xDT.Rows(0)("MATERNO"))
                RegistrarClientes.TxtCorreo.Text = CStr(xDT.Rows(0)("CORREO"))
                RegistrarClientes.TxtTelefono.Text = CStr(xDT.Rows(0)("TELEFONO"))
                RegistrarClientes.TxtDomicilio.Text = CStr(xDT.Rows(0)("DOMICILIO"))
            End If


            consultaUnCliente = True
        End If
    End Function

    Public Function consultaTodosClientes() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = " SELECT NOMBRE AS Nombre, PATERNO AS Apellido_Paterno, MATERNO AS Apellido_Materno, CORREO AS Correo, TELEFONO AS Telefono, DOMICILIO AS Domicilio FROM CLIENTES" &
                  " ORDER BY IDCLIENTE asc"
        '" WHERE NOMBRE = '" & ConsultarClientes.TxtNombre.Text & "'" &
        '" ORDER BY IDCLIENTE asc"

        ' " ORDER BY IDCLIENTE asc"
        ' " PATERNO ='" & ConsultarClientes.TxtPaterno.Text & "' AND " &
        '" MATERNO = '" & ConsultarClientes.TxtMaterno.Text & "'" &
        '  " ORDER BY IDCLIENTE asc"

        consultaTodosClientes = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridConsultaCliente(ByVal DGVClientes As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV


        DGVClientes.DataSource = consultaTodosClientes()

        'Con el refresh actualiza el contenido del DGV

        DGVClientes.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVClientes.Columns.Item(0).Width = 200
        DGVClientes.Columns.Item(1).Width = 200
        DGVClientes.Columns.Item(2).Width = 200
        DGVClientes.Columns.Item(3).Width = 200

    End Sub
End Class
