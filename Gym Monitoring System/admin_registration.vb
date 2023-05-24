Imports System.Data.OleDb
Public Class admin_registration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'member_registration.Show()
        Me.Hide()
        Call DBConnection.con.Open()
        Dim registercmd As New OleDbCommand("INSERT INTO Members 
        (fname,
        email
        ) 
        VALUES ('" &
        txtFullname.Text & "','" &
        txtEmail.Text & "')", con)

        registercmd.ExecuteNonQuery()
        Dim MemberID As New OleDbCommand("SELECT member_id FROM Members ORDER BY member_id DESC", con)
        Dim getdata As OleDbDataReader
        getdata = MemberID.ExecuteReader
        getdata.Read()
        Dim pw = "INSERT INTO credentials (member_id,member_password,isAdmin) VALUES (" & getdata("member_id") & ",'" & txtPassword.Text & "','Y')"
        DBConnection.member_id = getdata("member_id")
        Dim registercmd2 As New OleDbCommand(pw, con)
        getdata.Close()
        registercmd2.ExecuteNonQuery()

        Call DBConnection.con.Close()
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