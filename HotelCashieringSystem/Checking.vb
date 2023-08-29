Public Class Checking
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim out As New System.Windows.Forms.DialogResult
        out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If out Then
            Me.Close()
            Login.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class