<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        btnRoomProfile = New Button()
        btnDash = New Button()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        dtpRS1 = New DateTimePicker()
        dtpRS2 = New DateTimePicker()
        lblRS = New Label()
        Label1 = New Label()
        dgvRSales = New DataGridView()
        GroupBox2 = New GroupBox()
        dtpCS1 = New DateTimePicker()
        Label3 = New Label()
        dtpCS2 = New DateTimePicker()
        lblCS = New Label()
        Label4 = New Label()
        dgvCSales = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(dgvRSales, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvCSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(733, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(85, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnRoomProfile
        ' 
        btnRoomProfile.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRoomProfile.Location = New Point(12, 12)
        btnRoomProfile.Name = "btnRoomProfile"
        btnRoomProfile.Size = New Size(130, 23)
        btnRoomProfile.TabIndex = 1
        btnRoomProfile.Text = "Room Profile"
        btnRoomProfile.UseVisualStyleBackColor = True
        ' 
        ' btnDash
        ' 
        btnDash.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDash.Location = New Point(148, 12)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(130, 23)
        btnDash.TabIndex = 2
        btnDash.Text = "Transactions"
        btnDash.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(dtpRS1)
        GroupBox1.Controls.Add(dtpRS2)
        GroupBox1.Controls.Add(lblRS)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dgvRSales)
        GroupBox1.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(400, 288)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        GroupBox1.Text = "Reservation Sales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(278, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(16, 17)
        Label2.TabIndex = 43
        Label2.Text = "-"
        ' 
        ' dtpRS1
        ' 
        dtpRS1.Format = DateTimePickerFormat.Short
        dtpRS1.Location = New Point(175, 16)
        dtpRS1.Name = "dtpRS1"
        dtpRS1.Size = New Size(97, 20)
        dtpRS1.TabIndex = 4
        ' 
        ' dtpRS2
        ' 
        dtpRS2.Format = DateTimePickerFormat.Short
        dtpRS2.Location = New Point(297, 16)
        dtpRS2.Name = "dtpRS2"
        dtpRS2.Size = New Size(97, 20)
        dtpRS2.TabIndex = 3
        ' 
        ' lblRS
        ' 
        lblRS.AutoSize = True
        lblRS.Location = New Point(82, 22)
        lblRS.Name = "lblRS"
        lblRS.Size = New Size(13, 13)
        lblRS.TabIndex = 2
        lblRS.Text = " "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 13)
        Label1.TabIndex = 1
        Label1.Text = "Total Sales:"
        ' 
        ' dgvRSales
        ' 
        dgvRSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRSales.BackgroundColor = Color.White
        dgvRSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRSales.Location = New Point(6, 38)
        dgvRSales.Name = "dgvRSales"
        dgvRSales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvRSales.RowTemplate.Height = 25
        dgvRSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRSales.Size = New Size(388, 242)
        dgvRSales.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dtpCS1)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(dtpCS2)
        GroupBox2.Controls.Add(lblCS)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(dgvCSales)
        GroupBox2.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(418, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(400, 288)
        GroupBox2.TabIndex = 42
        GroupBox2.TabStop = False
        GroupBox2.Text = "Check-In Sales"
        ' 
        ' dtpCS1
        ' 
        dtpCS1.Format = DateTimePickerFormat.Short
        dtpCS1.Location = New Point(172, 16)
        dtpCS1.Name = "dtpCS1"
        dtpCS1.Size = New Size(97, 20)
        dtpCS1.TabIndex = 45
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(275, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 17)
        Label3.TabIndex = 44
        Label3.Text = "-"
        ' 
        ' dtpCS2
        ' 
        dtpCS2.Format = DateTimePickerFormat.Short
        dtpCS2.Location = New Point(297, 16)
        dtpCS2.Name = "dtpCS2"
        dtpCS2.Size = New Size(97, 20)
        dtpCS2.TabIndex = 4
        ' 
        ' lblCS
        ' 
        lblCS.AutoSize = True
        lblCS.Location = New Point(82, 22)
        lblCS.Name = "lblCS"
        lblCS.Size = New Size(13, 13)
        lblCS.TabIndex = 2
        lblCS.Text = " "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 13)
        Label4.TabIndex = 1
        Label4.Text = "Total Sales:"
        ' 
        ' dgvCSales
        ' 
        dgvCSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCSales.BackgroundColor = Color.White
        dgvCSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCSales.Location = New Point(6, 38)
        dgvCSales.Name = "dgvCSales"
        dgvCSales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        dgvCSales.RowTemplate.Height = 25
        dgvCSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCSales.Size = New Size(388, 242)
        dgvCSales.TabIndex = 0
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(829, 341)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnLogOut)
        Controls.Add(btnDash)
        Controls.Add(btnRoomProfile)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvRSales, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvCSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnRoomProfile As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvRSales As DataGridView
    Friend WithEvents lblRS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvCSales As DataGridView
    Friend WithEvents dtpRS1 As DateTimePicker
    Friend WithEvents dtpRS2 As DateTimePicker
    Friend WithEvents dtpCS2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCS1 As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
