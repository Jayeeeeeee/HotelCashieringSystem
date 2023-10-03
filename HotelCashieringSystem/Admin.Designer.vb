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
        dgvSales = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(464, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(60, 23)
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
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dgvSales)
        GroupBox1.Font = New Font("Consolas", 8F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(12, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(512, 194)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sales"
        ' 
        ' dgvSales
        ' 
        dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSales.Location = New Point(6, 38)
        dgvSales.Name = "dgvSales"
        dgvSales.RowTemplate.Height = 25
        dgvSales.Size = New Size(500, 150)
        dgvSales.TabIndex = 0
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 13)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(536, 247)
        Controls.Add(GroupBox1)
        Controls.Add(btnLogOut)
        Controls.Add(btnDash)
        Controls.Add(btnRoomProfile)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvSales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnRoomProfile As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
