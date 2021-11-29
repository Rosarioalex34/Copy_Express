Imports System.Runtime.InteropServices

Public Class Principal

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles iconcerrar.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles iconrestaurar.Click
        WindowState = FormWindowState.Normal
        iconrestaurar.Visible = False
        iconmaximizar.Visible = True
    End Sub

    Private Sub iconmaximizar_Click(sender As Object, e As EventArgs) Handles iconmaximizar.Click
        WindowState = FormWindowState.Maximized
        iconrestaurar.Visible = True
        iconmaximizar.Visible = False
    End Sub

    Private Sub iconminimizar_Click(sender As Object, e As EventArgs) Handles iconminimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If (MenuVertical.Width = 234) Then
            MenuVertical.Visible = False
            MenuVertical.Width = 48
            PanelTransition.ShowSync(MenuVertical)
            LogoTransition.Hide(Logo)

        Else
            LogoTransition.ShowSync(Logo)
            MenuVertical.Visible = False
            MenuVertical.Width = 234
            PanelTransition.ShowSync(MenuVertical)

        End If

    End Sub

    Private Sub timerfh_Tick(sender As Object, e As EventArgs) Handles timerfh.Tick
        lblHora.Text = TimeOfDay.TimeOfDay.ToString
        lblFecha.Text = DateString
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim Products As New Form
        Productos.TopLevel = False
        Productos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Productos.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Productos)
        Me.PanelContenedor.Tag = Productos
        Productos.Show()


    End Sub

    Private Sub AbrirFormEnPanel2(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim Home As New Form
        Inicio.TopLevel = False
        Inicio.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Inicio.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Inicio)
        Me.PanelContenedor.Tag = Inicio
        Inicio.Show()
    End Sub

    Private Sub AbrirFormEnPanel3(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim ven As New Form
        Factura.TopLevel = False
        Factura.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Factura.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Factura)
        Me.PanelContenedor.Tag = Inicio
        Factura.Show()
    End Sub

    Private Sub AbrirFormEnPanel4(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim ven As New Form
        General.TopLevel = False
        General.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        General.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(General)
        Me.PanelContenedor.Tag = Inicio
        General.Show()
    End Sub


    Private Sub AbrirFormEnPanel5(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim ven As New Form
        Individual.TopLevel = False
        Individual.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Individual.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Individual)
        Me.PanelContenedor.Tag = Inicio
        Individual.Show()
    End Sub

    Private Sub AbrirFormEnPanel6(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim ven As New Form
        Invetario.TopLevel = False
        Invetario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Invetario.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Invetario)
        Me.PanelContenedor.Tag = Inicio
        Invetario.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormEnPanel2(New Inicio)
    End Sub

    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormEnPanel3(New Factura)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormEnPanel4(New General)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormEnPanel5(New Individual)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AbrirFormEnPanel6(New Invetario)
    End Sub

    
    
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class