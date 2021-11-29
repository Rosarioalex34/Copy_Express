<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.iconmaximizar = New System.Windows.Forms.PictureBox()
        Me.iconminimizar = New System.Windows.Forms.PictureBox()
        Me.iconrestaurar = New System.Windows.Forms.PictureBox()
        Me.iconcerrar = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.LogoTransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.timerfh = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.iconmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PanelContenedor)
        Me.Panel1.Controls.Add(Me.MenuVertical)
        Me.Panel1.Controls.Add(Me.BarraTitulo)
        Me.LogoTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 657)
        Me.Panel1.TabIndex = 0
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.Panel2)
        Me.LogoTransition.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.PanelContenedor, BunifuAnimatorNS.DecorationType.None)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(238, 43)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(995, 614)
        Me.PanelContenedor.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblFecha)
        Me.Panel2.Controls.Add(Me.lblHora)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.LogoTransition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 534)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 80)
        Me.Panel2.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.lblFecha, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.lblFecha, BunifuAnimatorNS.DecorationType.None)
        Me.lblFecha.Font = New System.Drawing.Font("DFMincho-W5", 12.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(852, 56)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(56, 18)
        Me.lblFecha.TabIndex = 11
        Me.lblFecha.Text = "Label1"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.PanelTransition.SetDecoration(Me.lblHora, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.lblHora, BunifuAnimatorNS.DecorationType.None)
        Me.lblHora.Font = New System.Drawing.Font("DFMincho-W5", 35.25!)
        Me.lblHora.ForeColor = System.Drawing.Color.LightGray
        Me.lblHora.Location = New System.Drawing.Point(796, 2)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(163, 53)
        Me.lblHora.TabIndex = 10
        Me.lblHora.Text = "Label1"
        '
        'PictureBox7
        '
        Me.PanelTransition.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox7.Image = Global.Copy_Express.My.Resources.Resources.icono_cliente
        Me.PictureBox7.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(105, 85)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Button6)
        Me.MenuVertical.Controls.Add(Me.Button2)
        Me.MenuVertical.Controls.Add(Me.PictureBox5)
        Me.MenuVertical.Controls.Add(Me.Logo)
        Me.MenuVertical.Controls.Add(Me.PictureBox6)
        Me.MenuVertical.Controls.Add(Me.PictureBox4)
        Me.MenuVertical.Controls.Add(Me.PictureBox3)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.PictureBox1)
        Me.MenuVertical.Controls.Add(Me.Button4)
        Me.MenuVertical.Controls.Add(Me.Button3)
        Me.MenuVertical.Controls.Add(Me.Button1)
        Me.MenuVertical.Controls.Add(Me.ShapeContainer1)
        Me.LogoTransition.SetDecoration(Me.MenuVertical, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.MenuVertical, BunifuAnimatorNS.DecorationType.None)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 43)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(238, 614)
        Me.MenuVertical.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.Button6, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.Button6, BunifuAnimatorNS.DecorationType.None)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("DFMincho-W5", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Silver
        Me.Button6.Image = Global.Copy_Express.My.Resources.Resources._3d_printing_software
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(8, 258)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(227, 40)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "       INVENTARIO"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("DFMincho-W5", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Silver
        Me.Button2.Image = Global.Copy_Express.My.Resources.Resources.puzzle_piece_silhouette
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(10, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(227, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "       CONSULTA INDIVIDUAL"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox5.Location = New System.Drawing.Point(-4, 430)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 40)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'Logo
        '
        Me.PanelTransition.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.Logo.Image = Global.Copy_Express.My.Resources.Resources.icono_cliente
        Me.Logo.Location = New System.Drawing.Point(3, 11)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(54, 45)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 8
        Me.Logo.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox6.Image = Global.Copy_Express.My.Resources.Resources.menu2
        Me.PictureBox6.Location = New System.Drawing.Point(203, 21)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Location = New System.Drawing.Point(-4, 89)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(8, 40)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Location = New System.Drawing.Point(-12, 169)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 40)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Location = New System.Drawing.Point(-6, 258)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 40)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 344)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 40)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("DFMincho-W5", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Silver
        Me.Button4.Image = Global.Copy_Express.My.Resources.Resources.stationery
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(227, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "       CONSULTA GENERAL"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("DFMincho-W5", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Silver
        Me.Button3.Image = Global.Copy_Express.My.Resources.Resources.shopping_cart
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(12, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(227, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "       VENTA"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("DFMincho-W5", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Silver
        Me.Button1.Image = Global.Copy_Express.My.Resources.Resources.home_icon_silhouette
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(10, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "       INICIO"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.LogoTransition.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(238, 614)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Green
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 237
        Me.LineShape1.Y1 = 535
        Me.LineShape1.Y2 = 535
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.iconmaximizar)
        Me.BarraTitulo.Controls.Add(Me.iconminimizar)
        Me.BarraTitulo.Controls.Add(Me.iconrestaurar)
        Me.BarraTitulo.Controls.Add(Me.iconcerrar)
        Me.LogoTransition.SetDecoration(Me.BarraTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTransition.SetDecoration(Me.BarraTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1233, 43)
        Me.BarraTitulo.TabIndex = 1
        '
        'iconmaximizar
        '
        Me.iconmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.iconmaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.iconmaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.iconmaximizar.Image = Global.Copy_Express.My.Resources.Resources.maximize
        Me.iconmaximizar.Location = New System.Drawing.Point(1174, 12)
        Me.iconmaximizar.Name = "iconmaximizar"
        Me.iconmaximizar.Size = New System.Drawing.Size(25, 25)
        Me.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconmaximizar.TabIndex = 4
        Me.iconmaximizar.TabStop = False
        '
        'iconminimizar
        '
        Me.iconminimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.iconminimizar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.iconminimizar, BunifuAnimatorNS.DecorationType.None)
        Me.iconminimizar.Image = Global.Copy_Express.My.Resources.Resources.Minimize
        Me.iconminimizar.Location = New System.Drawing.Point(1143, 12)
        Me.iconminimizar.Name = "iconminimizar"
        Me.iconminimizar.Size = New System.Drawing.Size(25, 25)
        Me.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconminimizar.TabIndex = 3
        Me.iconminimizar.TabStop = False
        '
        'iconrestaurar
        '
        Me.iconrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.iconrestaurar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.iconrestaurar, BunifuAnimatorNS.DecorationType.None)
        Me.iconrestaurar.Image = Global.Copy_Express.My.Resources.Resources.Normal
        Me.iconrestaurar.Location = New System.Drawing.Point(1174, 12)
        Me.iconrestaurar.Name = "iconrestaurar"
        Me.iconrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconrestaurar.TabIndex = 5
        Me.iconrestaurar.TabStop = False
        '
        'iconcerrar
        '
        Me.iconcerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PanelTransition.SetDecoration(Me.iconcerrar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me.iconcerrar, BunifuAnimatorNS.DecorationType.None)
        Me.iconcerrar.Image = Global.Copy_Express.My.Resources.Resources.Close
        Me.iconcerrar.Location = New System.Drawing.Point(1205, 12)
        Me.iconcerrar.Name = "iconcerrar"
        Me.iconcerrar.Size = New System.Drawing.Size(25, 25)
        Me.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconcerrar.TabIndex = 2
        Me.iconcerrar.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelTransition
        '
        Me.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelTransition.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0.0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0.0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0.0!
        Animation3.RotateLimit = 0.0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0.0!
        Animation3.TransparencyCoeff = 0.0!
        Me.PanelTransition.DefaultAnimation = Animation3
        '
        'LogoTransition
        '
        Me.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.LogoTransition.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0.0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0.0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(30)
        Animation4.RotateCoeff = 0.5!
        Animation4.RotateLimit = 0.2!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0.0!
        Animation4.TransparencyCoeff = 0.0!
        Me.LogoTransition.DefaultAnimation = Animation4
        '
        'timerfh
        '
        Me.timerfh.Enabled = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 657)
        Me.Controls.Add(Me.Panel1)
        Me.PanelTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.LogoTransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.iconmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents BarraTitulo As System.Windows.Forms.Panel
    Friend WithEvents MenuVertical As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents iconcerrar As System.Windows.Forms.PictureBox
    Friend WithEvents iconmaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents iconminimizar As System.Windows.Forms.PictureBox
    Friend WithEvents iconrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents LogoTransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents timerfh As System.Windows.Forms.Timer
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
