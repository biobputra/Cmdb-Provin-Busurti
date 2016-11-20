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
    Me.components = New System.ComponentModel.Container()
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.DaftarReservasiBtn = New DevExpress.XtraEditors.SimpleButton()
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
    Me.DataSetDaftarMeja = New Cafe_Management.DataSetDaftarMeja()
    Me.DaftarMejaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.DaftarMejaTableAdapter = New Cafe_Management.DataSetDaftarMejaTableAdapters.DaftarMejaTableAdapter()
    Me.TableAdapterManager = New Cafe_Management.DataSetDaftarMejaTableAdapters.TableAdapterManager()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainSplit.SuspendLayout()
    CType(Me.MainTab, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainTab.SuspendLayout()
    Me.BilliardTablePage.SuspendLayout()
    Me.RestoTablePage.SuspendLayout()
    Me.BarTablePage.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainerControl1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    CType(Me.DataSetDaftarMeja, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.DaftarMejaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.BilliardTablePage.Appearance.PageClient.Image = CType(resources.GetObject("BillyardTablePage.Appearance.PageClient.Image"), System.Drawing.Image)
    Me.BilliardTablePage.Appearance.PageClient.Options.UseImage = True
    Me.BilliardTablePage.AutoScroll = True
    Me.BilliardTablePage.Controls.Add(Me.BillyardFlowPanel)
    Me.BilliardTablePage.Image = CType(resources.GetObject("BilliardTablePage.Image"), System.Drawing.Image)
    Me.BilliardTablePage.Name = "BilliardTablePage"
    Me.BilliardTablePage.Size = New System.Drawing.Size(613, 322)
    Me.BilliardTablePage.Text = "Meja Billiard"
    '
    'BillyardFlowPanel
    '
    Me.BillyardFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BillyardFlowPanel.Location = New System.Drawing.Point(0, 0)
    Me.BillyardFlowPanel.Name = "BillyardFlowPanel"
    Me.BillyardFlowPanel.Size = New System.Drawing.Size(613, 322)
    Me.BillyardFlowPanel.TabIndex = 10
    '
    'RestoTablePage
    '
    Me.RestoTablePage.Controls.Add(Me.RestoFlowPanel)
    Me.RestoTablePage.Image = CType(resources.GetObject("RestoTablePage.Image"), System.Drawing.Image)
    Me.RestoTablePage.Name = "RestoTablePage"
    Me.RestoTablePage.Size = New System.Drawing.Size(613, 322)
    Me.RestoTablePage.Text = "Meja Resto"
    '
    'RestoFlowPanel
    '
    Me.RestoFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.RestoFlowPanel.Location = New System.Drawing.Point(0, 0)
    Me.RestoFlowPanel.Name = "RestoFlowPanel"
    Me.RestoFlowPanel.Size = New System.Drawing.Size(613, 322)
    Me.RestoFlowPanel.TabIndex = 12
    '
    'BarTablePage
    '
    Me.BarTablePage.Controls.Add(Me.BarFlowPanel)
    Me.BarTablePage.Image = CType(resources.GetObject("BarTablePage.Image"), System.Drawing.Image)
    Me.BarTablePage.Name = "BarTablePage"
    Me.BarTablePage.Size = New System.Drawing.Size(613, 322)
    Me.BarTablePage.Text = "Meja Bar"
    '
    'BarFlowPanel
    '
    Me.BarFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.BarFlowPanel.Location = New System.Drawing.Point(0, 0)
    Me.BarFlowPanel.Name = "BarFlowPanel"
    Me.BarFlowPanel.Size = New System.Drawing.Size(613, 322)
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
    Me.MenuPage.Image = CType(resources.GetObject("MenuPage.Image"), System.Drawing.Image)
    Me.MenuPage.Name = "MenuPage"
    Me.MenuPage.Size = New System.Drawing.Size(613, 322)
    Me.MenuPage.Text = "Menu"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.DaftarReservasiBtn, 1, 0)
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
    Me.DaftarReservasiBtn.Location = New System.Drawing.Point(502, 3)
    Me.DaftarReservasiBtn.Name = "DaftarReservasiBtn"
    Me.DaftarReservasiBtn.Size = New System.Drawing.Size(114, 35)
    Me.DaftarReservasiBtn.TabIndex = 0
    Me.DaftarReservasiBtn.Text = "Daftar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reservasi"
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
    'DataSetDaftarMeja
    '
    Me.DataSetDaftarMeja.DataSetName = "DataSetDaftarMeja"
    Me.DataSetDaftarMeja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'DaftarMejaTableAdapter
    '
    Me.DaftarMejaTableAdapter.ClearBeforeFill = True
    '
    'TableAdapterManager
    '
    Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
    Me.TableAdapterManager.Connection = Nothing
    Me.TableAdapterManager.DaftarMejaTableAdapter = Nothing
    Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetDaftarMejaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
    Me.TableLayoutPanel1.ResumeLayout(False)
    CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainerControl1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    CType(Me.DataSetDaftarMeja, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.DaftarMejaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents DataSetDaftarMeja As Cafe_Management.DataSetDaftarMeja
  Friend WithEvents DaftarMejaBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents DaftarMejaTableAdapter As Cafe_Management.DataSetDaftarMejaTableAdapters.DaftarMejaTableAdapter
  Friend WithEvents TableAdapterManager As Cafe_Management.DataSetDaftarMejaTableAdapters.TableAdapterManager
  Friend WithEvents RestoTablePage As DevExpress.XtraTab.XtraTabPage
  Friend WithEvents RestoFlowPanel As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents BarFlowPanel As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents DaftarReservasiBtn As DevExpress.XtraEditors.SimpleButton




End Class
