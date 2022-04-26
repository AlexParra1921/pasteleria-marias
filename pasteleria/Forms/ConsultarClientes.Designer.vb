<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarClientes
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtPaterno = New System.Windows.Forms.TextBox()
        Me.TxtMaterno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DGVConsultaCliente = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVConsultaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtPaterno)
        Me.Panel1.Controls.Add(Me.TxtMaterno)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 232)
        Me.Panel1.TabIndex = 23
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.BackColor = System.Drawing.Color.Salmon
        Me.BtnBuscar.Location = New System.Drawing.Point(581, 176)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(110, 37)
        Me.BtnBuscar.TabIndex = 26
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtPaterno
        '
        Me.TxtPaterno.Location = New System.Drawing.Point(206, 57)
        Me.TxtPaterno.Multiline = True
        Me.TxtPaterno.Name = "TxtPaterno"
        Me.TxtPaterno.Size = New System.Drawing.Size(377, 32)
        Me.TxtPaterno.TabIndex = 31
        '
        'TxtMaterno
        '
        Me.TxtMaterno.Location = New System.Drawing.Point(206, 126)
        Me.TxtMaterno.Multiline = True
        Me.TxtMaterno.Name = "TxtMaterno"
        Me.TxtMaterno.Size = New System.Drawing.Size(377, 32)
        Me.TxtMaterno.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Apellido Materno: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Apellido Paterno: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consultar Cliente"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLimpiar.BackColor = System.Drawing.Color.Salmon
        Me.BtnLimpiar.Location = New System.Drawing.Point(485, 500)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(110, 37)
        Me.BtnLimpiar.TabIndex = 24
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegresar.BackColor = System.Drawing.Color.Salmon
        Me.BtnRegresar.Location = New System.Drawing.Point(610, 500)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(110, 37)
        Me.BtnRegresar.TabIndex = 25
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'DGVConsultaCliente
        '
        Me.DGVConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsultaCliente.Location = New System.Drawing.Point(34, 257)
        Me.DGVConsultaCliente.Name = "DGVConsultaCliente"
        Me.DGVConsultaCliente.RowHeadersWidth = 51
        Me.DGVConsultaCliente.RowTemplate.Height = 24
        Me.DGVConsultaCliente.Size = New System.Drawing.Size(643, 215)
        Me.DGVConsultaCliente.TabIndex = 33
        Me.DGVConsultaCliente.UseWaitCursor = True
        '
        'ConsultarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(742, 549)
        Me.Controls.Add(Me.DGVConsultaCliente)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(760, 596)
        Me.MinimumSize = New System.Drawing.Size(760, 596)
        Me.Name = "ConsultarClientes"
        Me.Text = "ConsultarClientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVConsultaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtPaterno As TextBox
    Friend WithEvents TxtMaterno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents DGVConsultaCliente As DataGridView
    Friend WithEvents BtnBuscar As Button
End Class
