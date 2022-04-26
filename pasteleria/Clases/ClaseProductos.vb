Imports Oracle.DataAccess.Client
Public Class ClaseProductos

    Public Sub New()
        idProducto = 0
        descProd = ""
    End Sub

    Public Sub New(idtam As Integer, desc As String, cant As Integer, cost As Integer, idProd As Integer)
        idTamano = idtam
        descTamano = desc
        cantTamano = 0
        costo = cost
        idProducto = idProd

    End Sub

    Public Sub New(idProd As Integer, descPro As String)
        idProducto = idProd
        descProd = descPro
    End Sub

    Public Property getSetidTamano() As Integer
        Get
            Return idTamano
        End Get
        Set(ByVal Value As Integer)
            idTamano = Value
        End Set
    End Property

    Public Property getSetdescTamano() As String
        Get
            Return descTamano
        End Get
        Set(ByVal Value As String)
            descTamano = Value
        End Set
    End Property

    Public Property getSetcosto() As Integer
        Get
            Return costo
        End Get
        Set(ByVal Value As Integer)
            costo = Value
        End Set
    End Property

    Public Property getSetcantTamano() As Integer
        Get
            Return cantTamano
        End Get
        Set(ByVal Value As Integer)
            cantTamano = Value
        End Set
    End Property
    Public Property getSetidProducto() As Integer
        Get
            Return idProducto
        End Get
        Set(ByVal Value As Integer)
            idProducto = Value
        End Set
    End Property
    Public Property getSetdescProd() As String
        Get
            Return descProd
        End Get
        Set(ByVal Value As String)
            descProd = Value
        End Set
    End Property


    Public Sub insertaProducto()
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "INSERT INTO PRODUCTO VALUES(" & idProducto & ", '" & descProd & "')"

        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub insertaTamano()
        Dim strSql As String
        Dim xCnx As New Oracle
        cantTamano = 0

        strSql = "INSERT INTO TAMANOS VALUES(TamanoSeq.NEXTVAL " & ", '" & descTamano & "', " & cantTamano & ", " & costo & ", " & idProducto & ")"

        xCnx.objetoCommand(strSql)

    End Sub

    Public Sub poblarComboIdProducto(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'Ejemplo para llenar un combo con información, se recibe como 
        ' parámetro el nombre del combo

        strSql = "select max(idProducto+1) from PRODUCTO"
        Lista = xCnx.objetoDataReader(strSql)

        'Limpia el contenido del combo, para ser rellendo
        objeto.Items.Clear()

        'Con el while le coloca los renglones encontrados al combo
        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub


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
                 "WHERE IDPRODUCTO ='" & Producto.ComboIdProducto.Text & "'"
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

    Public Function consultaUnTamano() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT TAMANOS.IDTAMANO, TAMANOS.DESCRIPCION, TAMANOS.CANTTAMANO, TAMANOS.COSTO, PRODUCTO.IDPRODUCTO " &
                  " FROM TAMANOS, PRODUCTO " &
                  " WHERE TAMANOS.IDPRODUCTO = PRODUCTO.IDPRODUCTO AND " &
                  " PRODUCTO.DESCRIPCION = '" & Producto.TxtTamano.Text & "' AND " &
                   " TAMANOS.DESCRIPCION = '" & Producto.TxtTamano.Text & "' AND " &
                   " COSTO = '" & Producto.TxtCosto.Text & "'"



        consultaUnTamano = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("IDTAMANO")) Then
                idTamano = 0
            Else
                idTamano = CStr(xDT.Rows(0)("IDTAMANO"))
                Producto.TxtTamano.Text = CStr(xDT.Rows(0)("DESCRIPCION"))
                Producto.TxtCosto.Text = CStr(xDT.Rows(0)("COSTO"))
            End If


            consultaUnTamano = True
        End If
    End Function

    Public Function consultaTodosTamanos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Consulta datos de todas las ciudades registradas en el estado y país seleccionado
        ' para llenar el DGV correspondiente, así solo se le muestran al usuario final las
        ' ciudades del estado y país que se ha seleccionado 
        '----------------------------------------------------------------------------------

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = " SELECT TAMANOS.DESCRIPCION AS Tamano, TAMANOS.CANTTAMANO AS Cantidad, TAMANOS.COSTO AS Costo " &
                 " FROM TAMANOS, PRODUCTO " &
                 " WHERE PRODUCTO.IDPRODUCTO = TAMANOS.IDPRODUCTO AND " &
                 " PRODUCTO.IDPRODUCTO =  '" & Producto.ComboIdProducto.Text & "'" &
                 " ORDER BY TAMANOS.DESCRIPCION asc"

        consultaTodosTamanos = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub PoblarDataGridConsultaTamano(ByVal DGVClientes As DataGridView)
        'Método que lee todas las ciudades del origen de datos y
        'da dimensión a las columnas y cuantas columnas tendrá el DGV


        DGVClientes.DataSource = consultaTodosTamanos()

        'Con el refresh actualiza el contenido del DGV

        DGVClientes.Refresh()

        'Establecer ancho de cada columna del DataGridView, si en el DGV tú requieres mas columnas
        ' agregas GDVciudades.Columns.Item(consecutivo).Width = 900, el numero de columnas de DGV
        ' estarán determinadas por el Query (select) de arriba

        DGVClientes.Columns.Item(0).Width = 200
        DGVClientes.Columns.Item(1).Width = 200
        DGVClientes.Columns.Item(2).Width = 200
        'DGVClientes.Columns.Item(3).Width = 200

    End Sub


End Class
