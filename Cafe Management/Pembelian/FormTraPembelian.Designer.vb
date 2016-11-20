<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTraPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTraPembelian))
        Me.DataSetPembelian = New Cafe_Management.DataSetPembelian()
        Me.PembelianHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembelianHTableAdapter = New Cafe_Management.DataSetPembelianTableAdapters.PembelianHTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetPembelianTableAdapters.TableAdapterManager()
        Me.c = New Cafe_Management.DataSetPembelianTableAdapters.PembelianDetailSelectTableAdapter()
        Me.PembelianHBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PembelianHBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PembelianHGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPembelianH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PembelianDetailSelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.FKPembelianHPembelianDetailSelectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PembelianDetailSelectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPembelianH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPembelianD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LookUpEditBarangDetail = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPembelianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHargaBeli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscountPembelian = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TanggalPembelianDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IDSupplierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoPembelianTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CatatanMemoExEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.IsCompletedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForTanggalPembelian = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIDSupplier = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNoPembelian = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCatatan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIsCompleted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SupplierTableAdapter = New Cafe_Management.DataSetPembelianTableAdapters.SupplierTableAdapter()
        Me.BarangTableAdapter = New Cafe_Management.DataSetPembelianTableAdapters.BarangTableAdapter()
        Me.RepositoryItemImagePopupContainerEdit1 = New DevExpress.XtraCharts.Designer.Native.RepositoryItemImagePopupContainerEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.DataSetPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianHBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PembelianHBindingNavigator.SuspendLayout()
        CType(Me.PembelianHGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetailSelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.FKPembelianHPembelianDetailSelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembelianDetailSelectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEditBarangDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPembelianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TanggalPembelianDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPembelianDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoPembelianTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatatanMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsCompletedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTanggalPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNoPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCatatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIsCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImagePopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPembelian
        '
        Me.DataSetPembelian.DataSetName = "DataSetPembelian"
        Me.DataSetPembelian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PembelianHBindingSource
        '
        Me.PembelianHBindingSource.DataMember = "PembelianH"
        Me.PembelianHBindingSource.DataSource = Me.DataSetPembelian
        '
        'PembelianHTableAdapter
        '
        Me.PembelianHTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PembelianDetailSelectTableAdapter = Me.c
        Me.TableAdapterManager.PembelianHTableAdapter = Me.PembelianHTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetPembelianTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'c
        '
        Me.c.ClearBeforeFill = True
        '
        'PembelianHBindingNavigator
        '
        Me.PembelianHBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PembelianHBindingNavigator.BindingSource = Me.PembelianHBindingSource
        Me.PembelianHBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PembelianHBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PembelianHBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PembelianHBindingNavigatorSaveItem})
        Me.PembelianHBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PembelianHBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PembelianHBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PembelianHBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PembelianHBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PembelianHBindingNavigator.Name = "PembelianHBindingNavigator"
        Me.PembelianHBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PembelianHBindingNavigator.Size = New System.Drawing.Size(1056, 25)
        Me.PembelianHBindingNavigator.TabIndex = 0
        Me.PembelianHBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'PembelianHBindingNavigatorSaveItem
        '
        Me.PembelianHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PembelianHBindingNavigatorSaveItem.Image = CType(resources.GetObject("PembelianHBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PembelianHBindingNavigatorSaveItem.Name = "PembelianHBindingNavigatorSaveItem"
        Me.PembelianHBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PembelianHBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PembelianHGridControl
        '
        Me.PembelianHGridControl.DataSource = Me.PembelianHBindingSource
        Me.PembelianHGridControl.Location = New System.Drawing.Point(330, 12)
        Me.PembelianHGridControl.MainView = Me.GridView1
        Me.PembelianHGridControl.Name = "PembelianHGridControl"
        Me.PembelianHGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImagePopupContainerEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.PembelianHGridControl.Size = New System.Drawing.Size(714, 299)
        Me.PembelianHGridControl.TabIndex = 1
        Me.PembelianHGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPembelianH1, Me.colTanggalPembelian, Me.colIDSupplier, Me.colNoPembelian, Me.colStatus, Me.colCatatan, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate})
        Me.GridView1.GridControl = Me.PembelianHGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDPembelianH1
        '
        Me.colIDPembelianH1.FieldName = "IDPembelianH"
        Me.colIDPembelianH1.Name = "colIDPembelianH1"
        '
        'colTanggalPembelian
        '
        Me.colTanggalPembelian.FieldName = "TanggalPembelian"
        Me.colTanggalPembelian.Name = "colTanggalPembelian"
        Me.colTanggalPembelian.Visible = True
        Me.colTanggalPembelian.VisibleIndex = 0
        '
        'colIDSupplier
        '
        Me.colIDSupplier.Caption = "Supplier"
        Me.colIDSupplier.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colIDSupplier.FieldName = "IDSupplier"
        Me.colIDSupplier.Name = "colIDSupplier"
        Me.colIDSupplier.Visible = True
        Me.colIDSupplier.VisibleIndex = 1
        '
        'colNoPembelian
        '
        Me.colNoPembelian.FieldName = "NoPembelian"
        Me.colNoPembelian.Name = "colNoPembelian"
        Me.colNoPembelian.Visible = True
        Me.colNoPembelian.VisibleIndex = 2
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colCatatan
        '
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 3
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
        'PembelianDetailSelectBindingSource
        '
        Me.PembelianDetailSelectBindingSource.DataMember = "PembelianDetailSelect"
        Me.PembelianDetailSelectBindingSource.DataSource = Me.DataSetPembelian
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.FKPembelianHPembelianDetailSelectBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(12, 315)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1032, 30)
        Me.BindingNavigator1.TabIndex = 3
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'FKPembelianHPembelianDetailSelectBindingSource
        '
        Me.FKPembelianHPembelianDetailSelectBindingSource.DataMember = "FK_PembelianH_PembelianDetailSelect"
        Me.FKPembelianHPembelianDetailSelectBindingSource.DataSource = Me.PembelianHBindingSource
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'PembelianDetailSelectGridControl
        '
        Me.PembelianDetailSelectGridControl.DataSource = Me.FKPembelianHPembelianDetailSelectBindingSource
        Me.PembelianDetailSelectGridControl.Location = New System.Drawing.Point(12, 349)
        Me.PembelianDetailSelectGridControl.MainView = Me.GridView2
        Me.PembelianDetailSelectGridControl.Name = "PembelianDetailSelectGridControl"
        Me.PembelianDetailSelectGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookUpEditBarangDetail})
        Me.PembelianDetailSelectGridControl.Size = New System.Drawing.Size(1032, 225)
        Me.PembelianDetailSelectGridControl.TabIndex = 3
        Me.PembelianDetailSelectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPembelianH, Me.colIDPembelianD, Me.colIDBarang, Me.colJumlah, Me.colHargaBeli, Me.colDiscountPembelian})
        Me.GridView2.GridControl = Me.PembelianDetailSelectGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colIDPembelianH
        '
        Me.colIDPembelianH.FieldName = "IDPembelianH"
        Me.colIDPembelianH.Name = "colIDPembelianH"
        '
        'colIDPembelianD
        '
        Me.colIDPembelianD.FieldName = "IDPembelianD"
        Me.colIDPembelianD.Name = "colIDPembelianD"
        '
        'colIDBarang
        '
        Me.colIDBarang.ColumnEdit = Me.LookUpEditBarangDetail
        Me.colIDBarang.FieldName = "IDBarang"
        Me.colIDBarang.Name = "colIDBarang"
        Me.colIDBarang.Visible = True
        Me.colIDBarang.VisibleIndex = 0
        '
        'LookUpEditBarangDetail
        '
        Me.LookUpEditBarangDetail.AutoHeight = False
        Me.LookUpEditBarangDetail.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEditBarangDetail.DataSource = Me.BarangBindingSource
        Me.LookUpEditBarangDetail.DisplayMember = "NamaBarang"
        Me.LookUpEditBarangDetail.Name = "LookUpEditBarangDetail"
        Me.LookUpEditBarangDetail.ValueMember = "IDBarang"
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.DataSetPembelianBindingSource
        '
        'DataSetPembelianBindingSource
        '
        Me.DataSetPembelianBindingSource.DataSource = Me.DataSetPembelian
        Me.DataSetPembelianBindingSource.Position = 0
        '
        'colJumlah
        '
        Me.colJumlah.FieldName = "Jumlah"
        Me.colJumlah.Name = "colJumlah"
        Me.colJumlah.Visible = True
        Me.colJumlah.VisibleIndex = 1
        '
        'colHargaBeli
        '
        Me.colHargaBeli.FieldName = "HargaBeli"
        Me.colHargaBeli.Name = "colHargaBeli"
        Me.colHargaBeli.Visible = True
        Me.colHargaBeli.VisibleIndex = 2
        '
        'colDiscountPembelian
        '
        Me.colDiscountPembelian.FieldName = "DiscountPembelian"
        Me.colDiscountPembelian.Name = "colDiscountPembelian"
        Me.colDiscountPembelian.Visible = True
        Me.colDiscountPembelian.VisibleIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.PembelianDetailSelectGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.BindingNavigator1)
        Me.DataLayoutControl1.Controls.Add(Me.PembelianHGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.TanggalPembelianDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDSupplierLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NoPembelianTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CatatanMemoExEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IsCompletedCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.PembelianHBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1056, 586)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TanggalPembelianDateEdit
        '
        Me.TanggalPembelianDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianHBindingSource, "TanggalPembelian", True))
        Me.TanggalPembelianDateEdit.EditValue = Nothing
        Me.TanggalPembelianDateEdit.Location = New System.Drawing.Point(104, 12)
        Me.TanggalPembelianDateEdit.Name = "TanggalPembelianDateEdit"
        Me.TanggalPembelianDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPembelianDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPembelianDateEdit.Size = New System.Drawing.Size(222, 20)
        Me.TanggalPembelianDateEdit.StyleController = Me.DataLayoutControl1
        Me.TanggalPembelianDateEdit.TabIndex = 4
        '
        'IDSupplierLookUpEdit
        '
        Me.IDSupplierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianHBindingSource, "IDSupplier", True))
        Me.IDSupplierLookUpEdit.Location = New System.Drawing.Point(104, 36)
        Me.IDSupplierLookUpEdit.Name = "IDSupplierLookUpEdit"
        Me.IDSupplierLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDSupplierLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDSupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDSupplierLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.IDSupplierLookUpEdit.Properties.DisplayMember = "Company"
        Me.IDSupplierLookUpEdit.Properties.NullText = ""
        Me.IDSupplierLookUpEdit.Properties.ValueMember = "IDSupplier"
        Me.IDSupplierLookUpEdit.Size = New System.Drawing.Size(222, 20)
        Me.IDSupplierLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDSupplierLookUpEdit.TabIndex = 5
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DataSetPembelianBindingSource
        '
        'NoPembelianTextEdit
        '
        Me.NoPembelianTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianHBindingSource, "NoPembelian", True))
        Me.NoPembelianTextEdit.Location = New System.Drawing.Point(104, 60)
        Me.NoPembelianTextEdit.Name = "NoPembelianTextEdit"
        Me.NoPembelianTextEdit.Size = New System.Drawing.Size(222, 20)
        Me.NoPembelianTextEdit.StyleController = Me.DataLayoutControl1
        Me.NoPembelianTextEdit.TabIndex = 6
        '
        'CatatanMemoExEdit
        '
        Me.CatatanMemoExEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianHBindingSource, "Catatan", True))
        Me.CatatanMemoExEdit.Location = New System.Drawing.Point(104, 84)
        Me.CatatanMemoExEdit.Name = "CatatanMemoExEdit"
        Me.CatatanMemoExEdit.Size = New System.Drawing.Size(222, 204)
        Me.CatatanMemoExEdit.StyleController = Me.DataLayoutControl1
        Me.CatatanMemoExEdit.TabIndex = 7
        '
        'IsCompletedCheckEdit
        '
        Me.IsCompletedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PembelianHBindingSource, "IsCompleted", True))
        Me.IsCompletedCheckEdit.Location = New System.Drawing.Point(104, 292)
        Me.IsCompletedCheckEdit.Name = "IsCompletedCheckEdit"
        Me.IsCompletedCheckEdit.Properties.Caption = "Is Completed"
        Me.IsCompletedCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.IsCompletedCheckEdit.Size = New System.Drawing.Size(222, 19)
        Me.IsCompletedCheckEdit.StyleController = Me.DataLayoutControl1
        Me.IsCompletedCheckEdit.TabIndex = 8
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1056, 586)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTanggalPembelian, Me.ItemForIDSupplier, Me.ItemForNoPembelian, Me.ItemForCatatan, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.ItemForIsCompleted})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1036, 566)
        '
        'ItemForTanggalPembelian
        '
        Me.ItemForTanggalPembelian.Control = Me.TanggalPembelianDateEdit
        Me.ItemForTanggalPembelian.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTanggalPembelian.Name = "ItemForTanggalPembelian"
        Me.ItemForTanggalPembelian.Size = New System.Drawing.Size(318, 24)
        Me.ItemForTanggalPembelian.Text = "Tanggal Pembelian"
        Me.ItemForTanggalPembelian.TextSize = New System.Drawing.Size(89, 13)
        '
        'ItemForIDSupplier
        '
        Me.ItemForIDSupplier.Control = Me.IDSupplierLookUpEdit
        Me.ItemForIDSupplier.Location = New System.Drawing.Point(0, 24)
        Me.ItemForIDSupplier.Name = "ItemForIDSupplier"
        Me.ItemForIDSupplier.Size = New System.Drawing.Size(318, 24)
        Me.ItemForIDSupplier.Text = "Supplier"
        Me.ItemForIDSupplier.TextSize = New System.Drawing.Size(89, 13)
        '
        'ItemForNoPembelian
        '
        Me.ItemForNoPembelian.Control = Me.NoPembelianTextEdit
        Me.ItemForNoPembelian.Location = New System.Drawing.Point(0, 48)
        Me.ItemForNoPembelian.Name = "ItemForNoPembelian"
        Me.ItemForNoPembelian.Size = New System.Drawing.Size(318, 24)
        Me.ItemForNoPembelian.Text = "No Pembelian"
        Me.ItemForNoPembelian.TextSize = New System.Drawing.Size(89, 13)
        '
        'ItemForCatatan
        '
        Me.ItemForCatatan.Control = Me.CatatanMemoExEdit
        Me.ItemForCatatan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForCatatan.Name = "ItemForCatatan"
        Me.ItemForCatatan.Size = New System.Drawing.Size(318, 208)
        Me.ItemForCatatan.Text = "Catatan"
        Me.ItemForCatatan.TextSize = New System.Drawing.Size(89, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PembelianHGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(318, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(718, 303)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.BindingNavigator1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 303)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1036, 34)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PembelianDetailSelectGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 337)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1036, 229)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'ItemForIsCompleted
        '
        Me.ItemForIsCompleted.Control = Me.IsCompletedCheckEdit
        Me.ItemForIsCompleted.Location = New System.Drawing.Point(0, 280)
        Me.ItemForIsCompleted.Name = "ItemForIsCompleted"
        Me.ItemForIsCompleted.Size = New System.Drawing.Size(318, 23)
        Me.ItemForIsCompleted.Text = "Is Completed"
        Me.ItemForIsCompleted.TextSize = New System.Drawing.Size(89, 13)
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemImagePopupContainerEdit1
        '
        Me.RepositoryItemImagePopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemImagePopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImagePopupContainerEdit1.Name = "RepositoryItemImagePopupContainerEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.SupplierBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Company"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "IDSupplier"
        '
        'FormTraPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 611)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PembelianHBindingNavigator)
        Me.Name = "FormTraPembelian"
        Me.Text = "FormTraPembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianHBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PembelianHBindingNavigator.ResumeLayout(False)
        Me.PembelianHBindingNavigator.PerformLayout()
        CType(Me.PembelianHGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetailSelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.FKPembelianHPembelianDetailSelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembelianDetailSelectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEditBarangDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPembelianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TanggalPembelianDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPembelianDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoPembelianTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatatanMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsCompletedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTanggalPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNoPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCatatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIsCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImagePopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPembelian As DataSetPembelian
    Friend WithEvents PembelianHBindingSource As BindingSource
    Friend WithEvents PembelianHTableAdapter As DataSetPembelianTableAdapters.PembelianHTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPembelianTableAdapters.TableAdapterManager
    Friend WithEvents PembelianHBindingNavigator As BindingNavigator
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
    Friend WithEvents PembelianHBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PembelianHGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PembelianDetailSelectBindingSource As BindingSource
    Friend WithEvents c As DataSetPembelianTableAdapters.PembelianDetailSelectTableAdapter
    Friend WithEvents colIDPembelianH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalPembelian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoPembelian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PembelianDetailSelectGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPembelianH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPembelianD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHargaBeli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscountPembelian As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FKPembelianHPembelianDetailSelectBindingSource As BindingSource
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents TanggalPembelianDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IDSupplierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NoPembelianTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CatatanMemoExEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForTanggalPembelian As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDSupplier As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNoPembelian As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCatatan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DataSetPembelianBindingSource As BindingSource
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DataSetPembelianTableAdapters.SupplierTableAdapter
    Friend WithEvents LookUpEditBarangDetail As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As DataSetPembelianTableAdapters.BarangTableAdapter
    Friend WithEvents IsCompletedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ItemForIsCompleted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImagePopupContainerEdit1 As DevExpress.XtraCharts.Designer.Native.RepositoryItemImagePopupContainerEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
