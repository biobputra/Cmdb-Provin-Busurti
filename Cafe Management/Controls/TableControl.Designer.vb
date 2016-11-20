<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableControl
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableControl))
    Me.CollapseBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.MyImageList = New DevExpress.Utils.ImageCollection(Me.components)
    Me.NoMejaLbl = New System.Windows.Forms.Label()
    Me.Pic = New System.Windows.Forms.PictureBox()
    Me.ButtonLayout = New System.Windows.Forms.TableLayoutPanel()
    Me.OrderBtn = New System.Windows.Forms.Button()
    Me.Extendbtn = New System.Windows.Forms.Button()
    Me.CheckInBtn = New System.Windows.Forms.Button()
    Me.ReserveBtn = New System.Windows.Forms.Button()
    CType(Me.MyImageList, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ButtonLayout.SuspendLayout()
    Me.SuspendLayout()
    '
    'CollapseBtn
    '
    Me.CollapseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.CollapseBtn.ImageIndex = 0
    Me.CollapseBtn.ImageList = Me.MyImageList
    Me.CollapseBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
    Me.CollapseBtn.Location = New System.Drawing.Point(313, 3)
    Me.CollapseBtn.Name = "CollapseBtn"
    Me.CollapseBtn.Size = New System.Drawing.Size(20, 20)
    Me.CollapseBtn.TabIndex = 2
    '
    'MyImageList
    '
    Me.MyImageList.ImageSize = New System.Drawing.Size(32, 32)
    Me.MyImageList.ImageStream = CType(resources.GetObject("MyImageList.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
    Me.MyImageList.InsertGalleryImage("next_32x32.png", "images/arrows/next_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/next_32x32.png"), 0)
    Me.MyImageList.Images.SetKeyName(0, "next_32x32.png")
    Me.MyImageList.InsertGalleryImage("prev_32x32.png", "images/arrows/prev_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrows/prev_32x32.png"), 1)
    Me.MyImageList.Images.SetKeyName(1, "prev_32x32.png")
    Me.MyImageList.InsertGalleryImage("notes_32x32.png", "images/content/notes_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/notes_32x32.png"), 2)
    Me.MyImageList.Images.SetKeyName(2, "notes_32x32.png")
    Me.MyImageList.InsertGalleryImage("checkbox_32x32.png", "images/content/checkbox_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/content/checkbox_32x32.png"), 3)
    Me.MyImageList.Images.SetKeyName(3, "checkbox_32x32.png")
    Me.MyImageList.InsertGalleryImage("time2_32x32.png", "images/number%20formats/time2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/number%20formats/time2_32x32.png"), 4)
    Me.MyImageList.Images.SetKeyName(4, "time2_32x32.png")
    Me.MyImageList.InsertGalleryImage("report2_32x32.png", "images/toolbox%20items/report2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/toolbox%20items/report2_32x32.png"), 5)
    Me.MyImageList.Images.SetKeyName(5, "report2_32x32.png")
    '
    'NoMejaLbl
    '
    Me.NoMejaLbl.AutoSize = True
    Me.NoMejaLbl.BackColor = System.Drawing.Color.Black
    Me.NoMejaLbl.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NoMejaLbl.ForeColor = System.Drawing.Color.White
    Me.NoMejaLbl.Location = New System.Drawing.Point(0, 0)
    Me.NoMejaLbl.Name = "NoMejaLbl"
    Me.NoMejaLbl.Size = New System.Drawing.Size(58, 47)
    Me.NoMejaLbl.TabIndex = 4
    Me.NoMejaLbl.Text = "20"
    '
    'Pic
    '
    Me.Pic.Dock = System.Windows.Forms.DockStyle.Left
    Me.Pic.Location = New System.Drawing.Point(0, 0)
    Me.Pic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Pic.Name = "Pic"
    Me.Pic.Size = New System.Drawing.Size(165, 170)
    Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.Pic.TabIndex = 0
    Me.Pic.TabStop = False
    '
    'ButtonLayout
    '
    Me.ButtonLayout.ColumnCount = 2
    Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.ButtonLayout.Controls.Add(Me.OrderBtn, 1, 1)
    Me.ButtonLayout.Controls.Add(Me.Extendbtn, 0, 1)
    Me.ButtonLayout.Controls.Add(Me.CheckInBtn, 1, 0)
    Me.ButtonLayout.Controls.Add(Me.ReserveBtn, 0, 0)
    Me.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.ButtonLayout.Location = New System.Drawing.Point(165, 29)
    Me.ButtonLayout.Name = "ButtonLayout"
    Me.ButtonLayout.RowCount = 2
    Me.ButtonLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.ButtonLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.ButtonLayout.Size = New System.Drawing.Size(170, 141)
    Me.ButtonLayout.TabIndex = 5
    '
    'OrderBtn
    '
    Me.OrderBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OrderBtn.Image = Global.Cafe_Management.My.Resources.Resources.Report2_32x32
    Me.OrderBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.OrderBtn.Location = New System.Drawing.Point(88, 73)
    Me.OrderBtn.Name = "OrderBtn"
    Me.OrderBtn.Size = New System.Drawing.Size(79, 65)
    Me.OrderBtn.TabIndex = 7
    Me.OrderBtn.Text = "Order"
    Me.OrderBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.OrderBtn.UseVisualStyleBackColor = True
    '
    'Extendbtn
    '
    Me.Extendbtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Extendbtn.Image = Global.Cafe_Management.My.Resources.Resources.Time_32x32
    Me.Extendbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.Extendbtn.Location = New System.Drawing.Point(3, 73)
    Me.Extendbtn.Name = "Extendbtn"
    Me.Extendbtn.Size = New System.Drawing.Size(79, 65)
    Me.Extendbtn.TabIndex = 6
    Me.Extendbtn.Text = "Extend"
    Me.Extendbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.Extendbtn.UseVisualStyleBackColor = True
    '
    'CheckInBtn
    '
    Me.CheckInBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CheckInBtn.Image = Global.Cafe_Management.My.Resources.Resources.CheckBox_32x32
    Me.CheckInBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.CheckInBtn.Location = New System.Drawing.Point(88, 3)
    Me.CheckInBtn.Name = "CheckInBtn"
    Me.CheckInBtn.Size = New System.Drawing.Size(79, 64)
    Me.CheckInBtn.TabIndex = 5
    Me.CheckInBtn.Text = "Check In"
    Me.CheckInBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.CheckInBtn.UseVisualStyleBackColor = True
    '
    'ReserveBtn
    '
    Me.ReserveBtn.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ReserveBtn.Image = Global.Cafe_Management.My.Resources.Resources.Notes_32x32
    Me.ReserveBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.ReserveBtn.Location = New System.Drawing.Point(3, 3)
    Me.ReserveBtn.Name = "ReserveBtn"
    Me.ReserveBtn.Size = New System.Drawing.Size(79, 64)
    Me.ReserveBtn.TabIndex = 4
    Me.ReserveBtn.Text = "Reserve"
    Me.ReserveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.ReserveBtn.UseVisualStyleBackColor = True
    '
    'TableControl
    '
    Me.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Appearance.Options.UseFont = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.ButtonLayout)
    Me.Controls.Add(Me.NoMejaLbl)
    Me.Controls.Add(Me.CollapseBtn)
    Me.Controls.Add(Me.Pic)
    Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
    Me.Name = "TableControl"
    Me.Size = New System.Drawing.Size(335, 170)
    Me.Tag = "335, 170 165, 170"
    CType(Me.MyImageList, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ButtonLayout.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Pic As System.Windows.Forms.PictureBox
  Friend WithEvents CollapseBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents MyImageList As DevExpress.Utils.ImageCollection
  Friend WithEvents NoMejaLbl As System.Windows.Forms.Label
  Friend WithEvents ButtonLayout As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OrderBtn As System.Windows.Forms.Button
  Friend WithEvents Extendbtn As System.Windows.Forms.Button
  Friend WithEvents CheckInBtn As System.Windows.Forms.Button
  Friend WithEvents ReserveBtn As System.Windows.Forms.Button

End Class
