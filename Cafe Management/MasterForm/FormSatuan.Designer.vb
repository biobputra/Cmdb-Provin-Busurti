<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSatuan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSatuan))
        Me.DataSetSatuan = New Cafe_Management.DataSetSatuan()
        Me.SatuanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SatuanTableAdapter = New Cafe_Management.DataSetSatuanTableAdapters.SatuanTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetSatuanTableAdapters.TableAdapterManager()
        Me.SatuanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SatuanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SatuanGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.IDSatuanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SatuanTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KeteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemForIDSatuan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForSatuan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKeterangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatuanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatuanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SatuanBindingNavigator.SuspendLayout()
        CType(Me.SatuanGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDSatuanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatuanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForIDSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSatuan
        '
        Me.DataSetSatuan.DataSetName = "DataSetSatuan"
        Me.DataSetSatuan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SatuanBindingSource
        '
        Me.SatuanBindingSource.DataMember = "Satuan"
        Me.SatuanBindingSource.DataSource = Me.DataSetSatuan
        '
        'SatuanTableAdapter
        '
        Me.SatuanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SatuanTableAdapter = Me.SatuanTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetSatuanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SatuanBindingNavigator
        '
        Me.SatuanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SatuanBindingNavigator.BindingSource = Me.SatuanBindingSource
        Me.SatuanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SatuanBindingNavigator.DeleteItem = Nothing
        Me.SatuanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.SatuanBindingNavigatorSaveItem})
        Me.SatuanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SatuanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SatuanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SatuanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SatuanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SatuanBindingNavigator.Name = "SatuanBindingNavigator"
        Me.SatuanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SatuanBindingNavigator.Size = New System.Drawing.Size(330, 25)
        Me.SatuanBindingNavigator.TabIndex = 0
        Me.SatuanBindingNavigator.Text = "BindingNavigator1"
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
        'SatuanBindingNavigatorSaveItem
        '
        Me.SatuanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SatuanBindingNavigatorSaveItem.Image = CType(resources.GetObject("SatuanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SatuanBindingNavigatorSaveItem.Name = "SatuanBindingNavigatorSaveItem"
        Me.SatuanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SatuanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SatuanGridControl
        '
        Me.SatuanGridControl.DataSource = Me.SatuanBindingSource
        Me.SatuanGridControl.Location = New System.Drawing.Point(12, 60)
        Me.SatuanGridControl.MainView = Me.GridView1
        Me.SatuanGridControl.Name = "SatuanGridControl"
        Me.SatuanGridControl.Size = New System.Drawing.Size(306, 294)
        Me.SatuanGridControl.TabIndex = 2
        Me.SatuanGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDSatuan, Me.colSatuan, Me.colKeterangan, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.SatuanGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDSatuan
        '
        Me.colIDSatuan.FieldName = "IDSatuan"
        Me.colIDSatuan.Name = "colIDSatuan"
        '
        'colSatuan
        '
        Me.colSatuan.FieldName = "Satuan"
        Me.colSatuan.Name = "colSatuan"
        Me.colSatuan.Visible = True
        Me.colSatuan.VisibleIndex = 0
        '
        'colKeterangan
        '
        Me.colKeterangan.FieldName = "Keterangan"
        Me.colKeterangan.Name = "colKeterangan"
        Me.colKeterangan.Visible = True
        Me.colKeterangan.VisibleIndex = 1
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
        Me.DataLayoutControl1.Controls.Add(Me.SatuanGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.IDSatuanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.SatuanTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KeteranganTextEdit)
        Me.DataLayoutControl1.DataSource = Me.SatuanBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDSatuan})
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(330, 393)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 358)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Data "), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Data")})
        Me.RadioGroup1.Size = New System.Drawing.Size(306, 23)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'IDSatuanTextEdit
        '
        Me.IDSatuanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SatuanBindingSource, "IDSatuan", True))
        Me.IDSatuanTextEdit.Location = New System.Drawing.Point(72, 12)
        Me.IDSatuanTextEdit.Name = "IDSatuanTextEdit"
        Me.IDSatuanTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.IDSatuanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IDSatuanTextEdit.Properties.Mask.EditMask = "N0"
        Me.IDSatuanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.IDSatuanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.IDSatuanTextEdit.Size = New System.Drawing.Size(243, 20)
        Me.IDSatuanTextEdit.StyleController = Me.DataLayoutControl1
        Me.IDSatuanTextEdit.TabIndex = 4
        '
        'SatuanTextEdit
        '
        Me.SatuanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SatuanBindingSource, "Satuan", True))
        Me.SatuanTextEdit.Location = New System.Drawing.Point(71, 12)
        Me.SatuanTextEdit.Name = "SatuanTextEdit"
        Me.SatuanTextEdit.Size = New System.Drawing.Size(247, 20)
        Me.SatuanTextEdit.StyleController = Me.DataLayoutControl1
        Me.SatuanTextEdit.TabIndex = 5
        '
        'KeteranganTextEdit
        '
        Me.KeteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SatuanBindingSource, "Keterangan", True))
        Me.KeteranganTextEdit.Location = New System.Drawing.Point(71, 36)
        Me.KeteranganTextEdit.Name = "KeteranganTextEdit"
        Me.KeteranganTextEdit.Size = New System.Drawing.Size(247, 20)
        Me.KeteranganTextEdit.StyleController = Me.DataLayoutControl1
        Me.KeteranganTextEdit.TabIndex = 6
        '
        'ItemForIDSatuan
        '
        Me.ItemForIDSatuan.Control = Me.IDSatuanTextEdit
        Me.ItemForIDSatuan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForIDSatuan.Name = "ItemForIDSatuan"
        Me.ItemForIDSatuan.Size = New System.Drawing.Size(307, 24)
        Me.ItemForIDSatuan.Text = "ID Satuan"
        Me.ItemForIDSatuan.TextSize = New System.Drawing.Size(50, 20)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(330, 393)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForSatuan, Me.ItemForKeterangan, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(310, 373)
        '
        'ItemForSatuan
        '
        Me.ItemForSatuan.Control = Me.SatuanTextEdit
        Me.ItemForSatuan.Location = New System.Drawing.Point(0, 0)
        Me.ItemForSatuan.Name = "ItemForSatuan"
        Me.ItemForSatuan.Size = New System.Drawing.Size(310, 24)
        Me.ItemForSatuan.Text = "Satuan"
        Me.ItemForSatuan.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemForKeterangan
        '
        Me.ItemForKeterangan.Control = Me.KeteranganTextEdit
        Me.ItemForKeterangan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForKeterangan.Name = "ItemForKeterangan"
        Me.ItemForKeterangan.Size = New System.Drawing.Size(310, 24)
        Me.ItemForKeterangan.Text = "Keterangan"
        Me.ItemForKeterangan.TextSize = New System.Drawing.Size(56, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SatuanGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(310, 298)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 346)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(310, 27)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormSatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 418)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.SatuanBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormSatuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSatuan"
        CType(Me.DataSetSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatuanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatuanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SatuanBindingNavigator.ResumeLayout(False)
        Me.SatuanBindingNavigator.PerformLayout()
        CType(Me.SatuanGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDSatuanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatuanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForIDSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetSatuan As DataSetSatuan
    Friend WithEvents SatuanBindingSource As BindingSource
    Friend WithEvents SatuanTableAdapter As DataSetSatuanTableAdapters.SatuanTableAdapter
    Friend WithEvents TableAdapterManager As DataSetSatuanTableAdapters.TableAdapterManager
    Friend WithEvents SatuanBindingNavigator As BindingNavigator
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
    Friend WithEvents SatuanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SatuanGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents IDSatuanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SatuanTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KeteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemForIDSatuan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForSatuan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKeterangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
