﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.penjualanDataSet1 = New AhmadBeniRusli.penjualanDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PenjualanTableAdapter = New AhmadBeniRusli.penjualanDataSet1TableAdapters.PenjualanTableAdapter()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.penjualanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "Penjualan"
        Me.PenjualanBindingSource.DataSource = Me.penjualanDataSet1
        '
        'penjualanDataSet1
        '
        Me.penjualanDataSet1.DataSetName = "penjualanDataSet1"
        Me.penjualanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PenjualanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AhmadBeniRusli.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(639, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.penjualanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents penjualanDataSet1 As AhmadBeniRusli.penjualanDataSet1
    Friend WithEvents PenjualanTableAdapter As AhmadBeniRusli.penjualanDataSet1TableAdapters.PenjualanTableAdapter
End Class
