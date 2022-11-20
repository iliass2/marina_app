Imports System.Data.SqlClient

Public Class empl

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub empl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvempl.MultiSelect = False
        conn("(local)", "hola")
        dgvempl.DataSource = Nothing

        ds.Clear()
        da = New SqlDataAdapter("select * from etat_journalier", con)
        da.Fill(ds, "etat_journalier")
        dgvempl.DataSource = Nothing

        dgvempl.DataSource = ds.Tables("etat_journalier")

    End Sub

    Public Sub dgvempl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvempl.CellContentClick

    End Sub

    Private Sub ajouter_Click(sender As Object, e As EventArgs)
        ajouterform.Show()



    End Sub

    Private Sub supp_Click(sender As Object, e As EventArgs) Handles supp.Click
        Dim s As String = dgvempl.Rows(dgvempl.CurrentRow.Index).Cells(0).Value
        Dim re = MsgBox("Êtes-vous sûr ?", MsgBoxStyle.OkCancel, "confirmation")
        If re = 1 Then
            da = New SqlDataAdapter("delete from etat_journalier where Num=" & s & "", con)
            cmd = New SqlCommandBuilder(da)
            da.Fill(ds, "etat_journalier")
            da.Update(ds, "etat_journalier")
            ds.Tables("etat_journalier").AcceptChanges()
            Call Form1.Button1_Click_1(Form1.Button1, Nothing)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()

    End Sub

    Private Sub Chercher_Click(sender As Object, e As EventArgs) Handles Chercher.Click
        Dim dv As New DataView
        Try


            If id.Checked = True Then
                Dim i As Integer = 0
                While (i < dgvempl.Rows().Count)
                    If (dgvempl.Rows(i).Cells(0).Value = chercher_T.Text) Then
                        dgvempl.Rows(i).Selected = True
                    End If
                    i += 1
                End While

            End If
            If RadioNom.Checked = True Then
                dv.Table = ds.Tables("etat_journalier")
                dv.RowFilter = "nom_du_bateau like '" & chercher_T.Text & "%'"
                dv.Sort = "nom_du_bateau desc"
                dgvempl.DataSource = dv
            End If

        Catch ex As Exception
            MsgBox("s'il vous plait fait attention ", 0, "info")
        End Try
    End Sub
End Class