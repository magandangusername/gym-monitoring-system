Imports System.Data.OleDb
Public Class profile
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        member_dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        'load the current user profile info to the screen
        'txtFullname.ReadOnly = True
        txtFullname.Enabled = False
        txtAddress.Enabled = False
        txtBirthday.Enabled = False
        txtAge.Enabled = False
        txtGender.Enabled = False
        txtHeight.Enabled = False
        txtWeight.Enabled = False
        txtContactNumber.Enabled = False
        txtEmail.Enabled = False
        txtEmergencyContactPerson.Enabled = False
        txtContactNumber2.Enabled = False
        txtMedCon.Enabled = False
        txtOldPass.Hide()
        txtPassword.Hide()
        txtReTypePassword.Hide()
        lbloldpass.Hide()
        lblPassword.Hide()
        lblReTypePassword.Hide()
        seeoldpass.Hide()
        showPassword.Hide()
        showPassword2.Hide()
        hideoldpass.Hide()
        hidePassword.Hide()
        hidePassword2.Hide()
        btnSave.Hide()


        Call DBConnection.con.Open()
        Dim MemberProfile As New OleDbCommand("SELECT * FROM Members where member_id = " & DBConnection.member_id, con)
        Dim getdata As OleDbDataReader
        getdata = MemberProfile.ExecuteReader
        getdata.Read()
        txtFullname.Text = getdata("fname")
        txtAddress.Text = getdata("address")
        txtBirthday.Text = getdata("birthday")
        txtAge.Text = getdata("age")
        txtGender.Text = getdata("gender")
        txtHeight.Text = getdata("height")
        txtWeight.Text = getdata("weight")
        txtContactNumber.Text = getdata("contactnumber")
        txtEmail.Text = getdata("email")
        txtEmergencyContactPerson.Text = getdata("emergencyperson")
        txtContactNumber2.Text = getdata("emergencynum")
        txtMedCon.Text = getdata("medicalcondition")

        getdata.Close()
        Call DBConnection.con.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtFullname.Enabled = True
        txtAddress.Enabled = True
        txtBirthday.Enabled = True
        txtAge.Enabled = True
        txtGender.Enabled = True
        txtHeight.Enabled = True
        txtWeight.Enabled = True
        txtContactNumber.Enabled = True
        txtEmail.Enabled = True
        txtEmergencyContactPerson.Enabled = True
        txtContactNumber2.Enabled = True
        txtMedCon.Enabled = True
        txtOldPass.Show()
        txtPassword.Show()
        txtReTypePassword.Show()
        lbloldpass.Show()
        lblPassword.Show()
        lblReTypePassword.Show()
        seeoldpass.Show()
        showPassword.Show()
        showPassword2.Show()
        hideoldpass.Show()
        hidePassword.Show()
        hidePassword2.Show()
        btnSave.Show()
        btnUpdate.Hide()
        btnBack.Hide()

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
        'test

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


    Private Sub seeoldpass_Click(sender As Object, e As EventArgs) Handles seeoldpass.Click
        txtOldPass.PasswordChar = ""
        seeoldpass.Visible = False
        hideoldpass.Visible = True
    End Sub
    Private Sub hideoldpass_Click(sender As Object, e As EventArgs) Handles hideoldpass.Click
        txtOldPass.PasswordChar = "•"
        hideoldpass.Visible = False
        seeoldpass.Visible = True
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call DBConnection.openCon()
        'Trim input fields
        txtFullname.Text = Trim(txtFullname.Text)
        txtAddress.Text = Trim(txtAddress.Text)
        txtBirthday.Text = Trim(txtBirthday.Text)
        txtAge.Text = Trim(txtAge.Text)
        txtContactNumber.Text = Trim(txtContactNumber.Text)
        txtEmail.Text = Trim(txtEmail.Text)
        txtEmergencyContactPerson.Text = Trim(txtEmergencyContactPerson.Text)
        txtContactNumber2.Text = Trim(txtContactNumber2.Text)

        Dim hasError As Boolean = False
        If txtFullname.Text = "" Then
            lblFNameRequired.Show()
            hasError = True
        Else
            lblFNameRequired.Hide()
        End If

        If txtAddress.Text = "" Then
            lblAddrRequired.Show()
            hasError = True
        Else
            lblAddrRequired.Hide()
        End If

        If txtContactNumber.Text = "" Then
            lblContactNumRequired.Show()
            hasError = True
        Else
            lblContactNumRequired.Hide()
        End If

        If txtEmail.Text = "" Then
            lblEmailRequired.Show()
            hasError = True
        Else
            getdata = DBConnection.fetchData("SELECT * FROM Members WHERE email = '" & Trim(txtEmail.Text) & "' AND member_ID <>" & DBConnection.member_id)
            If getdata.HasRows Then
                lblEmailRequired.Text = "Email is already taken."
                lblEmailRequired.Show()
                hasError = True
            Else
                lblEmailRequired.Hide()
            End If
        End If

        If txtEmergencyContactPerson.Text = "" Then
            lblECPRequired.Show()
            hasError = True
        Else
            lblECPRequired.Hide()
        End If

        If txtContactNumber2.Text = "" Then
            lblContactNum2Required.Show()
            hasError = True
        Else
            lblContactNum2Required.Hide()
        End If

        Dim eligibleToChange As Boolean = False
        If txtOldPass.Text <> "" Then
            'check if old pw is same in DB

            getdata = DBConnection.fetchData("SELECT * FROM credentials WHERE member_id = " & DBConnection.member_id & " AND member_password = '" & txtOldPass.Text & "'")
            If getdata.HasRows Then
                lbloldpasswordrequired.Hide()
                If txtPassword.Text = "" Then
                    lblPasswordRequired.Show()
                    eligibleToChange = False
                Else
                    eligibleToChange = True
                    lblPasswordRequired.Hide()
                End If
                If txtReTypePassword.Text = "" Then
                    lblPassword2Required.Show()
                    eligibleToChange = False
                Else
                    lblPassword2Required.Hide()
                    eligibleToChange = True
                End If
                If txtPassword.Text <> txtReTypePassword.Text Then
                    lblPasswordRequired.Text = "password does not match."
                    lblPasswordRequired.Show()
                    eligibleToChange = False
                ElseIf Not securedStr.ValidatePassword(txtPassword.Text) Then
                    lblPassRequirements.Text = "Password must be:
                    atleast 8 characters
                    has atleast 1 Uppercase
                    has atleast 1 Lowercase
                    has atleast 1 Number
                    has atleast 1 Special Character"
                    lblPassRequirements.Show()
                    eligibleToChange = False
                Else
                    lblPasswordRequired.Hide()
                    eligibleToChange = True
                End If
            Else
                lbloldpasswordrequired.Text = "Old password do not match"
                lbloldpasswordrequired.Show()
                eligibleToChange = False
            End If
        End If



        If eligibleToChange = False Then
            DBConnection.closeCon()
            Exit Sub
        Else
            Dim updatecmd As New OleDbCommand("UPDATE credentials
            SET 
            credentials.member_id = " & DBConnection.member_id & ", 
            credentials.member_password = '" & txtPassword.Text & "'
            FROM Members
            JOIN credentials ON Members.member_ID = credentials.member_id
            WHERE Members.member_ID = " & DBConnection.member_id & ";", DBConnection.con)
            If updatecmd.ExecuteNonQuery() > 0 Then
                MsgBox("Password change successfully.", MessageBoxIcon.Information)
            Else
                MsgBox("Password change failed.", MessageBoxIcon.Warning)
            End If
        End If

        If hasError Then
            DBConnection.closeCon()
            Exit Sub
        Else
            Dim updatecmd As New OleDbCommand("UPDATE Members
            SET fname = '" & txtFullname.Text & "', 
            address = '" & txtAddress.Text & "', 
            contactnumber = '" & txtContactNumber.Text & "', 
            email = '" & txtEmail.Text & "',
            emergencyperson = '" & txtEmergencyContactPerson.Text & "',
            emergencynum = '" & txtContactNumber2.Text & "',
            height = '" & txtHeight.Text & "',
            weight = '" & txtWeight.Text & "', 
            medicalcondition = '" & txtMedCon.Text & "',
            FROM Members
            JOIN credentials ON Members.member_ID = credentials.member_id
            WHERE Members.member_ID =" & DBConnection.member_id & ";", DBConnection.con)


            If updatecmd.ExecuteNonQuery() > 0 Then
                MsgBox("Profile updated successfully", MessageBoxIcon.Information)
                btnUpdate.Show()
                btnBack.Show()
                btnSave.Hide()
                DBConnection.closeCon()
            Else
                MsgBox("Profile update failed", MessageBoxIcon.Warning)
            End If
        End If

        'MsgBox("UPDATE Members
        'SET fname = '" & txtFullname.Text &
        '"', address = '" & txtAddress.Text &
        '"', contactnumber = '" & txtContactNumber.Text &
        '"', email = '" & txtEmail.Text &
        '"',emergencyperson = '" & txtEmergencyContactPerson.Text &
        '"',emergencynum = '" & txtContactNumber2.Text &
        '"',height = '" & txtHeight.Text &
        '"',weight = '" & txtWeight.Text &
        '"', medicalcondition = '" & txtMedCon.Text & "',
        'FROM Members
        'JOIN credentials ON Members.member_ID = credentials.member_id
        'WHERE Members.member_ID =" & DBConnection.member_id & ";
        'UPDATE credentials
        'SET credentials.member_id = " & DBConnection.member_id &
        '", credentials.member_password = '" & txtPassword.Text & "'
        'FROM Members
        'JOIN credentials ON Members.member_ID = credentials.member_id
        'WHERE Members.member_ID = " & DBConnection.member_id & ";")




    End Sub


End Class