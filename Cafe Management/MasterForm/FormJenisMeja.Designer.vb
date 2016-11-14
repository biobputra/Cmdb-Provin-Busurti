<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisMeja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJenisMeja))
        Me.DataSetJenisMeja = New Cafe_Management.DataSetJenisMeja()
        Me.Jnm_SelectBindingSource = New System.Windows.Forms.BindingSource()
        Me.Jnm_SelectTableAdapter = New Cafe_Management.DataSetJenisMejaTableAdapters.Jnm_SelectTableAdapter()
        Me.TableAdapterManager = New Cafe_Management.DataSetJenisMejaTableAdapters.TableAdapterManager()
        Me.Jnm_SelectBindingNavigator = New System.Windows.Forms.BindingNavigator()
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
        Me.Jnm_SelectBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Jnm_SelectGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDJenisMeJa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJenisMeja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.JenisMejaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KeteranganTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ItemForJenisMeja = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ItemForKeterangan = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DataSetJenisMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jnm_SelectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jnm_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Jnm_SelectBindingNavigator.SuspendLayout()
        CType(Me.Jnm_SelectGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForJenisMeja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetJenisMeja
        '
        Me.DataSetJenisMeja.DataSetName = "DataSetJenisMeja"
        Me.DataSetJenisMeja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Jnm_SelectBindingSource
        '
        Me.Jnm_SelectBindingSource.DataMember = "Jnm_Select"
        Me.Jnm_SelectBindingSource.DataSource = Me.DataSetJenisMeja
        '
        'Jnm_SelectTableAdapter
        '
        Me.Jnm_SelectTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Jnm_SelectTableAdapter = Me.Jnm_SelectTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetJenisMejaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Jnm_SelectBindingNavigator
        '
        Me.Jnm_SelectBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Jnm_SelectBindingNavigator.BindingSource = Me.Jnm_SelectBindingSource
        Me.Jnm_SelectBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Jnm_SelectBindingNavigator.DeleteItem = Nothing
        Me.Jnm_SelectBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripButton1, Me.Jnm_SelectBindingNavigatorSaveItem})
        Me.Jnm_SelectBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Jnm_SelectBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Jnm_SelectBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Jnm_SelectBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Jnm_SelectBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Jnm_SelectBindingNavigator.Name = "Jnm_SelectBindingNavigator"
        Me.Jnm_SelectBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Jnm_SelectBindingNavigator.Size = New System.Drawing.Size(326, 25)
        Me.Jnm_SelectBindingNavigator.TabIndex = 0
        Me.Jnm_SelectBindingNavigator.Text = "BindingNavigator1"
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
        'Jnm_SelectBindingNavigatorSaveItem
        '
        Me.Jnm_SelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Jnm_SelectBindingNavigatorSaveItem.Image = CType(resources.GetObject("Jnm_SelectBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Jnm_SelectBindingNavigatorSaveItem.Name = "Jnm_SelectBindingNavigatorSaveItem"
        Me.Jnm_SelectBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Jnm_SelectBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Jnm_SelectGridControl
        '
        Me.Jnm_SelectGridControl.DataSource = Me.Jnm_SelectBindingSource
        Me.Jnm_SelectGridControl.Location = New System.Drawing.Point(12, 60)
        Me.Jnm_SelectGridControl.MainView = Me.GridView1
        Me.Jnm_SelectGridControl.Name = "Jnm_SelectGridControl"
        Me.Jnm_SelectGridControl.Size = New System.Drawing.Size(302, 316)
        Me.Jnm_SelectGridControl.TabIndex = 3
        Me.Jnm_SelectGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDJenisMeJa, Me.colJenisMeja, Me.colKeterangan, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
        Me.GridView1.GridControl = Me.Jnm_SelectGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colIDJenisMeJa
        '
        Me.colIDJenisMeJa.FieldName = "IDJenisMeJa"
        Me.colIDJenisMeJa.Name = "colIDJenisMeJa"
        '
        'colJenisMeja
        '
        Me.colJenisMeja.FieldName = "JenisMeja"
        Me.colJenisMeja.Name = "colJenisMeja"
        Me.colJenisMeja.Visible = True
        Me.colJenisMeja.VisibleIndex = 0
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
        Me.DataLayoutControl1.Controls.Add(Me.Jnm_SelectGridControl)
        Me.DataLayoutControl1.Controls.Add(Me.JenisMejaTextEdit)
        Me.DataLayoutControl1.Controls.Add(Me.KeteranganTextEdit)
        Me.DataLayoutControl1.DataSource = Me.Jnm_SelectBindingSource
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
        Me.DataLayoutControl1.Size = New System.Drawing.Size(326, 427)
        Me.DataLayoutControl1.TabIndex = 3
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(12, 380)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Columns = 2
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Show Active Tables", True, 1), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Show Inactive Tables")})
        Me.RadioGroup1.Size = New System.Drawing.Size(302, 35)
        Me.RadioGroup1.StyleController = Me.DataLayoutControl1
        Me.RadioGroup1.TabIndex = 4
        '
        'JenisMejaTextEdit
        '
        Me.JenisMejaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Jnm_SelectBindingSource, "JenisMeja", True))
        Me.JenisMejaTextEdit.Location = New System.Drawing.Point(71, 12)
        Me.JenisMejaTextEdit.Name = "JenisMejaTextEdit"
        Me.JenisMejaTextEdit.Size = New System.Drawing.Size(243, 20)
        Me.JenisMejaTextEdit.StyleController = Me.DataLayoutControl1
        Me.JenisMejaTextEdit.TabIndex = 0
        '
        'KeteranganTextEdit
        '
        Me.KeteranganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Jnm_SelectBindingSource, "Keterangan", True))
        Me.KeteranganTextEdit.Location = New System.Drawing.Point(71, 36)
        Me.KeteranganTextEdit.Name = "KeteranganTextEdit"
        Me.KeteranganTextEdit.Size = New System.Drawing.Size(243, 20)
        Me.KeteranganTextEdit.StyleController = Me.DataLayoutControl1
        Me.KeteranganTextEdit.TabIndex = 2
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(326, 427)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AllowDrawBackground = False
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForJenisMeja, Me.ItemForKeterangan, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(306, 407)
        '
        'ItemForJenisMeja
        '
        Me.ItemForJenisMeja.Control = Me.JenisMejaTextEdit
        Me.ItemForJenisMeja.Location = New System.Drawing.Point(0, 0)
        Me.ItemForJenisMeja.Name = "ItemForJenisMeja"
        Me.ItemForJenisMeja.Size = New System.Drawing.Size(306, 24)
        Me.ItemForJenisMeja.Text = "Jenis Meja"
        Me.ItemForJenisMeja.TextSize = New System.Drawing.Size(56, 13)
        '
        'ItemForKeterangan
        '
        Me.ItemForKeterangan.Control = Me.KeteranganTextEdit
        Me.ItemForKeterangan.Location = New System.Drawing.Point(0, 24)
        Me.ItemForKeterangan.Name = "ItemForKeterangan"
        Me.ItemForKeterangan.Size = New System.Drawing.Size(306, 24)
        Me.ItemForKeterangan.Text = "Keterangan"
        Me.ItemForKeterangan.TextSize = New System.Drawing.Size(56, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Jnm_SelectGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(306, 320)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.RadioGroup1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 368)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(306, 39)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'FormJenisMeja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 452)
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.Jnm_SelectBindingNavigator)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "FormJenisMeja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormJenisMeja"
        CType(Me.DataSetJenisMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jnm_SelectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jnm_SelectBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Jnm_SelectBindingNavigator.ResumeLayout(False)
        Me.Jnm_SelectBindingNavigator.PerformLayout()
        CType(Me.Jnm_SelectGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisMejaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeteranganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForJenisMeja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemForKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetJenisMeja As DataSetJenisMeja
    Friend WithEvents Jnm_SelectBindingSource As BindingSource
    Friend WithEvents Jnm_SelectTableAdapter As DataSetJenisMejaTableAdapters.Jnm_SelectTableAdapter
    Friend WithEvents TableAdapterManager As DataSetJenisMejaTableAdapters.TableAdapterManager
    Friend WithEvents Jnm_SelectBindingNavigator As BindingNavigator
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
    Friend WithEvents Jnm_SelectBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Jnm_SelectGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDJenisMeJa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJenisMeja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents JenisMejaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents KeteranganTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ItemForJenisMeja As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ItemForKeterangan As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
