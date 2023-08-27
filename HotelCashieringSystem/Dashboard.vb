Public Class Dashboard
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Reservation.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Checking.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Admin.Show()
        Me.Hide()
    End Sub

End Class