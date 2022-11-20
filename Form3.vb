Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Runtime.InteropServices
Public Class Form3
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            da = New SqlDataAdapter("update etat_journalier set nom_du_bateau='" & nom.Text & "',immatriculation='" & imma.Text & "',pavillon='" & pav.Text & "',typee='" & type.Text & "',longueur=" & Double.Parse(lon.Text, New CultureInfo("en-US")) & ",poste='" & poste.Text & "',date_arr='" & arr.Text & "',date_dep='" & dep.Text & "',proprietaire='" & prop.Text & "',numero_tele='" & tele.Text & "' where Num=" & ComboBox1.Text & "", con)
            cmd = New SqlCommandBuilder(da)
            da.Update(ds, "etat_journalier")
            da.Fill(ds, "etat_journalier")
            ds.Tables("etat_journalier").AcceptChanges()

            MsgBox("bien modifier", MsgBoxStyle.Information, "succes")
            Me.Close()
            Call Form1.Button1_Click_1(Nothing, Nothing)
        Catch ex As Exception
            MsgBox("fait attention a la saise", MsgBoxStyle.Critical, "attention")

        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pos As Integer
        da = New SqlDataAdapter("select * from etat_journalier", con)
        da.Fill(ds, "etat_journalier1")
        While pos <= ds.Tables("etat_journalier1").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("etat_journalier1").Rows(pos).Item(0))
            pos += 1
        End While
        ds.Tables("etat_journalier1").Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

            da = New SqlDataAdapter("select * from etat_journalier where Num=" + ComboBox1.Text + "", con)
            da.Fill(ds, "re1")
            nom.Text = ds.Tables("re1").Rows(0).Item(1)
            imma.Text = ds.Tables("re1").Rows(0).Item(2)
            pav.Text = ds.Tables("re1").Rows(0).Item(3)
            type.Text = ds.Tables("re1").Rows(0).Item(4)
            lon.Text = ds.Tables("re1").Rows(0).Item(5)
            poste.Text = ds.Tables("re1").Rows(0).Item(6)
            arr.Text = ds.Tables("re1").Rows(0).Item(7)
            dep.Text = ds.Tables("re1").Rows(0).Item(8)
            prop.Text = ds.Tables("re1").Rows(0).Item(9)
            tele.Text = ds.Tables("re1").Rows(0).Item(10)

            ds.Tables("re1").Clear()
        Catch ex As Exception
            MsgBox("Erreur", MsgBoxStyle.Critical, "Erreur")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class