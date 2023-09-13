Public Class Dashboard

    Private Sub tmrDash_Tick(sender As Object, e As EventArgs) Handles tmrDash.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim out As New System.Windows.Forms.DialogResult
        out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If out Then
            Login.Show()
            Me.Close()
            ClosedbConn()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From rooms_available", dgvAvailable)
        displayInfo("Select * From rooms_occupied", dgvOccupied)
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Reservation.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Checking.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        GuestProfile.Show()
        Me.Hide()
    End Sub

End Class