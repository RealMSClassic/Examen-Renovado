Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad
Public Class Query_Venta
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

End Class
