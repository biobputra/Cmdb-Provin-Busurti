
Public Class LoginForm
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UserNameTxt.Text <> "" And PasswordTxt.Text <> "" Then
            If Pengguna.ValidateLogin(UserNameTxt.Text, PasswordTxt.Text) = True Then
                MyLoggedInPengguna = Pengguna.GetUserByUserNamePassword(UserNameTxt.Text, PasswordTxt.Text)
                MainForm.Show()
                Me.Close()

            Else
                UserNameTxt.Text = ""
                PasswordTxt.Text = ""
                MyAlert.Show(Me, "Perhatian", "User Name atau password tidak terdaftar dalam database.")
            End If
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserNameTxt.Text = "admin"
        PasswordTxt.Text = "admin"

    End Sub
End Class