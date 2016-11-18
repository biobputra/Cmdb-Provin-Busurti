<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnggota))
        Me.DataSetAnggota = New Cafe_Management.DataSetAnggota()
        Me.AnggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnggotaTableAdapter = New Cafe_Management.DataSetAnggotaTableAdapters.AnggotaTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetAnggotaTableAdapters.TableAdapterManager()
        Me.AnggotaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AnggotaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AnggotaGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDAnggota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJenisIdentitas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.JenisIdentitasGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colNomorIdentitas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidTitle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TitleGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggalBergabung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlamat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomorHandphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.KodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.JenisIdentitasLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.JenisIdentitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomorIdentitasTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.idTitleLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.TitleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TanggalBergabungDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.AlamatMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.NomorHandphoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PhotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForKode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForJenisIdentitas = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNomorIdentitas = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForidTitle = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForTanggalBergabung = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForAlamat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForNomorHandphone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.JenisIdentitasTableAdapter = New Cafe_Management.DataSetAnggotaTableAdapters.JenisIdentitasTableAdapter()
        Me.TitleTableAdapter = New Cafe_Management.DataSetAnggotaTableAdapters.TitleTableAdapter()
        Me.JenisIdentitasGridTableAdapter = New Cafe_Management.DataSetAnggotaTableAdapters.JenisIdentitasGridTableAdapter()
        Me.TitleGridTableAdapter = New Cafe_Management.DataSetAnggotaTableAdapters.TitleGridTableAdapter()
        CType(Me.DataSetAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnggotaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnggotaBindingNavigator.SuspendLayout()
        CType(Me.AnggotaGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisIdentitasGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.KodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisIdentitasLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisIdentitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorIdentitasTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalBergabungDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanggalBergabungDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomorHandphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJenisIdentitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNomorIdentitas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForidTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForTanggalBergabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNomorHandphone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetAnggota
        '
        Me.DataSetAnggota.DataSetName = "DataSetAnggota"
        Me.DataSetAnggota.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnggotaBindingSource
        '
        Me.AnggotaBindingSource.DataMember = "Anggota"
        Me.AnggotaBindingSource.DataSource = Me.DataSetAnggota
        '
        'AnggotaTableAdapter
        '
        Me.AnggotaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnggotaTableAdapter = Me.AnggotaTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetAnggotaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AnggotaBindingNavigator
        '
        Me.AnggotaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnggotaBindingNavigator.BindingSource = Me.AnggotaBindingSource
        Me.AnggotaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnggotaBindingNavigator.DeleteItem = Nothing
        Me.AnggotaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.AnggotaBindingNavigatorSaveItem})
        Me.AnggotaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnggotaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnggotaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnggotaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnggotaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnggotaBindingNavigator.Name = "AnggotaBindingNavigator"
        Me.AnggotaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnggotaBindingNavigator.Size = New System.Drawing.Size(1027, 25)
        Me.AnggotaBindingNavigator.TabIndex = 0
        Me.AnggotaBindingNavigator.Text = "BindingNavigator1"
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
        'AnggotaBindingNavigatorSaveItem
        '
        Me.AnggotaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnggotaBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnggotaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnggotaBindingNavigatorSaveItem.Name = "AnggotaBindingNavigatorSaveItem"
        Me.AnggotaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AnggotaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AnggotaGridControl
        '
        Me.AnggotaGridControl.DataSource = Me.AnggotaBindingSource
        Me.AnggotaGridControl.Location = New System.Drawing.Point(12, 225)
        Me.AnggotaGridControl.MainView = Me.GridView1
        Me.AnggotaGridControl.Name = "AnggotaGridControl"
        Me.AnggotaGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.AnggotaGridControl.Size = New System.Drawing.Size(1003, 236)
        Me.AnggotaGridControl.TabIndex = 2
        Me.AnggotaGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDAnggota, Me.colKode, Me.colJenisIdentitas, Me.colNomorIdentitas, Me.colidTitle, Me.colNama, Me.colTanggalBergabung, Me.colAlamat, Me.colNomorHandphone, Me.colPhoto, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.AnggotaGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colIDAnggota
        '
        Me.colIDAnggota.FieldName = "IDAnggota"
        Me.colIDAnggota.Name = "colIDAnggota"
        '
        'colKode
        '
        Me.colKode.FieldName = "Kode"
        Me.colKode.Name = "colKode"
        Me.colKode.Visible = True
        Me.colKode.VisibleIndex = 0
        '
        'colJenisIdentitas
        '
        Me.colJenisIdentitas.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colJenisIdentitas.FieldName = "JenisIdentitas"
        Me.colJenisIdentitas.Name = "colJenisIdentitas"
        Me.colJenisIdentitas.Visible = True
        Me.colJenisIdentitas.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.JenisIdentitasGridBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "JenisIdentitas"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDJenisIdentitas"
        '
        'JenisIdentitasGridBindingSource
        '
        Me.JenisIdentitasGridBindingSource.DataMember = "JenisIdentitasGrid"
        Me.JenisIdentitasGridBindingSource.DataSource = Me.DataSetAnggota
        '
        'colNomorIdentitas
        '
        Me.colNomorIdentitas.FieldName = "NomorIdentitas"
        Me.colNomorIdentitas.Name = "colNomorIdentitas"
        Me.colNomorIdentitas.Visible = True
        Me.colNomorIdentitas.VisibleIndex = 2
        '
        'colidTitle
        '
        Me.colidTitle.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidTitle.FieldName = "idTitle"
        Me.colidTitle.Name = "colidTitle"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.TitleGridBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Title"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "IDTitle"
        '
        'TitleGridBindingSource
        '
        Me.TitleGridBindingSource.DataMember = "TitleGrid"
        Me.TitleGridBindingSource.DataSource = Me.DataSetAnggota
        '
        'colNama
        '
        Me.colNama.FieldName = "Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 4
        '
        'colTanggalBergabung
        '
        Me.colTanggalBergabung.FieldName = "TanggalBergabung"
        Me.colTanggalBergabung.Name = "colTanggalBergabung"
        Me.colTanggalBergabung.Visible = True
        Me.colTanggalBergabung.VisibleIndex = 5
        '
        'colAlamat
        '
        Me.colAlamat.FieldName = "Alamat"
        Me.colAlamat.Name = "colAlamat"
        Me.colAlamat.Visible = True
        Me.colAlamat.VisibleIndex = 6
        '
        'colNomorHandphone
        '
        Me.colNomorHandphone.FieldName = "NomorHandphone"
        Me.colNomorHandphone.Name = "colNomorHandphone"
        Me.colNomorHandphone.Visible = True
        Me.colNomorHandphone.VisibleIndex = 7
        '
        'colPhoto
        '
        Me.colPhoto.FieldName = "Photo"
        Me.colPhoto.Name = "colPhoto"
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
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 465)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(499, 30)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.AnggotaGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.KodeTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.JenisIdentitasLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NomorIdentitasTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.idTitleLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.TanggalBergabungDateEdit)
        Me.DataLayoutControl1.Controls.Add(Me.AlamatMemoEdit)
        Me.DataLayoutControl1.Controls.Add(Me.NomorHandphoneTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PhotoPictureEdit)
        Me.DataLayoutControl1.DataSource = Me.AnggotaBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(339, 196, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(1027, 507)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'KodeTextEdit
        '
        Me.KodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "Kode", True))
        Me.KodeTextEdit.Location = New System.Drawing.Point(120, 42)
        Me.KodeTextEdit.Name = "KodeTextEdit"
        Me.KodeTextEdit.Size = New System.Drawing.Size(379, 20)
        Me.KodeTextEdit.StyleController = Me.DataLayoutControl1
        Me.KodeTextEdit.TabIndex = 4
        '
        'JenisIdentitasLookUpEdit
        '
        Me.JenisIdentitasLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "JenisIdentitas", True))
        Me.JenisIdentitasLookUpEdit.Location = New System.Drawing.Point(120, 66)
        Me.JenisIdentitasLookUpEdit.Name = "JenisIdentitasLookUpEdit"
        Me.JenisIdentitasLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.JenisIdentitasLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.JenisIdentitasLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JenisIdentitasLookUpEdit.Properties.DataSource = Me.JenisIdentitasBindingSource
        Me.JenisIdentitasLookUpEdit.Properties.DisplayMember = "JenisIdentitas"
        Me.JenisIdentitasLookUpEdit.Properties.NullText = ""
        Me.JenisIdentitasLookUpEdit.Properties.ValueMember = "IDJenisIdentitas"
        Me.JenisIdentitasLookUpEdit.Size = New System.Drawing.Size(379, 20)
        Me.JenisIdentitasLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.JenisIdentitasLookUpEdit.TabIndex = 5
        '
        'JenisIdentitasBindingSource
        '
        Me.JenisIdentitasBindingSource.DataMember = "JenisIdentitas"
        Me.JenisIdentitasBindingSource.DataSource = Me.DataSetAnggota
        '
        'NomorIdentitasTextEdit
        '
        Me.NomorIdentitasTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "NomorIdentitas", True))
        Me.NomorIdentitasTextEdit.Location = New System.Drawing.Point(120, 90)
        Me.NomorIdentitasTextEdit.Name = "NomorIdentitasTextEdit"
        Me.NomorIdentitasTextEdit.Size = New System.Drawing.Size(379, 20)
        Me.NomorIdentitasTextEdit.StyleController = Me.DataLayoutControl1
        Me.NomorIdentitasTextEdit.TabIndex = 6
        '
        'idTitleLookUpEdit
        '
        Me.idTitleLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "idTitle", True))
        Me.idTitleLookUpEdit.Location = New System.Drawing.Point(120, 114)
        Me.idTitleLookUpEdit.Name = "idTitleLookUpEdit"
        Me.idTitleLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.idTitleLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.idTitleLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.idTitleLookUpEdit.Properties.DataSource = Me.TitleBindingSource
        Me.idTitleLookUpEdit.Properties.DisplayMember = "Title"
        Me.idTitleLookUpEdit.Properties.NullText = ""
        Me.idTitleLookUpEdit.Properties.ValueMember = "IDTitle"
        Me.idTitleLookUpEdit.Size = New System.Drawing.Size(379, 20)
        Me.idTitleLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.idTitleLookUpEdit.TabIndex = 7
        '
        'TitleBindingSource
        '
        Me.TitleBindingSource.DataMember = "Title"
        Me.TitleBindingSource.DataSource = Me.DataSetAnggota
        '
        'NamaTextEdit
        '
        Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "Nama", True))
        Me.NamaTextEdit.Location = New System.Drawing.Point(120, 138)
        Me.NamaTextEdit.Name = "NamaTextEdit"
        Me.NamaTextEdit.Size = New System.Drawing.Size(379, 20)
        Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamaTextEdit.TabIndex = 8
        '
        'TanggalBergabungDateEdit
        '
        Me.TanggalBergabungDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "TanggalBergabung", True))
        Me.TanggalBergabungDateEdit.EditValue = Nothing
        Me.TanggalBergabungDateEdit.Location = New System.Drawing.Point(623, 42)
        Me.TanggalBergabungDateEdit.Name = "TanggalBergabungDateEdit"
        Me.TanggalBergabungDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalBergabungDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TanggalBergabungDateEdit.Size = New System.Drawing.Size(238, 20)
        Me.TanggalBergabungDateEdit.StyleController = Me.DataLayoutControl1
        Me.TanggalBergabungDateEdit.TabIndex = 9
        '
        'AlamatMemoEdit
        '
        Me.AlamatMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "Alamat", True))
        Me.AlamatMemoEdit.Location = New System.Drawing.Point(623, 66)
        Me.AlamatMemoEdit.Name = "AlamatMemoEdit"
        Me.AlamatMemoEdit.Size = New System.Drawing.Size(238, 119)
        Me.AlamatMemoEdit.StyleController = Me.DataLayoutControl1
        Me.AlamatMemoEdit.TabIndex = 10
        '
        'NomorHandphoneTextEdit
        '
        Me.NomorHandphoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "NomorHandphone", True))
        Me.NomorHandphoneTextEdit.Location = New System.Drawing.Point(623, 189)
        Me.NomorHandphoneTextEdit.Name = "NomorHandphoneTextEdit"
        Me.NomorHandphoneTextEdit.Size = New System.Drawing.Size(238, 20)
        Me.NomorHandphoneTextEdit.StyleController = Me.DataLayoutControl1
        Me.NomorHandphoneTextEdit.TabIndex = 11
        '
        'PhotoPictureEdit
        '
        Me.PhotoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PhotoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.AnggotaBindingSource, "Photo", True))
        Me.PhotoPictureEdit.Location = New System.Drawing.Point(865, 58)
        Me.PhotoPictureEdit.Name = "PhotoPictureEdit"
        Me.PhotoPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PhotoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PhotoPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.PhotoPictureEdit.Size = New System.Drawing.Size(138, 151)
        Me.PhotoPictureEdit.StyleController = Me.DataLayoutControl1
        Me.PhotoPictureEdit.TabIndex = 12
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1027, 507)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1007, 487)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForKode, Me.ItemForJenisIdentitas, Me.ItemForNomorIdentitas, Me.ItemForidTitle, Me.ItemForNama, Me.EmptySpaceItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(503, 213)
        Me.LayoutControlGroup3.Text = " "
        '
        'ItemForKode
        '
        Me.ItemForKode.Control = Me.KodeTextEdit
        Me.ItemForKode.Location = New System.Drawing.Point(0, 0)
        Me.ItemForKode.Name = "ItemForKode"
        Me.ItemForKode.Size = New System.Drawing.Size(479, 24)
        Me.ItemForKode.Text = "Kode"
        Me.ItemForKode.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForJenisIdentitas
        '
        Me.ItemForJenisIdentitas.Control = Me.JenisIdentitasLookUpEdit
        Me.ItemForJenisIdentitas.Location = New System.Drawing.Point(0, 24)
        Me.ItemForJenisIdentitas.Name = "ItemForJenisIdentitas"
        Me.ItemForJenisIdentitas.Size = New System.Drawing.Size(479, 24)
        Me.ItemForJenisIdentitas.Text = "Jenis Identitas"
        Me.ItemForJenisIdentitas.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForNomorIdentitas
        '
        Me.ItemForNomorIdentitas.Control = Me.NomorIdentitasTextEdit
        Me.ItemForNomorIdentitas.Location = New System.Drawing.Point(0, 48)
        Me.ItemForNomorIdentitas.Name = "ItemForNomorIdentitas"
        Me.ItemForNomorIdentitas.Size = New System.Drawing.Size(479, 24)
        Me.ItemForNomorIdentitas.Text = "Nomor Identitas"
        Me.ItemForNomorIdentitas.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForidTitle
        '
        Me.ItemForidTitle.Control = Me.idTitleLookUpEdit
        Me.ItemForidTitle.Location = New System.Drawing.Point(0, 72)
        Me.ItemForidTitle.Name = "ItemForidTitle"
        Me.ItemForidTitle.Size = New System.Drawing.Size(479, 24)
        Me.ItemForidTitle.Text = "id Title"
        Me.ItemForidTitle.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForNama
        '
        Me.ItemForNama.Control = Me.NamaTextEdit
        Me.ItemForNama.Location = New System.Drawing.Point(0, 96)
        Me.ItemForNama.Name = "ItemForNama"
        Me.ItemForNama.Size = New System.Drawing.Size(479, 24)
        Me.ItemForNama.Text = "Nama"
        Me.ItemForNama.TextSize = New System.Drawing.Size(93, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 120)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(479, 51)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForTanggalBergabung, Me.ItemForAlamat, Me.ItemForNomorHandphone, Me.ItemForPhoto})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(503, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(504, 213)
        Me.LayoutControlGroup4.Text = " "
        '
        'ItemForTanggalBergabung
        '
        Me.ItemForTanggalBergabung.Control = Me.TanggalBergabungDateEdit
        Me.ItemForTanggalBergabung.Location = New System.Drawing.Point(0, 0)
        Me.ItemForTanggalBergabung.Name = "ItemForTanggalBergabung"
        Me.ItemForTanggalBergabung.Size = New System.Drawing.Size(338, 24)
        Me.ItemForTanggalBergabung.Text = "Tanggal Bergabung"
        Me.ItemForTanggalBergabung.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForAlamat
        '
        Me.ItemForAlamat.Control = Me.AlamatMemoEdit
        Me.ItemForAlamat.Location = New System.Drawing.Point(0, 24)
        Me.ItemForAlamat.Name = "ItemForAlamat"
        Me.ItemForAlamat.Size = New System.Drawing.Size(338, 123)
        Me.ItemForAlamat.StartNewLine = True
        Me.ItemForAlamat.Text = "Alamat"
        Me.ItemForAlamat.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForNomorHandphone
        '
        Me.ItemForNomorHandphone.Control = Me.NomorHandphoneTextEdit
        Me.ItemForNomorHandphone.Location = New System.Drawing.Point(0, 147)
        Me.ItemForNomorHandphone.Name = "ItemForNomorHandphone"
        Me.ItemForNomorHandphone.Size = New System.Drawing.Size(338, 24)
        Me.ItemForNomorHandphone.Text = "Nomor Handphone"
        Me.ItemForNomorHandphone.TextSize = New System.Drawing.Size(93, 13)
        '
        'ItemForPhoto
        '
        Me.ItemForPhoto.Control = Me.PhotoPictureEdit
        Me.ItemForPhoto.Location = New System.Drawing.Point(338, 0)
        Me.ItemForPhoto.Name = "ItemForPhoto"
        Me.ItemForPhoto.Size = New System.Drawing.Size(142, 171)
        Me.ItemForPhoto.StartNewLine = True
        Me.ItemForPhoto.Text = "Photo"
        Me.ItemForPhoto.TextLocation = DevExpress.Utils.Locations.Top
        Me.ItemForPhoto.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.AnggotaGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1007, 240)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 453)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(503, 34)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(503, 453)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(504, 34)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'JenisIdentitasTableAdapter
        '
        Me.JenisIdentitasTableAdapter.ClearBeforeFill = True
        '
        'TitleTableAdapter
        '
        Me.TitleTableAdapter.ClearBeforeFill = True
        '
        'JenisIdentitasGridTableAdapter
        '
        Me.JenisIdentitasGridTableAdapter.ClearBeforeFill = True
        '
        'TitleGridTableAdapter
        '
        Me.TitleGridTableAdapter.ClearBeforeFill = True
        '
        'FormAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 532)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.AnggotaBindingNavigator)
        Me.Name = "FormAnggota"
        Me.Text = "FormAnggota"
        CType(Me.DataSetAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnggotaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnggotaBindingNavigator.ResumeLayout(False)
        Me.AnggotaBindingNavigator.PerformLayout()
        CType(Me.AnggotaGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisIdentitasGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.KodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisIdentitasLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisIdentitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorIdentitasTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idTitleLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalBergabungDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanggalBergabungDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomorHandphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJenisIdentitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNomorIdentitas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForidTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForTanggalBergabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForAlamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNomorHandphone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetAnggota As DataSetAnggota
    Friend WithEvents AnggotaBindingSource As BindingSource
    Friend WithEvents AnggotaTableAdapter As DataSetAnggotaTableAdapters.AnggotaTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAnggotaTableAdapters.TableAdapterManager
    Friend WithEvents AnggotaBindingNavigator As BindingNavigator
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
    Friend WithEvents AnggotaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AnggotaGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents KodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents JenisIdentitasLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NomorIdentitasTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents idTitleLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TanggalBergabungDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents AlamatMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NomorHandphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PhotoPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForKode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForJenisIdentitas As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNomorIdentitas As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForidTitle As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNama As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForTanggalBergabung As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForAlamat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForNomorHandphone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPhoto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colIDAnggota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJenisIdentitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorIdentitas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidTitle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggalBergabung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlamat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomorHandphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents JenisIdentitasBindingSource As BindingSource
    Friend WithEvents JenisIdentitasTableAdapter As DataSetAnggotaTableAdapters.JenisIdentitasTableAdapter
    Friend WithEvents TitleBindingSource As BindingSource
    Friend WithEvents TitleTableAdapter As DataSetAnggotaTableAdapters.TitleTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents JenisIdentitasGridBindingSource As BindingSource
    Friend WithEvents JenisIdentitasGridTableAdapter As DataSetAnggotaTableAdapters.JenisIdentitasGridTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TitleGridBindingSource As BindingSource
    Friend WithEvents TitleGridTableAdapter As DataSetAnggotaTableAdapters.TitleGridTableAdapter
End Class
