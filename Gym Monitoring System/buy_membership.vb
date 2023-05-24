Imports System.Data.OleDb
Public Class buy_membership
    'for accessability for other forms
    Public membership As String
    Public origPrice As Integer
    Public discount As Integer
    Public discountedPrice As Integer
    Dim getData As OleDbDataReader
    Dim membership_id As String

    'discount
    '
    'membership 1 
    '    2% of 750 = 0.02 × 750 = 15
    '    750 – 15 = 735
    'membership 2
    '    5% of 1500 = 0.05 × 1500 = 75
    '    1500 – 75 = 1425
    'membership 3
    '    10% of 3500 = 0.10 × 3500 = 350
    '    3500 – 350 = 3150
    'membership 4 
    '    13% of 5500 = 0.13 × 5500 = 715
    '    5500 – 715 = 4785
    'membership 5
    '    13% of 9000 = 0.13 × 9000 = 1170
    '    9000 – 1170 = 7830
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If rdbdiscount1.Checked Then
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to buy a 2 Weeks Membership?", MsgBoxStyle.YesNo)

            If (result = MsgBoxResult.Yes) Then
                Me.Hide()
                Order_Request.Show()
            End If
        End If
        If rdbdiscount2.Checked Then
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to buy a 1 Month Membership?", MsgBoxStyle.YesNo)

            If (result = MsgBoxResult.Yes) Then
                Me.Hide()
                Order_Request.Show()
            End If
        End If
        If rdbdiscount3.Checked Then
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to buy a 3 Months Membership?", MsgBoxStyle.YesNo)

            If (result = MsgBoxResult.Yes) Then
                Me.Hide()
                Order_Request.Show()
            End If
        End If
        If rdbdiscount4.Checked Then
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to buy a 6 Months Membership?", MsgBoxStyle.YesNo)

            If (result = MsgBoxResult.Yes) Then
                Me.Hide()
                Order_Request.Show()
            End If
        End If
        If rdbdiscount5.Checked Then
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to buy a 1 Year Membership?", MsgBoxStyle.YesNo)

            If (result = MsgBoxResult.Yes) Then
                Me.Hide()
                Order_Request.Show()
            End If
        End If

        DBConnection.con.Open()
        Dim insertMembership As New OleDbCommand("INSERT INTO MembershipOrder(
        membership_id,
        member_id,
        total_price,
        membership_datetime,
        membership_status
        ) VALUES(" &
        membership_id & "," &
        DBConnection.member_id & "," &
        discountedPrice & ",'" &
        Today.ToShortDateString & " " & Now.ToShortTimeString & "','" &
        "Pending" & "')", con)
        MsgBox("INSERT INTO MembershipOrder(
        membership_id,
        member_id,
        total_price,
        membership_datetime,
        membership_status
        ) VALUES(" &
        membership_id & "," &
        DBConnection.member_id & "," &
        discountedPrice & ",'" &
        Today.ToShortDateString & " " & Now.ToShortTimeString & "','" &
        "Pending" & "')")
        insertMembership.ExecuteNonQuery()

        DBConnection.con.Close()





    End Sub

    Private Sub rdbdiscount1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount1.CheckedChanged
        If rdbdiscount1.Checked Then
            '    2% of 750 = 0.02 × 750 = 15
            '    750 – 15 = 735
            DBConnection.con.Open()
            membership = "2 Weeks"
            getData = DBConnection.fetchData("SELECT * FROM membership WHERE membership_name = '" & membership & "'")
        origPrice = CInt(getData("membership_price"))
            membership_id = getData("membership_id")
            discount = 2
            discountedPrice = origPrice - ((discount / 100) * origPrice)
            lblPriceTotal.Text = discountedPrice
            DBConnection.con.Close()
        End If
    End Sub

    Private Sub rdbdiscount2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount2.CheckedChanged
        If rdbdiscount2.Checked Then
            DBConnection.con.Open()
            membership = "1 Month"
            getData = DBConnection.fetchData("SELECT * FROM membership WHERE membership_name = '" & membership & "'")
            origPrice = CInt(getData("membership_price"))
            membership_id = getData("membership_id")
            discount = 5
            discountedPrice = origPrice - ((discount / 100) * origPrice)
            lblPriceTotal.Text = discountedPrice
            DBConnection.con.Close()
        End If
    End Sub

    Private Sub rdbdiscount3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount3.CheckedChanged
        If rdbdiscount3.Checked Then
            DBConnection.con.Open()
            membership = "3 Months"
            getData = DBConnection.fetchData("SELECT * FROM membership WHERE membership_name = '" & membership & "'")
            origPrice = CInt(getData("membership_price"))
            membership_id = getData("membership_id")
            discount = 10
            discountedPrice = origPrice - ((discount / 100) * origPrice)
            lblPriceTotal.Text = discountedPrice
            DBConnection.con.Close()
        End If
    End Sub

    Private Sub rdbdiscount4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount4.CheckedChanged
        If rdbdiscount4.Checked Then
            DBConnection.con.Open()
            membership = "6 Months"
            getData = DBConnection.fetchData("SELECT * FROM membership WHERE membership_name = '" & membership & "'")
            origPrice = CInt(getData("membership_price"))
            membership_id = getData("membership_id")
            discount = 13
            discountedPrice = origPrice - ((discount / 100) * origPrice)
            lblPriceTotal.Text = discountedPrice
            DBConnection.con.Close()
        End If
    End Sub

    Private Sub rdbdiscount5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount5.CheckedChanged
        If rdbdiscount5.Checked Then
            DBConnection.con.Open()
            membership = "1 Year"
            getData = DBConnection.fetchData("SELECT * FROM membership WHERE membership_name = '" & membership & "'")
            origPrice = CInt(getData("membership_price"))
            membership_id = getData("membership_id")
            discount = 13
            discountedPrice = origPrice - ((discount / 100) * origPrice)
            lblPriceTotal.Text = discountedPrice
            DBConnection.con.Close()
        End If
    End Sub
End Class