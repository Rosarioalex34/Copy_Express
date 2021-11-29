Imports System.Data.OleDb
Public Class General
    Dim conexion As New OleDbConnection
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CopExpressDataSet)

    End Sub

    Private Sub General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CopExpressDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\CARRASCO\Desktop\Copy Express\Copy Express\My Project\CopExpress.accdb"
            conexion.Open()
            MsgBox("Conectado a la BS", vbInformation, "Correcto")
        Catch ex As Exception
            MsgBox("Error al conectarse a la BS", vbCritical, "Sin conexión")
        End Try

    End Sub


    Private Sub btnfacturar_Click(sender As Object, e As EventArgs) Handles btnfacturar.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class