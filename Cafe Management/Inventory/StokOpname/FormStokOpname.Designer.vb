﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStokOpname
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TambahBtn = New System.Windows.Forms.ToolStripButton()
        Me.EditBtn = New System.Windows.Forms.ToolStripButton()
        Me.HapusBtn = New System.Windows.Forms.ToolStripButton()
        Me.SimpanBtn = New System.Windows.Forms.ToolStripButton()
        Me.BatalBtn = New System.Windows.Forms.ToolStripButton()
        Me.LaporanBtn = New System.Windows.Forms.ToolStripButton()
        Me.PencarianBtn = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.InputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TanggalDTP = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoBrk = New DevExpress.XtraEditors.TextEdit()
        Me.txtCatatan = New System.Windows.Forms.TextBox()
        Me.dgvHeader = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvView = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.InputLayout.SuspendLayout()
        CType(Me.txtNoBrk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahBtn, Me.EditBtn, Me.HapusBtn, Me.SimpanBtn, Me.BatalBtn, Me.LaporanBtn, Me.PencarianBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1244, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TambahBtn
        '
        Me.TambahBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(54, 22)
        Me.TambahBtn.Text = "Tambah"
        '
        'EditBtn
        '
        Me.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(31, 22)
        Me.EditBtn.Text = "Edit"
        '
        'HapusBtn
        '
        Me.HapusBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(45, 22)
        Me.HapusBtn.Text = "Hapus"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(51, 22)
        Me.SimpanBtn.Text = "Simpan"
        '
        'BatalBtn
        '
        Me.BatalBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(37, 22)
        Me.BatalBtn.Text = "Batal"
        '
        'LaporanBtn
        '
        Me.LaporanBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LaporanBtn.Name = "LaporanBtn"
        Me.LaporanBtn.Size = New System.Drawing.Size(54, 22)
        Me.LaporanBtn.Text = "Laporan"
        '
        'PencarianBtn
        '
        Me.PencarianBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PencarianBtn.Name = "PencarianBtn"
        Me.PencarianBtn.Size = New System.Drawing.Size(63, 22)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCatatan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.InputLayout)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvHeader)
        Me.SplitContainer1.Size = New System.Drawing.Size(1244, 176)
        Me.SplitContainer1.SplitterDistance = 414
        Me.SplitContainer1.TabIndex = 4
        '
        'InputLayout
        '
        Me.InputLayout.ColumnCount = 2
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputLayout.Controls.Add(Me.Label3, 0, 2)
        Me.InputLayout.Controls.Add(Me.label1, 0, 1)
        Me.InputLayout.Controls.Add(Me.TanggalDTP, 1, 1)
        Me.InputLayout.Controls.Add(Me.Label2, 0, 0)
        Me.InputLayout.Controls.Add(Me.txtNoBrk, 1, 0)
        Me.InputLayout.Dock = System.Windows.Forms.DockStyle.Top
        Me.InputLayout.Location = New System.Drawing.Point(0, 0)
        Me.InputLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputLayout.Name = "InputLayout"
        Me.InputLayout.RowCount = 3
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.InputLayout.Size = New System.Drawing.Size(414, 77)
        Me.InputLayout.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Catatan"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(3, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Tanggal"
        '
        'TanggalDTP
        '
        Me.TanggalDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TanggalDTP.Location = New System.Drawing.Point(123, 29)
        Me.TanggalDTP.Name = "TanggalDTP"
        Me.TanggalDTP.Size = New System.Drawing.Size(165, 21)
        Me.TanggalDTP.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No.Stok Opname"
        '
        'txtNoBrk
        '
        Me.txtNoBrk.Location = New System.Drawing.Point(123, 3)
        Me.txtNoBrk.Name = "txtNoBrk"
        Me.txtNoBrk.Size = New System.Drawing.Size(165, 20)
        Me.txtNoBrk.TabIndex = 5
        '
        'txtCatatan
        '
        Me.txtCatatan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCatatan.Location = New System.Drawing.Point(0, 77)
        Me.txtCatatan.Multiline = True
        Me.txtCatatan.Name = "txtCatatan"
        Me.txtCatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCatatan.Size = New System.Drawing.Size(414, 99)
        Me.txtCatatan.TabIndex = 5
        '
        'dgvHeader
        '
        Me.dgvHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHeader.Location = New System.Drawing.Point(0, 0)
        Me.dgvHeader.MainView = Me.GridView1
        Me.dgvHeader.Name = "dgvHeader"
        Me.dgvHeader.Size = New System.Drawing.Size(826, 176)
        Me.dgvHeader.TabIndex = 3
        Me.dgvHeader.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvHeader
        Me.GridView1.Name = "GridView1"
        '
        'dgvView
        '
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 201)
        Me.dgvView.MainView = Me.GridView3
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(1244, 250)
        Me.dgvView.TabIndex = 5
        Me.dgvView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.dgvView
        Me.GridView3.Name = "GridView3"
        '
        'FormStokOpname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 451)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormStokOpname"
        Me.Text = "Stok Opname"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.InputLayout.ResumeLayout(False)
        CType(Me.txtNoBrk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents InputLayout As TableLayoutPanel
    Private WithEvents Label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents TanggalDTP As DateTimePicker
    Private WithEvents Label2 As Label
    Friend WithEvents txtNoBrk As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents dgvHeader As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
End Class