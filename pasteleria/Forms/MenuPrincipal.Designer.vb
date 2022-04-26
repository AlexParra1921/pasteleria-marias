<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.PanelSubMenuProductos = New System.Windows.Forms.Panel()
        Me.BtnRegProduccion = New System.Windows.Forms.Button()
        Me.BtnRegProducto = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnAgenda = New System.Windows.Forms.Button()
        Me.PanelSubMenuPedidos = New System.Windows.Forms.Panel()
        Me.BtnConsultarPedido = New System.Windows.Forms.Button()
        Me.BtnRegPedido = New System.Windows.Forms.Button()
        Me.BtnPedidos = New System.Windows.Forms.Button()
        Me.PanelSubMenuClientes = New System.Windows.Forms.Panel()
        Me.BtnConsultaCliente = New System.Windows.Forms.Button()
        Me.BtnRegCliente = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelFormHijo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelLateral.SuspendLayout()
        Me.PanelSubMenuProductos.SuspendLayout()
        Me.PanelSubMenuPedidos.SuspendLayout()
        Me.PanelSubMenuClientes.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelFormHijo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.AutoScroll = True
        Me.PanelLateral.Controls.Add(Me.BtnCerrarSesion)
        Me.PanelLateral.Controls.Add(Me.PanelSubMenuProductos)
        Me.PanelLateral.Controls.Add(Me.BtnProductos)
        Me.PanelLateral.Controls.Add(Me.BtnAgenda)
        Me.PanelLateral.Controls.Add(Me.PanelSubMenuPedidos)
        Me.PanelLateral.Controls.Add(Me.BtnPedidos)
        Me.PanelLateral.Controls.Add(Me.PanelSubMenuClientes)
        Me.PanelLateral.Controls.Add(Me.BtnClientes)
        Me.PanelLateral.Controls.Add(Me.PanelLogo)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(250, 724)
        Me.PanelLateral.TabIndex = 0
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.BackColor = System.Drawing.Color.MistyRose
        Me.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(0, 978)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(229, 58)
        Me.BtnCerrarSesion.TabIndex = 24
        Me.BtnCerrarSesion.Text = "Cerrar Sesión"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = False
        '
        'PanelSubMenuProductos
        '
        Me.PanelSubMenuProductos.Controls.Add(Me.BtnRegProduccion)
        Me.PanelSubMenuProductos.Controls.Add(Me.BtnRegProducto)
        Me.PanelSubMenuProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuProductos.Location = New System.Drawing.Point(0, 813)
        Me.PanelSubMenuProductos.Name = "PanelSubMenuProductos"
        Me.PanelSubMenuProductos.Size = New System.Drawing.Size(229, 165)
        Me.PanelSubMenuProductos.TabIndex = 18
        '
        'BtnRegProduccion
        '
        Me.BtnRegProduccion.BackColor = System.Drawing.Color.MistyRose
        Me.BtnRegProduccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegProduccion.FlatAppearance.BorderSize = 0
        Me.BtnRegProduccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnRegProduccion.Location = New System.Drawing.Point(0, 80)
        Me.BtnRegProduccion.Name = "BtnRegProduccion"
        Me.BtnRegProduccion.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnRegProduccion.Size = New System.Drawing.Size(229, 80)
        Me.BtnRegProduccion.TabIndex = 5
        Me.BtnRegProduccion.Text = "Registrar Producción"
        Me.BtnRegProduccion.UseVisualStyleBackColor = False
        '
        'BtnRegProducto
        '
        Me.BtnRegProducto.BackColor = System.Drawing.Color.MistyRose
        Me.BtnRegProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegProducto.FlatAppearance.BorderSize = 0
        Me.BtnRegProducto.Location = New System.Drawing.Point(0, 0)
        Me.BtnRegProducto.Name = "BtnRegProducto"
        Me.BtnRegProducto.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnRegProducto.Size = New System.Drawing.Size(229, 80)
        Me.BtnRegProducto.TabIndex = 4
        Me.BtnRegProducto.Text = "Registrar Productos"
        Me.BtnRegProducto.UseVisualStyleBackColor = False
        '
        'BtnProductos
        '
        Me.BtnProductos.BackColor = System.Drawing.Color.MistyRose
        Me.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.Location = New System.Drawing.Point(0, 722)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BtnProductos.Size = New System.Drawing.Size(229, 91)
        Me.BtnProductos.TabIndex = 23
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'BtnAgenda
        '
        Me.BtnAgenda.BackColor = System.Drawing.Color.MistyRose
        Me.BtnAgenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgenda.FlatAppearance.BorderSize = 0
        Me.BtnAgenda.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgenda.Location = New System.Drawing.Point(0, 631)
        Me.BtnAgenda.Name = "BtnAgenda"
        Me.BtnAgenda.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BtnAgenda.Size = New System.Drawing.Size(229, 91)
        Me.BtnAgenda.TabIndex = 22
        Me.BtnAgenda.Text = "Agenda"
        Me.BtnAgenda.UseVisualStyleBackColor = False
        '
        'PanelSubMenuPedidos
        '
        Me.PanelSubMenuPedidos.Controls.Add(Me.BtnConsultarPedido)
        Me.PanelSubMenuPedidos.Controls.Add(Me.BtnRegPedido)
        Me.PanelSubMenuPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuPedidos.Location = New System.Drawing.Point(0, 467)
        Me.PanelSubMenuPedidos.Name = "PanelSubMenuPedidos"
        Me.PanelSubMenuPedidos.Size = New System.Drawing.Size(229, 164)
        Me.PanelSubMenuPedidos.TabIndex = 21
        '
        'BtnConsultarPedido
        '
        Me.BtnConsultarPedido.BackColor = System.Drawing.Color.MistyRose
        Me.BtnConsultarPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConsultarPedido.FlatAppearance.BorderSize = 0
        Me.BtnConsultarPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConsultarPedido.Location = New System.Drawing.Point(0, 84)
        Me.BtnConsultarPedido.Name = "BtnConsultarPedido"
        Me.BtnConsultarPedido.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnConsultarPedido.Size = New System.Drawing.Size(229, 80)
        Me.BtnConsultarPedido.TabIndex = 3
        Me.BtnConsultarPedido.Text = "Consultar Pedido"
        Me.BtnConsultarPedido.UseVisualStyleBackColor = False
        '
        'BtnRegPedido
        '
        Me.BtnRegPedido.BackColor = System.Drawing.Color.MistyRose
        Me.BtnRegPedido.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegPedido.FlatAppearance.BorderSize = 0
        Me.BtnRegPedido.Location = New System.Drawing.Point(0, 0)
        Me.BtnRegPedido.Name = "BtnRegPedido"
        Me.BtnRegPedido.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnRegPedido.Size = New System.Drawing.Size(229, 84)
        Me.BtnRegPedido.TabIndex = 2
        Me.BtnRegPedido.Text = "Registrar Pedido"
        Me.BtnRegPedido.UseVisualStyleBackColor = False
        '
        'BtnPedidos
        '
        Me.BtnPedidos.BackColor = System.Drawing.Color.MistyRose
        Me.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPedidos.FlatAppearance.BorderSize = 0
        Me.BtnPedidos.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPedidos.Location = New System.Drawing.Point(0, 376)
        Me.BtnPedidos.Name = "BtnPedidos"
        Me.BtnPedidos.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BtnPedidos.Size = New System.Drawing.Size(229, 91)
        Me.BtnPedidos.TabIndex = 20
        Me.BtnPedidos.Text = "Pedidos"
        Me.BtnPedidos.UseVisualStyleBackColor = False
        '
        'PanelSubMenuClientes
        '
        Me.PanelSubMenuClientes.Controls.Add(Me.BtnConsultaCliente)
        Me.PanelSubMenuClientes.Controls.Add(Me.BtnRegCliente)
        Me.PanelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuClientes.Location = New System.Drawing.Point(0, 219)
        Me.PanelSubMenuClientes.Name = "PanelSubMenuClientes"
        Me.PanelSubMenuClientes.Size = New System.Drawing.Size(229, 157)
        Me.PanelSubMenuClientes.TabIndex = 19
        '
        'BtnConsultaCliente
        '
        Me.BtnConsultaCliente.BackColor = System.Drawing.Color.MistyRose
        Me.BtnConsultaCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConsultaCliente.FlatAppearance.BorderSize = 0
        Me.BtnConsultaCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnConsultaCliente.Location = New System.Drawing.Point(0, 80)
        Me.BtnConsultaCliente.Name = "BtnConsultaCliente"
        Me.BtnConsultaCliente.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnConsultaCliente.Size = New System.Drawing.Size(229, 80)
        Me.BtnConsultaCliente.TabIndex = 1
        Me.BtnConsultaCliente.Text = "Consultar Cliente"
        Me.BtnConsultaCliente.UseVisualStyleBackColor = False
        '
        'BtnRegCliente
        '
        Me.BtnRegCliente.BackColor = System.Drawing.Color.MistyRose
        Me.BtnRegCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRegCliente.FlatAppearance.BorderSize = 0
        Me.BtnRegCliente.Location = New System.Drawing.Point(0, 0)
        Me.BtnRegCliente.Name = "BtnRegCliente"
        Me.BtnRegCliente.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.BtnRegCliente.Size = New System.Drawing.Size(229, 80)
        Me.BtnRegCliente.TabIndex = 0
        Me.BtnRegCliente.Text = "Registrar Cliente"
        Me.BtnRegCliente.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.Color.MistyRose
        Me.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Location = New System.Drawing.Point(0, 128)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.BtnClientes.Size = New System.Drawing.Size(229, 91)
        Me.BtnClientes.TabIndex = 18
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.MistyRose
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(229, 128)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pasteleria.My.Resources.Resources.logoBueno
        Me.PictureBox1.Location = New System.Drawing.Point(38, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.MistyRose
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(250, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(760, 128)
        Me.PanelSuperior.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 57)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Maria´s Pasteleria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFormHijo
        '
        Me.PanelFormHijo.BackColor = System.Drawing.Color.Plum
        Me.PanelFormHijo.Controls.Add(Me.Label2)
        Me.PanelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormHijo.Location = New System.Drawing.Point(250, 128)
        Me.PanelFormHijo.Name = "PanelFormHijo"
        Me.PanelFormHijo.Size = New System.Drawing.Size(760, 596)
        Me.PanelFormHijo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 91)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bienvenido"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 724)
        Me.Controls.Add(Me.PanelFormHijo)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.PanelLateral)
        Me.MinimumSize = New System.Drawing.Size(1028, 771)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.PanelLateral.ResumeLayout(False)
        Me.PanelSubMenuProductos.ResumeLayout(False)
        Me.PanelSubMenuPedidos.ResumeLayout(False)
        Me.PanelSubMenuClientes.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelFormHijo.ResumeLayout(False)
        Me.PanelFormHijo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelSubMenuClientes As Panel
    Friend WithEvents BtnConsultaCliente As Button
    Friend WithEvents BtnRegCliente As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelSubMenuPedidos As Panel
    Friend WithEvents BtnPedidos As Button
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnAgenda As Button
    Friend WithEvents BtnConsultarPedido As Button
    Friend WithEvents BtnRegPedido As Button
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents PanelSubMenuProductos As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnRegProduccion As Button
    Friend WithEvents BtnRegProducto As Button
    Friend WithEvents PanelFormHijo As Panel
    Friend WithEvents Label2 As Label
End Class
