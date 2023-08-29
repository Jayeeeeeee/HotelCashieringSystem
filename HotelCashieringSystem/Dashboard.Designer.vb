<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnReserve = New Button()
        btnCheck = New Button()
        btnAdmin = New Button()
        Panel1 = New Panel()
        btnLogOut = New Button()
        GroupBox1 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox2 = New GroupBox()
        DataGridView2 = New DataGridView()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(btnReserve)
        FlowLayoutPanel1.Controls.Add(btnCheck)
        FlowLayoutPanel1.Controls.Add(btnAdmin)
        FlowLayoutPanel1.Location = New Point(12, 12)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(445, 31)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' btnReserve
        ' 
        btnReserve.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReserve.Location = New Point(3, 3)
        btnReserve.Name = "btnReserve"
        btnReserve.Size = New Size(133, 23)
        btnReserve.TabIndex = 0
        btnReserve.Text = "Reservation"
        btnReserve.UseVisualStyleBackColor = True
        ' 
        ' btnCheck
        ' 
        btnCheck.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCheck.Location = New Point(142, 3)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(161, 23)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check In / Check Out"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdmin.Location = New Point(309, 3)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(133, 23)
        btnAdmin.TabIndex = 2
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogOut)
        Panel1.Location = New Point(649, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(139, 31)
        Panel1.TabIndex = 2
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(3, 3)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(15, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(383, 292)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rooms Occupied"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 22)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(371, 264)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(404, 49)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(383, 292)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Rooms Available"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(6, 22)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(371, 264)
        DataGridView2.TabIndex = 1
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 353)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(FlowLayoutPanel1)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
End Class
