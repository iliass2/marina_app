Public Class Form2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Label1.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (TextBox1.Text = user And TextBox2.Text = pass) Then
            sec = True
            Call Form1.des()
        End If
        Call Form1.btnProductos_Click(Form1.btnProductos, Nothing)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub
End Class