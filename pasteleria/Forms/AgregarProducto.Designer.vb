<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.PanelSubAgregarProduto = New System.Windows.Forms.Panel()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.PanelSubAgregarProduto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del Producto:"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(283, 184)
        Me.TxtNombreProducto.Multiline = True
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(377, 32)
        Me.TxtNombreProducto.TabIndex = 34
        '
        'PanelSubAgregarProduto
        '
        Me.PanelSubAgregarProduto.Controls.Add(Me.BtnAceptar)
        Me.PanelSubAgregarProduto.Controls.Add(Me.TxtNombreProducto)
        Me.PanelSubAgregarProduto.Controls.Add(Me.Label1)
        Me.PanelSubAgregarProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSubAgregarProduto.Location = New System.Drawing.Point(0, 0)
        Me.PanelSubAgregarProduto.Name = "PanelSubAgregarProduto"
        Me.PanelSubAgregarProduto.Size = New System.Drawing.Size(800, 450)
        Me.PanelSubAgregarProduto.TabIndex = 35
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(669, 400)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(78, 38)
        Me.BtnAceptar.TabIndex = 35
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelSubAgregarProduto)
        Me.Name = "AgregarProducto"
        Me.Text = "AgregarProducto"
        Me.PanelSubAgregarProduto.ResumeLayout(False)
        Me.PanelSubAgregarProduto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents PanelSubAgregarProduto As Panel
    Friend WithEvents BtnAceptar As Button
End Class
