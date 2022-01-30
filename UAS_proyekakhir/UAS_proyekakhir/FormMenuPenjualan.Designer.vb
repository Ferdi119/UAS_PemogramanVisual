<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.STlabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STlabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.PasswordToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(136, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(139, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ToolStripMenuItem2, Me.BarangToolStripMenuItem, Me.PelangganToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.MasterToolStripMenuItem.Text = "Data"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(158, 6)
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.HistoryPembelianToolStripMenuItem, Me.HistoryPelangganToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(82, 26)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'HistoryPembelianToolStripMenuItem
        '
        Me.HistoryPembelianToolStripMenuItem.Name = "HistoryPembelianToolStripMenuItem"
        Me.HistoryPembelianToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.HistoryPembelianToolStripMenuItem.Text = "History pembelian"
        '
        'HistoryPelangganToolStripMenuItem
        '
        Me.HistoryPelangganToolStripMenuItem.Name = "HistoryPelangganToolStripMenuItem"
        Me.HistoryPelangganToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.HistoryPelangganToolStripMenuItem.Text = "History Barang"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem})
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(86, 26)
        Me.PasswordToolStripMenuItem.Text = "password"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti password"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STlabel1, Me.STlabel2, Me.STlabel3, Me.STlabel4, Me.STlabel5, Me.STlabel6, Me.STlabel7, Me.STlabel8, Me.STlabel9, Me.STlabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 26)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'STlabel1
        '
        Me.STlabel1.Name = "STlabel1"
        Me.STlabel1.Size = New System.Drawing.Size(31, 20)
        Me.STlabel1.Text = "ID :"
        '
        'STlabel2
        '
        Me.STlabel2.Name = "STlabel2"
        Me.STlabel2.Size = New System.Drawing.Size(0, 20)
        '
        'STlabel3
        '
        Me.STlabel3.Name = "STlabel3"
        Me.STlabel3.Size = New System.Drawing.Size(56, 20)
        Me.STlabel3.Text = "Nama :"
        '
        'STlabel4
        '
        Me.STlabel4.Name = "STlabel4"
        Me.STlabel4.Size = New System.Drawing.Size(0, 20)
        '
        'STlabel5
        '
        Me.STlabel5.Name = "STlabel5"
        Me.STlabel5.Size = New System.Drawing.Size(81, 20)
        Me.STlabel5.Text = "Tingkatan :"
        '
        'STlabel6
        '
        Me.STlabel6.Name = "STlabel6"
        Me.STlabel6.Size = New System.Drawing.Size(0, 20)
        '
        'STlabel7
        '
        Me.STlabel7.Name = "STlabel7"
        Me.STlabel7.Size = New System.Drawing.Size(42, 20)
        Me.STlabel7.Text = "Jam :"
        '
        'STlabel8
        '
        Me.STlabel8.Name = "STlabel8"
        Me.STlabel8.Size = New System.Drawing.Size(0, 20)
        '
        'STlabel9
        '
        Me.STlabel9.Name = "STlabel9"
        Me.STlabel9.Size = New System.Drawing.Size(68, 20)
        Me.STlabel9.Text = "Tanggal :"
        '
        'STlabel10
        '
        Me.STlabel10.Name = "STlabel10"
        Me.STlabel10.Size = New System.Drawing.Size(0, 20)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama : Ferdi maulana akbar "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-4, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NIM    : 2019230119"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 7
        '
        'FormMenuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuPenjualan"
        Me.Text = "FormMenuPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STlabel1 As ToolStripStatusLabel
    Friend WithEvents STlabel2 As ToolStripStatusLabel
    Friend WithEvents STlabel3 As ToolStripStatusLabel
    Friend WithEvents STlabel4 As ToolStripStatusLabel
    Friend WithEvents STlabel5 As ToolStripStatusLabel
    Friend WithEvents STlabel6 As ToolStripStatusLabel
    Friend WithEvents STlabel7 As ToolStripStatusLabel
    Friend WithEvents STlabel8 As ToolStripStatusLabel
    Friend WithEvents STlabel9 As ToolStripStatusLabel
    Friend WithEvents STlabel10 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HistoryPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryPelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
