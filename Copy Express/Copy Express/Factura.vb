Imports System.Data
Imports System.Data.OleDb

Public Class Factura

    Dim conexion As New OleDbConnection
    Dim comand As New OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CopExpressDataSet)

    End Sub

    Public Sub Factura_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'CopExpressDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.CopExpressDataSet.Factura)





    End Sub

    Private Sub AbrirFormEnPanel1(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim ven As New Form
        Productos.TopLevel = False
        Productos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Productos.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Productos)
        Me.PanelContenedor.Tag = Inicio
        Productos.Show()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        FacturaDataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub


    Private Sub FacturaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        If FacturaDataGridView1.SelectedRows.Count > 0 Then
            txtcodigo.Text = FacturaDataGridView1.CurrentRow.Cells(0).Value
            txtdescripcion.Text = FacturaDataGridView1.CurrentRow.Cells(1).Value
            txtprecio.Text = FacturaDataGridView1.CurrentRow.Cells(2).Value
            txtcantidad.Text = FacturaDataGridView1.CurrentRow.Cells(3).Value
            txttotal.Text = FacturaDataGridView1.CurrentRow.Cells(4).Value
        End If
    End Sub


    Private Sub iconcerrar_Click_1(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Factura_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CopExpressDataSet1.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter1.Fill(Me.CopExpressDataSet1.Factura)

        aceptarbtn.Visible = False
        Label14.Visible = False


        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\CARRASCO\Desktop\Copy Express\Copy Express\My Project\CopExpress.accdb"
            conexion.Open()
            MsgBox("Conectado a la BS", vbInformation, "Correcto")
        Catch ex As Exception
            MsgBox("Error al conectarse a la BS", vbCritical, "Sin conexión")
        End Try




    End Sub

    Private Sub FacturaBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FacturaBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.CopExpressDataSet1)

    End Sub

    Private Sub Agregarbtn_Click(sender As Object, e As EventArgs) Handles Agregarbtn.Click



        Dim hijo As Productos = New Productos()
        AddOwnedForm(hijo)
        hijo.FormBorderStyle = FormBorderStyle.None
        hijo.TopLevel = False
        hijo.Dock = DockStyle.Fill
        Me.Controls.Add(hijo)
        Me.Tag = hijo
        hijo.BringToFront()
        hijo.Show()











    End Sub

    Private Sub Eliminarbtn_Click(sender As Object, e As EventArgs) Handles Eliminarbtn.Click
        If FacturaDataGridView1.SelectedRows.Count > 0 Then
            txtcodigo1.Text = FacturaDataGridView1.CurrentRow.Cells(0).Value
            txtdescripcion1.Text = FacturaDataGridView1.CurrentRow.Cells(1).Value
            txtcantidad1.Text = FacturaDataGridView1.CurrentRow.Cells(2).Value
            txtprecio1.Text = FacturaDataGridView1.CurrentRow.Cells(3).Value


            If MsgBox("Seguro Que Desea Eliminar Este Producto", vbCritical + vbYesNo, "ELIMINAR") = vbYes Then
                Me.FacturaTableAdapter1.ELIMINAR(txtcodigo1.Text)
                Me.FacturaTableAdapter1.Fill(Me.CopExpressDataSet1.Factura)
                MsgBox("Se Elimino Correctamente", vbInformation, "ELIMINAR")
            Else
                MsgBox("No Se Pudo Eliminar", vbInformation, "ELIMINAR")
            End If
        End If

        txtcodigo1.Text = ""
        txtdescripcion1.Text = ""
        txtcantidad1.Text = ""
        txtprecio1.Text = ""
        txttotal1.Text = ""




    End Sub

    Private Sub Facturarbtn_Click(sender As Object, e As EventArgs) Handles Facturarbtn.Click

        lblcodigo1.Visible = False
        lbldescripcion1.Visible = False
        lblprecio1.Visible = False
        lblcantidad1.Visible = False
        lbltotal1.Visible = False


        txtcodigo1.Visible = False
        txtdescripcion1.Visible = False
        txtcantidad1.Visible = False
        txtprecio1.Visible = False
        txttotal1.Visible = False

        aceptarbtn.Visible = False
        confirmarbtn.Visible = False

        PrintForm2.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm2.Print()




    End Sub

    Private Sub confirmarbtn_Click(sender As Object, e As EventArgs) Handles confirmarbtn.Click

        If txtcantidad1.Text = "" Then
            Label14.Visible = True
            aceptarbtn.Visible = False
            confirmarbtn.Visible = True


        Else
            aceptarbtn.Visible = True
            confirmarbtn.Visible = False
            Label14.Visible = False
            txttotal1.Text = Val(txtcantidad1.Text) * Val(txtprecio1.Text)
        End If



    End Sub

    Private Sub aceptarbtn_Click(sender As Object, e As EventArgs) Handles aceptarbtn.Click

        Try


            comand = New OleDbCommand("INSERT INTO Factura (Codigo, Descripcion, Cantidad, Precio_LPS, Total)" & Chr(13) &
                                         "VALUES (txtcodigo1, txtdescripcion1, txtcantidad1, txtprecio1, txttotal1)", conexion)
            comand.Parameters.AddWithValue("@Codigo", txtcodigo1.Text)
            comand.Parameters.AddWithValue("@Descripcion", txtdescripcion1.Text)
            comand.Parameters.AddWithValue("@Cantidad", txtcantidad1.Text)
            comand.Parameters.AddWithValue("@Precio_LPS", txtprecio1.Text)
            comand.Parameters.AddWithValue("@Total", txttotal1.Text)
            comand.ExecuteNonQuery()
            MsgBox("Agregado", vbInformation, "Correcto")

            Me.FacturaTableAdapter1.INSERTAR(txtcodigo1.Text, txtdescripcion1.Text, txtcantidad1.Text, txtprecio1.Text, txttotal1.Text)
            Me.FacturaTableAdapter1.Fill(Me.CopExpressDataSet1.Factura)



        Catch ex As Exception

            MsgBox("Error de Guardado", vbCritical, "Atención!")
        End Try

        txtcodigo1.Text = ""
        txtdescripcion1.Text = ""
        txtcantidad1.Text = ""
        txtprecio1.Text = ""
        txttotal1.Text = ""

        confirmarbtn.Visible = True

    End Sub

    Private Sub timerfh1_Tick(sender As Object, e As EventArgs) Handles timerfh1.Tick
        lblhora1.Text = TimeOfDay.TimeOfDay.ToString
        lblfecha1.Text = DateString
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class