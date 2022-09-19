<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnClientes)
        Me.Panel1.Controls.Add(Me.btnConfiguracion)
        Me.Panel1.Controls.Add(Me.btnHistorial)
        Me.Panel1.Controls.Add(Me.btnVentas)
        Me.Panel1.Controls.Add(Me.btnProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 426)
        Me.Panel1.TabIndex = 0
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfiguracion.Location = New System.Drawing.Point(0, 366)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(101, 41)
        Me.btnConfiguracion.TabIndex = 4
        Me.btnConfiguracion.Text = "Configuracion"
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHistorial.Location = New System.Drawing.Point(0, 295)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(101, 41)
        Me.btnHistorial.TabIndex = 3
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVentas.Location = New System.Drawing.Point(0, 228)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(101, 41)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProductos.Location = New System.Drawing.Point(0, 159)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(101, 41)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClientes.Location = New System.Drawing.Point(0, 88)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(101, 41)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumBlue
        Me.Panel2.Controls.Add(Me.lblText)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(101, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 60)
        Me.Panel2.TabIndex = 1
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblText.Location = New System.Drawing.Point(201, 9)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(105, 43)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Menu"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(101, 60)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(655, 366)
        Me.PanelPrincipal.TabIndex = 2
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 426)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "MenuForm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents lblText As Label
End Class
