<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStokOpname
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TambahBtn = New System.Windows.Forms.ToolStripButton()
        Me.EditBtn = New System.Windows.Forms.ToolStripButton()
        Me.HapusBtn = New System.Windows.Forms.ToolStripButton()
        Me.SimpanBtn = New System.Windows.Forms.ToolStripButton()
        Me.BatalBtn = New System.Windows.Forms.ToolStripButton()
        Me.LaporanBtn = New System.Windows.Forms.ToolStripButton()
        Me.PencarianBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahBtn, Me.EditBtn, Me.HapusBtn, Me.SimpanBtn, Me.BatalBtn, Me.LaporanBtn, Me.PencarianBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1244, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TambahBtn
        '
        Me.TambahBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TambahBtn.Name = "TambahBtn"
        Me.TambahBtn.Size = New System.Drawing.Size(54, 22)
        Me.TambahBtn.Text = "Tambah"
        '
        'EditBtn
        '
        Me.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(31, 22)
        Me.EditBtn.Text = "Edit"
        '
        'HapusBtn
        '
        Me.HapusBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(45, 22)
        Me.HapusBtn.Text = "Hapus"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(51, 22)
        Me.SimpanBtn.Text = "Simpan"
        '
        'BatalBtn
        '
        Me.BatalBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(37, 22)
        Me.BatalBtn.Text = "Batal"
        '
        'LaporanBtn
        '
        Me.LaporanBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LaporanBtn.Name = "LaporanBtn"
        Me.LaporanBtn.Size = New System.Drawing.Size(54, 22)
        Me.LaporanBtn.Text = "Laporan"
        '
        'PencarianBtn
        '
        Me.PencarianBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PencarianBtn.Name = "PencarianBtn"
        Me.PencarianBtn.Size = New System.Drawing.Size(63, 22)
        Me.PencarianBtn.Text = "Pencarian"
        '
        'FormStokOpname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 451)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FormStokOpname"
        Me.Text = "Stok Opname"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TambahBtn As ToolStripButton
    Friend WithEvents EditBtn As ToolStripButton
    Friend WithEvents HapusBtn As ToolStripButton
    Friend WithEvents SimpanBtn As ToolStripButton
    Friend WithEvents BatalBtn As ToolStripButton
    Friend WithEvents LaporanBtn As ToolStripButton
    Friend WithEvents PencarianBtn As ToolStripButton
End Class
