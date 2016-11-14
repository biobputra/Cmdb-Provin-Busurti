<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJenisBarang))
        Me.DataSetJenisBarang = New Cafe_Management.DataSetJenisBarang()
        Me.JenisBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JenisBarangTableAdapter = New Cafe_Management.DataSetJenisBarangTableAdapters.JenisBarangTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetJenisBarangTableAdapters.TableAdapterManager()
        Me.JenisBarangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.JenisBarangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.JenisBarangGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdJenisBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJenisBarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.JenisBarangTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PicturePictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForJenisBarang = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForPicture = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.DataSetJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisBarangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.JenisBarangBindingNavigator.SuspendLayout()
        CType(Me.JenisBarangGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.JenisBarangTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetJenisBarang
        '
        Me.DataSetJenisBarang.DataSetName = "DataSetJenisBarang"
        Me.DataSetJenisBarang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JenisBarangBindingSource
        '
        Me.JenisBarangBindingSource.DataMember = "JenisBarang"
        Me.JenisBarangBindingSource.DataSource = Me.DataSetJenisBarang
        '
        'JenisBarangTableAdapter
        '
        Me.JenisBarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.JenisBarangTableAdapter = Me.JenisBarangTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetJenisBarangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JenisBarangBindingNavigator
        '
        Me.JenisBarangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.JenisBarangBindingNavigator.BindingSource = Me.JenisBarangBindingSource
        Me.JenisBarangBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.JenisBarangBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.JenisBarangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JenisBarangBindingNavigatorSaveItem})
        Me.JenisBarangBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.JenisBarangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.JenisBarangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.JenisBarangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.JenisBarangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.JenisBarangBindingNavigator.Name = "JenisBarangBindingNavigator"
        Me.JenisBarangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.JenisBarangBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.JenisBarangBindingNavigator.TabIndex = 0
        Me.JenisBarangBindingNavigator.Text = "BindingNavigator1"
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
        'JenisBarangBindingNavigatorSaveItem
        '
        Me.JenisBarangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.JenisBarangBindingNavigatorSaveItem.Image = CType(resources.GetObject("JenisBarangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.JenisBarangBindingNavigatorSaveItem.Name = "JenisBarangBindingNavigatorSaveItem"
        Me.JenisBarangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.JenisBarangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'JenisBarangGridControl
        '
        Me.JenisBarangGridControl.DataSource = Me.JenisBarangBindingSource
        Me.JenisBarangGridControl.Location = New System.Drawing.Point(271, 12)
        Me.JenisBarangGridControl.MainView = Me.GridView1
        Me.JenisBarangGridControl.Name = "JenisBarangGridControl"
        Me.JenisBarangGridControl.Size = New System.Drawing.Size(436, 325)
        Me.JenisBarangGridControl.TabIndex = 2
        Me.JenisBarangGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdJenisBarang, Me.colJenisBarang, Me.colPicture, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.JenisBarangGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIdJenisBarang
        '
        Me.colIdJenisBarang.FieldName = "IdJenisBarang"
        Me.colIdJenisBarang.Name = "colIdJenisBarang"
        '
        'colJenisBarang
        '
        Me.colJenisBarang.FieldName = "JenisBarang"
        Me.colJenisBarang.Name = "colJenisBarang"
        Me.colJenisBarang.Visible = True
        Me.colJenisBarang.VisibleIndex = 0
        '
        'colPicture
        '
        Me.colPicture.FieldName = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.Visible = True
        Me.colPicture.VisibleIndex = 1
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
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 341)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(286, 25)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 3
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.RadioGroup1)
        Me.DataLayoutControl1.Controls.Add(Me.JenisBarangGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.JenisBarangTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.PicturePictureEdit)
        Me.DataLayoutControl1.DataSource = Me.JenisBarangBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(665, 214, 250, 350)
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(719, 378)
        Me.DataLayoutControl1.TabIndex = 4
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'JenisBarangTextEdit
        '
        Me.JenisBarangTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JenisBarangBindingSource, "JenisBarang", True))
        Me.JenisBarangTextEdit.Location = New System.Drawing.Point(76, 12)
        Me.JenisBarangTextEdit.Name = "JenisBarangTextEdit"
        Me.JenisBarangTextEdit.Size = New System.Drawing.Size(191, 20)
        Me.JenisBarangTextEdit.StyleController = Me.DataLayoutControl1
        Me.JenisBarangTextEdit.TabIndex = 4
        '
        'PicturePictureEdit
        '
        Me.PicturePictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.PicturePictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JenisBarangBindingSource, "Picture", True))
        Me.PicturePictureEdit.Location = New System.Drawing.Point(76, 36)
        Me.PicturePictureEdit.Name = "PicturePictureEdit"
        Me.PicturePictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PicturePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PicturePictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.PicturePictureEdit.Size = New System.Drawing.Size(191, 148)
        Me.PicturePictureEdit.StyleController = Me.DataLayoutControl1
        Me.PicturePictureEdit.TabIndex = 5
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(719, 378)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForJenisBarang, Me.ItemForPicture, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.EmptySpaceItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(699, 358)
        '
        'ItemForJenisBarang
        '
        Me.ItemForJenisBarang.Control = Me.JenisBarangTextEdit
        Me.ItemForJenisBarang.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJenisBarang.Name = "ItemForJenisBarang"
        Me.ItemForJenisBarang.Size = New System.Drawing.Size(259, 24)
        Me.ItemForJenisBarang.Text = "Jenis Barang"
        Me.ItemForJenisBarang.TextSize = New System.Drawing.Size(61, 13)
        '
        'ItemForPicture
        '
        Me.ItemForPicture.Control = Me.PicturePictureEdit
        Me.ItemForPicture.Location = New System.Drawing.Point(0, 24)
        Me.ItemForPicture.Name = "ItemForPicture"
        Me.ItemForPicture.Size = New System.Drawing.Size(259, 152)
        Me.ItemForPicture.StartNewLine = True
        Me.ItemForPicture.Text = "Picture"
        Me.ItemForPicture.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.JenisBarangGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(259, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(440, 329)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 329)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(290, 29)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(290, 329)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(409, 29)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 176)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(259, 153)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'FormJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 403)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.JenisBarangBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormJenisBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJenisBarang"
        CType(Me.DataSetJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisBarangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.JenisBarangBindingNavigator.ResumeLayout(False)
        Me.JenisBarangBindingNavigator.PerformLayout()
        CType(Me.JenisBarangGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.JenisBarangTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicturePictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetJenisBarang As DataSetJenisBarang
    Friend WithEvents JenisBarangBindingSource As BindingSource
    Friend WithEvents JenisBarangTableAdapter As DataSetJenisBarangTableAdapters.JenisBarangTableAdapter
    Friend WithEvents TableAdapterManager As DataSetJenisBarangTableAdapters.TableAdapterManager
    Friend WithEvents JenisBarangBindingNavigator As BindingNavigator
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
    Friend WithEvents JenisBarangBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents JenisBarangGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdJenisBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJenisBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPicture As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents JenisBarangTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PicturePictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForJenisBarang As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForPicture As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
End Class
