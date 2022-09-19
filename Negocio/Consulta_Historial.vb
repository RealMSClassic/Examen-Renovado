Imports Querys
Public Class Consulta_Historial
    Dim consulta As Query_Historial = New Query_Historial
    Public Function cargar_historial() As DataTable
        Return consulta.CargarLista()
    End Function
    Public Function cargar_informe(ByVal a As Integer) As DataTable
        Return consulta.Cargarinforme(a)
    End Function
    Public Function filtrarXFecha(ByVal a As DateTime, ByVal b As DateTime) As DataTable

        Return consulta.FiltroFecha(a, b)
    End Function
End Class
