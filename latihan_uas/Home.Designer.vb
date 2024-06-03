<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailPembeliaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem, Me.DetailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1137, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterBarangToolStripMenuItem, Me.MasterSupplierToolStripMenuItem, Me.MasterUserToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.MenuToolStripMenuItem.Text = "Master"
        '
        'MasterBarangToolStripMenuItem
        '
        Me.MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        Me.MasterBarangToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.MasterBarangToolStripMenuItem.Text = "Master Barang"
        '
        'MasterSupplierToolStripMenuItem
        '
        Me.MasterSupplierToolStripMenuItem.Name = "MasterSupplierToolStripMenuItem"
        Me.MasterSupplierToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.MasterSupplierToolStripMenuItem.Text = "Master Supplier"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.MasterUserToolStripMenuItem.Text = "Master User"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailPenjualanToolStripMenuItem, Me.DetailPembeliaanToolStripMenuItem})
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.DetailToolStripMenuItem.Text = "Detail"
        '
        'DetailPenjualanToolStripMenuItem
        '
        Me.DetailPenjualanToolStripMenuItem.Name = "DetailPenjualanToolStripMenuItem"
        Me.DetailPenjualanToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DetailPenjualanToolStripMenuItem.Text = "Detail Penjualan"
        '
        'DetailPembeliaanToolStripMenuItem
        '
        Me.DetailPembeliaanToolStripMenuItem.Name = "DetailPembeliaanToolStripMenuItem"
        Me.DetailPembeliaanToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DetailPembeliaanToolStripMenuItem.Text = "Detail Pembelian"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 540)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailPembeliaanToolStripMenuItem As ToolStripMenuItem
End Class
