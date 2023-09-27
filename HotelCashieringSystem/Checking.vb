Imports System.Diagnostics.Tracing
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Checking

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
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
        If Out = Windows.Forms.DialogResult.Yes Then
            SQLProcess(StatusQuery)
            Me.Close()
            Login.Show()
        Else
            Me.Show()
        End If
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
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim CIn As New System.Windows.Forms.DialogResult
            CIn = MessageBox.Show("Check-In On Room No. " & txtRoomNumber.Text & "?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If CIn = Windows.Forms.DialogResult.Yes Then
                Dim CheckIn = "Insert Into checkin Values(null, '" _
                                                         & txtGuestID.Text & "', '" _
                                                         & txtRoomNumber.Text & "', '" _
                                                         & dtpCheckIn.Text & "', '" _
                                                         & dtpCheckOut.Text & "', '" _
                                                         & 1 & "')"
                SQLProcess(CheckIn)

                'Dim ReserveStatus = "Update reservation_payment Set RStatusID = 2 Where RoomID = '" & txtRoomNumber.Text & "' And GuestID = '" & txtGuestID.Text & "'"
                'SQLProcess(ReserveStatus)

                Dim CheckInRoom = "Update rooms Set RoomStatusID = 3 Where RoomID = '" & txtRoomNumber.Text & "'"
                SQLProcess(CheckInRoom)

                Dim RStatus = "Update reservation Set RStatusID = 2  where RoomID = '" & txtRoomNumber.Text &
                                                                         "' And GuestID = '" & txtGuestID.Text &
                                                                         "' And CIDate = '" & dtpCheckIn.Text &
                                                                         "' And CODate = '" & dtpCheckOut.Text & "'"
                SQLProcess(RStatus)

                Dim CStatus = "Update guests Set CStatusID = 1  Where GuestID = '" & txtGuestID.Text & "'"
                SQLProcess(CStatus)

                Dim EmpQuery As New MySqlCommand("Select EmpID From emp_login Where EmpStatusID = 2", mysqlConn)
                Dim da As New MySqlDataAdapter(EmpQuery)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim ChckinQuery As New MySqlCommand("Select ChckID From checkin Where GuestID ='" & txtGuestID.Text &
                                                    "' and RoomID = '" & txtRoomNumber.Text & "'", mysqlConn)
                Dim cda As New MySqlDataAdapter(ChckinQuery)
                Dim cdt As New DataTable()
                cda.Fill(cdt)

                Dim PriceQuery As New MySqlCommand("Select RoomPrice From room_type Where RoomTypeID In (Select RoomTypeID From Rooms Where RoomID ='" & txtRoomNumber.Text & "')", mysqlConn)
                Dim pda As New MySqlDataAdapter(PriceQuery)
                Dim pdt As New DataTable()
                pda.Fill(pdt)

                Dim ChckStatus As New MySqlCommand("Select RoomStatusID From rooms Where RoomID = '" & txtRoomNumber.Text & "'", mysqlConn)
                Dim csda As New MySqlDataAdapter(ChckStatus)
                Dim csdt As New DataTable()
                csda.Fill(csdt)

                'CheckIn
                Dim Payment As Integer = CInt(Int(txtPayment.Text))
                Dim Change As Integer = Payment - pdt.Rows.Item(0).Item("RoomPrice")
                Dim CheckInPayment = "Insert Into checkin_payment Values(null, '" _
                                                                            & cdt.Rows.Item(0).Item("ChckID") &
                                                                            "', '" & dt.Rows.Item(0).Item("EmpID") &
                                                                            "', '" & txtGuestID.Text &
                                                                            "', '" & txtRoomNumber.Text &
                                                                            "', '" & Payment &
                                                                            "', '" & Change &
                                                                            "', '" & lblDateTime.Text & "')"
                    SQLProcess(CheckInPayment)

                MessageBox.Show("Guest Checked-In!" & vbCrLf &
                                    "Room No.: " & txtRoomNumber.Text & vbCrLf &
                                    "Guest Name: " & txtName.Text & vbCrLf &
                                    "Check-In Date: " & dtpCheckIn.Text & vbCrLf &
                                    "Check-Out Date: " & dtpCheckOut.Text & vbCrLf &
                                    "Payment Amount: ₱" & Payment & vbCrLf &
                                    "Payment Change: ₱" & Change,
                                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleartxt()
            Else
                Me.Show()
            End If
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

    Private Sub dgvCheckedIn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckedIn.CellClick
        dtpCheckOut.MinDate = DateAdd(DateInterval.Day, -1, Now)
        dtpCheckIn.MinDate = DateAdd(DateInterval.Day, -1, Now)
        Try
            Dim i = e.RowIndex
            With dgvCheckedIn
                Dim chckin As DateTime = Date.ParseExact(.Item("Check-In Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)
                Dim chckout As DateTime = Date.ParseExact(.Item("Check-Out Date", i).Value, "MM/dd/yyyy - h:mm tt", CultureInfo.InvariantCulture)

                txtRoomNumber.Text = .Item("Room No.", i).Value
                txtGuestID.Text = .Item("ID", i).Value
                txtName.Text = .Item("Guest Name", i).Value
                dtpCheckIn.Text = chckin
                dtpCheckOut.Text = chckout

            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
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
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) Or String.IsNullOrWhiteSpace(txtGuestID.Text) Or String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Some fields are empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim COut As New System.Windows.Forms.DialogResult
            COut = MessageBox.Show("Check-Out On Room No. " & txtRoomNumber.Text & "?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If COut = Windows.Forms.DialogResult.Yes Then
                Dim CheckOutStatus = "Update checkin Set ChckStatusID = 2 where RoomID = '" & txtRoomNumber.Text &
                                                                         "' And GuestID = '" & txtGuestID.Text &
                                                                         "' And CIDate = '" & dtpCheckIn.Text &
                                                                         "' And CODate = '" & dtpCheckOut.Text & "'"
                SQLProcess(CheckOutStatus)

                Dim CheckInRoom = "Update rooms Set RoomStatusID = 1 Where RoomID = '" & txtRoomNumber.Text & "'"
                SQLProcess(CheckInRoom)

                Dim CStatus = "Update guests Set CStatusID = 3  Where GuestID = '" & txtGuestID.Text & "'"
                SQLProcess(CStatus)

                'Dim ReserveStatus = "Update reservation_payment Set RStatusID = 3 Where RoomID = '" & txtRoomNumber.Text & "' And GuestID = '" & txtGuestID.Text & "'"
                'SQLProcess(ReserveStatus)

                Dim RStatus = "Update reservation Set RStatusID = 3  where RoomID = '" & txtRoomNumber.Text &
                                                                         "' And GuestID = '" & txtGuestID.Text &
                                                                         "' And CIDate = '" & dtpCheckIn.Text &
                                                                         "' And CODate = '" & dtpCheckOut.Text & "'"
                SQLProcess(RStatus)

                MessageBox.Show("Guest Checked-Out!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cleartxt()
            Else
                Me.Show()
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
                txtPayment.Text = .Item("Reservation Payment", i).Value


            End With
            btnCheckIn.Enabled = True
            btnCheckOut.Enabled = True
        Catch ex As Exception
            'MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub
End Class