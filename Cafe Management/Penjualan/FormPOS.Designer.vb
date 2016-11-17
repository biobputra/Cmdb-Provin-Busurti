<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPOS
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPOS))
    Me.MainSplit = New DevExpress.XtraEditors.SplitContainerControl()
    Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
    Me.BillyardTablePage = New DevExpress.XtraTab.XtraTabPage()
    Me.TopLayout = New System.Windows.Forms.TableLayoutPanel()
    Me.BillyardCheckInBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BillyardReserveBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BillyardExtendBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.RestoTablePage = New DevExpress.XtraTab.XtraTabPage()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.RestoCheckInBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.RestoReserveBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BarTablePage = New DevExpress.XtraTab.XtraTabPage()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.BarCheckInBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BarReserveBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.BarTabsPage = New DevExpress.XtraTab.XtraTabPage()
    Me.MenuPage = New DevExpress.XtraTab.XtraTabPage()
    Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
    Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainSplit.SuspendLayout()
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.XtraTabControl1.SuspendLayout()
    Me.BillyardTablePage.SuspendLayout()
    Me.TopLayout.SuspendLayout()
    Me.RestoTablePage.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.BarTablePage.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'MainSplit
    '
    Me.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MainSplit.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
    Me.MainSplit.Location = New System.Drawing.Point(0, 0)
    Me.MainSplit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.MainSplit.Name = "MainSplit"
    Me.MainSplit.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
    Me.MainSplit.Panel1.Controls.Add(Me.XtraTabControl1)
    Me.MainSplit.Panel1.Text = "Panel1"
    Me.MainSplit.Panel2.Controls.Add(Me.SplitContainerControl1)
    Me.MainSplit.Panel2.Text = "Panel2"
    Me.MainSplit.Size = New System.Drawing.Size(1177, 487)
    Me.MainSplit.SplitterPosition = 388
    Me.MainSplit.TabIndex = 0
    Me.MainSplit.Text = "SplitContainerControl1"
    '
    'XtraTabControl1
    '
    Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
    Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
    Me.XtraTabControl1.Name = "XtraTabControl1"
    Me.XtraTabControl1.SelectedTabPage = Me.BillyardTablePage
    Me.XtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
    Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
    Me.XtraTabControl1.Size = New System.Drawing.Size(780, 483)
    Me.XtraTabControl1.TabIndex = 9
    Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.BillyardTablePage, Me.RestoTablePage, Me.BarTablePage, Me.BarTabsPage, Me.MenuPage})
    '
    'BillyardTablePage
    '
    Me.BillyardTablePage.Appearance.PageClient.Image = CType(resources.GetObject("BillyardTablePage.Appearance.PageClient.Image"), System.Drawing.Image)
    Me.BillyardTablePage.Appearance.PageClient.Options.UseImage = True
    Me.BillyardTablePage.AutoScroll = True
    Me.BillyardTablePage.Controls.Add(Me.TopLayout)
    Me.BillyardTablePage.Image = CType(resources.GetObject("BillyardTablePage.Image"), System.Drawing.Image)
    Me.BillyardTablePage.Name = "BillyardTablePage"
    Me.BillyardTablePage.Size = New System.Drawing.Size(774, 436)
    Me.BillyardTablePage.Text = "Meja Billyard"
    '
    'TopLayout
    '
    Me.TopLayout.ColumnCount = 4
    Me.TopLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TopLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TopLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TopLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TopLayout.Controls.Add(Me.BillyardCheckInBtn, 2, 0)
    Me.TopLayout.Controls.Add(Me.BillyardReserveBtn, 1, 0)
    Me.TopLayout.Controls.Add(Me.BillyardExtendBtn, 3, 0)
    Me.TopLayout.Dock = System.Windows.Forms.DockStyle.Top
    Me.TopLayout.Location = New System.Drawing.Point(0, 0)
    Me.TopLayout.Name = "TopLayout"
    Me.TopLayout.RowCount = 1
    Me.TopLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TopLayout.Size = New System.Drawing.Size(774, 54)
    Me.TopLayout.TabIndex = 9
    '
    'BillyardCheckInBtn
    '
    Me.BillyardCheckInBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BillyardCheckInBtn.Appearance.Options.UseFont = True
    Me.BillyardCheckInBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BillyardCheckInBtn.Image = CType(resources.GetObject("BillyardCheckInBtn.Image"), System.Drawing.Image)
    Me.BillyardCheckInBtn.Location = New System.Drawing.Point(557, 3)
    Me.BillyardCheckInBtn.Name = "BillyardCheckInBtn"
    Me.BillyardCheckInBtn.Size = New System.Drawing.Size(104, 48)
    Me.BillyardCheckInBtn.TabIndex = 5
    Me.BillyardCheckInBtn.Text = "Check In"
    '
    'BillyardReserveBtn
    '
    Me.BillyardReserveBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BillyardReserveBtn.Appearance.Options.UseFont = True
    Me.BillyardReserveBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BillyardReserveBtn.Image = CType(resources.GetObject("BillyardReserveBtn.Image"), System.Drawing.Image)
    Me.BillyardReserveBtn.Location = New System.Drawing.Point(447, 3)
    Me.BillyardReserveBtn.Name = "BillyardReserveBtn"
    Me.BillyardReserveBtn.Size = New System.Drawing.Size(104, 48)
    Me.BillyardReserveBtn.TabIndex = 3
    Me.BillyardReserveBtn.Text = "Reserve"
    '
    'BillyardExtendBtn
    '
    Me.BillyardExtendBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BillyardExtendBtn.Appearance.Options.UseFont = True
    Me.BillyardExtendBtn.Image = CType(resources.GetObject("BillyardExtendBtn.Image"), System.Drawing.Image)
    Me.BillyardExtendBtn.Location = New System.Drawing.Point(667, 3)
    Me.BillyardExtendBtn.Name = "BillyardExtendBtn"
    Me.BillyardExtendBtn.Size = New System.Drawing.Size(104, 48)
    Me.BillyardExtendBtn.TabIndex = 6
    Me.BillyardExtendBtn.Text = "Extend"
    '
    'RestoTablePage
    '
    Me.RestoTablePage.Controls.Add(Me.TableLayoutPanel1)
    Me.RestoTablePage.Image = CType(resources.GetObject("RestoTablePage.Image"), System.Drawing.Image)
    Me.RestoTablePage.Name = "RestoTablePage"
    Me.RestoTablePage.Size = New System.Drawing.Size(774, 436)
    Me.RestoTablePage.Text = "Meja Resto"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.RestoCheckInBtn, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.RestoReserveBtn, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(774, 54)
    Me.TableLayoutPanel1.TabIndex = 10
    '
    'RestoCheckInBtn
    '
    Me.RestoCheckInBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.RestoCheckInBtn.Appearance.Options.UseFont = True
    Me.RestoCheckInBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.RestoCheckInBtn.Image = CType(resources.GetObject("RestoCheckInBtn.Image"), System.Drawing.Image)
    Me.RestoCheckInBtn.Location = New System.Drawing.Point(667, 3)
    Me.RestoCheckInBtn.Name = "RestoCheckInBtn"
    Me.RestoCheckInBtn.Size = New System.Drawing.Size(104, 48)
    Me.RestoCheckInBtn.TabIndex = 5
    Me.RestoCheckInBtn.Text = "Check In"
    '
    'RestoReserveBtn
    '
    Me.RestoReserveBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.RestoReserveBtn.Appearance.Options.UseFont = True
    Me.RestoReserveBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.RestoReserveBtn.Image = CType(resources.GetObject("RestoReserveBtn.Image"), System.Drawing.Image)
    Me.RestoReserveBtn.Location = New System.Drawing.Point(557, 3)
    Me.RestoReserveBtn.Name = "RestoReserveBtn"
    Me.RestoReserveBtn.Size = New System.Drawing.Size(104, 48)
    Me.RestoReserveBtn.TabIndex = 3
    Me.RestoReserveBtn.Text = "Reserve"
    '
    'BarTablePage
    '
    Me.BarTablePage.Controls.Add(Me.TableLayoutPanel2)
    Me.BarTablePage.Image = CType(resources.GetObject("BarTablePage.Image"), System.Drawing.Image)
    Me.BarTablePage.Name = "BarTablePage"
    Me.BarTablePage.Size = New System.Drawing.Size(774, 436)
    Me.BarTablePage.Text = "Meja Bar"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 3
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.BarCheckInBtn, 2, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.BarReserveBtn, 1, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(774, 54)
    Me.TableLayoutPanel2.TabIndex = 11
    '
    'BarCheckInBtn
    '
    Me.BarCheckInBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BarCheckInBtn.Appearance.Options.UseFont = True
    Me.BarCheckInBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BarCheckInBtn.Image = CType(resources.GetObject("BarCheckInBtn.Image"), System.Drawing.Image)
    Me.BarCheckInBtn.Location = New System.Drawing.Point(667, 3)
    Me.BarCheckInBtn.Name = "BarCheckInBtn"
    Me.BarCheckInBtn.Size = New System.Drawing.Size(104, 48)
    Me.BarCheckInBtn.TabIndex = 5
    Me.BarCheckInBtn.Text = "Check In"
    '
    'BarReserveBtn
    '
    Me.BarReserveBtn.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.BarReserveBtn.Appearance.Options.UseFont = True
    Me.BarReserveBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BarReserveBtn.Image = CType(resources.GetObject("BarReserveBtn.Image"), System.Drawing.Image)
    Me.BarReserveBtn.Location = New System.Drawing.Point(557, 3)
    Me.BarReserveBtn.Name = "BarReserveBtn"
    Me.BarReserveBtn.Size = New System.Drawing.Size(104, 48)
    Me.BarReserveBtn.TabIndex = 3
    Me.BarReserveBtn.Text = "Reserve"
    '
    'BarTabsPage
    '
    Me.BarTabsPage.Image = CType(resources.GetObject("BarTabsPage.Image"), System.Drawing.Image)
    Me.BarTabsPage.Name = "BarTabsPage"
    Me.BarTabsPage.Size = New System.Drawing.Size(774, 436)
    Me.BarTabsPage.Text = "Bar tabs"
    '
    'MenuPage
    '
    Me.MenuPage.Image = CType(resources.GetObject("MenuPage.Image"), System.Drawing.Image)
    Me.MenuPage.Name = "MenuPage"
    Me.MenuPage.Size = New System.Drawing.Size(774, 436)
    Me.MenuPage.Text = "Menu"
    '
    'SplitContainerControl1
    '
    Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
    Me.SplitContainerControl1.Horizontal = False
    Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainerControl1.Name = "SplitContainerControl1"
    Me.SplitContainerControl1.Panel1.Text = "Panel1"
    Me.SplitContainerControl1.Panel2.Controls.Add(Me.TableLayoutPanel3)
    Me.SplitContainerControl1.Panel2.Text = "Panel2"
    Me.SplitContainerControl1.Size = New System.Drawing.Size(388, 487)
    Me.SplitContainerControl1.SplitterPosition = 204
    Me.SplitContainerControl1.TabIndex = 1
    Me.SplitContainerControl1.Text = "SplitContainerControl1"
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 4
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton15, 3, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton14, 3, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton13, 3, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton3, 2, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton2, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton1, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton4, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton5, 1, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton6, 2, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton7, 0, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton8, 1, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton9, 2, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton10, 0, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton11, 1, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.SimpleButton12, 2, 3)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 4
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(388, 204)
    Me.TableLayoutPanel3.TabIndex = 0
    '
    'SimpleButton15
    '
    Me.SimpleButton15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton15.Appearance.Options.UseFont = True
    Me.SimpleButton15.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton15.Image = CType(resources.GetObject("SimpleButton15.Image"), System.Drawing.Image)
    Me.SimpleButton15.Location = New System.Drawing.Point(294, 105)
    Me.SimpleButton15.Name = "SimpleButton15"
    Me.SimpleButton15.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton15.TabIndex = 14
    Me.SimpleButton15.Text = "Bayar"
    '
    'SimpleButton14
    '
    Me.SimpleButton14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton14.Appearance.Options.UseFont = True
    Me.SimpleButton14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton14.Image = CType(resources.GetObject("SimpleButton14.Image"), System.Drawing.Image)
    Me.SimpleButton14.Location = New System.Drawing.Point(294, 54)
    Me.SimpleButton14.Name = "SimpleButton14"
    Me.SimpleButton14.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton14.TabIndex = 13
    Me.SimpleButton14.Text = "Del"
    '
    'SimpleButton13
    '
    Me.SimpleButton13.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton13.Appearance.Options.UseFont = True
    Me.SimpleButton13.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton13.Location = New System.Drawing.Point(294, 3)
    Me.SimpleButton13.Name = "SimpleButton13"
    Me.SimpleButton13.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton13.TabIndex = 12
    Me.SimpleButton13.Text = "*"
    '
    'SimpleButton3
    '
    Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton3.Appearance.Options.UseFont = True
    Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton3.Location = New System.Drawing.Point(197, 3)
    Me.SimpleButton3.Name = "SimpleButton3"
    Me.SimpleButton3.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton3.TabIndex = 2
    Me.SimpleButton3.Text = "3"
    '
    'SimpleButton2
    '
    Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton2.Appearance.Options.UseFont = True
    Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton2.Location = New System.Drawing.Point(100, 3)
    Me.SimpleButton2.Name = "SimpleButton2"
    Me.SimpleButton2.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton2.TabIndex = 1
    Me.SimpleButton2.Text = "2"
    '
    'SimpleButton1
    '
    Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton1.Appearance.Options.UseFont = True
    Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton1.Location = New System.Drawing.Point(3, 3)
    Me.SimpleButton1.Name = "SimpleButton1"
    Me.SimpleButton1.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton1.TabIndex = 0
    Me.SimpleButton1.Text = "1"
    '
    'SimpleButton4
    '
    Me.SimpleButton4.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton4.Appearance.Options.UseFont = True
    Me.SimpleButton4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton4.Location = New System.Drawing.Point(3, 54)
    Me.SimpleButton4.Name = "SimpleButton4"
    Me.SimpleButton4.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton4.TabIndex = 3
    Me.SimpleButton4.Text = "4"
    '
    'SimpleButton5
    '
    Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton5.Appearance.Options.UseFont = True
    Me.SimpleButton5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton5.Location = New System.Drawing.Point(100, 54)
    Me.SimpleButton5.Name = "SimpleButton5"
    Me.SimpleButton5.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton5.TabIndex = 4
    Me.SimpleButton5.Text = "5"
    '
    'SimpleButton6
    '
    Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton6.Appearance.Options.UseFont = True
    Me.SimpleButton6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton6.Location = New System.Drawing.Point(197, 54)
    Me.SimpleButton6.Name = "SimpleButton6"
    Me.SimpleButton6.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton6.TabIndex = 5
    Me.SimpleButton6.Text = "6"
    '
    'SimpleButton7
    '
    Me.SimpleButton7.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton7.Appearance.Options.UseFont = True
    Me.SimpleButton7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton7.Location = New System.Drawing.Point(3, 105)
    Me.SimpleButton7.Name = "SimpleButton7"
    Me.SimpleButton7.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton7.TabIndex = 6
    Me.SimpleButton7.Text = "7"
    '
    'SimpleButton8
    '
    Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton8.Appearance.Options.UseFont = True
    Me.SimpleButton8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton8.Location = New System.Drawing.Point(100, 105)
    Me.SimpleButton8.Name = "SimpleButton8"
    Me.SimpleButton8.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton8.TabIndex = 7
    Me.SimpleButton8.Text = "8"
    '
    'SimpleButton9
    '
    Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton9.Appearance.Options.UseFont = True
    Me.SimpleButton9.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton9.Location = New System.Drawing.Point(197, 105)
    Me.SimpleButton9.Name = "SimpleButton9"
    Me.SimpleButton9.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton9.TabIndex = 8
    Me.SimpleButton9.Text = "9"
    '
    'SimpleButton10
    '
    Me.SimpleButton10.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton10.Appearance.Options.UseFont = True
    Me.SimpleButton10.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton10.Location = New System.Drawing.Point(3, 156)
    Me.SimpleButton10.Name = "SimpleButton10"
    Me.SimpleButton10.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton10.TabIndex = 9
    Me.SimpleButton10.Text = "0"
    '
    'SimpleButton11
    '
    Me.SimpleButton11.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton11.Appearance.Options.UseFont = True
    Me.SimpleButton11.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton11.Location = New System.Drawing.Point(100, 156)
    Me.SimpleButton11.Name = "SimpleButton11"
    Me.SimpleButton11.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton11.TabIndex = 10
    Me.SimpleButton11.Text = "00"
    '
    'SimpleButton12
    '
    Me.SimpleButton12.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton12.Appearance.Options.UseFont = True
    Me.SimpleButton12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton12.Location = New System.Drawing.Point(197, 156)
    Me.SimpleButton12.Name = "SimpleButton12"
    Me.SimpleButton12.Size = New System.Drawing.Size(91, 45)
    Me.SimpleButton12.TabIndex = 11
    Me.SimpleButton12.Text = "000"
    '
    'FormPOS
    '
    Me.Appearance.Options.UseFont = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1177, 487)
    Me.Controls.Add(Me.MainSplit)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "FormPOS"
    Me.Text = "Point Of Sales"
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MainSplit.ResumeLayout(False)
    CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.XtraTabControl1.ResumeLayout(False)
    Me.BillyardTablePage.ResumeLayout(False)
    Me.TopLayout.ResumeLayout(False)
    Me.RestoTablePage.ResumeLayout(False)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.BarTablePage.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents MainSplit As DevExpress.XtraEditors.SplitContainerControl
  Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents BillyardTablePage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents RestoTablePage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents TopLayout As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents BillyardCheckInBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents BillyardReserveBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents BarTablePage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents BillyardExtendBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents RestoCheckInBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents RestoReserveBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents BarCheckInBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents BarReserveBtn As DevExpress.XtraEditors.SimpleButton


  Friend WithEvents BarTabsPage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents MenuPage As DevExpress.XtraTab.XtraTabPage




End Class
