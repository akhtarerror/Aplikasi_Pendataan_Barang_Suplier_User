Public Class Home
    Private Sub btnSuplier_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        Supplier.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        User.Show()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        Barang.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub MasterBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBarangToolStripMenuItem.Click
        Dim f2 As New Barang
        f2.MdiParent = Me
        f2.Show()
    End Sub

    Private Sub MasterSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSupplierToolStripMenuItem.Click
        Dim f3 As New Supplier
        f3.MdiParent = Me
        f3.Show()
    End Sub

    Private Sub MasterUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterUserToolStripMenuItem.Click
        Dim f4 As New User
        f4.MdiParent = Me
        f4.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Dim f4 As New Pembelian
        f4.MdiParent = Me
        f4.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        Dim f4 As New Penjualan
        f4.MdiParent = Me
        f4.Show()
    End Sub

    Private Sub DetailPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailPenjualanToolStripMenuItem.Click
        Dim f4 As New DetailPenjualan
        f4.MdiParent = Me
        f4.Show()
    End Sub

    Private Sub DetailPembeliaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailPembeliaanToolStripMenuItem.Click
        Dim f4 As New DetailPembelian
        f4.MdiParent = Me
        f4.Show()
    End Sub
End Class