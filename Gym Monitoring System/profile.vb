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
        txtGender.Text = getdata("gender")
        txtHeight.Text = getdata("height")
        txtWeight.Text = getdata("weight")
        txtContactNumber.Text = getdata("contactnumber")
        txtEmail.Text = getdata("email")
        txtEmergencyContactPerson.Text = getdata("emergencyperson")
        txtContactNumber2.Text = getdata("emergencynum")

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
        txtOldPass.PasswordChar = "•"
        showPassword.Visible = False
        hidePassword.Visible = True
    End Sub
    Private Sub hideoldpass_Click(sender As Object, e As EventArgs) Handles hideoldpass.Click
        txtPassword.PasswordChar = "•"
        hidePassword.Visible = False
        showPassword.Visible = True
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