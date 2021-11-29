Public Class Individual

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CopExpressDataSet)

    End Sub

    Private Sub Individual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CopExpressDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.CopExpressDataSet.Productos)

    End Sub


    Private Sub btnprimero_Click(sender As Object, e As EventArgs) Handles btnprimero.Click
        Me.ProductosBindingSource.MoveFirst()
    End Sub

    Private Sub btnanterior_Click(sender As Object, e As EventArgs) Handles btnanterior.Click
        Me.ProductosBindingSource.MovePrevious()
    End Sub

    Private Sub btnsiguiente_Click(sender As Object, e As EventArgs) Handles btnsiguiente.Click
        Me.ProductosBindingSource.MoveNext()
    End Sub

    Private Sub btnultimo_Click(sender As Object, e As EventArgs) Handles btnultimo.Click
        Me.ProductosBindingSource.MoveLast()
    End Sub

    Private Sub btnfacturar_Click(sender As Object, e As EventArgs) Handles btnfacturar.Click
       



        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class