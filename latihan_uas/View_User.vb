Imports Microsoft.Reporting.WinForms

Public Class View_User
    Private Sub View_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.DataSet1.user)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Me.UserTableAdapter.Fill(Me.DataSet1.user)
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        ' Correct the table name to "user" (lowercase)
        Dim reportDataSource As New ReportDataSource("DataSet1", Me.DataSet1.Tables("user"))

        Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class