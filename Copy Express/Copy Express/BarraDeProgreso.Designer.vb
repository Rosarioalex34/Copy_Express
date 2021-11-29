<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarraDeProgreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarraDeProgreso))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Progresbar2 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 26)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Copy_Express.My.Resources.Resources.loading
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(237, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CARGANDO..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Progresbar2
        '
        Me.Progresbar2.animated = False
        Me.Progresbar2.animationIterval = 5
        Me.Progresbar2.animationSpeed = 300
        Me.Progresbar2.BackColor = System.Drawing.Color.Transparent
        Me.Progresbar2.BackgroundImage = CType(resources.GetObject("Progresbar2.BackgroundImage"), System.Drawing.Image)
        Me.Progresbar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Progresbar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Progresbar2.LabelVisible = True
        Me.Progresbar2.LineProgressThickness = 8
        Me.Progresbar2.LineThickness = 5
        Me.Progresbar2.Location = New System.Drawing.Point(229, 116)
        Me.Progresbar2.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Progresbar2.MaxValue = 100
        Me.Progresbar2.Name = "Progresbar2"
        Me.Progresbar2.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.Progresbar2.ProgressColor = System.Drawing.Color.Green
        Me.Progresbar2.Size = New System.Drawing.Size(201, 201)
        Me.Progresbar2.TabIndex = 4
        Me.Progresbar2.Value = 100
        '
        'BarraDeProgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(656, 369)
        Me.Controls.Add(Me.Progresbar2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BarraDeProgreso"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BarraDeProgreso"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Progresbar2 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
