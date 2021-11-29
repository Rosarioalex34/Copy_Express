<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Individual
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
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Precio_LPSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Individual))
        Me.CopExpressDataSet = New Copy_Express.CopExpressDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Copy_Express.CopExpressDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager()
        Me.CodigoLabel1 = New System.Windows.Forms.Label()
        Me.DescripcionLabel1 = New System.Windows.Forms.Label()
        Me.Precio_LPSLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnprimero = New System.Windows.Forms.Button()
        Me.btnanterior = New System.Windows.Forms.Button()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnultimo = New System.Windows.Forms.Button()
        Me.btnfacturar = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CodigoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Precio_LPSLabel = New System.Windows.Forms.Label()
        CType(Me.CopExpressDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoLabel.ForeColor = System.Drawing.Color.Black
        CodigoLabel.Location = New System.Drawing.Point(205, 244)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(64, 20)
        CodigoLabel.TabIndex = 1
        CodigoLabel.Text = "Codigo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.ForeColor = System.Drawing.Color.Black
        DescripcionLabel.Location = New System.Drawing.Point(205, 298)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(98, 20)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'Precio_LPSLabel
        '
        Precio_LPSLabel.AutoSize = True
        Precio_LPSLabel.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_LPSLabel.ForeColor = System.Drawing.Color.Black
        Precio_LPSLabel.Location = New System.Drawing.Point(205, 364)
        Precio_LPSLabel.Name = "Precio_LPSLabel"
        Precio_LPSLabel.Size = New System.Drawing.Size(95, 20)
        Precio_LPSLabel.TabIndex = 5
        Precio_LPSLabel.Text = "Precio LPS:"
        '
        'CopExpressDataSet
        '
        Me.CopExpressDataSet.DataSetName = "CopExpressDataSet"
        Me.CopExpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.CopExpressDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CodigoLabel1
        '
        Me.CodigoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Codigo", True))
        Me.CodigoLabel1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoLabel1.ForeColor = System.Drawing.Color.Black
        Me.CodigoLabel1.Location = New System.Drawing.Point(328, 244)
        Me.CodigoLabel1.Name = "CodigoLabel1"
        Me.CodigoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CodigoLabel1.TabIndex = 2
        Me.CodigoLabel1.Text = "Label1"
        '
        'DescripcionLabel1
        '
        Me.DescripcionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionLabel1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionLabel1.ForeColor = System.Drawing.Color.Black
        Me.DescripcionLabel1.Location = New System.Drawing.Point(328, 295)
        Me.DescripcionLabel1.Name = "DescripcionLabel1"
        Me.DescripcionLabel1.Size = New System.Drawing.Size(233, 23)
        Me.DescripcionLabel1.TabIndex = 4
        Me.DescripcionLabel1.Text = "Label1"
        '
        'Precio_LPSLabel1
        '
        Me.Precio_LPSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precio_LPS", True))
        Me.Precio_LPSLabel1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_LPSLabel1.ForeColor = System.Drawing.Color.Black
        Me.Precio_LPSLabel1.Location = New System.Drawing.Point(328, 361)
        Me.Precio_LPSLabel1.Name = "Precio_LPSLabel1"
        Me.Precio_LPSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Precio_LPSLabel1.TabIndex = 6
        Me.Precio_LPSLabel1.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(245, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Consulta Individual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(234, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Santo Domingo, Distrito Nacional"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(216, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Calle 27 de ferbrero. Av Abraham Lincoln" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(249, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Copy Express"
        '
        'btnprimero
        '
        Me.btnprimero.BackColor = System.Drawing.Color.Silver
        Me.btnprimero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnprimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnprimero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnprimero.ForeColor = System.Drawing.Color.Black
        Me.btnprimero.Location = New System.Drawing.Point(631, 192)
        Me.btnprimero.Name = "btnprimero"
        Me.btnprimero.Size = New System.Drawing.Size(100, 30)
        Me.btnprimero.TabIndex = 88
        Me.btnprimero.Text = "Primero"
        Me.btnprimero.UseVisualStyleBackColor = False
        '
        'btnanterior
        '
        Me.btnanterior.BackColor = System.Drawing.Color.Silver
        Me.btnanterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnanterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnanterior.ForeColor = System.Drawing.Color.Black
        Me.btnanterior.Location = New System.Drawing.Point(631, 228)
        Me.btnanterior.Name = "btnanterior"
        Me.btnanterior.Size = New System.Drawing.Size(100, 30)
        Me.btnanterior.TabIndex = 89
        Me.btnanterior.Text = "Anterior"
        Me.btnanterior.UseVisualStyleBackColor = False
        '
        'btnsiguiente
        '
        Me.btnsiguiente.BackColor = System.Drawing.Color.Silver
        Me.btnsiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnsiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsiguiente.ForeColor = System.Drawing.Color.Black
        Me.btnsiguiente.Location = New System.Drawing.Point(631, 264)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(100, 30)
        Me.btnsiguiente.TabIndex = 90
        Me.btnsiguiente.Text = "Siguiente"
        Me.btnsiguiente.UseVisualStyleBackColor = False
        '
        'btnultimo
        '
        Me.btnultimo.BackColor = System.Drawing.Color.Silver
        Me.btnultimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnultimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnultimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnultimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnultimo.ForeColor = System.Drawing.Color.Black
        Me.btnultimo.Location = New System.Drawing.Point(631, 303)
        Me.btnultimo.Name = "btnultimo"
        Me.btnultimo.Size = New System.Drawing.Size(100, 30)
        Me.btnultimo.TabIndex = 91
        Me.btnultimo.Text = "Ultimo"
        Me.btnultimo.UseVisualStyleBackColor = False
        '
        'btnfacturar
        '
        Me.btnfacturar.BackColor = System.Drawing.Color.Maroon
        Me.btnfacturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnfacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnfacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfacturar.ForeColor = System.Drawing.Color.White
        Me.btnfacturar.Location = New System.Drawing.Point(631, 354)
        Me.btnfacturar.Name = "btnfacturar"
        Me.btnfacturar.Size = New System.Drawing.Size(100, 30)
        Me.btnfacturar.TabIndex = 92
        Me.btnfacturar.Text = "Facturar"
        Me.btnfacturar.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Individual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(743, 467)
        Me.Controls.Add(Me.btnfacturar)
        Me.Controls.Add(Me.btnultimo)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnanterior)
        Me.Controls.Add(Me.btnprimero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Precio_LPSLabel)
        Me.Controls.Add(Me.Precio_LPSLabel1)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionLabel1)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Individual"
        Me.Opacity = 0.9R
        Me.Text = "Individual"
        CType(Me.CopExpressDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CopExpressDataSet As Copy_Express.CopExpressDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Copy_Express.CopExpressDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodigoLabel1 As System.Windows.Forms.Label
    Friend WithEvents DescripcionLabel1 As System.Windows.Forms.Label
    Friend WithEvents Precio_LPSLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnprimero As System.Windows.Forms.Button
    Friend WithEvents btnanterior As System.Windows.Forms.Button
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnultimo As System.Windows.Forms.Button
    Friend WithEvents btnfacturar As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
