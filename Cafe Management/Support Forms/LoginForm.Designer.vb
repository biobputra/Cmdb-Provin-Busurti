<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
    Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
    Me.UserNameTxt = New DevExpress.XtraEditors.TextEdit()
    Me.PasswordTxt = New DevExpress.XtraEditors.TextEdit()
    Me.PasswordLbl = New DevExpress.XtraEditors.LabelControl()
    Me.LoginBtn = New DevExpress.XtraEditors.SimpleButton()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
    CType(Me.UserNameTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PasswordTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LabelControl1
    '
    Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl1.Location = New System.Drawing.Point(142, 56)
    Me.LabelControl1.Name = "LabelControl1"
    Me.LabelControl1.Size = New System.Drawing.Size(66, 17)
    Me.LabelControl1.TabIndex = 0
    Me.LabelControl1.Text = "User Name"
    '
    'UserNameTxt
    '
    Me.UserNameTxt.Location = New System.Drawing.Point(221, 53)
    Me.UserNameTxt.Name = "UserNameTxt"
    Me.UserNameTxt.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.UserNameTxt.Properties.Appearance.Options.UseFont = True
    Me.UserNameTxt.Size = New System.Drawing.Size(164, 24)
    Me.UserNameTxt.TabIndex = 1
    '
    'PasswordTxt
    '
    Me.PasswordTxt.Location = New System.Drawing.Point(221, 83)
    Me.PasswordTxt.Name = "PasswordTxt"
    Me.PasswordTxt.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.PasswordTxt.Properties.Appearance.Options.UseFont = True
    Me.PasswordTxt.Properties.UseSystemPasswordChar = True
    Me.PasswordTxt.Size = New System.Drawing.Size(164, 24)
    Me.PasswordTxt.TabIndex = 3
    '
    'PasswordLbl
    '
    Me.PasswordLbl.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.PasswordLbl.Location = New System.Drawing.Point(142, 90)
    Me.PasswordLbl.Name = "PasswordLbl"
    Me.PasswordLbl.Size = New System.Drawing.Size(56, 17)
    Me.PasswordLbl.TabIndex = 2
    Me.PasswordLbl.Text = "Password"
    '
    'LoginBtn
    '
    Me.LoginBtn.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LoginBtn.Appearance.Options.UseFont = True
    Me.LoginBtn.Location = New System.Drawing.Point(310, 115)
    Me.LoginBtn.Name = "LoginBtn"
    Me.LoginBtn.Size = New System.Drawing.Size(75, 23)
    Me.LoginBtn.TabIndex = 4
    Me.LoginBtn.Text = "Login"
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(3, 8)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(133, 130)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox1.TabIndex = 5
    Me.PictureBox1.TabStop = False
    '
    'LabelControl2
    '
    Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelControl2.Location = New System.Drawing.Point(158, 8)
    Me.LabelControl2.Name = "LabelControl2"
    Me.LabelControl2.Size = New System.Drawing.Size(218, 37)
    Me.LabelControl2.TabIndex = 6
    Me.LabelControl2.Text = "Cafe Management"
    '
    'LoginForm
    '
    Me.Appearance.Options.UseFont = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(397, 146)
    Me.Controls.Add(Me.LabelControl2)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.LoginBtn)
    Me.Controls.Add(Me.PasswordTxt)
    Me.Controls.Add(Me.PasswordLbl)
    Me.Controls.Add(Me.UserNameTxt)
    Me.Controls.Add(Me.LabelControl1)
    Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "LoginForm"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Login"
    CType(Me.UserNameTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PasswordTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UserNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordLbl As DevExpress.XtraEditors.LabelControl
  Friend WithEvents LoginBtn As DevExpress.XtraEditors.SimpleButton
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
