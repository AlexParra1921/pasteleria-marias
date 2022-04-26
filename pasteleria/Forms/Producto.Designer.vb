<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Producto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelAgregarOtro = New System.Windows.Forms.Panel()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboIdProducto = New System.Windows.Forms.ComboBox()
        Me.TxtCosto = New System.Windows.Forms.TextBox()
        Me.BtnTamano = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVTamanos = New System.Windows.Forms.DataGridView()
        Me.TxtTamano = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelProductos.SuspendLayout()
        Me.PanelAgregarOtro.SuspendLayout()
        CType(Me.DGVTamanos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelProductos
        '
        Me.PanelProductos.BackColor = System.Drawing.Color.Plum
        Me.PanelProductos.Controls.Add(Me.BtnAceptar)
        Me.PanelProductos.Controls.Add(Me.BtnRegresar)
        Me.PanelProductos.Controls.Add(Me.BtnLimpiar)
        Me.PanelProductos.Controls.Add(Me.Label5)
        Me.PanelProductos.Controls.Add(Me.PanelAgregarOtro)
        Me.PanelProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelProductos.Location = New System.Drawing.Point(0, 0)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(742, 549)
        Me.PanelProductos.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.BackColor = System.Drawing.Color.Salmon
        Me.BtnAceptar.Location = New System.Drawing.Point(358, 500)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(110, 37)
        Me.BtnAceptar.TabIndex = 44
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegresar.BackColor = System.Drawing.Color.Salmon
        Me.BtnRegresar.Location = New System.Drawing.Point(610, 500)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(110, 37)
        Me.BtnRegresar.TabIndex = 43
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Salmon
        Me.BtnLimpiar.Location = New System.Drawing.Point(485, 500)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(110, 37)
        Me.BtnLimpiar.TabIndex = 42
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Agregar Productos"
        '
        'PanelAgregarOtro
        '
        Me.PanelAgregarOtro.Controls.Add(Me.BtnProducto)
        Me.PanelAgregarOtro.Controls.Add(Me.TxtNombreProducto)
        Me.PanelAgregarOtro.Controls.Add(Me.Label6)
        Me.PanelAgregarOtro.Controls.Add(Me.ComboIdProducto)
        Me.PanelAgregarOtro.Controls.Add(Me.TxtCosto)
        Me.PanelAgregarOtro.Controls.Add(Me.BtnTamano)
        Me.PanelAgregarOtro.Controls.Add(Me.Label3)
        Me.PanelAgregarOtro.Controls.Add(Me.DGVTamanos)
        Me.PanelAgregarOtro.Controls.Add(Me.TxtTamano)
        Me.PanelAgregarOtro.Controls.Add(Me.Label1)
        Me.PanelAgregarOtro.Controls.Add(Me.Label2)
        Me.PanelAgregarOtro.Controls.Add(Me.Label4)
        Me.PanelAgregarOtro.Location = New System.Drawing.Point(29, 41)
        Me.PanelAgregarOtro.Name = "PanelAgregarOtro"
        Me.PanelAgregarOtro.Size = New System.Drawing.Size(684, 433)
        Me.PanelAgregarOtro.TabIndex = 40
        '
        'BtnProducto
        '
        Me.BtnProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProducto.BackColor = System.Drawing.Color.Salmon
        Me.BtnProducto.Location = New System.Drawing.Point(474, 22)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(110, 45)
        Me.BtnProducto.TabIndex = 47
        Me.BtnProducto.Text = "Agregar Producto"
        Me.BtnProducto.UseVisualStyleBackColor = False
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(193, 61)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(213, 22)
        Me.TxtNombreProducto.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Número de Producto:"
        '
        'ComboIdProducto
        '
        Me.ComboIdProducto.FormattingEnabled = True
        Me.ComboIdProducto.Location = New System.Drawing.Point(192, 22)
        Me.ComboIdProducto.Name = "ComboIdProducto"
        Me.ComboIdProducto.Size = New System.Drawing.Size(121, 24)
        Me.ComboIdProducto.TabIndex = 43
        '
        'TxtCosto
        '
        Me.TxtCosto.Location = New System.Drawing.Point(192, 171)
        Me.TxtCosto.Multiline = True
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(213, 32)
        Me.TxtCosto.TabIndex = 40
        '
        'BtnTamano
        '
        Me.BtnTamano.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTamano.BackColor = System.Drawing.Color.Salmon
        Me.BtnTamano.Location = New System.Drawing.Point(474, 160)
        Me.BtnTamano.Name = "BtnTamano"
        Me.BtnTamano.Size = New System.Drawing.Size(110, 45)
        Me.BtnTamano.TabIndex = 39
        Me.BtnTamano.Text = "Agregar Tamaño"
        Me.BtnTamano.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Seleccionar de la Lista Tamaños Disponibles"
        '
        'DGVTamanos
        '
        Me.DGVTamanos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVTamanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTamanos.Location = New System.Drawing.Point(48, 266)
        Me.DGVTamanos.Name = "DGVTamanos"
        Me.DGVTamanos.RowHeadersWidth = 51
        Me.DGVTamanos.RowTemplate.Height = 24
        Me.DGVTamanos.Size = New System.Drawing.Size(614, 154)
        Me.DGVTamanos.TabIndex = 27
        '
        'TxtTamano
        '
        Me.TxtTamano.Location = New System.Drawing.Point(193, 102)
        Me.TxtTamano.Multiline = True
        Me.TxtTamano.Name = "TxtTamano"
        Me.TxtTamano.Size = New System.Drawing.Size(213, 32)
        Me.TxtTamano.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Costo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tamaño:"
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 549)
        Me.Controls.Add(Me.PanelProductos)
        Me.MaximumSize = New System.Drawing.Size(760, 596)
        Me.MinimumSize = New System.Drawing.Size(760, 596)
        Me.Name = "Producto"
        Me.Text = "Producto"
        Me.PanelProductos.ResumeLayout(False)
        Me.PanelProductos.PerformLayout()
        Me.PanelAgregarOtro.ResumeLayout(False)
        Me.PanelAgregarOtro.PerformLayout()
        CType(Me.DGVTamanos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelProductos As Panel
    Friend WithEvents PanelAgregarOtro As Panel
    Friend WithEvents BtnTamano As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVTamanos As DataGridView
    Friend WithEvents TxtTamano As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtCosto As TextBox
    Friend WithEvents ComboIdProducto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents BtnProducto As Button
End Class
