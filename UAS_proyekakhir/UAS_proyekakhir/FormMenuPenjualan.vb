Public Class FormMenuPenjualan
    Sub lock()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        PasswordToolStripMenuItem.Enabled = False

        STlabel2.Text = ""
        STlabel4.Text = ""
        STlabel6.Text = ""
    End Sub
    Private Sub FormMenuPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lock()
        STlabel10.Text = Today
    End Sub

    Private Sub FormMenuPenjualan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Formlogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call lock()
        MsgBox("Login telah dinoaktifkan", MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Formadmin.ShowDialog()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FormPelanggan.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Formbarang.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        STlabel8.Text = TimeOfDay
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub HistoryPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryPembelianToolStripMenuItem.Click
        FormHPembelian.ShowDialog()
    End Sub

    Private Sub HistoryPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryPelangganToolStripMenuItem.Click
        FormHPelanggan.ShowDialog()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        FormPassword.ShowDialog()
    End Sub
End Class