Public Class Inicio

    Private Sub timerfh_Tick(sender As Object, e As EventArgs) Handles timerfh.Tick
        lblHora.Text = TimeOfDay.TimeOfDay.ToString
        lblFecha.Text = DateString
    End Sub
End Class