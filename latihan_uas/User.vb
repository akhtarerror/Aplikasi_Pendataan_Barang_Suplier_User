﻿Imports Microsoft.Reporting.WinForms

Public Class User
    Private WithEvents MyBaseBindingNavigatorSaveItem As New ToolStripButton()

    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TODO: This line of code loads data into the 'DataSet1.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DataSet1.user)

        ' Manually create MyBaseBindingNavigatorSaveItem if it doesn't exist
        If MyBaseBindingNavigatorSaveItem Is Nothing Then
            MyBaseBindingNavigatorSaveItem = New ToolStripButton()
        End If

        ' Attach the event handler manually
        AddHandler MyBaseBindingNavigatorSaveItem.Click, AddressOf UserBindingNavigatorSaveItem_Click
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Me.Validate()
        UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Data Berhasil Disimpan")
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Me.Validate()
        Me.UserBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DataSet1)
        MsgBox("Data Berhasil Dihapus")
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KodeTextBox.Clear()
        NamaTextBox.Clear()
        PasswordTextBox.Clear()
        StatusComboBox.SelectedIndex = -1
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        End
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        UserBindingSource.AddNew()
        KodeTextBox.Text = UserBindingSource.Count
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        UserBindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        UserBindingSource.MoveNext()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        UserBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        UserBindingSource.MoveLast()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim code As String
        code = InputBox("Cari kode")
        UserBindingSource.Filter = "Kode='" & code & "'"
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        Home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim View_User As New View_User()
        View_User.Show()
        Me.Hide()
    End Sub
End Class