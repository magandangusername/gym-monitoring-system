﻿Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call DBConnection.con.Open()


        Dim selectID As New OleDbCommand("
        SELECT COUNT(*) as isValid 
        FROM Members 
        INNER JOIN credentials ON credentials.member_id = Members.member_id WHERE Members.email = '" & txtEmail.Text & "' 
        AND credentials.member_password = '" & txtPassword.Text & "'", con)
        Dim getdata As OleDbDataReader
        getdata = selectID.ExecuteReader
        getdata.Read()
        If getdata("isValid") > 0 Then
            'order.Show()
            'Me.Hide()
            MsgBox("Login Success")
            Me.Hide()
            member_dashboard.Show()

        ElseIf txtEmail.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Empty Email or Password", "Warning")
        Else
            MessageBox.Show("Incorrect Name or Password", "Warning")
        End If
        getdata.Close()
        Call DBConnection.con.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        member_registration.Show()
        Me.Hide()
    End Sub
End Class