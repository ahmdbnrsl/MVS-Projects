Public Class Laporan

    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'penjualanDataSet1.Penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.penjualanDataSet1.Penjualan)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class