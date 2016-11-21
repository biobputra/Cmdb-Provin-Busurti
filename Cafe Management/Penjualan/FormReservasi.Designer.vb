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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReservasi))
    Me.SimpanBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BatalBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.MainSplit = New System.Windows.Forms.SplitContainer()
    Me.NamaMemberCombo = New DevExpress.XtraEditors.LookUpEdit()
    Me.NamaTamuTxt = New DevExpress.XtraEditors.TextEdit()
    Me.UntukTanggalReservasi = New DevExpress.XtraEditors.DateEdit()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
    Me.TabPageBilliard = New DevExpress.XtraTab.XtraTabPage()
    Me.FlowBilliard = New System.Windows.Forms.FlowLayoutPanel()
    Me.TabPageResto = New DevExpress.XtraTab.XtraTabPage()
    Me.FlowResto = New System.Windows.Forms.FlowLayoutPanel()
    Me.TabPageBar = New DevExpress.XtraTab.XtraTabPage()
    Me.FlowBar = New System.Windows.Forms.FlowLayoutPanel()
    Me.NoReservasiLbl = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.TamuChk = New DevExpress.XtraEditors.CheckEdit()
    Me.ReserveSplit = New System.Windows.Forms.SplitContainer()
    Me.CheckedListReservasi = New System.Windows.Forms.CheckedListBox()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.ReservasiDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.ReservasiDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.ReservasiDataset = New Cafe_Management.ReservasiDataset()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.colIDReservasiH = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIDReservasiD = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colIDDaftarMeja = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colNamaMeja = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.colJamMulai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
    Me.colJamSelesai = New DevExpress.XtraGrid.Columns.GridColumn()
    Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
    Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
    Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
    Me.HomeBtn = New System.Windows.Forms.ToolStripButton()
    Me.DetailBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.ReserveBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.CheckInBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.ReservasiDTableAdapter = New Cafe_Management.ReservasiDatasetTableAdapters.ReservasiDTableAdapter()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainSplit.Panel1.SuspendLayout()
    Me.MainSplit.Panel2.SuspendLayout()
    Me.MainSplit.SuspendLayout()
    CType(Me.NamaMemberCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaTamuTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UntukTanggalReservasi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.UntukTanggalReservasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.XtraTabControl1.SuspendLayout()
    Me.TabPageBilliard.SuspendLayout()
    Me.TabPageResto.SuspendLayout()
    Me.TabPageBar.SuspendLayout()
    CType(Me.TamuChk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ReserveSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ReserveSplit.Panel1.SuspendLayout()
    Me.ReserveSplit.Panel2.SuspendLayout()
    Me.ReserveSplit.SuspendLayout()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ReservasiDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ReservasiDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ReservasiDataset, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.BindingNavigator1.SuspendLayout()
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
    Me.MainSplit.Panel1.Controls.Add(Me.NamaMemberCombo)
    Me.MainSplit.Panel1.Controls.Add(Me.NamaTamuTxt)
    Me.MainSplit.Panel1.Controls.Add(Me.UntukTanggalReservasi)
    Me.MainSplit.Panel1.Controls.Add(Me.LabelControl6)
    Me.MainSplit.Panel1.Controls.Add(Me.LabelControl4)
    Me.MainSplit.Panel1.Controls.Add(Me.LabelControl5)
    Me.MainSplit.Panel1.Controls.Add(Me.XtraTabControl1)
    Me.MainSplit.Panel1.Controls.Add(Me.NoReservasiLbl)
    Me.MainSplit.Panel1.Controls.Add(Me.LabelControl1)
    Me.MainSplit.Panel1.Controls.Add(Me.TamuChk)
    Me.MainSplit.Panel1.Controls.Add(Me.SimpanBtn)
    Me.MainSplit.Panel1.Controls.Add(Me.BatalBtn)
    '
    'MainSplit.Panel2
    '
    Me.MainSplit.Panel2.Controls.Add(Me.ReserveSplit)
    Me.MainSplit.Panel2.Controls.Add(Me.DetailBtn)
    Me.MainSplit.Panel2.Controls.Add(Me.ReserveBtn)
    Me.MainSplit.Panel2.Controls.Add(Me.CheckInBtn)
    Me.MainSplit.Size = New System.Drawing.Size(454, 483)
    Me.MainSplit.SplitterDistance = 292
    Me.MainSplit.SplitterWidth = 3
    Me.MainSplit.TabIndex = 10
    '
    'NamaMemberCombo
    '
    Me.NamaMemberCombo.EditValue = ""
    Me.NamaMemberCombo.Enabled = False
    Me.NamaMemberCombo.Location = New System.Drawing.Point(107, 60)
    Me.NamaMemberCombo.Name = "NamaMemberCombo"
    Me.NamaMemberCombo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NamaMemberCombo.Properties.Appearance.Options.UseFont = True
    Me.NamaMemberCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.NamaMemberCombo.Size = New System.Drawing.Size(155, 22)
    Me.NamaMemberCombo.TabIndex = 13
    '
    'NamaTamuTxt
    '
    Me.NamaTamuTxt.Location = New System.Drawing.Point(268, 58)
    Me.NamaTamuTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.NamaTamuTxt.Name = "NamaTamuTxt"
    Me.NamaTamuTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NamaTamuTxt.Properties.Appearance.Options.UseFont = True
    Me.NamaTamuTxt.Size = New System.Drawing.Size(174, 22)
    Me.NamaTamuTxt.TabIndex = 1
    '
    'UntukTanggalReservasi
    '
    Me.UntukTanggalReservasi.EditValue = Nothing
    Me.UntukTanggalReservasi.Location = New System.Drawing.Point(107, 84)
    Me.UntukTanggalReservasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.UntukTanggalReservasi.Name = "UntukTanggalReservasi"
    Me.UntukTanggalReservasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UntukTanggalReservasi.Properties.Appearance.Options.UseFont = True
    Me.UntukTanggalReservasi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.UntukTanggalReservasi.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.UntukTanggalReservasi.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI
    Me.UntukTanggalReservasi.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
    Me.UntukTanggalReservasi.Size = New System.Drawing.Size(335, 22)
    Me.UntukTanggalReservasi.TabIndex = 11
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl6.Location = New System.Drawing.Point(12, 86)
    Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(84, 17)
    Me.LabelControl6.TabIndex = 10
    Me.LabelControl6.Text = "Untuk Tanggal"
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl4.Location = New System.Drawing.Point(12, 35)
    Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(32, 17)
    Me.LabelControl4.TabIndex = 2
    Me.LabelControl4.Text = "Tamu"
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl5.Location = New System.Drawing.Point(12, 60)
    Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(35, 17)
    Me.LabelControl5.TabIndex = 8
    Me.LabelControl5.Text = "Nama"
    '
    'XtraTabControl1
    '
    Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XtraTabControl1.Appearance.Options.UseFont = True
    Me.XtraTabControl1.Location = New System.Drawing.Point(3, 110)
    Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.XtraTabControl1.Name = "XtraTabControl1"
    Me.XtraTabControl1.SelectedTabPage = Me.TabPageBilliard
    Me.XtraTabControl1.Size = New System.Drawing.Size(451, 144)
    Me.XtraTabControl1.TabIndex = 10
    Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabPageBilliard, Me.TabPageResto, Me.TabPageBar})
    '
    'TabPageBilliard
    '
    Me.TabPageBilliard.AllowTouchScroll = True
    Me.TabPageBilliard.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPageBilliard.Appearance.Header.Options.UseFont = True
    Me.TabPageBilliard.AutoScroll = True
    Me.TabPageBilliard.Controls.Add(Me.FlowBilliard)
    Me.TabPageBilliard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TabPageBilliard.Name = "TabPageBilliard"
    Me.TabPageBilliard.Size = New System.Drawing.Size(445, 110)
    Me.TabPageBilliard.Text = "Billiard"
    '
    'FlowBilliard
    '
    Me.FlowBilliard.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowBilliard.Location = New System.Drawing.Point(0, 0)
    Me.FlowBilliard.Name = "FlowBilliard"
    Me.FlowBilliard.Size = New System.Drawing.Size(445, 110)
    Me.FlowBilliard.TabIndex = 0
    '
    'TabPageResto
    '
    Me.TabPageResto.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPageResto.Appearance.Header.Options.UseFont = True
    Me.TabPageResto.Controls.Add(Me.FlowResto)
    Me.TabPageResto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TabPageResto.Name = "TabPageResto"
    Me.TabPageResto.Size = New System.Drawing.Size(445, 110)
    Me.TabPageResto.Text = "Resto"
    '
    'FlowResto
    '
    Me.FlowResto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowResto.Location = New System.Drawing.Point(0, 0)
    Me.FlowResto.Name = "FlowResto"
    Me.FlowResto.Size = New System.Drawing.Size(445, 110)
    Me.FlowResto.TabIndex = 1
    '
    'TabPageBar
    '
    Me.TabPageBar.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TabPageBar.Appearance.Header.Options.UseFont = True
    Me.TabPageBar.Controls.Add(Me.FlowBar)
    Me.TabPageBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TabPageBar.Name = "TabPageBar"
    Me.TabPageBar.Size = New System.Drawing.Size(445, 110)
    Me.TabPageBar.Text = "Bar"
    '
    'FlowBar
    '
    Me.FlowBar.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowBar.Location = New System.Drawing.Point(0, 0)
    Me.FlowBar.Name = "FlowBar"
    Me.FlowBar.Size = New System.Drawing.Size(445, 110)
    Me.FlowBar.TabIndex = 1
    '
    'NoReservasiLbl
    '
    Me.NoReservasiLbl.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NoReservasiLbl.Location = New System.Drawing.Point(107, 11)
    Me.NoReservasiLbl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.NoReservasiLbl.Name = "NoReservasiLbl"
    Me.NoReservasiLbl.Size = New System.Drawing.Size(7, 17)
    Me.NoReservasiLbl.TabIndex = 1
    Me.NoReservasiLbl.Text = "0"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Location = New System.Drawing.Point(12, 11)
    Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(81, 17)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "No Reservasi "
    '
    'TamuChk
    '
    Me.TamuChk.Location = New System.Drawing.Point(107, 34)
    Me.TamuChk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.TamuChk.Name = "TamuChk"
    Me.TamuChk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TamuChk.Properties.Appearance.Options.UseFont = True
    Me.TamuChk.Properties.Caption = "Member"
    Me.TamuChk.Size = New System.Drawing.Size(155, 20)
    Me.TamuChk.TabIndex = 12
    '
    'ReserveSplit
    '
    Me.ReserveSplit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ReserveSplit.Location = New System.Drawing.Point(0, 42)
    Me.ReserveSplit.Name = "ReserveSplit"
    Me.ReserveSplit.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'ReserveSplit.Panel1
    '
    Me.ReserveSplit.Panel1.Controls.Add(Me.CheckedListReservasi)
    '
    'ReserveSplit.Panel2
    '
    Me.ReserveSplit.Panel2.Controls.Add(Me.GridControl1)
    Me.ReserveSplit.Panel2.Controls.Add(Me.BindingNavigator1)
    Me.ReserveSplit.Size = New System.Drawing.Size(454, 152)
    Me.ReserveSplit.SplitterDistance = 73
    Me.ReserveSplit.TabIndex = 10
    '
    'CheckedListReservasi
    '
    Me.CheckedListReservasi.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckedListReservasi.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CheckedListReservasi.FormattingEnabled = True
    Me.CheckedListReservasi.Location = New System.Drawing.Point(0, 0)
    Me.CheckedListReservasi.Name = "CheckedListReservasi"
    Me.CheckedListReservasi.Size = New System.Drawing.Size(454, 73)
    Me.CheckedListReservasi.TabIndex = 9
    '
    'GridControl1
    '
    Me.GridControl1.DataSource = Me.ReservasiDBindingSource
    Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GridControl1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridControl1.Location = New System.Drawing.Point(0, 25)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1, Me.RepositoryItemTimeEdit2})
    Me.GridControl1.Size = New System.Drawing.Size(454, 50)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'ReservasiDBindingSource
    '
    Me.ReservasiDBindingSource.DataMember = "ReservasiD"
    Me.ReservasiDBindingSource.DataSource = Me.ReservasiDatasetBindingSource
    '
    'ReservasiDatasetBindingSource
    '
    Me.ReservasiDatasetBindingSource.DataSource = Me.ReservasiDataset
    Me.ReservasiDatasetBindingSource.Position = 0
    '
    'ReservasiDataset
    '
    Me.ReservasiDataset.DataSetName = "ReservasiDataset"
    Me.ReservasiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'GridView1
    '
    Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GridView1.Appearance.Row.Options.UseFont = True
    Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDReservasiH, Me.colIDReservasiD, Me.colIDDaftarMeja, Me.colNamaMeja, Me.colJamMulai, Me.colJamSelesai})
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    Me.GridView1.OptionsView.ShowGroupPanel = False
    '
    'colIDReservasiH
    '
    Me.colIDReservasiH.FieldName = "IDReservasiH"
    Me.colIDReservasiH.Name = "colIDReservasiH"
    '
    'colIDReservasiD
    '
    Me.colIDReservasiD.FieldName = "IDReservasiD"
    Me.colIDReservasiD.Name = "colIDReservasiD"
    '
    'colIDDaftarMeja
    '
    Me.colIDDaftarMeja.FieldName = "IDDaftarMeja"
    Me.colIDDaftarMeja.Name = "colIDDaftarMeja"
    '
    'colNamaMeja
    '
    Me.colNamaMeja.Caption = "Nama Meja"
    Me.colNamaMeja.FieldName = "NamaMeja"
    Me.colNamaMeja.Name = "colNamaMeja"
    Me.colNamaMeja.OptionsColumn.ReadOnly = True
    Me.colNamaMeja.Visible = True
    Me.colNamaMeja.VisibleIndex = 0
    '
    'colJamMulai
    '
    Me.colJamMulai.Caption = "Jam Mulai"
    Me.colJamMulai.ColumnEdit = Me.RepositoryItemTimeEdit1
    Me.colJamMulai.FieldName = "JamMulai"
    Me.colJamMulai.Name = "colJamMulai"
    Me.colJamMulai.Visible = True
    Me.colJamMulai.VisibleIndex = 1
    '
    'RepositoryItemTimeEdit1
    '
    Me.RepositoryItemTimeEdit1.AutoHeight = False
    Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
    Me.RepositoryItemTimeEdit1.Mask.EditMask = "HH:mm"
    Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
    '
    'colJamSelesai
    '
    Me.colJamSelesai.Caption = "Jam Selesai"
    Me.colJamSelesai.ColumnEdit = Me.RepositoryItemTimeEdit2
    Me.colJamSelesai.FieldName = "JamSelesai"
    Me.colJamSelesai.Name = "colJamSelesai"
    Me.colJamSelesai.Visible = True
    Me.colJamSelesai.VisibleIndex = 2
    '
    'RepositoryItemTimeEdit2
    '
    Me.RepositoryItemTimeEdit2.AutoHeight = False
    Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
    Me.RepositoryItemTimeEdit2.Mask.EditMask = "HH:mm"
    Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
    '
    'BindingNavigator1
    '
    Me.BindingNavigator1.AddNewItem = Nothing
    Me.BindingNavigator1.BindingSource = Me.ReservasiDBindingSource
    Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
    Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.SaveToolStripButton, Me.HomeBtn})
    Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
    Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.BindingNavigator1.Name = "BindingNavigator1"
    Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
    Me.BindingNavigator1.Size = New System.Drawing.Size(454, 25)
    Me.BindingNavigator1.TabIndex = 1
    Me.BindingNavigator1.Text = "BindingNavigator1"
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
    'SaveToolStripButton
    '
    Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
    Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.SaveToolStripButton.Name = "SaveToolStripButton"
    Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
    Me.SaveToolStripButton.Text = "&Save"
    '
    'HomeBtn
    '
    Me.HomeBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
    Me.HomeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.HomeBtn.Image = Global.Cafe_Management.My.Resources.Resources.CheckBox_32x32
    Me.HomeBtn.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.HomeBtn.Name = "HomeBtn"
    Me.HomeBtn.Size = New System.Drawing.Size(23, 22)
    Me.HomeBtn.Text = "ToolStripButton1"
    '
    'DetailBtn
    '
    Me.DetailBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.DetailBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.DetailBtn.Appearance.Options.UseFont = True
    Me.DetailBtn.Image = CType(resources.GetObject("DetailBtn.Image"), System.Drawing.Image)
    Me.DetailBtn.Location = New System.Drawing.Point(353, 3)
    Me.DetailBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.DetailBtn.Name = "DetailBtn"
    Me.DetailBtn.Size = New System.Drawing.Size(98, 35)
    Me.DetailBtn.TabIndex = 9
    Me.DetailBtn.Text = "Detail"
    '
    'ReserveBtn
    '
    Me.ReserveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ReserveBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ReserveBtn.Appearance.Options.UseFont = True
    Me.ReserveBtn.Image = CType(resources.GetObject("ReserveBtn.Image"), System.Drawing.Image)
    Me.ReserveBtn.Location = New System.Drawing.Point(149, 2)
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
    Me.CheckInBtn.Location = New System.Drawing.Point(253, 3)
    Me.CheckInBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
    Me.CheckInBtn.Name = "CheckInBtn"
    Me.CheckInBtn.Size = New System.Drawing.Size(96, 35)
    Me.CheckInBtn.TabIndex = 7
    Me.CheckInBtn.Text = "Check In"
    '
    'ReservasiDTableAdapter
    '
    Me.ReservasiDTableAdapter.ClearBeforeFill = True
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
    Me.MainSplit.Panel1.PerformLayout()
    Me.MainSplit.Panel2.ResumeLayout(False)
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MainSplit.ResumeLayout(False)
    CType(Me.NamaMemberCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaTamuTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UntukTanggalReservasi.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.UntukTanggalReservasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.XtraTabControl1.ResumeLayout(False)
    Me.TabPageBilliard.ResumeLayout(False)
    Me.TabPageResto.ResumeLayout(False)
    Me.TabPageBar.ResumeLayout(False)
    CType(Me.TamuChk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ReserveSplit.Panel1.ResumeLayout(False)
    Me.ReserveSplit.Panel2.ResumeLayout(False)
    Me.ReserveSplit.Panel2.PerformLayout()
    CType(Me.ReserveSplit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ReserveSplit.ResumeLayout(False)
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ReservasiDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ReservasiDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ReservasiDataset, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.BindingNavigator1.ResumeLayout(False)
    Me.BindingNavigator1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents SimpanBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents BatalBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents MainSplit As System.Windows.Forms.SplitContainer
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents TabPageBilliard As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents TabPageResto As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents TabPageBar As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents NoReservasiLbl As DevExpress.XtraEditors.LabelControl
  Friend WithEvents NamaTamuTxt As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents UntukTanggalReservasi As DevExpress.XtraEditors.DateEdit
  Friend WithEvents TamuChk As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents ReserveBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents CheckInBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents FlowBilliard As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents FlowResto As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents FlowBar As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents NamaMemberCombo As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents DetailBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents ReserveSplit As System.Windows.Forms.SplitContainer
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents ReservasiDatasetBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents ReservasiDataset As Cafe_Management.ReservasiDataset
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents ReservasiDBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents ReservasiDTableAdapter As Cafe_Management.ReservasiDatasetTableAdapters.ReservasiDTableAdapter
  Friend WithEvents colIDReservasiH As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIDReservasiD As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colIDDaftarMeja As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colNamaMeja As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJamMulai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents colJamSelesai As DevExpress.XtraGrid.Columns.GridColumn
  Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
  Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
  Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
  Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents CheckedListReservasi As System.Windows.Forms.CheckedListBox
  Friend WithEvents HomeBtn As System.Windows.Forms.ToolStripButton
End Class
