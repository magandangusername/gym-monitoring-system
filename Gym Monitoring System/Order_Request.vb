Imports System.Data.OleDb
Public Class Order_Request
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Order Request Printed")
    End Sub

    Private Sub Order_Request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display needed info
        lblCurrDateTime.Text = Today.ToShortDateString & " " & Now.ToShortTimeString
        Call DBConnection.con.Open()
        Dim MemberProfile As New OleDbCommand("SELECT * FROM Members where member_id = " & DBConnection.member_id, con)
        Dim getdata As OleDbDataReader
        getdata = MemberProfile.ExecuteReader
        getdata.Read()
        lblName.Text = getdata("fname")
        lblAddress.Text = getdata("address")
        lblContact.Text = getdata("contactnumber")

        getdata.Close()
        Call DBConnection.con.Close()

        'fetch values from other forms
        lblMembership.Text = buy_membership.membership
        lblPrice.Text = buy_membership.origPrice
        lblDiscount.Text = buy_membership.discount
        lblDiscounted.Text = buy_membership.discountedPrice
    End Sub
End Class