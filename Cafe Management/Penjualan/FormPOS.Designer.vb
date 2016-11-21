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
    Me.MainTab = New DevExpress.XtraTab.XtraTabControl()
    Me.BilliardTablePage = New DevExpress.XtraTab.XtraTabPage()
    Me.BillyardFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
    Me.RestoTablePage = New DevExpress.XtraTab.XtraTabPage()
    Me.RestoFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
    Me.BarTablePage = New DevExpress.XtraTab.XtraTabPage()
    Me.BarFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
    Me.BarTabsPage = New DevExpress.XtraTab.XtraTabPage()
    Me.MenuPage = New DevExpress.XtraTab.XtraTabPage()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.DaftarReservasiBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.StatusMejaBtn = New DevExpress.XtraEditors.SimpleButton()
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
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
    Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
    Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
    Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainSplit.SuspendLayout()
    CType(Me.MainTab, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainTab.SuspendLayout()
    Me.BilliardTablePage.SuspendLayout()
    Me.RestoTablePage.SuspendLayout()
    Me.BarTablePage.SuspendLayout()
    Me.MenuPage.SuspendLayout()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel4.SuspendLayout()
    Me.TableLayoutPanel5.SuspendLayout()
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
    Me.MainSplit.Panel1.Controls.Add(Me.MainTab)
    Me.MainSplit.Panel1.Controls.Add(Me.TableLayoutPanel1)
    Me.MainSplit.Panel1.Text = "Panel1"
    Me.MainSplit.Panel2.Controls.Add(Me.SplitContainerControl1)
    Me.MainSplit.Panel2.Text = "Panel2"
    Me.MainSplit.Size = New System.Drawing.Size(976, 414)
    Me.MainSplit.SplitterPosition = 348
    Me.MainSplit.TabIndex = 0
    Me.MainSplit.Text = "SplitContainerControl1"
    '
    'MainTab
    '
    Me.MainTab.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.MainTab.AppearancePage.Header.Options.UseFont = True
    Me.MainTab.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MainTab.Location = New System.Drawing.Point(0, 41)
    Me.MainTab.Name = "MainTab"
    Me.MainTab.SelectedTabPage = Me.BilliardTablePage
    Me.MainTab.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[True]
    Me.MainTab.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
    Me.MainTab.Size = New System.Drawing.Size(619, 369)
    Me.MainTab.TabIndex = 9
    Me.MainTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.BilliardTablePage, Me.RestoTablePage, Me.BarTablePage, Me.BarTabsPage, Me.MenuPage})
    '
    'BilliardTablePage
    '
    Me.BilliardTablePage.Appearance.PageClient.Image = CType(resources.GetObject("BilliardTablePage.Appearance.PageClient.Image"), System.Drawing.Image)
    Me.BilliardTablePage.Appearance.PageClient.Options.UseImage = True
    Me.BilliardTablePage.AutoScroll = True
    Me.BilliardTablePage.Controls.Add(Me.BillyardFlowPanel)
    Me.BilliardTablePage.Controls.Add(Me.TableLayoutPanel2)
    Me.BilliardTablePage.Image = CType(resources.GetObject("BilliardTablePage.Image"), System.Drawing.Image)
    Me.BilliardTablePage.Name = "BilliardTablePage"
    Me.BilliardTablePage.Size = New System.Drawing.Size(613, 322)
    Me.BilliardTablePage.Text = "Meja Billiard"
    '
    'BillyardFlowPanel
    '
    Me.BillyardFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BillyardFlowPanel.Location = New System.Drawing.Point(0, 22)
    Me.BillyardFlowPanel.Name = "BillyardFlowPanel"
    Me.BillyardFlowPanel.Size = New System.Drawing.Size(613, 300)
    Me.BillyardFlowPanel.TabIndex = 10
    '
    'RestoTablePage
    '
    Me.RestoTablePage.Controls.Add(Me.RestoFlowPanel)
    Me.RestoTablePage.Controls.Add(Me.TableLayoutPanel4)
    Me.RestoTablePage.Image = CType(resources.GetObject("RestoTablePage.Image"), System.Drawing.Image)
    Me.RestoTablePage.Name = "RestoTablePage"
    Me.RestoTablePage.Size = New System.Drawing.Size(613, 322)
    Me.RestoTablePage.Text = "Meja Resto"
    '
    'RestoFlowPanel
    '
    Me.RestoFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.RestoFlowPanel.Location = New System.Drawing.Point(0, 22)
    Me.RestoFlowPanel.Name = "RestoFlowPanel"
    Me.RestoFlowPanel.Size = New System.Drawing.Size(613, 300)
    Me.RestoFlowPanel.TabIndex = 12
    '
    'BarTablePage
    '
    Me.BarTablePage.Controls.Add(Me.BarFlowPanel)
    Me.BarTablePage.Controls.Add(Me.TableLayoutPanel5)
    Me.BarTablePage.Image = CType(resources.GetObject("BarTablePage.Image"), System.Drawing.Image)
    Me.BarTablePage.Name = "BarTablePage"
    Me.BarTablePage.Size = New System.Drawing.Size(613, 322)
    Me.BarTablePage.Text = "Meja Bar"
    '
    'BarFlowPanel
    '
    Me.BarFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BarFlowPanel.Location = New System.Drawing.Point(0, 22)
    Me.BarFlowPanel.Name = "BarFlowPanel"
    Me.BarFlowPanel.Size = New System.Drawing.Size(613, 300)
    Me.BarFlowPanel.TabIndex = 12
    '
    'BarTabsPage
    '
    Me.BarTabsPage.Image = CType(resources.GetObject("BarTabsPage.Image"), System.Drawing.Image)
    Me.BarTabsPage.Name = "BarTabsPage"
    Me.BarTabsPage.Size = New System.Drawing.Size(613, 322)
    Me.BarTabsPage.Text = "Bar tabs"
    '
    'MenuPage
    '
    Me.MenuPage.Controls.Add(Me.GridControl1)
    Me.MenuPage.Image = CType(resources.GetObject("MenuPage.Image"), System.Drawing.Image)
    Me.MenuPage.Name = "MenuPage"
    Me.MenuPage.Size = New System.Drawing.Size(613, 322)
    Me.MenuPage.Text = "Menu"
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(115, 68)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(400, 200)
    Me.GridControl1.TabIndex = 0
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.DaftarReservasiBtn, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.StatusMejaBtn, 2, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(619, 41)
    Me.TableLayoutPanel1.TabIndex = 10
    '
    'DaftarReservasiBtn
    '
    Me.DaftarReservasiBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DaftarReservasiBtn.Image = CType(resources.GetObject("DaftarReservasiBtn.Image"), System.Drawing.Image)
    Me.DaftarReservasiBtn.Location = New System.Drawing.Point(382, 3)
    Me.DaftarReservasiBtn.Name = "DaftarReservasiBtn"
    Me.DaftarReservasiBtn.Size = New System.Drawing.Size(114, 35)
    Me.DaftarReservasiBtn.TabIndex = 0
    Me.DaftarReservasiBtn.Text = "Daftar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reservasi"
    '
    'StatusMejaBtn
    '
    Me.StatusMejaBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.StatusMejaBtn.Image = CType(resources.GetObject("StatusMejaBtn.Image"), System.Drawing.Image)
    Me.StatusMejaBtn.Location = New System.Drawing.Point(502, 3)
    Me.StatusMejaBtn.Name = "StatusMejaBtn"
    Me.StatusMejaBtn.Size = New System.Drawing.Size(114, 35)
    Me.StatusMejaBtn.TabIndex = 1
    Me.StatusMejaBtn.Text = "Status Meja"
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
    Me.SplitContainerControl1.Size = New System.Drawing.Size(348, 414)
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
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(348, 204)
    Me.TableLayoutPanel3.TabIndex = 0
    '
    'SimpleButton15
    '
    Me.SimpleButton15.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton15.Appearance.Options.UseFont = True
    Me.SimpleButton15.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton15.Image = CType(resources.GetObject("SimpleButton15.Image"), System.Drawing.Image)
    Me.SimpleButton15.Location = New System.Drawing.Point(264, 105)
    Me.SimpleButton15.Name = "SimpleButton15"
    Me.SimpleButton15.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton15.TabIndex = 14
    Me.SimpleButton15.Text = "Bayar"
    '
    'SimpleButton14
    '
    Me.SimpleButton14.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton14.Appearance.Options.UseFont = True
    Me.SimpleButton14.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton14.Image = CType(resources.GetObject("SimpleButton14.Image"), System.Drawing.Image)
    Me.SimpleButton14.Location = New System.Drawing.Point(264, 54)
    Me.SimpleButton14.Name = "SimpleButton14"
    Me.SimpleButton14.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton14.TabIndex = 13
    Me.SimpleButton14.Text = "Del"
    '
    'SimpleButton13
    '
    Me.SimpleButton13.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton13.Appearance.Options.UseFont = True
    Me.SimpleButton13.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton13.Location = New System.Drawing.Point(264, 3)
    Me.SimpleButton13.Name = "SimpleButton13"
    Me.SimpleButton13.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton13.TabIndex = 12
    Me.SimpleButton13.Text = "*"
    '
    'SimpleButton3
    '
    Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton3.Appearance.Options.UseFont = True
    Me.SimpleButton3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton3.Location = New System.Drawing.Point(177, 3)
    Me.SimpleButton3.Name = "SimpleButton3"
    Me.SimpleButton3.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton3.TabIndex = 2
    Me.SimpleButton3.Text = "3"
    '
    'SimpleButton2
    '
    Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton2.Appearance.Options.UseFont = True
    Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton2.Location = New System.Drawing.Point(90, 3)
    Me.SimpleButton2.Name = "SimpleButton2"
    Me.SimpleButton2.Size = New System.Drawing.Size(81, 45)
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
    Me.SimpleButton1.Size = New System.Drawing.Size(81, 45)
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
    Me.SimpleButton4.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton4.TabIndex = 3
    Me.SimpleButton4.Text = "4"
    '
    'SimpleButton5
    '
    Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton5.Appearance.Options.UseFont = True
    Me.SimpleButton5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton5.Location = New System.Drawing.Point(90, 54)
    Me.SimpleButton5.Name = "SimpleButton5"
    Me.SimpleButton5.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton5.TabIndex = 4
    Me.SimpleButton5.Text = "5"
    '
    'SimpleButton6
    '
    Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton6.Appearance.Options.UseFont = True
    Me.SimpleButton6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton6.Location = New System.Drawing.Point(177, 54)
    Me.SimpleButton6.Name = "SimpleButton6"
    Me.SimpleButton6.Size = New System.Drawing.Size(81, 45)
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
    Me.SimpleButton7.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton7.TabIndex = 6
    Me.SimpleButton7.Text = "7"
    '
    'SimpleButton8
    '
    Me.SimpleButton8.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton8.Appearance.Options.UseFont = True
    Me.SimpleButton8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton8.Location = New System.Drawing.Point(90, 105)
    Me.SimpleButton8.Name = "SimpleButton8"
    Me.SimpleButton8.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton8.TabIndex = 7
    Me.SimpleButton8.Text = "8"
    '
    'SimpleButton9
    '
    Me.SimpleButton9.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton9.Appearance.Options.UseFont = True
    Me.SimpleButton9.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton9.Location = New System.Drawing.Point(177, 105)
    Me.SimpleButton9.Name = "SimpleButton9"
    Me.SimpleButton9.Size = New System.Drawing.Size(81, 45)
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
    Me.SimpleButton10.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton10.TabIndex = 9
    Me.SimpleButton10.Text = "0"
    '
    'SimpleButton11
    '
    Me.SimpleButton11.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton11.Appearance.Options.UseFont = True
    Me.SimpleButton11.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton11.Location = New System.Drawing.Point(90, 156)
    Me.SimpleButton11.Name = "SimpleButton11"
    Me.SimpleButton11.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton11.TabIndex = 10
    Me.SimpleButton11.Text = "00"
    '
    'SimpleButton12
    '
    Me.SimpleButton12.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.SimpleButton12.Appearance.Options.UseFont = True
    Me.SimpleButton12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SimpleButton12.Location = New System.Drawing.Point(177, 156)
    Me.SimpleButton12.Name = "SimpleButton12"
    Me.SimpleButton12.Size = New System.Drawing.Size(81, 45)
    Me.SimpleButton12.TabIndex = 11
    Me.SimpleButton12.Text = "000"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 5
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.LabelControl4, 3, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelControl3, 2, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelControl2, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.LabelControl1, 0, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(613, 22)
    Me.TableLayoutPanel2.TabIndex = 11
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.LightGreen
    Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "Free"
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.LightBlue
    Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl2.Location = New System.Drawing.Point(73, 3)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl2.TabIndex = 1
    Me.LabelControl2.Text = "Reserved"
    '
    'LabelControl3
    '
    Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.Gold
    Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl3.Location = New System.Drawing.Point(143, 3)
    Me.LabelControl3.Name = "LabelControl3"
    Me.LabelControl3.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl3.TabIndex = 2
    Me.LabelControl3.Text = "Checked In"
    '
    'LabelControl4
    '
    Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Tomato
    Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl4.Location = New System.Drawing.Point(213, 3)
    Me.LabelControl4.Name = "LabelControl4"
    Me.LabelControl4.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl4.TabIndex = 3
    Me.LabelControl4.Text = "Time Out"
    '
    'TableLayoutPanel4
    '
    Me.TableLayoutPanel4.ColumnCount = 5
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.Controls.Add(Me.LabelControl5, 3, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.LabelControl6, 2, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.LabelControl7, 1, 0)
    Me.TableLayoutPanel4.Controls.Add(Me.LabelControl8, 0, 0)
    Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
    Me.TableLayoutPanel4.RowCount = 1
    Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel4.Size = New System.Drawing.Size(613, 22)
    Me.TableLayoutPanel4.TabIndex = 13
    '
    'LabelControl5
    '
    Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Tomato
    Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl5.Location = New System.Drawing.Point(213, 3)
    Me.LabelControl5.Name = "LabelControl5"
    Me.LabelControl5.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl5.TabIndex = 3
    Me.LabelControl5.Text = "Time Out"
    '
    'LabelControl6
    '
    Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Gold
    Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl6.Location = New System.Drawing.Point(143, 3)
    Me.LabelControl6.Name = "LabelControl6"
    Me.LabelControl6.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl6.TabIndex = 2
    Me.LabelControl6.Text = "Checked In"
    '
    'LabelControl7
    '
    Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.LightBlue
    Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl7.Location = New System.Drawing.Point(73, 3)
    Me.LabelControl7.Name = "LabelControl7"
    Me.LabelControl7.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl7.TabIndex = 1
    Me.LabelControl7.Text = "Reserved"
    '
    'LabelControl8
    '
    Me.LabelControl8.Appearance.BackColor = System.Drawing.Color.LightGreen
    Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl8.Location = New System.Drawing.Point(3, 3)
    Me.LabelControl8.Name = "LabelControl8"
    Me.LabelControl8.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl8.TabIndex = 0
    Me.LabelControl8.Text = "Free"
    '
    'TableLayoutPanel5
    '
    Me.TableLayoutPanel5.ColumnCount = 5
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
    Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel5.Controls.Add(Me.LabelControl9, 3, 0)
    Me.TableLayoutPanel5.Controls.Add(Me.LabelControl10, 2, 0)
    Me.TableLayoutPanel5.Controls.Add(Me.LabelControl11, 1, 0)
    Me.TableLayoutPanel5.Controls.Add(Me.LabelControl12, 0, 0)
    Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
    Me.TableLayoutPanel5.RowCount = 1
    Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel5.Size = New System.Drawing.Size(613, 22)
    Me.TableLayoutPanel5.TabIndex = 13
    '
    'LabelControl9
    '
    Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.Tomato
    Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl9.Location = New System.Drawing.Point(213, 3)
    Me.LabelControl9.Name = "LabelControl9"
    Me.LabelControl9.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl9.TabIndex = 3
    Me.LabelControl9.Text = "Time Out"
    '
    'LabelControl10
    '
    Me.LabelControl10.Appearance.BackColor = System.Drawing.Color.Gold
    Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl10.Location = New System.Drawing.Point(143, 3)
    Me.LabelControl10.Name = "LabelControl10"
    Me.LabelControl10.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl10.TabIndex = 2
    Me.LabelControl10.Text = "Checked In"
    '
    'LabelControl11
    '
    Me.LabelControl11.Appearance.BackColor = System.Drawing.Color.LightBlue
    Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl11.Location = New System.Drawing.Point(73, 3)
    Me.LabelControl11.Name = "LabelControl11"
    Me.LabelControl11.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl11.TabIndex = 1
    Me.LabelControl11.Text = "Reserved"
    '
    'LabelControl12
    '
    Me.LabelControl12.Appearance.BackColor = System.Drawing.Color.LightGreen
    Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
    Me.LabelControl12.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl12.Location = New System.Drawing.Point(3, 3)
    Me.LabelControl12.Name = "LabelControl12"
    Me.LabelControl12.Size = New System.Drawing.Size(64, 16)
    Me.LabelControl12.TabIndex = 0
    Me.LabelControl12.Text = "Free"
    '
    'FormPOS
    '
    Me.Appearance.Options.UseFont = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(976, 414)
    Me.Controls.Add(Me.MainSplit)
    Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "FormPOS"
    Me.Text = "Point Of Sales"
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MainSplit.ResumeLayout(False)
    CType(Me.MainTab, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MainTab.ResumeLayout(False)
    Me.BilliardTablePage.ResumeLayout(False)
    Me.RestoTablePage.ResumeLayout(False)
    Me.BarTablePage.ResumeLayout(False)
    Me.MenuPage.ResumeLayout(False)
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.TableLayoutPanel4.ResumeLayout(False)
    Me.TableLayoutPanel4.PerformLayout()
    Me.TableLayoutPanel5.ResumeLayout(False)
    Me.TableLayoutPanel5.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents MainSplit As DevExpress.XtraEditors.SplitContainerControl
  Friend WithEvents MainTab As DevExpress.XtraTab.XtraTabControl
  Friend WithEvents BilliardTablePage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents BarTablePage As DevExpress.XtraTab.XtraTabPage


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
  Friend WithEvents BillyardFlowPanel As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents RestoTablePage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents RestoFlowPanel As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents BarFlowPanel As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents DaftarReservasiBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents StatusMejaBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl




End Class
