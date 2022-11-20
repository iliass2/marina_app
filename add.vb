Imports System.Data.SqlClient
Imports System.Globalization
Public Class add
    Private Sub mission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn("(local)", "hola")





    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Try



            Dim d1 As DateTime = Convert.ToDateTime(arr.Text)
            Dim d2 As DateTime = Convert.ToDateTime(dep.Text)
            DateTime.Compare(d1, d2)

            If (DateTime.Compare(d1, d2) > 0) Then
                MsgBox("la date ce n'est pas raissonable", 48, "La date")
            Else
                Dim bit As Integer
                If (RadioButton1.Checked = True) Then
                    bit = 0
                End If
                If (RadioButton2.Checked = True) Then
                    bit = 1
                End If

                System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")


                da = New SqlDataAdapter("insert into etat_glob values ('" & nom.Text & "','" & imma.Text & "','" & pav.Text & "','" & type.Text & "'," & Double.Parse(lon.Text, New CultureInfo("en-US")) & ",'" & poste.Text & "','" & arr.Text & "','" & dep.Text & "'," & Integer.Parse(sej.Text) & ",	" & bit & ",'" & num.Text & "'	,'" & prop.Text & "','" & tele.Text & "','" & obs.Text & "')", con)

                cmd = New SqlCommandBuilder(da)
                da.Fill(ds, "etat_glob")
                '  da.Update(ds, "etat_glob")
                'ds.Tables("etat_glob").AcceptChanges()

                da = New SqlDataAdapter("insert into etat_journalier values('" & nom.Text & "','" & imma.Text & "' ,'" & pav.Text & "','" & type.Text & "'," & Double.Parse(lon.Text, New CultureInfo("en-US")) & ",'" & poste.Text & "','" & arr.Text & "','" & dep.Text & "','" & prop.Text & "','" & num.Text & "' )", con)
                da.Fill(ds, "etat_journalier")

                MsgBox("enregistrer avec succes", 64, "succes")
                nom.Text = Nothing
                imma.Text = Nothing
                pav.Text = Nothing
                type.Text = Nothing
                dep.Text = Nothing
                arr.Text = Nothing
                poste.Text = Nothing
                lon.Text = Nothing
                tele.Text = Nothing
                RadioButton1.Checked = False
                RadioButton2.Checked = False
                prop.Text = Nothing

                num.Text = Nothing
                sej.Text = Nothing
                obs.Text = Nothing

            End If
        Catch ex As Exception
            MsgBox("fait attention a la saisie ! ", MsgBoxStyle.Critical, "attention")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub x_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        arr.Text = todaysdate
    End Sub
End Class