<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Me.DataSetSuppier = New Cafe_Management.DataSetSuppier()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource()
        Me.SupplierTableAdapter = New Cafe_Management.DataSetSuppierTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetSuppierTableAdapters.TableAdapterManager()
        Me.SupplierBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.SupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SupplierGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompany = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodePos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelephone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFaximile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHomepage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TitleBindingSource = New System.Windows.Forms.BindingSource()
        Me.TitleTableAdapter = New Cafe_Management.DataSetSuppierTableAdapters.TitleTableAdapter()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.CompanyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContactNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContactTitleLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.AlamatMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.KotaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KodePosTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelephoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FaximileTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HomepageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.emailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForContactName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForContactTitle = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAlamat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForCompany = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForKota = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKodePos = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForTelephone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForFaximile = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForHomepage = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForemail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForLogo = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetSuppier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierBindingNavigator.SuspendLayout()
        CType(Me.SupplierGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KotaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KodePosTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelephoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FaximileTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomepageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForContactTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKodePos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForFaximile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForHomepage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSuppier
        '
        Me.DataSetSuppier.DataSetName = "DataSetSuppier"
        Me.DataSetSuppier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DataSetSuppier
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetSuppierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierBindingNavigator
        '
        Me.SupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SupplierBindingNavigator.BindingSource = Me.SupplierBindingSource
        Me.SupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SupplierBindingNavigator.DeleteItem = Nothing
        Me.SupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.SupplierBindingNavigatorSaveItem})
        Me.SupplierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SupplierBindingNavigator.Name = "SupplierBindingNavigator"
        Me.SupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SupplierBindingNavigator.Size = New System.Drawing.Size(750, 25)
        Me.SupplierBindingNavigator.TabIndex = 0
        Me.SupplierBindingNavigator.Text = "BindingNavigator1"
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
        'SupplierBindingNavigatorSaveItem
        '
        Me.SupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("SupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SupplierBindingNavigatorSaveItem.Name = "SupplierBindingNavigatorSaveItem"
        Me.SupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SupplierGridControl
        '
        Me.SupplierGridControl.DataSource = Me.SupplierBindingSource
        Me.SupplierGridControl.Location = New System.Drawing.Point(12, 198)
        Me.SupplierGridControl.MainView = Me.GridView1
        Me.SupplierGridControl.Name = "SupplierGridControl"
        Me.SupplierGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.SupplierGridControl.Size = New System.Drawing.Size(726, 311)
        Me.SupplierGridControl.TabIndex = 2
        Me.SupplierGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDSupplier, Me.colCompany, Me.colContactName, Me.colContactTitle, Me.colAlamat, Me.colKota, Me.colKodePos, Me.colTelephone, Me.colFaximile, Me.colHomepage, Me.colemail, Me.colLogo, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.SupplierGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDSupplier
        '
        Me.colIDSupplier.FieldName = "IDSupplier"
        Me.colIDSupplier.Name = "colIDSupplier"
        '
        'colCompany
        '
        Me.colCompany.FieldName = "Company"
        Me.colCompany.Name = "colCompany"
        Me.colCompany.Visible = True
        Me.colCompany.VisibleIndex = 0
        '
        'colContactName
        '
        Me.colContactName.FieldName = "ContactName"
        Me.colContactName.Name = "colContactName"
        Me.colContactName.Visible = True
        Me.colContactName.VisibleIndex = 1
        '
        'colContactTitle
        '
        Me.colContactTitle.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colContactTitle.FieldName = "ContactTitle"
        Me.colContactTitle.Name = "colContactTitle"
        Me.colContactTitle.Visible = True
        Me.colContactTitle.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.TitleBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Title"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDTitle"
        '
        'colAlamat
        '
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 3
        '
        'colKota
        '
        Me.colKota.FieldName = "Kota"
        Me.colKota.Name = "colKota"
        Me.colKota.Visible = True
        Me.colKota.VisibleIndex = 4
        '
        'colKodePos
        '
        Me.colKodePos.FieldName = "KodePos"
        Me.colKodePos.Name = "colKodePos"
        Me.colKodePos.Visible = True
        Me.colKodePos.VisibleIndex = 5
        '
        'colTelephone
        '
        Me.colTelephone.FieldName = "Telephone"
        Me.colTelephone.Name = "colTelephone"
        Me.colTelephone.Visible = True
        Me.colTelephone.VisibleIndex = 6
        '
        'colFaximile
        '
        Me.colFaximile.FieldName = "Faximile"
        Me.colFaximile.Name = "colFaximile"
        Me.colFaximile.Visible = True
        Me.colFaximile.VisibleIndex = 7
        '
        'colHomepage
        '
        Me.colHomepage.FieldName = "Homepage"
        Me.colHomepage.Name = "colHomepage"
        Me.colHomepage.Visible = True
        Me.colHomepage.VisibleIndex = 8
        '
        'colemail
        '
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.Visible = True
        Me.colemail.VisibleIndex = 9
        '
        'colLogo
        '
        Me.colLogo.FieldName = "Logo"
        Me.colLogo.Name = "colLogo"
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
        'TitleBindingSource
        '
        Me.TitleBindingSource.DataMember = "Title"
        Me.TitleBindingSource.DataSource = Me.DataSetSuppier
        '
        'TitleTableAdapter
        '
        Me.TitleTableAdapter.ClearBeforeFill = True
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.SupplierGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.CompanyTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ContactNameTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.ContactTitleLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AlamatMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KotaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KodePosTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TelephoneTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.FaximileTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.HomepageTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.emailTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.LogoPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.SupplierBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(987, 222, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(750, 548)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 513)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Supplier"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Supplier")})
        Me.RadioGroup1.Size = New System.Drawing.Size(294, 23)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'CompanyTextEdit
        '
        Me.CompanyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Company", True))
        Me.CompanyTextEdit.Location = New System.Drawing.Point(95, 42)
        Me.CompanyTextEdit.Name = "CompanyTextEdit"
        Me.CompanyTextEdit.Size = New System.Drawing.Size(183, 20)
        Me.CompanyTextEdit.StyleController = Me.DataLayoutControl1
        Me.CompanyTextEdit.TabIndex = 4
        '
        'ContactNameTextEdit
        '
        Me.ContactNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "ContactName", True))
        Me.ContactNameTextEdit.Location = New System.Drawing.Point(95, 66)
        Me.ContactNameTextEdit.Name = "ContactNameTextEdit"
        Me.ContactNameTextEdit.Size = New System.Drawing.Size(183, 20)
        Me.ContactNameTextEdit.StyleController = Me.DataLayoutControl1
        Me.ContactNameTextEdit.TabIndex = 5
        '
        'ContactTitleLookUpEdit
        '
        Me.ContactTitleLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "ContactTitle", True))
        Me.ContactTitleLookUpEdit.Location = New System.Drawing.Point(95, 90)
        Me.ContactTitleLookUpEdit.Name = "ContactTitleLookUpEdit"
        Me.ContactTitleLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ContactTitleLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ContactTitleLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ContactTitleLookUpEdit.Properties.DataSource = Me.TitleBindingSource
        Me.ContactTitleLookUpEdit.Properties.DisplayMember = "Title"
        Me.ContactTitleLookUpEdit.Properties.NullText = ""
        Me.ContactTitleLookUpEdit.Properties.ValueMember = "IDTitle"
        Me.ContactTitleLookUpEdit.Size = New System.Drawing.Size(183, 20)
        Me.ContactTitleLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.ContactTitleLookUpEdit.TabIndex = 6
        '
        'AlamatMemoEdit
        '
        Me.AlamatMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Alamat", True))
        Me.AlamatMemoEdit.Location = New System.Drawing.Point(95, 114)
        Me.AlamatMemoEdit.Name = "AlamatMemoEdit"
        Me.AlamatMemoEdit.Size = New System.Drawing.Size(183, 68)
        Me.AlamatMemoEdit.StyleController = Me.DataLayoutControl1
        Me.AlamatMemoEdit.TabIndex = 7
        '
        'KotaTextEdit
        '
        Me.KotaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Kota", True))
        Me.KotaTextEdit.Location = New System.Drawing.Point(377, 42)
        Me.KotaTextEdit.Name = "KotaTextEdit"
        Me.KotaTextEdit.Size = New System.Drawing.Size(176, 20)
        Me.KotaTextEdit.StyleController = Me.DataLayoutControl1
        Me.KotaTextEdit.TabIndex = 8
        '
        'KodePosTextEdit
        '
        Me.KodePosTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "KodePos", True))
        Me.KodePosTextEdit.Location = New System.Drawing.Point(377, 66)
        Me.KodePosTextEdit.Name = "KodePosTextEdit"
        Me.KodePosTextEdit.Size = New System.Drawing.Size(176, 20)
        Me.KodePosTextEdit.StyleController = Me.DataLayoutControl1
        Me.KodePosTextEdit.TabIndex = 9
        '
        'TelephoneTextEdit
        '
        Me.TelephoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Telephone", True))
        Me.TelephoneTextEdit.Location = New System.Drawing.Point(377, 90)
        Me.TelephoneTextEdit.Name = "TelephoneTextEdit"
        Me.TelephoneTextEdit.Properties.Mask.BeepOnError = True
        Me.TelephoneTextEdit.Properties.Mask.EditMask = "(9999) 000-0000"
        Me.TelephoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TelephoneTextEdit.Properties.Mask.SaveLiteral = False
        Me.TelephoneTextEdit.Size = New System.Drawing.Size(176, 20)
        Me.TelephoneTextEdit.StyleController = Me.DataLayoutControl1
        Me.TelephoneTextEdit.TabIndex = 10
        '
        'FaximileTextEdit
        '
        Me.FaximileTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Faximile", True))
        Me.FaximileTextEdit.Location = New System.Drawing.Point(377, 114)
        Me.FaximileTextEdit.Name = "FaximileTextEdit"
        Me.FaximileTextEdit.Properties.Mask.EditMask = "(9999) 000-0000"
        Me.FaximileTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.FaximileTextEdit.Size = New System.Drawing.Size(176, 20)
        Me.FaximileTextEdit.StyleController = Me.DataLayoutControl1
        Me.FaximileTextEdit.TabIndex = 11
        '
        'HomepageTextEdit
        '
        Me.HomepageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Homepage", True))
        Me.HomepageTextEdit.Location = New System.Drawing.Point(377, 138)
        Me.HomepageTextEdit.Name = "HomepageTextEdit"
        Me.HomepageTextEdit.Size = New System.Drawing.Size(176, 20)
        Me.HomepageTextEdit.StyleController = Me.DataLayoutControl1
        Me.HomepageTextEdit.TabIndex = 12
        '
        'emailTextEdit
        '
        Me.emailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "email", True))
        Me.emailTextEdit.Location = New System.Drawing.Point(377, 162)
        Me.emailTextEdit.Name = "emailTextEdit"
        Me.emailTextEdit.Properties.Mask.BeepOnError = True
        Me.emailTextEdit.Properties.Mask.EditMask = "(\w|[\.\-])+@(\w|[\-]+\.)*(\w|[\-]){2,63}\.[a-zA-Z]{2,4}"
        Me.emailTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.emailTextEdit.Size = New System.Drawing.Size(176, 20)
        Me.emailTextEdit.StyleController = Me.DataLayoutControl1
        Me.emailTextEdit.TabIndex = 13
        '
        'LogoPictureEdit
        '
        Me.LogoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.LogoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SupplierBindingSource, "Logo", True))
        Me.LogoPictureEdit.Location = New System.Drawing.Point(581, 42)
        Me.LogoPictureEdit.Name = "LogoPictureEdit"
        Me.LogoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.LogoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.LogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.LogoPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.LogoPictureEdit.Size = New System.Drawing.Size(145, 140)
        Me.LogoPictureEdit.StyleController = Me.DataLayoutControl1
        Me.LogoPictureEdit.TabIndex = 14
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(750, 548)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.LayoutControlGroup3, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlGroup5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(730, 528)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForContactName, Me.ItemForContactTitle, Me.ItemForAlamat, Me.ItemForCompany})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(282, 186)
        Me.LayoutControlGroup4.Text = "Primary Data"
        '
        'ItemForContactName
        '
        Me.ItemForContactName.Control = Me.ContactNameTextEdit
        Me.ItemForContactName.Location = New System.Drawing.Point(0, 24)
        Me.ItemForContactName.Name = "ItemForContactName"
        Me.ItemForContactName.Size = New System.Drawing.Size(258, 24)
        Me.ItemForContactName.Text = "Contact Name"
        Me.ItemForContactName.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForContactTitle
        '
        Me.ItemForContactTitle.Control = Me.ContactTitleLookUpEdit
        Me.ItemForContactTitle.Location = New System.Drawing.Point(0, 48)
        Me.ItemForContactTitle.Name = "ItemForContactTitle"
        Me.ItemForContactTitle.Size = New System.Drawing.Size(258, 24)
        Me.ItemForContactTitle.Text = "Contact Title"
        Me.ItemForContactTitle.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForAlamat
        '
        Me.ItemForAlamat.Control = Me.AlamatMemoEdit
        Me.ItemForAlamat.Location = New System.Drawing.Point(0, 72)
        Me.ItemForAlamat.Name = "ItemForAlamat"
        Me.ItemForAlamat.Size = New System.Drawing.Size(258, 72)
        Me.ItemForAlamat.StartNewLine = True
        Me.ItemForAlamat.Text = "Alamat"
        Me.ItemForAlamat.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForCompany
        '
        Me.ItemForCompany.Control = Me.CompanyTextEdit
        Me.ItemForCompany.Location = New System.Drawing.Point(0, 0)
        Me.ItemForCompany.Name = "ItemForCompany"
        Me.ItemForCompany.Size = New System.Drawing.Size(258, 24)
        Me.ItemForCompany.Text = "Company"
        Me.ItemForCompany.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKota, Me.ItemForKodePos, Me.ItemForTelephone, Me.ItemForFaximile, Me.ItemForHomepage, Me.ItemForemail})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(282, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(275, 186)
        Me.LayoutControlGroup3.Text = "Additional Supplier Data"
        '
        'ItemForKota
        '
        Me.ItemForKota.Control = Me.KotaTextEdit
        Me.ItemForKota.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKota.Name = "ItemForKota"
        Me.ItemForKota.Size = New System.Drawing.Size(251, 24)
        Me.ItemForKota.Text = "Kota"
        Me.ItemForKota.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForKodePos
        '
        Me.ItemForKodePos.Control = Me.KodePosTextEdit
        Me.ItemForKodePos.Location = New System.Drawing.Point(0, 24)
        Me.ItemForKodePos.Name = "ItemForKodePos"
        Me.ItemForKodePos.Size = New System.Drawing.Size(251, 24)
        Me.ItemForKodePos.Text = "Kode Pos"
        Me.ItemForKodePos.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForTelephone
        '
        Me.ItemForTelephone.Control = Me.TelephoneTextEdit
        Me.ItemForTelephone.Location = New System.Drawing.Point(0, 48)
        Me.ItemForTelephone.Name = "ItemForTelephone"
        Me.ItemForTelephone.Size = New System.Drawing.Size(251, 24)
        Me.ItemForTelephone.Text = "Telephone"
        Me.ItemForTelephone.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForFaximile
        '
        Me.ItemForFaximile.Control = Me.FaximileTextEdit
        Me.ItemForFaximile.Location = New System.Drawing.Point(0, 72)
        Me.ItemForFaximile.Name = "ItemForFaximile"
        Me.ItemForFaximile.Size = New System.Drawing.Size(251, 24)
        Me.ItemForFaximile.Text = "Faximile"
        Me.ItemForFaximile.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForHomepage
        '
        Me.ItemForHomepage.Control = Me.HomepageTextEdit
        Me.ItemForHomepage.Location = New System.Drawing.Point(0, 96)
        Me.ItemForHomepage.Name = "ItemForHomepage"
        Me.ItemForHomepage.Size = New System.Drawing.Size(251, 24)
        Me.ItemForHomepage.Text = "Homepage"
        Me.ItemForHomepage.TextSize = New System.Drawing.Size(68, 13)
        '
        'ItemForemail
        '
        Me.ItemForemail.Control = Me.emailTextEdit
        Me.ItemForemail.Location = New System.Drawing.Point(0, 120)
        Me.ItemForemail.Name = "ItemForemail"
        Me.ItemForemail.Size = New System.Drawing.Size(251, 24)
        Me.ItemForemail.Text = "email"
        Me.ItemForemail.TextSize = New System.Drawing.Size(68, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SupplierGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 186)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(730, 315)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 501)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(298, 27)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(298, 501)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(432, 27)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForLogo})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(557, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(173, 186)
        Me.LayoutControlGroup5.Text = "Company Logo"
        '
        'ItemForLogo
        '
        Me.ItemForLogo.Control = Me.LogoPictureEdit
        Me.ItemForLogo.Location = New System.Drawing.Point(0, 0)
        Me.ItemForLogo.Name = "ItemForLogo"
        Me.ItemForLogo.Size = New System.Drawing.Size(149, 144)
        Me.ItemForLogo.StartNewLine = True
        Me.ItemForLogo.Text = "Logo"
        Me.ItemForLogo.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForLogo.TextSize = New System.Drawing.Size(0, 0)
        Me.ItemForLogo.TextVisible = False
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 573)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.SupplierBindingNavigator)
        Me.Name = "FormSupplier"
        Me.Text = "FormSupplier"
        CType(Me.DataSetSuppier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierBindingNavigator.ResumeLayout(False)
        Me.SupplierBindingNavigator.PerformLayout()
        CType(Me.SupplierGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KotaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KodePosTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelephoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FaximileTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomepageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForContactName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForContactTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKodePos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTelephone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForFaximile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForHomepage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetSuppier As DataSetSuppier
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DataSetSuppierTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As DataSetSuppierTableAdapters.TableAdapterManager
    Friend WithEvents SupplierBindingNavigator As BindingNavigator
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
    Friend WithEvents SupplierBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SupplierGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TitleBindingSource As BindingSource
    Friend WithEvents TitleTableAdapter As DataSetSuppierTableAdapters.TitleTableAdapter
    Friend WithEvents colIDSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompany As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodePos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelephone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFaximile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHomepage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents CompanyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContactTitleLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AlamatMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents KotaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KodePosTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelephoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FaximileTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HomepageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents emailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogoPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForLogo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForKota As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKodePos As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForTelephone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForFaximile As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForHomepage As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForemail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForContactName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForContactTitle As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForCompany As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAlamat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
