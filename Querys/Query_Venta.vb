Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad
Imports System.Data.SqlClient.SqlTransaction
Public Class Query_Venta
    Private tran As SqlTransaction
    Private cn As SqlConnection
    Private adaptador As SqlDataAdapter
    Private _llave As String = ConfigurationManager.ConnectionStrings("cn").ToString
    Private dt As DataTable

    Private Sub abrir()
        cn = New SqlConnection(_llave)
        cn.Open()

    End Sub
    Private Sub cerrar()
        cn = New SqlConnection(_llave)
        cn.Close()
    End Sub


    Public Function CargarLista() As DataTable
        abrir()
        adaptador = New SqlDataAdapter("SELECT * FROM productos ", cn)
        dt = New DataTable
        adaptador.Fill(dt)
        Return dt
        cerrar()
    End Function

    Public Sub Ingresar(ByVal venta As Entidad_Venta, ByVal items As List(Of entidadVentaItem))
        Try
            abrir()
            'cn.Close() 'cierro la conexion porque en algun lado queda abierta. Fijarse esto

            'cn.Open()
            'seteo la transaccion
            tran = cn.BeginTransaction()

            'al final de la query pongo SELECT SCOPE_IDENTITY() para obtener el id de la factura agregada
            Dim query As String = "  INSERT INTO ventas (IDCliente, Fecha, Total)VALUES ('" & venta.IdCliente & "', '" & venta.Fecha.ToString("yyyy-MM-dd") & "', '" & venta.Total & "'); SELECT SCOPE_IDENTITY()"
            Dim adapte As New SqlCommand(query, cn, tran)
            'executescalar: obtiene el valor de la primera columna de la primera fila (el id de la venta en este caso)
            Dim id As Integer = adapte.ExecuteScalar()

            'si el id es 0 es porque algo salio mal. se hace rollback
            If id = 0 Then
                tran.Rollback()
                Return
            End If

            'ya con el id de venta, agregamos los items.
            For Each i As entidadVentaItem In items
                query = "INSERT INTO ventasitems (IDVenta,IDProducto,PrecioUnitario,Cantidad,PrecioTotal)VALUES ('" & id & "', '" & i.IdProducto & "', '" & CDbl(i.PrecioUnidad) & "', '" & CDbl(i.Cantidad) & "', '" & CDbl(i.Total) & "')"
                adapte.CommandText = query
                adapte.ExecuteNonQuery()
            Next

            'hacemos commit de la transaccion
            tran.Commit()
        Catch ex As Exception
            'si algo sale mal, mensaje y rollback de la transaccion.
            MsgBox("En ingresar " + ex.Message)
            tran.Rollback()
        Finally
            cerrar()
        End Try
    End Sub

    '-------------**************-------------------*************-------------










End Class
