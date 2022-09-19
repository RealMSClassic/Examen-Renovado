Imports Negocio
Public Class Informe
    Dim consulta As Consulta_Historial = New Consulta_Historial
    Private Sub Informe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub cargarDatos()
        If Not HistorialForm.dgvHistorial.Item(1, HistorialForm.dgvHistorial.CurrentRow.Index).Value.ToString = "" Then
            lblCliente.Text = HistorialForm.dgvHistorial.Item(1, HistorialForm.dgvHistorial.CurrentRow.Index).Value.ToString
            lblID.Text = HistorialForm.dgvHistorial.Item(2, HistorialForm.dgvHistorial.CurrentRow.Index).Value.ToString
            lblTotal.Text = HistorialForm.dgvHistorial.Item(4, HistorialForm.dgvHistorial.CurrentRow.Index).Value.ToString
            lblFecha.Text = HistorialForm.dgvHistorial.Item(3, HistorialForm.dgvHistorial.CurrentRow.Index).Value.ToString
            lblIDVenta.Text = HistorialForm.dgvHistorial.Item(0, HistorialForm.dgvHistorial.CurrentRow.Index).Value.ToString

            dgvInforme.DataSource = consulta.cargar_informe(CInt(HistorialForm.dgvHistorial.Item(0, HistorialForm.dgvHistorial.CurrentRow.Index).Value))
            dgvInforme.Columns("ID").Visible = False
            dgvInforme.Columns("IDVenta").Visible = False
            dgvInforme.Columns("IDProducto").Visible = False
        End If



    End Sub
End Class