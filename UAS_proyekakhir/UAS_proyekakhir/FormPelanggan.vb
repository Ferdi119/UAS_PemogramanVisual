Imports MySql.Data.MySqlClient
Public Class FormPelanggan
    Sub awal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = True
        TextBox5.Enabled = False
        TextBox6.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Exit"
        Call koneksi()
        da = New MySqlDataAdapter("Select * From tbl_pelanggan", con)
        ds = New DataSet
        da.Fill(ds, "tbl_pelanggan")
        DataGridView1.DataSource = ds.Tables("tbl_pelanggan")
        DataGridView1.ReadOnly = True
    End Sub

    Sub isi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = False
        TextBox5.Enabled = True
        TextBox6.Enabled = True
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
                MsgBox("Tolong isi semua data pelanggan yang dibutuhkan")
            Else
                Call koneksi()
                Dim InputData As String = "insert into tbl_pelanggan values('" & TextBox1.Text & "', 
                            '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
                cmd = New MySqlCommand(InputData, con)
                cmd.ExecuteNonQuery()
                MsgBox("Input data telah selesai")
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Tolong isi semua data pelanggan yang kurang")
            Else
                Call koneksi()
                Dim Updated As String
                Updated = "update tbl_pelanggan set nama ='" & TextBox2.Text & "', alamat = '" & TextBox3.Text & "', telp = '" & TextBox5.Text & "', Email = '" & TextBox6.Text & "' where id_pelanggan ='" & TextBox1.Text & "'"
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
            cmd = New MySqlCommand("Select * From tbl_pelanggan where id_pelanggan='" & TextBox1.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("ID pelanggan belum ditemukan")
            Else
                TextBox1.Text = rd.Item("id_pelanggan")
                TextBox2.Text = rd.Item("nama")
                TextBox3.Text = rd.Item("alamat")
                TextBox5.Text = rd.Item("telp")
                TextBox6.Text = rd.Item("Email")
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
                MsgBox("Data admin tidak ada yang dihapus")
            Else
                Call koneksi()
                Dim hapus As String
                hapus = "delete from tbl_pelanggan where id_pelanggan ='" & TextBox1.Text & "'"
                cmd = New MySqlCommand(hapus, con)
                cmd.ExecuteNonQuery()

                MsgBox("Hapus data pelanggan telah selesai")
                Call awal()
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        da = New MySqlDataAdapter("select * from tbl_pelanggan where nama like '%" _
            & TextBox4.Text & "%'", con)
        ds = New DataSet
        rd.Close()
        da.Fill(ds, "tbl_pelanggan")
        DataGridView1.DataSource = (ds.Tables("tbl_pelanggan"))
    End Sub

    Sub NoOtomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select * from tbl_pelanggan where id_pelanggan in (select max(id_pelanggan) from tbl_pelanggan)", con)
        Dim Urutancode As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Urutancode = "PL" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 3) + 1
            Urutancode = "PL" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = Urutancode
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Me.Hide()
        Formadmin.Hide()

        Formbarang.ShowDialog()
    End Sub
End Class