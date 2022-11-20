Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class Form1
    Public Sub des()
        If (btnMenu.Enabled = True) Then
            btnMenu.Enabled = False
        End If
        If (btnMenu.Enabled = False) Then
            btnMenu.Enabled = True
        End If

    End Sub
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn("(local)", "hola")
        sec = False
        user = "admin"
        pass = "admin"
        AbrirFormEnPanel(Form2)
        btnMenu.Enabled = False
        Me.WindowState = FormWindowState.Maximized

    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public da As SqlDataAdapter
    Public ds As New DataSet
    Public cmd As New SqlCommandBuilder
    Public con As SqlConnection = New SqlConnection("Data Source=(local);Initial Catalog=hola;Integrated Security=True")


    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub



    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Public Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        If (sec = True) Then



            AbrirFormEnPanel(New FormProductos)
        End If
    End Sub

    Public Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        If (sec = True) Then

            AbrirFormEnPanel(New calc)
        End If
        'conn("DESKTOP-IPS4V6O", "hola")
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (sec = True) Then

            AbrirFormEnPanel(New empl)
        End If
        conn("(local)", "hola")

    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub PanelBarraTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelBarraTitulo.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (sec = True) Then

            AbrirFormEnPanel(New demande_conge)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (sec = True) Then

            AbrirFormEnPanel(New add)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (sec = True) Then

            AbrirFormEnPanel(New configuration)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ajouterform.Show()

    End Sub
End Class
