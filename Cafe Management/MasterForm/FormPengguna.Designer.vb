<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPengguna))
        Me.DataSetUser = New Cafe_Management.DataSetUser()
        Me.PenggunaBindingSource = New System.Windows.Forms.BindingSource()
        Me.PenggunaTableAdapter = New Cafe_Management.DataSetUserTableAdapters.PenggunaTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetUserTableAdapters.TableAdapterManager()
        Me.PenggunaBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.PenggunaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PenggunaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPengguna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.KaryawanGridBindingSource = New System.Windows.Forms.BindingSource()
        Me.colUserName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDigitalSignature = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.IDKaryawanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource()
        Me.UserNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UserPicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.DigitalSignaturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForIDKaryawan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUserName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForUserPicture = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForDigitalSignature = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ItemForPassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.KaryawanTableAdapter = New Cafe_Management.DataSetUserTableAdapters.KaryawanTableAdapter()
        Me.KaryawanGridTableAdapter = New Cafe_Management.DataSetUserTableAdapters.KaryawanGridTableAdapter()
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenggunaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PenggunaBindingNavigator.SuspendLayout()
        CType(Me.PenggunaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDKaryawanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalSignaturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForUserPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForDigitalSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetUser
        '
        Me.DataSetUser.DataSetName = "DataSetUser"
        Me.DataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenggunaBindingSource
        '
        Me.PenggunaBindingSource.DataMember = "Pengguna"
        Me.PenggunaBindingSource.DataSource = Me.DataSetUser
        '
        'PenggunaTableAdapter
        '
        Me.PenggunaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PenggunaTableAdapter = Me.PenggunaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PenggunaBindingNavigator
        '
        Me.PenggunaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PenggunaBindingNavigator.BindingSource = Me.PenggunaBindingSource
        Me.PenggunaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PenggunaBindingNavigator.DeleteItem = Nothing
        Me.PenggunaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.PenggunaBindingNavigatorSaveItem})
        Me.PenggunaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PenggunaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PenggunaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PenggunaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PenggunaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PenggunaBindingNavigator.Name = "PenggunaBindingNavigator"
        Me.PenggunaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PenggunaBindingNavigator.Size = New System.Drawing.Size(1073, 25)
        Me.PenggunaBindingNavigator.TabIndex = 0
        Me.PenggunaBindingNavigator.Text = "BindingNavigator1"
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
        'PenggunaBindingNavigatorSaveItem
        '
        Me.PenggunaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PenggunaBindingNavigatorSaveItem.Image = CType(resources.GetObject("PenggunaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PenggunaBindingNavigatorSaveItem.Name = "PenggunaBindingNavigatorSaveItem"
        Me.PenggunaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PenggunaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PenggunaGridControl
        '
        Me.PenggunaGridControl.DataSource = Me.PenggunaBindingSource
        Me.PenggunaGridControl.Location = New System.Drawing.Point(12, 230)
        Me.PenggunaGridControl.MainView = Me.GridView1
        Me.PenggunaGridControl.Name = "PenggunaGridControl"
        Me.PenggunaGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.PenggunaGridControl.Size = New System.Drawing.Size(1049, 196)
        Me.PenggunaGridControl.TabIndex = 5
        Me.PenggunaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPengguna, Me.colIDKaryawan, Me.colUserName, Me.colPassword, Me.colUserPicture, Me.colDigitalSignature, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.PenggunaGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDPengguna
        '
        Me.colIDPengguna.FieldName = "IDPengguna"
        Me.colIDPengguna.Name = "colIDPengguna"
        '
        'colIDKaryawan
        '
        Me.colIDKaryawan.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIDKaryawan.FieldName = "IDKaryawan"
        Me.colIDKaryawan.Name = "colIDKaryawan"
        Me.colIDKaryawan.Visible = True
        Me.colIDKaryawan.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.KaryawanGridBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "NamaLengkap"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDKaryawan"
        '
        'KaryawanGridBindingSource
        '
        Me.KaryawanGridBindingSource.DataMember = "KaryawanGrid"
        Me.KaryawanGridBindingSource.DataSource = Me.DataSetUser
        '
        'colUserName
        '
        Me.colUserName.FieldName = "UserName"
        Me.colUserName.Name = "colUserName"
        Me.colUserName.Visible = True
        Me.colUserName.VisibleIndex = 1
        '
        'colPassword
        '
        Me.colPassword.FieldName = "Password"
        Me.colPassword.Name = "colPassword"
        '
        'colUserPicture
        '
        Me.colUserPicture.FieldName = "UserPicture"
        Me.colUserPicture.Name = "colUserPicture"
        '
        'colDigitalSignature
        '
        Me.colDigitalSignature.FieldName = "DigitalSignature"
        Me.colDigitalSignature.Name = "colDigitalSignature"
        Me.colDigitalSignature.Visible = True
        Me.colDigitalSignature.VisibleIndex = 2
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
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 430)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active User"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive User")})
        Me.RadioGroup1.Size = New System.Drawing.Size(481, 25)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 6
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.TextEdit1)
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.PenggunaGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.IDKaryawanLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UserNameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PasswordTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.UserPicturePictureEdit)
        Me.DataLayoutControl1.Controls.Add(Me.DigitalSignaturePictureEdit)
        Me.DataLayoutControl1.DataSource = Me.PenggunaBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForUserPicture})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(293, 223, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1073, 467)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(126, 84)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.UseSystemPasswordChar = True
        Me.TextEdit1.Size = New System.Drawing.Size(293, 20)
        Me.TextEdit1.StyleController = Me.DataLayoutControl1
        Me.TextEdit1.TabIndex = 4
        '
        'IDKaryawanLookUpEdit
        '
        Me.IDKaryawanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenggunaBindingSource, "IDKaryawan", True))
        Me.IDKaryawanLookUpEdit.Location = New System.Drawing.Point(126, 12)
        Me.IDKaryawanLookUpEdit.Name = "IDKaryawanLookUpEdit"
        Me.IDKaryawanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDKaryawanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDKaryawanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDKaryawanLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDKaryawan", "ID Karyawan", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NamaLengkap", "Nama Lengkap", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NoKTP", "No KTP", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.IDKaryawanLookUpEdit.Properties.DataSource = Me.KaryawanBindingSource
        Me.IDKaryawanLookUpEdit.Properties.DisplayMember = "NamaLengkap"
        Me.IDKaryawanLookUpEdit.Properties.NullText = ""
        Me.IDKaryawanLookUpEdit.Properties.ValueMember = "IDKaryawan"
        Me.IDKaryawanLookUpEdit.Size = New System.Drawing.Size(293, 20)
        Me.IDKaryawanLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDKaryawanLookUpEdit.TabIndex = 0
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "Karyawan"
        Me.KaryawanBindingSource.DataSource = Me.DataSetUser
        '
        'UserNameTextEdit
        '
        Me.UserNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenggunaBindingSource, "UserName", True))
        Me.UserNameTextEdit.Location = New System.Drawing.Point(126, 36)
        Me.UserNameTextEdit.Name = "UserNameTextEdit"
        Me.UserNameTextEdit.Size = New System.Drawing.Size(293, 20)
        Me.UserNameTextEdit.StyleController = Me.DataLayoutControl1
        Me.UserNameTextEdit.TabIndex = 2
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenggunaBindingSource, "Password", True))
        Me.PasswordTextEdit.Location = New System.Drawing.Point(126, 60)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Properties.UseSystemPasswordChar = True
        Me.PasswordTextEdit.Size = New System.Drawing.Size(293, 20)
        Me.PasswordTextEdit.StyleController = Me.DataLayoutControl1
        Me.PasswordTextEdit.TabIndex = 3
        '
        'UserPicturePictureEdit
        '
        Me.UserPicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.UserPicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenggunaBindingSource, "UserPicture", True))
        Me.UserPicturePictureEdit.Location = New System.Drawing.Point(423, 28)
        Me.UserPicturePictureEdit.Name = "UserPicturePictureEdit"
        Me.UserPicturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.UserPicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.UserPicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.UserPicturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.UserPicturePictureEdit.Size = New System.Drawing.Size(165, 198)
        Me.UserPicturePictureEdit.StyleController = Me.DataLayoutControl1
        Me.UserPicturePictureEdit.TabIndex = 1
        '
        'DigitalSignaturePictureEdit
        '
        Me.DigitalSignaturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.DigitalSignaturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PenggunaBindingSource, "DigitalSignature", True))
        Me.DigitalSignaturePictureEdit.Location = New System.Drawing.Point(423, 28)
        Me.DigitalSignaturePictureEdit.Name = "DigitalSignaturePictureEdit"
        Me.DigitalSignaturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.DigitalSignaturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.DigitalSignaturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.DigitalSignaturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.DigitalSignaturePictureEdit.Size = New System.Drawing.Size(638, 198)
        Me.DigitalSignaturePictureEdit.StyleController = Me.DataLayoutControl1
        Me.DigitalSignaturePictureEdit.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1073, 467)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDKaryawan, Me.ItemForUserName, Me.ItemForDigitalSignature, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.ItemForPassword, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1053, 447)
        '
        'ItemForIDKaryawan
        '
        Me.ItemForIDKaryawan.Control = Me.IDKaryawanLookUpEdit
        Me.ItemForIDKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIDKaryawan.Name = "ItemForIDKaryawan"
        Me.ItemForIDKaryawan.Size = New System.Drawing.Size(411, 24)
        Me.ItemForIDKaryawan.Text = "Karyawan"
        Me.ItemForIDKaryawan.TextSize = New System.Drawing.Size(111, 13)
        '
        'ItemForUserName
        '
        Me.ItemForUserName.Control = Me.UserNameTextEdit
        Me.ItemForUserName.Location = New System.Drawing.Point(0, 24)
        Me.ItemForUserName.Name = "ItemForUserName"
        Me.ItemForUserName.Size = New System.Drawing.Size(411, 24)
        Me.ItemForUserName.Text = "User Name"
        Me.ItemForUserName.TextSize = New System.Drawing.Size(111, 13)
        '
        'ItemForUserPicture
        '
        Me.ItemForUserPicture.Control = Me.UserPicturePictureEdit
        Me.ItemForUserPicture.Location = New System.Drawing.Point(411, 0)
        Me.ItemForUserPicture.Name = "ItemForUserPicture"
        Me.ItemForUserPicture.Size = New System.Drawing.Size(169, 218)
        Me.ItemForUserPicture.StartNewLine = True
        Me.ItemForUserPicture.Text = "User Picture"
        Me.ItemForUserPicture.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForUserPicture.TextSize = New System.Drawing.Size(111, 13)
        '
        'ItemForDigitalSignature
        '
        Me.ItemForDigitalSignature.Control = Me.DigitalSignaturePictureEdit
        Me.ItemForDigitalSignature.Location = New System.Drawing.Point(411, 0)
        Me.ItemForDigitalSignature.Name = "ItemForDigitalSignature"
        Me.ItemForDigitalSignature.Size = New System.Drawing.Size(642, 218)
        Me.ItemForDigitalSignature.StartNewLine = True
        Me.ItemForDigitalSignature.Text = "Digital Signature"
        Me.ItemForDigitalSignature.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForDigitalSignature.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PenggunaGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 218)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1053, 200)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(411, 122)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ItemForPassword
        '
        Me.ItemForPassword.Control = Me.PasswordTextEdit
        Me.ItemForPassword.Location = New System.Drawing.Point(0, 48)
        Me.ItemForPassword.Name = "ItemForPassword"
        Me.ItemForPassword.Size = New System.Drawing.Size(411, 24)
        Me.ItemForPassword.Text = "Password"
        Me.ItemForPassword.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.TextEdit1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(411, 24)
        Me.LayoutControlItem2.Text = "Confirm Your Password"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(111, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.RadioGroup1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 418)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(485, 29)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(485, 418)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(568, 29)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'KaryawanGridTableAdapter
        '
        Me.KaryawanGridTableAdapter.ClearBeforeFill = True
        '
        'FormPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 492)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.PenggunaBindingNavigator)
        Me.Name = "FormPengguna"
        Me.Text = "FormPengguna"
        CType(Me.DataSetUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenggunaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PenggunaBindingNavigator.ResumeLayout(False)
        Me.PenggunaBindingNavigator.PerformLayout()
        CType(Me.PenggunaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDKaryawanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalSignaturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForUserPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForDigitalSignature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetUser As DataSetUser
    Friend WithEvents PenggunaBindingSource As BindingSource
    Friend WithEvents PenggunaTableAdapter As DataSetUserTableAdapters.PenggunaTableAdapter
    Friend WithEvents TableAdapterManager As DataSetUserTableAdapters.TableAdapterManager
    Friend WithEvents PenggunaBindingNavigator As BindingNavigator
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
    Friend WithEvents PenggunaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PenggunaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPengguna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDKaryawan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDigitalSignature As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents IDKaryawanLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UserNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UserPicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DigitalSignaturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForIDKaryawan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUserName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForUserPicture As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForDigitalSignature As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents KaryawanBindingSource As BindingSource
    Friend WithEvents KaryawanTableAdapter As DataSetUserTableAdapters.KaryawanTableAdapter
    Friend WithEvents KaryawanGridBindingSource As BindingSource
    Friend WithEvents KaryawanGridTableAdapter As DataSetUserTableAdapters.KaryawanGridTableAdapter
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
