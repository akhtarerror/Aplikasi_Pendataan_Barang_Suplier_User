Imports Microsoft.Reporting.WinForms

Public Class View_Supplier
    Private Sub View_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DataSet1.supplier)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Me.SupplierTableAdapter.Fill(Me.DataSet1.supplier)
        Me.ReportViewer1.LocalReport.DataSources.Clear()

        ' Correct the table name to "user" (lowercase)
        Dim reportDataSource As New ReportDataSource("DataSet1", Me.DataSet1.Tables("supplier"))

        Me.ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class