Imports Negocio
Imports Entidad

Public Class ListaClientes
    Dim llaveBusqueda As String = "Cliente"
    Dim consultaCliente As Consulta_Clientes = New Consulta_Clientes
    Private Sub ListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgwClientes.DataSource = consultaCliente.Cargar_Datos()
    End Sub



    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwClientes.CellContentClick
        If Not dgwClientes.Item(0, dgwClientes.CurrentRow.Index).Value.ToString = "" Then
            ResumenVentaForm.lblID.Text = dgwClientes.Item(0, dgwClientes.CurrentRow.Index).Value
            ResumenVentaForm.lblCliente.Text = dgwClientes.Item(1, dgwClientes.CurrentRow.Index).Value
        End If
        Me.Close()
    End Sub
    Private Sub ClienteOps_Click(sender As Object, e As EventArgs) Handles ClienteOps.Click
        ClienteOps.Checked = True
        TelefonoOps.Checked = False
        CorreoOps.Checked = False
        llaveBusqueda = "Cliente"
    End Sub

    Private Sub TelefonoOps_Click(sender As Object, e As EventArgs) Handles TelefonoOps.Click
        ClienteOps.Checked = False
        TelefonoOps.Checked = True
        CorreoOps.Checked = False
        llaveBusqueda = "Telefono"
    End Sub

    Private Sub CorreoOps_Click(sender As Object, e As EventArgs) Handles CorreoOps.Click
        ClienteOps.Checked = False
        TelefonoOps.Checked = False
        CorreoOps.Checked = True
        llaveBusqueda = "Correo"
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then

            dgwClientes.DataSource = consultaCliente.Cargar_Datos()
        Else


            Dim k As New DataView(consultaCliente.Cargar_Datos)
            k.RowFilter = String.Format(" {0} like '%{1}%'", llaveBusqueda, txtBuscar.Text)
            dgwClientes.DataSource = k
            dgwClientes.Columns("ID").Visible = False
            'dgwClientes.Columns("IDCliente").Visible = False
        End If
    End Sub
End Class