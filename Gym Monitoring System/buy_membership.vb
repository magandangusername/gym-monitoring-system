Public Class buy_membership
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


    End Sub

    Private Sub rdbdiscount1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount1.CheckedChanged
        If rdbdiscount1.Checked Then
            lblPriceTotal.Text = 735
        End If
    End Sub

    Private Sub rdbdiscount2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount2.CheckedChanged
        If rdbdiscount2.Checked Then
            lblPriceTotal.Text = 1425
        End If
    End Sub

    Private Sub rdbdiscount3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount3.CheckedChanged
        If rdbdiscount3.Checked Then
            lblPriceTotal.Text = 3150
        End If
    End Sub

    Private Sub rdbdiscount4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount4.CheckedChanged
        If rdbdiscount4.Checked Then
            lblPriceTotal.Text = 4785
        End If
    End Sub

    Private Sub rdbdiscount5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbdiscount5.CheckedChanged
        If rdbdiscount5.Checked Then
            lblPriceTotal.Text = 7830
        End If
    End Sub
End Class