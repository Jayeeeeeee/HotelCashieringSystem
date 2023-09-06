Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Module HCSModule
    Private da As MySqlDataAdapter
    Private ds As DataSet
    Private dt As DataTable
    Private sqlCommand As MySqlCommand

    Public mysqlConn As New MySqlConnection("Server=localhost; Port=3306; Database=hoteldb; user=root;")
    Public Sub OpendbConn()

        Try

            If mysqlConn.State = ConnectionState.Closed Then

                mysqlConn.Open()

                'MessageBox.Show("Connected")

            End If

        Catch ex As MySqlException

            MessageBox.Show("Error: " & ex.Message)

            'MessageBox.Show("Connection Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub ClosedbConn()

        Try

            If mysqlConn.State = ConnectionState.Open Then

                mysqlConn.Close()

            End If

        Catch ex As MySqlException

            MessageBox.Show("Error: " & ex.Message)

            'MessageBox.Show("Connection Error: " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub SQLProcess(ByVal SQL As String)
        Try
            OpendbConn()
            sqlCommand = New MySqlCommand

            With sqlCommand
                .CommandText = SQL
                .CommandType = CommandType.Text
                .Connection = mysqlConn
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MessageBox.Show("Error: SQLProcess" + ex.Message)
        Finally

            ClosedbConn()
        End Try
    End Sub

    Public Sub displayInfo(ByVal SQL As String, ByVal DG As DataGridView)
        Try
            OpendbConn()
            da = New MySqlDataAdapter(SQL, mysqlConn)
            dt = New DataTable
            da.Fill(dt)
            DG.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error: displayInfo " + ex.Message)
        Finally
            ClosedbConn()
        End Try
    End Sub

    Public Sub loadToComboBox(ByVal SQL As String, ByVal cbo As ComboBox)

        Try
            mysqlConn.Open()
            da = New MySqlDataAdapter(SQL, mysqlConn)
            dt = New DataTable
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.ValueMember = dt.Columns(0).ToString
            cbo.DisplayMember = dt.Columns(1).ToString

        Catch ex As Exception
            MessageBox.Show("Error: loadtoComboBox " + ex.Message)
        Finally
            mysqlConn.Close()
        End Try

    End Sub
End Module
