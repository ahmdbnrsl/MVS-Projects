<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Penjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Penjualan))
        Dim No_FakturLabel As System.Windows.Forms.Label
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim PelagganLabel As System.Windows.Forms.Label
        Dim BarangLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PenjualanDataSet = New AhmadBeniRusli.penjualanDataSet()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanTableAdapter = New AhmadBeniRusli.penjualanDataSetTableAdapters.PenjualanTableAdapter()
        Me.TableAdapterManager = New AhmadBeniRusli.penjualanDataSetTableAdapters.TableAdapterManager()
        Me.PenjualanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PenjualanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.No_FakturTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PelagganTextBox = New System.Windows.Forms.TextBox()
        Me.BarangTextBox = New System.Windows.Forms.TextBox()
        Me.UnitTextBox = New System.Windows.Forms.TextBox()
        Me.HargaTextBox = New System.Windows.Forms.TextBox()
        Me.PenjualanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        No_FakturLabel = New System.Windows.Forms.Label()
        TanggalLabel = New System.Windows.Forms.Label()
        PelagganLabel = New System.Windows.Forms.Label()
        BarangLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenjualanBindingNavigator.SuspendLayout()
        CType(Me.PenjualanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA PENJUALAN"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(765, 351)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(HargaLabel)
        Me.TabPage1.Controls.Add(Me.HargaTextBox)
        Me.TabPage1.Controls.Add(UnitLabel)
        Me.TabPage1.Controls.Add(Me.UnitTextBox)
        Me.TabPage1.Controls.Add(BarangLabel)
        Me.TabPage1.Controls.Add(Me.BarangTextBox)
        Me.TabPage1.Controls.Add(PelagganLabel)
        Me.TabPage1.Controls.Add(Me.PelagganTextBox)
        Me.TabPage1.Controls.Add(TanggalLabel)
        Me.TabPage1.Controls.Add(Me.TanggalDateTimePicker)
        Me.TabPage1.Controls.Add(No_FakturLabel)
        Me.TabPage1.Controls.Add(Me.No_FakturTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(757, 325)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.PenjualanDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(757, 325)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Browse"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PenjualanDataSet
        '
        Me.PenjualanDataSet.DataSetName = "penjualanDataSet"
        Me.PenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "Penjualan"
        Me.PenjualanBindingSource.DataSource = Me.PenjualanDataSet
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PenjualanTableAdapter = Me.PenjualanTableAdapter
        Me.TableAdapterManager.UpdateOrder = AhmadBeniRusli.penjualanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PenjualanBindingNavigator
        '
        Me.PenjualanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PenjualanBindingNavigator.BindingSource = Me.PenjualanBindingSource
        Me.PenjualanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PenjualanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PenjualanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PenjualanBindingNavigatorSaveItem})
        Me.PenjualanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PenjualanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PenjualanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PenjualanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PenjualanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PenjualanBindingNavigator.Name = "PenjualanBindingNavigator"
        Me.PenjualanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PenjualanBindingNavigator.Size = New System.Drawing.Size(754, 25)
        Me.PenjualanBindingNavigator.TabIndex = 2
        Me.PenjualanBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PenjualanBindingNavigatorSaveItem
        '
        Me.PenjualanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PenjualanBindingNavigatorSaveItem.Image = CType(resources.GetObject("PenjualanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PenjualanBindingNavigatorSaveItem.Name = "PenjualanBindingNavigatorSaveItem"
        Me.PenjualanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PenjualanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'No_FakturLabel
        '
        No_FakturLabel.AutoSize = True
        No_FakturLabel.Location = New System.Drawing.Point(6, 13)
        No_FakturLabel.Name = "No_FakturLabel"
        No_FakturLabel.Size = New System.Drawing.Size(57, 13)
        No_FakturLabel.TabIndex = 0
        No_FakturLabel.Text = "No Faktur:"
        '
        'No_FakturTextBox
        '
        Me.No_FakturTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanBindingSource, "No_Faktur", True))
        Me.No_FakturTextBox.Location = New System.Drawing.Point(69, 10)
        Me.No_FakturTextBox.Name = "No_FakturTextBox"
        Me.No_FakturTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_FakturTextBox.TabIndex = 1
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Location = New System.Drawing.Point(10, 39)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(49, 13)
        TanggalLabel.TabIndex = 2
        TanggalLabel.Text = "Tanggal:"
        '
        'TanggalDateTimePicker
        '
        Me.TanggalDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PenjualanBindingSource, "Tanggal", True))
        Me.TanggalDateTimePicker.Location = New System.Drawing.Point(65, 35)
        Me.TanggalDateTimePicker.Name = "TanggalDateTimePicker"
        Me.TanggalDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TanggalDateTimePicker.TabIndex = 3
        '
        'PelagganLabel
        '
        PelagganLabel.AutoSize = True
        PelagganLabel.Location = New System.Drawing.Point(10, 67)
        PelagganLabel.Name = "PelagganLabel"
        PelagganLabel.Size = New System.Drawing.Size(55, 13)
        PelagganLabel.TabIndex = 4
        PelagganLabel.Text = "Pelaggan:"
        '
        'PelagganTextBox
        '
        Me.PelagganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanBindingSource, "Pelaggan", True))
        Me.PelagganTextBox.Location = New System.Drawing.Point(71, 64)
        Me.PelagganTextBox.Name = "PelagganTextBox"
        Me.PelagganTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PelagganTextBox.TabIndex = 5
        '
        'BarangLabel
        '
        BarangLabel.AutoSize = True
        BarangLabel.Location = New System.Drawing.Point(15, 95)
        BarangLabel.Name = "BarangLabel"
        BarangLabel.Size = New System.Drawing.Size(44, 13)
        BarangLabel.TabIndex = 6
        BarangLabel.Text = "Barang:"
        '
        'BarangTextBox
        '
        Me.BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanBindingSource, "Barang", True))
        Me.BarangTextBox.Location = New System.Drawing.Point(65, 92)
        Me.BarangTextBox.Name = "BarangTextBox"
        Me.BarangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BarangTextBox.TabIndex = 7
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Location = New System.Drawing.Point(21, 126)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(29, 13)
        UnitLabel.TabIndex = 8
        UnitLabel.Text = "Unit:"
        '
        'UnitTextBox
        '
        Me.UnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanBindingSource, "Unit", True))
        Me.UnitTextBox.Location = New System.Drawing.Point(56, 123)
        Me.UnitTextBox.Name = "UnitTextBox"
        Me.UnitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UnitTextBox.TabIndex = 9
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(36, 161)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(39, 13)
        HargaLabel.TabIndex = 10
        HargaLabel.Text = "Harga:"
        '
        'HargaTextBox
        '
        Me.HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PenjualanBindingSource, "Harga", True))
        Me.HargaTextBox.Location = New System.Drawing.Point(81, 158)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HargaTextBox.TabIndex = 11
        '
        'PenjualanDataGridView
        '
        Me.PenjualanDataGridView.AutoGenerateColumns = False
        Me.PenjualanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PenjualanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PenjualanDataGridView.DataSource = Me.PenjualanBindingSource
        Me.PenjualanDataGridView.Location = New System.Drawing.Point(3, 0)
        Me.PenjualanDataGridView.Name = "PenjualanDataGridView"
        Me.PenjualanDataGridView.Size = New System.Drawing.Size(749, 357)
        Me.PenjualanDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No_Faktur"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No_Faktur"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tanggal"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Pelaggan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pelaggan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Barang"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Unit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Harga"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Data_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 367)
        Me.Controls.Add(Me.PenjualanBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Data_Penjualan"
        Me.Text = "Data_Penjualan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenjualanBindingNavigator.ResumeLayout(False)
        Me.PenjualanBindingNavigator.PerformLayout()
        CType(Me.PenjualanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PenjualanDataSet As AhmadBeniRusli.penjualanDataSet
    Friend WithEvents PenjualanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PenjualanTableAdapter As AhmadBeniRusli.penjualanDataSetTableAdapters.PenjualanTableAdapter
    Friend WithEvents TableAdapterManager As AhmadBeniRusli.penjualanDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PenjualanBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PenjualanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents No_FakturTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PelagganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PenjualanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
