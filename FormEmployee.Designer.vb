<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
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
        Me.btnEmployeeDetail = New System.Windows.Forms.Button()
        Me.btnEmployeeRecord = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnEmployeeDetail
        '
        Me.btnEmployeeDetail.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployeeDetail.FlatAppearance.BorderSize = 0
        Me.btnEmployeeDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeDetail.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeDetail.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeDetail.Location = New System.Drawing.Point(12, 12)
        Me.btnEmployeeDetail.Name = "btnEmployeeDetail"
        Me.btnEmployeeDetail.Size = New System.Drawing.Size(202, 51)
        Me.btnEmployeeDetail.TabIndex = 8
        Me.btnEmployeeDetail.Text = "Employee Details"
        Me.btnEmployeeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployeeDetail.UseVisualStyleBackColor = False
        '
        'btnEmployeeRecord
        '
        Me.btnEmployeeRecord.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployeeRecord.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnEmployeeRecord.FlatAppearance.BorderSize = 0
        Me.btnEmployeeRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeRecord.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeRecord.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeRecord.Location = New System.Drawing.Point(214, 12)
        Me.btnEmployeeRecord.Name = "btnEmployeeRecord"
        Me.btnEmployeeRecord.Size = New System.Drawing.Size(188, 51)
        Me.btnEmployeeRecord.TabIndex = 5
        Me.btnEmployeeRecord.Text = "Employee Records"
        Me.btnEmployeeRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployeeRecord.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(15, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1011, 695)
        Me.Panel2.TabIndex = 9
        '
        'FormEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 777)
        Me.Controls.Add(Me.btnEmployeeRecord)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnEmployeeDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEmployee"
        Me.Text = "FormEmployee"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEmployeeDetail As System.Windows.Forms.Button
    Friend WithEvents btnEmployeeRecord As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
