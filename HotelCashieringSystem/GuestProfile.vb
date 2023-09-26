Public Class GuestProfile

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrGP.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub cleartxt()
        txtGuestID.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtNumber.Text = ""
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim StatusQuery = "Update emp_login Set EmpStatusID = 1 Where EmpStatusID = 2"
        Dim Out As New System.Windows.Forms.DialogResult
        Out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Out = Windows.Forms.DialogResult.Yes Then
            SQLProcess(StatusQuery)
            Me.Close()
            Login.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub GuestProfile_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From guest_info", dgvGuest)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtAddress.Text) Or String.IsNullOrWhiteSpace(txtNumber.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim AddGuest = "Insert Into guests Values(null or '" & txtGuestID.Text & "', '" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtNumber.Text & "', '" & 3 & "')"

            SQLProcess(AddGuest)

            MessageBox.Show("Guest Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim GuestDelete As New System.Windows.Forms.DialogResult
        GuestDelete = MessageBox.Show("Delete Guest?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If GuestDelete = Windows.Forms.DialogResult.Yes Then
            Dim GDelete = "Delete From guest_info where ID = '" & txtGuestID.Text & "'"
            SQLProcess(GDelete)
            MessageBox.Show("Guest Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleartxt()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub dgvGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        Try
            Dim i = e.RowIndex
            With dgvGuest
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                txtAddress.Text = .Item("Address", i).Value
                txtNumber.Text = .Item("Contact No.", i).Value
            End With
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtAddress.Text) Or String.IsNullOrWhiteSpace(txtNumber.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim UGuest = "Update guests Set GName = '" & txtName.Text & "', GAddress = '" & txtAddress.Text & "', GNum = '" & txtNumber.Text & "' Where GuestID = '" & txtGuestID.Text & "'"
            SQLProcess(UGuest)

            MessageBox.Show("Guest Profile Updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub
End Class