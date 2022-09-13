Imports Querys
Imports Entidad
Public Class Consulta_Venta
    Dim fecha = DateTime.Now
    Dim consulta As Query_Venta = New Query_Venta

    Public Function cargar_lista() As DataTable
        Return consulta.CargarLista
    End Function



    Public Sub TerminarVenta(ByVal venta As Entidad_Venta, ByVal items As List(Of entidadVentaItem))
        consulta.Ingresar(venta, items)
    End Sub

    'Resumen_VentaForm
    Public Function nuevaVenta(ByVal idcliente As Integer, ByVal total As Decimal) As Entidad_Venta

        Dim enti As Entidad_Venta = New Entidad_Venta
        enti.IdCliente = idcliente
        enti.Fecha = Format(fecha, "yyyy,MM,dd  HH:mm ")
        enti.Total = total

        Return enti
    End Function

End Class
