<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserProfile))
        Me.DataSetUserProfile = New Cafe_Management.DataSetUserProfile()
        Me.UserProfileBindingSource = New System.Windows.Forms.BindingSource()
        Me.UserProfileTableAdapter = New Cafe_Management.DataSetUserProfileTableAdapters.UserProfileTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetUserProfileTableAdapters.TableAdapterManager()
        Me.UserProfileBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.UserProfileBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserProfileGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ProfileGridBindingSource = New System.Windows.Forms.BindingSource()
        Me.colIDProfile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ProfileGridBindingSource1 = New System.Windows.Forms.BindingSource()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.IDUserLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PenggunaBindingSource = New System.Windows.Forms.BindingSource()
        Me.IDProfileLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForIDUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForIDProfile = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.PenggunaTableAdapter = New Cafe_Management.DataSetUserProfileTableAdapters.PenggunaTableAdapter()
        Me.ProfileTableAdapter = New Cafe_Management.DataSetUserProfileTableAdapters.ProfileTableAdapter()
        Me.ProfileGridTableAdapter = New Cafe_Management.DataSetUserProfileTableAdapters.ProfileGridTableAdapter()
        Me.PenggunaGridBindingSource = New System.Windows.Forms.BindingSource()
        Me.PenggunaGridTableAdapter = New Cafe_Management.DataSetUserProfileTableAdapters.PenggunaGridTableAdapter()
        CType(Me.DataSetUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserProfileBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserProfileBindingNavigator.SuspendLayout()
        CType(Me.UserProfileGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileGridBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDUserLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProfileLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggunaGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetUserProfile
        '
        Me.DataSetUserProfile.DataSetName = "DataSetUserProfile"
        Me.DataSetUserProfile.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserProfileBindingSource
        '
        Me.UserProfileBindingSource.DataMember = "UserProfile"
        Me.UserProfileBindingSource.DataSource = Me.DataSetUserProfile
        '
        'UserProfileTableAdapter
        '
        Me.UserProfileTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetUserProfileTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserProfileTableAdapter = Me.UserProfileTableAdapter
        '
        'UserProfileBindingNavigator
        '
        Me.UserProfileBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserProfileBindingNavigator.BindingSource = Me.UserProfileBindingSource
        Me.UserProfileBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserProfileBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserProfileBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.UserProfileBindingNavigatorSaveItem})
        Me.UserProfileBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UserProfileBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserProfileBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserProfileBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserProfileBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserProfileBindingNavigator.Name = "UserProfileBindingNavigator"
        Me.UserProfileBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserProfileBindingNavigator.Size = New System.Drawing.Size(458, 25)
        Me.UserProfileBindingNavigator.TabIndex = 0
        Me.UserProfileBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'UserProfileBindingNavigatorSaveItem
        '
        Me.UserProfileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserProfileBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserProfileBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserProfileBindingNavigatorSaveItem.Name = "UserProfileBindingNavigatorSaveItem"
        Me.UserProfileBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UserProfileBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserProfileGridControl
        '
        Me.UserProfileGridControl.DataSource = Me.UserProfileBindingSource
        Me.UserProfileGridControl.Location = New System.Drawing.Point(12, 60)
        Me.UserProfileGridControl.MainView = Me.GridView1
        Me.UserProfileGridControl.Name = "UserProfileGridControl"
        Me.UserProfileGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.UserProfileGridControl.Size = New System.Drawing.Size(434, 372)
        Me.UserProfileGridControl.TabIndex = 2
        Me.UserProfileGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDUser, Me.colIDProfile, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.UserProfileGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDUser
        '
        Me.colIDUser.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIDUser.FieldName = "IDUser"
        Me.colIDUser.Name = "colIDUser"
        Me.colIDUser.Visible = True
        Me.colIDUser.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.PenggunaGridBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "UserName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDPengguna"
        '
        'ProfileGridBindingSource
        '
        Me.ProfileGridBindingSource.DataMember = "ProfileGrid"
        Me.ProfileGridBindingSource.DataSource = Me.DataSetUserProfile
        '
        'colIDProfile
        '
        Me.colIDProfile.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colIDProfile.FieldName = "IDProfile"
        Me.colIDProfile.Name = "colIDProfile"
        Me.colIDProfile.Visible = True
        Me.colIDProfile.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ProfileGridBindingSource1
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Profile"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "IDProfile"
        '
        'ProfileGridBindingSource1
        '
        Me.ProfileGridBindingSource1.DataMember = "ProfileGrid"
        Me.ProfileGridBindingSource1.DataSource = Me.DataSetUserProfile
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
        Me.DataLayoutControl1.Controls.Add(Me.UserProfileGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.IDUserLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDProfileLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.UserProfileBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(458, 473)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 436)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(434, 25)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'IDUserLookUpEdit
        '
        Me.IDUserLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserProfileBindingSource, "IDUser", True))
        Me.IDUserLookUpEdit.Location = New System.Drawing.Point(59, 12)
        Me.IDUserLookUpEdit.Name = "IDUserLookUpEdit"
        Me.IDUserLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDUserLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDUserLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDUserLookUpEdit.Properties.DataSource = Me.PenggunaBindingSource
        Me.IDUserLookUpEdit.Properties.DisplayMember = "UserName"
        Me.IDUserLookUpEdit.Properties.NullText = ""
        Me.IDUserLookUpEdit.Properties.ValueMember = "IDPengguna"
        Me.IDUserLookUpEdit.Size = New System.Drawing.Size(387, 20)
        Me.IDUserLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDUserLookUpEdit.TabIndex = 4
        '
        'PenggunaBindingSource
        '
        Me.PenggunaBindingSource.DataMember = "Pengguna"
        Me.PenggunaBindingSource.DataSource = Me.DataSetUserProfile
        '
        'IDProfileLookUpEdit
        '
        Me.IDProfileLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.UserProfileBindingSource, "IDProfile", True))
        Me.IDProfileLookUpEdit.Location = New System.Drawing.Point(59, 36)
        Me.IDProfileLookUpEdit.Name = "IDProfileLookUpEdit"
        Me.IDProfileLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDProfileLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDProfileLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDProfileLookUpEdit.Properties.DataSource = Me.ProfileBindingSource
        Me.IDProfileLookUpEdit.Properties.DisplayMember = "Profile"
        Me.IDProfileLookUpEdit.Properties.NullText = ""
        Me.IDProfileLookUpEdit.Properties.ValueMember = "IDProfile"
        Me.IDProfileLookUpEdit.Size = New System.Drawing.Size(387, 20)
        Me.IDProfileLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDProfileLookUpEdit.TabIndex = 5
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "Profile"
        Me.ProfileBindingSource.DataSource = Me.DataSetUserProfile
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(458, 473)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDUser, Me.ItemForIDProfile, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(438, 453)
        '
        'ItemForIDUser
        '
        Me.ItemForIDUser.Control = Me.IDUserLookUpEdit
        Me.ItemForIDUser.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIDUser.Name = "ItemForIDUser"
        Me.ItemForIDUser.Size = New System.Drawing.Size(438, 24)
        Me.ItemForIDUser.Text = "ID User"
        Me.ItemForIDUser.TextSize = New System.Drawing.Size(44, 13)
        '
        'ItemForIDProfile
        '
        Me.ItemForIDProfile.Control = Me.IDProfileLookUpEdit
        Me.ItemForIDProfile.Location = New System.Drawing.Point(0, 24)
        Me.ItemForIDProfile.Name = "ItemForIDProfile"
        Me.ItemForIDProfile.Size = New System.Drawing.Size(438, 24)
        Me.ItemForIDProfile.Text = "ID Profile"
        Me.ItemForIDProfile.TextSize = New System.Drawing.Size(44, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UserProfileGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(438, 376)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 424)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(438, 29)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'PenggunaTableAdapter
        '
        Me.PenggunaTableAdapter.ClearBeforeFill = True
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'ProfileGridTableAdapter
        '
        Me.ProfileGridTableAdapter.ClearBeforeFill = True
        '
        'PenggunaGridBindingSource
        '
        Me.PenggunaGridBindingSource.DataMember = "PenggunaGrid"
        Me.PenggunaGridBindingSource.DataSource = Me.DataSetUserProfile
        '
        'PenggunaGridTableAdapter
        '
        Me.PenggunaGridTableAdapter.ClearBeforeFill = True
        '
        'FormUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 498)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.UserProfileBindingNavigator)
        Me.Name = "FormUserProfile"
        Me.Text = "FormUserProfile"
        CType(Me.DataSetUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserProfileBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserProfileBindingNavigator.ResumeLayout(False)
        Me.UserProfileBindingNavigator.PerformLayout()
        CType(Me.UserProfileGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileGridBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDUserLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProfileLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggunaGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetUserProfile As DataSetUserProfile
    Friend WithEvents UserProfileBindingSource As BindingSource
    Friend WithEvents UserProfileTableAdapter As DataSetUserProfileTableAdapters.UserProfileTableAdapter
    Friend WithEvents TableAdapterManager As DataSetUserProfileTableAdapters.TableAdapterManager
    Friend WithEvents UserProfileBindingNavigator As BindingNavigator
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
    Friend WithEvents UserProfileBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserProfileGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProfile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents IDUserLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IDProfileLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForIDUser As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDProfile As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PenggunaBindingSource As BindingSource
    Friend WithEvents PenggunaTableAdapter As DataSetUserProfileTableAdapters.PenggunaTableAdapter
    Friend WithEvents ProfileBindingSource As BindingSource
    Friend WithEvents ProfileTableAdapter As DataSetUserProfileTableAdapters.ProfileTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ProfileGridBindingSource As BindingSource
    Friend WithEvents ProfileGridTableAdapter As DataSetUserProfileTableAdapters.ProfileGridTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ProfileGridBindingSource1 As BindingSource
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PenggunaGridBindingSource As BindingSource
    Friend WithEvents PenggunaGridTableAdapter As DataSetUserProfileTableAdapters.PenggunaGridTableAdapter
End Class
