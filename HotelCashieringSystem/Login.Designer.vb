<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblUser = New Label()
        lblPass = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblUser.Location = New Point(12, 42)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(70, 14)
        lblUser.TabIndex = 0
        lblUser.Text = "Username:"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblPass.Location = New Point(12, 73)
        lblPass.Margin = New Padding(4, 0, 4, 0)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(70, 14)
        lblPass.TabIndex = 1
        lblPass.Text = "Password:"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUser.Location = New Point(80, 39)
        txtUser.Margin = New Padding(4, 3, 4, 3)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(117, 23)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPass.Location = New Point(80, 70)
        txtPass.Margin = New Padding(4, 3, 4, 3)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(117, 23)
        txtPass.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogin.Location = New Point(12, 99)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(186, 27)
        btnLogin.TabIndex = 4
        btnLogin.TabStop = False
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.Location = New Point(12, 132)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(186, 23)
        btnCancel.TabIndex = 5
        btnCancel.TabStop = False
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(27, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 24)
        Label1.TabIndex = 6
        Label1.Text = "BS Inn Hotel"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Login
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(210, 161)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
End Class
