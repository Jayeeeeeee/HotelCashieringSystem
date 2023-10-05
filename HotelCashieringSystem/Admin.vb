Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Relational

Public Class Admin

    Private Sub Admin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        displayInfo("Select * From reserve_payment", dgvRSales)
        displayInfo("Select * From chck_payment", dgvCSales)
        Dim RQuery As New MySqlCommand("Select * from total_rp", mysqlConn)
        Dim ra As New MySqlDataAdapter(RQuery)
        Dim rdt As New DataTable()
        ra.Fill(rdt)
        lblRS.Text = "₱" & rdt.Rows.Item(0).Item("SUM(PAmount)")

        Dim CQuery As New MySqlCommand("Select SUM(PAmount) From checkin_payment", mysqlConn)
        Dim ca As New MySqlDataAdapter(CQuery)
        Dim cdt As New DataTable()
        ca.Fill(cdt)
        lblCS.Text = "₱" & cdt.Rows.Item(0).Item("SUM(PAmount)")
        dgvRSales.AllowUserToResizeRows = False
        dgvCSales.AllowUserToResizeRows = False
        dgvRSales.AllowUserToResizeColumns = False
        dgvCSales.AllowUserToResizeColumns = False
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

    Private Sub btnRoomProfile_Click(sender As Object, e As EventArgs) Handles btnRoomProfile.Click
        RoomProfile.Show()
        Me.Hide()
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        Records.Show()
        Me.Hide()
    End Sub

    'Private Sub dtpRS1_ValueChanged(sender As Object, e As EventArgs) Handles dtpRS1.ValueChanged
    '    Dim sDate = dtpRS1.Value.ToString("MM/dd/yyyy")
    '    Dim eDate = dtpRS2.Value.ToString("MM/dd/yyyy")
    '    Dim RSearch = "select * from reserve_payment where Payment Date like '%" & sDate & "%' and '%" & eDate & "%'"
    '    displayInfo(RSearch, dgvRSales)
    'End Sub

    'Private Sub dtpCS1_ValueChanged(sender As Object, e As EventArgs) Handles dtpCS1.ValueChanged
    '    Dim sDate = dtpCS1.Value.Date.ToString("MM/dd/yyyy")
    '    Dim eDate = dtpCS2.Value.Date.ToString("MM/dd/yyyy")
    '    Dim CSearch = "select * from chck_payment where Payment Date like '%" & sDate & "%' and '%" & eDate & "%'"
    '    displayInfo(CSearch, dgvCSales)
    'End Sub
End Class