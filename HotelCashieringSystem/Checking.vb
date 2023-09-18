Public Class Checking

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
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

    Private Sub dgGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        Try
            Dim i = e.RowIndex
            With dgvGuest
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub Checking_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From guest_avail", dgvGuest)
        displayInfo("Select * From guest_checkedin", dgvCheckedIn)
        displayInfo("Select * From rooms_available", dgvAvailable)
        displayInfo("Select * From guest_reservation", dgvReserve)
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim CheckIn = "Insert Into checkin Values(null, '" & txtGuestID.Text & "', '" & txtRoomNumber.Text & "', '" & dtpCheckIn.Text & "', '" & dtpCheckOut.Text & "', '" & 1 & "')"
            SQLProcess(CheckIn)

            Dim CheckInRoom = "Update rooms Set RoomStatusID = 3 Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(CheckInRoom)

            Dim RStatus = "Update reservation Set RStatusID = 2  Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(RStatus)

            Dim CStatus = "Update guests Set CStatusID = 1  Where GuestID = '" & txtGuestID.Text & "'"
            SQLProcess(CStatus)

            MessageBox.Show("Guest Checked-In!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Public Sub cleartxt()
        txtRoomNumber.Text = ""
        txtGuestID.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
    End Sub

    Private Sub dgvCheckedIn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckedIn.CellClick
        Try
            Dim i = e.RowIndex
            With dgvCheckedIn
                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Value = .Item("Check-In Date", i).Value
                dtpCheckOut.Value = .Item("Check-Out Date", i).Value

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellClick
        Try
            Dim i = e.RowIndex
            With dgvAvailable
                txtRoomNumber.Text = .Item("Room No.", i).Value

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim CheckOutStatus = "Update checkin Set ChckStatusID = 2 Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(CheckOutStatus)

            Dim CheckInRoom = "Update rooms Set RoomStatusID = 1 Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(CheckInRoom)

            Dim CStatus = "Update guests Set CStatusID = 3  Where GuestID = '" & txtGuestID.Text & "'"
            SQLProcess(CStatus)

            MessageBox.Show("Guest Checked-Out!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Private Sub dgvReserve_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserve.CellClick
        Try
            Dim i = e.RowIndex
            With dgvReserve
                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Value = .Item("Check-In Date", i).Value
                dtpCheckOut.Value = .Item("Check-Out Date", i).Value

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class