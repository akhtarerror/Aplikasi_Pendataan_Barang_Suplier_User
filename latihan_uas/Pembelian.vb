Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Engines.SM2Engine
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes

Public Class Pembelian
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim kode As String
    Dim stok, jumlah, harga, total As Long
    Dim grandtotal, subtotal, kembali, bayar, diskon As Long
    Dim fktr, tgl As String
    Dim totalhargapembelian As Long
    Dim totalbelibarang As Long
    Dim panjang As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Isi Kode Barang dlo coy", "oi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            koneksi()
            cmd = New MySqlCommand("select * from barang where Kode = '" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                kode = rd.Item("Kode")
                TextBox2.Text = rd.Item("Nama")
                stok = rd.Item("Stok")
                jumlah = 1
                harga = rd.Item("HargaBeli")
                total = jumlah * harga
                TextBox3.Text = jumlah
                TextBox4.Text = harga
                TextBox4.Text = total
                TextBox4.Focus()
            Else
                MessageBox.Show("Kode barang gada", "oi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
            End If
        End If

    End Sub
    Sub printfaktur()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 550, 700)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox7.Text = "" Then
            MessageBox.Show("bayar dulu oi", "oi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox7.Text < total Then
            MessageBox.Show("kerja gih duid kurang", "oi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            bayar = TextBox7.Text
            MessageBox.Show("Berhasil nambah stok", "oi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            faktur()
            simpan()
            printfaktur()
            ResetForm()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pindah()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            jumlah = 0
            total = jumlah * harga
            TextBox4.Text = total
        Else
            jumlah = TextBox3.Text
            total = jumlah * harga
            TextBox4.Text = total

        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim f As Long
        If TextBox7.Text = "" Or Not IsNumeric(TextBox7.Text) Then
            Exit Sub
        End If
        f = TextBox7.Text
        TextBox7.Text = Format(f, "##,##0")
        TextBox7.SelectionStart = Len(TextBox7.Text)

        Dim hitung As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(4).Value

        Next

        subtotal = Format(hitung, "##,##0")
        total = hitung
        TextBox6.Text = Format(TextBox7.Text - total, "##,##0")

        total = Format(total, "##,##0")
        kembali = Format(TextBox7.Text - total, "##,##0")
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        ' Setting Font
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)
        Dim f8b As New Font("Times New Roman", 9, FontStyle.Bold)

        ' Setting Margin
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim tinggi As Integer
        Dim i As Long
        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        Dim kiri As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center
        kiri.Alignment = StringAlignment.Near

        ' Line Separator
        Dim garis As String = "-----------------------------------------------------------------------"

        ' Title
        e.Graphics.DrawString("Invoice", f14, Brushes.Black, e.PageBounds.Width / 2, topMargin, tengah)
        topMargin += 20
        e.Graphics.DrawString("Penambahan Stok", f10, Brushes.Black, e.PageBounds.Width / 2, topMargin, tengah)

        ' Line Separator
        topMargin += 20
        e.Graphics.DrawString(garis, f10, Brushes.Black, leftMargin, topMargin)

        ' Table Headers
        topMargin += 20
        e.Graphics.DrawString("Nama", f8b, Brushes.Black, leftMargin, topMargin)
        e.Graphics.DrawString("Jumlah", f8b, Brushes.Black, leftMargin + 80, topMargin)
        e.Graphics.DrawString("Harga 1 Pcs", f8b, Brushes.Black, leftMargin + 160, topMargin)
        e.Graphics.DrawString("Harga", f8b, Brushes.Black, leftMargin + 240, topMargin)

        ' Line Separator
        topMargin += 20
        e.Graphics.DrawString(garis, f10, Brushes.Black, leftMargin, topMargin)
        Dim totaljumlah As Long = 0
        ' Populate the table with data
        For row As Integer = 0 To DataGridView1.RowCount - 1
            topMargin += 15 ' Move down for the next line

            ' Check if the cell value is not Nothing before accessing it
            Dim kodeBarang As String = If(DataGridView1.Rows(row).Cells(1).Value IsNot Nothing, DataGridView1.Rows(row).Cells(1).Value.ToString(), "")
            Dim namaBarang As String = If(DataGridView1.Rows(row).Cells(2).Value IsNot Nothing, DataGridView1.Rows(row).Cells(2).Value.ToString(), "")
            Dim jumlah As String = If(DataGridView1.Rows(row).Cells(3).Value IsNot Nothing, DataGridView1.Rows(row).Cells(3).Value.ToString(), "")
            Dim harga As String = If(DataGridView1.Rows(row).Cells(4).Value IsNot Nothing, DataGridView1.Rows(row).Cells(4).Value.ToString(), "")

            ' Draw each column at specific positions
            e.Graphics.DrawString(kodeBarang, f10, Brushes.Black, leftMargin, topMargin + tinggi)
            e.Graphics.DrawString(namaBarang, f10, Brushes.Black, leftMargin + 80, topMargin + tinggi)
            e.Graphics.DrawString(jumlah, f10, Brushes.Black, leftMargin + 160, topMargin + tinggi)

            ' Format harga as currency and align to the right
            i = DataGridView1.Rows(row).Cells(4).Value
            DataGridView1.Rows(row).Cells(4).Value = Format(i, "##,##0")
            e.Graphics.DrawString(harga.ToString, f10, Brushes.Black, leftMargin + 240, topMargin + tinggi)



        Next

        topMargin += 15
        hitungfaktur()
        e.Graphics.DrawString(garis, f10, Brushes.Black, leftMargin, topMargin)
        e.Graphics.DrawString("Total : " & Format(totalhargapembelian, "##,##0"), f10b, Brushes.Black, leftMargin, topMargin + 15)


        ' Additional Notes
        topMargin += 40

        e.Graphics.DrawString("Notes:", f10b, Brushes.Black, leftMargin, topMargin + 40)

        e.Graphics.DrawString("Thank you for your purchase!", f10, Brushes.Black, leftMargin, topMargin + 15)

        ' Closing Greeting
        topMargin += 40

        e.Graphics.DrawString("Thank You!", f14, Brushes.Black, e.PageBounds.Width / 2, topMargin + 40, tengah)
    End Sub

    Private Sub TextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Sub hitungfaktur()
        Dim hitung As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(4).Value

        Next
        totalhargapembelian = hitung
        Dim hitung2 As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung2 + DataGridView1.Rows(baris).Cells(3).Value

        Next
        totalbelibarang = hitung


    End Sub


    Sub faktur()
        Dim tgl As String = Format(Today, "yyMMdd")
        koneksi()
        cmd = New MySqlCommand("select * from pembelian where left(faktur,6)='" & tgl & "'order by faktur desc", conn)
        rd = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            fktr = Val(Microsoft.VisualBasic.Mid(rd.Item("faktur").ToString, 7, 4)) + 1
            If Len(fktr) = 1 Then
                fktr = tgl + "000" & fktr
            ElseIf Len(fktr) - 2 Then
                fktr = tgl + "00" & fktr
            ElseIf Len(fktr) = 3 Then
                fktr = tgl + "0" & fktr
            ElseIf Len(fktr) = 4 Then
                fktr = tgl & fktr
            End If
        Else
            fktr = tgl = "000"
        End If
        tutup()

    End Sub

    Sub ResetForm()
        ' Reset TextBox dan DataGridView
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        DataGridView1.Rows.Clear()

        ' Reset variabel
        kode = ""
        stok = 0
        jumlah = 0
        harga = 0
        total = 0
        grandtotal = 0
        subtotal = 0
        kembali = 0
        bayar = 0
        diskon = 0
        fktr = ""
        tgl = ""
        totalhargapembelian = 0
        totalbelibarang = 0
        panjang = 0
    End Sub

    Sub simpan()
        tgl = Format(Now, "yyyy/MM/dd HH:mm:ss")
        Try
            ' Open the connection once before the loop
            koneksi()

            ' Save to the 'transaksi' table
            str = "INSERT INTO pembelian (tgl, total, bayar, kembali) VALUES (@tgl, @total, @bayar, @kembali)"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = str
                .Parameters.Add("tgl", MySqlDbType.DateTime).Value = tgl
                .Parameters.Add("total", MySqlDbType.Int64).Value = total
                .Parameters.Add("bayar", MySqlDbType.Int64).Value = bayar
                .Parameters.Add("kembali", MySqlDbType.Int64).Value = kembali
                .ExecuteNonQuery()
            End With

            ' Get the last inserted faktur value
            Dim lastFaktur As Integer
            str = "SELECT LAST_INSERT_ID();"
            cmd = conn.CreateCommand()
            cmd.CommandText = str
            lastFaktur = Convert.ToInt32(cmd.ExecuteScalar())

            ' Insert into 'detailtransaksi' using the last inserted faktur
            For baris As Long = 0 To DataGridView1.RowCount - 1
                Try
                    ' Insert into 'detailtransaksi'
                    str = "INSERT INTO detailtransaksibeli (nama_barang, jumlah, harga_satuan, total, faktur) VALUES (@nama_barang, @jumlah, @harga_satuan, @total, @faktur)"
                    cmd = conn.CreateCommand
                    With cmd
                        .CommandText = str
                        .Parameters.Add("nama_barang", MySqlDbType.String).Value = DataGridView1.Rows(baris).Cells(1).Value

                        Dim jumlahValue As Object = DataGridView1.Rows(baris).Cells(2).Value
                        If IsNumeric(jumlahValue) Then
                            .Parameters.Add("jumlah", MySqlDbType.Int64).Value = Convert.ToInt64(jumlahValue)
                        Else
                            ' Tindakan yang sesuai jika nilai tidak numerik
                            Continue For ' Skip this iteration and go to the next row
                        End If

                        Dim hargaSatuanValue As Object = DataGridView1.Rows(baris).Cells(3).Value
                        If IsNumeric(hargaSatuanValue) Then
                            .Parameters.Add("harga_satuan", MySqlDbType.Int64).Value = Convert.ToInt64(hargaSatuanValue)
                        Else
                            ' Tindakan yang sesuai jika nilai tidak numerik
                            Continue For ' Skip this iteration and go to the next row
                        End If

                        Dim totalValue As Object = DataGridView1.Rows(baris).Cells(4).Value
                        If IsNumeric(totalValue) Then
                            .Parameters.Add("total", MySqlDbType.Int64).Value = Convert.ToInt64(totalValue)
                        Else
                            ' Tindakan yang sesuai jika nilai tidak numerik
                            Continue For ' Skip this iteration and go to the next row
                        End If

                        .Parameters.Add("faktur", MySqlDbType.Int32).Value = lastFaktur
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    ' Log or display the error information to identify the problematic row or cell
                    MessageBox.Show($"Error on row {baris + 1}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            ' Deduct stock
            For baris As Long = 0 To DataGridView1.RowCount - 1
                Try
                    ' Read stock value
                    cmd = New MySqlCommand("SELECT stok FROM barang WHERE Kode = '" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                    Dim stk As Long = Convert.ToInt64(cmd.ExecuteScalar())

                    ' Update stock
                    str = "UPDATE barang SET stok = @stok WHERE Kode = @kode"
                    cmd = conn.CreateCommand
                    With cmd
                        .CommandText = str
                        .Parameters.Add("kode", MySqlDbType.String).Value = DataGridView1.Rows(baris).Cells(0).Value
                        .Parameters.Add("stok", MySqlDbType.Int64).Value = stk + DataGridView1.Rows(baris).Cells(2).Value
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    ' Log or display the error information to identify the problematic row or cell
                    MessageBox.Show($"Error on row baranggana {baris + 1}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

        Catch ex As Exception
            ' Log or display the error information
            MsgBox(ex.Message)
        Finally
            ' Close the connection after the loop
            tutup()
        End Try
    End Sub
    Sub pindah()
        Dim jum, har, tot As Long
        jum = TextBox3.Text
        har = harga
        tot = total

        DataGridView1.AllowUserToAddRows = True
        DataGridView1.RowCount = DataGridView1.RowCount + 1
        DataGridView1(0, DataGridView1.RowCount - 2).Value = kode
        DataGridView1(1, DataGridView1.RowCount - 2).Value = TextBox2.Text
        DataGridView1(2, DataGridView1.RowCount - 2).Value = jum
        DataGridView1(3, DataGridView1.RowCount - 2).Value = har
        DataGridView1(4, DataGridView1.RowCount - 2).Value = tot
        DataGridView1.AllowUserToAddRows = False

        Dim b_atasjumlah As Long
        For barisatas As Long = 0 To DataGridView1.RowCount - 1
            For barisbawah As Long = barisatas + 1 To DataGridView1.RowCount - 1
                b_atasjumlah = DataGridView1.Rows(barisatas).Cells(2).Value

                If DataGridView1.Rows(barisbawah).Cells(0).Value = DataGridView1.Rows(barisatas).Cells(0).Value Then
                    Dim totjumlah As Long
                    totjumlah = b_atasjumlah + DataGridView1.Rows(barisbawah).Cells(2).Value
                    If totjumlah > stok Then
                        MessageBox.Show("Jumlah lebih besar dari stok yang ada" & vbCrLf _
                                & "Stok hanya " & stok, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        DataGridView1.Rows(barisatas).Cells(2).Value = stok
                        DataGridView1.Rows(barisatas).Cells(3).Value = DataGridView1.Rows(barisbawah).Cells(3).Value
                        DataGridView1.Rows(barisatas).Cells(4).Value = (DataGridView1.Rows(barisatas).Cells(2).Value * DataGridView1.Rows(barisatas).Cells(3).Value)
                        DataGridView1.CurrentCell = DataGridView1.Rows(barisbawah).Cells(2)
                        hapusrow()
                    Else
                        DataGridView1.Rows(barisatas).Cells(2).Value = b_atasjumlah + DataGridView1.Rows(barisbawah).Cells(2).Value
                        DataGridView1.Rows(barisatas).Cells(3).Value = DataGridView1.Rows(barisbawah).Cells(3).Value
                        DataGridView1.Rows(barisatas).Cells(4).Value = (DataGridView1.Rows(barisatas).Cells(2).Value * DataGridView1.Rows(barisatas).Cells(3).Value)
                        DataGridView1.CurrentCell = DataGridView1.Rows(barisbawah).Cells(2)
                        hapusrow()
                    End If
                End If
            Next


        Next
        hitunggrandtotal()
    End Sub
    Sub hapusrow()
        If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
    End Sub
    Sub hitunggrandtotal()
        Dim hitung As Long = 0
        For baris As Long = 0 To DataGridView1.RowCount - 1
            hitung = hitung + DataGridView1.Rows(baris).Cells(4).Value
        Next
        subtotal = hitung
        TextBox5.Text = "Rp. " + Format(hitung, "##,##0")

    End Sub
    Sub ubahpanjang()
        Dim rowcount As Integer
        panjang = 0

        rowcount = DataGridView1.Rows.Count
        panjang = rowcount * 15
        panjang = panjang + 200
    End Sub


End Class