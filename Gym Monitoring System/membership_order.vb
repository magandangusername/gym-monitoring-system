Imports System.Data.OleDb
Public Class membership_order
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DBConnection.openCon()
        'checking of order ID
        Dim order_id As String = txtMembershipOrder.Text.Remove(0, 4)
        Dim SelectOrder = DBConnection.fetchData("Select * 
        FROM MembershipOrder
        WHERE membershipOrder_id = " & order_id)


        If SelectOrder.HasRows Then
            Dim result As MsgBoxResult

            result = MsgBox("Are you sure you want to Activate this membership?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                If getdata.HasRows Then

                    Dim UpdateOrder As New OleDbCommand("UPDATE MembershipOrder
            SET membership_status = 'Active', membership_active_datetime = #" & Today.ToShortDateString & "# 
            WHERE membershipOrder_id = " & order_id & ";", DBConnection.con)

                    If UpdateOrder.ExecuteNonQuery() Then
                        MsgBox("Order " & txtMembershipOrder.Text & " is now Active!")
                        txtMembershipOrder.Clear()
                    Else
                        MsgBox("Error occured updating data.")
                        DBConnection.closeCon()
                        Exit Sub
                    End If

                Else
                    MsgBox("Order ID does not exist.")
                    DBConnection.closeCon()
                    Exit Sub
                End If
            Else
                DBConnection.closeCon()
                Exit Sub
            End If
        End If

        DBConnection.closeCon()


    End Sub
End Class