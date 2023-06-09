﻿Imports System.Data.OleDb
Public Class progress_reports
    Const fnum1 = 655.1
    Const fnum2 = 9.563
    Const fnum3 = 1.85
    Const fnum4 = 4.676

    Const mnum1 = 66.5
    Const mnum2 = 13.75
    Const mnum3 = 5.003
    Const mnum4 = 6.75

    Const UBA1 = 5
    Const UBA2 = 5
    Const UBA3 = 8
    Const UBA4 = 5
    Const UBA5 = 8
    Const UBA6 = 4
    Const UBA7 = 4
    Const UBA8 = 6
    Const UBA9 = 3
    Const UBA10 = 4
    Const UBA11 = 5
    Const UBA12 = 6
    Const UBA13 = 8
    Const UBA14 = 10
    Const UBA15 = 10
    Const UBA16 = 10
    Const UBA17 = 10
    Const UBA18 = 10

    Const LBA1 = 6
    Const LBA2 = 6
    Const LBA3 = 7
    Const LBA4 = 4
    Const LBA5 = 5
    Const LBA6 = 7
    Const LBA7 = 6
    Const LBA8 = 5
    Const LBA9 = 4
    Const LBA10 = 3
    Const LBA11 = 4
    Const LBA12 = 4
    Const LBA13 = 5
    Const LBA14 = 5
    Const LBA15 = 5
    Const LBA16 = 10
    Const LBA17 = 10
    Const LBA18 = 10

    Const CBA1 = 4
    Const CBA2 = 6
    Const CBA3 = 6
    Const CBA4 = 5
    Const CBA5 = 4
    Const CBA6 = 5
    Const CBA7 = 5
    Const CBA8 = 6
    Const CBA9 = 8
    Const CBA10 = 8
    Const CBA11 = 8
    Const CBA12 = 7
    Const CBA13 = 8
    Const CBA14 = 8
    Const CBA15 = 10
    Const CBA16 = 10
    Const CBA17 = 10
    Dim totalcalories As Integer = 0
    'Dim UBA1, UBA2, UBA3, UBA4, UBA5, UBA6, UBA7, UBA8, UBA9, UBA10, UBA11, UBA12, UBA13, UBA14, UBA15, UBA16, UBA17, UBA18 As Integer

    'Dim LBA1, LBA2, LBA3, LBA4, LBA5, LBA6, LBA7, LBA8, LBA9, LBA10, LBA11, LBA12, LBA13, LBA14, LBA15, LBA16, LBA17, LBA18 As Integer

    'Dim CBA1, CBA2, CBA3, CBA4, CBA5, CBA6, CBA7, CBA8, CBA9, CBA10, CBA11, CBA12, CBA13, CBA14, CBA15, CBA16, CBA17 As Integer




    Private Sub LiveTotal()
        'If txtUBA1.Text = UBA1 Then
        '    totalcalories = UBA1
        'Else
        '    'totalcalories`
        'End If

    End Sub

    Private Sub progress_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnection.openCon()
        'load user info
        'note to self: this query has potential problems. remind to fix it when have time.




        Dim getCustomerInfo = DBConnection.fetchData("SELECT * FROM Members WHERE member_ID =" & DBConnection.member_id & ";")
        Dim weight As Double
        Dim height As Double
        Dim BMI As Double
        Dim age As Integer
        Dim FCalories As Double
        Dim MCalories As Double


        Dim getdata = DBConnection.fetchData("SELECT * FROM (MembershipOrder
        LEFT JOIN membership ON membership.membership_id = MembershipOrder.membership_id)
        LEFT JOIN Members ON Members.member_id = MembershipOrder.member_id
        WHERE Members.member_id = " & DBConnection.member_id & " ORDER BY membership_active_datetime DESC, membership_datetime DESC")

        If getdata.HasRows Then
            txtName.Text = getdata("fname")
            txtSubscription.Text = getdata("membership_name")
            txtEndSub.Text = CDate(getdata("membership_active_datetime")).AddDays(getdata("membership_days"))

            weight = getdata("weight")
            height = getdata("height")
            txtHeight.Text = height
            txtWeight.Text = weight
            age = CInt(getdata("age"))
        Else
            txtName.Text = getCustomerInfo("fname")
            txtSubscription.Text = "None"
            txtEndSub.Text = "None"
            txtHeight.Text = getCustomerInfo("height")
            txtWeight.Text = getCustomerInfo("weight")

            weight = getCustomerInfo("weight")
            height = getCustomerInfo("height")
            txtHeight.Text = height
            txtWeight.Text = weight
            age = CInt(getCustomerInfo("age"))
        End If


        BMI = weight / (height / 100) ^ 2
        FCalories = fnum1 + (fnum2 * weight) + (fnum3 * height) - (fnum4 * age)
        MCalories = mnum1 + (mnum2 * weight) + (mnum3 * height) - (mnum4 * age)
        txtInitialBmi.Text = BMI

        If getCustomerInfo("gender") = "Male" Then
            txtInitialCalories.Text = MCalories
        Else
            txtInitialCalories.Text = FCalories
        End If





        LiveTotal()


        'load sessions
        Dim sessioncmd As New OleDbCommand("
        SELECT MemberSessions.sessiondate as 'Session Date'
        FROM MemberSessions
        INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
        WHERE MemberSessions.member_id = " & DBConnection.member_id & " GROUP BY MemberSessions.sessiondate", DBConnection.con)

        Dim da As New OleDbDataAdapter
        da.SelectCommand = sessioncmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvSessions.DataSource = dt
        DBConnection.closeCon()
    End Sub
    Private Sub dgvSession_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellClick ', dgvSession.SelectionChanged
        resetFields("session")

        Try
            If IsNothing(dgvSessions.CurrentRow) = False Then
                txtSessionDate.Text = dgvSessions.CurrentRow.Cells(0).Value()
                loadSessions()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub
    Private Sub dgvSessions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        resetSession()
        Try
            If IsNothing(dgvSessions.CurrentRow) = False Then
                loadSession()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub resetSession()
        txtSessionDate.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtCaloriesLost.Text = ""
        txtInitialCalories.Text = ""

    End Sub

    Private Sub loadSession()
        Dim getdata = DBConnection.fetchData("
        SELECT * FROM MemberSessions
        INNER JOIN Members ON members.member_id = MemberSessions.member_id
        WHEN member_id = " & DBConnection.member_id & "
        sessiondate = #" & dgvSessions.CurrentRow.Cells(0).Value() & "#
        ")
        txtSessionDate.Text = getdata("sessiondate")
        txtHeight.Text = getdata("sessiondate")
        txtWeight.Text = getdata("sessiondate")
        txtCaloriesLost.Text = getdata("sessiondate")
        txtInitialCalories.Text = getdata("sessiondate")

    End Sub

    Private Sub dgvSessions_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessions.CellContentClick
        txtSessionDate.Text = dgvSessions.CurrentRow.Cells(0).Value

    End Sub
    Private Sub loadSessions()
        DBConnection.openCon()
        Dim sessioncmd As New OleDbCommand("
        SELECT *
        FROM MemberSessions
        INNER JOIN activitieslist ON MemberSessions.actcode = activitieslist.actcode
        WHERE MemberSessions.member_id = " & DBConnection.member_id &
        " AND sessiondate = #" & dgvSessions.CurrentRow.Cells(0).Value() & "#", DBConnection.con)

        Dim getdata = sessioncmd.ExecuteReader
        totalcalories = 0
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
            totalcalories += CInt(getdata("session_minutes")) * CInt(getdata("actvalue"))
        End While

        getdata.Close()
        txtCaloriesLost.Text = totalcalories
        DBConnection.closeCon()
    End Sub

    Private Sub resetFields(fieldType As String)


        If fieldType = "session" Then
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
End Class