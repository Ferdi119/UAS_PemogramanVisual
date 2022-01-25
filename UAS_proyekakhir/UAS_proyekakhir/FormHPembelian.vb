Imports MySql.Data.MySqlClient
Public Class FormHPembelian
    Sub awal()
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tbl_transaksi", con)
        ds = New DataSet
        da.Fill(ds, "tbl_transaksi")
        DataGridView1.DataSource = ds.Tables("tbl_transaksi")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub FormHPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        awal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        da = New MySqlDataAdapter("select * from tbl_transaksi where id_pelanggan like '%" _
          & TextBox1.Text & "%'", con)
        ds = New DataSet
        rd.Close()
        da.Fill(ds, "tbl_transaksi")
        DataGridView1.DataSource = (ds.Tables("tbl_transaksi"))
    End Sub
End Class