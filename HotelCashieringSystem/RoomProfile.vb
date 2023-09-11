Public Class RoomProfile
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub cleartxt()
        txtRoomID.Text = ""
        cmbRoomType.Text = ""
        txtBeds.Text = ""
        cmbAvailability.Text = ""
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim out As New System.Windows.Forms.DialogResult
        out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If out Then
            Login.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
    End Sub

    Private Sub RoomProfile_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        displayInfo("Select * From room_info", dgvRoom)
        loadToComboBox("Select * From room_type", cmbRoomType)
        loadToComboBox("Select * From room_status", cmbAvailability)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim RoomDelete As New System.Windows.Forms.DialogResult
        RoomDelete = MessageBox.Show("Delete Room?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If RoomDelete = Windows.Forms.DialogResult.Yes Then
            Dim RDelete = "Delete From room_info where Room No. = '" & txtRoomID.Text & "'"
            SQLProcess(RDelete)
            MessageBox.Show("Room Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleartxt()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim RoomUpdate = "Update room_info Set No. Of Beds = '" & txtBeds.Text & "' Where Room No. = '" & txtRoomID.Text & "'"
        SQLProcess(RoomUpdate)

        Dim RTypeUpdate = "Update room_info Set Room Type = '" & cmbRoomType.Text & "' Where Room No. = '" & txtRoomID.Text & "'"
        SQLProcess(RTypeUpdate)

        Dim RAvailUpdate = "Update room_info Set Room Status = '" & cmbAvailability.Text & "' Where Room No. = '" & txtRoomID.Text & "'"
        SQLProcess(RAvailUpdate)

        MessageBox.Show("Update Successful", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cleartxt()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If String.IsNullOrWhiteSpace(txtBeds.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim RoomQuery = "Insert Into rooms Values(null or '" & txtRoomID.Text & "', '" & txtBeds.Text & "', '" & cmbRoomType.SelectedValue & "', '" & cmbRoomType.SelectedValue & "', '" & cmbAvailability.SelectedValue & "')"
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
                cmbAvailability.Text = .Item("Room Status", i).Value
            End With
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

End Class