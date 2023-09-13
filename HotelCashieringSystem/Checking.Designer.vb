<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checking
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
        dgvCheckedIn = New DataGridView()
        btnCheckOut = New Button()
        GroupBox1 = New GroupBox()
        txtRoomNumber = New TextBox()
        Label7 = New Label()
        txtName = New TextBox()
        dtpCheckOut = New DateTimePicker()
        dtpCheckIn = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        txtGuestID = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        btnCheckIn = New Button()
        btnRooms = New Button()
        GroupBox3 = New GroupBox()
        dgvGuest = New DataGridView()
        lblDateTime = New Label()
        tmrCheck = New Timer(components)
        GroupBox2.SuspendLayout()
        CType(dgvCheckedIn, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvGuest, ComponentModel.ISupportInitialize).BeginInit()
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
        btnClear.Location = New Point(256, 314)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 51)
        btnClear.TabIndex = 23
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(dgvCheckedIn)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(842, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(435, 341)
        GroupBox2.TabIndex = 25
        GroupBox2.TabStop = False
        GroupBox2.Text = "Guests Checked In"
        ' 
        ' dgvCheckedIn
        ' 
        dgvCheckedIn.AllowUserToAddRows = False
        dgvCheckedIn.AllowUserToDeleteRows = False
        dgvCheckedIn.AllowUserToResizeColumns = False
        dgvCheckedIn.AllowUserToResizeRows = False
        dgvCheckedIn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCheckedIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCheckedIn.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCheckedIn.Location = New Point(6, 23)
        dgvCheckedIn.Name = "dgvCheckedIn"
        dgvCheckedIn.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvCheckedIn.RowTemplate.Height = 25
        dgvCheckedIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCheckedIn.Size = New Size(423, 312)
        dgvCheckedIn.TabIndex = 0
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCheckOut.Location = New Point(151, 314)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(90, 51)
        btnCheckOut.TabIndex = 22
        btnCheckOut.Text = "Check-Out"
        btnCheckOut.UseVisualStyleBackColor = True
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
        GroupBox1.Controls.Add(txtGuestID)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 80)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 225)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(176, 103)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(186, 26)
        txtRoomNumber.TabIndex = 28
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
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.Location = New Point(176, 63)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 26)
        txtName.TabIndex = 26
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 19)
        Label6.TabIndex = 22
        Label6.Text = "Check Out Date:"
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
        ' txtGuestID
        ' 
        txtGuestID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtGuestID.Location = New Point(176, 23)
        txtGuestID.Name = "txtGuestID"
        txtGuestID.Size = New Size(186, 26)
        txtGuestID.TabIndex = 3
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 19)
        Label1.TabIndex = 0
        Label1.Text = "Check-In ID:"
        ' 
        ' btnCheckIn
        ' 
        btnCheckIn.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCheckIn.Location = New Point(45, 314)
        btnCheckIn.Name = "btnCheckIn"
        btnCheckIn.Size = New Size(90, 51)
        btnCheckIn.TabIndex = 21
        btnCheckIn.Text = "Check-In"
        btnCheckIn.UseVisualStyleBackColor = True
        ' 
        ' btnRooms
        ' 
        btnRooms.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRooms.Location = New Point(151, 12)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(133, 23)
        btnRooms.TabIndex = 30
        btnRooms.Text = "Rooms Available"
        btnRooms.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.None
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(dgvGuest)
        GroupBox3.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.Black
        GroupBox3.Location = New Point(401, 41)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(435, 341)
        GroupBox3.TabIndex = 31
        GroupBox3.TabStop = False
        GroupBox3.Text = "Guest List"
        ' 
        ' dgvGuest
        ' 
        dgvGuest.AllowUserToAddRows = False
        dgvGuest.AllowUserToDeleteRows = False
        dgvGuest.AllowUserToResizeColumns = False
        dgvGuest.AllowUserToResizeRows = False
        dgvGuest.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuest.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvGuest.Location = New Point(6, 23)
        dgvGuest.Name = "dgvGuest"
        dgvGuest.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvGuest.RowTemplate.Height = 25
        dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuest.Size = New Size(423, 312)
        dgvGuest.TabIndex = 0
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.Location = New Point(977, 16)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 32
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' tmrCheck
        ' 
        tmrCheck.Enabled = True
        tmrCheck.Interval = 1000
        ' 
        ' Checking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1289, 396)
        Controls.Add(lblDateTime)
        Controls.Add(GroupBox3)
        Controls.Add(btnRooms)
        Controls.Add(btnClear)
        Controls.Add(GroupBox2)
        Controls.Add(btnCheckOut)
        Controls.Add(GroupBox1)
        Controls.Add(btnCheckIn)
        Controls.Add(btnLogOut)
        Controls.Add(btnBack)
        Name = "Checking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checking"
        GroupBox2.ResumeLayout(False)
        CType(dgvCheckedIn, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(dgvGuest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCheckedIn As DataGridView
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvGuest As DataGridView
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrCheck As Timer
End Class
