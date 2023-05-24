Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call DBConnection.con.Open()
        Dim salt As String = securedStr.GenerateSalt(70)
        Dim selectID As New OleDbCommand("
        SELECT *
        FROM Members 
        INNER JOIN credentials ON credentials.member_id = Members.member_id WHERE Members.email = '" & txtEmail.Text & "' 
        AND credentials.member_password = '" & txtPassword.Text & "'", con)
        MsgBox(securedStr.HashPassword(txtPassword.Text, salt, 10101, 70))
        Dim getdata As OleDbDataReader
        getdata = selectID.ExecuteReader
        getdata.Read()
        If getdata.HasRows Then
            MsgBox("Login Success")
            Me.Hide()
            If getdata("isAdmin") = "Y" Then
                MsgBox("Logged in as ADMIN: " & getdata("fname"))
                admin_overview.Show()
            Else
                member_dashboard.Show()
            End If


        ElseIf txtEmail.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Empty Email or Password", "Warning")
            txtEmail.Select()
        Else
            MessageBox.Show("Incorrect Name or Password", "Warning")
            txtEmail.Select()
            txtEmail.SelectAll()
        End If
        getdata.Close()
        Call DBConnection.con.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        member_registration.Show()
        Me.Hide()
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        e.Handled = True
        If e.KeyCode = Keys.Enter Then
            txtPassword.Select()
            txtPassword.SelectAll()
        End If
    End Sub

    Private Sub preventBeeps(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress, txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True 'This prevents the beep to sound
        End If
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