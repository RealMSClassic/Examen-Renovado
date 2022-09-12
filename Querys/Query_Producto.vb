Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Configuration.ConfigurationManager
Imports Entidad
Public Class Query_Productos
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
    Public Sub Ingresar_Producto(ByVal producto As Entidad_Producto)
        abrir()
        Try
            Dim query As String = "  INSERT INTO productos(Nombre,Precio,Categoria)VALUES ('" & producto.Nombre.ToString & "', '" & producto.Precio & "', '" & producto.Categoria & "');"
            Dim adapte As New SqlCommand(query, cn)
            adapte.ExecuteNonQuery()
            MsgBox("Datos Ingresados")

        Catch ex As Exception

        End Try
        cerrar()
    End Sub
    Public Function Modificar(ByVal enti As Entidad_Producto) As Boolean
        Dim llave As Boolean = False
        abrir()
        Try
            Dim Query As String = "UPDATE productos SET Nombre='" & enti.Nombre & "', Precio='" & enti.Precio & "', Categoria='" & enti.Categoria & "' WHERE  ID = '" & enti.Id & "';
"
            Dim adapte As New SqlCommand(Query, cn)

            adapte.ExecuteNonQuery()
            MsgBox("Actualizacion exitosa")
            llave = True
        Catch ex As Exception
            llave = False
        End Try

        cerrar()
        Return llave
    End Function
    Public Sub Eliminar_Producto(ByVal enti As Integer)
        abrir()
        Dim Query As String = "DELETE FROM productos WHERE  ID = '" & enti & "';"
        Dim Comando As New SqlCommand(Query, cn)
        Comando.ExecuteNonQuery()
        cerrar()
    End Sub
End Class


