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


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblText.Text = "Productos"
        ClientesForm.Close()
        VentasForm.Close()
        ProductosForm.MdiParent = Me
        PanelPrincipal.Controls.Add(ProductosForm)
        ProductosForm.Show()
        ProductosForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblText.Text = "Ventas"
        ProductosForm.Close()
        ClientesForm.Close()
        VentasForm.MdiParent = Me
        PanelPrincipal.Controls.Add(VentasForm)
        VentasForm.Show()
        VentasForm.WindowState = FormWindowState.Maximized
    End Sub
End Class
