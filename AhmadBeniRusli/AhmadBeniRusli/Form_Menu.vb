﻿Public Class Form_Menu

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
       
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
    End Sub

    Private Sub DataPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        Data_Penjualan.MdiParent = Me
        Data_Penjualan.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        Laporan.MdiParent = Me
        Laporan.Show()
    End Sub
End Class
