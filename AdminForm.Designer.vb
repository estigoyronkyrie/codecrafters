<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.btnAdminAccount = New System.Windows.Forms.Button()
        Me.btnLoginHistory = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUserAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdminAccount
        '
        Me.btnAdminAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnAdminAccount.FlatAppearance.BorderSize = 0
        Me.btnAdminAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminAccount.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminAccount.ForeColor = System.Drawing.Color.White
        Me.btnAdminAccount.Location = New System.Drawing.Point(12, 12)
        Me.btnAdminAccount.Name = "btnAdminAccount"
        Me.btnAdminAccount.Size = New System.Drawing.Size(196, 51)
        Me.btnAdminAccount.TabIndex = 1
        Me.btnAdminAccount.Text = "Admin Accounts"
        Me.btnAdminAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminAccount.UseVisualStyleBackColor = False
        '
        'btnLoginHistory
        '
        Me.btnLoginHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginHistory.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLoginHistory.FlatAppearance.BorderSize = 0
        Me.btnLoginHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginHistory.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginHistory.ForeColor = System.Drawing.Color.White
        Me.btnLoginHistory.Location = New System.Drawing.Point(403, 12)
        Me.btnLoginHistory.Name = "btnLoginHistory"
        Me.btnLoginHistory.Size = New System.Drawing.Size(196, 51)
        Me.btnLoginHistory.TabIndex = 2
        Me.btnLoginHistory.Text = "Login History"
        Me.btnLoginHistory.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 696)
        Me.Panel1.TabIndex = 3
        '
        'btnUserAccount
        '
        Me.btnUserAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnUserAccount.FlatAppearance.BorderSize = 0
        Me.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserAccount.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccount.ForeColor = System.Drawing.Color.White
        Me.btnUserAccount.Location = New System.Drawing.Point(208, 12)
        Me.btnUserAccount.Name = "btnUserAccount"
        Me.btnUserAccount.Size = New System.Drawing.Size(196, 51)
        Me.btnUserAccount.TabIndex = 4
        Me.btnUserAccount.Text = "User Accounts"
        Me.btnUserAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserAccount.UseVisualStyleBackColor = False
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 777)
        Me.Controls.Add(Me.btnLoginHistory)
        Me.Controls.Add(Me.btnUserAccount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdminAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdminAccount As System.Windows.Forms.Button
    Friend WithEvents btnLoginHistory As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUserAccount As System.Windows.Forms.Button

End Class
