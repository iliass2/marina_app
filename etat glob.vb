Imports System.Data.SqlClient
Public Class FormProductos
    Dim row As DataGridViewRow
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ReadOnly = True
        DataGridView1.DataSource = Nothing
        ds.Clear()
        DataGridView1.MultiSelect = False
        ds.Clear()
        da = New SqlDataAdapter("select distinct year(date_dep)  from etat_glob", con)
        da.Fill(ds, "years")
        Dim i As Integer
        i = 0
        While i < ds.Tables("years").Rows.Count
            ComboBox2.Items.Add(ds.Tables("years").Rows(i).Item(0))
            i += 1
        End While
        da = New SqlDataAdapter("select * from etat_glob", con)
        da.Fill(ds, "etat_glob")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = ds.Tables("etat_glob")
        da = New SqlDataAdapter("select distinct nom_du_bateau from etat_glob", con)
        da.Fill(ds, "nom")
        Dim pos As Integer
        While pos <= ds.Tables("nom").Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables("nom").Rows(pos).Item(0))
            pos += 1
        End While
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub Chercher_Click(sender As Object, e As EventArgs) Handles Chercher.Click
        Try

            If (Radiopre.Checked = True) Then
                ds.Clear()
                DataGridView1.MultiSelect = False
                da = New SqlDataAdapter("select * from etat_glob where n_g=" & chercher_T.Text, con)
                da.Fill(ds, "cher")
                DataGridView1.DataSource = ds.Tables("cher")
            End If
            If (RadioNom.Checked = True) Then
                ds.Clear()
                DataGridView1.MultiSelect = False
                da = New SqlDataAdapter("select * from etat_glob where nom_du_bateau='" & chercher_T.Text & "'", con)
                da.Fill(ds, "cher")
                DataGridView1.DataSource = ds.Tables("cher")
            End If
        Catch ex As Exception
            MsgBox("fait attention a la saisie !", 16, "Attention")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)





    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ds.Clear()
        da = New SqlDataAdapter("select * from etat_glob where  year(date_dep)='" & ComboBox2.Text & "' or year(date_arr)='" & ComboBox2.Text & "'  ", con)
        da.Fill(ds, "yy")
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = ds.Tables("yy")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        modifier_form.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim co As Integer

        da = New SqlDataAdapter("select count (*) from etat_glob where nom_du_bateau='" & ComboBox1.Text & "'", con)
        cmd = New SqlCommandBuilder(da)
        da.Fill(ds, "co")
        co = Integer.Parse(ds.Tables("co").Rows(0).Item(0))
        Label3.Text = "Nombre d'entrées : " & co
        ds.Tables("co").Clear()
    End Sub
End Class