﻿
Imports Oracle.DataAccess.Client
Public Class Oracle

    Public Sub New()

        cnx = New OracleConnection("Data Source=XE;User Id=PASTELERIA;Password=PASTELERIA;")

        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open() 'Abrir la base de datos en caso de que la conexión sea exitosa

            Catch ex As Exception
                Throw New Exception("No se puede conectar a la Base de Datos, contacte al D.B.A.", ex)
            End Try
        End If
    End Sub
    'Metodo para establecer la conexión a la BD



    'METODOS PARA ACCESO A DATOS
    'Método para efectuar consultas a base de datos recibiendo el string del DML

    Public Function objetoDataAdapter(ByVal sqlcmd As String) As DataTable

        Dim DA As OracleDataAdapter
        Dim DT As DataTable
        Try
            'en la variable sqlcmd traemos el QUERY y en la variable 
            'cnx la cadena de conexión a la BD, entonces con la línea de abajo le decimos al VB
            'que se conecte a la BD con el usuario y ejecute el query
            'A ESTE CODIGO NO HAY QUE MOVERLE NADA

            DA = New OracleDataAdapter(sqlcmd, cnx)
            DT = New DataTable
            DA.Fill(DT)
            Return DT 'retorna el conjunto de dato
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
        DT.Dispose()
    End Function

    'Método que ejecuta un comando INSERT, UPDATE o DELETE a base de datos

    Public Sub objetoCommand(ByVal strcmd As String)
        Dim sqlcmd As New OracleCommand(strcmd, cnx)

        'en la variable strcmd traemos el QUERY y en la variable 
        'cnx la cadena de conexión a la BD

        'A ESTE CODIGO NO HAY QUE MOVERLE NADA

        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)

            sqlcmd.Dispose()
        End Try
    End Sub

    'Método para efectuar lecturas y generar recordset de datos
    'todos los select invocan este método y aqui se ejecutan

    Function objetoDataReader(ByVal strcmd As String) As OracleDataReader
        'en la variable strcmd traemos el QUERY y en la variable 
        'cnx la cadena de conexión a la BD

        'A ESTE CODIGO NO HAY QUE MOVERLE NADA

        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Dim resultadoSQL As OracleDataReader = sqlcmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function

    'Método que ejecuta una función de grupo a la base de datos
    'cuando se hace un GROUP BY en el select

    Public Function objetoScalar(ByVal strcmd As String) As Object
        'en la variable strcmd traemos el QUERY y en la variable 
        'cnx la cadena de conexión a la BD

        'A ESTE CODIGO NO HAY QUE MOVERLE NADA

        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function
End Class
