Partial Public Class MainForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
    Me.PosMenuJenisMeja = New DevExpress.XtraBars.BarButtonItem()
    Me.PosMenuDaftarMeja = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryMenuSatuan = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryMenuJenisBarang = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryMenuBarang = New DevExpress.XtraBars.BarButtonItem()
    Me.PurchasingMenuPurchasing = New DevExpress.XtraBars.BarButtonItem()
    Me.PosMenuPenjualan = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
    Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
    Me.PosMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.InventoryMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.PurchasingMenu = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
    CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ribbonControl1
    '
    Me.ribbonControl1.ExpandCollapseItem.Id = 0
    Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.PosMenuJenisMeja, Me.PosMenuDaftarMeja, Me.InventoryMenuSatuan, Me.InventoryMenuJenisBarang, Me.InventoryMenuBarang, Me.PurchasingMenuPurchasing, Me.PosMenuPenjualan, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22})
    Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
    Me.ribbonControl1.MaxItemId = 25
    Me.ribbonControl1.Name = "ribbonControl1"
    Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.PosMenuHeader, Me.InventoryMenuHeader, Me.PurchasingMenu, Me.RibbonPage1})
    Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
    Me.ribbonControl1.Size = New System.Drawing.Size(1038, 162)
    '
    'PosMenuJenisMeja
    '
    Me.PosMenuJenisMeja.Caption = "Jenis Meja"
    Me.PosMenuJenisMeja.Glyph = CType(resources.GetObject("PosMenuJenisMeja.Glyph"), System.Drawing.Image)
    Me.PosMenuJenisMeja.Id = 1
    Me.PosMenuJenisMeja.Name = "PosMenuJenisMeja"
    '
    'PosMenuDaftarMeja
    '
    Me.PosMenuDaftarMeja.Caption = "Daftar Meja"
    Me.PosMenuDaftarMeja.Glyph = CType(resources.GetObject("PosMenuDaftarMeja.Glyph"), System.Drawing.Image)
    Me.PosMenuDaftarMeja.Id = 2
    Me.PosMenuDaftarMeja.Name = "PosMenuDaftarMeja"
    '
    'InventoryMenuSatuan
    '
    Me.InventoryMenuSatuan.Caption = "Satuan"
    Me.InventoryMenuSatuan.Glyph = CType(resources.GetObject("InventoryMenuSatuan.Glyph"), System.Drawing.Image)
    Me.InventoryMenuSatuan.Id = 3
    Me.InventoryMenuSatuan.Name = "InventoryMenuSatuan"
    '
    'InventoryMenuJenisBarang
    '
    Me.InventoryMenuJenisBarang.Caption = "Jenis Barang"
    Me.InventoryMenuJenisBarang.Glyph = CType(resources.GetObject("InventoryMenuJenisBarang.Glyph"), System.Drawing.Image)
    Me.InventoryMenuJenisBarang.Id = 4
    Me.InventoryMenuJenisBarang.Name = "InventoryMenuJenisBarang"
    '
    'InventoryMenuBarang
    '
    Me.InventoryMenuBarang.Caption = "Daftar Barang"
    Me.InventoryMenuBarang.Glyph = CType(resources.GetObject("InventoryMenuBarang.Glyph"), System.Drawing.Image)
    Me.InventoryMenuBarang.Id = 5
    Me.InventoryMenuBarang.Name = "InventoryMenuBarang"
    '
    'PurchasingMenuPurchasing
    '
    Me.PurchasingMenuPurchasing.Caption = "Purchasing"
    Me.PurchasingMenuPurchasing.Id = 6
    Me.PurchasingMenuPurchasing.Name = "PurchasingMenuPurchasing"
    '
    'PosMenuPenjualan
    '
    Me.PosMenuPenjualan.Caption = "Penjualan"
    Me.PosMenuPenjualan.Glyph = CType(resources.GetObject("PosMenuPenjualan.Glyph"), System.Drawing.Image)
    Me.PosMenuPenjualan.Id = 7
    Me.PosMenuPenjualan.Name = "PosMenuPenjualan"
    Me.PosMenuPenjualan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem1
    '
    Me.BarButtonItem1.Caption = "Daftar Produk"
    Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
    Me.BarButtonItem1.Id = 8
    Me.BarButtonItem1.Name = "BarButtonItem1"
    '
    'BarButtonItem2
    '
    Me.BarButtonItem2.Caption = "Buka Tututp Kasir"
    Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
    Me.BarButtonItem2.Id = 9
    Me.BarButtonItem2.Name = "BarButtonItem2"
    Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem3
    '
    Me.BarButtonItem3.Caption = "Laporan Penjualan"
    Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
    Me.BarButtonItem3.Id = 11
    Me.BarButtonItem3.Name = "BarButtonItem3"
    Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem4
    '
    Me.BarButtonItem4.Caption = "Status Stok"
    Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
    Me.BarButtonItem4.Id = 2
    Me.BarButtonItem4.Name = "BarButtonItem4"
    Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem5
    '
    Me.BarButtonItem5.Caption = "Stok Opname"
    Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
    Me.BarButtonItem5.Id = 3
    Me.BarButtonItem5.Name = "BarButtonItem5"
    Me.BarButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem6
    '
    Me.BarButtonItem6.Caption = "Barang Keluar"
    Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
    Me.BarButtonItem6.Id = 4
    Me.BarButtonItem6.Name = "BarButtonItem6"
    Me.BarButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem7
    '
    Me.BarButtonItem7.Caption = "Pembelian"
    Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
    Me.BarButtonItem7.Id = 5
    Me.BarButtonItem7.Name = "BarButtonItem7"
    Me.BarButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem8
    '
    Me.BarButtonItem8.Caption = "Supplier"
    Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
    Me.BarButtonItem8.Id = 6
    Me.BarButtonItem8.Name = "BarButtonItem8"
    '
    'BarButtonItem9
    '
    Me.BarButtonItem9.Caption = "Terima Barang"
    Me.BarButtonItem9.Glyph = CType(resources.GetObject("BarButtonItem9.Glyph"), System.Drawing.Image)
    Me.BarButtonItem9.Id = 7
    Me.BarButtonItem9.Name = "BarButtonItem9"
    Me.BarButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem10
    '
    Me.BarButtonItem10.Caption = "Data Member"
    Me.BarButtonItem10.Glyph = CType(resources.GetObject("BarButtonItem10.Glyph"), System.Drawing.Image)
    Me.BarButtonItem10.Id = 9
    Me.BarButtonItem10.Name = "BarButtonItem10"
    Me.BarButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem11
    '
    Me.BarButtonItem11.Caption = "Deposit Member"
    Me.BarButtonItem11.Glyph = CType(resources.GetObject("BarButtonItem11.Glyph"), System.Drawing.Image)
    Me.BarButtonItem11.Id = 10
    Me.BarButtonItem11.Name = "BarButtonItem11"
    Me.BarButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem12
    '
    Me.BarButtonItem12.Caption = "Barang Supplier"
    Me.BarButtonItem12.Glyph = CType(resources.GetObject("BarButtonItem12.Glyph"), System.Drawing.Image)
    Me.BarButtonItem12.Id = 11
    Me.BarButtonItem12.Name = "BarButtonItem12"
    '
    'BarButtonItem13
    '
    Me.BarButtonItem13.Caption = "Retur"
    Me.BarButtonItem13.Glyph = CType(resources.GetObject("BarButtonItem13.Glyph"), System.Drawing.Image)
    Me.BarButtonItem13.Id = 14
    Me.BarButtonItem13.Name = "BarButtonItem13"
    Me.BarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem14
    '
    Me.BarButtonItem14.Caption = "Terima Tagihan"
    Me.BarButtonItem14.Glyph = CType(resources.GetObject("BarButtonItem14.Glyph"), System.Drawing.Image)
    Me.BarButtonItem14.Id = 15
    Me.BarButtonItem14.Name = "BarButtonItem14"
    Me.BarButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem15
    '
    Me.BarButtonItem15.Caption = "Transaksi Kas / Bank"
    Me.BarButtonItem15.Glyph = CType(resources.GetObject("BarButtonItem15.Glyph"), System.Drawing.Image)
    Me.BarButtonItem15.Id = 16
    Me.BarButtonItem15.Name = "BarButtonItem15"
    Me.BarButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem16
    '
    Me.BarButtonItem16.Caption = "Group Akun"
    Me.BarButtonItem16.Glyph = CType(resources.GetObject("BarButtonItem16.Glyph"), System.Drawing.Image)
    Me.BarButtonItem16.Id = 18
    Me.BarButtonItem16.Name = "BarButtonItem16"
    '
    'BarButtonItem17
    '
    Me.BarButtonItem17.Caption = "COA"
    Me.BarButtonItem17.Glyph = CType(resources.GetObject("BarButtonItem17.Glyph"), System.Drawing.Image)
    Me.BarButtonItem17.Id = 19
    Me.BarButtonItem17.Name = "BarButtonItem17"
    '
    'BarButtonItem18
    '
    Me.BarButtonItem18.Caption = "Jurnal"
    Me.BarButtonItem18.Glyph = CType(resources.GetObject("BarButtonItem18.Glyph"), System.Drawing.Image)
    Me.BarButtonItem18.Id = 20
    Me.BarButtonItem18.Name = "BarButtonItem18"
    Me.BarButtonItem18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem19
    '
    Me.BarButtonItem19.Caption = "Buka / Tutup Periode"
    Me.BarButtonItem19.Glyph = CType(resources.GetObject("BarButtonItem19.Glyph"), System.Drawing.Image)
    Me.BarButtonItem19.Id = 21
    Me.BarButtonItem19.Name = "BarButtonItem19"
    Me.BarButtonItem19.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem20
    '
    Me.BarButtonItem20.Caption = "Neraca"
    Me.BarButtonItem20.Glyph = CType(resources.GetObject("BarButtonItem20.Glyph"), System.Drawing.Image)
    Me.BarButtonItem20.Id = 22
    Me.BarButtonItem20.Name = "BarButtonItem20"
    Me.BarButtonItem20.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem21
    '
    Me.BarButtonItem21.Caption = "Rugi Laba"
    Me.BarButtonItem21.Glyph = CType(resources.GetObject("BarButtonItem21.Glyph"), System.Drawing.Image)
    Me.BarButtonItem21.Id = 23
    Me.BarButtonItem21.Name = "BarButtonItem21"
    Me.BarButtonItem21.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'BarButtonItem22
    '
    Me.BarButtonItem22.Caption = "General Ledger"
    Me.BarButtonItem22.Glyph = CType(resources.GetObject("BarButtonItem22.Glyph"), System.Drawing.Image)
    Me.BarButtonItem22.Id = 24
    Me.BarButtonItem22.Name = "BarButtonItem22"
    Me.BarButtonItem22.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'PosMenuHeader
    '
    Me.PosMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup3})
    Me.PosMenuHeader.Image = CType(resources.GetObject("PosMenuHeader.Image"), System.Drawing.Image)
    Me.PosMenuHeader.Name = "PosMenuHeader"
    Me.PosMenuHeader.Text = "Transaksi"
    '
    'ribbonPageGroup1
    '
    Me.ribbonPageGroup1.ItemLinks.Add(Me.PosMenuPenjualan)
    Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
    Me.ribbonPageGroup1.ItemLinks.Add(Me.PosMenuJenisMeja)
    Me.ribbonPageGroup1.ItemLinks.Add(Me.PosMenuDaftarMeja)
    Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
    Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
    Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
    Me.ribbonPageGroup1.Text = "Penjualan"
    '
    'RibbonPageGroup3
    '
    Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem10)
    Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem11)
    Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
    Me.RibbonPageGroup3.Text = "Member"
    '
    'InventoryMenuHeader
    '
    Me.InventoryMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
    Me.InventoryMenuHeader.Image = CType(resources.GetObject("InventoryMenuHeader.Image"), System.Drawing.Image)
    Me.InventoryMenuHeader.Name = "InventoryMenuHeader"
    Me.InventoryMenuHeader.Text = "Inventory"
    '
    'RibbonPageGroup4
    '
    Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem4)
    Me.RibbonPageGroup4.ItemLinks.Add(Me.InventoryMenuBarang)
    Me.RibbonPageGroup4.ItemLinks.Add(Me.InventoryMenuSatuan)
    Me.RibbonPageGroup4.ItemLinks.Add(Me.InventoryMenuJenisBarang)
    Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem5)
    Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem6)
    Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
    Me.RibbonPageGroup4.Text = "Inventory"
    '
    'PurchasingMenu
    '
    Me.PurchasingMenu.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
    Me.PurchasingMenu.Image = CType(resources.GetObject("PurchasingMenu.Image"), System.Drawing.Image)
    Me.PurchasingMenu.Name = "PurchasingMenu"
    Me.PurchasingMenu.Text = "Pembelian"
    '
    'RibbonPageGroup2
    '
    Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem7)
    Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem9)
    Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem8)
    Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem12)
    Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem13)
    Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
    Me.RibbonPageGroup2.Text = "Pembelian"
    '
    'RibbonPage1
    '
    Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup6})
    Me.RibbonPage1.Image = CType(resources.GetObject("RibbonPage1.Image"), System.Drawing.Image)
    Me.RibbonPage1.Name = "RibbonPage1"
    Me.RibbonPage1.Text = "Keuangan & Akunting"
    '
    'RibbonPageGroup5
    '
    Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem14)
    Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem15)
    Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
    Me.RibbonPageGroup5.Text = "Finance"
    '
    'RibbonPageGroup6
    '
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem16)
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem17)
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem19)
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem18)
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem20)
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem21)
    Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem22)
    Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
    Me.RibbonPageGroup6.Text = "Akunting"
    '
    'XtraTabbedMdiManager1
    '
    Me.XtraTabbedMdiManager1.MdiParent = Me
    '
    'MainForm
    '
    Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1038, 360)
    Me.Controls.Add(Me.ribbonControl1)
    Me.IsMdiContainer = True
    Me.Name = "MainForm"
    Me.Ribbon = Me.ribbonControl1
    Me.Text = "Cafe Management"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private PosMenuHeader As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PosMenuJenisMeja As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents PosMenuDaftarMeja As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InventoryMenuSatuan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InventoryMenuHeader As DevExpress.XtraBars.Ribbon.RibbonPage
  Friend WithEvents InventoryMenuJenisBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InventoryMenuBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PurchasingMenuPurchasing As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PurchasingMenu As DevExpress.XtraBars.Ribbon.RibbonPage
  Friend WithEvents PosMenuPenjualan As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
  Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
End Class
