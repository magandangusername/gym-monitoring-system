Imports System.Data.OleDb
Public Class admin_overview


    Private Sub dgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick

        Me.Text = dgvCustomer.CurrentRow.Cells(0).Value
        txtFullname.Text = dgvCustomer.CurrentRow.Cells(1).Value
        txtAddress.Text = dgvCustomer.CurrentRow.Cells(2).Value
        txtBirthday.Text = dgvCustomer.CurrentRow.Cells(3).Value
        txtGender.Text = dgvCustomer.CurrentRow.Cells(5).Value
        txtContactNumber.Text = dgvCustomer.CurrentRow.Cells(6).Value
        txtEmail.Text = dgvCustomer.CurrentRow.Cells(7).Value
        txtEmergencyContactPerson.Text = dgvCustomer.CurrentRow.Cells(8).Value
        txtContactNumber2.Text = dgvCustomer.CurrentRow.Cells(9).Value
        txtHeight.Text = dgvCustomer.CurrentRow.Cells(10).Value
        txtWeight.Text = dgvCustomer.CurrentRow.Cells(11).Value
        txtBmi.Text = dgvCustomer.CurrentRow.Cells(12).Value
        RichTextBox1.Text = dgvCustomer.CurrentRow.Cells(13).Value

        DBConnection.openCon()

        Dim sessioncmd As New OleDbCommand("
        SELECT MemberSessions.sessiondate, MemberSessions.sessiontime, MemberSessions.lostweight, activitieslist.actname, activitieslist.acttype, activitieslist.actvalue
        FROM MemberSessions
        INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
        WHERE MemberSessions.member_id = " & dgvCustomer.CurrentRow.Cells(0).Value(), DBConnection.con)



        Dim da As New OleDbDataAdapter
        da.SelectCommand = sessioncmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvSession.DataSource = dt
        DBConnection.closeCon()


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            DBConnection.openCon()
            Dim searchcmd As New OleDbCommand("SELECT * FROM Members WHERE 
            member_ID LIKE '%" & txtsearch.Text & "%'
            OR fname LIKE '%" & txtsearch.Text & "%' 
            OR address LIKE '%" & txtsearch.Text & "%' 
            OR gender LIKE '%" & txtsearch.Text & "%' 
            OR contactnumber LIKE '%" & txtsearch.Text & "%' 
            OR email LIKE '%" & txtsearch.Text & "%' 
            OR emergencyperson LIKE '%" & txtsearch.Text & "%' 
            OR emergencynum LIKE '%" & txtsearch.Text & "%' 
            OR height LIKE '%" & txtsearch.Text & "%' 
            OR weight LIKE '%" & txtsearch.Text & "%' 
            OR medicalcondition LIKE '%" & txtsearch.Text & "%'        
            ;", DBConnection.con)
            Dim searchda As New OleDbDataAdapter
            searchda.SelectCommand = searchcmd
            Dim searchdt As New DataTable
            searchda.Fill(searchdt)
            dgvCustomer.DataSource = searchdt
        Catch ex As Exception
            MsgBox("An Error Occur!")
        Finally
            DBConnection.closeCon()

        End Try
    End Sub
    Private Sub btnSearch2_Click(sender As Object, e As EventArgs) Handles btnSearch2.Click
        Try
            DBConnection.openCon()
            Dim searchcmd2 As New OleDbCommand("SELECT MemberSessions.sessiondate, MemberSessions.sessiontime, MemberSessions.lostweight, activitieslist.actname, activitieslist.acttype, activitieslist.actvalue
            FROM MemberSessions
            INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
            WHERE 
            MemberSessions.sessiondate LIKE '%" & txtSearch2.Text & "%'
            OR MemberSessions.sessiontime LIKE '%" & txtSearch2.Text & "%' 
            OR MemberSessions.lostweight LIKE '%" & txtSearch2.Text & "%' 
            OR activitieslist.actname LIKE '%" & txtSearch2.Text & "%' 
            OR activitieslist.acttype LIKE '%" & txtSearch2.Text & "%' 
            OR activitieslist.actvalue LIKE '%" & txtSearch2.Text & "%'      
            ;", DBConnection.con)
            Dim searchda As New OleDbDataAdapter
            searchda.SelectCommand = searchcmd2
            Dim searchdt As New DataTable
            searchda.Fill(searchdt)
            dgvSession.DataSource = searchdt
        Catch ex As Exception
            MsgBox("An Error Occur!")
        Finally
            DBConnection.closeCon()

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DBConnection.openCon()
        Try
            Dim addcmd As New OleDbCommand("INSERT INTO Members (fname,address,birthday,gender,contactnumber,email,emergencyperson,
            emergencynum,height,weight,bmi,medicalcondition) 
            values ('" & txtFullname.Text & "','" & txtAddress.Text & "', '" & txtBirthday.Text & "',  '" & txtGender.Text & "', '" & txtContactNumber.Text & "', '" & txtEmail.Text & "', '" & txtEmergencyContactPerson.Text & "', '" & txtContactNumber2.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "', '" & txtBmi.Text & "', '" & RichTextBox1.Text & "');", DBConnection.con)
            Dim i = addcmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
            Else
                MsgBox("No record has been inserted successfully!")
            End If


            'Dim sql As String
            'Dim cmd As New OleDb.OleDbCommand
            'con.Open()
            'sql = "INSERT INTO Members (fname,address,birthday,gender,contactnumber,email,emergencyperson,
            'emergencynum,height,weight,bmi,medicalcondition,membersince,membershiptype,paymentstatus) 
            'values ('" & txtFullname.Text & "','" & txtAddress.Text & "', '" & txtBirthday.Text & "',  '" & txtGender.Text & "', '" & txtContactNumber.Text & "', '" & txtEmail.Text & "', '" & txtEmergencyContactPerson.Text & "', '" & txtContactNumber2.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "', '" & txtBmi.Text & "', '" & RichTextBox1.Text & "');"
            'cmd.Connection = con
            'cmd.CommandText = sql
            'i = cmd.ExecuteNonQuery
            'If i > 0 Then
            '    MsgBox("New record has been inserted successfully!")
            'Else
            '    MsgBox("No record has been inserted successfully!")
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBConnection.closeCon()

        End Try
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        DBConnection.openCon()
        Try
            Dim addsessioncmd As New OleDbCommand("INSERT INTO MemberSessions (Member_ID,sessiondate,sessiontime,lostweight,actcode) 
            values ('" & txtFullname.Text & "','" & txtAddress.Text & "', '" & txtBirthday.Text & "',  '" & txtGender.Text & "', '" & txtContactNumber.Text & "', '" & txtEmail.Text & "', '" & txtEmergencyContactPerson.Text & "', '" & txtContactNumber2.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "', '" & txtBmi.Text & "', '" & RichTextBox1.Text & "');", DBConnection.con)
            Dim i = addsessioncmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New record has been inserted successfully!")
            Else
                MsgBox("No record has been inserted successfully!")
            End If


            'Dim sql As String
            'Dim cmd As New OleDb.OleDbCommand
            'con.Open()
            'sql = "INSERT INTO Members (fname,address,birthday,gender,contactnumber,email,emergencyperson,
            'emergencynum,height,weight,bmi,medicalcondition,membersince,membershiptype,paymentstatus) 
            'values ('" & txtFullname.Text & "','" & txtAddress.Text & "', '" & txtBirthday.Text & "',  '" & txtGender.Text & "', '" & txtContactNumber.Text & "', '" & txtEmail.Text & "', '" & txtEmergencyContactPerson.Text & "', '" & txtContactNumber2.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "', '" & txtBmi.Text & "', '" & RichTextBox1.Text & "');"
            'cmd.Connection = con
            'cmd.CommandText = sql
            'i = cmd.ExecuteNonQuery
            'If i > 0 Then
            '    MsgBox("New record has been inserted successfully!")
            'Else
            '    MsgBox("No record has been inserted successfully!")
            'End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBConnection.closeCon()

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DBConnection.openCon()
        If txtFullname.Text <> Nothing And txtAddress.Text <> Nothing And txtBirthday.Text <> Nothing And txtGender.Text <> Nothing And txtContactNumber.Text <> Nothing And txtEmail.Text <> Nothing And txtEmergencyContactPerson.Text <> Nothing And txtContactNumber2.Text <> Nothing And txtHeight.Text <> Nothing And txtWeight.Text <> Nothing And txtBmi.Text <> Nothing And RichTextBox1.Text <> Nothing Then
            Try
                'Dim birthday = Str(dtpbirthday.Value().Year) & "-" & Str(dtpbirthday.Value().Month) & "-" & Str(dtpbirthday.Value().Day)
                Dim updatecmd As New OleDbCommand("Update Members
                SET fname ='" & txtFullname.Text & "', address ='" & txtAddress.Text & "', birthday ='" & txtBirthday.Text & "', gender ='" & txtGender.Text & "', contactnumber ='" & txtContactNumber.Text & "', email ='" & txtEmail.Text & "', emergencyperson ='" & txtEmergencyContactPerson.Text & "', emergencynum ='" & txtContactNumber2.Text & "', height ='" & txtHeight.Text & "', weight ='" & txtWeight.Text & "', bmi ='" & txtBmi.Text & "', medicalcondition ='" & RichTextBox1.Text & "'
                WHERE member_ID = " & Me.Text & "", DBConnection.con)

                Dim i = updatecmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Record Has Been UPDATED SUCCESSFULLY!", MessageBoxIcon.Information)

                Else
                    MsgBox("Record Update Failed!", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox("An Error Occur", MessageBoxIcon.Error)
            Finally
                DBConnection.closeCon()

            End Try
        Else
            MsgBox("All Fields Are Required", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DBConnection.openCon()
        Try
            Dim deletecmd As New OleDbCommand("DELETE * FROM Members WHERE member_ID = " & Me.Text & "", DBConnection.con)
            Dim i = deletecmd.ExecuteNonQuery
            If i > 0 Then
                Dim Answer As Integer
                Answer = MsgBox("Do you want to delete this information?", vbQuestion + vbYesNo + vbDefaultButton2, "Caution")

                If Answer = vbYes Then
                    MsgBox("Record Has Been DELETED SUCCESSFULLY!", MessageBoxIcon.Information)
                    txtFullname.Text = ""
                    txtAddress.Text = ""
                    txtBirthday.Text = ""
                    txtGender.Text = ""
                    txtContactNumber.Text = ""
                    txtEmail.Text = ""
                    txtEmergencyContactPerson.Text = ""
                    txtContactNumber2.Text = ""
                    txtHeight.Text = ""
                    txtWeight.Text = ""
                    txtBmi.Text = ""
                    RichTextBox1.Text = ""
                End If
            Else
                MsgBox("Please Select A Data!", MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex)
        Finally
            DBConnection.closeCon()

        End Try

    End Sub

    Private Sub admin_overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnUpdate.Click
        DBConnection.openCon()

        Dim customercmd As New OleDbCommand("
        SELECT Members.member_ID, Members.fname,Members.address,Members.birthday,Members.age,Members.gender,Members.contactnumber,Members.email,Members.emergencyperson,
        Members.emergencynum,Members.height,Members.weight,Members.bmi,Members.medicalcondition,Members.membersince,Members.membershiptype,Members.paymentstatus,credentials.isAdmin,credentials.member_id
        FROM Members
        INNER JOIN credentials ON Members.member_ID = credentials.member_id;
        ", DBConnection.con)

        'Dim adminreader As OleDbDataReader
        'adminreader = customercmd.ExecuteReader
        'If Me.Text = adminreader("credentials.member_id") Then
        '    lblAdminName = "Welcome " & adminreader("fname")
        'End If

        Dim da As New OleDbDataAdapter
        da.SelectCommand = customercmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvCustomer.DataSource = dt
        DBConnection.closeCon()
    End Sub


End Class