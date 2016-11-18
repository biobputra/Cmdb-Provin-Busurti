<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProdukLayanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProdukLayanan))
        Me.DataSetProdukDanLayanan = New Cafe_Management.DataSetProdukDanLayanan()
        Me.ProdukLayananHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdukLayananHTableAdapter = New Cafe_Management.DataSetProdukDanLayananTableAdapters.ProdukLayananHTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetProdukDanLayananTableAdapters.TableAdapterManager()
        Me.ProdukLayananDTableAdapter = New Cafe_Management.DataSetProdukDanLayananTableAdapters.ProdukLayananDTableAdapter()
        Me.ProdukLayananHBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProdukLayananHBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProdukLayananHGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDProdukLayananH1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisProduct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltaxed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProdukLayananDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdukLayananDGridControl = New DevExpress.XtraGrid.GridControl()
        Me.FKProdukLayananHProdukLayananDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDProdukLayananD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDProdukLayananH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMulaiBerlaku = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAkhirBerlaku = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.isProductCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.taxedCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForisProduct = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemFortaxed = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.DataSetProdukDanLayanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukLayananHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukLayananHBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdukLayananHBindingNavigator.SuspendLayout()
        CType(Me.ProdukLayananHGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukLayananDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukLayananDGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKProdukLayananHProdukLayananDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isProductCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.taxedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForisProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemFortaxed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetProdukDanLayanan
        '
        Me.DataSetProdukDanLayanan.DataSetName = "DataSetProdukDanLayanan"
        Me.DataSetProdukDanLayanan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdukLayananHBindingSource
        '
        Me.ProdukLayananHBindingSource.DataMember = "ProdukLayananH"
        Me.ProdukLayananHBindingSource.DataSource = Me.DataSetProdukDanLayanan
        '
        'ProdukLayananHTableAdapter
        '
        Me.ProdukLayananHTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProdukLayananDTableAdapter = Me.ProdukLayananDTableAdapter
        Me.TableAdapterManager.ProdukLayananHTableAdapter = Me.ProdukLayananHTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetProdukDanLayananTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProdukLayananDTableAdapter
        '
        Me.ProdukLayananDTableAdapter.ClearBeforeFill = True
        '
        'ProdukLayananHBindingNavigator
        '
        Me.ProdukLayananHBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProdukLayananHBindingNavigator.BindingSource = Me.ProdukLayananHBindingSource
        Me.ProdukLayananHBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProdukLayananHBindingNavigator.DeleteItem = Nothing
        Me.ProdukLayananHBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.ProdukLayananHBindingNavigatorSaveItem})
        Me.ProdukLayananHBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProdukLayananHBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProdukLayananHBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProdukLayananHBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProdukLayananHBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProdukLayananHBindingNavigator.Name = "ProdukLayananHBindingNavigator"
        Me.ProdukLayananHBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProdukLayananHBindingNavigator.Size = New System.Drawing.Size(867, 25)
        Me.ProdukLayananHBindingNavigator.TabIndex = 0
        Me.ProdukLayananHBindingNavigator.Text = "BindingNavigator1"
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
        'ProdukLayananHBindingNavigatorSaveItem
        '
        Me.ProdukLayananHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProdukLayananHBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProdukLayananHBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProdukLayananHBindingNavigatorSaveItem.Name = "ProdukLayananHBindingNavigatorSaveItem"
        Me.ProdukLayananHBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProdukLayananHBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProdukLayananHGridControl
        '
        Me.ProdukLayananHGridControl.DataSource = Me.ProdukLayananHBindingSource
        Me.ProdukLayananHGridControl.Location = New System.Drawing.Point(12, 36)
        Me.ProdukLayananHGridControl.MainView = Me.GridView1
        Me.ProdukLayananHGridControl.Name = "ProdukLayananHGridControl"
        Me.ProdukLayananHGridControl.Size = New System.Drawing.Size(843, 250)
        Me.ProdukLayananHGridControl.TabIndex = 2
        Me.ProdukLayananHGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDProdukLayananH1, Me.colNama, Me.colisProduct, Me.coltaxed, Me.colCreatedBy1, Me.colCreatedDate1, Me.colModifiedBy1, Me.colModifiedDate1, Me.colisActive})
        Me.GridView1.GridControl = Me.ProdukLayananHGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDProdukLayananH1
        '
        Me.colIDProdukLayananH1.FieldName = "IDProdukLayananH"
        Me.colIDProdukLayananH1.Name = "colIDProdukLayananH1"
        '
        'colNama
        '
        Me.colNama.FieldName = "Nama"
        Me.colNama.Name = "colNama"
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 0
        '
        'colisProduct
        '
        Me.colisProduct.FieldName = "isProduct"
        Me.colisProduct.Name = "colisProduct"
        Me.colisProduct.Visible = True
        Me.colisProduct.VisibleIndex = 1
        '
        'coltaxed
        '
        Me.coltaxed.FieldName = "taxed"
        Me.coltaxed.Name = "coltaxed"
        Me.coltaxed.Visible = True
        Me.coltaxed.VisibleIndex = 2
        '
        'colCreatedBy1
        '
        Me.colCreatedBy1.FieldName = "CreatedBy"
        Me.colCreatedBy1.Name = "colCreatedBy1"
        '
        'colCreatedDate1
        '
        Me.colCreatedDate1.FieldName = "CreatedDate"
        Me.colCreatedDate1.Name = "colCreatedDate1"
        '
        'colModifiedBy1
        '
        Me.colModifiedBy1.FieldName = "ModifiedBy"
        Me.colModifiedBy1.Name = "colModifiedBy1"
        '
        'colModifiedDate1
        '
        Me.colModifiedDate1.FieldName = "ModifiedDate"
        Me.colModifiedDate1.Name = "colModifiedDate1"
        '
        'colisActive
        '
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.Name = "colisActive"
        '
        'ProdukLayananDBindingSource
        '
        Me.ProdukLayananDBindingSource.DataMember = "FK_ProdukLayananH_ProdukLayananD"
        Me.ProdukLayananDBindingSource.DataSource = Me.ProdukLayananHBindingSource
        '
        'ProdukLayananDGridControl
        '
        Me.ProdukLayananDGridControl.DataSource = Me.FKProdukLayananHProdukLayananDBindingSource
        Me.ProdukLayananDGridControl.Location = New System.Drawing.Point(12, 353)
        Me.ProdukLayananDGridControl.MainView = Me.GridView2
        Me.ProdukLayananDGridControl.Name = "ProdukLayananDGridControl"
        Me.ProdukLayananDGridControl.Size = New System.Drawing.Size(843, 157)
        Me.ProdukLayananDGridControl.TabIndex = 3
        Me.ProdukLayananDGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'FKProdukLayananHProdukLayananDBindingSource
        '
        Me.FKProdukLayananHProdukLayananDBindingSource.DataMember = "FK_ProdukLayananH_ProdukLayananD"
        Me.FKProdukLayananHProdukLayananDBindingSource.DataSource = Me.ProdukLayananHBindingSource
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDProdukLayananD, Me.colIDProdukLayananH, Me.colHarga, Me.colMulaiBerlaku, Me.colAkhirBerlaku, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate})
        Me.GridView2.GridControl = Me.ProdukLayananDGridControl
        Me.GridView2.Name = "GridView2"
        '
        'colIDProdukLayananD
        '
        Me.colIDProdukLayananD.FieldName = "IDProdukLayananD"
        Me.colIDProdukLayananD.Name = "colIDProdukLayananD"
        '
        'colIDProdukLayananH
        '
        Me.colIDProdukLayananH.FieldName = "IDProdukLayananH"
        Me.colIDProdukLayananH.Name = "colIDProdukLayananH"
        Me.colIDProdukLayananH.Visible = True
        Me.colIDProdukLayananH.VisibleIndex = 0
        '
        'colHarga
        '
        Me.colHarga.FieldName = "Harga"
        Me.colHarga.Name = "colHarga"
        Me.colHarga.Visible = True
        Me.colHarga.VisibleIndex = 1
        '
        'colMulaiBerlaku
        '
        Me.colMulaiBerlaku.FieldName = "MulaiBerlaku"
        Me.colMulaiBerlaku.Name = "colMulaiBerlaku"
        Me.colMulaiBerlaku.Visible = True
        Me.colMulaiBerlaku.VisibleIndex = 2
        '
        'colAkhirBerlaku
        '
        Me.colAkhirBerlaku.FieldName = "AkhirBerlaku"
        Me.colAkhirBerlaku.Name = "colAkhirBerlaku"
        Me.colAkhirBerlaku.Visible = True
        Me.colAkhirBerlaku.VisibleIndex = 3
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
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 290)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(843, 25)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.BindingNavigator1)
        Me.DataLayoutControl1.Controls.Add(Me.ProdukLayananDGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.ProdukLayananHGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.isProductCheckEdit)
        Me.DataLayoutControl1.Controls.Add(Me.taxedCheckEdit)
        Me.DataLayoutControl1.DataSource = Me.ProdukLayananHBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(867, 522)
        Me.DataLayoutControl1.TabIndex = 5
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.FKProdukLayananHProdukLayananDBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(12, 319)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(843, 30)
        Me.BindingNavigator1.TabIndex = 6
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 27)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'NamaTextEdit
        '
        Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukLayananHBindingSource, "Nama", True))
        Me.NamaTextEdit.Location = New System.Drawing.Point(62, 12)
        Me.NamaTextEdit.Name = "NamaTextEdit"
        Me.NamaTextEdit.Size = New System.Drawing.Size(284, 20)
        Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
        Me.NamaTextEdit.TabIndex = 4
        '
        'isProductCheckEdit
        '
        Me.isProductCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukLayananHBindingSource, "isProduct", True))
        Me.isProductCheckEdit.Location = New System.Drawing.Point(450, 12)
        Me.isProductCheckEdit.Name = "isProductCheckEdit"
        Me.isProductCheckEdit.Properties.Caption = "is Product"
        Me.isProductCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.isProductCheckEdit.Size = New System.Drawing.Size(97, 19)
        Me.isProductCheckEdit.StyleController = Me.DataLayoutControl1
        Me.isProductCheckEdit.TabIndex = 5
        '
        'taxedCheckEdit
        '
        Me.taxedCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukLayananHBindingSource, "taxed", True))
        Me.taxedCheckEdit.Location = New System.Drawing.Point(611, 12)
        Me.taxedCheckEdit.Name = "taxedCheckEdit"
        Me.taxedCheckEdit.Properties.Caption = "taxed"
        Me.taxedCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.taxedCheckEdit.Size = New System.Drawing.Size(95, 19)
        Me.taxedCheckEdit.StyleController = Me.DataLayoutControl1
        Me.taxedCheckEdit.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(867, 522)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNama, Me.ItemForisProduct, Me.ItemFortaxed, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.SimpleSeparator1, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(847, 502)
        '
        'ItemForNama
        '
        Me.ItemForNama.Control = Me.NamaTextEdit
        Me.ItemForNama.Location = New System.Drawing.Point(0, 0)
        Me.ItemForNama.Name = "ItemForNama"
        Me.ItemForNama.Size = New System.Drawing.Size(338, 24)
        Me.ItemForNama.Text = "Nama"
        Me.ItemForNama.TextSize = New System.Drawing.Size(47, 13)
        '
        'ItemForisProduct
        '
        Me.ItemForisProduct.Control = Me.isProductCheckEdit
        Me.ItemForisProduct.Location = New System.Drawing.Point(388, 0)
        Me.ItemForisProduct.Name = "ItemForisProduct"
        Me.ItemForisProduct.Size = New System.Drawing.Size(151, 24)
        Me.ItemForisProduct.Text = "is Product"
        Me.ItemForisProduct.TextSize = New System.Drawing.Size(47, 13)
        '
        'ItemFortaxed
        '
        Me.ItemFortaxed.Control = Me.taxedCheckEdit
        Me.ItemFortaxed.Location = New System.Drawing.Point(549, 0)
        Me.ItemFortaxed.Name = "ItemFortaxed"
        Me.ItemFortaxed.Size = New System.Drawing.Size(149, 24)
        Me.ItemFortaxed.Text = "taxed"
        Me.ItemFortaxed.TextSize = New System.Drawing.Size(47, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ProdukLayananHGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(847, 254)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 278)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(847, 29)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.BindingNavigator1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 307)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(847, 34)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ProdukLayananDGridControl
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 341)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(847, 161)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(338, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(2, 24)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(340, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(48, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(539, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(698, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(149, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'FormProdukLayanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 547)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.ProdukLayananHBindingNavigator)
        Me.Name = "FormProdukLayanan"
        Me.Text = "FormProdukLayanan"
        CType(Me.DataSetProdukDanLayanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukLayananHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukLayananHBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdukLayananHBindingNavigator.ResumeLayout(False)
        Me.ProdukLayananHBindingNavigator.PerformLayout()
        CType(Me.ProdukLayananHGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukLayananDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukLayananDGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKProdukLayananHProdukLayananDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isProductCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.taxedCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForisProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemFortaxed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetProdukDanLayanan As DataSetProdukDanLayanan
    Friend WithEvents ProdukLayananHBindingSource As BindingSource
    Friend WithEvents ProdukLayananHTableAdapter As DataSetProdukDanLayananTableAdapters.ProdukLayananHTableAdapter
    Friend WithEvents TableAdapterManager As DataSetProdukDanLayananTableAdapters.TableAdapterManager
    Friend WithEvents ProdukLayananHBindingNavigator As BindingNavigator
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
    Friend WithEvents ProdukLayananHBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProdukLayananDTableAdapter As DataSetProdukDanLayananTableAdapters.ProdukLayananDTableAdapter
    Friend WithEvents ProdukLayananHGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProdukLayananDBindingSource As BindingSource
    Friend WithEvents colIDProdukLayananH1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisProduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltaxed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProdukLayananDGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDProdukLayananD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProdukLayananH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMulaiBerlaku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAkhirBerlaku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents isProductCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents taxedCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForNama As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForisProduct As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemFortaxed As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents FKProdukLayananHProdukLayananDBindingSource As BindingSource
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
