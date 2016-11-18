<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatusKaryawan
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStatusKaryawan))
    Me.DataSetHRD = New Cafe_Management.DataSetHRD()
    Me.StatusKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.StatusKaryawanTableAdapter = New Cafe_Management.DataSetHRDTableAdapters.StatusKaryawanTableAdapter()
    Me.TableAdapterManager = New Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager()
    Me.StatusKaryawanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
    Me.StatusKaryawanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.NamaTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForNama = New DevExpress.XtraLayout.LayoutControlItem()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    Me.colIDStatusKaryawan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
    CType(Me.DataSetHRD, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StatusKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StatusKaryawanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.StatusKaryawanBindingNavigator.SuspendLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DataLayoutControl1.SuspendLayout()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataSetHRD
    '
    Me.DataSetHRD.DataSetName = "DataSetHRD"
    Me.DataSetHRD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'StatusKaryawanBindingSource
    '
    Me.StatusKaryawanBindingSource.DataMember = "StatusKaryawan"
    Me.StatusKaryawanBindingSource.DataSource = Me.DataSetHRD
    '
    'StatusKaryawanTableAdapter
    '
    Me.StatusKaryawanTableAdapter.ClearBeforeFill = True
    '
    'TableAdapterManager
    '
    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager.DivisiTableAdapter = Nothing
    Me.TableAdapterManager.JabatanTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanAbsenTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanPendidikanTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanPengalamanTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanPenyesuaianGajiTableAdapter = Nothing
    Me.TableAdapterManager.KaryawanTableAdapter = Nothing
    Me.TableAdapterManager.PerubahanShiftTableAdapter = Nothing
    Me.TableAdapterManager.StatusKaryawanTableAdapter = Me.StatusKaryawanTableAdapter
    Me.TableAdapterManager.StatusPernikahanTableAdapter = Nothing
    Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '
    'StatusKaryawanBindingNavigator
    '
    Me.StatusKaryawanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.StatusKaryawanBindingNavigator.BindingSource = Me.StatusKaryawanBindingSource
    Me.StatusKaryawanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
    Me.StatusKaryawanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.StatusKaryawanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StatusKaryawanBindingNavigatorSaveItem})
    Me.StatusKaryawanBindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.StatusKaryawanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.StatusKaryawanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.StatusKaryawanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.StatusKaryawanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.StatusKaryawanBindingNavigator.Name = "StatusKaryawanBindingNavigator"
    Me.StatusKaryawanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
    Me.StatusKaryawanBindingNavigator.Size = New System.Drawing.Size(490, 25)
    Me.StatusKaryawanBindingNavigator.TabIndex = 0
    Me.StatusKaryawanBindingNavigator.Text = "BindingNavigator1"
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
    'StatusKaryawanBindingNavigatorSaveItem
    '
    Me.StatusKaryawanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.StatusKaryawanBindingNavigatorSaveItem.Image = CType(resources.GetObject("StatusKaryawanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.StatusKaryawanBindingNavigatorSaveItem.Name = "StatusKaryawanBindingNavigatorSaveItem"
    Me.StatusKaryawanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
    Me.StatusKaryawanBindingNavigatorSaveItem.Text = "Save Data"
    '
    'DataLayoutControl1
    '
    Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
    Me.DataLayoutControl1.Controls.Add(Me.NamaTextEdit)
    Me.DataLayoutControl1.DataSource = Me.StatusKaryawanBindingSource
    Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 25)
    Me.DataLayoutControl1.Name = "DataLayoutControl1"
    Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
    Me.DataLayoutControl1.Size = New System.Drawing.Size(490, 349)
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
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(490, 349)
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AllowDrawBackground = False
    Me.LayoutControlGroup2.GroupBordersVisible = False
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForNama, Me.LayoutControlItem1})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(470, 329)
    '
    'NamaTextEdit
    '
    Me.NamaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.StatusKaryawanBindingSource, "Nama", True))
    Me.NamaTextEdit.Location = New System.Drawing.Point(98, 12)
    Me.NamaTextEdit.Name = "NamaTextEdit"
    Me.NamaTextEdit.Size = New System.Drawing.Size(380, 20)
    Me.NamaTextEdit.StyleController = Me.DataLayoutControl1
    Me.NamaTextEdit.TabIndex = 5
    '
    'ItemForNama
    '
    Me.ItemForNama.Control = Me.NamaTextEdit
    Me.ItemForNama.Location = New System.Drawing.Point(0, 0)
    Me.ItemForNama.Name = "ItemForNama"
    Me.ItemForNama.Size = New System.Drawing.Size(470, 24)
    Me.ItemForNama.Text = "Status Karyawan"
    Me.ItemForNama.TextSize = New System.Drawing.Size(82, 13)
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.StatusKaryawanBindingSource
    Me.GridControl1.Location = New System.Drawing.Point(12, 36)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(466, 301)
    Me.GridControl1.TabIndex = 2
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDStatusKaryawan, Me.colNama})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.GridControl1
    Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(470, 305)
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextVisible = False
    '
    'colIDStatusKaryawan
    '
    Me.colIDStatusKaryawan.FieldName = "IDStatusKaryawan"
    Me.colIDStatusKaryawan.Name = "colIDStatusKaryawan"
    Me.colIDStatusKaryawan.Visible = True
    Me.colIDStatusKaryawan.VisibleIndex = 0
    '
    'colNama
    '
    Me.colNama.FieldName = "Nama"
    Me.colNama.Name = "colNama"
    Me.colNama.Visible = True
    Me.colNama.VisibleIndex = 1
    '
    'FormStatusKaryawan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(490, 374)
    Me.Controls.Add(Me.DataLayoutControl1)
    Me.Controls.Add(Me.StatusKaryawanBindingNavigator)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "FormStatusKaryawan"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Status Karyawan"
    CType(Me.DataSetHRD, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StatusKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StatusKaryawanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    Me.StatusKaryawanBindingNavigator.ResumeLayout(False)
    Me.StatusKaryawanBindingNavigator.PerformLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DataLayoutControl1.ResumeLayout(False)
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNama, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataSetHRD As Cafe_Management.DataSetHRD
  Friend WithEvents StatusKaryawanBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents StatusKaryawanTableAdapter As Cafe_Management.DataSetHRDTableAdapters.StatusKaryawanTableAdapter
  Friend WithEvents TableAdapterManager As Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager
  Friend WithEvents StatusKaryawanBindingNavigator As System.Windows.Forms.BindingNavigator
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
  Friend WithEvents StatusKaryawanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents colIDStatusKaryawan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents NamaTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents ItemForNama As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
