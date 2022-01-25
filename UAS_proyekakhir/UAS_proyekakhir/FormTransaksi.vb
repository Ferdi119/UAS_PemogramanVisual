Imports MySql.Data.MySqlClient
Public Class FormTransaksi
    Dim tglMYSQL As String
    Sub KAwal()
        LblNamaPlg.Text = ""
        LblAlamat.Text = ""
        LblTlp.Text = ""
        LblNamabarang.Text = ""
        LblJumBarang.Text = ""
        LblHarga.Text = ""
        ComboBox1.Text = ""
        LblTanggal.Text = Today
        LblAdmin.Text = FormMenuPenjualan.STlabel4.Text
        LblKembali.Text = ""

        TextBox2.Text = ""
        LblNamabarang.Text = ""
        LblHarga.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        LblItem.Text = ""
        munculP()
        NoOtomatis()
        kolom()

        Label10.Text = "0"
        TextBox1.Text = ""
    End Sub
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KAwal()
    End Sub

    Sub munculP()
        Call koneksi()
        ComboBox1.Items.Clear()
        cmd = New MySqlCommand("Select * from tbl_pelanggan", con)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        cmd = New MySqlCommand("Select * from tbl_pelanggan where id_pelanggan= '" & ComboBox1.Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LblNamaPlg.Text = rd!nama
            LblAlamat.Text = rd!alamat
            LblTlp.Text = rd!telp
        End If
    End Sub

    Sub NoOtomatis()
        Call koneksi()
        cmd = New MySqlCommand("Select * from tbl_transaksi where no_transaksi in (select max(no_transaksi) from tbl_transaksi)", con)
        Dim Urutancode As String
        Dim hitung As String
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            Urutancode = "T" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
            Urutancode = "T" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        LblNotrans.Text = Urutancode
    End Sub

    Sub kolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("ID", "ID")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("Select * From tbl_barang where idbarang='" & TextBox2.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("ID barang belum ditemukan")
            Else
                TextBox2.Text = rd.Item("idbarang")
                LblNamabarang.Text = rd.Item("namabarang")
                LblHarga.Text = rd.Item("hargabarang")
                LblJumBarang.Text = rd.Item("jumlahbarang")
                'TextBox5.Text = rd.Item("jumlahbarang")
                'ComboBox1.Text = rd.Item("satuanbarang")
                TextBox3.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox3.Text = "" Or LblNamabarang.Text = "" Then
            MsgBox("Tolong masukkan ID barang terlebih dahulu")
        Else
            If LblJumBarang.Text < Val(TextBox3.Text) Then
                MsgBox("Stock barang kurang")
            Else
                DataGridView1.Rows.Add(New String() {TextBox2.Text, LblNamabarang.Text, LblHarga.Text, TextBox3.Text, Val(LblHarga.Text) * Val(TextBox3.Text)})
                Call subtotal()

                TextBox2.Text = ""
                LblNamabarang.Text = ""
                LblHarga.Text = ""
                LblJumBarang.Text = ""
                TextBox3.Text = ""
                TextBox3.Enabled = False
                Call CariItem()
            End If
        End If
    End Sub

    Sub subtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            Label10.Text = hitung
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label10.Text) Then
                MsgBox("Uang pembayaran KURANG!")
            ElseIf Val(TextBox1.Text) = Val(Label10.Text) Then
                LblKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label10.Text) Then
                LblKembali.Text = Val(TextBox1.Text) - Val(Label10.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Sub CariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            LblItem.Text = HitungItem
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LblNamaPlg.Text = "" Or LblKembali.Text = "" Or Label10.Text = "" Then
            MsgBox("Transaksi masih kosong, Tolong lakukan transaksi terlebih dahulu")
        Else
            tglMYSQL = Format(Today, "yyyy-MM-dd")
            Dim simpantrans As String = "Insert into tbl_transaksi values('" & LblNotrans.Text & "', '" & tglMYSQL & "', 
                            '" & LblJam.Text & "', '" & LblItem.Text & "', '" & Label10.Text & "', '" & TextBox1.Text & "', 
                            '" & LblKembali.Text & "', '" & ComboBox1.Text & "', '" & FormMenuPenjualan.STlabel2.Text & "')"
            cmd = New MySqlCommand(simpantrans, con)
            rd.Close()
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim simpanDetail As String = "Insert into tbl_detail1 values('" & LblNotrans.Text & "', '" & DataGridView1.Rows(baris).Cells(0).Value & "',
                            '" & DataGridView1.Rows(baris).Cells(1).Value & "', '" & DataGridView1.Rows(baris).Cells(2).Value & "',
                            '" & DataGridView1.Rows(baris).Cells(3).Value & "', '" & DataGridView1.Rows(baris).Cells(4).Value & "')"
                cmd = New MySqlCommand(simpanDetail, con)
                rd.Close()
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("Select * from tbl_barang where idbarang='" & DataGridView1.Rows(baris).Cells(0).Value & "' ", con)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim kurangistock As String = "Update tbl_barang set jumlahbarang= '" & rd.Item("jumlahbarang") - DataGridView1.Rows(baris).Cells(3).Value & "' where idbarang='" & DataGridView1.Rows(baris).Cells(0).Value & "' "
                cmd = New MySqlCommand(kurangistock, con)
                rd.Close()
                cmd.ExecuteNonQuery()

            Next

            Call KAwal()
            MsgBox("Transaksi telah Berhasil")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Kamu akan menghapus seluruh data transaksi")
        DataGridView1.Rows.Clear()
        KAwal()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.SelectedRows.Count > 0 Then
            For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(i).Index)
                subtotal()
                CariItem()
            Next
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class