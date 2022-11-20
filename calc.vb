Imports System.Data.SqlClient
Public Class calc
    Private i = 0
    Dim da2, da1 As SqlDataAdapter
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub present_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub abs_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub mis_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False) Then
            MsgBox(" choisir le type de tarif ", MsgBoxStyle.Information, "choisir")
        End If
        Try
            Dim duree As Integer = Integer.Parse(TextBox2.Text)
            If (CheckBox2.Checked = True) Then
                Dim tot As Double
                If (RadioButton1.Checked = True) Then

                    tot = 63.04 * duree
                    Label4.Text = "Totale : " + tot.ToString
                End If
                If (RadioButton2.Checked = True) Then

                    tot = 1260.72 * duree
                    Label4.Text = "Totale : " + tot.ToString
                End If
                If (RadioButton3.Checked = True) Then

                    tot = 8951.11 * duree
                    Label4.Text = "Totale : " + tot.ToString
                End If
            End If
            Dim lon As Double = Double.Parse(TextBox1.Text)
            Select Case lon
                Case 0 To 7
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 88.25 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 1260.72 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 11308.66 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 7 To 8
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 100.86 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 1601.11 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 15128.64 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 8 To 9
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 126.07 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 1991.94 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 18116.55 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 9 To 10
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 151.29 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 2344.94 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 19490.73 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 10 To 11
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 189.11 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 2723.16 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 22995.53 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 11 To 12
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 201.72 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 3113.98 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 25000.08 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 12 To 13
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 239.54 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 3441.77 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 29816.03 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 13 To 14
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 264.75 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 3883.02 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 33245.19 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 14 To 15
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 302.57 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 4437.73 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 37998.1 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 15 To 16
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 340.39 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 4929.42 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 42208.91 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 16 To 17
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 378.22 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 5446.31 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 46369.28 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 17 To 18
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 403.43 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 5887.56 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 43494.84 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 18 To 19
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 441.25 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 6492.71 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 43999.13 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 19 To 20
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 466.47 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 7413.03 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 50592.69 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 20 To 22
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 542.11 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 8497.25 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 57085.4 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 22 To 25
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 630.36 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 10047.94 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 68520.13 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 25 To 27
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 743.82 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 11686.87 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 80813.01 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case 27 To 30
                    Dim tot As Double
                    If (RadioButton1.Checked = True) Then

                        tot = 882.5 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then

                        tot = 13905.74 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then

                        tot = 96331.62 * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                Case Else
                    Dim tot As Double
                    Dim p As Double
                    If (RadioButton1.Checked = True) Then
                        p = lon * 44.13
                        tot = p * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton2.Checked = True) Then
                        p = lon * 617.75
                        tot = p * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
                    If (RadioButton3.Checked = True) Then
                        p = lon * 6429.67
                        tot = p * duree
                        Label4.Text = "Totale : " + tot.ToString
                    End If
            End Select


        Catch Exception As Exception
            If (CheckBox2.Checked = True) Then

            Else MsgBox("fait attention a la saisie ! ", MsgBoxStyle.Critical, "attention")
            End If

        End Try


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (Me.CheckBox2.Checked = True) Then
            TextBox1.Text = ""
            TextBox1.Enabled = False
        End If
        If (Me.CheckBox2.Checked = False) Then
            TextBox1.Enabled = True

        End If
    End Sub

    Private Sub cong_Click(sender As Object, e As EventArgs)


    End Sub
End Class