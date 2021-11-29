<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.CopExpressDataSet1 = New Copy_Express.CopExpressDataSet()
        Me.FacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter1 = New Copy_Express.CopExpressDataSetTableAdapters.FacturaTableAdapter()
        Me.TableAdapterManager1 = New Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.aceptarbtn = New System.Windows.Forms.Button()
        Me.txttotal1 = New System.Windows.Forms.TextBox()
        Me.lbltotal1 = New System.Windows.Forms.Label()
        Me.confirmarbtn = New System.Windows.Forms.Button()
        Me.lblcantidad1 = New System.Windows.Forms.Label()
        Me.lblprecio1 = New System.Windows.Forms.Label()
        Me.lbldescripcion1 = New System.Windows.Forms.Label()
        Me.lblcodigo1 = New System.Windows.Forms.Label()
        Me.lblhora1 = New System.Windows.Forms.Label()
        Me.lblfecha1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtprecio1 = New System.Windows.Forms.TextBox()
        Me.txtcantidad1 = New System.Windows.Forms.TextBox()
        Me.txtdescripcion1 = New System.Windows.Forms.TextBox()
        Me.txtcodigo1 = New System.Windows.Forms.TextBox()
        Me.Facturarbtn = New System.Windows.Forms.Button()
        Me.Eliminarbtn = New System.Windows.Forms.Button()
        Me.Agregarbtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FacturaDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.timerfh1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CopExpressDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FacturaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CopExpressDataSet1
        '
        Me.CopExpressDataSet1.DataSetName = "CopExpressDataSet"
        Me.CopExpressDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource1
        '
        Me.FacturaBindingSource1.DataMember = "Factura"
        Me.FacturaBindingSource1.DataSource = Me.CopExpressDataSet1
        '
        'FacturaTableAdapter1
        '
        Me.FacturaTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.FacturaTableAdapter = Me.FacturaTableAdapter1
        Me.TableAdapterManager1.ProductosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.aceptarbtn)
        Me.Panel1.Controls.Add(Me.txttotal1)
        Me.Panel1.Controls.Add(Me.lbltotal1)
        Me.Panel1.Controls.Add(Me.confirmarbtn)
        Me.Panel1.Controls.Add(Me.lblcantidad1)
        Me.Panel1.Controls.Add(Me.lblprecio1)
        Me.Panel1.Controls.Add(Me.lbldescripcion1)
        Me.Panel1.Controls.Add(Me.lblcodigo1)
        Me.Panel1.Controls.Add(Me.lblhora1)
        Me.Panel1.Controls.Add(Me.lblfecha1)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtprecio1)
        Me.Panel1.Controls.Add(Me.txtcantidad1)
        Me.Panel1.Controls.Add(Me.txtdescripcion1)
        Me.Panel1.Controls.Add(Me.txtcodigo1)
        Me.Panel1.Controls.Add(Me.Facturarbtn)
        Me.Panel1.Controls.Add(Me.Eliminarbtn)
        Me.Panel1.Controls.Add(Me.Agregarbtn)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.FacturaDataGridView1)
        Me.Panel1.Controls.Add(Me.ShapeContainer3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 487)
        Me.Panel1.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(235, 465)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Ingrese Cantidad"
        '
        'aceptarbtn
        '
        Me.aceptarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aceptarbtn.BackColor = System.Drawing.Color.Transparent
        Me.aceptarbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aceptarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.aceptarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.aceptarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aceptarbtn.ForeColor = System.Drawing.Color.Black
        Me.aceptarbtn.Location = New System.Drawing.Point(459, 419)
        Me.aceptarbtn.Name = "aceptarbtn"
        Me.aceptarbtn.Size = New System.Drawing.Size(112, 30)
        Me.aceptarbtn.TabIndex = 32
        Me.aceptarbtn.Text = "Aceptar"
        Me.aceptarbtn.UseVisualStyleBackColor = False
        '
        'txttotal1
        '
        Me.txttotal1.Location = New System.Drawing.Point(361, 437)
        Me.txttotal1.Name = "txttotal1"
        Me.txttotal1.Size = New System.Drawing.Size(76, 20)
        Me.txttotal1.TabIndex = 31
        '
        'lbltotal1
        '
        Me.lbltotal1.AutoSize = True
        Me.lbltotal1.Location = New System.Drawing.Point(329, 441)
        Me.lbltotal1.Name = "lbltotal1"
        Me.lbltotal1.Size = New System.Drawing.Size(37, 13)
        Me.lbltotal1.TabIndex = 30
        Me.lbltotal1.Text = "Total :"
        '
        'confirmarbtn
        '
        Me.confirmarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.confirmarbtn.BackColor = System.Drawing.Color.Transparent
        Me.confirmarbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.confirmarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.confirmarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmarbtn.ForeColor = System.Drawing.Color.Black
        Me.confirmarbtn.Location = New System.Drawing.Point(459, 419)
        Me.confirmarbtn.Name = "confirmarbtn"
        Me.confirmarbtn.Size = New System.Drawing.Size(112, 30)
        Me.confirmarbtn.TabIndex = 29
        Me.confirmarbtn.Text = "Confirmar"
        Me.confirmarbtn.UseVisualStyleBackColor = False
        '
        'lblcantidad1
        '
        Me.lblcantidad1.AutoSize = True
        Me.lblcantidad1.Location = New System.Drawing.Point(168, 441)
        Me.lblcantidad1.Name = "lblcantidad1"
        Me.lblcantidad1.Size = New System.Drawing.Size(55, 13)
        Me.lblcantidad1.TabIndex = 28
        Me.lblcantidad1.Text = "Cantidad :"
        '
        'lblprecio1
        '
        Me.lblprecio1.AutoSize = True
        Me.lblprecio1.Location = New System.Drawing.Point(22, 436)
        Me.lblprecio1.Name = "lblprecio1"
        Me.lblprecio1.Size = New System.Drawing.Size(43, 13)
        Me.lblprecio1.TabIndex = 27
        Me.lblprecio1.Text = "Precio :"
        '
        'lbldescripcion1
        '
        Me.lbldescripcion1.AutoSize = True
        Me.lbldescripcion1.Location = New System.Drawing.Point(168, 404)
        Me.lbldescripcion1.Name = "lbldescripcion1"
        Me.lbldescripcion1.Size = New System.Drawing.Size(69, 13)
        Me.lbldescripcion1.TabIndex = 26
        Me.lbldescripcion1.Text = "Descripcion :"
        '
        'lblcodigo1
        '
        Me.lblcodigo1.AutoSize = True
        Me.lblcodigo1.Location = New System.Drawing.Point(22, 404)
        Me.lblcodigo1.Name = "lblcodigo1"
        Me.lblcodigo1.Size = New System.Drawing.Size(46, 13)
        Me.lblcodigo1.TabIndex = 25
        Me.lblcodigo1.Text = "Codigo :"
        '
        'lblhora1
        '
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(549, 112)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(34, 13)
        Me.lblhora1.TabIndex = 24
        Me.lblhora1.Text = "00:00"
        '
        'lblfecha1
        '
        Me.lblfecha1.AutoSize = True
        Me.lblfecha1.Location = New System.Drawing.Point(428, 112)
        Me.lblfecha1.Name = "lblfecha1"
        Me.lblfecha1.Size = New System.Drawing.Size(73, 13)
        Me.lblfecha1.TabIndex = 23
        Me.lblfecha1.Text = "00 - 00 - 0000"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(507, 112)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(36, 13)
        Me.Label.TabIndex = 22
        Me.Label.Text = "Hora :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(380, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Fecha :"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(110, 114)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 13)
        Me.TextBox2.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Cliente :"
        '
        'txtprecio1
        '
        Me.txtprecio1.Location = New System.Drawing.Point(71, 434)
        Me.txtprecio1.Name = "txtprecio1"
        Me.txtprecio1.Size = New System.Drawing.Size(77, 20)
        Me.txtprecio1.TabIndex = 18
        '
        'txtcantidad1
        '
        Me.txtcantidad1.Location = New System.Drawing.Point(238, 438)
        Me.txtcantidad1.Name = "txtcantidad1"
        Me.txtcantidad1.Size = New System.Drawing.Size(77, 20)
        Me.txtcantidad1.TabIndex = 17
        '
        'txtdescripcion1
        '
        Me.txtdescripcion1.Location = New System.Drawing.Point(238, 400)
        Me.txtdescripcion1.Name = "txtdescripcion1"
        Me.txtdescripcion1.Size = New System.Drawing.Size(199, 20)
        Me.txtdescripcion1.TabIndex = 16
        '
        'txtcodigo1
        '
        Me.txtcodigo1.Location = New System.Drawing.Point(73, 400)
        Me.txtcodigo1.Name = "txtcodigo1"
        Me.txtcodigo1.Size = New System.Drawing.Size(77, 20)
        Me.txtcodigo1.TabIndex = 15
        '
        'Facturarbtn
        '
        Me.Facturarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Facturarbtn.BackColor = System.Drawing.Color.Maroon
        Me.Facturarbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Facturarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Facturarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Facturarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Facturarbtn.ForeColor = System.Drawing.Color.White
        Me.Facturarbtn.Location = New System.Drawing.Point(693, 266)
        Me.Facturarbtn.Name = "Facturarbtn"
        Me.Facturarbtn.Size = New System.Drawing.Size(100, 30)
        Me.Facturarbtn.TabIndex = 14
        Me.Facturarbtn.Text = "Facturar"
        Me.Facturarbtn.UseVisualStyleBackColor = False
        '
        'Eliminarbtn
        '
        Me.Eliminarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Eliminarbtn.BackColor = System.Drawing.Color.Transparent
        Me.Eliminarbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Eliminarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminarbtn.ForeColor = System.Drawing.Color.Black
        Me.Eliminarbtn.Location = New System.Drawing.Point(693, 230)
        Me.Eliminarbtn.Name = "Eliminarbtn"
        Me.Eliminarbtn.Size = New System.Drawing.Size(100, 30)
        Me.Eliminarbtn.TabIndex = 13
        Me.Eliminarbtn.Text = "Eliminar"
        Me.Eliminarbtn.UseVisualStyleBackColor = False
        '
        'Agregarbtn
        '
        Me.Agregarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Agregarbtn.BackColor = System.Drawing.Color.Transparent
        Me.Agregarbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agregarbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Agregarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Agregarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Agregarbtn.ForeColor = System.Drawing.Color.Black
        Me.Agregarbtn.Location = New System.Drawing.Point(693, 194)
        Me.Agregarbtn.Name = "Agregarbtn"
        Me.Agregarbtn.Size = New System.Drawing.Size(100, 30)
        Me.Agregarbtn.TabIndex = 12
        Me.Agregarbtn.Text = "Agregar"
        Me.Agregarbtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(286, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "FACTURA"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Santo Domingo, Distrito Nacional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Calle 27 de ferbrero. Av Abraham Lincoln" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(265, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Copy Express"
        '
        'FacturaDataGridView1
        '
        Me.FacturaDataGridView1.AllowUserToAddRows = False
        Me.FacturaDataGridView1.AutoGenerateColumns = False
        Me.FacturaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.FacturaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FacturaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.FacturaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FacturaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.FacturaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.FacturaDataGridView1.DataSource = Me.FacturaBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FacturaDataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.FacturaDataGridView1.GridColor = System.Drawing.Color.White
        Me.FacturaDataGridView1.Location = New System.Drawing.Point(12, 174)
        Me.FacturaDataGridView1.Name = "FacturaDataGridView1"
        Me.FacturaDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FacturaDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.FacturaDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.FacturaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FacturaDataGridView1.Size = New System.Drawing.Size(608, 220)
        Me.FacturaDataGridView1.TabIndex = 2
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(899, 487)
        Me.ShapeContainer3.TabIndex = 33
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 108
        Me.LineShape4.X2 = 278
        Me.LineShape4.Y1 = 129
        Me.LineShape4.Y2 = 129
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 3
        Me.LineShape3.X2 = 677
        Me.LineShape3.Y1 = 147
        Me.LineShape3.Y2 = 147
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'timerfh1
        '
        Me.timerfh1.Enabled = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 200
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Precio_RD$"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Precio_LPS"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'Factura
        '
        Me.ClientSize = New System.Drawing.Size(899, 487)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Factura"
        Me.Opacity = 0.9R
        CType(Me.CopExpressDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FacturaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CopExpressDataSet As Copy_Express.CopExpressDataSet
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter As Copy_Express.CopExpressDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager As Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents timerfh As System.Windows.Forms.Timer
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FacturaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents lblprecio As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnfacturar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarp As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents CopExpressDataSet1 As Copy_Express.CopExpressDataSet
    Friend WithEvents FacturaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter1 As Copy_Express.CopExpressDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents TableAdapterManager1 As Copy_Express.CopExpressDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FacturaDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Facturarbtn As System.Windows.Forms.Button
    Friend WithEvents Eliminarbtn As System.Windows.Forms.Button
    Friend WithEvents Agregarbtn As System.Windows.Forms.Button
    Friend WithEvents txtprecio1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion1 As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents lblfecha1 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblcantidad1 As System.Windows.Forms.Label
    Friend WithEvents lblprecio1 As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion1 As System.Windows.Forms.Label
    Friend WithEvents lblcodigo1 As System.Windows.Forms.Label
    Friend WithEvents confirmarbtn As System.Windows.Forms.Button
    Friend WithEvents txttotal1 As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal1 As System.Windows.Forms.Label
    Friend WithEvents aceptarbtn As System.Windows.Forms.Button
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents timerfh1 As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
