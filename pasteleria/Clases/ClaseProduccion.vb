Imports Oracle.DataAccess.Client

Public Class ClaseProduccion

    Public Sub New()
        idProdGral = 0
        idProdEsp = 0
        cantProd = 0
        fechaProd = ""

    End Sub

    Public Sub New(idProdGeneral As Integer, idUsua As Integer, idProd As Integer, fecha As Date)
        idProdGral = idProdGeneral
        idUsuario = idUsua
        idProducto = idProd
        fechaProd = fecha

    End Sub

    Public Property getSetidProdGral() As Integer
        Get
            Return idProdGral
        End Get
        Set(ByVal Value As Integer)
            idProdGral = Value
        End Set
    End Property

    Public Property getSetFechaProd() As Date
        Get
            Return fechaProd
        End Get
        Set(ByVal Value As Date)
            fechaProd = Value
        End Set
    End Property

    Public Sub insertaProduccionGral()
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "INSERT INTO PRODUCCIONGRAL VALUES(ProdGral.NEXTVAL, " & idUsuario & ", " & idProducto & ", '" & fechaProd & "')"

        xCnx.objetoCommand(strSql)

    End Sub

    Public Function consultaIdUsuario() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT IDUSUARIO FROM USUARIOS " &
                 "WHERE NOMBRE ='" & Produccion.ComboBoxEmpleado.Text & "'"
        consultaIdUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDUSUARIO")) Then
                idUsuario = ""
            Else
                idUsuario = CStr(xDT.Rows(0)("IDUSUARIO"))
                miUsuario = idUsuario
            End If
            consultaIdUsuario = True
        End If
    End Function

    Public Function consultaIdProducto() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT IDPRODUCTO FROM PRODUCTO " &
                 "WHERE DESCRIPCION = '" & Produccion.ComboBoxProducto.Text & "'"
        consultaIdProducto = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDPRODUCTO")) Then
                idProducto = ""
            Else
                idProducto = CStr(xDT.Rows(0)("IDPRODUCTO"))
                miProducto = idProducto
            End If
            consultaIdProducto = True
        End If
    End Function

    Public Function consultaIdTamano() As Boolean

        ' Utilizada para obtener el ID del país seleccionado, ejemplo para cuando
        ' requieran obtener un ID de alguna tabla de un registro ya existente, 
        ' la búsqueda la hace por el nombre del país

        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable


        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT IDTAMANO FROM TAMANOS " &
                 "WHERE DESCRIPCION ='" & Produccion.ComboBoxTamano.Text & "'"
        consultaIdTamano = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDTAMANO")) Then
                idTamano = ""
            Else
                idTamano = CStr(xDT.Rows(0)("IDTAMANO"))
                miTamano = idTamano
            End If
            consultaIdTamano = True
        End If
    End Function


    Public Sub poblarComboProducto(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT DESCRIPCION FROM PRODUCTO ORDER BY DESCRIPCION ASC"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarComboUsuario(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT USUARIO FROM USUARIOS ORDER BY USUARIO ASC"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub poblarComboTamanos(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "SELECT DESCRIPCION FROM TAMANOS ORDER BY DESCRIPCION ASC"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

End Class
