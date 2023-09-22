Public Class RoomProfile

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRP.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub RoomProfile_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From room_info", dgvRoom)
        loadToComboBox("Select * From room_type", cmbRoomType)
        loadToComboBox("Select * From room_status", cmbAvailability)
    End Sub

    Private Sub cleartxt()
        txtRoomID.Text = ""
        cmbRoomType.Text = ""
        txtBeds.Text = ""
        txtRoomPrice.Text = ""
        cmbAvailability.Text = ""
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim StatusQuery = "Update emp_login Set EmpStatusID = 1 Where EmpStatusID = 2"
        Dim Out As New System.Windows.Forms.DialogResult
        Out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Out Then
            SQLProcess(StatusQuery)
            Me.Close()
            Login.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim RoomDelete As New System.Windows.Forms.DialogResult
        RoomDelete = MessageBox.Show("Delete Room?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If RoomDelete = Windows.Forms.DialogResult.Yes Then
            Dim RDelete = "Delete From rooms where RoomID = '" & txtRoomID.Text & "'"
            SQLProcess(RDelete)
            MessageBox.Show("Room Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleartxt()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim RoomUpdate = "Update rooms Set BedNum = '" & txtBeds.Text & "' Where RoomID = '" & txtRoomID.Text & "'"
        Dim RTypeUpdate = "Update rooms Set RoomTypeID = '" & cmbRoomType.SelectedValue & "' Where RoomID = '" & txtRoomID.Text & "'"
        Dim RAvailUpdate = "Update rooms Set RoomStatusID = '" & cmbAvailability.SelectedValue & "' Where RoomID = '" & txtRoomID.Text & "'"

        SQLProcess(RoomUpdate)
        SQLProcess(RTypeUpdate)
        SQLProcess(RAvailUpdate)

        MessageBox.Show("Update Successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cleartxt()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If String.IsNullOrWhiteSpace(txtBeds.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim RoomQuery = "Insert Into rooms Values('" & txtRoomID.Text & "', '" & txtBeds.Text & "', '" & cmbRoomType.SelectedValue & "', '" & cmbAvailability.SelectedValue & "')"
            SQLProcess(RoomQuery)

            MessageBox.Show("Room Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Private Sub dgvRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoom.CellClick
        Try
            Dim i = e.RowIndex
            With dgvRoom
                txtRoomID.Text = .Item("Room No.", i).Value
                cmbRoomType.Text = .Item("Room Type", i).Value
                txtBeds.Text = .Item("No. Of Beds", i).Value
                txtRoomPrice.Text = .Item("Room Price", i).Value
                cmbAvailability.Text = .Item("Room Status", i).Value
            End With
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub cmbRoomType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoomType.SelectedIndexChanged
        If cmbRoomType.Text = "Single" Then
            txtBeds.Text = 1
            txtRoomPrice.Text = 750.0

        ElseIf cmbRoomType.Text = "Double" Then
            txtBeds.Text = 2
            txtRoomPrice.Text = 850.0

        ElseIf cmbRoomType.Text = "Matrimonial" Then
            txtBeds.Text = 1
            txtRoomPrice.Text = 850.0

        End If
    End Sub
End Class