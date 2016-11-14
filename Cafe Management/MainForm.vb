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
    Private Sub PosMenuJenisMeja_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PosMenuJenisMeja.ItemClick
        If Me.MdiChildren.Contains(FormJenisMeja) Then
            FormJenisMeja.Focus()
        Else
            'FormJenisMeja.MdiParent = Me
            FormJenisMeja.ShowDialog()
        End If
    End Sub

    Private Sub PosMenuDaftarMeja_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PosMenuDaftarMeja.ItemClick
        If Me.MdiChildren.Contains(FormDaftarMeja) Then
            FormDaftarMeja.Focus()
        Else
            'FormDaftarMeja.MdiParent = Me
            FormDaftarMeja.ShowDialog()
        End If
    End Sub

    Private Sub InventoryMenuSatuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryMenuSatuan.ItemClick
        If Me.MdiChildren.Contains(FormSatuan) Then
            FormSatuan.Focus()
        Else
            'FormSatuan.MdiParent = Me
            FormSatuan.ShowDialog()
        End If
    End Sub

    Private Sub InventoryMenuJenisBarang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryMenuJenisBarang.ItemClick
        If Me.MdiChildren.Contains(FormJenisBarang) Then
            FormJenisBarang.Focus()
        Else
            'FormJenisBarang.MdiParent = Me
            FormJenisBarang.ShowDialog()
        End If
    End Sub

    Private Sub InventoryMenuBarang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles InventoryMenuBarang.ItemClick
        If Me.MdiChildren.Contains(FormBarang) Then
            FormBarang.Focus()
        Else
            'FormBarang.MdiParent = Me
            FormBarang.ShowDialog()
        End If
    End Sub
End Class

