﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        GroupBox2.SuspendLayout()
        CType(dgGuest, ComponentModel.ISupportInitialize).BeginInit()
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
        GroupBox1.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(12, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(378, 267)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
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
End Class
