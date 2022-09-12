Imports Negocio
Public Class ClientesForm
    Dim consulta As Consulta_Clientes = New Consulta_Clientes
    Dim llaveBusqueda As String = "Cliente"
    Private Sub ClientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Clientes()
        InicioHabilitar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevoHabilitar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelarNuevo()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If consulta.Obtener_Datos(txtNombre.Text, txtTelefono.Text, txtCorreo.Text) = True Then
            InicioHabilitar()
            Cargar_Clientes()
        Else
            nuevoHabilitar()
        End If
    End Sub

    Private Sub dgwClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwClientes.CellDoubleClick
        DatosATextBox()
        btnEliminar.Enabled = True
        btnEditar.Enabled = True
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarHabilitar()
        consulta.backup_accion(txtID.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text)


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If consulta.Modificar_Cliente(txtID.Text.ToString, txtNombre.Text.ToString, txtTelefono.Text.ToString, txtCorreo.Text.ToString) = True Then
            InicioHabilitar()
        End If
        Cargar_Clientes()
    End Sub



    '------*********------------**************--------------****************------------*********

    Private Function checkid2() As Integer

        Dim i As Integer = CInt(dgwClientes.CurrentRow.Index)
        Dim idcheck As String = dgwClientes.Item(0, i).Value()
        Dim IdShear As Integer = CInt(idcheck)
        Return IdShear
    End Function

    Private Sub DatosATextBox()
        txtID.Text = dgwClientes.Item(0, Lectura_Row).Value
        txtNombre.Text = dgwClientes.Item(1, Lectura_Row).Value
        txtTelefono.Text = dgwClientes.Item(2, Lectura_Row).Value
        txtCorreo.Text = dgwClientes.Item(3, Lectura_Row).Value

    End Sub
    Private Sub Mostrar_Editar()
        btnAgregar.Visible = False
        btnEditar.Enabled = True
    End Sub
    Private Function Lectura_Row() As Integer
        Dim id As Integer = CInt(dgwClientes.CurrentRow.Index)
        Return id
    End Function
    Private Sub Cargar_Clientes()
        dgwClientes.DataSource = consulta.Cargar_Datos()
        dgwClientes.Columns("ID").Visible = False
    End Sub
    Private Sub cancelarNuevo()
        txtID.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        InicioHabilitar()

    End Sub

    Private Sub InicioHabilitar()
        txtBuscar.Text = ""
        txtCorreo.Text = ""
        txtID.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""

        txtBuscar.Enabled = True
        txtCorreo.Enabled = False
        txtID.Enabled = False
        txtNombre.Enabled = False
        txtTelefono.Enabled = False

        btnCancelar.Visible = False
        btnAgregar.Visible = False
        btnActualizar.Visible = False
        btnNuevo.Visible = True
        btnEliminar.Visible = True
        btnEditar.Visible = True

        btnAgregar.Enabled = False
        btnCancelar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = True


        dgwClientes.Enabled = True

    End Sub
    Private Sub EditarHabilitar()

        txtBuscar.Enabled = False
        txtCorreo.Enabled = True
        txtID.Enabled = False
        txtNombre.Enabled = True
        txtTelefono.Enabled = True

        btnCancelar.Visible = True
        btnAgregar.Visible = False
        btnActualizar.Visible = True
        btnNuevo.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnCancelar.Enabled = True
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True

        dgwClientes.Enabled = False

    End Sub
    Private Sub nuevoHabilitar()
        txtBuscar.Text = ""
        txtCorreo.Text = ""
        txtID.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""

        txtBuscar.Enabled = False
        txtCorreo.Enabled = True
        txtID.Enabled = False
        txtNombre.Enabled = True
        txtTelefono.Enabled = True

        btnAgregar.Visible = True
        btnNuevo.Visible = False
        btnEditar.Visible = False
        btnEliminar.Visible = False
        btnCancelar.Visible = True

        btnAgregar.Enabled = True
        btnCancelar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = False
        btnNuevo.Enabled = False


        dgwClientes.Enabled = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If consulta.Eliminar_Cliente(CInt(txtID.Text)) = True Then
            InicioHabilitar()
            Cargar_Clientes()
        Else

        End If
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            Cargar_Clientes()
        Else


            Dim k As New DataView(consulta.Cargar_Datos)
            k.RowFilter = String.Format(" {0} like '%{1}%'", llaveBusqueda, txtBuscar.Text)
            dgwClientes.DataSource = k
            dgwClientes.Columns("ID").Visible = False
            'dgwClientes.Columns("IDCliente").Visible = False
        End If
    End Sub
End Class