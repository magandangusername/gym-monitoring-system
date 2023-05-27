Imports System.Data.OleDb
Public Class admin_registration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Trim input fields
        txtFullname.Text = Trim(txtFullname.Text)
        txtEmail.Text = Trim(txtEmail.Text)
        txtPassword.Text = Trim(txtPassword.Text)

        DBConnection.openCon()
        Dim registercmd As New OleDbCommand("INSERT INTO Members 
        (fname,
        email
        ) 
        VALUES ('" &
        txtFullname.Text & "','" &
        txtEmail.Text & "')", DBConnection.con)

        registercmd.ExecuteNonQuery()
        Dim MemberID As New OleDbCommand("SELECT member_id FROM Members ORDER BY member_id DESC", DBConnection.con)
        Dim getdata As OleDbDataReader
        getdata = MemberID.ExecuteReader
        getdata.Read()
        Dim pw = "INSERT INTO credentials (member_id,member_password,isAdmin) VALUES (" & getdata("member_id") & ",'" & txtPassword.Text & "','Y')"
        DBConnection.member_id = getdata("member_id")
        Dim registercmd2 As New OleDbCommand(pw, DBConnection.con)
        getdata.Close()
        registercmd2.ExecuteNonQuery()

        DBConnection.closeCon()

        Me.Close()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub admin_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class