<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        dgvGuest = New DataGridView()
        btnCancel = New Button()
        btnReserve = New Button()
        GroupBox3 = New GroupBox()
        dgvReserve = New DataGridView()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        dtpCheckIn = New DateTimePicker()
        dtpCheckOut = New DateTimePicker()
        txtName = New TextBox()
        Label7 = New Label()
        txtRoomNumber = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtGuestID = New TextBox()
        Label3 = New Label()
        lblDateTime = New Label()
        tmrReserve = New Timer(components)
        GroupBox4 = New GroupBox()
        dgvAvailable = New DataGridView()
        GroupBox2.SuspendLayout()
        CType(dgvGuest, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgvReserve, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(dgvAvailable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(1294, 12)
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
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(dgvGuest)
        GroupBox2.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(396, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(547, 341)
        GroupBox2.TabIndex = 20
        GroupBox2.TabStop = False
        GroupBox2.Text = "Guest List"
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
        dgvGuest.Size = New Size(535, 310)
        dgvGuest.TabIndex = 0
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.Location = New Point(108, 314)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(186, 51)
        btnCancel.TabIndex = 16
        btnCancel.Text = "Cancel Reservation"
        btnCancel.UseVisualStyleBackColor = True
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
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(dgvReserve)
        GroupBox3.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.Black
        GroupBox3.Location = New Point(15, 388)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1412, 341)
        GroupBox3.TabIndex = 30
        GroupBox3.TabStop = False
        GroupBox3.Text = "Reservation List"
        ' 
        ' dgvReserve
        ' 
        dgvReserve.AllowUserToAddRows = False
        dgvReserve.AllowUserToDeleteRows = False
        dgvReserve.AllowUserToResizeColumns = False
        dgvReserve.AllowUserToResizeRows = False
        dgvReserve.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReserve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReserve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReserve.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvReserve.Location = New Point(6, 23)
        dgvReserve.Name = "dgvReserve"
        dgvReserve.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvReserve.RowTemplate.Height = 25
        dgvReserve.Size = New Size(1400, 312)
        dgvReserve.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 1
        Label2.Text = "Guest Name:"
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
        dtpCheckIn.Location = New Point(161, 144)
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
        dtpCheckOut.Location = New Point(161, 184)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(201, 22)
        dtpCheckOut.TabIndex = 24
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.Location = New Point(176, 103)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(186, 26)
        txtName.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(20, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 19)
        Label7.TabIndex = 27
        Label7.Text = "Room Number:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(176, 23)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(186, 26)
        txtRoomNumber.TabIndex = 28
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtGuestID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtRoomNumber)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(dtpCheckOut)
        GroupBox1.Controls.Add(dtpCheckIn)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 267)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 226)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 19)
        Label1.TabIndex = 32
        Label1.Text = "Payment:"
        ' 
        ' txtGuestID
        ' 
        txtGuestID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtGuestID.Location = New Point(176, 63)
        txtGuestID.Name = "txtGuestID"
        txtGuestID.ReadOnly = True
        txtGuestID.Size = New Size(186, 26)
        txtGuestID.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 19)
        Label3.TabIndex = 30
        Label3.Text = "Guest ID:"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = SystemColors.ActiveCaptionText
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.ForeColor = Color.OrangeRed
        lblDateTime.Location = New Point(1127, 16)
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
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox4.Controls.Add(dgvAvailable)
        GroupBox4.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox4.Location = New Point(949, 41)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(478, 341)
        GroupBox4.TabIndex = 34
        GroupBox4.TabStop = False
        GroupBox4.Text = "Rooms Available"
        ' 
        ' dgvAvailable
        ' 
        dgvAvailable.AllowUserToAddRows = False
        dgvAvailable.AllowUserToDeleteRows = False
        dgvAvailable.AllowUserToResizeColumns = False
        dgvAvailable.AllowUserToResizeRows = False
        dgvAvailable.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAvailable.Cursor = Cursors.Hand
        dgvAvailable.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvAvailable.GridColor = SystemColors.Menu
        dgvAvailable.ImeMode = ImeMode.NoControl
        dgvAvailable.Location = New Point(6, 22)
        dgvAvailable.Name = "dgvAvailable"
        dgvAvailable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvAvailable.RowTemplate.Height = 25
        dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAvailable.Size = New Size(466, 313)
        dgvAvailable.TabIndex = 5
        dgvAvailable.TabStop = False
        ' 
        ' Reservation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1439, 734)
        Controls.Add(GroupBox4)
        Controls.Add(lblDateTime)
        Controls.Add(GroupBox3)
        Controls.Add(btnClear)
        Controls.Add(GroupBox2)
        Controls.Add(btnCancel)
        Controls.Add(GroupBox1)
        Controls.Add(btnReserve)
        Controls.Add(btnLogOut)
        Controls.Add(btnBack)
        Name = "Reservation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation"
        GroupBox2.ResumeLayout(False)
        CType(dgvGuest, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(dgvReserve, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        CType(dgvAvailable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvGuest As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtBeds As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents btnReserve As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvReserve As DataGridView
    Friend WithEvents Label2 As Label
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
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvAvailable As DataGridView
    Friend WithEvents Label1 As Label
End Class
