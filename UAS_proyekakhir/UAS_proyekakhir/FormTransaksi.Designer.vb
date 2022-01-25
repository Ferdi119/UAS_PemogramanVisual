<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblNotrans = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.LblNamaPlg = New System.Windows.Forms.Label()
        Me.LblTlp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblAdmin = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblKembali = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LblNamabarang = New System.Windows.Forms.Label()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.LblJumBarang = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomer Transaksi"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID pelanggan"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 44)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 44)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 44)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No.Telp"
        '
        'LblNotrans
        '
        Me.LblNotrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNotrans.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotrans.Location = New System.Drawing.Point(208, 50)
        Me.LblNotrans.Name = "LblNotrans"
        Me.LblNotrans.Size = New System.Drawing.Size(190, 44)
        Me.LblNotrans.TabIndex = 5
        Me.LblNotrans.Text = "LblNotrans"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(209, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'LblAlamat
        '
        Me.LblAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAlamat.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAlamat.Location = New System.Drawing.Point(209, 217)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(371, 44)
        Me.LblAlamat.TabIndex = 7
        Me.LblAlamat.Text = "LblAlamat"
        '
        'LblNamaPlg
        '
        Me.LblNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaPlg.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNamaPlg.Location = New System.Drawing.Point(208, 160)
        Me.LblNamaPlg.Name = "LblNamaPlg"
        Me.LblNamaPlg.Size = New System.Drawing.Size(372, 44)
        Me.LblNamaPlg.TabIndex = 8
        Me.LblNamaPlg.Text = "LblNamaPlg"
        '
        'LblTlp
        '
        Me.LblTlp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTlp.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTlp.Location = New System.Drawing.Point(209, 275)
        Me.LblTlp.Name = "LblTlp"
        Me.LblTlp.Size = New System.Drawing.Size(223, 44)
        Me.LblTlp.TabIndex = 9
        Me.LblTlp.Text = "LblTlp"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(725, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 31)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Admin"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(725, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Jam"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(725, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 31)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Tanggal"
        '
        'LblAdmin
        '
        Me.LblAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAdmin.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmin.Location = New System.Drawing.Point(914, 157)
        Me.LblAdmin.Name = "LblAdmin"
        Me.LblAdmin.Size = New System.Drawing.Size(190, 31)
        Me.LblAdmin.TabIndex = 13
        Me.LblAdmin.Text = "LblAdmin"
        '
        'LblJam
        '
        Me.LblJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblJam.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.Location = New System.Drawing.Point(914, 217)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(190, 31)
        Me.LblJam.TabIndex = 14
        Me.LblJam.Text = "LblJam"
        '
        'LblTanggal
        '
        Me.LblTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTanggal.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.Location = New System.Drawing.Point(914, 277)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(190, 31)
        Me.LblTanggal.TabIndex = 15
        Me.LblTanggal.Text = "LblTanggal"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Georgia", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(495, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 47)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "      Total  :     "
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(691, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(359, 47)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Rp. 260.000"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 463)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1092, 206)
        Me.DataGridView1.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(725, 686)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 31)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Membayar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(914, 695)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 22)
        Me.TextBox1.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(725, 737)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(183, 31)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Kembalian"
        '
        'LblKembali
        '
        Me.LblKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblKembali.Font = New System.Drawing.Font("Microsoft JhengHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKembali.Location = New System.Drawing.Point(914, 737)
        Me.LblKembali.Name = "LblKembali"
        Me.LblKembali.Size = New System.Drawing.Size(183, 31)
        Me.LblKembali.TabIndex = 22
        Me.LblKembali.Text = "LblKembali"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 686)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 57)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 686)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 57)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(362, 686)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 57)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(12, 346)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 45)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "ID Barang"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(357, 346)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 45)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Nama Barang"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(357, 405)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 45)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Harga "
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(12, 405)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 45)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Jumlah dibeli"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(208, 356)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 22)
        Me.TextBox2.TabIndex = 30
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(208, 416)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 22)
        Me.TextBox3.TabIndex = 31
        '
        'LblNamabarang
        '
        Me.LblNamabarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNamabarang.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblNamabarang.Location = New System.Drawing.Point(538, 346)
        Me.LblNamabarang.Name = "LblNamabarang"
        Me.LblNamabarang.Size = New System.Drawing.Size(210, 45)
        Me.LblNamabarang.TabIndex = 32
        Me.LblNamabarang.Text = "LblNamabarang"
        '
        'LblHarga
        '
        Me.LblHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHarga.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblHarga.Location = New System.Drawing.Point(538, 405)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(172, 45)
        Me.LblHarga.TabIndex = 33
        Me.LblHarga.Text = "LblHarga"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(934, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 54)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Input"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(516, 687)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 45)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Item"
        '
        'LblItem
        '
        Me.LblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblItem.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblItem.Location = New System.Drawing.Point(600, 686)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(110, 45)
        Me.LblItem.TabIndex = 36
        '
        'LblJumBarang
        '
        Me.LblJumBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblJumBarang.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.LblJumBarang.Location = New System.Drawing.Point(754, 346)
        Me.LblJumBarang.Name = "LblJumBarang"
        Me.LblJumBarang.Size = New System.Drawing.Size(110, 45)
        Me.LblJumBarang.TabIndex = 37
        Me.LblJumBarang.Text = "LblJumBarang"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1118, 795)
        Me.Controls.Add(Me.LblJumBarang)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.LblNamabarang)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblKembali)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.LblAdmin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblTlp)
        Me.Controls.Add(Me.LblNamaPlg)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblNotrans)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblNotrans As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LblAlamat As Label
    Friend WithEvents LblNamaPlg As Label
    Friend WithEvents LblTlp As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblAdmin As Label
    Friend WithEvents LblJam As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LblKembali As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblNamabarang As Label
    Friend WithEvents LblHarga As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents LblItem As Label
    Friend WithEvents LblJumBarang As Label
End Class
