Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MessageBox.Show("Successful Login!", "Welcome.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUser.Text = ""
        txtPass.Text = ""
        Me.Close()
    End Sub
End Class
