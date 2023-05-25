Imports System.Data.OleDb
Public Class admin_overview
    Private Sub admin_overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBConnection.con.Open()

        Dim customercmd As New OleDbCommand("
        SELECT Members.member_ID, Members.fname,Members.address,Members.birthday,Members.age,Members.gender,Members.contactnumber,Members.email,Members.emergencyperson,
        Members.emergencynum,Members.height,Members.weight,Members.bmi,Members.medicalcondition,Members.membersince,Members.membershiptype,Members.paymentstatus,credentials.isAdmin
        FROM Members
        INNER JOIN credentials ON Members.member_ID = credentials.member_id;
        ", DBConnection.con)

        Dim da As New OleDbDataAdapter
        da.SelectCommand = customercmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgvCustomer.DataSource = dt
        DBConnection.con.Close()
    End Sub

    Private Sub dgvCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomer.CellContentClick
        Me.Text = dgvCustomer.CurrentRow.Cells(0).Value
        txtFullname.Text = dgvCustomer.CurrentRow.Cells(1).Value
        txtAddress.Text = dgvCustomer.CurrentRow.Cells(2).Value
        txtBirthday.Text = dgvCustomer.CurrentRow.Cells(3).Value
        txtGender.Text = dgvCustomer.CurrentRow.Cells(5).Value
        txtContactNumber.Text = dgvCustomer.CurrentRow.Cells(6).Value
        txtEmail.Text = dgvCustomer.CurrentRow.Cells(7).Value
        txtEmergencyContactPerson.Text = dgvCustomer.CurrentRow.Cells(8).Value
        txtContactNumber2.Text = dgvCustomer.CurrentRow.Cells(9).Value
        txtHeight.Text = dgvCustomer.CurrentRow.Cells(10).Value
        txtWeight.Text = dgvCustomer.CurrentRow.Cells(11).Value
        txtBmi.Text = dgvCustomer.CurrentRow.Cells(12).Value
        RichTextBox1.Text = dgvCustomer.CurrentRow.Cells(13).Value
    End Sub
End Class