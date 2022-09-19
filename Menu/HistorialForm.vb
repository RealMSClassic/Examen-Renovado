Imports Negocio
Public Class HistorialForm

    Dim consulta As Consulta_Historial = New Consulta_Historial
    Private Sub HistorialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEnd.Visible = False
        dtpIni.Visible = False
        txtBuscar.Visible = True
        btnBuscar.Visible = False

        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        dgvHistorial.DataSource = consulta.cargar_historial
        dgvHistorial.Columns("ID").Visible = False
        dgvHistorial.Columns("IDCliente").Visible = False
        dgvHistorial.Columns("Total").Visible = False
    End Sub

    Private Sub TelefonoOps_Click(sender As Object, e As EventArgs) Handles FechaOp.Click
        ClienteOps.Checked = False
        FechaOp.Checked = True
        txtBuscar.Visible = False
        dtpEnd.Visible = True
        dtpIni.Visible = True
        btnBuscar.Visible = True


    End Sub

    Private Sub ClienteOps_Click(sender As Object, e As EventArgs) Handles ClienteOps.Click
        ClienteOps.Checked = True
        FechaOp.Checked = False
        txtBuscar.Visible = True
        dtpEnd.Visible = False
        dtpIni.Visible = False
        btnBuscar.Visible = False
    End Sub

    Private Sub dgvHistorial_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistorial.CellDoubleClick
        If Not dgvHistorial.Item(1, dgvHistorial.CurrentRow.Index).Value.ToString = "" Then
            Informe.Show()
        End If


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            cargarGrilla()
        Else


            Dim k As New DataView(consulta.cargar_historial)
            k.RowFilter = String.Format(" Cliente like '%{0}%'", txtBuscar.Text)
            dgvHistorial.DataSource = k
            dgvHistorial.Columns("ID").Visible = False
            dgvHistorial.Columns("IDCliente").Visible = False
            dgvHistorial.Columns("Total").Visible = False
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click



        fecha()
    End Sub
    Private Sub fecha()
        ' MsgBox(Format(dtpIni.Value, "yyyy/MM/dd").ToString + "" + Format(dtpEnd.Value, "yyyy/MM/dd").ToString)
        dgvHistorial.DataSource = consulta.filtrarXFecha(dtpIni.Value, dtpEnd.Value)

    End Sub

End Class