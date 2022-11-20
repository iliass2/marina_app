Imports System.Data.SqlClient
Public Class configuration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then

            MsgBox("fait attention", 16, "erreur")

        ElseIf (conn(TextBox1.Text, TextBox2.Text) = 1) Then
            MsgBox("connexion etablit avec succes", 48, "succes")
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            server = TextBox1.Text
            db = TextBox2.Text
            Dim a As Integer
            a = MsgBox("Voulez vous creer les tables automatiquement ?", 4, "creation des tables auto")
            Try
                If (a = 6) Then
                    Dim coom = New SqlCommand("create table abscence (N_abscence int identity(1,1),id_empl int not null,nom varchar(100) not null,prenom varchar(100) not null,datte date not null)", con)
                    da = New SqlDataAdapter(coom)
                    coom.ExecuteNonQuery()
                    coom = New SqlCommand("create table conge (N_conge int identity(1,1),id_empl int not null,nom varchar(100) not null,prenom varchar(100) not null,date_du date not null,date_au date not null)", con)
                    da = New SqlDataAdapter(coom)
                    coom.ExecuteNonQuery()
                    coom = New SqlCommand("create table empl (id int identity(1,1),nom varchar(100) not null,prenom varchar(100) not null,age int not null,departement varchar(100) not null)", con)
                    da = New SqlDataAdapter(coom)
                    coom.ExecuteNonQuery()
                    coom = New SqlCommand("create table mission (N_mission int identity(1,1),id_emp int not null,nom varchar(100) not null,prenom varchar(100) not null,date_du date not null,date_au date not null,motif_de_deplacement varchar(max),nature_de_deplacement varchar(max),)", con)
                    da = New SqlDataAdapter(coom)
                    coom.ExecuteNonQuery()
                    MsgBox("table crees avec succes", 48, "succes")
                End If
            Catch ex As Exception
                MsgBox("creation des table impossible", 16, "erreur de cnx")
            End Try

        End If

    End Sub

    Private Sub x_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sec = False
        Call Form1.Form1_Load(Nothing, Nothing)
        Call Form1.Button1_Click_1(Button1, Nothing)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox3.Text <> "" And TextBox4.Text <> "") Then
            user = TextBox3.Text
            pass = TextBox4.Text
            MsgBox("nom et mot de pass changer ", 64, "succes")
        Else
            MsgBox("fait attention ", 16, "erreue")

        End If
    End Sub

    Private Sub configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class