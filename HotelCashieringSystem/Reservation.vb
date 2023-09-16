Public Class Reservation

    Public Sub tmrReserve_Tick(sender As Object, e As EventArgs) Handles tmrReserve.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim out As New System.Windows.Forms.DialogResult
        out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If out Then
            Me.Close()
            Login.Show()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        RoomsAvailable.Show()
    End Sub

    Public Sub cleartxt()
        txtReserveID.Text = ""
        txtName.Text = ""
        txtRoomNumber.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtReserveID.Text = ""
        txtGuestID.Text = ""
        txtName.Text = ""
        txtRoomNumber.Text = ""
    End Sub

    Private Sub Reservation_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From guest_info", dgvGuest)
        displayInfo("Select * From guest_reservation", dgvReserve)
        displayInfo("Select * From rooms_available", dgvAvailable)
    End Sub

    Private Sub dgGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        Try
            Dim i = e.RowIndex
            With dgvGuest
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        If String.IsNullOrWhiteSpace(txtReserveID.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtRoomNumber.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim CheckIn = "Insert Into reservation Values(null or '" & txtReserveID.Text & "', '" & txtGuestID.Text & "', '" & txtRoomNumber.Text & "', '" & dtpCheckIn.Text & "', '" & dtpCheckOut.Text & "')"
            SQLProcess(CheckIn)

            Dim CheckInRoom = "Update rooms Set RoomStatusID = 2 Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(CheckInRoom)

            MessageBox.Show("Room Resereved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If String.IsNullOrWhiteSpace(txtReserveID.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtRoomNumber.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Cancel As New System.Windows.Forms.DialogResult
            If Cancel = Windows.Forms.DialogResult.Yes Then
                Cancel = MessageBox.Show("Cancel Reservation?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Dim CReservation = "Delete From reservation where ReservationID = '" & txtReserveID.Text & "'"
                SQLProcess(CReservation)

                Dim CRoom = "Update rooms Set RoomStatusID = 1 Where RoomID = '" & txtRoomNumber.Text & "'"
                SQLProcess(CRoom)

                MessageBox.Show("Reservation Cancelled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cleartxt()
            End If
        End If
    End Sub

    Private Sub dgvReserve_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserve.CellClick
        Try
            Dim i = e.RowIndex
            With dgvReserve
                txtReserveID.Text = .Item("Check-In ID", i).Value
                txtGuestID.Text = .Item("Guest ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                txtRoomNumber.Text = .Item("Room.No", i).Value
                dtpCheckIn.Value = .Item("Check-In Date", i).Value
                dtpCheckOut.Value = .Item("Check-Out Date", i).Value

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

End Class