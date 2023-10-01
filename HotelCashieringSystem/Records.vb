Public Class Records

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRecords.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Records_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From reservation_records", dgvRTransaction)
        displayInfo("Select * From checkin_records", dgvCITransaction)
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        If SearchCB.SelectedItem = "Payment ID" Then
            Dim RPIDSearch = "select * from reservation_records where Payment ID like '%" & SearchTxt.Text & "%'"
            Dim CPIDSearch = "select * from checkin_records where Payment ID like '%" & SearchTxt.Text & "%'"
            displayInfo(RPIDSearch, dgvRTransaction)
            displayInfo(CPIDSearch, dgvCITransaction)

        ElseIf SearchCB.SelectedItem = "Reservation No." Then
            Dim RNum = "select * from reservation_records where Reservation No. like '%" & SearchTxt.Text & "%'"
            displayInfo(RNum, dgvRTransaction)

        ElseIf SearchCB.SelectedItem = "Check-In No." Then
            Dim CNum = "select * from checkin_records where Reservation Status like '%" & SearchTxt.Text & "%'"
            displayInfo(CNum, dgvRTransaction)

        ElseIf SearchCB.SelectedItem = "Guest Name" Then
            Dim RName = "select * from reservation_records where Guest Name like '%" & SearchTxt.Text & "%'"
            Dim CName = "select * from checkin_records where Guest Name like '%" & SearchTxt.Text & "%'"
            displayInfo(RName, dgvRTransaction)
            displayInfo(CName, dgvCITransaction)

        ElseIf SearchCB.SelectedItem = "Room No." Then
            Dim RRoom = "select * from reservation_records where Room No. like '%" & SearchTxt.Text & "%'"
            Dim CRoom = "select * from checkin_records where Room No. like '%" & SearchTxt.Text & "%'"
            displayInfo(RRoom, dgvRTransaction)
            displayInfo(CRoom, dgvCITransaction)

        ElseIf SearchCB.SelectedItem = "Payment Date" Then
            Dim RPDate = "select * from reservation_records where Payment Date like '%" & SearchTxt.Text & "%'"
            Dim CPDate = "select * from checkin_records where Payment Date like '%" & SearchTxt.Text & "%'"
            displayInfo(RPDate, dgvRTransaction)
            displayInfo(CPDate, dgvCITransaction)

        ElseIf SearchCB.SelectedItem = "Reservation Status" Then
            Dim RStatus = "select * from reservation_records where Reservation Status like '%" & SearchTxt.Text & "%'"
            displayInfo(RStatus, dgvRTransaction)

        ElseIf SearchCB.SelectedItem = "Check-In Status" Then
            Dim CStatus = "select * from checkin_records where Reservation Status like '%" & SearchTxt.Text & "%'"
            displayInfo(CStatus, dgvCITransaction)
        End If
    End Sub
End Class