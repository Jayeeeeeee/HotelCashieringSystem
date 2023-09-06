Public Class RoomProfile
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim out As New System.Windows.Forms.DialogResult
        out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If out Then
            Login.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRoomID.Text = ""
        cmbRoomType.Text = ""
        txtBeds.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub RoomProfile_Activated(sender As Object, e As EventArgs) Handles MyBase.Load
        displayInfo("select * from room_info", dgvRoom)
    End Sub
End Class