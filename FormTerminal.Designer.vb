<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTerminal
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnTerminalRecords = New System.Windows.Forms.Button()
        Me.btnTerminalDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(12, 69)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1015, 696)
        Me.Panel5.TabIndex = 6
        '
        'btnTerminalRecords
        '
        Me.btnTerminalRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnTerminalRecords.FlatAppearance.BorderSize = 0
        Me.btnTerminalRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminalRecords.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminalRecords.ForeColor = System.Drawing.Color.White
        Me.btnTerminalRecords.Location = New System.Drawing.Point(184, 12)
        Me.btnTerminalRecords.Name = "btnTerminalRecords"
        Me.btnTerminalRecords.Size = New System.Drawing.Size(181, 51)
        Me.btnTerminalRecords.TabIndex = 11
        Me.btnTerminalRecords.Text = "Terminal Records"
        Me.btnTerminalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerminalRecords.UseVisualStyleBackColor = False
        '
        'btnTerminalDetails
        '
        Me.btnTerminalDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnTerminalDetails.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnTerminalDetails.FlatAppearance.BorderSize = 0
        Me.btnTerminalDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminalDetails.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminalDetails.ForeColor = System.Drawing.Color.White
        Me.btnTerminalDetails.Location = New System.Drawing.Point(13, 12)
        Me.btnTerminalDetails.Name = "btnTerminalDetails"
        Me.btnTerminalDetails.Size = New System.Drawing.Size(170, 51)
        Me.btnTerminalDetails.TabIndex = 10
        Me.btnTerminalDetails.Text = "Terminal Details"
        Me.btnTerminalDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerminalDetails.UseVisualStyleBackColor = False
        '
        'FormTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 777)
        Me.Controls.Add(Me.btnTerminalRecords)
        Me.Controls.Add(Me.btnTerminalDetails)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTerminal"
        Me.Text = "FormTerminal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnTerminalRecords As System.Windows.Forms.Button
    Friend WithEvents btnTerminalDetails As System.Windows.Forms.Button
End Class
