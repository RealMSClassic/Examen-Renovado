Imports Negocio
Imports Entidad

Public Class ListaClientes
    Dim consultaCliente As Consulta_Clientes = New Consulta_Clientes
    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvClientes.DataSource = consultaCliente.Cargar_Datos()
    End Sub



    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If Not dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value.ToString = "" Then
            ResumenVentaForm.lblID.Text = dgvClientes.Item(0, dgvClientes.CurrentRow.Index).Value
            ResumenVentaForm.lblCliente.Text = dgvClientes.Item(1, dgvClientes.CurrentRow.Index).Value
        End If
        Me.Close()
    End Sub
End Class