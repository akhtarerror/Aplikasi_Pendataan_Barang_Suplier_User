Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub koneksi()
        Try
            Dim str As String = "Server=localhost;user id=root;password=;database=database_minimarket"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                MessageBox.Show("Database Error")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub tutup()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Module