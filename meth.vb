Imports System.Data.SqlClient
Module meth
    Public user As String
    Public pass As String
    Public server As String
    Public db As String
    Public da As SqlDataAdapter
    Public ds As New DataSet
    Public cmd As New SqlCommandBuilder
    Public con As SqlConnection
    Public sec As Boolean



    Public Function conn(ByVal ser As String, d_b As String) As Integer
        Try
            con = New SqlConnection("Data Source=" + ser + ";Initial Catalog=" + d_b + ";Integrated Security=True")
            con.Open()
            Return 1
        Catch ex As Exception
            MsgBox("erreur de connexion a la basse de donnes", 16, "erreur de cnx")
            Return 0
        End Try
    End Function
    Public Sub ref()

    End Sub
End Module
