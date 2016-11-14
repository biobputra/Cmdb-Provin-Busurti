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
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidJenisMeja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.JenisMejaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.colNomorMeja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.NomorMejaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KeteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idJenisMejaTextEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.idTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForid = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForidJenisMeja = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNomorMeja = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKeterangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.JenisMejaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JenisMejaTableAdapter = New Cafe_Management.DataSetDaftarMejaTableAdapters.JenisMejaTableAdapter()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetDaftarMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaftarMejaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaftarMejaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DaftarMejaBindingNavigator.SuspendLayout()
        CType(Me.DaftarMejaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMejaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.NomorMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idJenisMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidJenisMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNomorMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMejaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DaftarMejaBindingNavigator.Size = New System.Drawing.Size(339, 25)
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
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
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
        Me.DaftarMejaGridControl.Size = New System.Drawing.Size(315, 339)
        Me.DaftarMejaGridControl.TabIndex = 2
        Me.DaftarMejaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colidJenisMeja, Me.colNomorMeja, Me.colKeterangan, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.DaftarMejaGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colidJenisMeja
        '
        Me.colidJenisMeja.Caption = "Jenis Meja"
        Me.colidJenisMeja.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colidJenisMeja.FieldName = "idJenisMeja"
        Me.colidJenisMeja.Name = "colidJenisMeja"
        Me.colidJenisMeja.Visible = True
        Me.colidJenisMeja.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.JenisMejaBindingSource1
        Me.RepositoryItemLookUpEdit1.DisplayMember = "JenisMeja"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDJenisMeJa"
        '
        'JenisMejaBindingSource1
        '
        Me.JenisMejaBindingSource1.DataMember = "JenisMeja"
        Me.JenisMejaBindingSource1.DataSource = Me.DataSetDaftarMeja
        '
        'colNomorMeja
        '
        Me.colNomorMeja.Caption = "Nomor Meja"
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
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.DaftarMejaGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.NomorMejaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KeteranganTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idJenisMejaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idTextEdit)
        Me.DataLayoutControl1.DataSource = Me.DaftarMejaBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForid})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(610, 79, 481, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(339, 464)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'NomorMejaTextEdit
        '
        Me.NomorMejaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "NomorMeja", True))
        Me.NomorMejaTextEdit.Location = New System.Drawing.Point(72, 36)
        Me.NomorMejaTextEdit.Name = "NomorMejaTextEdit"
        Me.NomorMejaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.NomorMejaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NomorMejaTextEdit.Properties.Mask.EditMask = "N0"
        Me.NomorMejaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.NomorMejaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.NomorMejaTextEdit.Size = New System.Drawing.Size(255, 20)
        Me.NomorMejaTextEdit.StyleController = Me.DataLayoutControl1
        Me.NomorMejaTextEdit.TabIndex = 5
        '
        'KeteranganTextEdit
        '
        Me.KeteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "Keterangan", True))
        Me.KeteranganTextEdit.Location = New System.Drawing.Point(72, 60)
        Me.KeteranganTextEdit.Name = "KeteranganTextEdit"
        Me.KeteranganTextEdit.Size = New System.Drawing.Size(255, 20)
        Me.KeteranganTextEdit.StyleController = Me.DataLayoutControl1
        Me.KeteranganTextEdit.TabIndex = 6
        '
        'idJenisMejaTextEdit
        '
        Me.idJenisMejaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "idJenisMeja", True))
        Me.idJenisMejaTextEdit.Location = New System.Drawing.Point(72, 12)
        Me.idJenisMejaTextEdit.Name = "idJenisMejaTextEdit"
        Me.idJenisMejaTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idJenisMejaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idJenisMejaTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idJenisMejaTextEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDJenisMeJa", "ID Jenis Me Ja", 92, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JenisMeja", "Jenis Meja", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Keterangan", "Keterangan", 66, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.idJenisMejaTextEdit.Properties.DataSource = Me.JenisMejaBindingSource1
        Me.idJenisMejaTextEdit.Properties.DisplayMember = "JenisMeja"
        Me.idJenisMejaTextEdit.Properties.NullText = ""
        Me.idJenisMejaTextEdit.Properties.ValueMember = "IDJenisMeJa"
        Me.idJenisMejaTextEdit.Size = New System.Drawing.Size(255, 20)
        Me.idJenisMejaTextEdit.StyleController = Me.DataLayoutControl1
        Me.idJenisMejaTextEdit.TabIndex = 4
        '
        'idTextEdit
        '
        Me.idTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DaftarMejaBindingSource, "id", True))
        Me.idTextEdit.Location = New System.Drawing.Point(12, 84)
        Me.idTextEdit.Name = "idTextEdit"
        Me.idTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTextEdit.Properties.Mask.EditMask = "N0"
        Me.idTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.idTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.idTextEdit.Size = New System.Drawing.Size(293, 20)
        Me.idTextEdit.StyleController = Me.DataLayoutControl1
        Me.idTextEdit.TabIndex = 7
        '
        'ItemForid
        '
        Me.ItemForid.Control = Me.idTextEdit
        Me.ItemForid.Location = New System.Drawing.Point(0, 72)
        Me.ItemForid.Name = "ItemForid"
        Me.ItemForid.Size = New System.Drawing.Size(297, 116)
        Me.ItemForid.Text = "id"
        Me.ItemForid.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForid.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(339, 464)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForidJenisMeja, Me.ItemForNomorMeja, Me.ItemForKeterangan, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(319, 444)
        '
        'ItemForidJenisMeja
        '
        Me.ItemForidJenisMeja.Control = Me.idJenisMejaTextEdit
        Me.ItemForidJenisMeja.Location = New System.Drawing.Point(0, 0)
        Me.ItemForidJenisMeja.Name = "ItemForidJenisMeja"
        Me.ItemForidJenisMeja.Size = New System.Drawing.Size(319, 24)
        Me.ItemForidJenisMeja.Text = "Jenis Meja"
        Me.ItemForidJenisMeja.TextSize = New System.Drawing.Size(57, 13)
        '
        'ItemForNomorMeja
        '
        Me.ItemForNomorMeja.Control = Me.NomorMejaTextEdit
        Me.ItemForNomorMeja.Location = New System.Drawing.Point(0, 24)
        Me.ItemForNomorMeja.Name = "ItemForNomorMeja"
        Me.ItemForNomorMeja.Size = New System.Drawing.Size(319, 24)
        Me.ItemForNomorMeja.Text = "Nomor Meja"
        Me.ItemForNomorMeja.TextSize = New System.Drawing.Size(57, 13)
        '
        'ItemForKeterangan
        '
        Me.ItemForKeterangan.Control = Me.KeteranganTextEdit
        Me.ItemForKeterangan.Location = New System.Drawing.Point(0, 48)
        Me.ItemForKeterangan.Name = "ItemForKeterangan"
        Me.ItemForKeterangan.Size = New System.Drawing.Size(319, 24)
        Me.ItemForKeterangan.Text = "Keterangan"
        Me.ItemForKeterangan.TextSize = New System.Drawing.Size(57, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.DaftarMejaGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(319, 343)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'JenisMejaBindingSource
        '
        Me.JenisMejaBindingSource.DataMember = "JenisMeja"
        Me.JenisMejaBindingSource.DataSource = Me.DataSetDaftarMeja
        '
        'JenisMejaTableAdapter
        '
        Me.JenisMejaTableAdapter.ClearBeforeFill = True
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 427)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(315, 25)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 415)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(319, 29)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormDaftarMeja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 489)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.DaftarMejaBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormDaftarMeja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDaftarMeja"
        CType(Me.DataSetDaftarMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaftarMejaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaftarMejaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DaftarMejaBindingNavigator.ResumeLayout(False)
        Me.DaftarMejaBindingNavigator.PerformLayout()
        CType(Me.DaftarMejaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMejaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.NomorMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idJenisMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidJenisMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNomorMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMejaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidJenisMeja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorMeja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents JenisMejaBindingSource As BindingSource
    Friend WithEvents JenisMejaTableAdapter As DataSetDaftarMejaTableAdapters.JenisMejaTableAdapter
    Friend WithEvents NomorMejaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KeteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents idJenisMejaTextEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents JenisMejaBindingSource1 As BindingSource
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForidJenisMeja As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNomorMeja As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKeterangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents idTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForid As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
