<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductSupplier))
        Me.DataSetProductSupplier = New Cafe_Management.DataSetProductSupplier()
        Me.ProdukSupplierBindingSource = New System.Windows.Forms.BindingSource()
        Me.ProdukSupplierTableAdapter = New Cafe_Management.DataSetProductSupplierTableAdapters.ProdukSupplierTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetProductSupplierTableAdapters.TableAdapterManager()
        Me.ProdukSupplierBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.ProdukSupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProdukSupplierGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource()
        Me.BarangTableAdapter = New Cafe_Management.DataSetProductSupplierTableAdapters.BarangTableAdapter()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource()
        Me.SupplierTableAdapter = New Cafe_Management.DataSetProductSupplierTableAdapters.SupplierTableAdapter()
        Me.colIDProdukSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDProduk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSupplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.IDProdukLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForIDProduk = New DevExpress.XtraLayout.LayoutControlItem()
        Me.IDSupplierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ItemForIDSupplier = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetProductSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdukSupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdukSupplierBindingNavigator.SuspendLayout()
        CType(Me.ProdukSupplierGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDProdukLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetProductSupplier
        '
        Me.DataSetProductSupplier.DataSetName = "DataSetProductSupplier"
        Me.DataSetProductSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdukSupplierBindingSource
        '
        Me.ProdukSupplierBindingSource.DataMember = "ProdukSupplier"
        Me.ProdukSupplierBindingSource.DataSource = Me.DataSetProductSupplier
        '
        'ProdukSupplierTableAdapter
        '
        Me.ProdukSupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProdukSupplierTableAdapter = Me.ProdukSupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetProductSupplierTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProdukSupplierBindingNavigator
        '
        Me.ProdukSupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProdukSupplierBindingNavigator.BindingSource = Me.ProdukSupplierBindingSource
        Me.ProdukSupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProdukSupplierBindingNavigator.DeleteItem = Nothing
        Me.ProdukSupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.ProdukSupplierBindingNavigatorSaveItem})
        Me.ProdukSupplierBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProdukSupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProdukSupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProdukSupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProdukSupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProdukSupplierBindingNavigator.Name = "ProdukSupplierBindingNavigator"
        Me.ProdukSupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProdukSupplierBindingNavigator.Size = New System.Drawing.Size(348, 25)
        Me.ProdukSupplierBindingNavigator.TabIndex = 0
        Me.ProdukSupplierBindingNavigator.Text = "BindingNavigator1"
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
        'ProdukSupplierBindingNavigatorSaveItem
        '
        Me.ProdukSupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProdukSupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProdukSupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProdukSupplierBindingNavigatorSaveItem.Name = "ProdukSupplierBindingNavigatorSaveItem"
        Me.ProdukSupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProdukSupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProdukSupplierGridControl
        '
        Me.ProdukSupplierGridControl.DataSource = Me.ProdukSupplierBindingSource
        Me.ProdukSupplierGridControl.Location = New System.Drawing.Point(12, 60)
        Me.ProdukSupplierGridControl.MainView = Me.GridView1
        Me.ProdukSupplierGridControl.Name = "ProdukSupplierGridControl"
        Me.ProdukSupplierGridControl.Size = New System.Drawing.Size(324, 312)
        Me.ProdukSupplierGridControl.TabIndex = 2
        Me.ProdukSupplierGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDProdukSupplier, Me.colIDProduk, Me.colIDSupplier, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.ProdukSupplierGridControl
        Me.GridView1.Name = "GridView1"
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "Barang"
        Me.BarangBindingSource.DataSource = Me.DataSetProductSupplier
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DataSetProductSupplier
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'colIDProdukSupplier
        '
        Me.colIDProdukSupplier.FieldName = "IDProdukSupplier"
        Me.colIDProdukSupplier.Name = "colIDProdukSupplier"
        '
        'colIDProduk
        '
        Me.colIDProduk.FieldName = "IDProduk"
        Me.colIDProduk.Name = "colIDProduk"
        Me.colIDProduk.Visible = True
        Me.colIDProduk.VisibleIndex = 0
        '
        'colIDSupplier
        '
        Me.colIDSupplier.FieldName = "IDSupplier"
        Me.colIDSupplier.Name = "colIDSupplier"
        Me.colIDSupplier.Visible = True
        Me.colIDSupplier.VisibleIndex = 1
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
        Me.DataLayoutControl1.Controls.Add(Me.ProdukSupplierGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.IDProdukLookUpEdit)
        Me.DataLayoutControl1.Controls.Add(Me.IDSupplierLookUpEdit)
        Me.DataLayoutControl1.DataSource = Me.ProdukSupplierBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(348, 413)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(348, 413)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDProduk, Me.ItemForIDSupplier, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(328, 393)
        '
        'IDProdukLookUpEdit
        '
        Me.IDProdukLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukSupplierBindingSource, "IDProduk", True))
        Me.IDProdukLookUpEdit.Location = New System.Drawing.Point(54, 12)
        Me.IDProdukLookUpEdit.Name = "IDProdukLookUpEdit"
        Me.IDProdukLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDProdukLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDProdukLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDProdukLookUpEdit.Properties.DataSource = Me.BarangBindingSource
        Me.IDProdukLookUpEdit.Properties.DisplayMember = "NamaBarang"
        Me.IDProdukLookUpEdit.Properties.NullText = ""
        Me.IDProdukLookUpEdit.Properties.ValueMember = "IDBarang"
        Me.IDProdukLookUpEdit.Size = New System.Drawing.Size(282, 20)
        Me.IDProdukLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDProdukLookUpEdit.TabIndex = 4
        '
        'ItemForIDProduk
        '
        Me.ItemForIDProduk.Control = Me.IDProdukLookUpEdit
        Me.ItemForIDProduk.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIDProduk.Name = "ItemForIDProduk"
        Me.ItemForIDProduk.Size = New System.Drawing.Size(328, 24)
        Me.ItemForIDProduk.Text = "Produk"
        Me.ItemForIDProduk.TextSize = New System.Drawing.Size(38, 13)
        '
        'IDSupplierLookUpEdit
        '
        Me.IDSupplierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProdukSupplierBindingSource, "IDSupplier", True))
        Me.IDSupplierLookUpEdit.Location = New System.Drawing.Point(54, 36)
        Me.IDSupplierLookUpEdit.Name = "IDSupplierLookUpEdit"
        Me.IDSupplierLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDSupplierLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDSupplierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IDSupplierLookUpEdit.Properties.DataSource = Me.SupplierBindingSource
        Me.IDSupplierLookUpEdit.Properties.DisplayMember = "Company"
        Me.IDSupplierLookUpEdit.Properties.NullText = ""
        Me.IDSupplierLookUpEdit.Properties.ValueMember = "IDSupplier"
        Me.IDSupplierLookUpEdit.Size = New System.Drawing.Size(282, 20)
        Me.IDSupplierLookUpEdit.StyleController = Me.DataLayoutControl1
        Me.IDSupplierLookUpEdit.TabIndex = 5
        '
        'ItemForIDSupplier
        '
        Me.ItemForIDSupplier.Control = Me.IDSupplierLookUpEdit
        Me.ItemForIDSupplier.Location = New System.Drawing.Point(0, 24)
        Me.ItemForIDSupplier.Name = "ItemForIDSupplier"
        Me.ItemForIDSupplier.Size = New System.Drawing.Size(328, 24)
        Me.ItemForIDSupplier.Text = "Supplier"
        Me.ItemForIDSupplier.TextSize = New System.Drawing.Size(38, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ProdukSupplierGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(328, 316)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
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
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 376)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(324, 25)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 364)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(328, 29)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormProductSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 438)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.ProdukSupplierBindingNavigator)
        Me.Name = "FormProductSupplier"
        Me.Text = "FormProductSupplier"
        CType(Me.DataSetProductSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdukSupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdukSupplierBindingNavigator.ResumeLayout(False)
        Me.ProdukSupplierBindingNavigator.PerformLayout()
        CType(Me.ProdukSupplierGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDProdukLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDProduk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSupplierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetProductSupplier As DataSetProductSupplier
    Friend WithEvents ProdukSupplierBindingSource As BindingSource
    Friend WithEvents ProdukSupplierTableAdapter As DataSetProductSupplierTableAdapters.ProdukSupplierTableAdapter
    Friend WithEvents TableAdapterManager As DataSetProductSupplierTableAdapters.TableAdapterManager
    Friend WithEvents ProdukSupplierBindingNavigator As BindingNavigator
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
    Friend WithEvents ProdukSupplierBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProdukSupplierGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As DataSetProductSupplierTableAdapters.BarangTableAdapter
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As DataSetProductSupplierTableAdapters.SupplierTableAdapter
    Friend WithEvents colIDProdukSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProduk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSupplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents IDProdukLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IDSupplierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForIDProduk As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForIDSupplier As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
