<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produccion
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVProduccion = New System.Windows.Forms.DataGridView()
        Me.PanelProduccion = New System.Windows.Forms.Panel()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.ComboBoxTamano = New System.Windows.Forms.ComboBox()
        Me.DTPFechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxEmpleado = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProducto = New System.Windows.Forms.ComboBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DGVProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProduccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Producto: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tamaño: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Producción: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Numero de Empleado:"
        '
        'DGVProduccion
        '
        Me.DGVProduccion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProduccion.Location = New System.Drawing.Point(67, 332)
        Me.DGVProduccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVProduccion.Name = "DGVProduccion"
        Me.DGVProduccion.RowHeadersWidth = 51
        Me.DGVProduccion.RowTemplate.Height = 24
        Me.DGVProduccion.Size = New System.Drawing.Size(613, 150)
        Me.DGVProduccion.TabIndex = 6
        '
        'PanelProduccion
        '
        Me.PanelProduccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelProduccion.AutoScroll = True
        Me.PanelProduccion.Controls.Add(Me.TxtCantidad)
        Me.PanelProduccion.Controls.Add(Me.ComboBoxTamano)
        Me.PanelProduccion.Controls.Add(Me.DTPFechaProduccion)
        Me.PanelProduccion.Controls.Add(Me.ComboBoxEmpleado)
        Me.PanelProduccion.Controls.Add(Me.ComboBoxProducto)
        Me.PanelProduccion.Controls.Add(Me.BtnRegresar)
        Me.PanelProduccion.Controls.Add(Me.BtnLimpiar)
        Me.PanelProduccion.Controls.Add(Me.BtnAgregar)
        Me.PanelProduccion.Controls.Add(Me.Label7)
        Me.PanelProduccion.Controls.Add(Me.Label2)
        Me.PanelProduccion.Controls.Add(Me.Label6)
        Me.PanelProduccion.Controls.Add(Me.DGVProduccion)
        Me.PanelProduccion.Controls.Add(Me.Label5)
        Me.PanelProduccion.Controls.Add(Me.Label4)
        Me.PanelProduccion.Controls.Add(Me.Label3)
        Me.PanelProduccion.Location = New System.Drawing.Point(0, 0)
        Me.PanelProduccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelProduccion.Name = "PanelProduccion"
        Me.PanelProduccion.Size = New System.Drawing.Size(744, 558)
        Me.PanelProduccion.TabIndex = 7
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(284, 281)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(229, 22)
        Me.TxtCantidad.TabIndex = 52
        '
        'ComboBoxTamano
        '
        Me.ComboBoxTamano.FormattingEnabled = True
        Me.ComboBoxTamano.Location = New System.Drawing.Point(284, 228)
        Me.ComboBoxTamano.Name = "ComboBoxTamano"
        Me.ComboBoxTamano.Size = New System.Drawing.Size(229, 24)
        Me.ComboBoxTamano.TabIndex = 51
        '
        'DTPFechaProduccion
        '
        Me.DTPFechaProduccion.Location = New System.Drawing.Point(287, 174)
        Me.DTPFechaProduccion.Name = "DTPFechaProduccion"
        Me.DTPFechaProduccion.Size = New System.Drawing.Size(226, 22)
        Me.DTPFechaProduccion.TabIndex = 50
        '
        'ComboBoxEmpleado
        '
        Me.ComboBoxEmpleado.FormattingEnabled = True
        Me.ComboBoxEmpleado.Location = New System.Drawing.Point(287, 59)
        Me.ComboBoxEmpleado.Name = "ComboBoxEmpleado"
        Me.ComboBoxEmpleado.Size = New System.Drawing.Size(226, 24)
        Me.ComboBoxEmpleado.TabIndex = 49
        '
        'ComboBoxProducto
        '
        Me.ComboBoxProducto.FormattingEnabled = True
        Me.ComboBoxProducto.ItemHeight = 16
        Me.ComboBoxProducto.Location = New System.Drawing.Point(287, 114)
        Me.ComboBoxProducto.Name = "ComboBoxProducto"
        Me.ComboBoxProducto.Size = New System.Drawing.Size(226, 24)
        Me.ComboBoxProducto.TabIndex = 48
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegresar.BackColor = System.Drawing.Color.Salmon
        Me.BtnRegresar.Location = New System.Drawing.Point(620, 500)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(109, 37)
        Me.BtnRegresar.TabIndex = 42
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Salmon
        Me.BtnLimpiar.Location = New System.Drawing.Point(496, 500)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(109, 37)
        Me.BtnLimpiar.TabIndex = 41
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.BackColor = System.Drawing.Color.Salmon
        Me.BtnAgregar.Location = New System.Drawing.Point(370, 500)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(109, 37)
        Me.BtnAgregar.TabIndex = 40
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Producción"
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(741, 548)
        Me.Controls.Add(Me.PanelProduccion)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(759, 595)
        Me.MinimumSize = New System.Drawing.Size(759, 595)
        Me.Name = "Produccion"
        Me.Text = "Produccion"
        CType(Me.DGVProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProduccion.ResumeLayout(False)
        Me.PanelProduccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVProduccion As DataGridView
    Friend WithEvents PanelProduccion As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents ComboBoxProducto As ComboBox
    Friend WithEvents ComboBoxEmpleado As ComboBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents ComboBoxTamano As ComboBox
    Friend WithEvents DTPFechaProduccion As DateTimePicker
End Class