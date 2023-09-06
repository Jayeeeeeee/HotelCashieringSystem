<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestProfile
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
        btnCreate = New Button()
        btnBack = New Button()
        btnLogOut = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        GroupBox2 = New GroupBox()
        dgGuest = New DataGridView()
        GroupBox1 = New GroupBox()
        txtName = New TextBox()
        txtAddress = New TextBox()
        txtNumber = New TextBox()
        txtGuestID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        CType(dgGuest, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCreate
        ' 
        btnCreate.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreate.Location = New Point(12, 315)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(120, 68)
        btnCreate.TabIndex = 17
        btnCreate.Text = "Add New Guest"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(12, 14)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 22)
        btnBack.TabIndex = 15
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(698, 14)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 22)
        btnLogOut.TabIndex = 16
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(268, 315)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 68)
        btnClear.TabIndex = 20
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(137, 315)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(125, 68)
        btnDelete.TabIndex = 19
        btnDelete.Text = "Delete Guest"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(dgGuest)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(396, 42)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(435, 341)
        GroupBox2.TabIndex = 22
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
        dgGuest.Location = New Point(6, 25)
        dgGuest.Name = "dgGuest"
        dgGuest.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgGuest.RowTemplate.Height = 25
        dgGuest.Size = New Size(423, 306)
        dgGuest.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtNumber)
        GroupBox1.Controls.Add(txtGuestID)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 267)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.Location = New Point(176, 89)
        txtName.Name = "txtName"
        txtName.Size = New Size(186, 26)
        txtName.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtAddress.Location = New Point(176, 131)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(186, 26)
        txtAddress.TabIndex = 11
        ' 
        ' txtNumber
        ' 
        txtNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNumber.Location = New Point(176, 172)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(186, 26)
        txtNumber.TabIndex = 10
        ' 
        ' txtGuestID
        ' 
        txtGuestID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtGuestID.Location = New Point(176, 43)
        txtGuestID.Name = "txtGuestID"
        txtGuestID.Size = New Size(186, 26)
        txtGuestID.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 19)
        Label4.TabIndex = 7
        Label4.Text = "Contact Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 19)
        Label3.TabIndex = 6
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 19)
        Label2.TabIndex = 5
        Label2.Text = "Guest Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 19)
        Label1.TabIndex = 4
        Label1.Text = "Guest ID:"
        ' 
        ' GuestProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 396)
        Controls.Add(btnCreate)
        Controls.Add(btnBack)
        Controls.Add(btnLogOut)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "GuestProfile"
        Text = "Guest Profile"
        GroupBox2.ResumeLayout(False)
        CType(dgGuest, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgGuest As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents txtName As TextBox
End Class
