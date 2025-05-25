Public Class Data_Penjualan

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PenjualanBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PenjualanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PenjualanDataSet)

    End Sub

    Private Sub Data_Penjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanDataSet.Penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.PenjualanDataSet.Penjualan)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PelagganLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


End Class