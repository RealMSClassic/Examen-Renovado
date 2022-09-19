Imports Negocio
Public Class ProductosForm

    Dim consultas As Consulta_Productos = New Consulta_Productos
    Dim llaveBusqueda As String = "Cliente"
    Private Sub ClientesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Productos()
        InicioHabilitar()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nuevoHabilitar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelarNuevo()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If consultas.Obtener_Datos(txtNombre.Text, CDec(txtPrecio.Text), txtCategoria.Text) = True Then
            InicioHabilitar()
            Cargar_Productos()
        Else
            nuevoHabilitar()
        End If
    End Sub

    Private Sub dgwClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwProductos.CellDoubleClick
        If Not dgwProductos.Item(1, dgwProductos.CurrentRow.Index).Value.ToString = "" Then
            DatosATextBox()
            btnEliminar.Enabled = True
            btnEditar.Enabled = True
        End If

    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarHabilitar()

        consultas.backup_accion(CInt(txtID.Text), txtNombre.Text, CDec(txtPrecio.Text), txtCategoria.Text)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If consultas.Modificar_Cliente(CInt(txtID.Text), txtNombre.Text.ToString, CDec(txtPrecio.Text), txtCategoria.Text.ToString) = True Then
            Cargar_Productos()
            InicioHabilitar()
        End If

    End Sub
    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        InicioHabilitar()
        Cargar_Productos()
        ProductoToolStripMenuItem.Checked = True
        CategoriaToolStripMenuItem.Checked = False
        txtBuscar.Enabled = True

    End Sub

    Private Sub filtroCbx_TextChanged(sender As Object, e As EventArgs) Handles filtroCbx.TextChanged
        CategoriaToolStripMenuItem.Checked = True
        ProductoToolStripMenuItem.Checked = False
        Dim k As New DataView(consultas.Cargar_Datos_lista)
        k.RowFilter = String.Format(" Categoria like '%{0}%'", filtroCbx.Text)
        dgwProductos.DataSource = k
        dgwProductos.Columns("ID").Visible = False
        txtBuscar.Enabled = False
    End Sub


    '------*********------------**************--------------****************------------*********

    Private Function checkid2() As Integer

        Dim i As Integer = CInt(dgwProductos.CurrentRow.Index)
        Dim idcheck As String = dgwProductos.Item(0, i).Value()
        Dim IdShear As Integer = CInt(idcheck)
        Return IdShear
    End Function

    Private Sub DatosATextBox()
        txtID.Text = dgwProductos.Item(0, Lectura_Row).Value
        txtNombre.Text = dgwProductos.Item(1, Lectura_Row).Value
        txtCategoria.Text = dgwProductos.Item(3, Lectura_Row).Value
        txtPrecio.Text = dgwProductos.Item(2, Lectura_Row).Value

    End Sub
    Private Sub Mostrar_Editar()
        btnAgregar.Visible = False
        btnEditar.Enabled = True
    End Sub
    Private Function Lectura_Row() As Integer
        Dim id As Integer = CInt(dgwProductos.CurrentRow.Index)
        Return id
    End Function
    Private Sub Cargar_Productos()
        dgwProductos.DataSource = consultas.Cargar_Datos_lista

        dgwProductos.Columns("ID").Visible = False
    End Sub
    Private Sub cancelarNuevo()
        txtID.Clear()
        txtNombre.Clear()
        txtCategoria.Text = "Varios"
        txtPrecio.Clear()
        InicioHabilitar()

    End Sub

    Private Sub InicioHabilitar()
        txtBuscar.Text = ""
        txtPrecio.Text = ""
        txtID.Text = ""
        txtNombre.Text = ""
        txtCategoria.Text = ""

        txtBuscar.Enabled = True
        txtPrecio.Enabled = False
        txtID.Enabled = False
        txtNombre.Enabled = False
        txtCategoria.Enabled = False

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


        dgwProductos.Enabled = True

    End Sub
    Private Sub EditarHabilitar()

        txtBuscar.Enabled = False
        txtPrecio.Enabled = True
        txtID.Enabled = False
        txtNombre.Enabled = True
        txtCategoria.Enabled = True

        btnCancelar.Visible = True
        btnAgregar.Visible = False
        btnActualizar.Visible = True
        btnNuevo.Visible = False
        btnEliminar.Visible = False
        btnEditar.Visible = False
        btnCancelar.Enabled = True
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True

        dgwProductos.Enabled = False

    End Sub
    Private Sub nuevoHabilitar()
        txtBuscar.Text = ""
        txtPrecio.Text = ""
        txtID.Text = ""
        txtNombre.Text = ""
        txtCategoria.Text = ""

        txtBuscar.Enabled = False
        txtPrecio.Enabled = True
        txtID.Enabled = False
        txtNombre.Enabled = True
        txtCategoria.Enabled = True

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


        dgwProductos.Enabled = False

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If consultas.Eliminar_Producto(CInt(txtID.Text)) = True Then
            InicioHabilitar()
            Cargar_Productos()
        Else

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            Cargar_Productos()
        Else


            Dim k As New DataView(consultas.Cargar_Datos_lista)
            k.RowFilter = String.Format("Nombre like '%{0}%'", txtBuscar.Text)
            dgwProductos.DataSource = k
            dgwProductos.Columns("ID").Visible = False
            'dgwClientes.Columns("IDCliente").Visible = False
        End If
    End Sub




End Class