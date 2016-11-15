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
    Me.MainRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
    Me.TransaksiJenisMejaBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiDaftarMejaBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.InventorySatuanBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryJenisBarangBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryDaftarBarangBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.PurchasingMenuPurchasing = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiPOSBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiDaftarProdukBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiBukaTututpKasirBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiLaporanPenjualanBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryStatusStokBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryStokOpnameBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.InventoryBarangkeluarBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.PembelianPembelianBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.PembelianSupplierBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.PembelianTerimaBarangBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiDataMemberBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiDepositMemberBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.PembelianBarangSupplierBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.PembeliannReturBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.AccountingTerimaTagihanBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganTransaksiKasBankBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganGroupAkunBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganCOABtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganJurnalBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganBukaTutupPeriode = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganLaporanNeracaBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganLaporanRugiLabaBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.KeuanganLaporanLedgerBtn = New DevExpress.XtraBars.BarButtonItem()
    Me.TransaksiMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.TransaksiPenjualanGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.TransaksiMemberGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.InventoryMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.InventoryInventoryGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.PembelianMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.PembelianPembelianGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.AccountingMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
    Me.KeuanganFinanceGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.KeuanganAccountingGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
    Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
    Me.InventoryDaftarStorageBtn = New DevExpress.XtraBars.BarButtonItem()
    CType(Me.MainRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MainRibbon
    '
    Me.MainRibbon.ExpandCollapseItem.Id = 0
    Me.MainRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.MainRibbon.ExpandCollapseItem, Me.TransaksiJenisMejaBtn, Me.TransaksiDaftarMejaBtn, Me.InventorySatuanBtn, Me.InventoryJenisBarangBtn, Me.InventoryDaftarBarangBtn, Me.PurchasingMenuPurchasing, Me.TransaksiPOSBtn, Me.TransaksiDaftarProdukBtn, Me.TransaksiBukaTututpKasirBtn, Me.TransaksiLaporanPenjualanBtn, Me.InventoryStatusStokBtn, Me.InventoryStokOpnameBtn, Me.InventoryBarangkeluarBtn, Me.PembelianPembelianBtn, Me.PembelianSupplierBtn, Me.PembelianTerimaBarangBtn, Me.TransaksiDataMemberBtn, Me.TransaksiDepositMemberBtn, Me.PembelianBarangSupplierBtn, Me.PembeliannReturBtn, Me.AccountingTerimaTagihanBtn, Me.KeuanganTransaksiKasBankBtn, Me.KeuanganGroupAkunBtn, Me.KeuanganCOABtn, Me.KeuanganJurnalBtn, Me.KeuanganBukaTutupPeriode, Me.KeuanganLaporanNeracaBtn, Me.KeuanganLaporanRugiLabaBtn, Me.KeuanganLaporanLedgerBtn, Me.InventoryDaftarStorageBtn})
    Me.MainRibbon.Location = New System.Drawing.Point(0, 0)
    Me.MainRibbon.MaxItemId = 26
    Me.MainRibbon.Name = "MainRibbon"
    Me.MainRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.TransaksiMenuHeader, Me.InventoryMenuHeader, Me.PembelianMenuHeader, Me.AccountingMenuHeader})
    Me.MainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
    Me.MainRibbon.Size = New System.Drawing.Size(1038, 162)
    '
    'TransaksiJenisMejaBtn
    '
    Me.TransaksiJenisMejaBtn.Caption = "Jenis Meja"
    Me.TransaksiJenisMejaBtn.Glyph = CType(resources.GetObject("TransaksiJenisMejaBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiJenisMejaBtn.Id = 1
    Me.TransaksiJenisMejaBtn.Name = "TransaksiJenisMejaBtn"
    '
    'TransaksiDaftarMejaBtn
    '
    Me.TransaksiDaftarMejaBtn.Caption = "Daftar Meja"
    Me.TransaksiDaftarMejaBtn.Glyph = CType(resources.GetObject("TransaksiDaftarMejaBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiDaftarMejaBtn.Id = 2
    Me.TransaksiDaftarMejaBtn.Name = "TransaksiDaftarMejaBtn"
    '
    'InventorySatuanBtn
    '
    Me.InventorySatuanBtn.Caption = "Satuan"
    Me.InventorySatuanBtn.Glyph = CType(resources.GetObject("InventorySatuanBtn.Glyph"), System.Drawing.Image)
    Me.InventorySatuanBtn.Id = 3
    Me.InventorySatuanBtn.Name = "InventorySatuanBtn"
    '
    'InventoryJenisBarangBtn
    '
    Me.InventoryJenisBarangBtn.Caption = "Jenis Barang"
    Me.InventoryJenisBarangBtn.Glyph = CType(resources.GetObject("InventoryJenisBarangBtn.Glyph"), System.Drawing.Image)
    Me.InventoryJenisBarangBtn.Id = 4
    Me.InventoryJenisBarangBtn.Name = "InventoryJenisBarangBtn"
    '
    'InventoryDaftarBarangBtn
    '
    Me.InventoryDaftarBarangBtn.Caption = "Daftar Barang"
    Me.InventoryDaftarBarangBtn.Glyph = CType(resources.GetObject("InventoryDaftarBarangBtn.Glyph"), System.Drawing.Image)
    Me.InventoryDaftarBarangBtn.Id = 5
    Me.InventoryDaftarBarangBtn.Name = "InventoryDaftarBarangBtn"
    '
    'PurchasingMenuPurchasing
    '
    Me.PurchasingMenuPurchasing.Caption = "Purchasing"
    Me.PurchasingMenuPurchasing.Id = 6
    Me.PurchasingMenuPurchasing.Name = "PurchasingMenuPurchasing"
    '
    'TransaksiPOSBtn
    '
    Me.TransaksiPOSBtn.Caption = "Point Of Sales"
    Me.TransaksiPOSBtn.Glyph = CType(resources.GetObject("TransaksiPOSBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiPOSBtn.Id = 7
    Me.TransaksiPOSBtn.Name = "TransaksiPOSBtn"
    Me.TransaksiPOSBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'TransaksiDaftarProdukBtn
    '
    Me.TransaksiDaftarProdukBtn.Caption = "Daftar Produk && Layanan"
    Me.TransaksiDaftarProdukBtn.Glyph = CType(resources.GetObject("TransaksiDaftarProdukBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiDaftarProdukBtn.Id = 8
    Me.TransaksiDaftarProdukBtn.Name = "TransaksiDaftarProdukBtn"
    '
    'TransaksiBukaTututpKasirBtn
    '
    Me.TransaksiBukaTututpKasirBtn.Caption = "Buka Tututp Kasir"
    Me.TransaksiBukaTututpKasirBtn.Glyph = CType(resources.GetObject("TransaksiBukaTututpKasirBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiBukaTututpKasirBtn.Id = 9
    Me.TransaksiBukaTututpKasirBtn.Name = "TransaksiBukaTututpKasirBtn"
    Me.TransaksiBukaTututpKasirBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'TransaksiLaporanPenjualanBtn
    '
    Me.TransaksiLaporanPenjualanBtn.Caption = "Laporan Penjualan"
    Me.TransaksiLaporanPenjualanBtn.Glyph = CType(resources.GetObject("TransaksiLaporanPenjualanBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiLaporanPenjualanBtn.Id = 11
    Me.TransaksiLaporanPenjualanBtn.Name = "TransaksiLaporanPenjualanBtn"
    Me.TransaksiLaporanPenjualanBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'InventoryStatusStokBtn
    '
    Me.InventoryStatusStokBtn.Caption = "Status Stok"
    Me.InventoryStatusStokBtn.Glyph = CType(resources.GetObject("InventoryStatusStokBtn.Glyph"), System.Drawing.Image)
    Me.InventoryStatusStokBtn.Id = 2
    Me.InventoryStatusStokBtn.Name = "InventoryStatusStokBtn"
    Me.InventoryStatusStokBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'InventoryStokOpnameBtn
    '
    Me.InventoryStokOpnameBtn.Caption = "Stok Opname"
    Me.InventoryStokOpnameBtn.Glyph = CType(resources.GetObject("InventoryStokOpnameBtn.Glyph"), System.Drawing.Image)
    Me.InventoryStokOpnameBtn.Id = 3
    Me.InventoryStokOpnameBtn.Name = "InventoryStokOpnameBtn"
    Me.InventoryStokOpnameBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'InventoryBarangkeluarBtn
    '
    Me.InventoryBarangkeluarBtn.Caption = "Barang Keluar"
    Me.InventoryBarangkeluarBtn.Glyph = CType(resources.GetObject("InventoryBarangkeluarBtn.Glyph"), System.Drawing.Image)
    Me.InventoryBarangkeluarBtn.Id = 4
    Me.InventoryBarangkeluarBtn.Name = "InventoryBarangkeluarBtn"
    Me.InventoryBarangkeluarBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'PembelianPembelianBtn
    '
    Me.PembelianPembelianBtn.Caption = "Pembelian"
    Me.PembelianPembelianBtn.Glyph = CType(resources.GetObject("PembelianPembelianBtn.Glyph"), System.Drawing.Image)
    Me.PembelianPembelianBtn.Id = 5
    Me.PembelianPembelianBtn.Name = "PembelianPembelianBtn"
    Me.PembelianPembelianBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'PembelianSupplierBtn
    '
    Me.PembelianSupplierBtn.Caption = "Supplier"
    Me.PembelianSupplierBtn.Glyph = CType(resources.GetObject("PembelianSupplierBtn.Glyph"), System.Drawing.Image)
    Me.PembelianSupplierBtn.Id = 6
    Me.PembelianSupplierBtn.Name = "PembelianSupplierBtn"
    '
    'PembelianTerimaBarangBtn
    '
    Me.PembelianTerimaBarangBtn.Caption = "Terima Barang"
    Me.PembelianTerimaBarangBtn.Glyph = CType(resources.GetObject("PembelianTerimaBarangBtn.Glyph"), System.Drawing.Image)
    Me.PembelianTerimaBarangBtn.Id = 7
    Me.PembelianTerimaBarangBtn.Name = "PembelianTerimaBarangBtn"
    Me.PembelianTerimaBarangBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'TransaksiDataMemberBtn
    '
    Me.TransaksiDataMemberBtn.Caption = "Data Member"
    Me.TransaksiDataMemberBtn.Glyph = CType(resources.GetObject("TransaksiDataMemberBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiDataMemberBtn.Id = 9
    Me.TransaksiDataMemberBtn.Name = "TransaksiDataMemberBtn"
    Me.TransaksiDataMemberBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'TransaksiDepositMemberBtn
    '
    Me.TransaksiDepositMemberBtn.Caption = "Deposit Member"
    Me.TransaksiDepositMemberBtn.Glyph = CType(resources.GetObject("TransaksiDepositMemberBtn.Glyph"), System.Drawing.Image)
    Me.TransaksiDepositMemberBtn.Id = 10
    Me.TransaksiDepositMemberBtn.Name = "TransaksiDepositMemberBtn"
    Me.TransaksiDepositMemberBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'PembelianBarangSupplierBtn
    '
    Me.PembelianBarangSupplierBtn.Caption = "Barang Supplier"
    Me.PembelianBarangSupplierBtn.Glyph = CType(resources.GetObject("PembelianBarangSupplierBtn.Glyph"), System.Drawing.Image)
    Me.PembelianBarangSupplierBtn.Id = 11
    Me.PembelianBarangSupplierBtn.Name = "PembelianBarangSupplierBtn"
    '
    'PembeliannReturBtn
    '
    Me.PembeliannReturBtn.Caption = "Retur"
    Me.PembeliannReturBtn.Glyph = CType(resources.GetObject("PembeliannReturBtn.Glyph"), System.Drawing.Image)
    Me.PembeliannReturBtn.Id = 14
    Me.PembeliannReturBtn.Name = "PembeliannReturBtn"
    Me.PembeliannReturBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'AccountingTerimaTagihanBtn
    '
    Me.AccountingTerimaTagihanBtn.Caption = "Terima Tagihan"
    Me.AccountingTerimaTagihanBtn.Glyph = CType(resources.GetObject("AccountingTerimaTagihanBtn.Glyph"), System.Drawing.Image)
    Me.AccountingTerimaTagihanBtn.Id = 15
    Me.AccountingTerimaTagihanBtn.Name = "AccountingTerimaTagihanBtn"
    Me.AccountingTerimaTagihanBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'KeuanganTransaksiKasBankBtn
    '
    Me.KeuanganTransaksiKasBankBtn.Caption = "Transaksi Kas / Bank"
    Me.KeuanganTransaksiKasBankBtn.Glyph = CType(resources.GetObject("KeuanganTransaksiKasBankBtn.Glyph"), System.Drawing.Image)
    Me.KeuanganTransaksiKasBankBtn.Id = 16
    Me.KeuanganTransaksiKasBankBtn.Name = "KeuanganTransaksiKasBankBtn"
    Me.KeuanganTransaksiKasBankBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'KeuanganGroupAkunBtn
    '
    Me.KeuanganGroupAkunBtn.Caption = "Group Akun"
    Me.KeuanganGroupAkunBtn.Glyph = CType(resources.GetObject("KeuanganGroupAkunBtn.Glyph"), System.Drawing.Image)
    Me.KeuanganGroupAkunBtn.Id = 18
    Me.KeuanganGroupAkunBtn.Name = "KeuanganGroupAkunBtn"
    '
    'KeuanganCOABtn
    '
    Me.KeuanganCOABtn.Caption = "COA"
    Me.KeuanganCOABtn.Glyph = CType(resources.GetObject("KeuanganCOABtn.Glyph"), System.Drawing.Image)
    Me.KeuanganCOABtn.Id = 19
    Me.KeuanganCOABtn.Name = "KeuanganCOABtn"
    '
    'KeuanganJurnalBtn
    '
    Me.KeuanganJurnalBtn.Caption = "Jurnal"
    Me.KeuanganJurnalBtn.Glyph = CType(resources.GetObject("KeuanganJurnalBtn.Glyph"), System.Drawing.Image)
    Me.KeuanganJurnalBtn.Id = 20
    Me.KeuanganJurnalBtn.Name = "KeuanganJurnalBtn"
    Me.KeuanganJurnalBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'KeuanganBukaTutupPeriode
    '
    Me.KeuanganBukaTutupPeriode.Caption = "Buka / Tutup Periode"
    Me.KeuanganBukaTutupPeriode.Glyph = CType(resources.GetObject("KeuanganBukaTutupPeriode.Glyph"), System.Drawing.Image)
    Me.KeuanganBukaTutupPeriode.Id = 21
    Me.KeuanganBukaTutupPeriode.Name = "KeuanganBukaTutupPeriode"
    Me.KeuanganBukaTutupPeriode.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'KeuanganLaporanNeracaBtn
    '
    Me.KeuanganLaporanNeracaBtn.Caption = "Neraca"
    Me.KeuanganLaporanNeracaBtn.Glyph = CType(resources.GetObject("KeuanganLaporanNeracaBtn.Glyph"), System.Drawing.Image)
    Me.KeuanganLaporanNeracaBtn.Id = 22
    Me.KeuanganLaporanNeracaBtn.Name = "KeuanganLaporanNeracaBtn"
    Me.KeuanganLaporanNeracaBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'KeuanganLaporanRugiLabaBtn
    '
    Me.KeuanganLaporanRugiLabaBtn.Caption = "Rugi Laba"
    Me.KeuanganLaporanRugiLabaBtn.Glyph = CType(resources.GetObject("KeuanganLaporanRugiLabaBtn.Glyph"), System.Drawing.Image)
    Me.KeuanganLaporanRugiLabaBtn.Id = 23
    Me.KeuanganLaporanRugiLabaBtn.Name = "KeuanganLaporanRugiLabaBtn"
    Me.KeuanganLaporanRugiLabaBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'KeuanganLaporanLedgerBtn
    '
    Me.KeuanganLaporanLedgerBtn.Caption = "General Ledger"
    Me.KeuanganLaporanLedgerBtn.Glyph = CType(resources.GetObject("KeuanganLaporanLedgerBtn.Glyph"), System.Drawing.Image)
    Me.KeuanganLaporanLedgerBtn.Id = 24
    Me.KeuanganLaporanLedgerBtn.Name = "KeuanganLaporanLedgerBtn"
    Me.KeuanganLaporanLedgerBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
    '
    'TransaksiMenuHeader
    '
    Me.TransaksiMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TransaksiPenjualanGroup, Me.TransaksiMemberGroup})
    Me.TransaksiMenuHeader.Image = CType(resources.GetObject("TransaksiMenuHeader.Image"), System.Drawing.Image)
    Me.TransaksiMenuHeader.Name = "TransaksiMenuHeader"
    Me.TransaksiMenuHeader.Text = "Transaksi"
    '
    'TransaksiPenjualanGroup
    '
    Me.TransaksiPenjualanGroup.ItemLinks.Add(Me.TransaksiPOSBtn)
    Me.TransaksiPenjualanGroup.ItemLinks.Add(Me.TransaksiBukaTututpKasirBtn)
    Me.TransaksiPenjualanGroup.ItemLinks.Add(Me.TransaksiJenisMejaBtn)
    Me.TransaksiPenjualanGroup.ItemLinks.Add(Me.TransaksiDaftarMejaBtn)
    Me.TransaksiPenjualanGroup.ItemLinks.Add(Me.TransaksiDaftarProdukBtn)
    Me.TransaksiPenjualanGroup.ItemLinks.Add(Me.TransaksiLaporanPenjualanBtn)
    Me.TransaksiPenjualanGroup.Name = "TransaksiPenjualanGroup"
    Me.TransaksiPenjualanGroup.Text = "Penjualan"
    '
    'TransaksiMemberGroup
    '
    Me.TransaksiMemberGroup.ItemLinks.Add(Me.TransaksiDataMemberBtn)
    Me.TransaksiMemberGroup.ItemLinks.Add(Me.TransaksiDepositMemberBtn)
    Me.TransaksiMemberGroup.Name = "TransaksiMemberGroup"
    Me.TransaksiMemberGroup.Text = "Member"
    '
    'InventoryMenuHeader
    '
    Me.InventoryMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.InventoryInventoryGroup})
    Me.InventoryMenuHeader.Image = CType(resources.GetObject("InventoryMenuHeader.Image"), System.Drawing.Image)
    Me.InventoryMenuHeader.Name = "InventoryMenuHeader"
    Me.InventoryMenuHeader.Text = "Inventory"
    '
    'InventoryInventoryGroup
    '
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventoryStatusStokBtn)
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventoryDaftarBarangBtn)
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventorySatuanBtn)
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventoryJenisBarangBtn)
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventoryStokOpnameBtn)
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventoryBarangkeluarBtn)
    Me.InventoryInventoryGroup.ItemLinks.Add(Me.InventoryDaftarStorageBtn)
    Me.InventoryInventoryGroup.Name = "InventoryInventoryGroup"
    Me.InventoryInventoryGroup.Text = "Inventory"
    '
    'PembelianMenuHeader
    '
    Me.PembelianMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PembelianPembelianGroup})
    Me.PembelianMenuHeader.Image = CType(resources.GetObject("PembelianMenuHeader.Image"), System.Drawing.Image)
    Me.PembelianMenuHeader.Name = "PembelianMenuHeader"
    Me.PembelianMenuHeader.Text = "Pembelian"
    '
    'PembelianPembelianGroup
    '
    Me.PembelianPembelianGroup.ItemLinks.Add(Me.PembelianPembelianBtn)
    Me.PembelianPembelianGroup.ItemLinks.Add(Me.PembelianTerimaBarangBtn)
    Me.PembelianPembelianGroup.ItemLinks.Add(Me.PembelianSupplierBtn)
    Me.PembelianPembelianGroup.ItemLinks.Add(Me.PembelianBarangSupplierBtn)
    Me.PembelianPembelianGroup.ItemLinks.Add(Me.PembeliannReturBtn)
    Me.PembelianPembelianGroup.Name = "PembelianPembelianGroup"
    Me.PembelianPembelianGroup.Text = "Pembelian"
    '
    'AccountingMenuHeader
    '
    Me.AccountingMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.KeuanganFinanceGroup, Me.KeuanganAccountingGroup})
    Me.AccountingMenuHeader.Image = CType(resources.GetObject("AccountingMenuHeader.Image"), System.Drawing.Image)
    Me.AccountingMenuHeader.Name = "AccountingMenuHeader"
    Me.AccountingMenuHeader.Text = "Keuangan & Akunting"
    '
    'KeuanganFinanceGroup
    '
    Me.KeuanganFinanceGroup.ItemLinks.Add(Me.AccountingTerimaTagihanBtn)
    Me.KeuanganFinanceGroup.ItemLinks.Add(Me.KeuanganTransaksiKasBankBtn)
    Me.KeuanganFinanceGroup.Name = "KeuanganFinanceGroup"
    Me.KeuanganFinanceGroup.Text = "Finance"
    '
    'KeuanganAccountingGroup
    '
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganGroupAkunBtn)
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganCOABtn)
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganBukaTutupPeriode)
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganJurnalBtn)
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganLaporanNeracaBtn)
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganLaporanRugiLabaBtn)
    Me.KeuanganAccountingGroup.ItemLinks.Add(Me.KeuanganLaporanLedgerBtn)
    Me.KeuanganAccountingGroup.Name = "KeuanganAccountingGroup"
    Me.KeuanganAccountingGroup.Text = "Akunting"
    '
    'XtraTabbedMdiManager1
    '
    Me.XtraTabbedMdiManager1.MdiParent = Me
    '
    'InventoryDaftarStorageBtn
    '
    Me.InventoryDaftarStorageBtn.Caption = "Daftar Storage"
    Me.InventoryDaftarStorageBtn.Id = 25
    Me.InventoryDaftarStorageBtn.Name = "InventoryDaftarStorageBtn"
    '
    'MainForm
    '
    Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1038, 360)
    Me.Controls.Add(Me.MainRibbon)
    Me.IsMdiContainer = True
    Me.Name = "MainForm"
    Me.Ribbon = Me.MainRibbon
    Me.Text = "Cafe Management"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    CType(Me.MainRibbon, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region

  Private WithEvents MainRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
  Private TransaksiMenuHeader As DevExpress.XtraBars.Ribbon.RibbonPage
  Private TransaksiPenjualanGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents PembelianPembelianGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents TransaksiJenisMejaBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
  Friend WithEvents TransaksiDaftarMejaBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventorySatuanBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryMenuHeader As DevExpress.XtraBars.Ribbon.RibbonPage
  Friend WithEvents InventoryJenisBarangBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryDaftarBarangBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryInventoryGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents PurchasingMenuPurchasing As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents PembelianMenuHeader As DevExpress.XtraBars.Ribbon.RibbonPage
  Friend WithEvents TransaksiPOSBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents TransaksiDaftarProdukBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents TransaksiBukaTututpKasirBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents TransaksiLaporanPenjualanBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryStatusStokBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryStokOpnameBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryBarangkeluarBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents PembelianPembelianBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents PembelianSupplierBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents PembelianTerimaBarangBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents TransaksiDataMemberBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents TransaksiDepositMemberBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents TransaksiMemberGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents PembelianBarangSupplierBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents PembeliannReturBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents AccountingTerimaTagihanBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganTransaksiKasBankBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents AccountingMenuHeader As DevExpress.XtraBars.Ribbon.RibbonPage
  Friend WithEvents KeuanganFinanceGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents KeuanganGroupAkunBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganCOABtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganJurnalBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganAccountingGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
  Friend WithEvents KeuanganBukaTutupPeriode As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganLaporanNeracaBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganLaporanRugiLabaBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents KeuanganLaporanLedgerBtn As DevExpress.XtraBars.BarButtonItem
  Friend WithEvents InventoryDaftarStorageBtn As DevExpress.XtraBars.BarButtonItem
End Class
