Imports System.Data.OleDb
Public Class progress_reports
    Private Sub progress_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnection.openCon()
        'load user info
        'note to self: this query has potential problems. remind to fix it when have time.
        Const fnum1 = 655.1
        Const fnum2 = 9.563
        Const fnum3 = 1.85
        Const fnum4 = 4.676

        Const mnum1 = 66.5
        Const mnum2 = 13.75
        Const mnum3 = 5.003
        Const mnum4 = 6.75

        Dim getCustomerInfo = DBConnection.fetchData("SELECT * FROM Members WHERE member_ID =" & DBConnection.member_id & ";")



        Dim getdata = DBConnection.fetchData("SELECT * FROM (MembershipOrder
        LEFT JOIN membership ON membership.membership_id = MembershipOrder.membership_id)
        LEFT JOIN Members ON Members.member_id = MembershipOrder.member_id
        WHERE Members.member_id = " & DBConnection.member_id & " ORDER BY membership_active_datetime DESC, membership_datetime DESC")
        txtName.Text = getdata("fname")
        txtSubscription.Text = getdata("membership_name")
        txtEndSub.Text = CDate(getdata("membership_active_datetime")).AddDays(getdata("membership_days"))
        txtHeight.Text = getdata("height")
        txtWeight.Text = getdata("weight")



        Dim weight As Double = getdata("weight")
        Dim height As Double = getdata("height")
        Dim BMI As Double = (weight) / (height ^ 2)
        Dim age As String
        Dim FCalories As Double = fnum1 + (fnum2 * weight) + (fnum3 * height) - (fnum4 * age)
        Dim MCalories As Double = mnum1 + (mnum2 * weight) + (mnum3 * height) - (mnum4 * age)
        txtInitialBmi.Text = BMI
        MsgBox(getCustomerInfo("gender"))
        If getCustomerInfo("gender") = "Male" Then
            txtInitialCalories.Text = MCalories
        Else
            txtInitialCalories.Text = FCalories
        End If


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
End Class