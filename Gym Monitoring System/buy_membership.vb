Public Class buy_membership
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
    End Sub
End Class