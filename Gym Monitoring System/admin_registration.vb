Public Class admin_registration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        member_registration.Show()
        Me.Hide()
    End Sub

    Private Sub showPassword_Click(sender As Object, e As EventArgs) Handles showPassword.Click
        txtPassword.PasswordChar = ""
        showPassword.Visible = False
        hidePassword.Visible = True
    End Sub
    Private Sub hidePassword_Click(sender As Object, e As EventArgs) Handles hidePassword.Click
        txtPassword.PasswordChar = "•"
        hidePassword.Visible = False
        showPassword.Visible = True
    End Sub
End Class