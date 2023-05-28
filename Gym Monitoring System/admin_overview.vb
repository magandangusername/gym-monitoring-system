Imports System.Data.OleDb
Public Class admin_overview

    Private Sub dgvSession_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSession.CellClick ', dgvSession.SelectionChanged
        resetFields("session")
        Try
            If IsNothing(dgvSession.CurrentRow) = False Then
                dtSession.Value = dgvSession.CurrentRow.Cells(0).Value()
                loadSessions()
            End If
        Catch ex As Exception
            dtSession.Value = Today
        End Try




    End Sub

    Private Sub dgvCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellClick ', dgvCustomer.SelectionChanged
        Try
            'Me.Text = dgvCustomer.CurrentRow.Cells(0).Value
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

            reloadSessions()

        Catch ex As Exception

        End Try


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
        'no validation required for admin
        DBConnection.openCon()
        Try
            Dim addcmd As New OleDbCommand("INSERT INTO Members (fname,address,birthday,gender,contactnumber,email,emergencyperson,
            emergencynum,height,weight,bmi,medicalcondition) 
            values ('" & txtFullname.Text & "','" & txtAddress.Text & "', #" & txtBirthday.Text & "#,  '" & txtGender.Text & "', '" & txtContactNumber.Text & "', '" & txtEmail.Text & "', '" & txtEmergencyContactPerson.Text & "', '" & txtContactNumber2.Text & "', '" & txtHeight.Text & "', '" & txtWeight.Text & "', '" & txtBmi.Text & "', '" & RichTextBox1.Text & "');", DBConnection.con)
            addcmd.ExecuteNonQuery()
            Dim getdata = DBConnection.fetchData("SELECT member_id FROM Members ORDER BY member_id DESC")
            Dim pw = "INSERT INTO credentials (member_id,member_password) VALUES (" & getdata("member_id") & ",'" & txtPW.Text & "')"
            Dim addpwcmd As New OleDbCommand(pw, DBConnection.con)
            If addpwcmd.ExecuteNonQuery > 0 Then
                MsgBox("New record has been inserted successfully!")
            Else
                MsgBox("Record occured creating record")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DBConnection.closeCon()

        End Try
        resetFields("member")
        loadMembers()
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        DBConnection.openCon()
        Try
            Dim getdata = DBConnection.fetchData("SELECT * FROM MemberSessions WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND sessiondate = #" & dtSession.Value.ToShortDateString & "#")
            If getdata.HasRows = False Then
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

                reloadSessions()
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
                SET fname ='" & txtFullname.Text & "', address ='" & txtAddress.Text & "', birthday = #" & txtBirthday.Text & "#, gender ='" & txtGender.Text & "', contactnumber ='" & txtContactNumber.Text & "', email ='" & txtEmail.Text & "', emergencyperson ='" & txtEmergencyContactPerson.Text & "', emergencynum ='" & txtContactNumber2.Text & "', height ='" & txtHeight.Text & "', weight ='" & txtWeight.Text & "', bmi ='" & txtBmi.Text & "', medicalcondition ='" & RichTextBox1.Text & "'
                WHERE member_ID = " & dgvCustomer.CurrentRow.Cells(0).Value() & "", DBConnection.con)

                Dim i = updatecmd.ExecuteNonQuery

                If Trim(txtPW.Text) <> "" Then
                    Dim updatePWcmd As New OleDbCommand("Update credentials
                    SET member_password ='" & txtPW.Text & "'
                    WHERE member_ID = " & Me.Text & "", DBConnection.con)
                    updatePWcmd.ExecuteNonQuery()
                End If


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

    Private Sub admin_overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load, btnUpdate.Click, btnAdd.Click, btnDelete.Click
        Dim getdata = DBConnection.fetchData("SELECT * FROM Members WHERE member_id = " & DBConnection.member_id)
        lblAdminName.Text = "Welcome " & getdata("fname") & "!"
        'reset fields
        resetFields("member")
        resetFields("session")

        'load data
        loadMembers()

        'Load Admin in datagridview\
        loadAdmin()

        reloadCustomer()
    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        Dim getdata As OleDbDataReader
        DBConnection.openCon()
        'check session date if changed
        If dtSession.Value.ToShortDateString <> dgvSession.CurrentRow.Cells(0).Value() Then
            'confirm change of session date
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to move this to another session date?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                'check if new session date already exists
                getdata = DBConnection.fetchData("SELECT * FROM MemberSessions WHERE 
                member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "#")
                If getdata.HasRows Then
                    'remove the old session if it exists and confirmed to replace
                    result = MsgBox("A session with this date already exists, do you want to replace it?", MsgBoxStyle.YesNo)
                    If result = MsgBoxResult.Yes Then
                        Dim delSessionCMD As New OleDbCommand("
                        DELETE MemberSessions WHERE
                        sessiondate = #" & dtSession.Value.ToShortDateString & "# AND
                        member_id = " & dgvCustomer.CurrentRow.Cells(0).Value(), DBConnection.con)
                        delSessionCMD.ExecuteNonQuery()
                    Else
                        DBConnection.closeCon()
                        Exit Sub
                    End If
                End If
            Else
                DBConnection.closeCon()
                Exit Sub
            End If

        End If

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

        DBConnection.closeCon()
        resetFields("session")
    End Sub

    Private Sub loadMembers()
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

        Dim da As New OleDbDataAdapter
        da.SelectCommand = customercmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvCustomer.DataSource = dt
        DBConnection.closeCon()
    End Sub



    Private Sub reloadSessions()
        resetFields("session")
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

    Private Sub reloadCustomer()
        'DBConnection.openCon()


        'Dim loadcmd As New OleDbCommand("
        'SELECT Member.member_ID, Members.fname, Members.email, credentials.member_password
        'FROM Members
        'INNER JOIN credentials ON Members.members_ID = credentials.members_id
        'WHERE Members.member_ID = " & DataGridView2.CurrentRow.Cells(0).Value() & "", DBConnection.con)

        'Dim da As New OleDbDataAdapter
        'da.SelectCommand = loadcmd
        'Dim dt As New DataTable
        'dt.Clear()
        'da.Fill(dt)
        'dgvSession.DataSource = dt
        'DBConnection.closeCon()
    End Sub

    Private Sub loadSessions()
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

    Private Sub updateAct(field As String, actcode As String, Optional sessiondate As String = "")
        If sessiondate = "" Then
            sessiondate = dtSession.Value.ToShortDateString
        End If
        field = Trim(field)
        If field <> "" Then
            Dim cmd As New OleDbCommand("
                UPDATE MemberSessions SET
                session_minutes = " & field & "
                WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & sessiondate & "# AND
                actcode = " & actcode, DBConnection.con)
            cmd.ExecuteNonQuery()
        Else
            Dim cmd As New OleDbCommand("
                DELETE FROM MemberSessions 
                WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & sessiondate & "# AND
                actcode = " & actcode, DBConnection.con)
            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub addAct(field As String, actcode As String, Optional sessiondate As String = "")
        If sessiondate = "" Then
            sessiondate = dtSession.Value.ToShortDateString
        End If
        field = Trim(field)
        Dim cmd As New OleDbCommand("
            INSERT INTO MemberSessions(member_id, sessiondate, session_minutes, actcode)
            VALUES(" & dgvCustomer.CurrentRow.Cells(0).Value() & ",
            #" & sessiondate & "#, " &
            field & ", " & actcode & ")", DBConnection.con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub checkAndUpdateAct(field As String, actcode As String, Optional sessiondate As String = "")
        If sessiondate = "" Then
            sessiondate = dtSession.Value.ToShortDateString
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
        DBConnection.openCon()
        Dim cmd As New OleDbCommand("
                DELETE FROM MemberSessions 
                WHERE member_id = " & dgvCustomer.CurrentRow.Cells(0).Value() & " AND 
                sessiondate = #" & dgvSession.CurrentRow.Cells(0).Value() & "#", DBConnection.con)
        cmd.ExecuteNonQuery()
        DBConnection.closeCon()
        resetFields("session")
        reloadSessions()
    End Sub

    Private Sub resetFields(fieldType As String)

        If fieldType = "member" Then
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
        ElseIf fieldType = "session" Then
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
        End If
    End Sub

    Private Sub btnMembershipOrder_Click(sender As Object, e As EventArgs) Handles btnMembershipOrder.Click
        membership_order.Show()
    End Sub

    Private Sub unlockFields(Optional fieldType As String = "")
        If fieldType = "member" Or fieldType = "" Then
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
        ElseIf fieldType = "session" Or fieldType = "" Then
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
        End If
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        DBConnection.openCon()
        Try
            Dim addcmd As New OleDbCommand("INSERT INTO Members (fname,email) 
            values ('" & txtAdminName.Text & "','" & txtAdminEmail.Text & "');", DBConnection.con)
            addcmd.ExecuteNonQuery()
            Dim getdata = DBConnection.fetchData("SELECT member_id FROM Members ORDER BY member_id DESC")
            Dim pw = "INSERT INTO credentials (member_id,member_password,isAdmin) VALUES (" & getdata("member_id") & ",'" & txtPassword.Text & "', 'Y');"
            Dim addpwcmd As New OleDbCommand(pw, DBConnection.con)
            Dim mem = "INSERT INTO Members (fname,email) VALUES (" & txtAdminName.Text & ",'" & txtAdminEmail.Text & "');"
            If addpwcmd.ExecuteNonQuery > 0 Then
                MsgBox("New record has been inserted successfully!")
            Else
                MsgBox("Record occured creating record")
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

    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        DBConnection.openCon()
        If txtAdminName.Text <> Nothing And txtAdminEmail.Text <> Nothing And txtPassword.Text <> Nothing Then
            Try
                'Dim birthday = Str(dtpbirthday.Value().Year) & "-" & Str(dtpbirthday.Value().Month) & "-" & Str(dtpbirthday.Value().Day)
                Dim updatecmd As New OleDbCommand("Update Members
                SET fname ='" & txtAdminName.Text & "', email ='" & txtAdminEmail.Text & "'
                WHERE member_ID = " & Me.Text & "", DBConnection.con)

                Dim i = updatecmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Record Has Been UPDATED SUCCESSFULLY!", MessageBoxIcon.Information)

                Else
                    MsgBox("Record Update Failed!", MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString, MessageBoxIcon.Error)
            Finally
                DBConnection.closeCon()

            End Try
        Else
            MsgBox("All Fields Are Required", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
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
                    txtEmail.Text = ""
                    txtPassword.Text = ""
                End If
            Else
                MsgBox("Please Select A Data!", MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            DBConnection.closeCon()

        End Try
    End Sub
    Private Sub loadAdmin()
        DBConnection.openCon()

        Dim admincmd As New OleDbCommand("
        SELECT Members.member_ID, 
        Members.fname, 
        Members.email,
credentials.member_password
        FROM Members
        INNER JOIN credentials ON Members.member_ID = credentials.member_id
        WHERE credentials.isAdmin <> 'N'", DBConnection.con)

        'Dim adminreader As OleDbDataReader
        'adminreader = customercmd.ExecuteReader
        'If Me.Text = adminreader("credentials.member_id") Then
        '    lblAdminName = "Welcome " & adminreader("fname")
        'End If

        Dim da As New OleDbDataAdapter
        da.SelectCommand = admincmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView2.DataSource = dt
        DBConnection.closeCon()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Me.Text = DataGridView2.CurrentRow.Cells(0).Value
        txtAdminName.Text = DataGridView2.CurrentRow.Cells(1).Value
        txtAdminEmail.Text = DataGridView2.CurrentRow.Cells(2).Value
        txtPassword.Text = DataGridView2.CurrentRow.Cells(3).Value
        reloadCustomer()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        DBConnection.member_id = ""
        login.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClearMembersFields.Click
        resetFields("member")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnClearSessionFields.Click
        resetFields("session")
    End Sub
End Class