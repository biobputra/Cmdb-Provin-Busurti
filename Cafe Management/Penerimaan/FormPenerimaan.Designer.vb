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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenerimaan))
        Me.DataSetPenerimaan = New Cafe_Management.DataSetPenerimaan()
        Me.PenerimaanHBindingSource = New System.Windows.Forms.BindingSource()
        Me.PenerimaanHTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.PenerimaanHTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetPenerimaanTableAdapters.TableAdapterManager()
        Me.PenerimaanHBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.PenerimaanHBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PenerimaanHGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPenerimaanH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSumberPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPenerimaan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.FKPenerimaanHPenerimaanDBindingSource = New System.Windows.Forms.BindingSource()
        Me.PenerimaanDTableAdapter = New Cafe_Management.DataSetPenerimaanTableAdapters.PenerimaanDTableAdapter()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TanggalPenerimaanDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ItemForTanggalPenerimaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SumberPenerimaanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForSumberPenerimaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NoPenerimaanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForNoPenerimaan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CatatanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForCatatan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForStatus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PenerimaanDGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPenerimaanH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPenerimaanD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJumlah = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanHBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenerimaanHBindingNavigator.SuspendLayout()
        CType(Me.PenerimaanHGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKPenerimaanHPenerimaanDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPenerimaanDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalPenerimaanDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTanggalPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SumberPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSumberPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNoPenerimaan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCatatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerimaanDGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PenerimaanHBindingNavigator.Size = New System.Drawing.Size(1077, 25)
        Me.PenerimaanHBindingNavigator.TabIndex = 0
        Me.PenerimaanHBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        Me.PenerimaanHGridControl.Location = New System.Drawing.Point(286, 41)
        Me.PenerimaanHGridControl.MainView = Me.GridView1
        Me.PenerimaanHGridControl.Name = "PenerimaanHGridControl"
        Me.PenerimaanHGridControl.Size = New System.Drawing.Size(771, 200)
        Me.PenerimaanHGridControl.TabIndex = 1
        Me.PenerimaanHGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPenerimaanH, Me.colTanggalPenerimaan, Me.colSumberPenerimaan, Me.colNoPenerimaan, Me.colCatatan, Me.colStatus, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate})
        Me.GridView1.GridControl = Me.PenerimaanHGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDPenerimaanH
        '
        Me.colIDPenerimaanH.FieldName = "IDPenerimaanH"
        Me.colIDPenerimaanH.Name = "colIDPenerimaanH"
        Me.colIDPenerimaanH.Visible = True
        Me.colIDPenerimaanH.VisibleIndex = 0
        '
        'colTanggalPenerimaan
        '
        Me.colTanggalPenerimaan.FieldName = "TanggalPenerimaan"
        Me.colTanggalPenerimaan.Name = "colTanggalPenerimaan"
        Me.colTanggalPenerimaan.Visible = True
        Me.colTanggalPenerimaan.VisibleIndex = 1
        '
        'colSumberPenerimaan
        '
        Me.colSumberPenerimaan.FieldName = "SumberPenerimaan"
        Me.colSumberPenerimaan.Name = "colSumberPenerimaan"
        Me.colSumberPenerimaan.Visible = True
        Me.colSumberPenerimaan.VisibleIndex = 2
        '
        'colNoPenerimaan
        '
        Me.colNoPenerimaan.FieldName = "NoPenerimaan"
        Me.colNoPenerimaan.Name = "colNoPenerimaan"
        Me.colNoPenerimaan.Visible = True
        Me.colNoPenerimaan.VisibleIndex = 3
        '
        'colCatatan
        '
        Me.colCatatan.FieldName = "Catatan"
        Me.colCatatan.Name = "colCatatan"
        Me.colCatatan.Visible = True
        Me.colCatatan.VisibleIndex = 4
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 5
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        Me.colCreatedBy.Visible = True
        Me.colCreatedBy.VisibleIndex = 6
        '
        'colCreatedDate
        '
        Me.colCreatedDate.FieldName = "CreatedDate"
        Me.colCreatedDate.Name = "colCreatedDate"
        Me.colCreatedDate.Visible = True
        Me.colCreatedDate.VisibleIndex = 7
        '
        'colModifiedBy
        '
        Me.colModifiedBy.FieldName = "ModifiedBy"
        Me.colModifiedBy.Name = "colModifiedBy"
        Me.colModifiedBy.Visible = True
        Me.colModifiedBy.VisibleIndex = 8
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.Visible = True
        Me.colModifiedDate.VisibleIndex = 9
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TanggalPenerimaanDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SumberPenerimaanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NoPenerimaanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.CatatanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.StatusTextEdit)
        Me.DataLayoutControl1.DataSource = Me.PenerimaanHBindingSource
        Me.DataLayoutControl1.Location = New System.Drawing.Point(17, 53)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(263, 188)
        Me.DataLayoutControl1.TabIndex = 2
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(263, 188)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'FKPenerimaanHPenerimaanDBindingSource
        '
        Me.FKPenerimaanHPenerimaanDBindingSource.DataMember = "FK_PenerimaanH_PenerimaanD"
        Me.FKPenerimaanHPenerimaanDBindingSource.DataSource = Me.PenerimaanHBindingSource
        '
        'PenerimaanDTableAdapter
        '
        Me.PenerimaanDTableAdapter.ClearBeforeFill = True
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTanggalPenerimaan, Me.ItemForSumberPenerimaan, Me.ItemForNoPenerimaan, Me.ItemForCatatan, Me.ItemForStatus})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(243, 168)
        '
        'TanggalPenerimaanDateEdit
        '
        Me.TanggalPenerimaanDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "TanggalPenerimaan", True))
        Me.TanggalPenerimaanDateEdit.EditValue = Nothing
        Me.TanggalPenerimaanDateEdit.Location = New System.Drawing.Point(113, 12)
        Me.TanggalPenerimaanDateEdit.Name = "TanggalPenerimaanDateEdit"
        Me.TanggalPenerimaanDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPenerimaanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalPenerimaanDateEdit.Size = New System.Drawing.Size(138, 20)
        Me.TanggalPenerimaanDateEdit.StyleController = Me.DataLayoutControl1
        Me.TanggalPenerimaanDateEdit.TabIndex = 4
        '
        'ItemForTanggalPenerimaan
        '
        Me.ItemForTanggalPenerimaan.Control = Me.TanggalPenerimaanDateEdit
        Me.ItemForTanggalPenerimaan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTanggalPenerimaan.Name = "ItemForTanggalPenerimaan"
        Me.ItemForTanggalPenerimaan.Size = New System.Drawing.Size(243, 24)
        Me.ItemForTanggalPenerimaan.Text = "Tanggal Penerimaan"
        Me.ItemForTanggalPenerimaan.TextSize = New System.Drawing.Size(97, 13)
        '
        'SumberPenerimaanTextEdit
        '
        Me.SumberPenerimaanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "SumberPenerimaan", True))
        Me.SumberPenerimaanTextEdit.Location = New System.Drawing.Point(113, 36)
        Me.SumberPenerimaanTextEdit.Name = "SumberPenerimaanTextEdit"
        Me.SumberPenerimaanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.SumberPenerimaanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SumberPenerimaanTextEdit.Properties.Mask.EditMask = "N0"
        Me.SumberPenerimaanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.SumberPenerimaanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.SumberPenerimaanTextEdit.Size = New System.Drawing.Size(138, 20)
        Me.SumberPenerimaanTextEdit.StyleController = Me.DataLayoutControl1
        Me.SumberPenerimaanTextEdit.TabIndex = 5
        '
        'ItemForSumberPenerimaan
        '
        Me.ItemForSumberPenerimaan.Control = Me.SumberPenerimaanTextEdit
        Me.ItemForSumberPenerimaan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForSumberPenerimaan.Name = "ItemForSumberPenerimaan"
        Me.ItemForSumberPenerimaan.Size = New System.Drawing.Size(243, 24)
        Me.ItemForSumberPenerimaan.Text = "Sumber Penerimaan"
        Me.ItemForSumberPenerimaan.TextSize = New System.Drawing.Size(97, 13)
        '
        'NoPenerimaanTextEdit
        '
        Me.NoPenerimaanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "NoPenerimaan", True))
        Me.NoPenerimaanTextEdit.Location = New System.Drawing.Point(113, 60)
        Me.NoPenerimaanTextEdit.Name = "NoPenerimaanTextEdit"
        Me.NoPenerimaanTextEdit.Size = New System.Drawing.Size(138, 20)
        Me.NoPenerimaanTextEdit.StyleController = Me.DataLayoutControl1
        Me.NoPenerimaanTextEdit.TabIndex = 6
        '
        'ItemForNoPenerimaan
        '
        Me.ItemForNoPenerimaan.Control = Me.NoPenerimaanTextEdit
        Me.ItemForNoPenerimaan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForNoPenerimaan.Name = "ItemForNoPenerimaan"
        Me.ItemForNoPenerimaan.Size = New System.Drawing.Size(243, 24)
        Me.ItemForNoPenerimaan.Text = "No Penerimaan"
        Me.ItemForNoPenerimaan.TextSize = New System.Drawing.Size(97, 13)
        '
        'CatatanTextEdit
        '
        Me.CatatanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "Catatan", True))
        Me.CatatanTextEdit.Location = New System.Drawing.Point(113, 84)
        Me.CatatanTextEdit.Name = "CatatanTextEdit"
        Me.CatatanTextEdit.Size = New System.Drawing.Size(138, 20)
        Me.CatatanTextEdit.StyleController = Me.DataLayoutControl1
        Me.CatatanTextEdit.TabIndex = 7
        '
        'ItemForCatatan
        '
        Me.ItemForCatatan.Control = Me.CatatanTextEdit
        Me.ItemForCatatan.Location = New System.Drawing.Point(0, 72)
        Me.ItemForCatatan.Name = "ItemForCatatan"
        Me.ItemForCatatan.Size = New System.Drawing.Size(243, 24)
        Me.ItemForCatatan.Text = "Catatan"
        Me.ItemForCatatan.TextSize = New System.Drawing.Size(97, 13)
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenerimaanHBindingSource, "Status", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(113, 108)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.StatusTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.StatusTextEdit.Properties.Mask.EditMask = "N0"
        Me.StatusTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.StatusTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.StatusTextEdit.Size = New System.Drawing.Size(138, 20)
        Me.StatusTextEdit.StyleController = Me.DataLayoutControl1
        Me.StatusTextEdit.TabIndex = 8
        '
        'ItemForStatus
        '
        Me.ItemForStatus.Control = Me.StatusTextEdit
        Me.ItemForStatus.Location = New System.Drawing.Point(0, 96)
        Me.ItemForStatus.Name = "ItemForStatus"
        Me.ItemForStatus.Size = New System.Drawing.Size(243, 72)
        Me.ItemForStatus.Text = "Status"
        Me.ItemForStatus.TextSize = New System.Drawing.Size(97, 13)
        '
        'PenerimaanDGridControl
        '
        Me.PenerimaanDGridControl.DataSource = Me.FKPenerimaanHPenerimaanDBindingSource
        Me.PenerimaanDGridControl.Location = New System.Drawing.Point(249, 292)
        Me.PenerimaanDGridControl.MainView = Me.GridView2
        Me.PenerimaanDGridControl.Name = "PenerimaanDGridControl"
        Me.PenerimaanDGridControl.Size = New System.Drawing.Size(816, 220)
        Me.PenerimaanDGridControl.TabIndex = 3
        Me.PenerimaanDGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPenerimaanH1, Me.colIDPenerimaanD, Me.colIDBarang, Me.colJumlah, Me.colHarga})
        Me.GridView2.GridControl = Me.PenerimaanDGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colIDPenerimaanH1
        '
        Me.colIDPenerimaanH1.FieldName = "IDPenerimaanH"
        Me.colIDPenerimaanH1.Name = "colIDPenerimaanH1"
        Me.colIDPenerimaanH1.Visible = True
        Me.colIDPenerimaanH1.VisibleIndex = 0
        '
        'colIDPenerimaanD
        '
        Me.colIDPenerimaanD.FieldName = "IDPenerimaanD"
        Me.colIDPenerimaanD.Name = "colIDPenerimaanD"
        Me.colIDPenerimaanD.Visible = True
        Me.colIDPenerimaanD.VisibleIndex = 1
        '
        'colIDBarang
        '
        Me.colIDBarang.FieldName = "IDBarang"
        Me.colIDBarang.Name = "colIDBarang"
        Me.colIDBarang.Visible = True
        Me.colIDBarang.VisibleIndex = 2
        '
        'colJumlah
        '
        Me.colJumlah.FieldName = "Jumlah"
        Me.colJumlah.Name = "colJumlah"
        Me.colJumlah.Visible = True
        Me.colJumlah.VisibleIndex = 3
        '
        'colHarga
        '
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 4
        '
        'FormPenerimaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 584)
        Me.Controls.Add(Me.PenerimaanDGridControl)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PenerimaanHGridControl)
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
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKPenerimaanHPenerimaanDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPenerimaanDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalPenerimaanDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTanggalPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SumberPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSumberPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoPenerimaanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNoPenerimaan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatatanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCatatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerimaanDGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PenerimaanDTableAdapter As DataSetPenerimaanTableAdapters.PenerimaanDTableAdapter
    Friend WithEvents PenerimaanHGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPenerimaanH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSumberPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoPenerimaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents FKPenerimaanHPenerimaanDBindingSource As BindingSource
    Friend WithEvents TanggalPenerimaanDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SumberPenerimaanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NoPenerimaanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CatatanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForTanggalPenerimaan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForSumberPenerimaan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNoPenerimaan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCatatan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForStatus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PenerimaanDGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPenerimaanH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPenerimaanD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
End Class
