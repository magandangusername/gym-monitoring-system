﻿Imports System.Data.OleDb
Public Class member_registration
    Private Sub member_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        'reset fields
        txtFullname.Text = ""
        txtAddress.Text = ""
        dtpBirthday.Value = Today
        txtAge.Text = ""
        rdbMale.Checked = True
        txtContactNumber.Text = ""
        txtEmail.Text = ""
        txtEmergencyContactPerson.Text = ""
        txtContactNumber2.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtPassword.Text = ""
        txtPassword.PasswordChar = "•"
        hidePassword.Visible = False
        showPassword.Visible = True
        txtReTypePassword.Text = ""
        txtReTypePassword.PasswordChar = "•"
        hidePassword2.Visible = False
        showPassword2.Visible = True

        medCon.Visible = False
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpBirthday.Value, Now)
        If (dtpBirthday.Value < Today.AddYears(-yr)) Then yr -= 1
        txtAge.Text = yr

        lblFNameRequired.Hide()
        lblAddrRequired.Hide()
        lblBirthdayRequired.Hide()
        lblAgeRequired.Hide()
        lblGenderRequired.Hide()
        lblContactNumRequired.Hide()
        lblEmailRequired.Hide()
        lblECPRequired.Hide()
        lblContactNum2Required.Hide()
        lblPasswordRequired.Hide()
        lblPassword2Required.Hide()

        lblFNameRequired.Text = "Required"
        lblAddrRequired.Text = "Required"
        lblBirthdayRequired.Text = "Required"
        lblAgeRequired.Text = "Required"
        lblGenderRequired.Text = "Required"
        lblContactNumRequired.Text = "Required"
        lblEmailRequired.Text = "Required"
        lblECPRequired.Text = "Required"
        lblContactNum2Required.Text = "Required"
        lblPasswordRequired.Text = "Required"
        lblPassword2Required.Text = "Required"


    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        DBConnection.openCon()
        Dim getdata As OleDbDataReader

        'Trim input fields
        txtFullname.Text = Trim(txtFullname.Text)
        txtAddress.Text = Trim(txtAddress.Text)
        dtpBirthday.Text = Trim(dtpBirthday.Text)
        txtAge.Text = Trim(txtAge.Text)
        txtContactNumber.Text = Trim(txtContactNumber.Text)
        txtEmail.Text = Trim(txtEmail.Text)
        txtEmergencyContactPerson.Text = Trim(txtEmergencyContactPerson.Text)
        txtContactNumber2.Text = Trim(txtContactNumber2.Text)


        'validation
        Dim hasError As Boolean = False
        If txtFullname.Text = "" Then
            'MsgBox("ERROR: Name cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtAddress.Text = "" Then
            'MsgBox("ERROR: Address cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If dtpBirthday.Value > Today Then
            'MsgBox("ERROR: Birthdate cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtAge.Text = "" Then
            'MsgBox("ERROR: Age cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        ElseIf CInt(txtAge.Text) < 12 Then
            'MsgBox("ERROR: You are too young to become a member.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtContactNumber.Text = "" Then
            'MsgBox("ERROR: Contact Number cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtEmail.Text = "" Then
            'MsgBox("ERROR: Email cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        getdata = DBConnection.fetchData("SELECT * FROM Members WHERE email = '" & Trim(txtEmail.Text) & "'")
        If getdata.HasRows Then
            'MsgBox("ERROR: Email is already taken.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtEmergencyContactPerson.Text = "" Then
            'MsgBox("ERROR: Emergency contact person cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtContactNumber2.Text = "" Then
            'MsgBox("ERROR: Emergency contact number cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtPassword.Text = "" Then
            'MsgBox("ERROR: Password cannot be empty.")
            lblFNameRequired.Show()
            hasError = True
        End If
        If txtReTypePassword.Text = "" Then
            'MsgBox("ERROR: Please retype your password.")
            lblFNameRequired.Show()
            hasError = True
        ElseIf txtPassword.Text <> txtReTypePassword.Text Then
            'MsgBox("ERROR: password does not match.")
            lblFNameRequired.Show()
            hasError = True
        ElseIf Not securedStr.ValidatePassword(txtPassword.Text) Then
            'MsgBox("Password must be atleast 8 characters
            'has atleast 1 Uppercase
            'has atleast 1 Lowercase
            'has atleast 1 Number
            'has atleast 1 Special Character
            '")
            lblFNameRequired.Show()
            hasError = True
        End If

        If hasError Then
            DBConnection.closeCon()
            Exit Sub
        End If




        'insertion of data to DB
        Dim medCondition As String = ""
        Dim gender As String
        If rdbMale.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If


        If rdbYes.Checked And medCon.Text <> "" Then
            medCondition = medCon.Text
        End If
        Dim registercmd As New OleDbCommand("INSERT INTO Members 
        (fname,
        address,
        birthday,
        age,
        gender,
        contactnumber,
        email,
        emergencyperson,
        emergencynum,
        height,
        weight,
        medicalcondition
        ) 
        VALUES ('" &
        txtFullname.Text & "','" &
        txtAddress.Text & "','" &
        dtpBirthday.Value.ToShortDateString() & "','" &
        txtAge.Text & "','" &
        gender & "','" &
        txtContactNumber.Text & "','" &
        txtEmail.Text & "','" &
        txtEmergencyContactPerson.Text & "','" &
        txtContactNumber2.Text & "','" &
        txtHeight.Text & "','" &
        txtWeight.Text & "','" &
        medCondition & "')", con)




        registercmd.ExecuteNonQuery()
        'Dim MemberID As New OleDbCommand("SELECT member_id FROM Members ORDER BY member_id DESC", con)
        'getdata = MemberID.ExecuteReader
        'getdata.Read()
        getdata = DBConnection.fetchData("SELECT member_id FROM Members ORDER BY member_id DESC")
        Dim pw = "INSERT INTO credentials (member_id,member_password) VALUES (" & getdata("member_id") & ",'" & txtPassword.Text & "')"
        DBConnection.member_id = getdata("member_id")
        Dim registercmd2 As New OleDbCommand(pw, con)
        'getdata.Close()
        registercmd2.ExecuteNonQuery()

        DBConnection.closeCon()

        member_dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers 

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtHeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHeight.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers 

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers 

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtContactNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNumber.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers 

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtContactNumber2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNumber2.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers 

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub rdbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYes.CheckedChanged
        If rdbYes.Checked Then
            medCon.Visible = True
        Else
            medCon.Visible = False
        End If
    End Sub

    Private Sub rdbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNo.CheckedChanged
        If rdbNo.Checked Then
            medCon.Visible = False
        Else
            medCon.Visible = True
        End If
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpBirthday.Value, Now)
        If (dtpBirthday.Value < Today.AddYears(-yr)) Then yr -= 1
        txtAge.Text = yr
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

    Private Sub showPassword2_Click(sender As Object, e As EventArgs) Handles showPassword2.Click
        txtReTypePassword.PasswordChar = ""
        showPassword2.Visible = False
        hidePassword2.Visible = True
    End Sub
    Private Sub hidePassword2_Click(sender As Object, e As EventArgs) Handles hidePassword2.Click
        txtReTypePassword.PasswordChar = "•"
        hidePassword2.Visible = False
        showPassword2.Visible = True
    End Sub
End Class