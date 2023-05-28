Public Class member_dashboard
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        profile.Show()
    End Sub

    Private Sub btnBuyMembership_Click(sender As Object, e As EventArgs) Handles btnBuyMembership.Click
        DBConnection.openCon()

        Dim getdata = DBConnection.fetchData("SELECT * FROM MembershipOrder WHERE member_id = " & DBConnection.member_id & " AND membership_status = 'Pending'")
        If getdata.HasRows Then
            Dim result As MsgBoxResult = MsgBox("You currently have a pending membership order. Continue?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.No Then
                DBConnection.closeCon()
                Exit Sub
            End If
        End If
        DBConnection.closeCon()
        buy_membership.Show()
    End Sub

    Private Sub member_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        RichTextBox1.Text = "   
    UPPER BODY includes arms, shoulders and upper back. Some of the most common exercises for the upper body are biceps curls, triceps curls, bench presses, overhead presses, lateral raises, and upright rows.

    Why It’s Important: 
            Working the upper body tones the arms and helps you not only look good, but maintain upper body strength. As we get older–and I’m talking even past age 30–we slowly but surely start to lose muscle. Exercise is key to maintaining muscle mass as the years go by. Upper body workouts also work the shoulders and muscles of the upper back. This aids in keeping good posture as strong muscles help support the upper spine. Good posture allows your lungs and diaphragm to fully expand, aiding in respiratory health.
"
        RichTextBox2.Text = "
    CORE part includes your upper and lower abdominal muscles and back muscles. Some of the most common core exercises are sit-ups of various kinds, push-ups (men’s or women’s), leg raises, and planks. (Upper body workouts also help the core as your stomach muscles should be engaged as you lift.)

    Why It’s Important: 
            Your core supports your back, which in turn supports your entire body. Having strong stomach and back muscles helps take some of the load off of your spine. It helps improve balance, stability, and posture.
"
        RichTextBox3.Text = "
            Lower body includes legs and glutes. Some of the most common exercises for the lower body are lunges, squats, step-ups, mountain climbers, and squat-thrusts.

        Why It’s Important: 
            Working the lower body tones the legs and glutes, and helps you maintain lower body strength. Powerful leg muscles allow us to climb stairs easily, to squat down and retrieve something off the floor, to get back up if we have fallen. Strong leg muscles also help protect our knees and hips from injury. They help us preserve our mobility, agility and stability as we age, and are helpful in maintaining our balance.
"
        lblWarning.Text = ""
        DBConnection.openCon()
        'MsgBox("SELECT * 
        'FROM MembershipOrder 
        'INNER JOIN membership ON membership.membership_id = MembershipOrder.membership_id 
        'INNER JOIN Members ON Members.member_id = MembershipOrder.member_id 
        'WHERE MembershipOrder.member_id = " & DBConnection.member_id & " ORDER BY membership_active_datetime DESC")
        Dim getdata = DBConnection.fetchData("SELECT * 
        FROM MembershipOrder 
        INNER JOIN membership ON membership.membership_id = MembershipOrder.membership_id 
        WHERE MembershipOrder.member_id = " & DBConnection.member_id & " ORDER BY membership_active_datetime DESC")
        If getdata.HasRows Then
            If getdata("membership_status") = "Active" Then
                lblMemStat.Text = "ACTIVE"
                Dim daysleft = DateDiff("d", Today, CDate(getdata("membership_active_datetime")).AddDays(getdata("membership_days")))
                If daysleft <= 0 Then
                    lblMemStat.Text = "INACTIVE"
                    daysleft = 0
                ElseIf daysleft < 3 Then
                    lblWarning.Text = "Warning: membership is expiring in " & daysleft & "day(s)!"
                End If
                lblDaysLeft.Text = daysleft
                lblMembership.Text = getdata("membership_name")
                getdata = DBConnection.fetchData("SELECT * FROM Members WHERE member_id = " & DBConnection.member_id)
                lblUser.Text = getdata("fname") & "!"
            End If
        End If


        DBConnection.closeCon()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        progress_report.Show()
    End Sub
End Class