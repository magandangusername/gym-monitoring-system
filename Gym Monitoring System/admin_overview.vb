Imports System.Data.OleDb
Public Class admin_overview

    Private Sub dgvSession_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSession.CellClick
        'reset fields for sessions
        txtUBA1.Text = ""
        txtUBA2.Text = ""
        txtUBA3.Text = ""
        txtUBA4.Text = ""
        txtUBA5.Text = ""
        txtUBA6.Text = ""
        txtUBA7.Text = ""
        txtUBA8.Text = ""
        txtUBA9.Text = ""
        txtUBA10.Text = ""
        txtUBA11.Text = ""
        txtUBA12.Text = ""
        txtUBA13.Text = ""
        txtUBA14.Text = ""
        txtUBA15.Text = ""
        txtUBA16.Text = ""
        txtUBA17.Text = ""
        txtUBA18.Text = ""

        txtLBA1.Text = ""
        txtLBA2.Text = ""
        txtLBA3.Text = ""
        txtLBA4.Text = ""
        txtLBA5.Text = ""
        txtLBA6.Text = ""
        txtLBA7.Text = ""
        txtLBA8.Text = ""
        txtLBA9.Text = ""
        txtLBA10.Text = ""
        txtLBA11.Text = ""
        txtLBA12.Text = ""
        txtLBA13.Text = ""
        txtLBA14.Text = ""
        txtLBA15.Text = ""
        txtLBA16.Text = ""
        txtLBA17.Text = ""
        txtLBA18.Text = ""

        txtCBA1.Text = ""
        txtCBA2.Text = ""
        txtCBA3.Text = ""
        txtCBA4.Text = ""
        txtCBA5.Text = ""
        txtCBA6.Text = ""
        txtCBA7.Text = ""
        txtCBA8.Text = ""
        txtCBA9.Text = ""
        txtCBA10.Text = ""
        txtCBA11.Text = ""
        txtCBA12.Text = ""
        txtCBA13.Text = ""
        txtCBA14.Text = ""
        txtCBA15.Text = ""
        txtCBA16.Text = ""
        txtCBA17.Text = ""

        DBConnection.openCon()
        Dim sessioncmd As New OleDbCommand("
        SELECT *
        FROM MemberSessions
        INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
        WHERE MemberSessions.member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() &
        " AND sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "#", DBConnection.con)

        Dim getdata = sessioncmd.ExecuteReader

        While getdata.Read

            If getdata("actname") = "Bench press" And getdata("acttype") = "Upper Body" Then
                txtUBA1.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Overhead press" And getdata("acttype") = "Upper Body" Then
                txtUBA2.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Pushups" And getdata("acttype") = "Upper Body" Then
                txtUBA3.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Bent-over row" And getdata("acttype") = "Upper Body" Then
                txtUBA4.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Biceps curl" And getdata("acttype") = "Upper Body" Then
                txtUBA5.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Pull-up" And getdata("acttype") = "Upper Body" Then
                txtUBA6.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Lying triceps extensions" And getdata("acttype") = "Upper Body" Then
                txtUBA7.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Tricep dip" And getdata("acttype") = "Upper Body" Then
                txtUBA8.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Single arm dumbbell row" And getdata("acttype") = "Upper Body" Then
                txtUBA9.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Pull-down" And getdata("acttype") = "Upper Body" Then
                txtUBA10.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell triceps kickback" And getdata("acttype") = "Upper Body" Then
                txtUBA11.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell triceps kickback" And getdata("acttype") = "Upper Body" Then
                txtUBA12.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell front raise" And getdata("acttype") = "Upper Body" Then
                txtUBA13.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Deadlift" And getdata("acttype") = "Upper Body" Then
                txtUBA14.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell fly" And getdata("acttype") = "Upper Body" Then
                txtUBA15.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Overhead Triceps Extension" And getdata("acttype") = "Upper Body" Then
                txtUBA16.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell bench press" And getdata("acttype") = "Upper Body" Then
                txtUBA17.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell shoulder press" And getdata("acttype") = "Upper Body" Then
                txtUBA18.Text = getdata("session_minutes")

            ElseIf getdata("actname") = "Squats" And getdata("acttype") = "Lower Body" Then
                txtLBA1.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Lunge" And getdata("acttype") = "Lower Body" Then
                txtLBA2.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Split squat" And getdata("acttype") = "Lower Body" Then
                txtLBA3.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Calf raises" And getdata("acttype") = "Lower Body" Then
                txtLBA4.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Deadlift" And getdata("acttype") = "Lower Body" Then
                txtLBA5.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Goblet squats" And getdata("acttype") = "Lower Body" Then
                txtLBA6.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Romanian deadlift" And getdata("acttype") = "Lower Body" Then
                txtLBA7.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Side lunge" And getdata("acttype") = "Lower Body" Then
                txtLBA8.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Leg curl" And getdata("acttype") = "Lower Body" Then
                txtLBA9.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Single leg deadlift" And getdata("acttype") = "Lower Body" Then
                txtLBA10.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Leg press" And getdata("acttype") = "Lower Body" Then
                txtLBA11.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Reverse lunges" And getdata("acttype") = "Lower Body" Then
                txtLBA12.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Walking lunge" And getdata("acttype") = "Lower Body" Then
                txtLBA13.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Leg extension" And getdata("acttype") = "Lower Body" Then
                txtLBA14.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Donkey kicks" And getdata("acttype") = "Lower Body" Then
                txtLBA15.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Barbell squat" And getdata("acttype") = "Lower Body" Then
                txtLBA16.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell lunge" And getdata("acttype") = "Lower Body" Then
                txtLBA17.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Bodyweight Squat" And getdata("acttype") = "Lower Body" Then
                txtLBA18.Text = getdata("session_minutes")

            ElseIf getdata("actname") = "Pilates" And getdata("acttype") = "Core" Then
                txtCBA1.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Plank" And getdata("acttype") = "Core" Then
                txtCBA2.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Crunch" And getdata("acttype") = "Core" Then
                txtCBA3.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Reverse crunch" And getdata("acttype") = "Core" Then
                txtCBA4.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Leg raise" And getdata("acttype") = "Core" Then
                txtCBA5.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Bicycle crunches" And getdata("acttype") = "Core" Then
                txtCBA6.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Russian twists" And getdata("acttype") = "Core" Then
                txtCBA7.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Modified plank" And getdata("acttype") = "Core" Then
                txtCBA8.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Sit-up" And getdata("acttype") = "Core" Then
                txtCBA9.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Hanging leg raises" And getdata("acttype") = "Core" Then
                txtCBA10.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Bird-dog crunch" And getdata("acttype") = "Core" Then
                txtCBA11.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Forearm plank" And getdata("acttype") = "Core" Then
                txtCBA12.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "High plank" And getdata("acttype") = "Core" Then
                txtCBA13.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Plank jack" And getdata("acttype") = "Core" Then
                txtCBA14.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Dumbbell plank drag" And getdata("acttype") = "Core" Then
                txtCBA15.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Chaturanga Dandasana" And getdata("acttype") = "Core" Then
                txtCBA16.Text = getdata("session_minutes")
            ElseIf getdata("actname") = "Plank walk" And getdata("acttype") = "Core" Then
                txtCBA17.Text = getdata("session_minutes")
            End If
        End While
        getdata.Close()
        DBConnection.closeCon()
    End Sub

    Private Sub dgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick
        'reset fields for member info
        'txtFullname.Text = ""
        'txtAddress.Text = ""
        'txtBirthday.Text = ""
        'txtGender.Text = ""
        'txtContactNumber.Text = ""
        'txtEmail.Text = ""
        'txtEmergencyContactPerson.Text = ""
        'txtContactNumber2.Text = ""
        'txtHeight.Text = ""
        'txtWeight.Text = ""
        'txtBmi.Text = ""
        'RichTextBox1.Text = ""
        'txtPW.Text = ""

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
        SELECT MemberSessions.sessiondate as 'Session Date'
        FROM MemberSessions
        INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
        WHERE MemberSessions.member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " GROUP BY MemberSessions.sessiondate", DBConnection.con)



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
            Dim getdata = DBConnection.fetchData("SELECT * FROM MemberSessions WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND sessiondate = #" & dgvCustomer.CurrentRow.Cells(0).Value() & "#")
            If Not getdata.HasRows Then
                checkAndUpdateAct(txtUBA1.Text, "1", dtSession.ToString)
                checkAndUpdateAct(txtUBA2.Text, "2", dtSession.ToString)
                checkAndUpdateAct(txtUBA3.Text, "3", dtSession.ToString)
                checkAndUpdateAct(txtUBA4.Text, "4", dtSession.ToString)
                checkAndUpdateAct(txtUBA5.Text, "5", dtSession.ToString)
                checkAndUpdateAct(txtUBA6.Text, "6", dtSession.ToString)
                checkAndUpdateAct(txtUBA7.Text, "7", dtSession.ToString)
                checkAndUpdateAct(txtUBA8.Text, "8", dtSession.ToString)
                checkAndUpdateAct(txtUBA9.Text, "9", dtSession.ToString)
                checkAndUpdateAct(txtUBA10.Text, "10", dtSession.ToString)
                checkAndUpdateAct(txtUBA11.Text, "11", dtSession.ToString)
                checkAndUpdateAct(txtUBA12.Text, "12", dtSession.ToString)
                checkAndUpdateAct(txtUBA13.Text, "13", dtSession.ToString)
                checkAndUpdateAct(txtUBA14.Text, "14", dtSession.ToString)
                checkAndUpdateAct(txtUBA15.Text, "15", dtSession.ToString)
                checkAndUpdateAct(txtUBA16.Text, "16", dtSession.ToString)
                checkAndUpdateAct(txtUBA17.Text, "17", dtSession.ToString)
                checkAndUpdateAct(txtUBA18.Text, "18", dtSession.ToString)
                checkAndUpdateAct(txtLBA1.Text, "19", dtSession.ToString)
                checkAndUpdateAct(txtLBA2.Text, "20", dtSession.ToString)
                checkAndUpdateAct(txtLBA3.Text, "21", dtSession.ToString)
                checkAndUpdateAct(txtLBA4.Text, "22", dtSession.ToString)
                checkAndUpdateAct(txtLBA5.Text, "23", dtSession.ToString)
                checkAndUpdateAct(txtLBA6.Text, "24", dtSession.ToString)
                checkAndUpdateAct(txtLBA7.Text, "25", dtSession.ToString)
                checkAndUpdateAct(txtLBA8.Text, "26", dtSession.ToString)
                checkAndUpdateAct(txtLBA9.Text, "27", dtSession.ToString)
                checkAndUpdateAct(txtLBA10.Text, "28", dtSession.ToString)
                checkAndUpdateAct(txtLBA11.Text, "29", dtSession.ToString)
                checkAndUpdateAct(txtLBA12.Text, "30", dtSession.ToString)
                checkAndUpdateAct(txtLBA13.Text, "31", dtSession.ToString)
                checkAndUpdateAct(txtLBA14.Text, "32", dtSession.ToString)
                checkAndUpdateAct(txtLBA15.Text, "33", dtSession.ToString)
                checkAndUpdateAct(txtLBA16.Text, "34", dtSession.ToString)
                checkAndUpdateAct(txtLBA17.Text, "35", dtSession.ToString)
                checkAndUpdateAct(txtLBA18.Text, "36", dtSession.ToString)
                checkAndUpdateAct(txtCBA1.Text, "37", dtSession.ToString)
                checkAndUpdateAct(txtCBA2.Text, "38", dtSession.ToString)
                checkAndUpdateAct(txtCBA3.Text, "39", dtSession.ToString)
                checkAndUpdateAct(txtCBA4.Text, "40", dtSession.ToString)
                checkAndUpdateAct(txtCBA5.Text, "41", dtSession.ToString)
                checkAndUpdateAct(txtCBA6.Text, "42", dtSession.ToString)
                checkAndUpdateAct(txtCBA7.Text, "43", dtSession.ToString)
                checkAndUpdateAct(txtCBA8.Text, "44", dtSession.ToString)
                checkAndUpdateAct(txtCBA9.Text, "45", dtSession.ToString)
                checkAndUpdateAct(txtCBA10.Text, "46", dtSession.ToString)
                checkAndUpdateAct(txtCBA11.Text, "47", dtSession.ToString)
                checkAndUpdateAct(txtCBA12.Text, "48", dtSession.ToString)
                checkAndUpdateAct(txtCBA13.Text, "49", dtSession.ToString)
                checkAndUpdateAct(txtCBA14.Text, "50", dtSession.ToString)
                checkAndUpdateAct(txtCBA15.Text, "51", dtSession.ToString)
                checkAndUpdateAct(txtCBA16.Text, "52", dtSession.ToString)
                checkAndUpdateAct(txtCBA17.Text, "53", dtSession.ToString)
            Else
                MsgBox("session date already exists")
            End If

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

    Private Sub admin_overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnUpdate.Click, btnAdd.Click, btnDelete.Click ', dgvCustomer.CellClick, dgvSession.CellClick
        'reset fields
        resetFields()

        'load data
        DBConnection.openCon()

        Dim customercmd As New OleDbCommand("
        SELECT Members.member_ID as ID, 
        Members.fname as Name, 
        Members.address as Address,
        Members.birthday as Birthdate,
        Members.age as Age,
        Members.gender as Gender,
        Members.contactnumber as Contact,
        Members.email as Email,
        Members.emergencyperson as 'Emergency Person',
        Members.emergencynum as 'Emergency Person Contact',
        Members.height as Height,
        Members.weight as Weight,
        Members.bmi as BMI,
        Members.medicalcondition as 'Medical Condition',
        Members.membersince as 'Member Since'
        FROM Members
        INNER JOIN credentials ON Members.member_ID = credentials.member_id
        WHERE credentials.isAdmin <> 'Y'", DBConnection.con)

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

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        Dim getdata As OleDbDataReader
        DBConnection.openCon()
        'Try
        'Dim sessioncmd As New OleDbCommand("
        '    SELECT *
        '    FROM MemberSessions
        '    INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
        '    WHERE MemberSessions.member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() &
        '    " AND sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "#", DBConnection.con)
        '
        'getdata = sessioncmd.ExecuteReader
        '
        'While getdata.Read
        '
        '    If getdata("actname") = "Bench press" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA1.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Overhead press" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA2.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Pushups" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA3.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Bent-over row" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA4.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Biceps curl" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA5.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Pull-up" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA6.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Lying triceps extensions" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA7.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Tricep dip" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA8.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Single arm dumbbell row" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA9.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Pull-down" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA10.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell triceps kickback" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA11.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell triceps kickback" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA12.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell front raise" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA13.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Deadlift" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA14.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell fly" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA15.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Overhead Triceps Extension" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA16.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell bench press" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA17.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell shoulder press" And getdata("acttype") = "Upper Body" Then
        '        updateAct(txtUBA18.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '
        '    ElseIf getdata("actname") = "Squats" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA1.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Lunge" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA2.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Split squat" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA3.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Calf raises" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA4.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Deadlift" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA5.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Goblet squats" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA6.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Romanian deadlift" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA7.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Side lunge" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA8.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Leg curl" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA9.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Single leg deadlift" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA10.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Leg press" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA11.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Reverse lunges" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA12.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Walking lunge" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA13.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Leg extension" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA14.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Donkey kicks" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA15.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Barbell squat" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA16.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell lunge" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA17.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Bodyweight Squat" And getdata("acttype") = "Lower Body" Then
        '        updateAct(txtLBA18.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '
        '    ElseIf getdata("actname") = "Pilates" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA1.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Plank" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA2.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Crunch" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA3.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Reverse crunch" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA4.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Leg raise" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA5.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Bicycle crunches" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA6.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Russian twists" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA7.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Modified plank" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA8.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Sit-up" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA9.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Hanging leg raises" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA10.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Bird-dog crunch" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA11.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Forearm plank" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA12.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "High plank" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA13.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Plank jack" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA14.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Dumbbell plank drag" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA15.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Chaturanga Dandasana" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA16.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    ElseIf getdata("actname") = "Plank walk" And getdata("acttype") = "Core" Then
        '        updateAct(txtCBA17.Text, getdata("activitieslist.actcode"))
        '        Continue While
        '    End If
        'End While
        checkAndUpdateAct(txtUBA1.Text, "1")
        checkAndUpdateAct(txtUBA2.Text, "2")
        checkAndUpdateAct(txtUBA3.Text, "3")
        checkAndUpdateAct(txtUBA4.Text, "4")
        checkAndUpdateAct(txtUBA5.Text, "5")
        checkAndUpdateAct(txtUBA6.Text, "6")
        checkAndUpdateAct(txtUBA7.Text, "7")
        checkAndUpdateAct(txtUBA8.Text, "8")
        checkAndUpdateAct(txtUBA9.Text, "9")
        checkAndUpdateAct(txtUBA10.Text, "10")
        checkAndUpdateAct(txtUBA11.Text, "11")
        checkAndUpdateAct(txtUBA12.Text, "12")
        checkAndUpdateAct(txtUBA13.Text, "13")
        checkAndUpdateAct(txtUBA14.Text, "14")
        checkAndUpdateAct(txtUBA15.Text, "15")
        checkAndUpdateAct(txtUBA16.Text, "16")
        checkAndUpdateAct(txtUBA17.Text, "17")
        checkAndUpdateAct(txtUBA18.Text, "18")
        checkAndUpdateAct(txtLBA1.Text, "19")
        checkAndUpdateAct(txtLBA2.Text, "20")
        checkAndUpdateAct(txtLBA3.Text, "21")
        checkAndUpdateAct(txtLBA4.Text, "22")
        checkAndUpdateAct(txtLBA5.Text, "23")
        checkAndUpdateAct(txtLBA6.Text, "24")
        checkAndUpdateAct(txtLBA7.Text, "25")
        checkAndUpdateAct(txtLBA8.Text, "26")
        checkAndUpdateAct(txtLBA9.Text, "27")
        checkAndUpdateAct(txtLBA10.Text, "28")
        checkAndUpdateAct(txtLBA11.Text, "29")
        checkAndUpdateAct(txtLBA12.Text, "30")
        checkAndUpdateAct(txtLBA13.Text, "31")
        checkAndUpdateAct(txtLBA14.Text, "32")
        checkAndUpdateAct(txtLBA15.Text, "33")
        checkAndUpdateAct(txtLBA16.Text, "34")
        checkAndUpdateAct(txtLBA17.Text, "35")
        checkAndUpdateAct(txtLBA18.Text, "36")
        checkAndUpdateAct(txtCBA1.Text, "37")
        checkAndUpdateAct(txtCBA2.Text, "38")
        checkAndUpdateAct(txtCBA3.Text, "39")
        checkAndUpdateAct(txtCBA4.Text, "40")
        checkAndUpdateAct(txtCBA5.Text, "41")
        checkAndUpdateAct(txtCBA6.Text, "42")
        checkAndUpdateAct(txtCBA7.Text, "43")
        checkAndUpdateAct(txtCBA8.Text, "44")
        checkAndUpdateAct(txtCBA9.Text, "45")
        checkAndUpdateAct(txtCBA10.Text, "46")
        checkAndUpdateAct(txtCBA11.Text, "47")
        checkAndUpdateAct(txtCBA12.Text, "48")
        checkAndUpdateAct(txtCBA13.Text, "49")
        checkAndUpdateAct(txtCBA14.Text, "50")
        checkAndUpdateAct(txtCBA15.Text, "51")
        checkAndUpdateAct(txtCBA16.Text, "52")
        checkAndUpdateAct(txtCBA17.Text, "53")


        '    MsgBox("An Error Occurred: ", MessageBoxIcon.Error)
        'Finally
        DBConnection.closeCon()
        '
        'End Try
        resetFields()
    End Sub

    Private Sub updateAct(field As String, actcode As String)
        field = Trim(field)
        If field <> "" Then
            Dim cmd As New OleDbCommand("
                UPDATE MemberSessions SET
                session_minutes = " & field & "
                WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "# AND
                actcode = " & actcode, DBConnection.con)
            cmd.ExecuteNonQuery()
        Else
            Dim cmd As New OleDbCommand("
                DELETE FROM MemberSessions 
                WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "# AND
                actcode = " & actcode, DBConnection.con)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub addAct(field As String, actcode As String)
        field = Trim(field)
        Dim cmd As New OleDbCommand("
            INSERT INTO MemberSessions(member_id, sessiondate, session_minutes, actcode)
            VALUES(" & dgvCustomer.CurrentRow.Cells(0).Value() & ",
            #" & dgvSession.CurrentRow.Cells(0).Value() & "#, " &
            field & ", " & actcode & ")", DBConnection.con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub checkAndUpdateAct(field As String, actcode As String, Optional sessiondate As String = "")
        If sessiondate = "" Then
            sessiondate = dgvSession.CurrentRow.Cells(0).Value()
        End If
        field = Trim(field)
        'check if member already has this record
        Dim getdata = DBConnection.fetchData("SELECT * FROM MemberSessions WHERE 
        member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
        sessiondate = #" & sessiondate & "# AND
        actcode = " & actcode)

        'update if it already exists, insert if not
        If getdata.HasRows Then
            updateAct(field, actcode)
        Else
            If field <> "" Then
                addAct(field, actcode)
            End If
        End If
    End Sub



    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        Dim cmd As New OleDbCommand("
                DELETE FROM MemberSessions 
                WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "#", DBConnection.con)
        cmd.ExecuteNonQuery()
        resetFields()
    End Sub

    Private Sub resetFields()

        'reset fields for member info
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
        txtPW.Text = ""

        'reset fields for sessions
        txtUBA1.Text = ""
        txtUBA2.Text = ""
        txtUBA3.Text = ""
        txtUBA4.Text = ""
        txtUBA5.Text = ""
        txtUBA6.Text = ""
        txtUBA7.Text = ""
        txtUBA8.Text = ""
        txtUBA9.Text = ""
        txtUBA10.Text = ""
        txtUBA11.Text = ""
        txtUBA12.Text = ""
        txtUBA13.Text = ""
        txtUBA14.Text = ""
        txtUBA15.Text = ""
        txtUBA16.Text = ""
        txtUBA17.Text = ""
        txtUBA18.Text = ""

        txtLBA1.Text = ""
        txtLBA2.Text = ""
        txtLBA3.Text = ""
        txtLBA4.Text = ""
        txtLBA5.Text = ""
        txtLBA6.Text = ""
        txtLBA7.Text = ""
        txtLBA8.Text = ""
        txtLBA9.Text = ""
        txtLBA10.Text = ""
        txtLBA11.Text = ""
        txtLBA12.Text = ""
        txtLBA13.Text = ""
        txtLBA14.Text = ""
        txtLBA15.Text = ""
        txtLBA16.Text = ""
        txtLBA17.Text = ""
        txtLBA18.Text = ""

        txtCBA1.Text = ""
        txtCBA2.Text = ""
        txtCBA3.Text = ""
        txtCBA4.Text = ""
        txtCBA5.Text = ""
        txtCBA6.Text = ""
        txtCBA7.Text = ""
        txtCBA8.Text = ""
        txtCBA9.Text = ""
        txtCBA10.Text = ""
        txtCBA11.Text = ""
        txtCBA12.Text = ""
        txtCBA13.Text = ""
        txtCBA14.Text = ""
        txtCBA15.Text = ""
        txtCBA16.Text = ""
        txtCBA17.Text = ""

    End Sub
End Class