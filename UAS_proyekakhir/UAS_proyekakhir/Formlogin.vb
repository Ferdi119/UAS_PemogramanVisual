Imports MySql.Data.MySqlClient
Public Class Formlogin
    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True

        kondisiawal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Sub unlock()
        FormMenuPenjualan.LoginToolStripMenuItem.Enabled = False
        FormMenuPenjualan.LogoutToolStripMenuItem.Enabled = True
        FormMenuPenjualan.MasterToolStripMenuItem.Enabled = True
        FormMenuPenjualan.TransaksiToolStripMenuItem.Enabled = True
        FormMenuPenjualan.PasswordToolStripMenuItem.Enabled = True
    End Sub
    Sub kondisiawal()
        TextBox1.Text = ""
        TextBox1.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Text = "show"

        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Username belum dimasukkan", MsgBoxStyle.Information, "Username ?")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MsgBox("Password belum dimasukkan", MsgBoxStyle.Information, "Password ?")
            TextBox2.Focus()
        Else
            Call koneksi()
            cmd = New MySqlCommand("Select * From tbl_admin where idadmin='" & TextBox1.Text & "'and passadmin='" & TextBox2.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Call unlock()
                Me.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                MsgBox("Login sudah aktif", MsgBoxStyle.Information, "Informasi")
                FormMenuPenjualan.STlabel2.Text = rd!idadmin
                FormMenuPenjualan.STlabel4.Text = rd!namaadmin
                FormMenuPenjualan.STlabel6.Text = rd!leveladmin
                If FormMenuPenjualan.STlabel6.Text = "USER" Then
                    FormMenuPenjualan.AdminToolStripMenuItem.Enabled = False
                ElseIf FormMenuPenjualan.STlabel6.Text = "ADMIN" Then
                    FormMenuPenjualan.AdminToolStripMenuItem.Enabled = True
                End If
            Else
                    MsgBox("Username atau password Salah !", MsgBoxStyle.Information, "Informasi")
                TextBox1.Text = ""
                TextBox2.Text = ""
                CheckBox1.Checked = False
                CheckBox1.Text = "show"
            End If

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Hide"
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
            CheckBox1.Text = "Show"
        End If
    End Sub
End Class