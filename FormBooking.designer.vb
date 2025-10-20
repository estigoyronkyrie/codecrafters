<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBooking
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnBookingRecords = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(12, 69)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1015, 696)
        Me.Panel6.TabIndex = 7
        '
        'btnBookingRecords
        '
        Me.btnBookingRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnBookingRecords.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBookingRecords.FlatAppearance.BorderSize = 0
        Me.btnBookingRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookingRecords.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookingRecords.ForeColor = System.Drawing.Color.White
        Me.btnBookingRecords.Location = New System.Drawing.Point(12, 12)
        Me.btnBookingRecords.Name = "btnBookingRecords"
        Me.btnBookingRecords.Size = New System.Drawing.Size(170, 51)
        Me.btnBookingRecords.TabIndex = 12
        Me.btnBookingRecords.Text = "Booking Records"
        Me.btnBookingRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookingRecords.UseVisualStyleBackColor = False
        '
        'FormBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 777)
        Me.Controls.Add(Me.btnBookingRecords)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBooking"
        Me.Text = "FormSchedule"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnBookingRecords As System.Windows.Forms.Button
End Class
