Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad



Public Class Query_Historial
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
        adaptador = New SqlDataAdapter("select v.ID,c.Cliente,v.IDCliente,cONVERT(date,v.Fecha,26)as Fecha,v.Total from ventas v inner join clientes c on v.IDCliente = c.ID
", cn)
        dt = New DataTable
        adaptador.Fill(dt)
        Return dt
        cerrar()
    End Function
    Public Function Cargarinforme(ByVal a As Integer) As DataTable
        abrir()
        adaptador = New SqlDataAdapter("SELECT vi.ID,vi.IDVenta,vi.IDProducto,p.Nombre,vi.PrecioUnitario,vi.Cantidad,vi.PrecioTotal
FROM ventasitems vi inner join productos p on vi.IDProducto = p.ID where IDVenta = " & a & "", cn)
        dt = New DataTable
        adaptador.Fill(dt)
        Return dt
        cerrar()
    End Function

    Public Function FiltroFecha(ByVal a As DateTime, ByVal b As DateTime) As DataTable
        abrir()
        Try


            adaptador = New SqlDataAdapter("select v.ID,c.Cliente,v.IDCliente,cONVERT(date,v.Fecha,26)as Fecha,v.Total 
            from ventas v inner join clientes c on v.IDCliente = c.ID  where Fecha >= '" & a.ToString("yyyy-MM-dd") & "' and Fecha <= '" & b.ToString("yyyy-MM-dd") & "'", cn)
            dt = New DataTable
            adaptador.Fill(dt)


        Catch ex As Exception
            MsgBox("" + ex.Message)
        End Try
        Return dt
        cerrar()
    End Function


End Class
