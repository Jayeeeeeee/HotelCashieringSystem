﻿Public Class Checking

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
            Login.Close()
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
        displayInfo("Select * From guest_info", dgvGuest)
        'displayInfo("Select * From guest_checkedin", dgvCheckedIn)
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        RoomsAvailable.Show()
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        If String.IsNullOrWhiteSpace(txtChckID.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Or String.IsNullOrWhiteSpace(txtRoomNumber.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim CheckIn = "Insert Into checking Values(null or '" & txtChckID.Text & "', '" & txtGuestID.Text & "', '" & txtRoomNumber.Text & "', '" & dtpCheckIn.Text & "', '" & dtpCheckOut.Text & "')"
            SQLProcess(CheckIn)

            Dim CheckInRoom = "Update rooms Set RoomStatusID = 3 Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(CheckInRoom)

            MessageBox.Show("Guest Checked-In!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Public Sub cleartxt()
        txtChckID.Text = ""
        txtGuestID.Text = ""
        txtName.Text = ""
        txtRoomNumber.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
    End Sub

    Private Sub dgvCheckedIn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckedIn.CellContentClick

    End Sub

    Private Sub dgvCheckedIn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckedIn.CellClick
        Try
            Dim i = e.RowIndex
            With dgvCheckedIn
                txtChckID.Text = .Item("Check-In ID", i).Value
                txtGuestID.Text = .Item("Guest ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                txtRoomNumber.Text = .Item("Room.No", i).Value
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