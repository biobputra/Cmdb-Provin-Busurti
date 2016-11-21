<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservasiMejaControl
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.JamMulaiEdit = New DevExpress.XtraEditors.TimeEdit()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.JamSelesaiEdit = New DevExpress.XtraEditors.TimeEdit()
    Me.NamaMejaLbl = New DevExpress.XtraEditors.LabelControl()
    Me.ChkMeja = New System.Windows.Forms.CheckBox()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    CType(Me.JamMulaiEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.JamSelesaiEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.NamaMejaLbl, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.ChkMeja, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(398, 70)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Controls.Add(Me.JamMulaiEdit, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.LabelControl2, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.LabelControl1, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.JamSelesaiEdit, 1, 1)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(213, 3)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 2
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(182, 64)
    Me.TableLayoutPanel3.TabIndex = 2
    '
    'JamMulaiEdit
    '
    Me.JamMulaiEdit.Dock = System.Windows.Forms.DockStyle.Fill
    Me.JamMulaiEdit.EditValue = New Date(2016, 11, 20, 0, 0, 0, 0)
    Me.JamMulaiEdit.Location = New System.Drawing.Point(3, 35)
    Me.JamMulaiEdit.Name = "JamMulaiEdit"
    Me.JamMulaiEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.JamMulaiEdit.Properties.Appearance.Options.UseFont = True
    Me.JamMulaiEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.JamMulaiEdit.Properties.Mask.EditMask = "t"
    Me.JamMulaiEdit.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
    Me.JamMulaiEdit.Size = New System.Drawing.Size(85, 26)
    Me.JamMulaiEdit.TabIndex = 3
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl2.Location = New System.Drawing.Point(4, 4)
    Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(83, 24)
    Me.LabelControl2.TabIndex = 1
    Me.LabelControl2.Text = "Jam Mulai"
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelControl1.Location = New System.Drawing.Point(95, 4)
    Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(83, 24)
    Me.LabelControl1.TabIndex = 4
    Me.LabelControl1.Text = "Jam Selesai"
    '
    'JamSelesaiEdit
    '
    Me.JamSelesaiEdit.Dock = System.Windows.Forms.DockStyle.Fill
    Me.JamSelesaiEdit.EditValue = New Date(2016, 11, 20, 0, 0, 0, 0)
    Me.JamSelesaiEdit.Location = New System.Drawing.Point(94, 35)
    Me.JamSelesaiEdit.Name = "JamSelesaiEdit"
    Me.JamSelesaiEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.JamSelesaiEdit.Properties.Appearance.Options.UseFont = True
    Me.JamSelesaiEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    Me.JamSelesaiEdit.Properties.Mask.EditMask = "t"
    Me.JamSelesaiEdit.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
    Me.JamSelesaiEdit.Size = New System.Drawing.Size(85, 26)
    Me.JamSelesaiEdit.TabIndex = 5
    '
    'NamaMejaLbl
    '
    Me.NamaMejaLbl.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NamaMejaLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
    Me.NamaMejaLbl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.NamaMejaLbl.Location = New System.Drawing.Point(64, 4)
    Me.NamaMejaLbl.Margin = New System.Windows.Forms.Padding(4)
    Me.NamaMejaLbl.Name = "NamaMejaLbl"
    Me.NamaMejaLbl.Size = New System.Drawing.Size(142, 62)
    Me.NamaMejaLbl.TabIndex = 0
    Me.NamaMejaLbl.Text = "NamaMeja nama meja"
    '
    'ChkMeja
    '
    Me.ChkMeja.AutoSize = True
    Me.ChkMeja.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.ChkMeja.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ChkMeja.Location = New System.Drawing.Point(3, 3)
    Me.ChkMeja.Name = "ChkMeja"
    Me.ChkMeja.Size = New System.Drawing.Size(54, 64)
    Me.ChkMeja.TabIndex = 3
    Me.ChkMeja.UseVisualStyleBackColor = True
    '
    'ReservasiMejaControl
    '
    Me.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Appearance.Options.UseFont = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.Name = "ReservasiMejaControl"
    Me.Size = New System.Drawing.Size(398, 70)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    CType(Me.JamMulaiEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.JamSelesaiEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents NamaMejaLbl As DevExpress.XtraEditors.LabelControl
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents JamMulaiEdit As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
  Friend WithEvents JamSelesaiEdit As DevExpress.XtraEditors.TimeEdit
  Friend WithEvents ChkMeja As System.Windows.Forms.CheckBox

End Class
