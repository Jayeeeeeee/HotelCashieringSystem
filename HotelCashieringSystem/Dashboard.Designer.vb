﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        components = New ComponentModel.Container()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnGuest = New Button()
        btnReserve = New Button()
        btnCheck = New Button()
        Panel1 = New Panel()
        btnLogOut = New Button()
        GroupBox1 = New GroupBox()
        dgvOccupied = New DataGridView()
        GroupBox2 = New GroupBox()
        dgvAvailable = New DataGridView()
        lblDateTime = New Label()
        tmrDash = New Timer(components)
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dgvOccupied, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvAvailable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(btnGuest)
        FlowLayoutPanel1.Controls.Add(btnReserve)
        FlowLayoutPanel1.Controls.Add(btnCheck)
        FlowLayoutPanel1.Location = New Point(12, 12)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(585, 31)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' btnGuest
        ' 
        btnGuest.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuest.Location = New Point(3, 3)
        btnGuest.Name = "btnGuest"
        btnGuest.Size = New Size(133, 23)
        btnGuest.TabIndex = 3
        btnGuest.Text = "Guest Profile"
        btnGuest.UseVisualStyleBackColor = True
        ' 
        ' btnReserve
        ' 
        btnReserve.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnReserve.Location = New Point(142, 3)
        btnReserve.Name = "btnReserve"
        btnReserve.Size = New Size(133, 23)
        btnReserve.TabIndex = 0
        btnReserve.Text = "Reservation"
        btnReserve.UseVisualStyleBackColor = True
        ' 
        ' btnCheck
        ' 
        btnCheck.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCheck.Location = New Point(281, 3)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(161, 23)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check In / Check Out"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnLogOut)
        Panel1.Location = New Point(1032, 12)
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
        GroupBox1.Controls.Add(dgvOccupied)
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.Location = New Point(15, 49)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(570, 292)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rooms Occupied"
        ' 
        ' dgvOccupied
        ' 
        dgvOccupied.AllowUserToAddRows = False
        dgvOccupied.AllowUserToDeleteRows = False
        dgvOccupied.AllowUserToResizeColumns = False
        dgvOccupied.AllowUserToResizeRows = False
        dgvOccupied.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOccupied.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvOccupied.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOccupied.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvOccupied.GridColor = SystemColors.Menu
        dgvOccupied.Location = New Point(6, 22)
        dgvOccupied.Name = "dgvOccupied"
        dgvOccupied.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvOccupied.RowTemplate.Height = 25
        dgvOccupied.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOccupied.Size = New Size(558, 264)
        dgvOccupied.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgvAvailable)
        GroupBox2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox2.Location = New Point(602, 49)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(570, 292)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Rooms Available"
        ' 
        ' dgvAvailable
        ' 
        dgvAvailable.AllowUserToAddRows = False
        dgvAvailable.AllowUserToDeleteRows = False
        dgvAvailable.AllowUserToResizeColumns = False
        dgvAvailable.AllowUserToResizeRows = False
        dgvAvailable.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dgvAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAvailable.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvAvailable.GridColor = SystemColors.Menu
        dgvAvailable.ImeMode = ImeMode.NoControl
        dgvAvailable.Location = New Point(6, 22)
        dgvAvailable.Name = "dgvAvailable"
        dgvAvailable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        dgvAvailable.RowTemplate.Height = 25
        dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAvailable.Size = New Size(558, 264)
        dgvAvailable.TabIndex = 1
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.Location = New Point(865, 19)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(161, 14)
        lblDateTime.TabIndex = 34
        lblDateTime.Text = "00/00/0000 00:00:00 am"
        ' 
        ' tmrDash
        ' 
        tmrDash.Enabled = True
        tmrDash.Interval = 1000
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 353)
        Controls.Add(lblDateTime)
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
        CType(dgvOccupied, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(dgvAvailable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnReserve As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogOut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvOccupied As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvAvailable As DataGridView
    Friend WithEvents btnGuest As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrDash As Timer
End Class
