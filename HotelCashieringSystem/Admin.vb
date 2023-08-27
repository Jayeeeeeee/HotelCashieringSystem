Public Class Admin
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub btnGuestProfile_Click(sender As Object, e As EventArgs) Handles btnGuestProfile.Click
        GuestProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoomProfile_Click(sender As Object, e As EventArgs) Handles btnRoomProfile.Click
        RoomProfile.Show()
        Me.Hide()
    End Sub

End Class