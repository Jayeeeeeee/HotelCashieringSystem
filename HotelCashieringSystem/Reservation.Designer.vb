﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnLogOut = New Button()
        btnBack = New Button()
        btnClear = New Button()
        GroupBox2 = New GroupBox()
        dgGuest = New DataGridView()
        btnUpdate = New Button()
        btnReserve = New Button()
        btnRooms = New Button()
        GroupBox3 = New GroupBox()
        dgReserve = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        txtReserveID = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        dtpCheckIn = New DateTimePicker()
        dtpCheckOut = New DateTimePicker()
        txtName = New TextBox()
        Label7 = New Label()
        txtRoomNumber = New TextBox()
        GroupBox1 = New GroupBox()
        lblDateTime = New Label()
        tmrReserve = New Timer(components)
        GroupBox2.SuspendLayout()
        CType(dgGuest, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgReserve, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(1144, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 23)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(300, 314)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 51)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(dgGuest)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(401, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(435, 341)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Guest List"
        ' 
        ' dgGuest
        ' 
        dgGuest.AllowUserToAddRows = False
        dgGuest.AllowUserToDeleteRows = False
        dgGuest.AllowUserToResizeColumns = False
        dgGuest.AllowUserToResizeRows = False
        dgGuest.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgGuest.EditMode = DataGridViewEditMode.EditProgrammatically
        dgGuest.Location = New Point(6, 23)
        dgGuest.Name = "dgGuest"
        dgGuest.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgGuest.RowTemplate.Height = 25
        dgGuest.Size = New Size(423, 310)
        dgGuest.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(108, 314)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(186, 51)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Cancel Reservation"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnReserve
        ' 
        btnReserve.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReserve.Location = New Point(12, 314)
        btnReserve.Name = "btnReserve"
        btnReserve.Size = New Size(90, 51)
        btnReserve.TabIndex = 15
        btnReserve.Text = "Reserve"
        btnReserve.UseVisualStyleBackColor = True
        ' 
        ' btnRooms
        ' 
        btnRooms.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRooms.Location = New Point(151, 12)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(133, 23)
        btnRooms.TabIndex = 29
        btnRooms.Text = "Rooms Available"
        btnRooms.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.None
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(dgReserve)
        GroupBox3.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.Black
        GroupBox3.Location = New Point(842, 41)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(435, 341)
        GroupBox3.TabIndex = 30
        GroupBox3.TabStop = False
        GroupBox3.Text = "Reservation List"
        ' 
        ' dgReserve
        ' 
        dgReserve.AllowUserToAddRows = False
        dgReserve.AllowUserToDeleteRows = False
        dgReserve.AllowUserToResizeColumns = False
        dgReserve.AllowUserToResizeRows = False
        dgReserve.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgReserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgReserve.EditMode = DataGridViewEditMode.EditProgrammatically
        dgReserve.Location = New Point(6, 23)
        dgReserve.Name = "dgReserve"
        dgReserve.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgReserve.RowTemplate.Height = 25
        dgReserve.Size = New Size(423, 312)
        dgReserve.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 19)
        Label1.TabIndex = 0
        Label1.Text = "Reservation ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 1
        Label2.Text = "Guest Name:"
        ' 
        ' txtReserveID
        ' 
        txtReserveID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtReserveID.Location = New Point(176, 23)
        txtReserveID.Name = "txtReserveID"
        txtReserveID.Size = New Size(186, 26)
        txtReserveID.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 19)
        Label5.TabIndex = 21
        Label5.Text = "Check In Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 19)
        Label6.TabIndex = 22
        Label6.Text = "Check Out Date:"
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.CalendarFont = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckIn.CustomFormat = "MM/dd/yyyy -h:mm:ss tt"
        dtpCheckIn.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckIn.Format = DateTimePickerFormat.Custom
        dtpCheckIn.Location = New Point(161, 146)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(201, 22)
        dtpCheckIn.TabIndex = 23
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.CalendarFont = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckOut.CustomFormat = "MM/dd/yyyy -h:mm:ss tt"
        dtpCheckOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckOut.Format = DateTimePickerFormat.Custom
        dtpCheckOut.Location = New Point(161, 186)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(201, 22)
        dtpCheckOut.TabIndex = 24
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.Location = New Point(176, 63)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 26)
        txtName.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(20, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 19)
        Label7.TabIndex = 27
        Label7.Text = "Room Number:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(176, 103)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(186, 26)
        txtRoomNumber.TabIndex = 28
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(txtRoomNumber)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(dtpCheckOut)
        GroupBox1.Controls.Add(dtpCheckIn)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtReserveID)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 80)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 228)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.Location = New Point(977, 16)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 33
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' tmrReserve
        ' 
        tmrReserve.Enabled = True
        tmrReserve.Interval = 1000
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1289, 396)
        Controls.Add(lblDateTime)
        Controls.Add(GroupBox3)
        Controls.Add(btnRooms)
        Controls.Add(btnClear)
        Controls.Add(GroupBox2)
        Controls.Add(btnUpdate)
        Controls.Add(GroupBox1)
        Controls.Add(btnReserve)
        Controls.Add(btnLogOut)
        Controls.Add(btnBack)
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        GroupBox2.ResumeLayout(False)
        CType(dgGuest, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(dgReserve, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgGuest As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtBeds As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgReserve As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReserveID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrReserve As Timer
End Class
