Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class DetailPembelian
    Private faktur As String
    Private PrintPreviewDialog1 As New PrintPreviewDialog() ' Declare PrintPreviewDialog1 here

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ambil nilai dari TextBox1
        faktur = TextBox1.Text.Trim()

        ' Lakukan query dan tampilkan laporan
        PrintPreviewDialog1.Document = New PrintDocument()
        AddHandler PrintPreviewDialog1.Document.PrintPage, AddressOf PrintPage
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Query untuk mengambil data transaksi dan detailtransaksi berdasarkan faktur
        Dim query As String = "SELECT pembelian.faktur, pembelian.tgl, pembelian.total, pembelian.bayar, pembelian.kembali, " &
                              "detailtransaksibeli.nama_barang, detailtransaksibeli.jumlah, detailtransaksibeli.harga_satuan, detailtransaksibeli.total " &
                              "FROM pembelian INNER JOIN detailtransaksibeli ON pembelian.faktur = detailtransaksibeli.faktur " &
                              "WHERE pembelian.faktur = @faktur"

        ' Koneksi ke database menggunakan module koneksi
        koneksi()

        ' Buat adapter untuk mengisi dataset
        Using adapter As New MySqlDataAdapter(query, conn)
            ' Tambahkan parameter faktur ke query
            adapter.SelectCommand.Parameters.AddWithValue("@faktur", faktur)

            ' Buat dataset
            Dim dataSet As New DataSet()

            ' Isi dataset dengan data dari database
            adapter.Fill(dataSet, "DataSet1")

            ' Inisialisasi variabel
            Dim yPos As Integer = e.MarginBounds.Top
            Dim count As Integer = 0
            Dim leftMargin As Integer = e.MarginBounds.Left
            Dim columnCount As Integer = dataSet.Tables(0).Columns.Count
            Dim columnWidths As New List(Of Integer)()

            ' Hitung lebar kolom
            For Each col As DataColumn In dataSet.Tables(0).Columns
                Dim colWidth As Integer = CInt(e.Graphics.MeasureString(col.ColumnName, New Font("Arial", 10, FontStyle.Bold)).Width) + 10
                columnWidths.Add(colWidth)

                ' Jika lebar kolom data lebih besar daripada lebar kolom header, gunakan lebar kolom data
                Dim dataColWidth As Integer = CInt(e.Graphics.MeasureString(dataSet.Tables(0).Rows(0)(col).ToString(), New Font("Arial", 10)).Width) + 10
                If dataColWidth > colWidth Then
                    columnWidths(columnWidths.Count - 1) = dataColWidth
                End If
            Next
            ' Tampilkan header kolom
            For j As Integer = 0 To columnCount - 1
                e.Graphics.DrawString(dataSet.Tables(0).Columns(j).ColumnName, New Font("Arial", 10, FontStyle.Bold), Brushes.Black, leftMargin, yPos)
                leftMargin += columnWidths(j)
            Next

            ' Add more space after header (adjust the value as needed)
            yPos += 25
            leftMargin = e.MarginBounds.Left
            ' Tampilkan data dalam bentuk tabel
            For i As Integer = 0 To dataSet.Tables(0).Rows.Count - 1
                For j As Integer = 0 To columnCount - 1
                    e.Graphics.DrawString(dataSet.Tables(0).Rows(i)(j).ToString(), New Font("Arial", 10), Brushes.Black, leftMargin, yPos)
                    leftMargin += columnWidths(j)
                Next
                yPos += 15 ' Add some space after each row
                leftMargin = e.MarginBounds.Left ' Reset leftMargin for the next row

                ' Jika mencapai akhir halaman, lanjutkan ke halaman berikutnya
                If yPos + 15 > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Exit Sub
                End If
            Next

            ' Tampilkan footer dengan informasi tambahan
            yPos += 20
            e.Graphics.DrawString($"Ditampilkan oleh {My.User.Name}", New Font("Arial", 8), Brushes.Black, e.MarginBounds.Left, yPos)
            yPos += 15
            e.Graphics.DrawString($"Tanggal Cetak: {DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss")}", New Font("Arial", 8), Brushes.Black, e.MarginBounds.Left, yPos)
        End Using

        ' Tutup koneksi setelah selesai
        tutup()
    End Sub

    Private Sub DetailPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class