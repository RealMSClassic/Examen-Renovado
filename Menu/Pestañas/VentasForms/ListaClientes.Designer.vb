<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgwClientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.menuFiltro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClienteOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelefonoOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorreoOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFiltros = New System.Windows.Forms.Button()
        CType(Me.dgwClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwClientes
        '
        Me.dgwClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwClientes.Location = New System.Drawing.Point(12, 69)
        Me.dgwClientes.Name = "dgwClientes"
        Me.dgwClientes.ReadOnly = True
        Me.dgwClientes.RowHeadersVisible = False
        Me.dgwClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwClientes.Size = New System.Drawing.Size(257, 217)
        Me.dgwClientes.TabIndex = 0
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(13, 43)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(147, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'menuFiltro
        '
        Me.menuFiltro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteOps, Me.TelefonoOps, Me.CorreoOps})
        Me.menuFiltro.Name = "menuFiltro"
        Me.menuFiltro.Size = New System.Drawing.Size(120, 70)
        '
        'ClienteOps
        '
        Me.ClienteOps.Checked = True
        Me.ClienteOps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClienteOps.Name = "ClienteOps"
        Me.ClienteOps.Size = New System.Drawing.Size(119, 22)
        Me.ClienteOps.Text = "Clientes"
        '
        'TelefonoOps
        '
        Me.TelefonoOps.Name = "TelefonoOps"
        Me.TelefonoOps.Size = New System.Drawing.Size(119, 22)
        Me.TelefonoOps.Text = "Telefono"
        '
        'CorreoOps
        '
        Me.CorreoOps.Name = "CorreoOps"
        Me.CorreoOps.Size = New System.Drawing.Size(119, 22)
        Me.CorreoOps.Text = "Correo"
        '
        'btnFiltros
        '
        Me.btnFiltros.ContextMenuStrip = Me.menuFiltro
        Me.btnFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFiltros.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltros.Location = New System.Drawing.Point(246, 43)
        Me.btnFiltros.Name = "btnFiltros"
        Me.btnFiltros.Size = New System.Drawing.Size(23, 20)
        Me.btnFiltros.TabIndex = 22
        Me.btnFiltros.Text = "F"
        Me.btnFiltros.UseVisualStyleBackColor = True
        '
        'ListaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 288)
        Me.Controls.Add(Me.btnFiltros)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgwClientes)
        Me.Name = "ListaClientes"
        Me.Text = "Clientes"
        CType(Me.dgwClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgwClientes As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents menuFiltro As ContextMenuStrip
    Friend WithEvents ClienteOps As ToolStripMenuItem
    Friend WithEvents TelefonoOps As ToolStripMenuItem
    Friend WithEvents CorreoOps As ToolStripMenuItem
    Friend WithEvents btnFiltros As Button
End Class
