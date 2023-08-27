Public Class RoomProfile
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRoomID.Text = ""
        cmbRoomType.Text = ""
        txtBeds.Text = ""
        txtRate.Text = ""
    End Sub
End Class