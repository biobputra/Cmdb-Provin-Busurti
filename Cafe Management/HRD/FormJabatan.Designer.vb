<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJabatan
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJabatan))
    Me.DataSetHRD = New Cafe_Management.DataSetHRD()
    Me.JabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.JabatanTableAdapter = New Cafe_Management.DataSetHRDTableAdapters.JabatanTableAdapter()
    Me.TableAdapterManager = New Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager()
    Me.JabatanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
    Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
    Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
    Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
    Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
    Me.JabatanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.IDDivisiLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.ItemForIDDivisi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.colIDDivisi = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIDJabatan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.DivisiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DivisiTableAdapter = New Cafe_Management.DataSetHRDTableAdapters.DivisiTableAdapter()
    CType(Me.DataSetHRD, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.JabatanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.JabatanBindingNavigator.SuspendLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DataLayoutControl1.SuspendLayout()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDDivisiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DivisiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataSetHRD
    '
    Me.DataSetHRD.DataSetName = "DataSetHRD"
    Me.DataSetHRD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'JabatanBindingSource
    '
    Me.JabatanBindingSource.DataMember = "Jabatan"
    Me.JabatanBindingSource.DataSource = Me.DataSetHRD
    '
    'JabatanTableAdapter
    '
    Me.JabatanTableAdapter.ClearBeforeFill = True
    '
    'TableAdapterManager
    '
    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager.DivisiTableAdapter = Me.DivisiTableAdapter
    Me.TableAdapterManager.JabatanTableAdapter = Me.JabatanTableAdapter
    Me.TableAdapterManager.KaryawanAbsenTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanPendidikanTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanPengalamanTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanPenyesuaianGajiTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanTableAdapter = Nothing
    Me.TableAdapterManager.PerubahanShiftTableAdapter = Nothing
    Me.TableAdapterManager.StatusKaryawanTableAdapter = Nothing
    Me.TableAdapterManager.StatusPernikahanTableAdapter = Nothing
    Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '
    'JabatanBindingNavigator
    '
    Me.JabatanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.JabatanBindingNavigator.BindingSource = Me.JabatanBindingSource
    Me.JabatanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
    Me.JabatanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.JabatanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.JabatanBindingNavigatorSaveItem})
    Me.JabatanBindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.JabatanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.JabatanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.JabatanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.JabatanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.JabatanBindingNavigator.Name = "JabatanBindingNavigator"
    Me.JabatanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
    Me.JabatanBindingNavigator.Size = New System.Drawing.Size(364, 25)
    Me.JabatanBindingNavigator.TabIndex = 0
    Me.JabatanBindingNavigator.Text = "BindingNavigator1"
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
    'JabatanBindingNavigatorSaveItem
    '
    Me.JabatanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.JabatanBindingNavigatorSaveItem.Image = CType(resources.GetObject("JabatanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.JabatanBindingNavigatorSaveItem.Name = "JabatanBindingNavigatorSaveItem"
    Me.JabatanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
    Me.JabatanBindingNavigatorSaveItem.Text = "Save Data"
    '
    'DataLayoutControl1
    '
    Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
    Me.DataLayoutControl1.Controls.Add(Me.IDDivisiLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
    Me.DataLayoutControl1.DataSource = Me.JabatanBindingSource
    Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
    Me.DataLayoutControl1.Name = "DataLayoutControl1"
    Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
    Me.DataLayoutControl1.Size = New System.Drawing.Size(364, 321)
    Me.DataLayoutControl1.TabIndex = 1
    Me.DataLayoutControl1.Text = "DataLayoutControl1"
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(364, 321)
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AllowDrawBackground = False
    Me.LayoutControlGroup2.GroupBordersVisible = False
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDDivisi, Me.ItemForNama, Me.LayoutControlItem1})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(344, 301)
    '
    'IDDivisiLookUpEdit
    '
    Me.IDDivisiLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JabatanBindingSource, "IDDivisi", True))
    Me.IDDivisiLookUpEdit.Location = New System.Drawing.Point(85, 12)
    Me.IDDivisiLookUpEdit.Name = "IDDivisiLookUpEdit"
    Me.IDDivisiLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDDivisiLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDDivisiLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDDivisiLookUpEdit.Properties.DataSource = Me.DivisiBindingSource
    Me.IDDivisiLookUpEdit.Properties.DisplayMember = "Nama"
    Me.IDDivisiLookUpEdit.Properties.NullText = ""
    Me.IDDivisiLookUpEdit.Properties.ValueMember = "IDDivisi"
    Me.IDDivisiLookUpEdit.Size = New System.Drawing.Size(267, 20)
    Me.IDDivisiLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDDivisiLookUpEdit.TabIndex = 4
    '
    'ItemForIDDivisi
    '
    Me.ItemForIDDivisi.Control = Me.IDDivisiLookUpEdit
    Me.ItemForIDDivisi.Location = New System.Drawing.Point(0, 0)
    Me.ItemForIDDivisi.Name = "ItemForIDDivisi"
    Me.ItemForIDDivisi.Size = New System.Drawing.Size(344, 24)
    Me.ItemForIDDivisi.Text = "Divisi"
    Me.ItemForIDDivisi.TextSize = New System.Drawing.Size(69, 13)
    '
    'NamaTextEdit
    '
    Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.JabatanBindingSource, "Nama", True))
    Me.NamaTextEdit.Location = New System.Drawing.Point(85, 36)
    Me.NamaTextEdit.Name = "NamaTextEdit"
    Me.NamaTextEdit.Size = New System.Drawing.Size(267, 20)
    Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
    Me.NamaTextEdit.TabIndex = 6
    '
    'ItemForNama
    '
    Me.ItemForNama.Control = Me.NamaTextEdit
    Me.ItemForNama.Location = New System.Drawing.Point(0, 24)
    Me.ItemForNama.Name = "ItemForNama"
    Me.ItemForNama.Size = New System.Drawing.Size(344, 24)
    Me.ItemForNama.Text = "Nama Jabatan"
    Me.ItemForNama.TextSize = New System.Drawing.Size(69, 13)
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.JabatanBindingSource
    Me.GridControl1.Location = New System.Drawing.Point(12, 60)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(340, 249)
    Me.GridControl1.TabIndex = 2
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDDivisi, Me.colIDJabatan, Me.colNama})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.GridControl1
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 48)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(344, 253)
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextVisible = False
    '
    'colIDDivisi
    '
    Me.colIDDivisi.FieldName = "IDDivisi"
    Me.colIDDivisi.Name = "colIDDivisi"
    Me.colIDDivisi.Visible = True
    Me.colIDDivisi.VisibleIndex = 0
    '
    'colIDJabatan
    '
    Me.colIDJabatan.FieldName = "IDJabatan"
    Me.colIDJabatan.Name = "colIDJabatan"
    Me.colIDJabatan.Visible = True
    Me.colIDJabatan.VisibleIndex = 1
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 2
    '
    'DivisiBindingSource
    '
    Me.DivisiBindingSource.DataMember = "Divisi"
    Me.DivisiBindingSource.DataSource = Me.DataSetHRD
    '
    'DivisiTableAdapter
    '
    Me.DivisiTableAdapter.ClearBeforeFill = True
    '
    'FormJabatan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(364, 346)
    Me.Controls.Add(Me.DataLayoutControl1)
    Me.Controls.Add(Me.JabatanBindingNavigator)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "FormJabatan"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Jabatan"
    CType(Me.DataSetHRD, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.JabatanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    Me.JabatanBindingNavigator.ResumeLayout(False)
    Me.JabatanBindingNavigator.PerformLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DataLayoutControl1.ResumeLayout(False)
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDDivisiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDDivisi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DivisiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataSetHRD As Cafe_Management.DataSetHRD
  Friend WithEvents JabatanBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents JabatanTableAdapter As Cafe_Management.DataSetHRDTableAdapters.JabatanTableAdapter
  Friend WithEvents TableAdapterManager As Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager
  Friend WithEvents JabatanBindingNavigator As System.Windows.Forms.BindingNavigator
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
  Friend WithEvents JabatanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents IDDivisiLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents ItemForIDDivisi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNama As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents DivisiTableAdapter As Cafe_Management.DataSetHRDTableAdapters.DivisiTableAdapter
  Friend WithEvents colIDDivisi As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIDJabatan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents DivisiBindingSource As System.Windows.Forms.BindingSource
End Class
