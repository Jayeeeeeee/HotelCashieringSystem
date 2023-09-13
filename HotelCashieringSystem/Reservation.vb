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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtReserveID.Text = ""
        txtName.Text = ""
        txtRoomNumber.Text = ""
    End Sub

    Private Sub Reservation_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From guest_info", dgGuest)
    End Sub

End Class