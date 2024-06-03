Public Class Supplier
    Private WithEvents MyBaseBindingNavigatorSaveItem As New ToolStripButton()

    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'DataSet1.supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DataSet1.supplier)

        ' Manually create MyBaseBindingNavigatorSaveItem if it doesn't exist
        If MyBaseBindingNavigatorSaveItem Is Nothing Then
            MyBaseBindingNavigatorSaveItem = New ToolStripButton()
        End If

        ' Attach the event handler manually
        AddHandler MyBaseBindingNavigatorSaveItem.Click, AddressOf SupplierBindingNavigatorSaveItem_Click
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Me.Validate()
        SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Data Berhasil Disimpan")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Me.Validate()
        Me.SupplierBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Data Berhasil Dihapus")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KodeTextBox.Clear()
        NamaTextBox.Clear()
        AlamatTextBox.Clear()
        TeleponTextBox.Clear()
        FaxTextBox.Clear()
        EmailTextBox.Clear()
        ContactPersonTextBox.Clear()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        End
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        SupplierBindingSource.AddNew()
        KodeTextBox.Text = SupplierBindingSource.Count
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        SupplierBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        SupplierBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        SupplierBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        SupplierBindingSource.MoveLast()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim code As String
        code = InputBox("Cari kode")
        SupplierBindingSource.Filter = "Kode='" & code & "'"
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) 
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim View_Suppplier As New View_Supplier()
        View_Supplier.Show()
        Me.Hide()
    End Sub
End Class
