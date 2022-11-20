Imports System.Data.SqlClient
Public Class demande_conge

    Private Sub demande_conge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ds.Clear()
        da = New SqlDataAdapter("select etat_journalier.nom_du_bateau,etat_journalier.immatriculation,etat_journalier.date_arr,etat_journalier.date_dep,etat_journalier.proprietaire,etat_glob.paiment from etat_journalier,etat_glob where etat_journalier.nom_du_bateau=etat_glob.nom_du_bateau and etat_glob.date_dep=etat_journalier.date_dep and etat_glob.paiment=0", con)
        da.Fill(ds, "exp")
        DataGridView1.DataSource = ds.Tables("exp")


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub x_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class