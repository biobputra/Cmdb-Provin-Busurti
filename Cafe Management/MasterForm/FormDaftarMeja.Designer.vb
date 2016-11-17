<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarMeja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDaftarMeja))
        Me.DataSetDaftarMeja = New Cafe_Management.DataSetDaftarMeja()
        Me.DaftarMejaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaftarMejaTableAdapter = New Cafe_Management.DataSetDaftarMejaTableAdapters.DaftarMejaTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetDaftarMejaTableAdapters.TableAdapterManager()
        Me.DaftarMejaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DaftarMejaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DaftarMejaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDDaftarMeja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDJenisMeja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorMeja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalbook = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJamMulai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJamSelesai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.KeteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NomorMejaLookUpEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IDJenisMejaTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JenisMejaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForIDJenisMeja = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNomorMeja = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKeterangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JenisMejaTableAdapter = New Cafe_Management.DataSetDaftarMejaTableAdapters.JenisMejaTableAdapter()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.DataSetDaftarMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaftarMejaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaftarMejaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DaftarMejaBindingNavigator.SuspendLayout()
        CType(Me.DaftarMejaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorMejaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDJenisMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMejaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDJenisMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNomorMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetDaftarMeja
        '
        Me.DataSetDaftarMeja.DataSetName = "DataSetDaftarMeja"
        Me.DataSetDaftarMeja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DaftarMejaBindingSource
        '
        Me.DaftarMejaBindingSource.DataMember = "DaftarMeja"
        Me.DaftarMejaBindingSource.DataSource = Me.DataSetDaftarMeja
        '
        'DaftarMejaTableAdapter
        '
        Me.DaftarMejaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DaftarMejaTableAdapter = Me.DaftarMejaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetDaftarMejaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DaftarMejaBindingNavigator
        '
        Me.DaftarMejaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DaftarMejaBindingNavigator.BindingSource = Me.DaftarMejaBindingSource
        Me.DaftarMejaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DaftarMejaBindingNavigator.DeleteItem = Nothing
        Me.DaftarMejaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.DaftarMejaBindingNavigatorSaveItem})
        Me.DaftarMejaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DaftarMejaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DaftarMejaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DaftarMejaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DaftarMejaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DaftarMejaBindingNavigator.Name = "DaftarMejaBindingNavigator"
        Me.DaftarMejaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DaftarMejaBindingNavigator.Size = New System.Drawing.Size(347, 25)
        Me.DaftarMejaBindingNavigator.TabIndex = 0
        Me.DaftarMejaBindingNavigator.Text = "BindingNavigator1"
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
        'DaftarMejaBindingNavigatorSaveItem
        '
        Me.DaftarMejaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DaftarMejaBindingNavigatorSaveItem.Image = CType(resources.GetObject("DaftarMejaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DaftarMejaBindingNavigatorSaveItem.Name = "DaftarMejaBindingNavigatorSaveItem"
        Me.DaftarMejaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DaftarMejaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DaftarMejaGridControl
        '
        Me.DaftarMejaGridControl.DataSource = Me.DaftarMejaBindingSource
        Me.DaftarMejaGridControl.Location = New System.Drawing.Point(12, 84)
        Me.DaftarMejaGridControl.MainView = Me.GridView1
        Me.DaftarMejaGridControl.Name = "DaftarMejaGridControl"
        Me.DaftarMejaGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.DaftarMejaGridControl.Size = New System.Drawing.Size(323, 355)
        Me.DaftarMejaGridControl.TabIndex = 4
        Me.DaftarMejaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDDaftarMeja, Me.colIDJenisMeja, Me.colNomorMeja, Me.colKeterangan, Me.colStatus, Me.colTanggalbook, Me.colJamMulai, Me.colJamSelesai, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.DaftarMejaGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDDaftarMeja
        '
        Me.colIDDaftarMeja.FieldName = "IDDaftarMeja"
        Me.colIDDaftarMeja.Name = "colIDDaftarMeja"
        '
        'colIDJenisMeja
        '
        Me.colIDJenisMeja.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIDJenisMeja.FieldName = "IDJenisMeja"
        Me.colIDJenisMeja.Name = "colIDJenisMeja"
        Me.colIDJenisMeja.Visible = True
        Me.colIDJenisMeja.VisibleIndex = 0
        '
        'colNomorMeja
        '
        Me.colNomorMeja.FieldName = "NomorMeja"
        Me.colNomorMeja.Name = "colNomorMeja"
        Me.colNomorMeja.Visible = True
        Me.colNomorMeja.VisibleIndex = 1
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Visible = True
        Me.colKeterangan.VisibleIndex = 2
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colTanggalbook
        '
        Me.colTanggalbook.FieldName = "Tanggalbook"
        Me.colTanggalbook.Name = "colTanggalbook"
        '
        'colJamMulai
        '
        Me.colJamMulai.FieldName = "JamMulai"
        Me.colJamMulai.Name = "colJamMulai"
        '
        'colJamSelesai
        '
        Me.colJamSelesai.FieldName = "JamSelesai"
        Me.colJamSelesai.Name = "colJamSelesai"
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
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 443)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(323, 33)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 5
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.DaftarMejaGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.KeteranganTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NomorMejaLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDJenisMejaTextEdit)
        Me.DataLayoutControl1.DataSource = Me.DaftarMejaBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(347, 488)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'KeteranganTextEdit
        '
        Me.KeteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "Keterangan", True))
        Me.KeteranganTextEdit.Location = New System.Drawing.Point(79, 60)
        Me.KeteranganTextEdit.Name = "KeteranganTextEdit"
        Me.KeteranganTextEdit.Size = New System.Drawing.Size(256, 20)
        Me.KeteranganTextEdit.StyleController = Me.DataLayoutControl1
        Me.KeteranganTextEdit.TabIndex = 3
        '
        'NomorMejaLookUpEdit
        '
        Me.NomorMejaLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "NomorMeja", True))
        Me.NomorMejaLookUpEdit.Location = New System.Drawing.Point(79, 36)
        Me.NomorMejaLookUpEdit.Name = "NomorMejaLookUpEdit"
        Me.NomorMejaLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.NomorMejaLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NomorMejaLookUpEdit.Properties.Mask.EditMask = "N0"
        Me.NomorMejaLookUpEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.NomorMejaLookUpEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.NomorMejaLookUpEdit.Size = New System.Drawing.Size(256, 20)
        Me.NomorMejaLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.NomorMejaLookUpEdit.TabIndex = 2
        '
        'IDJenisMejaTextEdit
        '
        Me.IDJenisMejaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "IDJenisMeja", True))
        Me.IDJenisMejaTextEdit.Location = New System.Drawing.Point(79, 12)
        Me.IDJenisMejaTextEdit.Name = "IDJenisMejaTextEdit"
        Me.IDJenisMejaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDJenisMejaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDJenisMejaTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDJenisMejaTextEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDJenisMeJa", "ID Jenis Me Ja", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JenisMeja", "Jenis Meja", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Keterangan", "Keterangan", 66, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.IDJenisMejaTextEdit.Properties.DataSource = Me.JenisMejaBindingSource
        Me.IDJenisMejaTextEdit.Properties.DisplayMember = "JenisMeja"
        Me.IDJenisMejaTextEdit.Properties.NullText = ""
        Me.IDJenisMejaTextEdit.Properties.ValueMember = "IDJenisMeJa"
        Me.IDJenisMejaTextEdit.Size = New System.Drawing.Size(256, 20)
        Me.IDJenisMejaTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDJenisMejaTextEdit.TabIndex = 0
        '
        'JenisMejaBindingSource
        '
        Me.JenisMejaBindingSource.DataMember = "JenisMeja"
        Me.JenisMejaBindingSource.DataSource = Me.DataSetDaftarMeja
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(347, 488)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDJenisMeja, Me.ItemForNomorMeja, Me.ItemForKeterangan, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(327, 468)
        '
        'ItemForIDJenisMeja
        '
        Me.ItemForIDJenisMeja.Control = Me.IDJenisMejaTextEdit
        Me.ItemForIDJenisMeja.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIDJenisMeja.Name = "ItemForIDJenisMeja"
        Me.ItemForIDJenisMeja.Size = New System.Drawing.Size(327, 24)
        Me.ItemForIDJenisMeja.Text = "ID Jenis Meja"
        Me.ItemForIDJenisMeja.TextSize = New System.Drawing.Size(64, 13)
        '
        'ItemForNomorMeja
        '
        Me.ItemForNomorMeja.Control = Me.NomorMejaLookUpEdit
        Me.ItemForNomorMeja.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNomorMeja.Name = "ItemForNomorMeja"
        Me.ItemForNomorMeja.Size = New System.Drawing.Size(327, 24)
        Me.ItemForNomorMeja.Text = "Nomor Meja"
        Me.ItemForNomorMeja.TextSize = New System.Drawing.Size(64, 13)
        '
        'ItemForKeterangan
        '
        Me.ItemForKeterangan.Control = Me.KeteranganTextEdit
        Me.ItemForKeterangan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForKeterangan.Name = "ItemForKeterangan"
        Me.ItemForKeterangan.Size = New System.Drawing.Size(327, 24)
        Me.ItemForKeterangan.Text = "Keterangan"
        Me.ItemForKeterangan.TextSize = New System.Drawing.Size(64, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DaftarMejaGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(327, 359)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 431)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(327, 37)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'JenisMejaTableAdapter
        '
        Me.JenisMejaTableAdapter.ClearBeforeFill = True
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.JenisMejaBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "JenisMeja"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDJenisMeJa"
        '
        'FormDaftarMeja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 513)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.DaftarMejaBindingNavigator)
        Me.Name = "FormDaftarMeja"
        Me.Text = "FormDaftarMeja"
        CType(Me.DataSetDaftarMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaftarMejaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaftarMejaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DaftarMejaBindingNavigator.ResumeLayout(False)
        Me.DaftarMejaBindingNavigator.PerformLayout()
        CType(Me.DaftarMejaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorMejaLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDJenisMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMejaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDJenisMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNomorMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetDaftarMeja As DataSetDaftarMeja
    Friend WithEvents DaftarMejaBindingSource As BindingSource
    Friend WithEvents DaftarMejaTableAdapter As DataSetDaftarMejaTableAdapters.DaftarMejaTableAdapter
    Friend WithEvents TableAdapterManager As DataSetDaftarMejaTableAdapters.TableAdapterManager
    Friend WithEvents DaftarMejaBindingNavigator As BindingNavigator
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
    Friend WithEvents DaftarMejaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DaftarMejaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDDaftarMeja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDJenisMeja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorMeja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalbook As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJamMulai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJamSelesai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents KeteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForIDJenisMeja As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNomorMeja As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKeterangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents JenisMejaBindingSource As BindingSource
    Friend WithEvents JenisMejaTableAdapter As DataSetDaftarMejaTableAdapters.JenisMejaTableAdapter
    Friend WithEvents NomorMejaLookUpEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IDJenisMejaTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
