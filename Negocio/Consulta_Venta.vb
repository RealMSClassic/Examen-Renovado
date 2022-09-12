Imports Querys
Public Class Consulta_Venta
    Dim consulta As Query_Venta = New Query_Venta

    Public Function cargar_lista() As DataTable
        Return consulta.CargarLista
    End Function
End Class
