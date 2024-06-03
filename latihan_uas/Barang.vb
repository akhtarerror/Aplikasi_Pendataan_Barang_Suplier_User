Public Class Barang
    Private WithEvents MyBaseBindingNavigatorSaveItem As New ToolStripButton()

    Private Sub BarangBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'DataSet1.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataSet1.barang)

        ' Manually create MyBaseBindingNavigatorSaveItem if it doesn't exist
        If MyBaseBindingNavigatorSaveItem Is Nothing Then
            MyBaseBindingNavigatorSaveItem = New ToolStripButton()
        End If

        ' Attach the event handler manually
        AddHandler MyBaseBindingNavigatorSaveItem.Click, AddressOf BarangBindingNavigatorSaveItem_Click
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Me.Validate()
        BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Data Berhasil Disimpan")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Me.Validate()
        Me.BarangBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Data Berhasil Dihapus")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KodeTextBox.Clear()
        NamaTextBox.Clear()
        SatuanComboBox.SelectedIndex = -1
        JenisBarangComboBox.SelectedIndex = -1
        HargaBeliTextBox.Clear()
        HargaJualTextBox.Clear()
        StokTextBox.Clear()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        End
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        BarangBindingSource.AddNew()
        KodeTextBox.Text = BarangBindingSource.Count
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BarangBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        BarangBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BarangBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BarangBindingSource.MoveLast()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim code As String
        code = InputBox("Cari kode")
        BarangBindingSource.Filter = "Kode='" & code & "'"
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) 
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim View_Barang As New View_Barang()
        View_Barang.Show()
        Me.Hide()
    End Sub
End Class
