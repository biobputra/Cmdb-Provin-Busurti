<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccountingGroupAkun
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAccountingGroupAkun))
    Me.DataSetAccounting = New Cafe_Management.DataSetAccounting()
    Me.GroupAkunBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.GroupAkunTableAdapter = New Cafe_Management.DataSetAccountingTableAdapters.GroupAkunTableAdapter()
    Me.TableAdapterManager = New Cafe_Management.DataSetAccountingTableAdapters.TableAdapterManager()
    Me.GroupTemplateTransaksiTableAdapter = New Cafe_Management.DataSetAccountingTableAdapters.GroupTemplateTransaksiTableAdapter()
    Me.GroupAkunBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
    Me.GroupAkunBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    Me.GroupTemplateTransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colIDGroupAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNoAkun = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colPosisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
    Me.NoAkunTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.PosisiLookUpEdit = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.ItemForNoAkun = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ItemForPosisi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.DataSetAccounting, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupAkunBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GroupAkunBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupAkunBindingNavigator.SuspendLayout()
    CType(Me.GroupTemplateTransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DataLayoutControl1.SuspendLayout()
    CType(Me.NoAkunTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PosisiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'GroupAkunBindingSource
    '
    Me.GroupAkunBindingSource.DataMember = "GroupAkun"
    Me.GroupAkunBindingSource.DataSource = Me.DataSetAccounting
    '
    'GroupAkunTableAdapter
    '
    Me.GroupAkunTableAdapter.ClearBeforeFill = True
    '
    'TableAdapterManager
    '
    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager.COATableAdapter = Nothing
    Me.TableAdapterManager.GroupAkunTableAdapter = Me.GroupAkunTableAdapter
    Me.TableAdapterManager.GroupTemplateTransaksiTableAdapter = Me.GroupTemplateTransaksiTableAdapter
    Me.TableAdapterManager.JurnalDTableAdapter = Nothing
    Me.TableAdapterManager.JurnalHTableAdapter = Nothing
    Me.TableAdapterManager.TemplateTransaksiTableAdapter = Nothing
    Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetAccountingTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '
    'GroupTemplateTransaksiTableAdapter
    '
    Me.GroupTemplateTransaksiTableAdapter.ClearBeforeFill = True
    '
    'GroupAkunBindingNavigator
    '
    Me.GroupAkunBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.GroupAkunBindingNavigator.BindingSource = Me.GroupAkunBindingSource
    Me.GroupAkunBindingNavigator.CountItem = Me.BindingNavigatorCountItem
    Me.GroupAkunBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.GroupAkunBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GroupAkunBindingNavigatorSaveItem})
    Me.GroupAkunBindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.GroupAkunBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.GroupAkunBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.GroupAkunBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.GroupAkunBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.GroupAkunBindingNavigator.Name = "GroupAkunBindingNavigator"
    Me.GroupAkunBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
    Me.GroupAkunBindingNavigator.Size = New System.Drawing.Size(468, 25)
    Me.GroupAkunBindingNavigator.TabIndex = 0
    Me.GroupAkunBindingNavigator.Text = "BindingNavigator1"
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
    'GroupAkunBindingNavigatorSaveItem
    '
    Me.GroupAkunBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.GroupAkunBindingNavigatorSaveItem.Image = CType(resources.GetObject("GroupAkunBindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.GroupAkunBindingNavigatorSaveItem.Name = "GroupAkunBindingNavigatorSaveItem"
    Me.GroupAkunBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
    Me.GroupAkunBindingNavigatorSaveItem.Text = "Save Data"
    '
    'GroupTemplateTransaksiBindingSource
    '
    Me.GroupTemplateTransaksiBindingSource.DataMember = "GroupTemplateTransaksi"
    Me.GroupTemplateTransaksiBindingSource.DataSource = Me.DataSetAccounting
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.GroupAkunBindingSource
    Me.GridControl1.Location = New System.Drawing.Point(12, 84)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(444, 197)
    Me.GridControl1.TabIndex = 4
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDGroupAkun, Me.colNoAkun, Me.colNama, Me.colPosisi})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'colIDGroupAkun
    '
    Me.colIDGroupAkun.FieldName = "IDGroupAkun"
    Me.colIDGroupAkun.Name = "colIDGroupAkun"
    Me.colIDGroupAkun.Visible = True
    Me.colIDGroupAkun.VisibleIndex = 0
    '
    'colNoAkun
    '
    Me.colNoAkun.FieldName = "NoAkun"
    Me.colNoAkun.Name = "colNoAkun"
    Me.colNoAkun.Visible = True
    Me.colNoAkun.VisibleIndex = 1
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 2
    '
    'colPosisi
    '
    Me.colPosisi.FieldName = "Posisi"
    Me.colPosisi.Name = "colPosisi"
    Me.colPosisi.Visible = True
    Me.colPosisi.VisibleIndex = 3
    '
    'DataLayoutControl1
    '
    Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
    Me.DataLayoutControl1.Controls.Add(Me.NoAkunTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.PosisiLookUpEdit)
    Me.DataLayoutControl1.DataSource = Me.GroupAkunBindingSource
    Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
    Me.DataLayoutControl1.Name = "DataLayoutControl1"
    Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(817, 120, 250, 350)
    Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
    Me.DataLayoutControl1.Size = New System.Drawing.Size(468, 293)
    Me.DataLayoutControl1.TabIndex = 2
    Me.DataLayoutControl1.Text = "DataLayoutControl1"
    '
    'NoAkunTextEdit
    '
    Me.NoAkunTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GroupAkunBindingSource, "NoAkun", True))
    Me.NoAkunTextEdit.Location = New System.Drawing.Point(55, 12)
    Me.NoAkunTextEdit.Name = "NoAkunTextEdit"
    Me.NoAkunTextEdit.Size = New System.Drawing.Size(401, 20)
    Me.NoAkunTextEdit.StyleController = Me.DataLayoutControl1
    Me.NoAkunTextEdit.TabIndex = 0
    '
    'NamaTextEdit
    '
    Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GroupAkunBindingSource, "Nama", True))
    Me.NamaTextEdit.Location = New System.Drawing.Point(55, 36)
    Me.NamaTextEdit.Name = "NamaTextEdit"
    Me.NamaTextEdit.Size = New System.Drawing.Size(401, 20)
    Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
    Me.NamaTextEdit.TabIndex = 2
    '
    'PosisiLookUpEdit
    '
    Me.PosisiLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GroupAkunBindingSource, "Posisi", True))
    Me.PosisiLookUpEdit.Location = New System.Drawing.Point(55, 60)
    Me.PosisiLookUpEdit.Name = "PosisiLookUpEdit"
    Me.PosisiLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.PosisiLookUpEdit.Properties.Items.AddRange(New Object() {"D", "K"})
    Me.PosisiLookUpEdit.Properties.PopupSizeable = True
    Me.PosisiLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
    Me.PosisiLookUpEdit.Size = New System.Drawing.Size(401, 20)
    Me.PosisiLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.PosisiLookUpEdit.TabIndex = 3
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlItem1})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "Root"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(468, 293)
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AllowDrawBackground = False
    Me.LayoutControlGroup2.GroupBordersVisible = False
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNoAkun, Me.ItemForNama, Me.ItemForPosisi})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(448, 72)
    '
    'ItemForNoAkun
    '
    Me.ItemForNoAkun.Control = Me.NoAkunTextEdit
    Me.ItemForNoAkun.Location = New System.Drawing.Point(0, 0)
    Me.ItemForNoAkun.Name = "ItemForNoAkun"
    Me.ItemForNoAkun.Size = New System.Drawing.Size(448, 24)
    Me.ItemForNoAkun.Text = "No Akun"
    Me.ItemForNoAkun.TextSize = New System.Drawing.Size(40, 13)
    '
    'ItemForNama
    '
    Me.ItemForNama.Control = Me.NamaTextEdit
    Me.ItemForNama.Location = New System.Drawing.Point(0, 24)
    Me.ItemForNama.Name = "ItemForNama"
    Me.ItemForNama.Size = New System.Drawing.Size(448, 24)
    Me.ItemForNama.Text = "Nama"
    Me.ItemForNama.TextSize = New System.Drawing.Size(40, 13)
    '
    'ItemForPosisi
    '
    Me.ItemForPosisi.Control = Me.PosisiLookUpEdit
    Me.ItemForPosisi.Location = New System.Drawing.Point(0, 48)
    Me.ItemForPosisi.Name = "ItemForPosisi"
    Me.ItemForPosisi.Size = New System.Drawing.Size(448, 24)
    Me.ItemForPosisi.Text = "Posisi"
    Me.ItemForPosisi.TextSize = New System.Drawing.Size(40, 13)
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.GridControl1
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 72)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(448, 201)
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextVisible = False
    '
    'FormAccountingGroupAkun
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(468, 318)
    Me.Controls.Add(Me.DataLayoutControl1)
    Me.Controls.Add(Me.GroupAkunBindingNavigator)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "FormAccountingGroupAkun"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Group Akun"
    CType(Me.DataSetAccounting, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupAkunBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GroupAkunBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupAkunBindingNavigator.ResumeLayout(False)
    Me.GroupAkunBindingNavigator.PerformLayout()
    CType(Me.GroupTemplateTransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DataLayoutControl1.ResumeLayout(False)
    CType(Me.NoAkunTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PosisiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNoAkun, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForPosisi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataSetAccounting As Cafe_Management.DataSetAccounting
  Friend WithEvents GroupAkunBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents GroupAkunTableAdapter As Cafe_Management.DataSetAccountingTableAdapters.GroupAkunTableAdapter
  Friend WithEvents TableAdapterManager As Cafe_Management.DataSetAccountingTableAdapters.TableAdapterManager
  Friend WithEvents GroupAkunBindingNavigator As System.Windows.Forms.BindingNavigator
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
  Friend WithEvents GroupAkunBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents GroupTemplateTransaksiTableAdapter As Cafe_Management.DataSetAccountingTableAdapters.GroupTemplateTransaksiTableAdapter
  Friend WithEvents GroupTemplateTransaksiBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colIDGroupAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNoAkun As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colPosisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
  Friend WithEvents NoAkunTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents PosisiLookUpEdit As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents ItemForNoAkun As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNama As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForPosisi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
