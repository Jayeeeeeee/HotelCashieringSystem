Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim LoginQuery As New MySqlCommand("Select EmpUser,EmpPass,EmpTypeID From emp_login Where EmpUser ='" & txtUser.Text & "' and EmpPass = '" & txtPass.Text & "'", mysqlConn)
        Dim da As New MySqlDataAdapter(LoginQuery)
        Dim dt As New DataTable()
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Wrong Username or Password!", "Please check your credentials.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cleartxt()

        ElseIf dt.Rows.Item(0).Item("EmpTypeID") = "1" Then
            'Manager Login
            MessageBox.Show("Successful Manager Login!", "Welcome.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Admin.Show()
            Me.Hide()

        ElseIf dt.Rows.Item(0).Item("EmpTypeID") = "2" Then
            'Attendant Login
            MessageBox.Show("Successful Attendant Login!", "Welcome.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dashboard.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        ClosedbConn()
    End Sub

    Private Sub cleartxt()
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Public Sub empID()

    End Sub

End Class
