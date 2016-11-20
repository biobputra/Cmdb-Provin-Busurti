<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservasi
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReservasi))
    Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.MainSplit = New System.Windows.Forms.SplitContainer()
    Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
    Me.TabPageBilliard = New DevExpress.XtraTab.XtraTabPage()
    Me.BilliardGrid = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colIDDaftarMeja = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIDJenisMeja = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNomorMeja = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colKeterangan = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colTanggalbook = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJamMulai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJamSelesai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colModifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
    Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
    Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
    Me.TabPageResto = New DevExpress.XtraTab.XtraTabPage()
    Me.CheckListResto = New DevExpress.XtraEditors.CheckedListBoxControl()
    Me.TabPageBar = New DevExpress.XtraTab.XtraTabPage()
    Me.CheckListBar = New DevExpress.XtraEditors.CheckedListBoxControl()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.NoReservasiLbl = New DevExpress.XtraEditors.LabelControl()
    Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
    Me.NamaMemberCombo = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.NamaTamuTxt = New DevExpress.XtraEditors.TextEdit()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.UntukTanggalReservasi = New DevExpress.XtraEditors.DateEdit()
    Me.TamuChk = New DevExpress.XtraEditors.CheckEdit()
    Me.CheckedListReservasi = New System.Windows.Forms.CheckedListBox()
    Me.ReserveBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.CheckInBtn = New DevExpress.XtraEditors.SimpleButton()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainSplit.Panel1.SuspendLayout()
    Me.MainSplit.Panel2.SuspendLayout()
    Me.MainSplit.SuspendLayout()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.XtraTabControl1.SuspendLayout()
    Me.TabPageBilliard.SuspendLayout()
    CType(Me.BilliardGrid, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPageResto.SuspendLayout()
    CType(Me.CheckListResto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabPageBar.SuspendLayout()
    CType(Me.CheckListBar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel5.SuspendLayout()
    CType(Me.NamaMemberCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaTamuTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UntukTanggalReservasi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UntukTanggalReservasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TamuChk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'SimpanBtn
    '
    Me.SimpanBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SimpanBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpanBtn.Appearance.Options.UseFont = True
    Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
    Me.SimpanBtn.Location = New System.Drawing.Point(251, 253)
    Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.SimpanBtn.Name = "SimpanBtn"
    Me.SimpanBtn.Size = New System.Drawing.Size(98, 35)
    Me.SimpanBtn.TabIndex = 4
    Me.SimpanBtn.Text = "Simpan"
    '
    'BatalBtn
    '
    Me.BatalBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.BatalBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BatalBtn.Appearance.Options.UseFont = True
    Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
    Me.BatalBtn.Location = New System.Drawing.Point(355, 253)
    Me.BatalBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.BatalBtn.Name = "BatalBtn"
    Me.BatalBtn.Size = New System.Drawing.Size(96, 35)
    Me.BatalBtn.TabIndex = 5
    Me.BatalBtn.Text = "Batal"
    '
    'MainSplit
    '
    Me.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MainSplit.Location = New System.Drawing.Point(0, 0)
    Me.MainSplit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.MainSplit.Name = "MainSplit"
    Me.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'MainSplit.Panel1
    '
    Me.MainSplit.Panel1.Controls.Add(Me.XtraTabControl1)
    Me.MainSplit.Panel1.Controls.Add(Me.SimpanBtn)
    Me.MainSplit.Panel1.Controls.Add(Me.TableLayoutPanel3)
    Me.MainSplit.Panel1.Controls.Add(Me.BatalBtn)
    '
    'MainSplit.Panel2
    '
    Me.MainSplit.Panel2.Controls.Add(Me.CheckedListReservasi)
    Me.MainSplit.Panel2.Controls.Add(Me.ReserveBtn)
    Me.MainSplit.Panel2.Controls.Add(Me.CheckInBtn)
    Me.MainSplit.Size = New System.Drawing.Size(454, 483)
    Me.MainSplit.SplitterDistance = 292
    Me.MainSplit.SplitterWidth = 3
    Me.MainSplit.TabIndex = 10
    '
    'XtraTabControl1
    '
    Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XtraTabControl1.Appearance.Options.UseFont = True
    Me.XtraTabControl1.Location = New System.Drawing.Point(3, 124)
    Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.XtraTabControl1.Name = "XtraTabControl1"
    Me.XtraTabControl1.SelectedTabPage = Me.TabPageBilliard
    Me.XtraTabControl1.Size = New System.Drawing.Size(451, 130)
    Me.XtraTabControl1.TabIndex = 10
    Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPageBilliard, Me.TabPageResto, Me.TabPageBar})
    '
    'TabPageBilliard
    '
    Me.TabPageBilliard.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPageBilliard.Appearance.Header.Options.UseFont = True
    Me.TabPageBilliard.Controls.Add(Me.BilliardGrid)
    Me.TabPageBilliard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TabPageBilliard.Name = "TabPageBilliard"
    Me.TabPageBilliard.Size = New System.Drawing.Size(445, 96)
    Me.TabPageBilliard.Text = "Billiard"
    '
    'BilliardGrid
    '
    Me.BilliardGrid.DataMember = "DaftarMeja"
    Me.BilliardGrid.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BilliardGrid.Location = New System.Drawing.Point(0, 0)
    Me.BilliardGrid.MainView = Me.GridView1
    Me.BilliardGrid.Name = "BilliardGrid"
    Me.BilliardGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1, Me.RepositoryItemTimeEdit2, Me.RepositoryItemTextEdit1})
    Me.BilliardGrid.Size = New System.Drawing.Size(445, 96)
    Me.BilliardGrid.TabIndex = 0
    Me.BilliardGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDDaftarMeja, Me.colIDJenisMeja, Me.colNomorMeja, Me.colKeterangan, Me.colStatus, Me.colTanggalbook, Me.colJamMulai, Me.colJamSelesai, Me.colCreatedBy, Me.colCreatedDate, Me.colModifiedBy, Me.colModifiedDate, Me.colisActive})
    Me.GridView1.GridControl = Me.BilliardGrid
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'colIDDaftarMeja
    '
    Me.colIDDaftarMeja.FieldName = "IDDaftarMeja"
    Me.colIDDaftarMeja.Name = "colIDDaftarMeja"
    Me.colIDDaftarMeja.Visible = True
    Me.colIDDaftarMeja.VisibleIndex = 0
    '
    'colIDJenisMeja
    '
    Me.colIDJenisMeja.FieldName = "IDJenisMeja"
    Me.colIDJenisMeja.Name = "colIDJenisMeja"
    Me.colIDJenisMeja.Visible = True
    Me.colIDJenisMeja.VisibleIndex = 1
    '
    'colNomorMeja
    '
    Me.colNomorMeja.FieldName = "NomorMeja"
    Me.colNomorMeja.Name = "colNomorMeja"
    Me.colNomorMeja.Visible = True
    Me.colNomorMeja.VisibleIndex = 2
    '
    'colKeterangan
    '
    Me.colKeterangan.FieldName = "Keterangan"
    Me.colKeterangan.Name = "colKeterangan"
    Me.colKeterangan.Visible = True
    Me.colKeterangan.VisibleIndex = 3
    '
    'colStatus
    '
    Me.colStatus.FieldName = "Status"
    Me.colStatus.Name = "colStatus"
    Me.colStatus.Visible = True
    Me.colStatus.VisibleIndex = 4
    '
    'colTanggalbook
    '
    Me.colTanggalbook.FieldName = "Tanggalbook"
    Me.colTanggalbook.Name = "colTanggalbook"
    Me.colTanggalbook.Visible = True
    Me.colTanggalbook.VisibleIndex = 5
    '
    'colJamMulai
    '
    Me.colJamMulai.FieldName = "JamMulai"
    Me.colJamMulai.Name = "colJamMulai"
    Me.colJamMulai.Visible = True
    Me.colJamMulai.VisibleIndex = 6
    '
    'colJamSelesai
    '
    Me.colJamSelesai.FieldName = "JamSelesai"
    Me.colJamSelesai.Name = "colJamSelesai"
    Me.colJamSelesai.Visible = True
    Me.colJamSelesai.VisibleIndex = 7
    '
    'colCreatedBy
    '
    Me.colCreatedBy.FieldName = "CreatedBy"
    Me.colCreatedBy.Name = "colCreatedBy"
    Me.colCreatedBy.Visible = True
    Me.colCreatedBy.VisibleIndex = 8
    '
    'colCreatedDate
    '
    Me.colCreatedDate.FieldName = "CreatedDate"
    Me.colCreatedDate.Name = "colCreatedDate"
    Me.colCreatedDate.Visible = True
    Me.colCreatedDate.VisibleIndex = 9
    '
    'colModifiedBy
    '
    Me.colModifiedBy.FieldName = "ModifiedBy"
    Me.colModifiedBy.Name = "colModifiedBy"
    Me.colModifiedBy.Visible = True
    Me.colModifiedBy.VisibleIndex = 10
    '
    'colModifiedDate
    '
    Me.colModifiedDate.FieldName = "ModifiedDate"
    Me.colModifiedDate.Name = "colModifiedDate"
    Me.colModifiedDate.Visible = True
    Me.colModifiedDate.VisibleIndex = 11
    '
    'colisActive
    '
    Me.colisActive.FieldName = "isActive"
    Me.colisActive.Name = "colisActive"
    Me.colisActive.Visible = True
    Me.colisActive.VisibleIndex = 12
    '
    'RepositoryItemTimeEdit1
    '
    Me.RepositoryItemTimeEdit1.AutoHeight = False
    Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
    '
    'RepositoryItemTimeEdit2
    '
    Me.RepositoryItemTimeEdit2.AutoHeight = False
    Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
    '
    'RepositoryItemTextEdit1
    '
    Me.RepositoryItemTextEdit1.AutoHeight = False
    Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
    '
    'TabPageResto
    '
    Me.TabPageResto.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPageResto.Appearance.Header.Options.UseFont = True
    Me.TabPageResto.Controls.Add(Me.CheckListResto)
    Me.TabPageResto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TabPageResto.Name = "TabPageResto"
    Me.TabPageResto.Size = New System.Drawing.Size(445, 96)
    Me.TabPageResto.Text = "Resto"
    '
    'CheckListResto
    '
    Me.CheckListResto.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CheckListResto.Appearance.Options.UseFont = True
    Me.CheckListResto.CheckOnClick = True
    Me.CheckListResto.Cursor = System.Windows.Forms.Cursors.Default
    Me.CheckListResto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckListResto.Location = New System.Drawing.Point(0, 0)
    Me.CheckListResto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.CheckListResto.Name = "CheckListResto"
    Me.CheckListResto.Size = New System.Drawing.Size(445, 96)
    Me.CheckListResto.TabIndex = 1
    '
    'TabPageBar
    '
    Me.TabPageBar.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPageBar.Appearance.Header.Options.UseFont = True
    Me.TabPageBar.Controls.Add(Me.CheckListBar)
    Me.TabPageBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TabPageBar.Name = "TabPageBar"
    Me.TabPageBar.Size = New System.Drawing.Size(445, 96)
    Me.TabPageBar.Text = "Bar"
    '
    'CheckListBar
    '
    Me.CheckListBar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CheckListBar.Appearance.Options.UseFont = True
    Me.CheckListBar.CheckOnClick = True
    Me.CheckListBar.Cursor = System.Windows.Forms.Cursors.Default
    Me.CheckListBar.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckListBar.Location = New System.Drawing.Point(0, 0)
    Me.CheckListBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.CheckListBar.Name = "CheckListBar"
    Me.CheckListBar.Size = New System.Drawing.Size(445, 96)
    Me.CheckListBar.TabIndex = 1
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.LabelControl4, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.LabelControl1, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.NoReservasiLbl, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 1, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.LabelControl5, 0, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.LabelControl6, 0, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.UntukTanggalReservasi, 1, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.TamuChk, 1, 1)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 4
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(454, 124)
    Me.TableLayoutPanel3.TabIndex = 9
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl4.Location = New System.Drawing.Point(3, 34)
    Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(84, 28)
    Me.LabelControl4.TabIndex = 2
    Me.LabelControl4.Text = "Tamu"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl1.Location = New System.Drawing.Point(3, 2)
    Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(84, 28)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "No Reservasi "
    '
    'NoReservasiLbl
    '
    Me.NoReservasiLbl.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NoReservasiLbl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NoReservasiLbl.Location = New System.Drawing.Point(93, 2)
    Me.NoReservasiLbl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.NoReservasiLbl.Name = "NoReservasiLbl"
    Me.NoReservasiLbl.Size = New System.Drawing.Size(358, 28)
    Me.NoReservasiLbl.TabIndex = 1
    Me.NoReservasiLbl.Text = "0"
    '
    'TableLayoutPanel5
    '
    Me.TableLayoutPanel5.ColumnCount = 2
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel5.Controls.Add(Me.NamaMemberCombo, 0, 0)
    Me.TableLayoutPanel5.Controls.Add(Me.NamaTamuTxt, 1, 0)
    Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel5.Location = New System.Drawing.Point(93, 66)
    Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
    Me.TableLayoutPanel5.RowCount = 1
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel5.Size = New System.Drawing.Size(358, 28)
    Me.TableLayoutPanel5.TabIndex = 9
    '
    'NamaMemberCombo
    '
    Me.NamaMemberCombo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NamaMemberCombo.Enabled = False
    Me.NamaMemberCombo.Location = New System.Drawing.Point(3, 2)
    Me.NamaMemberCombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.NamaMemberCombo.Name = "NamaMemberCombo"
    Me.NamaMemberCombo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NamaMemberCombo.Properties.Appearance.Options.UseFont = True
    Me.NamaMemberCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.NamaMemberCombo.Size = New System.Drawing.Size(173, 22)
    Me.NamaMemberCombo.TabIndex = 0
    '
    'NamaTamuTxt
    '
    Me.NamaTamuTxt.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NamaTamuTxt.Location = New System.Drawing.Point(182, 2)
    Me.NamaTamuTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.NamaTamuTxt.Name = "NamaTamuTxt"
    Me.NamaTamuTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NamaTamuTxt.Properties.Appearance.Options.UseFont = True
    Me.NamaTamuTxt.Size = New System.Drawing.Size(173, 22)
    Me.NamaTamuTxt.TabIndex = 1
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl5.Location = New System.Drawing.Point(3, 66)
    Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(84, 28)
    Me.LabelControl5.TabIndex = 8
    Me.LabelControl5.Text = "Nama"
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl6.Location = New System.Drawing.Point(3, 98)
    Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(84, 28)
    Me.LabelControl6.TabIndex = 10
    Me.LabelControl6.Text = "Untuk Tanggal"
    '
    'UntukTanggalReservasi
    '
    Me.UntukTanggalReservasi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.UntukTanggalReservasi.EditValue = Nothing
    Me.UntukTanggalReservasi.Location = New System.Drawing.Point(93, 98)
    Me.UntukTanggalReservasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.UntukTanggalReservasi.Name = "UntukTanggalReservasi"
    Me.UntukTanggalReservasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UntukTanggalReservasi.Properties.Appearance.Options.UseFont = True
    Me.UntukTanggalReservasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.UntukTanggalReservasi.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.UntukTanggalReservasi.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
    Me.UntukTanggalReservasi.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
    Me.UntukTanggalReservasi.Size = New System.Drawing.Size(358, 22)
    Me.UntukTanggalReservasi.TabIndex = 11
    '
    'TamuChk
    '
    Me.TamuChk.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TamuChk.Location = New System.Drawing.Point(93, 34)
    Me.TamuChk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TamuChk.Name = "TamuChk"
    Me.TamuChk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TamuChk.Properties.Appearance.Options.UseFont = True
    Me.TamuChk.Properties.Caption = "Member"
    Me.TamuChk.Size = New System.Drawing.Size(358, 28)
    Me.TamuChk.TabIndex = 12
    '
    'CheckedListReservasi
    '
    Me.CheckedListReservasi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CheckedListReservasi.FormattingEnabled = True
    Me.CheckedListReservasi.Location = New System.Drawing.Point(3, 43)
    Me.CheckedListReservasi.Name = "CheckedListReservasi"
    Me.CheckedListReservasi.Size = New System.Drawing.Size(445, 132)
    Me.CheckedListReservasi.TabIndex = 8
    '
    'ReserveBtn
    '
    Me.ReserveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ReserveBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ReserveBtn.Appearance.Options.UseFont = True
    Me.ReserveBtn.Image = CType(resources.GetObject("ReserveBtn.Image"), System.Drawing.Image)
    Me.ReserveBtn.Location = New System.Drawing.Point(254, 3)
    Me.ReserveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.ReserveBtn.Name = "ReserveBtn"
    Me.ReserveBtn.Size = New System.Drawing.Size(98, 35)
    Me.ReserveBtn.TabIndex = 6
    Me.ReserveBtn.Text = "Reserve"
    '
    'CheckInBtn
    '
    Me.CheckInBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CheckInBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CheckInBtn.Appearance.Options.UseFont = True
    Me.CheckInBtn.Image = CType(resources.GetObject("CheckInBtn.Image"), System.Drawing.Image)
    Me.CheckInBtn.Location = New System.Drawing.Point(355, 3)
    Me.CheckInBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.CheckInBtn.Name = "CheckInBtn"
    Me.CheckInBtn.Size = New System.Drawing.Size(96, 35)
    Me.CheckInBtn.TabIndex = 7
    Me.CheckInBtn.Text = "Check In"
    '
    'FormReservasi
    '
    Me.Appearance.Options.UseFont = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(454, 483)
    Me.Controls.Add(Me.MainSplit)
    Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FormReservasi"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Reservasi"
    Me.MainSplit.Panel1.ResumeLayout(False)
    Me.MainSplit.Panel2.ResumeLayout(False)
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MainSplit.ResumeLayout(False)
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.XtraTabControl1.ResumeLayout(False)
    Me.TabPageBilliard.ResumeLayout(False)
    CType(Me.BilliardGrid, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPageResto.ResumeLayout(False)
    CType(Me.CheckListResto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabPageBar.ResumeLayout(False)
    CType(Me.CheckListBar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.TableLayoutPanel5.ResumeLayout(False)
    CType(Me.NamaMemberCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaTamuTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UntukTanggalReservasi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UntukTanggalReservasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TamuChk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents MainSplit As System.Windows.Forms.SplitContainer
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents TabPageBilliard As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents TabPageResto As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents CheckListResto As DevExpress.XtraEditors.CheckedListBoxControl
  Friend WithEvents TabPageBar As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents CheckListBar As DevExpress.XtraEditors.CheckedListBoxControl
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents NoReservasiLbl As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents NamaMemberCombo As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents NamaTamuTxt As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents UntukTanggalReservasi As DevExpress.XtraEditors.DateEdit
  Friend WithEvents TamuChk As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents ReserveBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents CheckInBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents CheckedListReservasi As System.Windows.Forms.CheckedListBox
  Friend WithEvents BilliardGrid As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
  Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
  Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
  Friend WithEvents colIDDaftarMeja As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIDJenisMeja As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNomorMeja As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colKeterangan As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colTanggalbook As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJamMulai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJamSelesai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModifiedBy As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
End Class
