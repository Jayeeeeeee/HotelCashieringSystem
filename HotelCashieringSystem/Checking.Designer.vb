<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checking
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
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnLogOut.Location = New Point(698, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(133, 23)
        btnLogOut.TabIndex = 3
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(133, 23)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Checking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 396)
        Controls.Add(btnLogOut)
        Controls.Add(btnBack)
        Name = "Checking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checking"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBack As Button
End Class
