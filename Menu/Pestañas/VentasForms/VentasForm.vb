Imports Negocio
Public Class VentasForm
    Dim consulta_negocio As Consulta_Venta = New Consulta_Venta
    Private Sub VentasForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_Grilla()
        txtBuscar.Text = "Buscar por Nombre"
    End Sub
    Private Sub cargar_Grilla()
        dgwListaProductos.DataSource = consulta_negocio.cargar_lista
    End Sub

    Private Sub dgwListaProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwListaProductos.CellClick
        If Not dgwListaProductos.Item(0, dgwListaProductos.CurrentRow.Index).Value.ToString = "" Then
            DatosALabel()
        End If

    End Sub

    Private Sub btnAgregarALista_Click(sender As Object, e As EventArgs) Handles btnAgregarALista.Click
        If numCantidad.Value >= 1 Then
            dgvCarrito.Rows.Add(lblID.Text, lblNombre.Text, lblPrecio.Text, numCantidad.Value, CDec(lblPrecio.Text) * CDec(numCantidad.Value))
        End If


        Total_Precio()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Or txtBuscar.Text = "Buscar por Nombre" Then
            cargar_Grilla()
        Else


            Dim k As New DataView(consulta_negocio.cargar_lista)
            k.RowFilter = String.Format("Nombre like '%{0}%'", txtBuscar.Text)
            dgwListaProductos.DataSource = k
            dgwListaProductos.Columns("ID").Visible = False
            'dgwClientes.Columns("IDCliente").Visible = False
        End If
    End Sub

    Private Sub menuFiltro_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menuFiltro.Opening

    End Sub

    Private Sub filtroCbx_TextChanged(sender As Object, e As EventArgs) Handles filtroCbx.TextChanged
        CategoriaToolStripMenuItem.Checked = True
        ProductoToolStripMenuItem.Checked = False
        Dim k As New DataView(consulta_negocio.cargar_lista)
        k.RowFilter = String.Format(" Categoria like '%{0}%'", filtroCbx.Text)
        dgwListaProductos.DataSource = k
        dgwListaProductos.Columns("ID").Visible = False
        txtBuscar.Enabled = False
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        ProductoToolStripMenuItem.Checked = True
        CategoriaToolStripMenuItem.Checked = False
        txtBuscar.Enabled = True
        txtBuscar.Text = "Buscar por Nombre"
        cargar_Grilla()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If Not dgvCarrito.Item(0, dgvCarrito.CurrentRow.Index).Value = "" Then
            dgvCarrito.Rows.RemoveAt(dgvCarrito.CurrentRow.Index)
        End If
        Total_Precio()
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click
        txtBuscar.Text = ""
    End Sub
    Private Sub Total_Precio()

        Dim Total As Decimal = 0

        For a As Integer = 0 To dgvCarrito.Rows.Count - 1
            Dim nombre2 As String = dgvCarrito.Item(1, a).Value
            If Not nombre2 = "" Then
                Dim part As Decimal = CDec(dgvCarrito.Item(4, a).Value)
                Total = Total + part

            End If
        Next
        lblTotal.Text = Total.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ResumenVentaForm.Show()
    End Sub


End Class