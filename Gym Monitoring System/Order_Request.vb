Imports System.Data.OleDb
Public Class Order_Request
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Order Request Printed")
    End Sub

    Private Sub Order_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display needed info
        lblCurrDateTime.Text = Today.ToShortDateString & " " & Now.ToShortTimeString
        Call DBConnection.con.Open()
        Dim getdata = DBConnection.fetchData("SELECT * FROM Members INNER JOIN MembershipOrder ON MembershipOrder.member_id = Members.member_ID WHERE Members.member_ID = " & DBConnection.member_id & " ORDER BY membership_datetime DESC")
        If getdata.HasRows Then
            lblOrderID.Text = Format(getdata("membershipOrder_id"), "1101####")
            lblName.Text = getdata("fname")
            lblAddress.Text = getdata("address")
            lblContact.Text = getdata("contactnumber")
        Else
            MsgBox("Error occured fetching data")

        End If


        getdata.Close()
        Call DBConnection.con.Close()

        'fetch values from other forms
        lblMembership.Text = buy_membership.membership
        lblPrice.Text = buy_membership.origPrice
        lblDiscount.Text = buy_membership.discount
        lblDiscounted.Text = buy_membership.discountedPrice
    End Sub
End Class