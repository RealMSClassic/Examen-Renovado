Imports Entidad
Public Class MenuForm
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        lblText.Text = "Clientes"
        ProductosForm.Close()
        VentasForm.Close()
        ClientesForm.MdiParent = Me
        PanelPrincipal.Controls.Add(ClientesForm)
        ClientesForm.Show()
        ClientesForm.WindowState = FormWindowState.Maximized
        btnClientes.Enabled = False
        btnVentas.Enabled = True
        btnProductos.Enabled = True
        btnHistorial.Enabled = True
        btnConfiguracion.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        lblText.Text = "Productos"
        ClientesForm.Close()
        VentasForm.Close()
        ProductosForm.MdiParent = Me
        PanelPrincipal.Controls.Add(ProductosForm)
        ProductosForm.Show()
        ProductosForm.WindowState = FormWindowState.Maximized
        btnClientes.Enabled = True
        btnVentas.Enabled = True
        btnProductos.Enabled = False
        btnHistorial.Enabled = True
        btnConfiguracion.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        lblText.Text = "Ventas"
        ProductosForm.Close()
        ClientesForm.Close()
        HistorialForm.Close()
        VentasForm.MdiParent = Me
        PanelPrincipal.Controls.Add(VentasForm)
        VentasForm.Show()
        VentasForm.WindowState = FormWindowState.Maximized
        btnClientes.Enabled = True
        btnVentas.Enabled = False
        btnProductos.Enabled = True
        btnHistorial.Enabled = True
        btnConfiguracion.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        lblText.Text = "Historial"
        ProductosForm.Close()
        ClientesForm.Close()
        VentasForm.Close()
        HistorialForm.MdiParent = Me
        PanelPrincipal.Controls.Add(HistorialForm)
        HistorialForm.Show()
        VentasForm.WindowState = FormWindowState.Maximized
        btnClientes.Enabled = True
        btnVentas.Enabled = True
        btnProductos.Enabled = True
        btnHistorial.Enabled = False
        btnConfiguracion.Enabled = True
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        btnClientes.Enabled = True
        btnVentas.Enabled = True
        btnProductos.Enabled = True
        btnHistorial.Enabled = True
        btnConfiguracion.Enabled = False
    End Sub
End Class
