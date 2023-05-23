Imports System.Data.OleDb
Public Class member_registration
    Private Sub member_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Visible = False
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpBirthday.Value, Now)
        If (dtpBirthday.Value < Today.AddYears(-yr)) Then yr -= 1
        txtAge.Text = yr

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'If rdbNo.Checked Then
        '    RichTextBox1.Visible = False
        'Else
        '    RichTextBox1.Visible = True
        'End If

        Dim gender As String
        If rdbMale.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        Call DBConnection.con.Open()
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
        weight
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
        txtWeight.Text & "')", con)


        MsgBox("INSERT INTO Members 
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
        weight
        ) 
        VALUES ('" &
        txtFullname.Text & "','" &
        txtAddress.Text & "','" &
        dtpBirthday.Value.Date.ToString() & "','" &
        txtAge.Text & "','" &
        gender & "','" &
        txtContactNumber.Text & "','" &
        txtEmail.Text & "','" &
        txtEmergencyContactPerson.Text & "','" &
        txtContactNumber2.Text & "','" &
        txtHeight.Text & "','" &
        txtWeight.Text & "')")
        member_dashboard.Show()
        Me.Hide()

        registercmd.ExecuteNonQuery()
        Dim MemberID As New OleDbCommand("SELECT member_id FROM Members ORDER BY member_id DESC", con)
        Dim getdata As OleDbDataReader
        getdata = MemberID.ExecuteReader
        getdata.Read()
        Dim pw = "INSERT INTO credentials (member_id,member_password) VALUES (" & getdata("member_id") & ",'" & txtPassword.Text & "')"

        Dim registercmd2 As New OleDbCommand(pw, con)
        getdata.Close()
        registercmd2.ExecuteNonQuery()

        Call DBConnection.con.Close()

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
            RichTextBox1.Visible = True
        Else
            RichTextBox1.Visible = False
        End If
    End Sub

    Private Sub rdbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNo.CheckedChanged
        If rdbNo.Checked Then
            RichTextBox1.Visible = False
        Else
            RichTextBox1.Visible = True
        End If
    End Sub

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim yr As Integer = DateDiff(DateInterval.Year, dtpBirthday.Value, Now)
        If (dtpBirthday.Value < Today.AddYears(-yr)) Then yr -= 1
        txtAge.Text = yr
    End Sub
End Class