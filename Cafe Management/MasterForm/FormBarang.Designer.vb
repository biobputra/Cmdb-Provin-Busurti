<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.DataSetBarang = New Cafe_Management.DataSetBarang()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New Cafe_Management.DataSetBarangTableAdapters.BarangTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetBarangTableAdapters.TableAdapterManager()
        Me.BarangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BarangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BarangGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJenis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.JenisBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colNamaBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidSatuanBeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.SatuanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colidSatuanJual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colGambar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNilaiKonversi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.JenisBarangTableAdapter = New Cafe_Management.DataSetBarangTableAdapters.JenisBarangTableAdapter()
        Me.SatuanTableAdapter = New Cafe_Management.DataSetBarangTableAdapters.SatuanTableAdapter()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.idJenisLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.NamaBarangTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idSatuanBeliLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.idSatuanJualLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.GambarPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.NilaiKonversiTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.isSellCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidJenis = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNamaBarang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForGambar = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNilaiKonversi = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidSatuanBeli = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidSatuanJual = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisSell = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarangBindingNavigator.SuspendLayout()
        CType(Me.BarangGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatuanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idJenisLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaBarangTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idSatuanBeliLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idSatuanJualLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NilaiKonversiTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isSellCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNamaBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNilaiKonversi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidSatuanBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidSatuanJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisSell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetBarang
        '
        Me.DataSetBarang.DataSetName = "DataSetBarang"
        Me.DataSetBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.DataSetBarang
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetBarangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarangBindingNavigator
        '
        Me.BarangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BarangBindingNavigator.BindingSource = Me.BarangBindingSource
        Me.BarangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BarangBindingNavigator.DeleteItem = Nothing
        Me.BarangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.BarangBindingNavigatorSaveItem})
        Me.BarangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BarangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BarangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BarangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BarangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BarangBindingNavigator.Name = "BarangBindingNavigator"
        Me.BarangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BarangBindingNavigator.Size = New System.Drawing.Size(588, 25)
        Me.BarangBindingNavigator.TabIndex = 0
        Me.BarangBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Cafe_Management.My.Resources.Resources.BindingNavigatorDeleteItem_Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'BarangBindingNavigatorSaveItem
        '
        Me.BarangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BarangBindingNavigatorSaveItem.Image = CType(resources.GetObject("BarangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BarangBindingNavigatorSaveItem.Name = "BarangBindingNavigatorSaveItem"
        Me.BarangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BarangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BarangGridControl
        '
        Me.BarangGridControl.DataSource = Me.BarangBindingSource
        Me.BarangGridControl.Location = New System.Drawing.Point(12, 155)
        Me.BarangGridControl.MainView = Me.GridView1
        Me.BarangGridControl.Name = "BarangGridControl"
        Me.BarangGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.BarangGridControl.Size = New System.Drawing.Size(564, 318)
        Me.BarangGridControl.TabIndex = 2
        Me.BarangGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDBarang, Me.colidJenis, Me.colNamaBarang, Me.colidSatuanBeli, Me.colidSatuanJual, Me.colGambar, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive, Me.colNilaiKonversi})
        Me.GridView1.GridControl = Me.BarangGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDBarang
        '
        Me.colIDBarang.FieldName = "IDBarang"
        Me.colIDBarang.Name = "colIDBarang"
        '
        'colidJenis
        '
        Me.colidJenis.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidJenis.FieldName = "idJenis"
        Me.colidJenis.Name = "colidJenis"
        Me.colidJenis.Visible = True
        Me.colidJenis.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.JenisBarangBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "JenisBarang"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IdJenisBarang"
        '
        'JenisBarangBindingSource
        '
        Me.JenisBarangBindingSource.DataMember = "JenisBarang"
        Me.JenisBarangBindingSource.DataSource = Me.DataSetBarang
        '
        'colNamaBarang
        '
        Me.colNamaBarang.FieldName = "NamaBarang"
        Me.colNamaBarang.Name = "colNamaBarang"
        Me.colNamaBarang.Visible = True
        Me.colNamaBarang.VisibleIndex = 1
        '
        'colidSatuanBeli
        '
        Me.colidSatuanBeli.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidSatuanBeli.FieldName = "idSatuanBeli"
        Me.colidSatuanBeli.Name = "colidSatuanBeli"
        Me.colidSatuanBeli.Visible = True
        Me.colidSatuanBeli.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.SatuanBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Satuan"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "IDSatuan"
        '
        'SatuanBindingSource
        '
        Me.SatuanBindingSource.DataMember = "Satuan"
        Me.SatuanBindingSource.DataSource = Me.DataSetBarang
        '
        'colidSatuanJual
        '
        Me.colidSatuanJual.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.colidSatuanJual.FieldName = "idSatuanJual"
        Me.colidSatuanJual.Name = "colidSatuanJual"
        Me.colidSatuanJual.Visible = True
        Me.colidSatuanJual.VisibleIndex = 3
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.SatuanBindingSource
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Satuan"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "IDSatuan"
        '
        'colGambar
        '
        Me.colGambar.FieldName = "Gambar"
        Me.colGambar.Name = "colGambar"
        Me.colGambar.Visible = True
        Me.colGambar.VisibleIndex = 4
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        '
        'colNilaiKonversi
        '
        Me.colNilaiKonversi.FieldName = "NilaiKonversi"
        Me.colNilaiKonversi.Name = "colNilaiKonversi"
        Me.colNilaiKonversi.Visible = True
        Me.colNilaiKonversi.VisibleIndex = 5
        '
        'JenisBarangTableAdapter
        '
        Me.JenisBarangTableAdapter.ClearBeforeFill = True
        '
        'SatuanTableAdapter
        '
        Me.SatuanTableAdapter.ClearBeforeFill = True
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.BarangGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.idJenisLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamaBarangTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idSatuanBeliLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idSatuanJualLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.GambarPictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NilaiKonversiTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isSellCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.BarangBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(588, 557)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 477)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(564, 68)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'idJenisLookUpEdit
        '
        Me.idJenisLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "idJenis", True))
        Me.idJenisLookUpEdit.Location = New System.Drawing.Point(94, 12)
        Me.idJenisLookUpEdit.Name = "idJenisLookUpEdit"
        Me.idJenisLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idJenisLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idJenisLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idJenisLookUpEdit.Properties.DataSource = Me.JenisBarangBindingSource
        Me.idJenisLookUpEdit.Properties.DisplayMember = "JenisBarang"
        Me.idJenisLookUpEdit.Properties.NullText = ""
        Me.idJenisLookUpEdit.Properties.ValueMember = "IdJenisBarang"
        Me.idJenisLookUpEdit.Size = New System.Drawing.Size(276, 20)
        Me.idJenisLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idJenisLookUpEdit.TabIndex = 4
        '
        'NamaBarangTextEdit
        '
        Me.NamaBarangTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "NamaBarang", True))
        Me.NamaBarangTextEdit.Location = New System.Drawing.Point(94, 36)
        Me.NamaBarangTextEdit.Name = "NamaBarangTextEdit"
        Me.NamaBarangTextEdit.Size = New System.Drawing.Size(276, 20)
        Me.NamaBarangTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamaBarangTextEdit.TabIndex = 5
        '
        'idSatuanBeliLookUpEdit
        '
        Me.idSatuanBeliLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "idSatuanBeli", True))
        Me.idSatuanBeliLookUpEdit.Location = New System.Drawing.Point(94, 60)
        Me.idSatuanBeliLookUpEdit.Name = "idSatuanBeliLookUpEdit"
        Me.idSatuanBeliLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSatuanBeliLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSatuanBeliLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSatuanBeliLookUpEdit.Properties.DataSource = Me.SatuanBindingSource
        Me.idSatuanBeliLookUpEdit.Properties.DisplayMember = "Satuan"
        Me.idSatuanBeliLookUpEdit.Properties.NullText = ""
        Me.idSatuanBeliLookUpEdit.Properties.ValueMember = "IDSatuan"
        Me.idSatuanBeliLookUpEdit.Size = New System.Drawing.Size(276, 20)
        Me.idSatuanBeliLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idSatuanBeliLookUpEdit.TabIndex = 6
        '
        'idSatuanJualLookUpEdit
        '
        Me.idSatuanJualLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "idSatuanJual", True))
        Me.idSatuanJualLookUpEdit.Location = New System.Drawing.Point(94, 84)
        Me.idSatuanJualLookUpEdit.Name = "idSatuanJualLookUpEdit"
        Me.idSatuanJualLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idSatuanJualLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idSatuanJualLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idSatuanJualLookUpEdit.Properties.DataSource = Me.SatuanBindingSource
        Me.idSatuanJualLookUpEdit.Properties.DisplayMember = "Satuan"
        Me.idSatuanJualLookUpEdit.Properties.NullText = ""
        Me.idSatuanJualLookUpEdit.Properties.ValueMember = "IDSatuan"
        Me.idSatuanJualLookUpEdit.Size = New System.Drawing.Size(276, 20)
        Me.idSatuanJualLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idSatuanJualLookUpEdit.TabIndex = 7
        '
        'GambarPictureEdit
        '
        Me.GambarPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.GambarPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "Gambar", True))
        Me.GambarPictureEdit.Location = New System.Drawing.Point(374, 28)
        Me.GambarPictureEdit.Name = "GambarPictureEdit"
        Me.GambarPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.GambarPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.GambarPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.GambarPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.GambarPictureEdit.Size = New System.Drawing.Size(202, 123)
        Me.GambarPictureEdit.StyleController = Me.DataLayoutControl1
        Me.GambarPictureEdit.TabIndex = 8
        '
        'NilaiKonversiTextEdit
        '
        Me.NilaiKonversiTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "NilaiKonversi", True))
        Me.NilaiKonversiTextEdit.Location = New System.Drawing.Point(94, 108)
        Me.NilaiKonversiTextEdit.Name = "NilaiKonversiTextEdit"
        Me.NilaiKonversiTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.NilaiKonversiTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NilaiKonversiTextEdit.Properties.Mask.EditMask = "G"
        Me.NilaiKonversiTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.NilaiKonversiTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.NilaiKonversiTextEdit.Size = New System.Drawing.Size(276, 20)
        Me.NilaiKonversiTextEdit.StyleController = Me.DataLayoutControl1
        Me.NilaiKonversiTextEdit.TabIndex = 9
        '
        'isSellCheckEdit
        '
        Me.isSellCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.BarangBindingSource, "isSell", True))
        Me.isSellCheckEdit.Location = New System.Drawing.Point(94, 132)
        Me.isSellCheckEdit.Name = "isSellCheckEdit"
        Me.isSellCheckEdit.Properties.Caption = "is Sell"
        Me.isSellCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isSellCheckEdit.Size = New System.Drawing.Size(276, 19)
        Me.isSellCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isSellCheckEdit.TabIndex = 10
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(588, 557)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidJenis, Me.ItemForNamaBarang, Me.ItemForGambar, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.ItemForNilaiKonversi, Me.ItemForidSatuanBeli, Me.ItemForidSatuanJual, Me.ItemForisSell})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(568, 537)
        '
        'ItemForidJenis
        '
        Me.ItemForidJenis.Control = Me.idJenisLookUpEdit
        Me.ItemForidJenis.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidJenis.Name = "ItemForidJenis"
        Me.ItemForidJenis.Size = New System.Drawing.Size(362, 24)
        Me.ItemForidJenis.Text = "Jenis Barang"
        Me.ItemForidJenis.TextSize = New System.Drawing.Size(79, 13)
        '
        'ItemForNamaBarang
        '
        Me.ItemForNamaBarang.Control = Me.NamaBarangTextEdit
        Me.ItemForNamaBarang.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNamaBarang.Name = "ItemForNamaBarang"
        Me.ItemForNamaBarang.Size = New System.Drawing.Size(362, 24)
        Me.ItemForNamaBarang.Text = "Nama Barang"
        Me.ItemForNamaBarang.TextSize = New System.Drawing.Size(79, 13)
        '
        'ItemForGambar
        '
        Me.ItemForGambar.Control = Me.GambarPictureEdit
        Me.ItemForGambar.Location = New System.Drawing.Point(362, 0)
        Me.ItemForGambar.Name = "ItemForGambar"
        Me.ItemForGambar.Size = New System.Drawing.Size(206, 143)
        Me.ItemForGambar.StartNewLine = True
        Me.ItemForGambar.Text = "Gambar"
        Me.ItemForGambar.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForGambar.TextSize = New System.Drawing.Size(79, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.BarangGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 143)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(568, 322)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 465)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(568, 72)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'ItemForNilaiKonversi
        '
        Me.ItemForNilaiKonversi.Control = Me.NilaiKonversiTextEdit
        Me.ItemForNilaiKonversi.Location = New System.Drawing.Point(0, 96)
        Me.ItemForNilaiKonversi.Name = "ItemForNilaiKonversi"
        Me.ItemForNilaiKonversi.Size = New System.Drawing.Size(362, 24)
        Me.ItemForNilaiKonversi.Text = "Nilai Konversi"
        Me.ItemForNilaiKonversi.TextSize = New System.Drawing.Size(79, 13)
        '
        'ItemForidSatuanBeli
        '
        Me.ItemForidSatuanBeli.Control = Me.idSatuanBeliLookUpEdit
        Me.ItemForidSatuanBeli.Location = New System.Drawing.Point(0, 48)
        Me.ItemForidSatuanBeli.Name = "ItemForidSatuanBeli"
        Me.ItemForidSatuanBeli.Size = New System.Drawing.Size(362, 24)
        Me.ItemForidSatuanBeli.Text = "Satuan Beli"
        Me.ItemForidSatuanBeli.TextSize = New System.Drawing.Size(79, 13)
        '
        'ItemForidSatuanJual
        '
        Me.ItemForidSatuanJual.Control = Me.idSatuanJualLookUpEdit
        Me.ItemForidSatuanJual.Location = New System.Drawing.Point(0, 72)
        Me.ItemForidSatuanJual.Name = "ItemForidSatuanJual"
        Me.ItemForidSatuanJual.Size = New System.Drawing.Size(362, 24)
        Me.ItemForidSatuanJual.Text = "Satuan Jual"
        Me.ItemForidSatuanJual.TextSize = New System.Drawing.Size(79, 13)
        '
        'ItemForisSell
        '
        Me.ItemForisSell.Control = Me.isSellCheckEdit
        Me.ItemForisSell.Location = New System.Drawing.Point(0, 120)
        Me.ItemForisSell.Name = "ItemForisSell"
        Me.ItemForisSell.Size = New System.Drawing.Size(362, 23)
        Me.ItemForisSell.Text = "Barang Siap Jual"
        Me.ItemForisSell.TextSize = New System.Drawing.Size(79, 13)
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 582)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.BarangBindingNavigator)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        CType(Me.DataSetBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarangBindingNavigator.ResumeLayout(False)
        Me.BarangBindingNavigator.PerformLayout()
        CType(Me.BarangGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatuanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idJenisLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaBarangTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idSatuanBeliLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idSatuanJualLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NilaiKonversiTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isSellCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidJenis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNamaBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNilaiKonversi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidSatuanBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidSatuanJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisSell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetBarang As DataSetBarang
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As DataSetBarangTableAdapters.BarangTableAdapter
    Friend WithEvents TableAdapterManager As DataSetBarangTableAdapters.TableAdapterManager
    Friend WithEvents BarangBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BarangBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BarangGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents JenisBarangBindingSource As BindingSource
    Friend WithEvents JenisBarangTableAdapter As DataSetBarangTableAdapters.JenisBarangTableAdapter
    Friend WithEvents SatuanBindingSource As BindingSource
    Friend WithEvents SatuanTableAdapter As DataSetBarangTableAdapters.SatuanTableAdapter
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents idJenisLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NamaBarangTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents idSatuanBeliLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents idSatuanJualLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GambarPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidJenis As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNamaBarang As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidSatuanBeli As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidSatuanJual As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForGambar As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colIDBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidJenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNamaBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSatuanBeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidSatuanJual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGambar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNilaiKonversi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NilaiKonversiTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForNilaiKonversi As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents isSellCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForisSell As DevExpress.XtraLayout.LayoutControlItem
End Class
