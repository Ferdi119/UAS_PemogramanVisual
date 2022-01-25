Imports MySql.Data.MySqlClient
Module Module1
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public da As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public db As String

    Public Sub koneksi()
        db = "Server=localhost;user id=root;password=;database=db_penjualan;"
        con = New MySqlConnection(db)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Function SQLTable(ByVal Source As String) As DataTable
        Try
            Dim adp As New MySqlDataAdapter(Source, con)
            Dim DT As New DataTable
            adp.Fill(DT)
            SQLTable = DT
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function
End Module
