Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class modifier_form

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub modifier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pos As Integer
        da = New SqlDataAdapter("select * from etat_glob", con)
        da.Fill(ds, "etat_glob1")
        While pos <= ds.Tables("etat_glob1").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("etat_glob1").Rows(pos).Item(0))
            pos += 1
        End While
        ds.Tables("etat_glob1").Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            da = New SqlDataAdapter("select * from etat_glob where n_g=" + ComboBox1.Text + "", con)
            da.Fill(ds, "re")
            nom.Text = ds.Tables("re").Rows(0).Item(1)
            imma.Text = ds.Tables("re").Rows(0).Item(2)
            pav.Text = ds.Tables("re").Rows(0).Item(3)
            type.Text = ds.Tables("re").Rows(0).Item(4)
            lon.Text = ds.Tables("re").Rows(0).Item(5)
            poste.Text = ds.Tables("re").Rows(0).Item(6)
            arr.Text = ds.Tables("re").Rows(0).Item(7)
            dep.Text = ds.Tables("re").Rows(0).Item(8)
            sej.Text = ds.Tables("re").Rows(0).Item(9)
            num.Text = ds.Tables("re").Rows(0).Item(11)
            prop.Text = ds.Tables("re").Rows(0).Item(12)
            tele.Text = ds.Tables("re").Rows(0).Item(13)
            obs.Text = ds.Tables("re").Rows(0).Item(14)
            Dim t As Integer = ds.Tables("re").Rows(0).Item(10)
            If (t = 0) Then
                RadioButton1.Checked = True
            End If
            If (t = -1) Then
                RadioButton2.Checked = True
            End If
            ds.Tables("re").Clear()

        Catch ex As Exception
            MsgBox("errurre")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try


            Dim p As Integer
            If (RadioButton1.Checked = True) Then
                p = 0
            End If
            If (RadioButton2.Checked = True) Then
                p = -1
            End If
            System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            da = New SqlDataAdapter("update etat_glob set nom_du_bateau='" & nom.Text & "',immatriculation='" & imma.Text & "',pavillon='" & pav.Text & "',typee='" & type.Text & "',longueur=" & Double.Parse(lon.Text, New CultureInfo("en-US")) & ",poste='" & poste.Text & "',date_arr='" & arr.Text & "',date_dep='" & dep.Text & "', sejour=" & sej.Text & ",paiment=" & p & ",numero_facture='" & num.Text & "',proprietaire='" & prop.Text & "',numero_tele='" & tele.Text & "',observation='" & obs.Text & "' where n_g=" & ComboBox1.Text & "", con)
            cmd = New SqlCommandBuilder(da)
            da.Update(ds, "etat_glob")
            da.Fill(ds, "etat_glob")
            ds.Tables("etat_glob").AcceptChanges()

            MsgBox("bien modifier", MsgBoxStyle.Information, "succes")
            Me.Close()
            Call Form1.btnProductos_Click(Form1.btnProductos, Nothing)
        Catch ex As Exception
            MsgBox("fait attention a la saise", MsgBoxStyle.Critical, "attention")

        End Try
    End Sub
End Class