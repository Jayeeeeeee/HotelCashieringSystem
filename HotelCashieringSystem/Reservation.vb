﻿Public Class Reservation

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

    Public Sub cleartxt()
        txtRoomNumber.Text = ""
        txtGuestID.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRoomNumber.Text = ""
        txtGuestID.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub Reservation_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From guest_info", dgvGuest)
        displayInfo("Select * From guest_reservation", dgvReserve)
        displayInfo("Select * From rooms_available", dgvAvailable)
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
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
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Reserve = "Insert Into reservation Values(null, '" & txtGuestID.Text & "', '" & txtRoomNumber.Text & "', '" & dtpCheckIn.Text & "', '" & dtpCheckOut.Text & "', '" & 1 & "')"
            SQLProcess(Reserve)

            Dim ReserveRoom = "Update rooms Set RoomStatusID = 2 Where RoomID = '" & txtRoomNumber.Text & "'"
            SQLProcess(ReserveRoom)

            Dim CStatus = "Update guests Set CStatusID = 2  Where GuestID = '" & txtGuestID.Text & "'"
            SQLProcess(CStatus)

            MessageBox.Show("Room Resereved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cleartxt()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Cancel As New System.Windows.Forms.DialogResult
            Cancel = MessageBox.Show("Cancel Reservation?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Cancel = Windows.Forms.DialogResult.Yes Then
                Dim CReservation = "Delete From reservation where RoomID = '" & txtRoomNumber.Text & "'"
                SQLProcess(CReservation)

                Dim CRoom = "Update rooms Set RoomStatusID = 1 Where RoomID = '" & txtRoomNumber.Text & "'"
                SQLProcess(CRoom)

                Dim CStatus = "Update guests Set CStatusID = 3  Where GuestID = '" & txtGuestID.Text & "'"
                SQLProcess(CStatus)

                MessageBox.Show("Reservation Cancelled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cleartxt()
            End If
        End If
    End Sub

    Private Sub dgvReserve_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserve.CellClick
        Try
            Dim i = e.RowIndex
            With dgvReserve
                Dim chckin = .Item("Check-In Date", i).Value
                Dim chckout = .Item("Check-Out Date", i).Value

                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Value = Date.ParseExact(chckin, "MM/dd/yyyy - h:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
                dtpCheckOut.Value = Date.ParseExact(chckout, "MM/dd/yyyy - h:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellClick
        Try
            Dim i = e.RowIndex
            With dgvAvailable
                txtRoomNumber.Text = .Item("Room No.", i).Value

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class