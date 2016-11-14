<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRetur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRetur))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TambahBtn = New System.Windows.Forms.ToolStripButton()
        Me.EditBtn = New System.Windows.Forms.ToolStripButton()
        Me.HapusBtn = New System.Windows.Forms.ToolStripButton()
        Me.SimpanBtn = New System.Windows.Forms.ToolStripButton()
        Me.BatalBtn = New System.Windows.Forms.ToolStripButton()
        Me.LaporanBtn = New System.Windows.Forms.ToolStripButton()
        Me.PencarianBtn = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.InputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DropDownButton1 = New DevExpress.XtraEditors.DropDownButton()
        Me.dgvHeader = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.dgvEdit = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputLayout.SuspendLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahBtn, Me.EditBtn, Me.HapusBtn, Me.SimpanBtn, Me.BatalBtn, Me.LaporanBtn, Me.PencarianBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1200, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TambahBtn
        '
        Me.TambahBtn.Image = CType(resources.GetObject("TambahBtn.Image"), System.Drawing.Image)
        Me.TambahBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(70, 22)
        Me.TambahBtn.Text = "Tambah"
        '
        'EditBtn
        '
        Me.EditBtn.Image = CType(resources.GetObject("EditBtn.Image"), System.Drawing.Image)
        Me.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(47, 22)
        Me.EditBtn.Text = "Edit"
        '
        'HapusBtn
        '
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(61, 22)
        Me.HapusBtn.Text = "Hapus"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(67, 22)
        Me.SimpanBtn.Text = "Simpan"
        '
        'BatalBtn
        '
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(53, 22)
        Me.BatalBtn.Text = "Batal"
        '
        'LaporanBtn
        '
        Me.LaporanBtn.Image = CType(resources.GetObject("LaporanBtn.Image"), System.Drawing.Image)
        Me.LaporanBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LaporanBtn.Name = "LaporanBtn"
        Me.LaporanBtn.Size = New System.Drawing.Size(70, 22)
        Me.LaporanBtn.Text = "Laporan"
        '
        'PencarianBtn
        '
        Me.PencarianBtn.Image = CType(resources.GetObject("PencarianBtn.Image"), System.Drawing.Image)
        Me.PencarianBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PencarianBtn.Name = "PencarianBtn"
        Me.PencarianBtn.Size = New System.Drawing.Size(79, 22)
        Me.PencarianBtn.Text = "Pencarian"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MemoEdit1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputLayout)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvHeader)
        Me.SplitContainer1.Size = New System.Drawing.Size(1200, 150)
        Me.SplitContainer1.SplitterDistance = 400
        Me.SplitContainer1.TabIndex = 2
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 86)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(400, 64)
        Me.MemoEdit1.TabIndex = 3
        '
        'InputLayout
        '
        Me.InputLayout.ColumnCount = 2
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputLayout.Controls.Add(Me.LabelControl3, 0, 2)
        Me.InputLayout.Controls.Add(Me.LabelControl2, 0, 1)
        Me.InputLayout.Controls.Add(Me.DateEdit1, 1, 0)
        Me.InputLayout.Controls.Add(Me.LabelControl1, 0, 0)
        Me.InputLayout.Controls.Add(Me.DropDownButton1, 1, 1)
        Me.InputLayout.Dock = System.Windows.Forms.DockStyle.Top
        Me.InputLayout.Location = New System.Drawing.Point(0, 0)
        Me.InputLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputLayout.Name = "InputLayout"
        Me.InputLayout.RowCount = 3
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.InputLayout.Size = New System.Drawing.Size(400, 86)
        Me.InputLayout.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl3.Location = New System.Drawing.Point(3, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 25)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Catatan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl2.Location = New System.Drawing.Point(3, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(114, 23)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Penerimaan"
        '
        'DateEdit1
        '
        Me.DateEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(123, 3)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(274, 20)
        Me.DateEdit1.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(114, 20)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tanggal"
        '
        'DropDownButton1
        '
        Me.DropDownButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropDownButton1.Location = New System.Drawing.Point(123, 29)
        Me.DropDownButton1.Name = "DropDownButton1"
        Me.DropDownButton1.Size = New System.Drawing.Size(274, 23)
        Me.DropDownButton1.TabIndex = 5
        Me.DropDownButton1.Text = "DropDownButton1"
        '
        'dgvHeader
        '
        Me.dgvHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHeader.Location = New System.Drawing.Point(0, 0)
        Me.dgvHeader.MainView = Me.GridView1
        Me.dgvHeader.Name = "dgvHeader"
        Me.dgvHeader.Size = New System.Drawing.Size(796, 150)
        Me.dgvHeader.TabIndex = 0
        Me.dgvHeader.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvHeader
        Me.GridView1.Name = "GridView1"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 175)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvEdit)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvView)
        Me.SplitContainer2.Size = New System.Drawing.Size(1200, 286)
        Me.SplitContainer2.SplitterDistance = 556
        Me.SplitContainer2.TabIndex = 3
        '
        'dgvEdit
        '
        Me.dgvEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEdit.Location = New System.Drawing.Point(0, 37)
        Me.dgvEdit.MainView = Me.GridView2
        Me.dgvEdit.Name = "dgvEdit"
        Me.dgvEdit.Size = New System.Drawing.Size(556, 249)
        Me.dgvEdit.TabIndex = 1
        Me.dgvEdit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgvEdit
        Me.GridView2.Name = "GridView2"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(556, 37)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl4.Location = New System.Drawing.Point(247, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 31)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Total"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl5.Location = New System.Drawing.Point(314, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(239, 31)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Rp.0"
        '
        'dgvView
        '
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 0)
        Me.dgvView.MainView = Me.GridView3
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(640, 286)
        Me.dgvView.TabIndex = 0
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.dgvView
        Me.GridView3.Name = "GridView3"
        '
        'FormRetur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 461)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormRetur"
        Me.Text = "Retur Pembelian"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputLayout.ResumeLayout(False)
        Me.InputLayout.PerformLayout()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TambahBtn As ToolStripButton
    Friend WithEvents EditBtn As ToolStripButton
    Friend WithEvents HapusBtn As ToolStripButton
    Friend WithEvents SimpanBtn As ToolStripButton
    Friend WithEvents BatalBtn As ToolStripButton
    Friend WithEvents LaporanBtn As ToolStripButton
    Friend WithEvents PencarianBtn As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents InputLayout As TableLayoutPanel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DropDownButton1 As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents dgvHeader As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgvEdit As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
