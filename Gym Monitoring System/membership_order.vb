Imports System.Data.OleDb
Public Class membership_order
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DBConnection.openCon()
        Dim SelectOrder As New OleDbCommand("Select * 
        FROM MembershipOrder
        WHERE membershipOrder_id = " & txtMembershipOrder.Text & ";", DBConnection.con)

        Dim getdata As OleDbDataReader
        getdata = SelectOrder.ExecuteReader
        getdata.Read()

        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to Activate this membership?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            If getdata.HasRows Then

                Dim UpdateOrder As New OleDbCommand("UPDATE MembershipOrder
            SET membership_status = 'Active'
            WHERE membershipOrder_id =" & txtMembershipOrder.Text & ";", DBConnection.con)
                MsgBox("Order " & getdata("membershipOrder_id") & " is now " & getdata("membership_status"))
            Else
                DBConnection.closeCon()
                Exit Sub
            End If
        Else
            DBConnection.closeCon()
            Exit Sub
        End If



    End Sub
End Class