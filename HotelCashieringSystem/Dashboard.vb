﻿Public Class Dashboard

    Private Sub tmrDash_Tick(sender As Object, e As EventArgs) Handles tmrDash.Tick
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

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From rooms_available", dgvAvailable)
        displayInfo("Select * From rooms_occupied", dgvOccupied)
        displayInfo("Select * From rooms_reserved", dgvReserved)
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