<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.filtro = New System.Windows.Forms.Button()
        Me.menuFiltro = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClienteOps = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaOp = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpIni = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvHistorial
        '
        Me.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorial.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistorial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHistorial.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHistorial.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvHistorial.Location = New System.Drawing.Point(11, 57)
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHistorial.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Size = New System.Drawing.Size(613, 288)
        Me.dgvHistorial.TabIndex = 0
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(11, 28)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(239, 20)
        Me.txtBuscar.TabIndex = 1
        '
        'filtro
        '
        Me.filtro.ContextMenuStrip = Me.menuFiltro
        Me.filtro.Location = New System.Drawing.Point(601, 28)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(23, 23)
        Me.filtro.TabIndex = 2
        Me.filtro.Text = "F"
        Me.filtro.UseVisualStyleBackColor = True
        '
        'menuFiltro
        '
        Me.menuFiltro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteOps, Me.FechaOp})
        Me.menuFiltro.Name = "menuFiltro"
        Me.menuFiltro.Size = New System.Drawing.Size(117, 48)
        '
        'ClienteOps
        '
        Me.ClienteOps.Checked = True
        Me.ClienteOps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClienteOps.Name = "ClienteOps"
        Me.ClienteOps.Size = New System.Drawing.Size(116, 22)
        Me.ClienteOps.Text = "Clientes"
        '
        'FechaOp
        '
        Me.FechaOp.Name = "FechaOp"
        Me.FechaOp.Size = New System.Drawing.Size(116, 22)
        Me.FechaOp.Text = "Fecha"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "yyyy/MM/dd"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(183, 27)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(141, 20)
        Me.dtpEnd.TabIndex = 3
        Me.dtpEnd.Visible = False
        '
        'dtpIni
        '
        Me.dtpIni.CustomFormat = "yyyy/MM/dd"
        Me.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpIni.Location = New System.Drawing.Point(12, 27)
        Me.dtpIni.Name = "dtpIni"
        Me.dtpIni.Size = New System.Drawing.Size(146, 20)
        Me.dtpIni.TabIndex = 4
        Me.dtpIni.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.ContextMenuStrip = Me.menuFiltro
        Me.btnBuscar.Location = New System.Drawing.Point(355, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(59, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'HistorialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(636, 357)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtpIni)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvHistorial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HistorialForm"
        Me.Text = "HistorialForm"
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHistorial As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents filtro As Button
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents dtpIni As DateTimePicker
    Friend WithEvents menuFiltro As ContextMenuStrip
    Friend WithEvents ClienteOps As ToolStripMenuItem
    Friend WithEvents FechaOp As ToolStripMenuItem
    Friend WithEvents btnBuscar As Button
End Class
