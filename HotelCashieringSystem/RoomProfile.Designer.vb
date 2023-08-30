<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomProfile
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
        btnClear = New Button()
        btnDelete = New Button()
        GroupBox2 = New GroupBox()
        dgRoom = New DataGridView()
        btnUpdate = New Button()
        GroupBox1 = New GroupBox()
        cmbRoomType = New ComboBox()
        txtBeds = New TextBox()
        txtRate = New TextBox()
        txtRoomID = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCreate = New Button()
        btnBack = New Button()
        btnLogOut = New Button()
        GroupBox2.SuspendLayout()
        CType(dgRoom, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnClear.Location = New Point(300, 316)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(90, 68)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelete.Location = New Point(204, 316)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(90, 68)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete Room"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(dgRoom)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(396, 51)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(435, 341)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Room Information"
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
        dgRoom.Size = New Size(423, 306)
        dgRoom.TabIndex = 0
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpdate.Location = New Point(108, 316)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(90, 68)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update Room"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(cmbRoomType)
        GroupBox1.Controls.Add(txtBeds)
        GroupBox1.Controls.Add(txtRate)
        GroupBox1.Controls.Add(txtRoomID)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 51)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 259)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Items.AddRange(New Object() {"", "Single", "Double", "King"})
        cmbRoomType.Location = New Point(176, 89)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(186, 27)
        cmbRoomType.TabIndex = 5
        ' 
        ' txtBeds
        ' 
        txtBeds.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtBeds.Location = New Point(176, 131)
        txtBeds.Name = "txtBeds"
        txtBeds.Size = New Size(186, 26)
        txtBeds.TabIndex = 6
        ' 
        ' txtRate
        ' 
        txtRate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtRate.Location = New Point(176, 172)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(186, 26)
        txtRate.TabIndex = 5
        ' 
        ' txtRoomID
        ' 
        txtRoomID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtRoomID.Location = New Point(176, 43)
        txtRoomID.Name = "txtRoomID"
        txtRoomID.Size = New Size(186, 26)
        txtRoomID.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 19)
        Label4.TabIndex = 3
        Label4.Text = "Room Rate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 19)
        Label3.TabIndex = 2
        Label3.Text = "No. Of Beds:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 19)
        Label2.TabIndex = 1
        Label2.Text = "Room Type:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 19)
        Label1.TabIndex = 0
        Label1.Text = "Room No.:"
        ' 
        ' btnCreate
        ' 
        btnCreate.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreate.Location = New Point(12, 316)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(90, 68)
        btnCreate.TabIndex = 7
        btnCreate.Text = "Create Room"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 22)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(698, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 22)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' RoomProfile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 396)
        Controls.Add(btnBack)
        Controls.Add(btnLogOut)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(GroupBox2)
        Controls.Add(btnUpdate)
        Controls.Add(GroupBox1)
        Controls.Add(btnCreate)
        Name = "RoomProfile"
        Text = "Room Profile"
        GroupBox2.ResumeLayout(False)
        CType(dgRoom, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgRoom As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtBeds As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogOut As Button
End Class
