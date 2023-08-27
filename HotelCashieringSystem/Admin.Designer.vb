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
        btnBack = New Button()
        btnGuestProfile = New Button()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(146, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(60, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnRoomProfile
        ' 
        btnRoomProfile.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRoomProfile.Location = New Point(12, 115)
        btnRoomProfile.Name = "btnRoomProfile"
        btnRoomProfile.Size = New Size(194, 68)
        btnRoomProfile.TabIndex = 1
        btnRoomProfile.Text = "Room Profile"
        btnRoomProfile.UseVisualStyleBackColor = True
        ' 
        ' btnDash
        ' 
        btnDash.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDash.Location = New Point(12, 189)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(194, 68)
        btnDash.TabIndex = 2
        btnDash.Text = "Report/Dashboard"
        btnDash.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(60, 23)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnGuestProfile
        ' 
        btnGuestProfile.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuestProfile.Location = New Point(12, 41)
        btnGuestProfile.Name = "btnGuestProfile"
        btnGuestProfile.Size = New Size(194, 68)
        btnGuestProfile.TabIndex = 0
        btnGuestProfile.Text = "Guest Profile"
        btnGuestProfile.UseVisualStyleBackColor = True
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(218, 264)
        Controls.Add(btnBack)
        Controls.Add(btnLogOut)
        Controls.Add(btnDash)
        Controls.Add(btnGuestProfile)
        Controls.Add(btnRoomProfile)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnDash As Button
    Friend WithEvents btnRoomProfile As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnGuestProfile As Button
End Class
