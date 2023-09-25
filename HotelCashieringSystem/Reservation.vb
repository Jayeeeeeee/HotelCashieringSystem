Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Reservation

    Private Sub tmrReserve_Tick(sender As Object, e As EventArgs) Handles tmrReserve.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
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

    Public Sub cleartxt()
        txtRoomNumber.Text = ""
        txtGuestID.Text = ""
        txtName.Text = ""
        txtPayment.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cleartxt()
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
    End Sub

    Private Sub Reservation_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From guest_info", dgvGuest)
        displayInfo("Select * From guest_reservation", dgvReserve)
        displayInfo("Select * From rooms_available", dgvAvailable)
    End Sub

    Private Sub dgGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
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

            Dim EmpQuery As New MySqlCommand("Select EmpID From emp_login Where EmpStatusID = 2", mysqlConn)
            Dim da As New MySqlDataAdapter(EmpQuery)
            Dim dt As New DataTable()
            da.Fill(dt)

            Dim ReserveQuery As New MySqlCommand("Select ReservationID From reservation Where GuestID ='" & txtGuestID.Text & "' and RoomID = '" & txtRoomNumber.Text & "'", mysqlConn)
            Dim rda As New MySqlDataAdapter(ReserveQuery)
            Dim rdt As New DataTable()
            rda.Fill(rdt)

            Dim PriceQuery As New MySqlCommand("Select RoomPrice From room_type Where RoomTypeID In (Select RoomTypeID From Rooms Where RoomID ='" & txtRoomNumber.Text & "')", mysqlConn)
            Dim pda As New MySqlDataAdapter(PriceQuery)
            Dim pdt As New DataTable()
            pda.Fill(pdt)

            Dim Payment = CInt(Int(txtPayment.Text))

            Dim Change As Integer = Payment - pdt.Rows.Item(0).Item("RoomPrice")

            Dim ReservePayment = "Insert Into reservation_payment Values(null, '" & rdt.Rows.Item(0).Item("ReservationID") & "', '" & dt.Rows.Item(0).Item("EmpID") & "', '" & txtGuestID.Text & "', '" & txtRoomNumber.Text & "', '" & Payment & "', '" & Change & "', '" & lblDateTime.Text & "')"
            SQLProcess(ReservePayment)

            MessageBox.Show("Room Resereved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Change To Be Given To The Guest: ₱" & Change, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

                Dim CPReservation = "Delete From reservation_payment where RoomID = '" & txtRoomNumber.Text & "'"
                SQLProcess(CPReservation)

                MessageBox.Show("Reservation Cancelled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cleartxt()
            End If
        End If
    End Sub

    Private Sub dgvReserve_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserve.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, -1, Now)
        dtpCheckIn.MinDate = DateAdd(DateInterval.Day, -1, Now)
        Try
            Dim i = e.RowIndex
            With dgvReserve
                Dim chckin As DateTime = DateTime.ParseExact(.Item("Check-In Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)
                Dim chckout As DateTime = DateTime.ParseExact(.Item("Check-Out Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)



                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Value = chckin
                dtpCheckOut.Value = chckout

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvAvailable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAvailable.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, 1, Now)
        dtpCheckIn.MinDate = Now
        Try
            Dim i = e.RowIndex
            With dgvAvailable
                txtRoomNumber.Text = .Item("Room No.", i).Value

            End With
            btnReserve.Enabled = True
            btnCancel.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class