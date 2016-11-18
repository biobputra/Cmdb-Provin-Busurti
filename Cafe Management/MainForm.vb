Imports System.ComponentModel
Imports System.Text


Partial Public Class MainForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub PosMenuJenisMeja_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TransaksiJenisMejaBtn.ItemClick
        If Me.MdiChildren.Contains(FormJenisMeja) Then
            FormJenisMeja.Focus()
        Else
            'FormJenisMeja.MdiParent = Me
            FormJenisMeja.ShowDialog()
        End If
    End Sub

    Private Sub PosMenuDaftarMeja_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TransaksiDaftarMejaBtn.ItemClick
        If Me.MdiChildren.Contains(FormDaftarMeja) Then
            FormDaftarMeja.Focus()
        Else
            'FormDaftarMeja.MdiParent = Me
            FormDaftarMeja.ShowDialog()
        End If
    End Sub

    Private Sub InventoryMenuSatuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventorySatuanBtn.ItemClick
        If Me.MdiChildren.Contains(FormSatuan) Then
            FormSatuan.Focus()
        Else
            'FormSatuan.MdiParent = Me
            FormSatuan.ShowDialog()
        End If
    End Sub

    Private Sub InventoryMenuJenisBarang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryJenisBarangBtn.ItemClick
        If Me.MdiChildren.Contains(FormJenisBarang) Then
            FormJenisBarang.Focus()
        Else
            'FormJenisBarang.MdiParent = Me
            FormJenisBarang.ShowDialog()
        End If
    End Sub

    Private Sub InventoryMenuBarang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryDaftarBarangBtn.ItemClick
        If Me.MdiChildren.Contains(FormBarang) Then
            FormBarang.Focus()
        Else
            'FormBarang.MdiParent = Me
            FormBarang.ShowDialog()
        End If
    End Sub



    Private Sub PosMenuPenjualan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TransaksiPOSBtn.ItemClick
        If Me.MdiChildren.Contains(FormPOS) Then
            FormPOS.Focus()
        Else
            FormPOS.MdiParent = Me
            FormPOS.Show()
        End If
    End Sub

    Private Sub PembelianSupplierBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PembelianSupplierBtn.ItemClick
        If Me.MdiChildren.Contains(FormSupplier) Then
            FormSupplier.Focus()
        Else
            FormSupplier.MdiParent = Me
            FormSupplier.Show()
        End If
    End Sub
    Private Sub KeuanganMenuTermOfPaymentBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles KeuanganMenuTermOfPaymentBtn.ItemClick
        If Me.MdiChildren.Contains(FormTermOfPayment) Then
            FormTermOfPayment.Focus()
        Else
            'FormTermOfPayment.MdiParent = Me
            FormTermOfPayment.ShowDialog()
        End If
    End Sub
    Private Sub KeuanganCOABtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles KeuanganCOABtn.ItemClick
        FormAccountingCOA.Show()
    End Sub

    Private Sub KeuanganGroupAkunBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles KeuanganGroupAkunBtn.ItemClick
        FormAccountingGroupAkun.Show()

    End Sub
    Private Sub PembelianBarangSupplierBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PembelianBarangSupplierBtn.ItemClick
        If Me.MdiChildren.Contains(FormProductSupplier) Then
            FormProductSupplier.Focus()
        Else
            'FormProductSupplier.MdiParent = Me
            FormProductSupplier.ShowDialog()
        End If
    End Sub

    Private Sub SettingsTitleBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SettingsTitleBtn.ItemClick
        If Me.MdiChildren.Contains(FormTitle) Then
            FormTitle.Focus()
        Else
            'FormTitle.MdiParent = Me
            FormTitle.ShowDialog()
        End If
    End Sub

    Private Sub SettingsJenisIdentitasBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles SettingsJenisIdentitasBtn.ItemClick
        If Me.MdiChildren.Contains(FormJenisIdentitas) Then
            FormJenisIdentitas.Focus()
        Else
            'FormJenisIdentitas.MdiParent = Me
            FormJenisIdentitas.ShowDialog()
        End If
    End Sub

    Private Sub PembelianPembelianBtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PembelianPembelianBtn.ItemClick
        If Me.MdiChildren.Contains(FormTraPembelian) Then
            FormTraPembelian.Focus()
        Else
            FormTraPembelian.MdiParent = Me
            FormTraPembelian.Show()
        End If
    End Sub
End Class

