Imports MySql.Data.MySqlClient
Public Class FormHPelanggan
    Sub TDetail()
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tbl_detail1", con)
        ds = New DataSet
        da.Fill(ds, "tbl_detail1")
        DataGridView1.DataSource = ds.Tables("tbl_detail1")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormHPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TDetail()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New MySqlDataAdapter("select * from tbl_detail1 where namabarang like '%" _
          & TextBox1.Text & "%'", con)
        ds = New DataSet
        rd.Close()
        da.Fill(ds, "tbl_detail1")
        DataGridView1.DataSource = (ds.Tables("tbl_detail1"))
    End Sub
End Class