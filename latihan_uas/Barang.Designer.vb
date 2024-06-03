<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim KodeLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim SatuanLabel As System.Windows.Forms.Label
        Dim JenisBarangLabel As System.Windows.Forms.Label
        Dim HargaBeliLabel As System.Windows.Forms.Label
        Dim HargaJualLabel As System.Windows.Forms.Label
        Dim StokLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barang))
        Me.DataSet1 = New latihan_uas.DataSet1()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New latihan_uas.DataSet1TableAdapters.barangTableAdapter()
        Me.TableAdapterManager = New latihan_uas.DataSet1TableAdapters.TableAdapterManager()
        Me.BarangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BarangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.KodeTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.SatuanComboBox = New System.Windows.Forms.ComboBox()
        Me.JenisBarangComboBox = New System.Windows.Forms.ComboBox()
        Me.HargaBeliTextBox = New System.Windows.Forms.TextBox()
        Me.HargaJualTextBox = New System.Windows.Forms.TextBox()
        Me.StokTextBox = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.BarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        KodeLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        SatuanLabel = New System.Windows.Forms.Label()
        JenisBarangLabel = New System.Windows.Forms.Label()
        HargaBeliLabel = New System.Windows.Forms.Label()
        HargaJualLabel = New System.Windows.Forms.Label()
        StokLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarangBindingNavigator.SuspendLayout()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KodeLabel
        '
        KodeLabel.AutoSize = True
        KodeLabel.Location = New System.Drawing.Point(12, 42)
        KodeLabel.Name = "KodeLabel"
        KodeLabel.Size = New System.Drawing.Size(86, 16)
        KodeLabel.TabIndex = 1
        KodeLabel.Text = "Kode Barang"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(292, 42)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(91, 16)
        NamaLabel.TabIndex = 3
        NamaLabel.Text = "Nama Barang"
        '
        'SatuanLabel
        '
        SatuanLabel.AutoSize = True
        SatuanLabel.Location = New System.Drawing.Point(591, 40)
        SatuanLabel.Name = "SatuanLabel"
        SatuanLabel.Size = New System.Drawing.Size(49, 16)
        SatuanLabel.TabIndex = 5
        SatuanLabel.Text = "Satuan"
        '
        'JenisBarangLabel
        '
        JenisBarangLabel.AutoSize = True
        JenisBarangLabel.Location = New System.Drawing.Point(9, 85)
        JenisBarangLabel.Name = "JenisBarangLabel"
        JenisBarangLabel.Size = New System.Drawing.Size(86, 16)
        JenisBarangLabel.TabIndex = 7
        JenisBarangLabel.Text = "Jenis Barang"
        '
        'HargaBeliLabel
        '
        HargaBeliLabel.AutoSize = True
        HargaBeliLabel.Location = New System.Drawing.Point(569, 85)
        HargaBeliLabel.Name = "HargaBeliLabel"
        HargaBeliLabel.Size = New System.Drawing.Size(71, 16)
        HargaBeliLabel.TabIndex = 9
        HargaBeliLabel.Text = "Harga Beli"
        '
        'HargaJualLabel
        '
        HargaJualLabel.AutoSize = True
        HargaJualLabel.Location = New System.Drawing.Point(307, 88)
        HargaJualLabel.Name = "HargaJualLabel"
        HargaJualLabel.Size = New System.Drawing.Size(73, 16)
        HargaJualLabel.TabIndex = 11
        HargaJualLabel.Text = "Harga Jual"
        '
        'StokLabel
        '
        StokLabel.AutoSize = True
        StokLabel.Location = New System.Drawing.Point(61, 134)
        StokLabel.Name = "StokLabel"
        StokLabel.Size = New System.Drawing.Size(34, 16)
        StokLabel.TabIndex = 13
        StokLabel.Text = "Stok"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.DataSet1
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.supplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = latihan_uas.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'BarangBindingNavigator
        '
        Me.BarangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BarangBindingNavigator.BindingSource = Me.BarangBindingSource
        Me.BarangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BarangBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BarangBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BarangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BarangBindingNavigatorSaveItem})
        Me.BarangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BarangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BarangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BarangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BarangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BarangBindingNavigator.Name = "BarangBindingNavigator"
        Me.BarangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BarangBindingNavigator.Size = New System.Drawing.Size(868, 31)
        Me.BarangBindingNavigator.TabIndex = 0
        Me.BarangBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BarangBindingNavigatorSaveItem
        '
        Me.BarangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BarangBindingNavigatorSaveItem.Image = CType(resources.GetObject("BarangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BarangBindingNavigatorSaveItem.Name = "BarangBindingNavigatorSaveItem"
        Me.BarangBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.BarangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KodeTextBox
        '
        Me.KodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Kode", True))
        Me.KodeTextBox.Location = New System.Drawing.Point(104, 42)
        Me.KodeTextBox.Name = "KodeTextBox"
        Me.KodeTextBox.Size = New System.Drawing.Size(147, 22)
        Me.KodeTextBox.TabIndex = 2
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(389, 39)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(156, 22)
        Me.NamaTextBox.TabIndex = 4
        '
        'SatuanComboBox
        '
        Me.SatuanComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Satuan", True))
        Me.SatuanComboBox.FormattingEnabled = True
        Me.SatuanComboBox.Items.AddRange(New Object() {"UNIT", "KRAT", "DUS", "PCS"})
        Me.SatuanComboBox.Location = New System.Drawing.Point(649, 37)
        Me.SatuanComboBox.Name = "SatuanComboBox"
        Me.SatuanComboBox.Size = New System.Drawing.Size(177, 24)
        Me.SatuanComboBox.TabIndex = 6
        '
        'JenisBarangComboBox
        '
        Me.JenisBarangComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "JenisBarang", True))
        Me.JenisBarangComboBox.FormattingEnabled = True
        Me.JenisBarangComboBox.Items.AddRange(New Object() {"Makanan", "Minuman", "Pakaian", "Elektronik"})
        Me.JenisBarangComboBox.Location = New System.Drawing.Point(104, 82)
        Me.JenisBarangComboBox.Name = "JenisBarangComboBox"
        Me.JenisBarangComboBox.Size = New System.Drawing.Size(147, 24)
        Me.JenisBarangComboBox.TabIndex = 8
        '
        'HargaBeliTextBox
        '
        Me.HargaBeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "HargaBeli", True))
        Me.HargaBeliTextBox.Location = New System.Drawing.Point(649, 82)
        Me.HargaBeliTextBox.Name = "HargaBeliTextBox"
        Me.HargaBeliTextBox.Size = New System.Drawing.Size(177, 22)
        Me.HargaBeliTextBox.TabIndex = 10
        '
        'HargaJualTextBox
        '
        Me.HargaJualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "HargaJual", True))
        Me.HargaJualTextBox.Location = New System.Drawing.Point(389, 85)
        Me.HargaJualTextBox.Name = "HargaJualTextBox"
        Me.HargaJualTextBox.Size = New System.Drawing.Size(156, 22)
        Me.HargaJualTextBox.TabIndex = 12
        '
        'StokTextBox
        '
        Me.StokTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Stok", True))
        Me.StokTextBox.Location = New System.Drawing.Point(104, 131)
        Me.StokTextBox.Name = "StokTextBox"
        Me.StokTextBox.Size = New System.Drawing.Size(147, 22)
        Me.StokTextBox.TabIndex = 14
        '
        'btnTambah
        '
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.Location = New System.Drawing.Point(372, 171)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(85, 74)
        Me.btnTambah.TabIndex = 30
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Image = CType(resources.GetObject("btn_keluar.Image"), System.Drawing.Image)
        Me.btn_keluar.Location = New System.Drawing.Point(281, 171)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(85, 74)
        Me.btn_keluar.TabIndex = 29
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.Location = New System.Drawing.Point(190, 171)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(85, 74)
        Me.btnBatal.TabIndex = 28
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.Location = New System.Drawing.Point(11, 171)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(84, 74)
        Me.btnSimpan.TabIndex = 27
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Image = CType(resources.GetObject("btnHapus.Image"), System.Drawing.Image)
        Me.btnHapus.Location = New System.Drawing.Point(100, 171)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 74)
        Me.btnHapus.TabIndex = 26
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'BarangDataGridView
        '
        Me.BarangDataGridView.AutoGenerateColumns = False
        Me.BarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BarangDataGridView.DataSource = Me.BarangBindingSource
        Me.BarangDataGridView.Location = New System.Drawing.Point(15, 269)
        Me.BarangDataGridView.Name = "BarangDataGridView"
        Me.BarangDataGridView.RowHeadersWidth = 51
        Me.BarangDataGridView.RowTemplate.Height = 24
        Me.BarangDataGridView.Size = New System.Drawing.Size(811, 137)
        Me.BarangDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Kode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Satuan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "JenisBarang"
        Me.DataGridViewTextBoxColumn4.HeaderText = "JenisBarang"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HargaBeli"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HargaBeli"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "HargaJual"
        Me.DataGridViewTextBoxColumn6.HeaderText = "HargaJual"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Stok"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stok"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(566, 411)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(67, 35)
        Me.btnNext.TabIndex = 37
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(279, 411)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(67, 35)
        Me.btnPrev.TabIndex = 36
        Me.btnPrev.Text = "Prev"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(418, 411)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(67, 35)
        Me.btnCari.TabIndex = 35
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(726, 411)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(67, 35)
        Me.btnLast.TabIndex = 34
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(81, 411)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(67, 35)
        Me.btnFirst.TabIndex = 33
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(463, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 74)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Cetak"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 563)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.BarangDataGridView)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(StokLabel)
        Me.Controls.Add(Me.StokTextBox)
        Me.Controls.Add(HargaJualLabel)
        Me.Controls.Add(Me.HargaJualTextBox)
        Me.Controls.Add(HargaBeliLabel)
        Me.Controls.Add(Me.HargaBeliTextBox)
        Me.Controls.Add(JenisBarangLabel)
        Me.Controls.Add(Me.JenisBarangComboBox)
        Me.Controls.Add(SatuanLabel)
        Me.Controls.Add(Me.SatuanComboBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(KodeLabel)
        Me.Controls.Add(Me.KodeTextBox)
        Me.Controls.Add(Me.BarangBindingNavigator)
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarangBindingNavigator.ResumeLayout(False)
        Me.BarangBindingNavigator.PerformLayout()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As DataSet1TableAdapters.barangTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BarangBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BarangBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents KodeTextBox As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents SatuanComboBox As ComboBox
    Friend WithEvents JenisBarangComboBox As ComboBox
    Friend WithEvents HargaBeliTextBox As TextBox
    Friend WithEvents HargaJualTextBox As TextBox
    Friend WithEvents StokTextBox As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents BarangDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents Button1 As Button
End Class
