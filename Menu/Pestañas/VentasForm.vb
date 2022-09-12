Imports Negocio
Public Class VentasForm
    Dim consulta_negocio As Consulta_Venta = New Consulta_Venta
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_Grilla()
    End Sub
    Private Sub cargar_Grilla()
        dgwListaProductos.DataSource = consulta_negocio.cargar_lista
    End Sub

    Private Sub dgwListaProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwListaProductos.CellClick
        DatosALabel()
    End Sub

    Private Sub btnAgregarALista_Click(sender As Object, e As EventArgs) Handles btnAgregarALista.Click
        dgvCarrito.Rows.Add(lblID.Text, lblNombre.Text, lblPrecio.Text, numCantidad.Value, CDec(lblPrecio.Text) * CDec(numCantidad.Value))
    End Sub

    '------------//////////////-----------------///////////-------------/////////////--------

    Private Sub DatosALabel()
        lblID.Text = dgwListaProductos.Item(0, Lectura_Row).Value

        lblNombre.Text = dgwListaProductos.Item(1, Lectura_Row).Value
        lblPrecio.Text = dgwListaProductos.Item(2, Lectura_Row).Value


    End Sub
    Private Function Lectura_Row() As Integer
        Dim id As Integer = CInt(dgwListaProductos.CurrentRow.Index)
        Return id
    End Function


End Class