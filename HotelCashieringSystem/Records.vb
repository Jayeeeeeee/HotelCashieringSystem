Public Class Records

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRecords.Tick
        lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim StatusQuery = "Update emp_login Set EmpStatusID = 1 Where EmpStatusID = 2"
        Dim Out As New System.Windows.Forms.DialogResult
        Out = MessageBox.Show("Logout?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Out Then
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
End Class