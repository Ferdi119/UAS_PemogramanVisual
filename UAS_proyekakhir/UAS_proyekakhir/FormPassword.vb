Imports MySql.Data.MySqlClient
Public Class FormPassword
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FormPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pawal()
    End Sub

    Sub Pawal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.UseSystemPasswordChar = True
        TextBox2.UseSystemPasswordChar = True
        TextBox3.UseSystemPasswordChar = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = False

        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("Select * from tbl_admin where idadmin='" & FormMenuPenjualan.STlabel2.Text & "' and passadmin='" & TextBox1.Text & "' ", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox1.Enabled = False
                Button1.Enabled = True

                CheckBox2.Enabled = True
                CheckBox1.Enabled = False
                TextBox2.Focus()
            Else
                MsgBox("Password lama SALAH")
                TextBox1.Text = ""

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Tolong masukkan password baru Disini")
            TextBox2.Focus()
        Else
            If TextBox2.Text <> TextBox3.Text Then
                MsgBox("Password baru maupun Konfirmasi harus sama")
            Else
                Call koneksi()
                Dim Epassword As String = "Update tbl_admin set passadmin= '" & TextBox2.Text & "' where idadmin='" & FormMenuPenjualan.STlabel2.Text & "' "
                cmd = New MySqlCommand(Epassword, con)
                cmd.ExecuteNonQuery()
                MsgBox("Password telah berhasil diganti")
                Call Pawal()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Hide"
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
            CheckBox1.Text = "Show"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.Text = "Hide"
            TextBox2.UseSystemPasswordChar = False
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
            TextBox3.UseSystemPasswordChar = True
            CheckBox2.Text = "Show"
        End If
    End Sub
End Class