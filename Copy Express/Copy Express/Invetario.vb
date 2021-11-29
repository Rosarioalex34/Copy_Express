Imports System.Data
Imports System.Data.OleDb

Public Class Invetario

    Dim conexion As New OleDbConnection
    Dim comand As New OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

  

    Private Sub Invetario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CopExpressDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)


        CodigoTextbox.Visible = False
        DescripcionTextbox.Visible = False
        PrecioTextbox.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

        guardarbtn.Visible = False
        Button2.Visible = False
        CodTextBox.Visible = True
        Label4.Visible = False



        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\CARRASCO\Desktop\Copy Express\Copy Express\My Project\CopExpress.accdb"
            conexion.Open()
            MsgBox("Conectado a la BS", vbInformation, "Correcto")
        Catch ex As Exception
            MsgBox("Error al conectarse a la BS", vbCritical, "Sin conexión")
        End Try



        CodigoTextbox.Text = ""
        DescripcionTextbox.Text = ""
        PrecioTextbox.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        guardarbtn.Visible = True
        CodTextBox.Visible = False
        Label4.Visible = False

        CodigoTextbox.Visible = True
        DescripcionTextbox.Visible = True
        PrecioTextbox.Visible = True
        btnbuscar.Visible = False
        btnEliminar.Visible = False

        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Button2.Visible = True


    End Sub

    

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If ProductosDataGridView.SelectedRows.Count > 0 Then
            CodigoTextbox.Text = ProductosDataGridView.CurrentRow.Cells(0).Value
            DescripcionTextbox.Text = ProductosDataGridView.CurrentRow.Cells(1).Value
            PrecioTextbox.Text = ProductosDataGridView.CurrentRow.Cells(2).Value



            If MsgBox("Seguro Que Desea Eliminar Esta Fila", vbCritical + vbYesNo, "ELIMINAR") = vbYes Then
                Me.ProductosTableAdapter.ELIMINAR(CodigoTextbox.Text)
                Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)
                MsgBox("Se Elimino Correctamente", vbInformation, "ELIMINAR")
            Else
                MsgBox("No Se Pudo Eliminar", vbInformation, "ELIMINAR")

                CodigoTextbox.Text = ""
                DescripcionTextbox.Text = ""
                PrecioTextbox.Text = ""
            End If
        End If
        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
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
            ProductosDataGridView.DataSource = registro
            ProductosDataGridView.DataMember = "Productos"
        End If
        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)
        CodigoTextbox.Text = ""
        btnEliminar.Visible = True

    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs)
        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)

    End Sub

    Private Sub guardarbtn_Click(sender As Object, e As EventArgs) Handles guardarbtn.Click


        Try
           

            comand = New OleDbCommand("INSERT INTO Productos (Codigo, Descripcion, Precio_LPS)" & Chr(13) &
                                         "VALUES (Codigotextbox, Descripciontextbox, Preciotextbox)", conexion)
            comand.Parameters.AddWithValue("@Codigo", CodigoTextbox.Text)
            comand.Parameters.AddWithValue("@Descripcion", DescripcionTextbox.Text)
            comand.Parameters.AddWithValue("@Precio_LPS", PrecioTextbox.Text)
            comand.ExecuteNonQuery()
            MsgBox("Guardado", vbInformation, "Correcto")

            Me.ProductosTableAdapter.INSERTAR(CodigoTextbox.Text, DescripcionTextbox.Text, PrecioTextbox.Text)
            Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)

        Catch ex As Exception
            MsgBox("Error de Guardado", vbCritical, "Atención!")
        End Try


        guardarbtn.Visible = False

        Button2.Visible = False
        Button3.Visible = True
        CodigoTextbox.Visible = False
        DescripcionTextbox.Visible = False
        PrecioTextbox.Visible = False
        btnbuscar.Visible = True
        btnEliminar.Visible = True
        CodTextBox.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False


        CodigoTextbox.Text = ""
        DescripcionTextbox.Text = ""
        PrecioTextbox.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button3.Visible = True
        guardarbtn.Visible = False
        CodTextBox.Visible = True
        Label4.Visible = False
        btnbuscar.Visible = True

        CodigoTextbox.Visible = False
        DescripcionTextbox.Visible = False
        PrecioTextbox.Visible = False
        btnEliminar.Visible = True

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        btnbuscar.Visible = True

        Label4.Visible = True

        CodigoTextbox.Visible = False
        DescripcionTextbox.Visible = False
        PrecioTextbox.Visible = False
        btnEliminar.Visible = True

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        btnEliminar.Visible = False
        Button2.Visible = True



    End Sub
End Class