Imports System.Runtime.InteropServices

Public Class ControlAcceso
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles usuario.Enter
        If usuario.Text = "USUARIO" Then
            usuario.Text = ""
            usuario.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub usuario_Leave(sender As Object, e As EventArgs) Handles usuario.Leave
        If usuario.Text = "" Then
            usuario.Text = "USUARIO"
            usuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub contraseña_Enter(sender As Object, e As EventArgs)
        If contraseña.Text = "CONTRASEÑA" Then
            contraseña.Text = ""
            contraseña.ForeColor = Color.LightGray
            contraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub contraseña_Leave(sender As Object, e As EventArgs)
        If contraseña.Text = "" Then
            contraseña.Text = "CONTRASEÑA"
            contraseña.ForeColor = Color.DimGray
            contraseña.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub contraseña_Enter_1(sender As Object, e As EventArgs) Handles contraseña.Enter
        If contraseña.Text = "CONTRASEÑA" Then
            contraseña.Text = ""
            contraseña.ForeColor = Color.LightGray
            contraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub contraseña_Leave_1(sender As Object, e As EventArgs) Handles contraseña.Leave
        If contraseña.Text = "" Then
            contraseña.Text = "CONTRASEÑA"
            contraseña.ForeColor = Color.DimGray
            contraseña.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub ControlAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ControlAcceso_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ACCEDER_Click(sender As Object, e As EventArgs) Handles ACCEDER.Click
        If usuario.Text = "Bryan" And contraseña.Text = "bryan123" Then
            BarraDeProgreso.Show()
            Me.Hide()

        Else
            If usuario.Text = "Oscar" And contraseña.Text = "oscar234" Then
                BarraDeProgreso.Show()
                Me.Hide()

            Else
                If usuario.Text = "Juan" And contraseña.Text = "juan345" Then
                    BarraDeProgreso.Show()
                    Me.Hide()
                Else
                    lblloginerror.Text = "Usuario O Contraseña Invalidas. Intente De Nuevo"
                    lblloginerror.Visible = True
                    usuario.Text = "USUARIO"
                    contraseña.Text = "CONTRASEÑA"
                    contraseña.UseSystemPasswordChar = False
                End If
            End If
        End If
    End Sub

   
End Class