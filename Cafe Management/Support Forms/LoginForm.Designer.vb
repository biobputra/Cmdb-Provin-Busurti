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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UserNameTxt = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordTxt = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordLbl = New DevExpress.XtraEditors.LabelControl()
        Me.LoginBtn = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.UserNameTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "User Name"
        '
        'UserNameTxt
        '
        Me.UserNameTxt.Location = New System.Drawing.Point(99, 12)
        Me.UserNameTxt.Name = "UserNameTxt"
        Me.UserNameTxt.Size = New System.Drawing.Size(266, 20)
        Me.UserNameTxt.TabIndex = 1
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(99, 38)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Properties.UseSystemPasswordChar = True
        Me.PasswordTxt.Size = New System.Drawing.Size(266, 20)
        Me.PasswordTxt.TabIndex = 3
        '
        'PasswordLbl
        '
        Me.PasswordLbl.Location = New System.Drawing.Point(12, 41)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(46, 13)
        Me.PasswordLbl.TabIndex = 2
        Me.PasswordLbl.Text = "Password"
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(290, 64)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "SimpleButton1"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 115)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.UserNameTxt)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.UserNameTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UserNameTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordLbl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LoginBtn As DevExpress.XtraEditors.SimpleButton
End Class
