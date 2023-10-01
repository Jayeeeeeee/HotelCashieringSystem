<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Records
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
        btnBack = New Button()
        lblDateTime = New Label()
        btnLogOut = New Button()
        GroupBox4 = New GroupBox()
        dgvCITransaction = New DataGridView()
        GroupBox3 = New GroupBox()
        dgvRTransaction = New DataGridView()
        tmrRecords = New Timer(components)
        SearchTxt = New TextBox()
        SearchCB = New ComboBox()
        GroupBox4.SuspendLayout()
        CType(dgvCITransaction, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgvRTransaction, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(12, 8)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 27)
        btnBack.TabIndex = 11
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblDateTime
        ' 
        lblDateTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = Color.Black
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.ForeColor = Color.OrangeRed
        lblDateTime.Location = New Point(1272, 17)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(1439, 9)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 30)
        btnLogOut.TabIndex = 33
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvCITransaction)
        GroupBox4.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox4.Location = New Point(12, 301)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(1560, 250)
        GroupBox4.TabIndex = 37
        GroupBox4.TabStop = False
        GroupBox4.Text = "Check-In Transaction"
        ' 
        ' dgvCITransaction
        ' 
        dgvCITransaction.AllowUserToAddRows = False
        dgvCITransaction.AllowUserToDeleteRows = False
        dgvCITransaction.AllowUserToResizeColumns = False
        dgvCITransaction.AllowUserToResizeRows = False
        dgvCITransaction.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCITransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCITransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCITransaction.Cursor = Cursors.Hand
        dgvCITransaction.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCITransaction.GridColor = SystemColors.Menu
        dgvCITransaction.ImeMode = ImeMode.NoControl
        dgvCITransaction.Location = New Point(6, 23)
        dgvCITransaction.Name = "dgvCITransaction"
        dgvCITransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvCITransaction.RowTemplate.Height = 25
        dgvCITransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCITransaction.Size = New Size(1548, 221)
        dgvCITransaction.TabIndex = 5
        dgvCITransaction.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(dgvRTransaction)
        GroupBox3.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox3.ForeColor = Color.Black
        GroupBox3.Location = New Point(12, 41)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1560, 250)
        GroupBox3.TabIndex = 36
        GroupBox3.TabStop = False
        GroupBox3.Text = "Reservation Transaction"
        ' 
        ' dgvRTransaction
        ' 
        dgvRTransaction.AllowUserToAddRows = False
        dgvRTransaction.AllowUserToDeleteRows = False
        dgvRTransaction.AllowUserToResizeColumns = False
        dgvRTransaction.AllowUserToResizeRows = False
        dgvRTransaction.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRTransaction.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvRTransaction.Location = New Point(6, 23)
        dgvRTransaction.Name = "dgvRTransaction"
        dgvRTransaction.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvRTransaction.RowTemplate.Height = 25
        dgvRTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRTransaction.Size = New Size(1548, 221)
        dgvRTransaction.TabIndex = 0
        dgvRTransaction.TabStop = False
        ' 
        ' tmrRecords
        ' 
        tmrRecords.Interval = 1000
        ' 
        ' SearchTxt
        ' 
        SearchTxt.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SearchTxt.Location = New Point(151, 9)
        SearchTxt.Name = "SearchTxt"
        SearchTxt.Size = New Size(534, 26)
        SearchTxt.TabIndex = 38
        ' 
        ' SearchCB
        ' 
        SearchCB.DropDownStyle = ComboBoxStyle.DropDownList
        SearchCB.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SearchCB.FormattingEnabled = True
        SearchCB.Items.AddRange(New Object() {"Payment ID", "Payment Receiver", "Reservation No.", "Check-In No.", "Guest Name", "Room No.", "Payment Date", "Reservation Status", "Check-In Status"})
        SearchCB.Location = New Point(691, 8)
        SearchCB.Name = "SearchCB"
        SearchCB.Size = New Size(180, 27)
        SearchCB.TabIndex = 39
        ' 
        ' Records
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1584, 561)
        Controls.Add(SearchCB)
        Controls.Add(SearchTxt)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(lblDateTime)
        Controls.Add(btnLogOut)
        Controls.Add(btnBack)
        Name = "Records"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation & Check-In Transactions"
        GroupBox4.ResumeLayout(False)
        CType(dgvCITransaction, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(dgvRTransaction, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvCITransaction As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvRTransaction As DataGridView
    Friend WithEvents tmrRecords As Timer
    Friend WithEvents SearchTxt As TextBox
    Friend WithEvents SearchCB As ComboBox
End Class
