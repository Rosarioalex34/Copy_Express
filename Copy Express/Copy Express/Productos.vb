Imports System.Data
Imports System.Data.OleDb

Public Class Productos

    Dim conexion As New OleDbConnection
    Dim comand As New OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet


    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CopExpressDataSet)

    End Sub



    Private Sub ProductosBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.CopExpressDataSet1)

    End Sub

    Private Sub Productos_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CopExpressDataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter1.Fill(Me.CopExpressDataSet1.Productos)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\CARRASCO\Desktop\Copy Express\Copy Express\My Project\CopExpress.accdb"
            conexion.Open()
            MsgBox("Conectado a la BS", vbInformation, "Correcto")
        Catch ex As Exception
            MsgBox("Error al conectarse a la BS", vbCritical, "Sin conexión")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hijo As Factura = New Factura()


        AddOwnedForm(hijo)
        hijo.FormBorderStyle = FormBorderStyle.None
        hijo.TopLevel = False
        hijo.Dock = DockStyle.Fill
        Me.Controls.Add(hijo)
        Me.Tag = hijo
        hijo.BringToFront()
        hijo.Show()



        If ProductosDataGridView1.SelectedRows.Count > 0 Then
            hijo.txtcodigo1.Text = ProductosDataGridView1.CurrentRow.Cells(0).Value
            hijo.txtdescripcion1.Text = ProductosDataGridView1.CurrentRow.Cells(1).Value
            hijo.txtprecio1.Text = ProductosDataGridView1.CurrentRow.Cells(2).Value

        Else
            MessageBox.Show("seleccione una fila por favor")
        End If
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta As String
        Dim lista As Byte

        If CodTextBox.Text <> "" Then
            consulta = "SELECT * FROM Productos WHERE Codigo =" & CodTextBox.Text & ""
            adaptador = New OleDbDataAdapter(consulta, conexion)

            registro = New DataSet
            adaptador.Fill(registro, "Productos")
            lista = registro.Tables("Productos").Rows.Count

        Else
            MsgBox("Debe Ingresar Codigo", vbExclamation, "Campo Vacio")

        End If
        If lista <> 0 Then
            ProductosDataGridView1.DataSource = registro
            ProductosDataGridView1.DataMember = "Productos"
        End If

        CodTextBox.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Button2.Visible = True
    End Sub


    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Factura.Show()
        Me.Close()
    End Sub
End Class