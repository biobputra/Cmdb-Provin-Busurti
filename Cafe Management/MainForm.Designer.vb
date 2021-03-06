﻿Partial Public Class MainForm
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
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.PosMenuJenisMeja = New DevExpress.XtraBars.BarButtonItem()
        Me.PosMenuDaftarMeja = New DevExpress.XtraBars.BarButtonItem()
        Me.InventoryMenuSatuan = New DevExpress.XtraBars.BarButtonItem()
        Me.InventoryMenuJenisBarang = New DevExpress.XtraBars.BarButtonItem()
        Me.PosMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.InventoryMenuHeader = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.InventoryMenuBarang = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.PosMenuJenisMeja, Me.PosMenuDaftarMeja, Me.InventoryMenuSatuan, Me.InventoryMenuJenisBarang, Me.InventoryMenuBarang})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 6
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.PosMenuHeader, Me.InventoryMenuHeader})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(758, 143)
        '
        'PosMenuJenisMeja
        '
        Me.PosMenuJenisMeja.Caption = "Jenis Meja"
        Me.PosMenuJenisMeja.Id = 1
        Me.PosMenuJenisMeja.Name = "PosMenuJenisMeja"
        '
        'PosMenuDaftarMeja
        '
        Me.PosMenuDaftarMeja.Caption = "Daftar Meja"
        Me.PosMenuDaftarMeja.Id = 2
        Me.PosMenuDaftarMeja.Name = "PosMenuDaftarMeja"
        '
        'InventoryMenuSatuan
        '
        Me.InventoryMenuSatuan.Caption = "Satuan"
        Me.InventoryMenuSatuan.Id = 3
        Me.InventoryMenuSatuan.Name = "InventoryMenuSatuan"
        '
        'InventoryMenuJenisBarang
        '
        Me.InventoryMenuJenisBarang.Caption = "Jenis Barang"
        Me.InventoryMenuJenisBarang.Id = 4
        Me.InventoryMenuJenisBarang.Name = "InventoryMenuJenisBarang"
        '
        'PosMenuHeader
        '
        Me.PosMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.PosMenuHeader.Name = "PosMenuHeader"
        Me.PosMenuHeader.Text = "Point Of Sale"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.PosMenuJenisMeja)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.PosMenuDaftarMeja)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'InventoryMenuHeader
        '
        Me.InventoryMenuHeader.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.InventoryMenuHeader.Name = "InventoryMenuHeader"
        Me.InventoryMenuHeader.Text = "Inventory"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.InventoryMenuSatuan)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.InventoryMenuJenisBarang)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.InventoryMenuBarang)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Barang"
        '
        'InventoryMenuBarang
        '
        Me.InventoryMenuBarang.Caption = "Barang"
        Me.InventoryMenuBarang.Id = 5
        Me.InventoryMenuBarang.Name = "InventoryMenuBarang"
        '
        'MainForm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 360)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Form1"
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
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents InventoryMenuJenisBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents InventoryMenuBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
