Imports MySql.Data.MySqlClient
Public Class Formbarang
    Sub awal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = True
        TextBox5.Enabled = False
        ComboBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Exit"
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tbl_barang", con)
        ds = New DataSet
        da.Fill(ds, "tbl_barang")
        DataGridView1.DataSource = ds.Tables("tbl_barang")
        DataGridView1.ReadOnly = True
    End Sub

    Sub isi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = False
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
        satuan()
    End Sub

    Sub satuan()
        Call koneksi()
        cmd = New MySqlCommand("select distinct satuanbarang from tbl_barang", con)
        rd = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item("satuanbarang"))
        Loop
    End Sub

    Private Sub Formbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call isi()
            Call NoOtomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Tolong isi semua data barang yang dibutuhkan")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_barang values('" & TextBox1.Text & "', 
                            '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox5.Text & "', '" & ComboBox1.Text & "')"
                cmd = New MySqlCommand(InputData, con)
                cmd.ExecuteNonQuery()
                MsgBox("Input data barang telah selesai")
                Call awal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Tolong isi semua data barang yang kurang")
            Else
                Call koneksi()
                Dim Updated As String
                Updated = "update tbl_barang set namabarang ='" & TextBox2.Text & "', hargabarang = '" & TextBox3.Text & "', 
                            jumlahbarang = '" & TextBox5.Text & "', satuanbarang = '" & ComboBox1.Text & "' where idbarang ='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(Updated, con)
                cmd.ExecuteNonQuery()
                MsgBox("Update data telah selesai")
                Call awal()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("Select * From tbl_barang where idbarang='" & TextBox1.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("ID barang belum ditemukan")
            Else
                TextBox1.Text = rd.Item("idbarang")
                TextBox2.Text = rd.Item("namabarang")
                TextBox3.Text = rd.Item("hargabarang")
                TextBox5.Text = rd.Item("jumlahbarang")
                ComboBox1.Text = rd.Item("satuanbarang")
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Exit" Then
            Me.Close()
        Else
            Call awal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call isi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Data admin tidak ada yang dihapus")
            Else
                Call koneksi()
                Dim hapus As String
                hapus = "delete from tbl_barang where idbarang ='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(hapus, con)
                cmd.ExecuteNonQuery()

                MsgBox("Hapus data barang telah selesai")
                Call awal()
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        da = New MySqlDataAdapter("select * from tbl_barang where namabarang like '%" _
           & TextBox4.Text & "%'", con)
        ds = New DataSet
        rd.Close()
        da.Fill(ds, "tbl_barang")
        DataGridView1.DataSource = (ds.Tables("tbl_barang"))
    End Sub

    Sub NoOtomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select * from tbl_barang where idbarang in (select max(idbarang) from tbl_barang)", con)
        Dim Urutancode As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Urutancode = "BRG-" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            Urutancode = "BRG-" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = Urutancode
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Hide()
        Formadmin.Hide()

        FormPelanggan.Show()
    End Sub
End Class