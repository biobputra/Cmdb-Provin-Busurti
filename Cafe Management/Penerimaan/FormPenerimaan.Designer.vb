<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenerimaan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenerimaan))
        Me.DataSetPenerimaan = New Cafe_Management.DataSetPenerimaan()
        Me.PenerimaanHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenerimaanHTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.PenerimaanHTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetPenerimaanTableAdapters.TableAdapterManager()
        Me.PenerimaanDTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.PenerimaanDTableAdapter()
        Me.PenerimaanHBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PenerimaanHBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PenerimaanHGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPenerimaanH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPembelianH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSumberPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.HargaSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.FKPenerimaanHPenerimaanDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JumlahSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.IDBarangLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.GetBarangSisaByIDPembelianHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenerimaanDGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPenerimaanH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPenerimaanD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colJumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
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
        Me.TanggalPenerimaanDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.IDPembelianHLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PnrGetAktifPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SumberPenerimaanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NoPenerimaanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CatatanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForTanggalPenerimaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIDPembelianH = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForSumberPenerimaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNoPenerimaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCatatan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForStatus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Pnr_GetAktifPOTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.Pnr_GetAktifPOTableAdapter()
        Me.PenerimaanDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetBarangSisaByIDPembelianHTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.GetBarangSisaByIDPembelianHTableAdapter()
        Me.BarangTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.BarangTableAdapter()
        CType(Me.DataSetPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanHBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenerimaanHBindingNavigator.SuspendLayout()
        CType(Me.PenerimaanHGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.HargaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPenerimaanHPenerimaanDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JumlahSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDBarangLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetBarangSisaByIDPembelianHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanDGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.TanggalPenerimaanDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPenerimaanDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDPembelianHLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnrGetAktifPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SumberPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTanggalPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDPembelianH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSumberPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNoPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCatatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPenerimaan
        '
        Me.DataSetPenerimaan.DataSetName = "DataSetPenerimaan"
        Me.DataSetPenerimaan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenerimaanHBindingSource
        '
        Me.PenerimaanHBindingSource.DataMember = "PenerimaanH"
        Me.PenerimaanHBindingSource.DataSource = Me.DataSetPenerimaan
        '
        'PenerimaanHTableAdapter
        '
        Me.PenerimaanHTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PenerimaanDTableAdapter = Me.PenerimaanDTableAdapter
        Me.TableAdapterManager.PenerimaanHTableAdapter = Me.PenerimaanHTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetPenerimaanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PenerimaanDTableAdapter
        '
        Me.PenerimaanDTableAdapter.ClearBeforeFill = True
        '
        'PenerimaanHBindingNavigator
        '
        Me.PenerimaanHBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PenerimaanHBindingNavigator.BindingSource = Me.PenerimaanHBindingSource
        Me.PenerimaanHBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PenerimaanHBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PenerimaanHBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PenerimaanHBindingNavigatorSaveItem})
        Me.PenerimaanHBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PenerimaanHBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PenerimaanHBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PenerimaanHBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PenerimaanHBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PenerimaanHBindingNavigator.Name = "PenerimaanHBindingNavigator"
        Me.PenerimaanHBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PenerimaanHBindingNavigator.Size = New System.Drawing.Size(1217, 25)
        Me.PenerimaanHBindingNavigator.TabIndex = 0
        Me.PenerimaanHBindingNavigator.Text = "BindingNavigator1"
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
        'PenerimaanHBindingNavigatorSaveItem
        '
        Me.PenerimaanHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PenerimaanHBindingNavigatorSaveItem.Image = CType(resources.GetObject("PenerimaanHBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PenerimaanHBindingNavigatorSaveItem.Name = "PenerimaanHBindingNavigatorSaveItem"
        Me.PenerimaanHBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PenerimaanHBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PenerimaanHGridControl
        '
        Me.PenerimaanHGridControl.DataSource = Me.PenerimaanHBindingSource
        Me.PenerimaanHGridControl.Location = New System.Drawing.Point(531, 12)
        Me.PenerimaanHGridControl.MainView = Me.GridView1
        Me.PenerimaanHGridControl.Name = "PenerimaanHGridControl"
        Me.PenerimaanHGridControl.Size = New System.Drawing.Size(674, 270)
        Me.PenerimaanHGridControl.TabIndex = 1
        Me.PenerimaanHGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPenerimaanH, Me.colTanggalPenerimaan, Me.colIDPembelianH, Me.colSumberPenerimaan, Me.colNoPenerimaan, Me.colCatatan, Me.colStatus, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate})
        Me.GridView1.GridControl = Me.PenerimaanHGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDPenerimaanH
        '
        Me.colIDPenerimaanH.FieldName = "IDPenerimaanH"
        Me.colIDPenerimaanH.Name = "colIDPenerimaanH"
        '
        'colTanggalPenerimaan
        '
        Me.colTanggalPenerimaan.FieldName = "TanggalPenerimaan"
        Me.colTanggalPenerimaan.Name = "colTanggalPenerimaan"
        Me.colTanggalPenerimaan.Visible = True
        Me.colTanggalPenerimaan.VisibleIndex = 0
        '
        'colIDPembelianH
        '
        Me.colIDPembelianH.FieldName = "IDPembelianH"
        Me.colIDPembelianH.Name = "colIDPembelianH"
        '
        'colSumberPenerimaan
        '
        Me.colSumberPenerimaan.FieldName = "SumberPenerimaan"
        Me.colSumberPenerimaan.Name = "colSumberPenerimaan"
        Me.colSumberPenerimaan.Visible = True
        Me.colSumberPenerimaan.VisibleIndex = 1
        '
        'colNoPenerimaan
        '
        Me.colNoPenerimaan.FieldName = "NoPenerimaan"
        Me.colNoPenerimaan.Name = "colNoPenerimaan"
        Me.colNoPenerimaan.Visible = True
        Me.colNoPenerimaan.VisibleIndex = 2
        '
        'colCatatan
        '
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 3
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 4
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
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.HargaSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JumlahSpinEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDBarangLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PenerimaanDGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.BindingNavigator1)
        Me.DataLayoutControl1.Controls.Add(Me.PenerimaanHGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.TanggalPenerimaanDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDPembelianHLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SumberPenerimaanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NoPenerimaanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CatatanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.StatusTextEdit)
        Me.DataLayoutControl1.DataSource = Me.PenerimaanHBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(149, 61, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1217, 685)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'HargaSpinEdit
        '
        Me.HargaSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FKPenerimaanHPenerimaanDBindingSource, "Harga", True))
        Me.HargaSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.HargaSpinEdit.Location = New System.Drawing.Point(697, 320)
        Me.HargaSpinEdit.Name = "HargaSpinEdit"
        Me.HargaSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HargaSpinEdit.Size = New System.Drawing.Size(172, 20)
        Me.HargaSpinEdit.StyleController = Me.DataLayoutControl1
        Me.HargaSpinEdit.TabIndex = 16
        '
        'FKPenerimaanHPenerimaanDBindingSource
        '
        Me.FKPenerimaanHPenerimaanDBindingSource.DataMember = "FK_PenerimaanH_PenerimaanD"
        Me.FKPenerimaanHPenerimaanDBindingSource.DataSource = Me.PenerimaanHBindingSource
        '
        'JumlahSpinEdit
        '
        Me.JumlahSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FKPenerimaanHPenerimaanDBindingSource, "Jumlah", True))
        Me.JumlahSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.JumlahSpinEdit.Location = New System.Drawing.Point(436, 320)
        Me.JumlahSpinEdit.Name = "JumlahSpinEdit"
        Me.JumlahSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JumlahSpinEdit.Size = New System.Drawing.Size(91, 20)
        Me.JumlahSpinEdit.StyleController = Me.DataLayoutControl1
        Me.JumlahSpinEdit.TabIndex = 15
        '
        'IDBarangLookUpEdit
        '
        Me.IDBarangLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.FKPenerimaanHPenerimaanDBindingSource, "IDBarang", True))
        Me.IDBarangLookUpEdit.Location = New System.Drawing.Point(112, 320)
        Me.IDBarangLookUpEdit.Name = "IDBarangLookUpEdit"
        Me.IDBarangLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDBarangLookUpEdit.Properties.DataSource = Me.GetBarangSisaByIDPembelianHBindingSource
        Me.IDBarangLookUpEdit.Properties.DisplayMember = "NamaBarang"
        Me.IDBarangLookUpEdit.Properties.ValueMember = "IDBarang"
        Me.IDBarangLookUpEdit.Size = New System.Drawing.Size(170, 20)
        Me.IDBarangLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDBarangLookUpEdit.TabIndex = 14
        '
        'GetBarangSisaByIDPembelianHBindingSource
        '
        Me.GetBarangSisaByIDPembelianHBindingSource.DataMember = "GetBarangSisaByIDPembelianH"
        Me.GetBarangSisaByIDPembelianHBindingSource.DataSource = Me.DataSetPenerimaan
        '
        'PenerimaanDGridControl
        '
        Me.PenerimaanDGridControl.DataSource = Me.FKPenerimaanHPenerimaanDBindingSource
        Me.PenerimaanDGridControl.Location = New System.Drawing.Point(12, 344)
        Me.PenerimaanDGridControl.MainView = Me.GridView2
        Me.PenerimaanDGridControl.Name = "PenerimaanDGridControl"
        Me.PenerimaanDGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.PenerimaanDGridControl.Size = New System.Drawing.Size(1193, 329)
        Me.PenerimaanDGridControl.TabIndex = 3
        Me.PenerimaanDGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPenerimaanH1, Me.colIDPenerimaanD, Me.colIDBarang, Me.colJumlah, Me.colHarga})
        Me.GridView2.GridControl = Me.PenerimaanDGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'colIDPenerimaanH1
        '
        Me.colIDPenerimaanH1.FieldName = "IDPenerimaanH"
        Me.colIDPenerimaanH1.Name = "colIDPenerimaanH1"
        '
        'colIDPenerimaanD
        '
        Me.colIDPenerimaanD.FieldName = "IDPenerimaanD"
        Me.colIDPenerimaanD.Name = "colIDPenerimaanD"
        '
        'colIDBarang
        '
        Me.colIDBarang.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIDBarang.FieldName = "IDBarang"
        Me.colIDBarang.Name = "colIDBarang"
        Me.colIDBarang.Visible = True
        Me.colIDBarang.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.BarangBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "NamaBarang"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDBarang"
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.DataSetPenerimaan
        '
        'colJumlah
        '
        Me.colJumlah.FieldName = "Jumlah"
        Me.colJumlah.Name = "colJumlah"
        Me.colJumlah.Visible = True
        Me.colJumlah.VisibleIndex = 1
        '
        'colHarga
        '
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Harga", "Total Harga={0:0.##}")})
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 2
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.FKPenerimaanHPenerimaanDBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(12, 286)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1193, 30)
        Me.BindingNavigator1.TabIndex = 10
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
        'TanggalPenerimaanDateEdit
        '
        Me.TanggalPenerimaanDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "TanggalPenerimaan", True))
        Me.TanggalPenerimaanDateEdit.EditValue = Nothing
        Me.TanggalPenerimaanDateEdit.Location = New System.Drawing.Point(112, 12)
        Me.TanggalPenerimaanDateEdit.Name = "TanggalPenerimaanDateEdit"
        Me.TanggalPenerimaanDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPenerimaanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPenerimaanDateEdit.Size = New System.Drawing.Size(415, 20)
        Me.TanggalPenerimaanDateEdit.StyleController = Me.DataLayoutControl1
        Me.TanggalPenerimaanDateEdit.TabIndex = 4
        '
        'IDPembelianHLookUpEdit
        '
        Me.IDPembelianHLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "IDPembelianH", True))
        Me.IDPembelianHLookUpEdit.Location = New System.Drawing.Point(112, 36)
        Me.IDPembelianHLookUpEdit.Name = "IDPembelianHLookUpEdit"
        Me.IDPembelianHLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDPembelianHLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDPembelianHLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDPembelianHLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDPembelianH", "ID Pembelian H", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoPembelian", "No Pembelian", 74, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDSupplier", "ID Supplier", 62, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Company", "Company", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "Contact Name", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.IDPembelianHLookUpEdit.Properties.DataSource = Me.PnrGetAktifPOBindingSource
        Me.IDPembelianHLookUpEdit.Properties.DisplayMember = "Company"
        Me.IDPembelianHLookUpEdit.Properties.NullText = ""
        Me.IDPembelianHLookUpEdit.Properties.ValueMember = "IDPembelianH"
        Me.IDPembelianHLookUpEdit.Size = New System.Drawing.Size(415, 20)
        Me.IDPembelianHLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDPembelianHLookUpEdit.TabIndex = 5
        '
        'PnrGetAktifPOBindingSource
        '
        Me.PnrGetAktifPOBindingSource.DataMember = "Pnr_GetAktifPO"
        Me.PnrGetAktifPOBindingSource.DataSource = Me.DataSetPenerimaan
        '
        'SumberPenerimaanTextEdit
        '
        Me.SumberPenerimaanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "SumberPenerimaan", True))
        Me.SumberPenerimaanTextEdit.Location = New System.Drawing.Point(112, 60)
        Me.SumberPenerimaanTextEdit.Name = "SumberPenerimaanTextEdit"
        Me.SumberPenerimaanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.SumberPenerimaanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SumberPenerimaanTextEdit.Properties.Mask.EditMask = "N0"
        Me.SumberPenerimaanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.SumberPenerimaanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.SumberPenerimaanTextEdit.Size = New System.Drawing.Size(415, 20)
        Me.SumberPenerimaanTextEdit.StyleController = Me.DataLayoutControl1
        Me.SumberPenerimaanTextEdit.TabIndex = 6
        '
        'NoPenerimaanTextEdit
        '
        Me.NoPenerimaanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "NoPenerimaan", True))
        Me.NoPenerimaanTextEdit.Location = New System.Drawing.Point(112, 84)
        Me.NoPenerimaanTextEdit.Name = "NoPenerimaanTextEdit"
        Me.NoPenerimaanTextEdit.Size = New System.Drawing.Size(415, 20)
        Me.NoPenerimaanTextEdit.StyleController = Me.DataLayoutControl1
        Me.NoPenerimaanTextEdit.TabIndex = 7
        '
        'CatatanTextEdit
        '
        Me.CatatanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "Catatan", True))
        Me.CatatanTextEdit.Location = New System.Drawing.Point(112, 108)
        Me.CatatanTextEdit.Name = "CatatanTextEdit"
        Me.CatatanTextEdit.Size = New System.Drawing.Size(415, 20)
        Me.CatatanTextEdit.StyleController = Me.DataLayoutControl1
        Me.CatatanTextEdit.TabIndex = 8
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "Status", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(112, 132)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.StatusTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.StatusTextEdit.Properties.Mask.EditMask = "N0"
        Me.StatusTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.StatusTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.StatusTextEdit.Size = New System.Drawing.Size(415, 20)
        Me.StatusTextEdit.StyleController = Me.DataLayoutControl1
        Me.StatusTextEdit.TabIndex = 9
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1217, 685)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTanggalPenerimaan, Me.ItemForIDPembelianH, Me.ItemForSumberPenerimaan, Me.ItemForNoPenerimaan, Me.ItemForCatatan, Me.ItemForStatus, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1197, 665)
        '
        'ItemForTanggalPenerimaan
        '
        Me.ItemForTanggalPenerimaan.Control = Me.TanggalPenerimaanDateEdit
        Me.ItemForTanggalPenerimaan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTanggalPenerimaan.Name = "ItemForTanggalPenerimaan"
        Me.ItemForTanggalPenerimaan.Size = New System.Drawing.Size(519, 24)
        Me.ItemForTanggalPenerimaan.Text = "Tanggal Penerimaan"
        Me.ItemForTanggalPenerimaan.TextSize = New System.Drawing.Size(97, 13)
        '
        'ItemForIDPembelianH
        '
        Me.ItemForIDPembelianH.Control = Me.IDPembelianHLookUpEdit
        Me.ItemForIDPembelianH.Location = New System.Drawing.Point(0, 24)
        Me.ItemForIDPembelianH.Name = "ItemForIDPembelianH"
        Me.ItemForIDPembelianH.Size = New System.Drawing.Size(519, 24)
        Me.ItemForIDPembelianH.Text = "Dari Pembelian"
        Me.ItemForIDPembelianH.TextSize = New System.Drawing.Size(97, 13)
        '
        'ItemForSumberPenerimaan
        '
        Me.ItemForSumberPenerimaan.Control = Me.SumberPenerimaanTextEdit
        Me.ItemForSumberPenerimaan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForSumberPenerimaan.Name = "ItemForSumberPenerimaan"
        Me.ItemForSumberPenerimaan.Size = New System.Drawing.Size(519, 24)
        Me.ItemForSumberPenerimaan.Text = "Sumber Penerimaan"
        Me.ItemForSumberPenerimaan.TextSize = New System.Drawing.Size(97, 13)
        '
        'ItemForNoPenerimaan
        '
        Me.ItemForNoPenerimaan.Control = Me.NoPenerimaanTextEdit
        Me.ItemForNoPenerimaan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForNoPenerimaan.Name = "ItemForNoPenerimaan"
        Me.ItemForNoPenerimaan.Size = New System.Drawing.Size(519, 24)
        Me.ItemForNoPenerimaan.Text = "No Penerimaan"
        Me.ItemForNoPenerimaan.TextSize = New System.Drawing.Size(97, 13)
        '
        'ItemForCatatan
        '
        Me.ItemForCatatan.Control = Me.CatatanTextEdit
        Me.ItemForCatatan.Location = New System.Drawing.Point(0, 96)
        Me.ItemForCatatan.Name = "ItemForCatatan"
        Me.ItemForCatatan.Size = New System.Drawing.Size(519, 24)
        Me.ItemForCatatan.Text = "Catatan"
        Me.ItemForCatatan.TextSize = New System.Drawing.Size(97, 13)
        '
        'ItemForStatus
        '
        Me.ItemForStatus.Control = Me.StatusTextEdit
        Me.ItemForStatus.Location = New System.Drawing.Point(0, 120)
        Me.ItemForStatus.Name = "ItemForStatus"
        Me.ItemForStatus.Size = New System.Drawing.Size(519, 24)
        Me.ItemForStatus.Text = "Status"
        Me.ItemForStatus.TextSize = New System.Drawing.Size(97, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PenerimaanHGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(519, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(678, 274)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 144)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(519, 130)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.BindingNavigator1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 274)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1197, 34)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PenerimaanDGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 332)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1197, 333)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.IDBarangLookUpEdit
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 308)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(274, 24)
        Me.LayoutControlItem5.Text = "IDBarang:"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(97, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.JumlahSpinEdit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(324, 308)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem6.Text = "Jumlah:"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(97, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.HargaSpinEdit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(585, 308)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(276, 24)
        Me.LayoutControlItem7.Text = "Harga:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(97, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(861, 308)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(336, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(274, 308)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(50, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(519, 308)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(66, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'Pnr_GetAktifPOTableAdapter
        '
        Me.Pnr_GetAktifPOTableAdapter.ClearBeforeFill = True
        '
        'PenerimaanDBindingSource
        '
        Me.PenerimaanDBindingSource.DataMember = "FK_PenerimaanH_PenerimaanD"
        Me.PenerimaanDBindingSource.DataSource = Me.PenerimaanHBindingSource
        '
        'GetBarangSisaByIDPembelianHTableAdapter
        '
        Me.GetBarangSisaByIDPembelianHTableAdapter.ClearBeforeFill = True
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'FormPenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 710)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PenerimaanHBindingNavigator)
        Me.Name = "FormPenerimaan"
        Me.Text = "FormPenerimaan"
        CType(Me.DataSetPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanHBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenerimaanHBindingNavigator.ResumeLayout(False)
        Me.PenerimaanHBindingNavigator.PerformLayout()
        CType(Me.PenerimaanHGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.HargaSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPenerimaanHPenerimaanDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JumlahSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDBarangLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetBarangSisaByIDPembelianHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanDGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.TanggalPenerimaanDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPenerimaanDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDPembelianHLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnrGetAktifPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SumberPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTanggalPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDPembelianH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSumberPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNoPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCatatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetPenerimaan As DataSetPenerimaan
    Friend WithEvents PenerimaanHBindingSource As BindingSource
    Friend WithEvents PenerimaanHTableAdapter As DataSetPenerimaanTableAdapters.PenerimaanHTableAdapter
    Friend WithEvents TableAdapterManager As DataSetPenerimaanTableAdapters.TableAdapterManager
    Friend WithEvents PenerimaanHBindingNavigator As BindingNavigator
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
    Friend WithEvents PenerimaanHBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PenerimaanHGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPenerimaanH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPembelianH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSumberPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents TanggalPenerimaanDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents IDPembelianHLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SumberPenerimaanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NoPenerimaanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CatatanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForTanggalPenerimaan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDPembelianH As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSumberPenerimaan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNoPenerimaan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCatatan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForStatus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PnrGetAktifPOBindingSource As BindingSource
    Friend WithEvents Pnr_GetAktifPOTableAdapter As DataSetPenerimaanTableAdapters.Pnr_GetAktifPOTableAdapter
    Friend WithEvents PenerimaanDBindingSource As BindingSource
    Friend WithEvents PenerimaanDTableAdapter As DataSetPenerimaanTableAdapters.PenerimaanDTableAdapter
    Friend WithEvents PenerimaanDGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents FKPenerimaanHPenerimaanDBindingSource As BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPenerimaanH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPenerimaanD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents HargaSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents JumlahSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents IDBarangLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GetBarangSisaByIDPembelianHBindingSource As BindingSource
    Friend WithEvents GetBarangSisaByIDPembelianHTableAdapter As DataSetPenerimaanTableAdapters.GetBarangSisaByIDPembelianHTableAdapter
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As DataSetPenerimaanTableAdapters.BarangTableAdapter
End Class
