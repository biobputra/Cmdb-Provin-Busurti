<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKaryawan
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKaryawan))
    Me.DataSetHRD = New Cafe_Management.DataSetHRD()
    Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.KaryawanTableAdapter = New Cafe_Management.DataSetHRDTableAdapters.KaryawanTableAdapter()
    Me.TableAdapterManager = New Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager()
    Me.KaryawanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
    Me.KaryawanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
    Me.MainSplit = New DevExpress.XtraEditors.SplitContainerControl()
    Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
    Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
    Me.IDKaryawanTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForIDKaryawan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.NamaLengkapTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForNamaLengkap = New DevExpress.XtraLayout.LayoutControlItem()
    Me.NoKTPTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForNoKTP = New DevExpress.XtraLayout.LayoutControlItem()
    Me.TempatLahirTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForTempatLahir = New DevExpress.XtraLayout.LayoutControlItem()
    Me.TanggallahirDateEdit = New DevExpress.XtraEditors.DateEdit()
    Me.ItemForTanggallahir = New DevExpress.XtraLayout.LayoutControlItem()
    Me.JenisKelaminComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
    Me.ItemForJenisKelamin = New DevExpress.XtraLayout.LayoutControlItem()
    Me.AlamatMemoEdit = New DevExpress.XtraEditors.MemoEdit()
    Me.ItemForAlamat = New DevExpress.XtraLayout.LayoutControlItem()
    Me.NoTelponTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForNoTelpon = New DevExpress.XtraLayout.LayoutControlItem()
    Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForEmail = New DevExpress.XtraLayout.LayoutControlItem()
    Me.IDStatusPernikahanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.ItemForIDStatusPernikahan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.FotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
    Me.ItemForFoto = New DevExpress.XtraLayout.LayoutControlItem()
    Me.IDDivisiLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.ItemForIDDivisi = New DevExpress.XtraLayout.LayoutControlItem()
    Me.IDJabatanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.ItemForIDJabatan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.TanggalMulaiBekerjaDateEdit = New DevExpress.XtraEditors.DateEdit()
    Me.ItemForTanggalMulaiBekerja = New DevExpress.XtraLayout.LayoutControlItem()
    Me.IDStatusKaryawanLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.ItemForIDStatusKaryawan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.GajiPokokTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForGajiPokok = New DevExpress.XtraLayout.LayoutControlItem()
    Me.IDIntervalGajiLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
    Me.ItemForIDIntervalGaji = New DevExpress.XtraLayout.LayoutControlItem()
    Me.TotalTunjanganTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForTotalTunjangan = New DevExpress.XtraLayout.LayoutControlItem()
    Me.PotonganPajakTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForPotonganPajak = New DevExpress.XtraLayout.LayoutControlItem()
    Me.StatusAktifCheckEdit = New DevExpress.XtraEditors.CheckEdit()
    Me.ItemForStatusAktif = New DevExpress.XtraLayout.LayoutControlItem()
    Me.CreatedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
    Me.ItemForCreatedDate = New DevExpress.XtraLayout.LayoutControlItem()
    Me.CreatedByTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForCreatedBy = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ModifiedDateDateEdit = New DevExpress.XtraEditors.DateEdit()
    Me.ItemForModifiedDate = New DevExpress.XtraLayout.LayoutControlItem()
    Me.ModifiedByTextEdit = New DevExpress.XtraEditors.TextEdit()
    Me.ItemForModifiedBy = New DevExpress.XtraLayout.LayoutControlItem()
    Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
    Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
    Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
    CType(Me.DataSetHRD, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.KaryawanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.KaryawanBindingNavigator.SuspendLayout()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.MainSplit.SuspendLayout()
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.DataLayoutControl1.SuspendLayout()
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDKaryawanTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NamaLengkapTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNamaLengkap, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NoKTPTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNoKTP, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TempatLahirTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForTempatLahir, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TanggallahirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TanggallahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForTanggallahir, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.JenisKelaminComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForJenisKelamin, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.AlamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForAlamat, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NoTelponTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForNoTelpon, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDStatusPernikahanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDStatusPernikahan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.FotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForFoto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDDivisiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDJabatanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDJabatan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TanggalMulaiBekerjaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TanggalMulaiBekerjaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForTanggalMulaiBekerja, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDStatusKaryawanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDStatusKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.GajiPokokTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForGajiPokok, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.IDIntervalGajiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForIDIntervalGaji, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TotalTunjanganTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForTotalTunjangan, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PotonganPajakTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForPotonganPajak, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.StatusAktifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForStatusAktif, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CreatedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'KaryawanBindingSource
    '
    Me.KaryawanBindingSource.DataMember = "Karyawan"
    Me.KaryawanBindingSource.DataSource = Me.DataSetHRD
    '
    'KaryawanTableAdapter
    '
    Me.KaryawanTableAdapter.ClearBeforeFill = True
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
    Me.TableAdapterManager.KaryawanTableAdapter = Me.KaryawanTableAdapter
    Me.TableAdapterManager.PerubahanShiftTableAdapter = Nothing
    Me.TableAdapterManager.StatusKaryawanTableAdapter = Nothing
    Me.TableAdapterManager.StatusPernikahanTableAdapter = Nothing
    Me.TableAdapterManager.UpdateOrder = Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
    '
    'KaryawanBindingNavigator
    '
    Me.KaryawanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
    Me.KaryawanBindingNavigator.BindingSource = Me.KaryawanBindingSource
    Me.KaryawanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
    Me.KaryawanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
    Me.KaryawanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.KaryawanBindingNavigatorSaveItem})
    Me.KaryawanBindingNavigator.Location = New System.Drawing.Point(0, 0)
    Me.KaryawanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
    Me.KaryawanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
    Me.KaryawanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
    Me.KaryawanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
    Me.KaryawanBindingNavigator.Name = "KaryawanBindingNavigator"
    Me.KaryawanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
    Me.KaryawanBindingNavigator.Size = New System.Drawing.Size(647, 25)
    Me.KaryawanBindingNavigator.TabIndex = 0
    Me.KaryawanBindingNavigator.Text = "BindingNavigator1"
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
    'KaryawanBindingNavigatorSaveItem
    '
    Me.KaryawanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.KaryawanBindingNavigatorSaveItem.Image = CType(resources.GetObject("KaryawanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
    Me.KaryawanBindingNavigatorSaveItem.Name = "KaryawanBindingNavigatorSaveItem"
    Me.KaryawanBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
    Me.KaryawanBindingNavigatorSaveItem.Text = "Save Data"
    '
    'MainSplit
    '
    Me.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill
    Me.MainSplit.Horizontal = False
    Me.MainSplit.Location = New System.Drawing.Point(0, 25)
    Me.MainSplit.Name = "MainSplit"
    Me.MainSplit.Panel1.Controls.Add(Me.DataLayoutControl1)
    Me.MainSplit.Panel1.Text = "Panel1"
    Me.MainSplit.Panel2.Text = "Panel2"
    Me.MainSplit.Size = New System.Drawing.Size(647, 366)
    Me.MainSplit.SplitterPosition = 339
    Me.MainSplit.TabIndex = 1
    Me.MainSplit.Text = "SplitContainerControl1"
    '
    'DataLayoutControl1
    '
    Me.DataLayoutControl1.Controls.Add(Me.GridControl1)
    Me.DataLayoutControl1.Controls.Add(Me.IDKaryawanTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NamaLengkapTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NoKTPTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.TempatLahirTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.TanggallahirDateEdit)
    Me.DataLayoutControl1.Controls.Add(Me.JenisKelaminComboBoxEdit)
    Me.DataLayoutControl1.Controls.Add(Me.AlamatMemoEdit)
    Me.DataLayoutControl1.Controls.Add(Me.NoTelponTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.EmailTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.IDStatusPernikahanLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.FotoPictureEdit)
    Me.DataLayoutControl1.Controls.Add(Me.IDDivisiLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.IDJabatanLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.TanggalMulaiBekerjaDateEdit)
    Me.DataLayoutControl1.Controls.Add(Me.IDStatusKaryawanLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.GajiPokokTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.IDIntervalGajiLookUpEdit)
    Me.DataLayoutControl1.Controls.Add(Me.TotalTunjanganTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.PotonganPajakTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.StatusAktifCheckEdit)
    Me.DataLayoutControl1.Controls.Add(Me.CreatedDateDateEdit)
    Me.DataLayoutControl1.Controls.Add(Me.CreatedByTextEdit)
    Me.DataLayoutControl1.Controls.Add(Me.ModifiedDateDateEdit)
    Me.DataLayoutControl1.Controls.Add(Me.ModifiedByTextEdit)
    Me.DataLayoutControl1.DataSource = Me.KaryawanBindingSource
    Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
    Me.DataLayoutControl1.Name = "DataLayoutControl1"
    Me.DataLayoutControl1.Root = Me.LayoutControlGroup1
    Me.DataLayoutControl1.Size = New System.Drawing.Size(647, 339)
    Me.DataLayoutControl1.TabIndex = 0
    Me.DataLayoutControl1.Text = "DataLayoutControl1"
    '
    'LayoutControlGroup1
    '
    Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
    Me.LayoutControlGroup1.GroupBordersVisible = False
    Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
    Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
    Me.LayoutControlGroup1.Size = New System.Drawing.Size(630, 591)
    Me.LayoutControlGroup1.TextVisible = False
    '
    'LayoutControlGroup2
    '
    Me.LayoutControlGroup2.AllowDrawBackground = False
    Me.LayoutControlGroup2.GroupBordersVisible = False
    Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForIDKaryawan, Me.ItemForNamaLengkap, Me.ItemForNoKTP, Me.ItemForTempatLahir, Me.ItemForTanggallahir, Me.ItemForJenisKelamin, Me.ItemForAlamat, Me.ItemForNoTelpon, Me.ItemForEmail, Me.ItemForIDStatusPernikahan, Me.ItemForFoto, Me.ItemForIDDivisi, Me.ItemForIDJabatan, Me.ItemForTanggalMulaiBekerja, Me.ItemForIDStatusKaryawan, Me.ItemForGajiPokok, Me.ItemForIDIntervalGaji, Me.ItemForTotalTunjangan, Me.ItemForPotonganPajak, Me.ItemForStatusAktif, Me.ItemForCreatedDate, Me.ItemForCreatedBy, Me.ItemForModifiedDate, Me.ItemForModifiedBy, Me.LayoutControlItem1})
    Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
    Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
    Me.LayoutControlGroup2.Size = New System.Drawing.Size(610, 571)
    '
    'IDKaryawanTextEdit
    '
    Me.IDKaryawanTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "IDKaryawan", True))
    Me.IDKaryawanTextEdit.Location = New System.Drawing.Point(120, 12)
    Me.IDKaryawanTextEdit.Name = "IDKaryawanTextEdit"
    Me.IDKaryawanTextEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDKaryawanTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDKaryawanTextEdit.Properties.Mask.EditMask = "N0"
    Me.IDKaryawanTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.IDKaryawanTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.IDKaryawanTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.IDKaryawanTextEdit.StyleController = Me.DataLayoutControl1
    Me.IDKaryawanTextEdit.TabIndex = 4
    '
    'ItemForIDKaryawan
    '
    Me.ItemForIDKaryawan.Control = Me.IDKaryawanTextEdit
    Me.ItemForIDKaryawan.Location = New System.Drawing.Point(0, 0)
    Me.ItemForIDKaryawan.Name = "ItemForIDKaryawan"
    Me.ItemForIDKaryawan.Size = New System.Drawing.Size(506, 24)
    Me.ItemForIDKaryawan.Text = "ID Karyawan"
    Me.ItemForIDKaryawan.TextSize = New System.Drawing.Size(104, 13)
    '
    'NamaLengkapTextEdit
    '
    Me.NamaLengkapTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "NamaLengkap", True))
    Me.NamaLengkapTextEdit.Location = New System.Drawing.Point(120, 36)
    Me.NamaLengkapTextEdit.Name = "NamaLengkapTextEdit"
    Me.NamaLengkapTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.NamaLengkapTextEdit.StyleController = Me.DataLayoutControl1
    Me.NamaLengkapTextEdit.TabIndex = 5
    '
    'ItemForNamaLengkap
    '
    Me.ItemForNamaLengkap.Control = Me.NamaLengkapTextEdit
    Me.ItemForNamaLengkap.Location = New System.Drawing.Point(0, 24)
    Me.ItemForNamaLengkap.Name = "ItemForNamaLengkap"
    Me.ItemForNamaLengkap.Size = New System.Drawing.Size(506, 24)
    Me.ItemForNamaLengkap.Text = "Nama Lengkap"
    Me.ItemForNamaLengkap.TextSize = New System.Drawing.Size(104, 13)
    '
    'NoKTPTextEdit
    '
    Me.NoKTPTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "NoKTP", True))
    Me.NoKTPTextEdit.Location = New System.Drawing.Point(120, 60)
    Me.NoKTPTextEdit.Name = "NoKTPTextEdit"
    Me.NoKTPTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.NoKTPTextEdit.StyleController = Me.DataLayoutControl1
    Me.NoKTPTextEdit.TabIndex = 6
    '
    'ItemForNoKTP
    '
    Me.ItemForNoKTP.Control = Me.NoKTPTextEdit
    Me.ItemForNoKTP.Location = New System.Drawing.Point(0, 48)
    Me.ItemForNoKTP.Name = "ItemForNoKTP"
    Me.ItemForNoKTP.Size = New System.Drawing.Size(506, 24)
    Me.ItemForNoKTP.Text = "No KTP"
    Me.ItemForNoKTP.TextSize = New System.Drawing.Size(104, 13)
    '
    'TempatLahirTextEdit
    '
    Me.TempatLahirTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "TempatLahir", True))
    Me.TempatLahirTextEdit.Location = New System.Drawing.Point(120, 84)
    Me.TempatLahirTextEdit.Name = "TempatLahirTextEdit"
    Me.TempatLahirTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.TempatLahirTextEdit.StyleController = Me.DataLayoutControl1
    Me.TempatLahirTextEdit.TabIndex = 7
    '
    'ItemForTempatLahir
    '
    Me.ItemForTempatLahir.Control = Me.TempatLahirTextEdit
    Me.ItemForTempatLahir.Location = New System.Drawing.Point(0, 72)
    Me.ItemForTempatLahir.Name = "ItemForTempatLahir"
    Me.ItemForTempatLahir.Size = New System.Drawing.Size(506, 24)
    Me.ItemForTempatLahir.Text = "Tempat Lahir"
    Me.ItemForTempatLahir.TextSize = New System.Drawing.Size(104, 13)
    '
    'TanggallahirDateEdit
    '
    Me.TanggallahirDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "Tanggallahir", True))
    Me.TanggallahirDateEdit.EditValue = Nothing
    Me.TanggallahirDateEdit.Location = New System.Drawing.Point(120, 108)
    Me.TanggallahirDateEdit.Name = "TanggallahirDateEdit"
    Me.TanggallahirDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.TanggallahirDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.TanggallahirDateEdit.Size = New System.Drawing.Size(394, 20)
    Me.TanggallahirDateEdit.StyleController = Me.DataLayoutControl1
    Me.TanggallahirDateEdit.TabIndex = 8
    '
    'ItemForTanggallahir
    '
    Me.ItemForTanggallahir.Control = Me.TanggallahirDateEdit
    Me.ItemForTanggallahir.Location = New System.Drawing.Point(0, 96)
    Me.ItemForTanggallahir.Name = "ItemForTanggallahir"
    Me.ItemForTanggallahir.Size = New System.Drawing.Size(506, 24)
    Me.ItemForTanggallahir.Text = "Tanggallahir"
    Me.ItemForTanggallahir.TextSize = New System.Drawing.Size(104, 13)
    '
    'JenisKelaminComboBoxEdit
    '
    Me.JenisKelaminComboBoxEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "JenisKelamin", True))
    Me.JenisKelaminComboBoxEdit.Location = New System.Drawing.Point(120, 132)
    Me.JenisKelaminComboBoxEdit.Name = "JenisKelaminComboBoxEdit"
    Me.JenisKelaminComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.JenisKelaminComboBoxEdit.Size = New System.Drawing.Size(394, 20)
    Me.JenisKelaminComboBoxEdit.StyleController = Me.DataLayoutControl1
    Me.JenisKelaminComboBoxEdit.TabIndex = 9
    '
    'ItemForJenisKelamin
    '
    Me.ItemForJenisKelamin.Control = Me.JenisKelaminComboBoxEdit
    Me.ItemForJenisKelamin.Location = New System.Drawing.Point(0, 120)
    Me.ItemForJenisKelamin.Name = "ItemForJenisKelamin"
    Me.ItemForJenisKelamin.Size = New System.Drawing.Size(506, 24)
    Me.ItemForJenisKelamin.Text = "Jenis Kelamin"
    Me.ItemForJenisKelamin.TextSize = New System.Drawing.Size(104, 13)
    '
    'AlamatMemoEdit
    '
    Me.AlamatMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "Alamat", True))
    Me.AlamatMemoEdit.Location = New System.Drawing.Point(120, 156)
    Me.AlamatMemoEdit.Name = "AlamatMemoEdit"
    Me.AlamatMemoEdit.Size = New System.Drawing.Size(394, 16)
    Me.AlamatMemoEdit.StyleController = Me.DataLayoutControl1
    Me.AlamatMemoEdit.TabIndex = 10
    '
    'ItemForAlamat
    '
    Me.ItemForAlamat.Control = Me.AlamatMemoEdit
    Me.ItemForAlamat.Location = New System.Drawing.Point(0, 144)
    Me.ItemForAlamat.Name = "ItemForAlamat"
    Me.ItemForAlamat.Size = New System.Drawing.Size(506, 20)
    Me.ItemForAlamat.StartNewLine = True
    Me.ItemForAlamat.Text = "Alamat"
    Me.ItemForAlamat.TextSize = New System.Drawing.Size(104, 13)
    '
    'NoTelponTextEdit
    '
    Me.NoTelponTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "NoTelpon", True))
    Me.NoTelponTextEdit.Location = New System.Drawing.Point(120, 176)
    Me.NoTelponTextEdit.Name = "NoTelponTextEdit"
    Me.NoTelponTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.NoTelponTextEdit.StyleController = Me.DataLayoutControl1
    Me.NoTelponTextEdit.TabIndex = 11
    '
    'ItemForNoTelpon
    '
    Me.ItemForNoTelpon.Control = Me.NoTelponTextEdit
    Me.ItemForNoTelpon.Location = New System.Drawing.Point(0, 164)
    Me.ItemForNoTelpon.Name = "ItemForNoTelpon"
    Me.ItemForNoTelpon.Size = New System.Drawing.Size(506, 24)
    Me.ItemForNoTelpon.Text = "No Telpon"
    Me.ItemForNoTelpon.TextSize = New System.Drawing.Size(104, 13)
    '
    'EmailTextEdit
    '
    Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "Email", True))
    Me.EmailTextEdit.Location = New System.Drawing.Point(120, 200)
    Me.EmailTextEdit.Name = "EmailTextEdit"
    Me.EmailTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.EmailTextEdit.StyleController = Me.DataLayoutControl1
    Me.EmailTextEdit.TabIndex = 12
    '
    'ItemForEmail
    '
    Me.ItemForEmail.Control = Me.EmailTextEdit
    Me.ItemForEmail.Location = New System.Drawing.Point(0, 188)
    Me.ItemForEmail.Name = "ItemForEmail"
    Me.ItemForEmail.Size = New System.Drawing.Size(506, 24)
    Me.ItemForEmail.Text = "Email"
    Me.ItemForEmail.TextSize = New System.Drawing.Size(104, 13)
    '
    'IDStatusPernikahanLookUpEdit
    '
    Me.IDStatusPernikahanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "IDStatusPernikahan", True))
    Me.IDStatusPernikahanLookUpEdit.Location = New System.Drawing.Point(120, 224)
    Me.IDStatusPernikahanLookUpEdit.Name = "IDStatusPernikahanLookUpEdit"
    Me.IDStatusPernikahanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDStatusPernikahanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDStatusPernikahanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDStatusPernikahanLookUpEdit.Properties.NullText = ""
    Me.IDStatusPernikahanLookUpEdit.Size = New System.Drawing.Size(394, 20)
    Me.IDStatusPernikahanLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDStatusPernikahanLookUpEdit.TabIndex = 13
    '
    'ItemForIDStatusPernikahan
    '
    Me.ItemForIDStatusPernikahan.Control = Me.IDStatusPernikahanLookUpEdit
    Me.ItemForIDStatusPernikahan.Location = New System.Drawing.Point(0, 212)
    Me.ItemForIDStatusPernikahan.Name = "ItemForIDStatusPernikahan"
    Me.ItemForIDStatusPernikahan.Size = New System.Drawing.Size(506, 24)
    Me.ItemForIDStatusPernikahan.Text = "ID Status Pernikahan"
    Me.ItemForIDStatusPernikahan.TextSize = New System.Drawing.Size(104, 13)
    '
    'FotoPictureEdit
    '
    Me.FotoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "Foto", True))
    Me.FotoPictureEdit.Location = New System.Drawing.Point(120, 248)
    Me.FotoPictureEdit.Name = "FotoPictureEdit"
    Me.FotoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
    Me.FotoPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
    Me.FotoPictureEdit.Size = New System.Drawing.Size(394, 20)
    Me.FotoPictureEdit.StyleController = Me.DataLayoutControl1
    Me.FotoPictureEdit.TabIndex = 14
    '
    'ItemForFoto
    '
    Me.ItemForFoto.Control = Me.FotoPictureEdit
    Me.ItemForFoto.Location = New System.Drawing.Point(0, 236)
    Me.ItemForFoto.Name = "ItemForFoto"
    Me.ItemForFoto.Size = New System.Drawing.Size(506, 24)
    Me.ItemForFoto.StartNewLine = True
    Me.ItemForFoto.Text = "Foto"
    Me.ItemForFoto.TextSize = New System.Drawing.Size(104, 13)
    '
    'IDDivisiLookUpEdit
    '
    Me.IDDivisiLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "IDDivisi", True))
    Me.IDDivisiLookUpEdit.Location = New System.Drawing.Point(120, 272)
    Me.IDDivisiLookUpEdit.Name = "IDDivisiLookUpEdit"
    Me.IDDivisiLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDDivisiLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDDivisiLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDDivisiLookUpEdit.Properties.NullText = ""
    Me.IDDivisiLookUpEdit.Size = New System.Drawing.Size(394, 20)
    Me.IDDivisiLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDDivisiLookUpEdit.TabIndex = 15
    '
    'ItemForIDDivisi
    '
    Me.ItemForIDDivisi.Control = Me.IDDivisiLookUpEdit
    Me.ItemForIDDivisi.Location = New System.Drawing.Point(0, 260)
    Me.ItemForIDDivisi.Name = "ItemForIDDivisi"
    Me.ItemForIDDivisi.Size = New System.Drawing.Size(506, 24)
    Me.ItemForIDDivisi.Text = "ID Divisi"
    Me.ItemForIDDivisi.TextSize = New System.Drawing.Size(104, 13)
    '
    'IDJabatanLookUpEdit
    '
    Me.IDJabatanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "IDJabatan", True))
    Me.IDJabatanLookUpEdit.Location = New System.Drawing.Point(120, 296)
    Me.IDJabatanLookUpEdit.Name = "IDJabatanLookUpEdit"
    Me.IDJabatanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDJabatanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDJabatanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDJabatanLookUpEdit.Properties.NullText = ""
    Me.IDJabatanLookUpEdit.Size = New System.Drawing.Size(394, 20)
    Me.IDJabatanLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDJabatanLookUpEdit.TabIndex = 16
    '
    'ItemForIDJabatan
    '
    Me.ItemForIDJabatan.Control = Me.IDJabatanLookUpEdit
    Me.ItemForIDJabatan.Location = New System.Drawing.Point(0, 284)
    Me.ItemForIDJabatan.Name = "ItemForIDJabatan"
    Me.ItemForIDJabatan.Size = New System.Drawing.Size(506, 24)
    Me.ItemForIDJabatan.Text = "ID Jabatan"
    Me.ItemForIDJabatan.TextSize = New System.Drawing.Size(104, 13)
    '
    'TanggalMulaiBekerjaDateEdit
    '
    Me.TanggalMulaiBekerjaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "TanggalMulaiBekerja", True))
    Me.TanggalMulaiBekerjaDateEdit.EditValue = Nothing
    Me.TanggalMulaiBekerjaDateEdit.Location = New System.Drawing.Point(120, 320)
    Me.TanggalMulaiBekerjaDateEdit.Name = "TanggalMulaiBekerjaDateEdit"
    Me.TanggalMulaiBekerjaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.TanggalMulaiBekerjaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.TanggalMulaiBekerjaDateEdit.Size = New System.Drawing.Size(394, 20)
    Me.TanggalMulaiBekerjaDateEdit.StyleController = Me.DataLayoutControl1
    Me.TanggalMulaiBekerjaDateEdit.TabIndex = 17
    '
    'ItemForTanggalMulaiBekerja
    '
    Me.ItemForTanggalMulaiBekerja.Control = Me.TanggalMulaiBekerjaDateEdit
    Me.ItemForTanggalMulaiBekerja.Location = New System.Drawing.Point(0, 308)
    Me.ItemForTanggalMulaiBekerja.Name = "ItemForTanggalMulaiBekerja"
    Me.ItemForTanggalMulaiBekerja.Size = New System.Drawing.Size(506, 24)
    Me.ItemForTanggalMulaiBekerja.Text = "Tanggal Mulai Bekerja"
    Me.ItemForTanggalMulaiBekerja.TextSize = New System.Drawing.Size(104, 13)
    '
    'IDStatusKaryawanLookUpEdit
    '
    Me.IDStatusKaryawanLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "IDStatusKaryawan", True))
    Me.IDStatusKaryawanLookUpEdit.Location = New System.Drawing.Point(120, 344)
    Me.IDStatusKaryawanLookUpEdit.Name = "IDStatusKaryawanLookUpEdit"
    Me.IDStatusKaryawanLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDStatusKaryawanLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDStatusKaryawanLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDStatusKaryawanLookUpEdit.Properties.NullText = ""
    Me.IDStatusKaryawanLookUpEdit.Size = New System.Drawing.Size(394, 20)
    Me.IDStatusKaryawanLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDStatusKaryawanLookUpEdit.TabIndex = 18
    '
    'ItemForIDStatusKaryawan
    '
    Me.ItemForIDStatusKaryawan.Control = Me.IDStatusKaryawanLookUpEdit
    Me.ItemForIDStatusKaryawan.Location = New System.Drawing.Point(0, 332)
    Me.ItemForIDStatusKaryawan.Name = "ItemForIDStatusKaryawan"
    Me.ItemForIDStatusKaryawan.Size = New System.Drawing.Size(506, 24)
    Me.ItemForIDStatusKaryawan.Text = "ID Status Karyawan"
    Me.ItemForIDStatusKaryawan.TextSize = New System.Drawing.Size(104, 13)
    '
    'GajiPokokTextEdit
    '
    Me.GajiPokokTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "GajiPokok", True))
    Me.GajiPokokTextEdit.Location = New System.Drawing.Point(120, 368)
    Me.GajiPokokTextEdit.Name = "GajiPokokTextEdit"
    Me.GajiPokokTextEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.GajiPokokTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.GajiPokokTextEdit.Properties.Mask.EditMask = "G"
    Me.GajiPokokTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.GajiPokokTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.GajiPokokTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.GajiPokokTextEdit.StyleController = Me.DataLayoutControl1
    Me.GajiPokokTextEdit.TabIndex = 19
    '
    'ItemForGajiPokok
    '
    Me.ItemForGajiPokok.Control = Me.GajiPokokTextEdit
    Me.ItemForGajiPokok.Location = New System.Drawing.Point(0, 356)
    Me.ItemForGajiPokok.Name = "ItemForGajiPokok"
    Me.ItemForGajiPokok.Size = New System.Drawing.Size(506, 24)
    Me.ItemForGajiPokok.Text = "Gaji Pokok"
    Me.ItemForGajiPokok.TextSize = New System.Drawing.Size(104, 13)
    '
    'IDIntervalGajiLookUpEdit
    '
    Me.IDIntervalGajiLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "IDIntervalGaji", True))
    Me.IDIntervalGajiLookUpEdit.Location = New System.Drawing.Point(120, 392)
    Me.IDIntervalGajiLookUpEdit.Name = "IDIntervalGajiLookUpEdit"
    Me.IDIntervalGajiLookUpEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.IDIntervalGajiLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.IDIntervalGajiLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.IDIntervalGajiLookUpEdit.Properties.NullText = ""
    Me.IDIntervalGajiLookUpEdit.Size = New System.Drawing.Size(394, 20)
    Me.IDIntervalGajiLookUpEdit.StyleController = Me.DataLayoutControl1
    Me.IDIntervalGajiLookUpEdit.TabIndex = 20
    '
    'ItemForIDIntervalGaji
    '
    Me.ItemForIDIntervalGaji.Control = Me.IDIntervalGajiLookUpEdit
    Me.ItemForIDIntervalGaji.Location = New System.Drawing.Point(0, 380)
    Me.ItemForIDIntervalGaji.Name = "ItemForIDIntervalGaji"
    Me.ItemForIDIntervalGaji.Size = New System.Drawing.Size(506, 24)
    Me.ItemForIDIntervalGaji.Text = "ID Interval Gaji"
    Me.ItemForIDIntervalGaji.TextSize = New System.Drawing.Size(104, 13)
    '
    'TotalTunjanganTextEdit
    '
    Me.TotalTunjanganTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "TotalTunjangan", True))
    Me.TotalTunjanganTextEdit.Location = New System.Drawing.Point(120, 416)
    Me.TotalTunjanganTextEdit.Name = "TotalTunjanganTextEdit"
    Me.TotalTunjanganTextEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.TotalTunjanganTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.TotalTunjanganTextEdit.Properties.Mask.EditMask = "G"
    Me.TotalTunjanganTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.TotalTunjanganTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.TotalTunjanganTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.TotalTunjanganTextEdit.StyleController = Me.DataLayoutControl1
    Me.TotalTunjanganTextEdit.TabIndex = 21
    '
    'ItemForTotalTunjangan
    '
    Me.ItemForTotalTunjangan.Control = Me.TotalTunjanganTextEdit
    Me.ItemForTotalTunjangan.Location = New System.Drawing.Point(0, 404)
    Me.ItemForTotalTunjangan.Name = "ItemForTotalTunjangan"
    Me.ItemForTotalTunjangan.Size = New System.Drawing.Size(506, 24)
    Me.ItemForTotalTunjangan.Text = "Total Tunjangan"
    Me.ItemForTotalTunjangan.TextSize = New System.Drawing.Size(104, 13)
    '
    'PotonganPajakTextEdit
    '
    Me.PotonganPajakTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "PotonganPajak", True))
    Me.PotonganPajakTextEdit.Location = New System.Drawing.Point(120, 440)
    Me.PotonganPajakTextEdit.Name = "PotonganPajakTextEdit"
    Me.PotonganPajakTextEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.PotonganPajakTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.PotonganPajakTextEdit.Properties.Mask.EditMask = "G"
    Me.PotonganPajakTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.PotonganPajakTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.PotonganPajakTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.PotonganPajakTextEdit.StyleController = Me.DataLayoutControl1
    Me.PotonganPajakTextEdit.TabIndex = 22
    '
    'ItemForPotonganPajak
    '
    Me.ItemForPotonganPajak.Control = Me.PotonganPajakTextEdit
    Me.ItemForPotonganPajak.Location = New System.Drawing.Point(0, 428)
    Me.ItemForPotonganPajak.Name = "ItemForPotonganPajak"
    Me.ItemForPotonganPajak.Size = New System.Drawing.Size(506, 24)
    Me.ItemForPotonganPajak.Text = "Potongan Pajak"
    Me.ItemForPotonganPajak.TextSize = New System.Drawing.Size(104, 13)
    '
    'StatusAktifCheckEdit
    '
    Me.StatusAktifCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "StatusAktif", True))
    Me.StatusAktifCheckEdit.Location = New System.Drawing.Point(120, 464)
    Me.StatusAktifCheckEdit.Name = "StatusAktifCheckEdit"
    Me.StatusAktifCheckEdit.Properties.Caption = "Status Aktif"
    Me.StatusAktifCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.StatusAktifCheckEdit.Size = New System.Drawing.Size(394, 19)
    Me.StatusAktifCheckEdit.StyleController = Me.DataLayoutControl1
    Me.StatusAktifCheckEdit.TabIndex = 23
    '
    'ItemForStatusAktif
    '
    Me.ItemForStatusAktif.Control = Me.StatusAktifCheckEdit
    Me.ItemForStatusAktif.Location = New System.Drawing.Point(0, 452)
    Me.ItemForStatusAktif.Name = "ItemForStatusAktif"
    Me.ItemForStatusAktif.Size = New System.Drawing.Size(506, 23)
    Me.ItemForStatusAktif.Text = "Status Aktif"
    Me.ItemForStatusAktif.TextSize = New System.Drawing.Size(104, 13)
    '
    'CreatedDateDateEdit
    '
    Me.CreatedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "CreatedDate", True))
    Me.CreatedDateDateEdit.EditValue = Nothing
    Me.CreatedDateDateEdit.Location = New System.Drawing.Point(120, 487)
    Me.CreatedDateDateEdit.Name = "CreatedDateDateEdit"
    Me.CreatedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.CreatedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.CreatedDateDateEdit.Size = New System.Drawing.Size(394, 20)
    Me.CreatedDateDateEdit.StyleController = Me.DataLayoutControl1
    Me.CreatedDateDateEdit.TabIndex = 24
    '
    'ItemForCreatedDate
    '
    Me.ItemForCreatedDate.Control = Me.CreatedDateDateEdit
    Me.ItemForCreatedDate.Location = New System.Drawing.Point(0, 475)
    Me.ItemForCreatedDate.Name = "ItemForCreatedDate"
    Me.ItemForCreatedDate.Size = New System.Drawing.Size(506, 24)
    Me.ItemForCreatedDate.Text = "Created Date"
    Me.ItemForCreatedDate.TextSize = New System.Drawing.Size(104, 13)
    '
    'CreatedByTextEdit
    '
    Me.CreatedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "CreatedBy", True))
    Me.CreatedByTextEdit.Location = New System.Drawing.Point(120, 511)
    Me.CreatedByTextEdit.Name = "CreatedByTextEdit"
    Me.CreatedByTextEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.CreatedByTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.CreatedByTextEdit.Properties.Mask.EditMask = "N0"
    Me.CreatedByTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.CreatedByTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.CreatedByTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.CreatedByTextEdit.StyleController = Me.DataLayoutControl1
    Me.CreatedByTextEdit.TabIndex = 25
    '
    'ItemForCreatedBy
    '
    Me.ItemForCreatedBy.Control = Me.CreatedByTextEdit
    Me.ItemForCreatedBy.Location = New System.Drawing.Point(0, 499)
    Me.ItemForCreatedBy.Name = "ItemForCreatedBy"
    Me.ItemForCreatedBy.Size = New System.Drawing.Size(506, 24)
    Me.ItemForCreatedBy.Text = "Created By"
    Me.ItemForCreatedBy.TextSize = New System.Drawing.Size(104, 13)
    '
    'ModifiedDateDateEdit
    '
    Me.ModifiedDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "ModifiedDate", True))
    Me.ModifiedDateDateEdit.EditValue = Nothing
    Me.ModifiedDateDateEdit.Location = New System.Drawing.Point(120, 535)
    Me.ModifiedDateDateEdit.Name = "ModifiedDateDateEdit"
    Me.ModifiedDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.ModifiedDateDateEdit.Size = New System.Drawing.Size(394, 20)
    Me.ModifiedDateDateEdit.StyleController = Me.DataLayoutControl1
    Me.ModifiedDateDateEdit.TabIndex = 26
    '
    'ItemForModifiedDate
    '
    Me.ItemForModifiedDate.Control = Me.ModifiedDateDateEdit
    Me.ItemForModifiedDate.Location = New System.Drawing.Point(0, 523)
    Me.ItemForModifiedDate.Name = "ItemForModifiedDate"
    Me.ItemForModifiedDate.Size = New System.Drawing.Size(506, 24)
    Me.ItemForModifiedDate.Text = "Modified Date"
    Me.ItemForModifiedDate.TextSize = New System.Drawing.Size(104, 13)
    '
    'ModifiedByTextEdit
    '
    Me.ModifiedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KaryawanBindingSource, "ModifiedBy", True))
    Me.ModifiedByTextEdit.Location = New System.Drawing.Point(120, 559)
    Me.ModifiedByTextEdit.Name = "ModifiedByTextEdit"
    Me.ModifiedByTextEdit.Properties.Appearance.Options.UseTextOptions = True
    Me.ModifiedByTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    Me.ModifiedByTextEdit.Properties.Mask.EditMask = "N0"
    Me.ModifiedByTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
    Me.ModifiedByTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
    Me.ModifiedByTextEdit.Size = New System.Drawing.Size(394, 20)
    Me.ModifiedByTextEdit.StyleController = Me.DataLayoutControl1
    Me.ModifiedByTextEdit.TabIndex = 27
    '
    'ItemForModifiedBy
    '
    Me.ItemForModifiedBy.Control = Me.ModifiedByTextEdit
    Me.ItemForModifiedBy.Location = New System.Drawing.Point(0, 547)
    Me.ItemForModifiedBy.Name = "ItemForModifiedBy"
    Me.ItemForModifiedBy.Size = New System.Drawing.Size(506, 24)
    Me.ItemForModifiedBy.Text = "Modified By"
    Me.ItemForModifiedBy.TextSize = New System.Drawing.Size(104, 13)
    '
    'GridControl1
    '
    Me.GridControl1.Location = New System.Drawing.Point(518, 12)
    Me.GridControl1.MainView = Me.GridView1
    Me.GridControl1.Name = "GridControl1"
    Me.GridControl1.Size = New System.Drawing.Size(100, 567)
    Me.GridControl1.TabIndex = 28
    Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
    '
    'GridView1
    '
    Me.GridView1.GridControl = Me.GridControl1
    Me.GridView1.Name = "GridView1"
    '
    'LayoutControlItem1
    '
    Me.LayoutControlItem1.Control = Me.GridControl1
    Me.LayoutControlItem1.Location = New System.Drawing.Point(506, 0)
    Me.LayoutControlItem1.Name = "LayoutControlItem1"
    Me.LayoutControlItem1.Size = New System.Drawing.Size(104, 571)
    Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
    Me.LayoutControlItem1.TextVisible = False
    '
    'FormKaryawan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(647, 391)
    Me.Controls.Add(Me.MainSplit)
    Me.Controls.Add(Me.KaryawanBindingNavigator)
    Me.Name = "FormKaryawan"
    Me.Text = "FormKaryawan"
    CType(Me.DataSetHRD, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.KaryawanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
    Me.KaryawanBindingNavigator.ResumeLayout(False)
    Me.KaryawanBindingNavigator.PerformLayout()
    CType(Me.MainSplit, System.ComponentModel.ISupportInitialize).EndInit()
    Me.MainSplit.ResumeLayout(False)
    CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.DataLayoutControl1.ResumeLayout(False)
    CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDKaryawanTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NamaLengkapTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNamaLengkap, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NoKTPTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNoKTP, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TempatLahirTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForTempatLahir, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TanggallahirDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TanggallahirDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForTanggallahir, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.JenisKelaminComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForJenisKelamin, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.AlamatMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForAlamat, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NoTelponTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForNoTelpon, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForEmail, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDStatusPernikahanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDStatusPernikahan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.FotoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForFoto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDDivisiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDDivisi, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDJabatanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDJabatan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TanggalMulaiBekerjaDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TanggalMulaiBekerjaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForTanggalMulaiBekerja, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDStatusKaryawanLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDStatusKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GajiPokokTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForGajiPokok, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.IDIntervalGajiLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForIDIntervalGaji, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TotalTunjanganTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForTotalTunjangan, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PotonganPajakTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForPotonganPajak, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.StatusAktifCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForStatusAktif, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CreatedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CreatedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForCreatedDate, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.CreatedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForCreatedBy, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ModifiedDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ModifiedDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForModifiedDate, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ModifiedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ItemForModifiedBy, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataSetHRD As Cafe_Management.DataSetHRD
  Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents KaryawanTableAdapter As Cafe_Management.DataSetHRDTableAdapters.KaryawanTableAdapter
  Friend WithEvents TableAdapterManager As Cafe_Management.DataSetHRDTableAdapters.TableAdapterManager
  Friend WithEvents KaryawanBindingNavigator As System.Windows.Forms.BindingNavigator
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
  Friend WithEvents KaryawanBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
  Friend WithEvents MainSplit As DevExpress.XtraEditors.SplitContainerControl
  Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
  Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
  Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
  Friend WithEvents IDKaryawanTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents NamaLengkapTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents NoKTPTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents TempatLahirTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents TanggallahirDateEdit As DevExpress.XtraEditors.DateEdit
  Friend WithEvents JenisKelaminComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
  Friend WithEvents AlamatMemoEdit As DevExpress.XtraEditors.MemoEdit
  Friend WithEvents NoTelponTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents IDStatusPernikahanLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents FotoPictureEdit As DevExpress.XtraEditors.PictureEdit
  Friend WithEvents IDDivisiLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents IDJabatanLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents TanggalMulaiBekerjaDateEdit As DevExpress.XtraEditors.DateEdit
  Friend WithEvents IDStatusKaryawanLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents GajiPokokTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents IDIntervalGajiLookUpEdit As DevExpress.XtraEditors.LookUpEdit
  Friend WithEvents TotalTunjanganTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents PotonganPajakTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents StatusAktifCheckEdit As DevExpress.XtraEditors.CheckEdit
  Friend WithEvents CreatedDateDateEdit As DevExpress.XtraEditors.DateEdit
  Friend WithEvents CreatedByTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents ModifiedDateDateEdit As DevExpress.XtraEditors.DateEdit
  Friend WithEvents ModifiedByTextEdit As DevExpress.XtraEditors.TextEdit
  Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
  Friend WithEvents ItemForIDKaryawan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNamaLengkap As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNoKTP As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForTempatLahir As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForTanggallahir As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForJenisKelamin As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForAlamat As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForNoTelpon As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForEmail As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForIDStatusPernikahan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForFoto As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForIDDivisi As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForIDJabatan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForTanggalMulaiBekerja As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForIDStatusKaryawan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForGajiPokok As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForIDIntervalGaji As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForTotalTunjangan As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForPotonganPajak As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForStatusAktif As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForCreatedDate As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForCreatedBy As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForModifiedDate As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents ItemForModifiedBy As DevExpress.XtraLayout.LayoutControlItem
  Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
