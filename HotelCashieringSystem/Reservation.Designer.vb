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
        btnLogOut = New Button()
        btnBack = New Button()
        btnClear = New Button()
        GroupBox2 = New GroupBox()
        dgRoom = New DataGridView()
        btnUpdate = New Button()
        GroupBox1 = New GroupBox()
        txtName = New TextBox()
        txtAddress = New TextBox()
        dtpCheckOut = New DateTimePicker()
        dtpCheckIn = New DateTimePicker()
        txtContact = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        txtGuestID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnReserve = New Button()
        Label7 = New Label()
        txtRoomNumber = New TextBox()
        btnRooms = New Button()
        GroupBox2.SuspendLayout()
        CType(dgRoom, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(698, 12)
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
        btnClear.Location = New Point(300, 343)
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
        GroupBox2.Controls.Add(dgRoom)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(396, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(435, 341)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Reservation List"
        ' 
        ' dgRoom
        ' 
        dgRoom.AllowUserToAddRows = False
        dgRoom.AllowUserToDeleteRows = False
        dgRoom.AllowUserToResizeColumns = False
        dgRoom.AllowUserToResizeRows = False
        dgRoom.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgRoom.EditMode = DataGridViewEditMode.EditProgrammatically
        dgRoom.Location = New Point(6, 25)
        dgRoom.Name = "dgRoom"
        dgRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgRoom.RowTemplate.Height = 25
        dgRoom.Size = New Size(423, 308)
        dgRoom.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(108, 343)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(186, 51)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Cancel Reservation"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(txtRoomNumber)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(dtpCheckOut)
        GroupBox1.Controls.Add(dtpCheckIn)
        GroupBox1.Controls.Add(txtContact)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtGuestID)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 296)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.Location = New Point(176, 63)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 26)
        txtName.TabIndex = 26
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtAddress.Location = New Point(176, 103)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(186, 26)
        txtAddress.TabIndex = 25
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.CalendarFont = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckOut.CustomFormat = "MM/dd/yyyy -h:mm:ss tt"
        dtpCheckOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckOut.Format = DateTimePickerFormat.Custom
        dtpCheckOut.Location = New Point(161, 263)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(201, 22)
        dtpCheckOut.TabIndex = 24
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.CalendarFont = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckIn.CustomFormat = "MM/dd/yyyy -h:mm:ss tt"
        dtpCheckIn.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpCheckIn.Format = DateTimePickerFormat.Custom
        dtpCheckIn.Location = New Point(161, 223)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(201, 22)
        dtpCheckIn.TabIndex = 23
        ' 
        ' txtContact
        ' 
        txtContact.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtContact.Location = New Point(176, 143)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(186, 26)
        txtContact.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 266)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 19)
        Label6.TabIndex = 22
        Label6.Text = "Check Out Date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 19)
        Label5.TabIndex = 21
        Label5.Text = "Check In Date:"
        ' 
        ' txtGuestID
        ' 
        txtGuestID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtGuestID.Location = New Point(176, 23)
        txtGuestID.Name = "txtGuestID"
        txtGuestID.Size = New Size(186, 26)
        txtGuestID.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 19)
        Label4.TabIndex = 3
        Label4.Text = "Contact Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 19)
        Label3.TabIndex = 2
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 19)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 19)
        Label1.TabIndex = 0
        Label1.Text = "Guest ID:"
        ' 
        ' btnReserve
        ' 
        btnReserve.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReserve.Location = New Point(12, 343)
        btnReserve.Name = "btnReserve"
        btnReserve.Size = New Size(90, 51)
        btnReserve.TabIndex = 15
        btnReserve.Text = "Reserve"
        btnReserve.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(20, 186)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 19)
        Label7.TabIndex = 27
        Label7.Text = "Room Number:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(176, 183)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(186, 26)
        txtRoomNumber.TabIndex = 28
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
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 396)
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
        CType(dgRoom, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgRoom As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtBeds As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReserve As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents btnRooms As Button
End Class
