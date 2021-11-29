Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class Datos

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Productos.Show()
        Me.Hide()
    End Sub

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnagregar.Visible = False
        txttotal.Visible = False

    End Sub

    Private Sub Datos_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub iconcerrar_Click(sender As Object, e As EventArgs) Handles iconcerrar.Click
        Me.Hide()
    End Sub


    Private Sub btnconfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click

    End Sub
End Class