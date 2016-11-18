<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountingCOA
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountingCOA))
    Me.DataSetAccounting = New Cafe_Management.DataSetAccounting()
    Me.COABindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.COATableAdapter = New Cafe_Management.DataSetAccountingTableAdapters.COATableAdapter()
    Me.TableAdapterManager = New Cafe_Management.DataSetAccountingTableAdapters.TableAdapterManager()
    Me.GroupAkunTableAdapter = New Cafe_Management.DataSetAccountingTableAdapters.GroupAkunTableAdapter()
    Me.COABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
    Me.COABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colIDAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIDGroupAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIDAkunInduk = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPosisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.IDGroupAkunLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.GroupAkunBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.IDAkunIndukLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.NoAkunTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.PosisiComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.ItemForIDGroupAkun = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ItemForIDAkunInduk = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ItemForNoAkun = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ItemForPosisi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.DataSetAccounting, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.COABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.COABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.COABindingNavigator.SuspendLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DataLayoutControl1.SuspendLayout()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDGroupAkunLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupAkunBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDAkunIndukLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NoAkunTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PosisiComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDGroupAkun, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDAkunInduk, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNoAkun, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForPosisi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataSetAccounting
    '
    Me.DataSetAccounting.DataSetName = "DataSetAccounting"
    Me.DataSetAccounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'COABindingSource
    '
    Me.COABindingSource.DataMember = "COA"
    Me.COABindingSource.DataSource = Me.DataSetAccounting
    '
    'COATableAdapter
    '
    Me.COATableAdapter.ClearBeforeFill = True
    '
    'TableAdapterManager
    '
    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager.COATableAdapter = Me.COATableAdapter
    Me.TableAdapterManager.GroupAkunTableAdapter = Me.GroupAkunTableAdapter
    Me.TableAdapterManager.GroupTemplateTransaksiTableAdapter = Nothing
    Me.TableAdapterManager.JurnalDTableAdapter = Nothing
    Me.TableAdapterManager.JurnalHTableAdapter = Nothing
    Me.TableAdapterManager.TemplateTransaksiTableAdapter = Nothing
    Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetAccountingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '
    'GroupAkunTableAdapter
    '
    Me.GroupAkunTableAdapter.ClearBeforeFill = True
    '
    'COABindingNavigator
    '
    Me.COABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.COABindingNavigator.BindingSource = Me.COABindingSource
    Me.COABindingNavigator.CountItem = Me.BindingNavigatorCountItem
    Me.COABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.COABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.COABindingNavigatorSaveItem})
    Me.COABindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.COABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.COABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.COABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.COABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.COABindingNavigator.Name = "COABindingNavigator"
    Me.COABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
    Me.COABindingNavigator.Size = New System.Drawing.Size(537, 25)
    Me.COABindingNavigator.TabIndex = 0
    Me.COABindingNavigator.Text = "BindingNavigator1"
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
    'COABindingNavigatorSaveItem
    '
    Me.COABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.COABindingNavigatorSaveItem.Image = CType(resources.GetObject("COABindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.COABindingNavigatorSaveItem.Name = "COABindingNavigatorSaveItem"
    Me.COABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
    Me.COABindingNavigatorSaveItem.Text = "Save Data"
    '
    'DataLayoutControl1
    '
    Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
    Me.DataLayoutControl1.Controls.Add(Me.IDGroupAkunLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.IDAkunIndukLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NoAkunTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.PosisiComboBoxEdit)
    Me.DataLayoutControl1.DataSource = Me.COABindingSource
    Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
    Me.DataLayoutControl1.Name = "DataLayoutControl1"
    Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
    Me.DataLayoutControl1.Size = New System.Drawing.Size(537, 383)
    Me.DataLayoutControl1.TabIndex = 1
    Me.DataLayoutControl1.Text = "DataLayoutControl1"
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.COABindingSource
    Me.GridControl1.Location = New System.Drawing.Point(12, 132)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(513, 239)
    Me.GridControl1.TabIndex = 10
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDAkun, Me.colIDGroupAkun, Me.colIDAkunInduk, Me.colNoAkun, Me.colNama, Me.colPosisi})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'colIDAkun
    '
    Me.colIDAkun.FieldName = "IDAkun"
    Me.colIDAkun.Name = "colIDAkun"
    Me.colIDAkun.Visible = True
    Me.colIDAkun.VisibleIndex = 0
    '
    'colIDGroupAkun
    '
    Me.colIDGroupAkun.FieldName = "IDGroupAkun"
    Me.colIDGroupAkun.Name = "colIDGroupAkun"
    Me.colIDGroupAkun.Visible = True
    Me.colIDGroupAkun.VisibleIndex = 1
    '
    'colIDAkunInduk
    '
    Me.colIDAkunInduk.FieldName = "IDAkunInduk"
    Me.colIDAkunInduk.Name = "colIDAkunInduk"
    Me.colIDAkunInduk.Visible = True
    Me.colIDAkunInduk.VisibleIndex = 2
    '
    'colNoAkun
    '
    Me.colNoAkun.FieldName = "NoAkun"
    Me.colNoAkun.Name = "colNoAkun"
    Me.colNoAkun.Visible = True
    Me.colNoAkun.VisibleIndex = 3
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 4
    '
    'colPosisi
    '
    Me.colPosisi.FieldName = "Posisi"
    Me.colPosisi.Name = "colPosisi"
    Me.colPosisi.Visible = True
    Me.colPosisi.VisibleIndex = 5
    '
    'IDGroupAkunLookUpEdit
    '
    Me.IDGroupAkunLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.COABindingSource, "IDGroupAkun", True))
    Me.IDGroupAkunLookUpEdit.Location = New System.Drawing.Point(71, 12)
    Me.IDGroupAkunLookUpEdit.Name = "IDGroupAkunLookUpEdit"
    Me.IDGroupAkunLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDGroupAkunLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDGroupAkunLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDGroupAkunLookUpEdit.Properties.DataSource = Me.GroupAkunBindingSource
    Me.IDGroupAkunLookUpEdit.Properties.DisplayMember = "Nama"
    Me.IDGroupAkunLookUpEdit.Properties.NullText = ""
    Me.IDGroupAkunLookUpEdit.Properties.ValueMember = "IDGroupAkun"
    Me.IDGroupAkunLookUpEdit.Size = New System.Drawing.Size(454, 20)
    Me.IDGroupAkunLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDGroupAkunLookUpEdit.TabIndex = 5
    '
    'GroupAkunBindingSource
    '
    Me.GroupAkunBindingSource.DataMember = "GroupAkun"
    Me.GroupAkunBindingSource.DataSource = Me.DataSetAccounting
    '
    'IDAkunIndukLookUpEdit
    '
    Me.IDAkunIndukLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.COABindingSource, "IDAkunInduk", True))
    Me.IDAkunIndukLookUpEdit.Location = New System.Drawing.Point(71, 36)
    Me.IDAkunIndukLookUpEdit.Name = "IDAkunIndukLookUpEdit"
    Me.IDAkunIndukLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDAkunIndukLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDAkunIndukLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDAkunIndukLookUpEdit.Properties.DataSource = Me.COABindingSource
    Me.IDAkunIndukLookUpEdit.Properties.DisplayMember = "Nama"
    Me.IDAkunIndukLookUpEdit.Properties.NullText = ""
    Me.IDAkunIndukLookUpEdit.Properties.ValueMember = "IDAkun"
    Me.IDAkunIndukLookUpEdit.Size = New System.Drawing.Size(454, 20)
    Me.IDAkunIndukLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDAkunIndukLookUpEdit.TabIndex = 6
    '
    'NoAkunTextEdit
    '
    Me.NoAkunTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.COABindingSource, "NoAkun", True))
    Me.NoAkunTextEdit.Location = New System.Drawing.Point(71, 60)
    Me.NoAkunTextEdit.Name = "NoAkunTextEdit"
    Me.NoAkunTextEdit.Size = New System.Drawing.Size(454, 20)
    Me.NoAkunTextEdit.StyleController = Me.DataLayoutControl1
    Me.NoAkunTextEdit.TabIndex = 7
    '
    'NamaTextEdit
    '
    Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.COABindingSource, "Nama", True))
    Me.NamaTextEdit.Location = New System.Drawing.Point(71, 84)
    Me.NamaTextEdit.Name = "NamaTextEdit"
    Me.NamaTextEdit.Size = New System.Drawing.Size(454, 20)
    Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
    Me.NamaTextEdit.TabIndex = 8
    '
    'PosisiComboBoxEdit
    '
    Me.PosisiComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.COABindingSource, "Posisi", True))
    Me.PosisiComboBoxEdit.Location = New System.Drawing.Point(71, 108)
    Me.PosisiComboBoxEdit.Name = "PosisiComboBoxEdit"
    Me.PosisiComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.PosisiComboBoxEdit.Properties.Items.AddRange(New Object() {"D", "K"})
    Me.PosisiComboBoxEdit.Size = New System.Drawing.Size(454, 20)
    Me.PosisiComboBoxEdit.StyleController = Me.DataLayoutControl1
    Me.PosisiComboBoxEdit.TabIndex = 9
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(537, 383)
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AllowDrawBackground = False
    Me.LayoutControlGroup2.GroupBordersVisible = False
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDGroupAkun, Me.ItemForIDAkunInduk, Me.ItemForNoAkun, Me.ItemForNama, Me.ItemForPosisi, Me.LayoutControlItem1})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(517, 363)
    '
    'ItemForIDGroupAkun
    '
    Me.ItemForIDGroupAkun.Control = Me.IDGroupAkunLookUpEdit
    Me.ItemForIDGroupAkun.Location = New System.Drawing.Point(0, 0)
    Me.ItemForIDGroupAkun.Name = "ItemForIDGroupAkun"
    Me.ItemForIDGroupAkun.Size = New System.Drawing.Size(517, 24)
    Me.ItemForIDGroupAkun.Text = "Group Akun"
    Me.ItemForIDGroupAkun.TextSize = New System.Drawing.Size(56, 13)
    '
    'ItemForIDAkunInduk
    '
    Me.ItemForIDAkunInduk.Control = Me.IDAkunIndukLookUpEdit
    Me.ItemForIDAkunInduk.Location = New System.Drawing.Point(0, 24)
    Me.ItemForIDAkunInduk.Name = "ItemForIDAkunInduk"
    Me.ItemForIDAkunInduk.Size = New System.Drawing.Size(517, 24)
    Me.ItemForIDAkunInduk.Text = "Akun Induk"
    Me.ItemForIDAkunInduk.TextSize = New System.Drawing.Size(56, 13)
    '
    'ItemForNoAkun
    '
    Me.ItemForNoAkun.Control = Me.NoAkunTextEdit
    Me.ItemForNoAkun.Location = New System.Drawing.Point(0, 48)
    Me.ItemForNoAkun.Name = "ItemForNoAkun"
    Me.ItemForNoAkun.Size = New System.Drawing.Size(517, 24)
    Me.ItemForNoAkun.Text = "No Akun"
    Me.ItemForNoAkun.TextSize = New System.Drawing.Size(56, 13)
    '
    'ItemForNama
    '
    Me.ItemForNama.Control = Me.NamaTextEdit
    Me.ItemForNama.Location = New System.Drawing.Point(0, 72)
    Me.ItemForNama.Name = "ItemForNama"
    Me.ItemForNama.Size = New System.Drawing.Size(517, 24)
    Me.ItemForNama.Text = "Nama"
    Me.ItemForNama.TextSize = New System.Drawing.Size(56, 13)
    '
    'ItemForPosisi
    '
    Me.ItemForPosisi.Control = Me.PosisiComboBoxEdit
    Me.ItemForPosisi.Location = New System.Drawing.Point(0, 96)
    Me.ItemForPosisi.Name = "ItemForPosisi"
    Me.ItemForPosisi.Size = New System.Drawing.Size(517, 24)
    Me.ItemForPosisi.Text = "Posisi"
    Me.ItemForPosisi.TextSize = New System.Drawing.Size(56, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.GridControl1
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 120)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(517, 243)
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextVisible = False
    '
    'FormAccountingCOA
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(537, 408)
    Me.Controls.Add(Me.DataLayoutControl1)
    Me.Controls.Add(Me.COABindingNavigator)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "FormAccountingCOA"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Chart Of Accounts"
    CType(Me.DataSetAccounting, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.COABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.COABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    Me.COABindingNavigator.ResumeLayout(False)
    Me.COABindingNavigator.PerformLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DataLayoutControl1.ResumeLayout(False)
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDGroupAkunLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupAkunBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDAkunIndukLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NoAkunTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PosisiComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDGroupAkun, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDAkunInduk, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNoAkun, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForPosisi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataSetAccounting As Cafe_Management.DataSetAccounting
  Friend WithEvents COABindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents COATableAdapter As Cafe_Management.DataSetAccountingTableAdapters.COATableAdapter
  Friend WithEvents TableAdapterManager As Cafe_Management.DataSetAccountingTableAdapters.TableAdapterManager
  Friend WithEvents COABindingNavigator As System.Windows.Forms.BindingNavigator
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
  Friend WithEvents COABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents GroupAkunTableAdapter As Cafe_Management.DataSetAccountingTableAdapters.GroupAkunTableAdapter
  Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colIDAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIDGroupAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIDAkunInduk As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPosisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents IDGroupAkunLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents IDAkunIndukLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents NoAkunTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents PosisiComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents ItemForIDGroupAkun As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForIDAkunInduk As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNoAkun As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNama As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForPosisi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents GroupAkunBindingSource As System.Windows.Forms.BindingSource
End Class
