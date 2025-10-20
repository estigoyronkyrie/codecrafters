<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuses
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMaintenanceRecords = New System.Windows.Forms.Button()
        Me.btnBusesDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(12, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1015, 696)
        Me.Panel3.TabIndex = 4
        '
        'btnMaintenanceRecords
        '
        Me.btnMaintenanceRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnMaintenanceRecords.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnMaintenanceRecords.FlatAppearance.BorderSize = 0
        Me.btnMaintenanceRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaintenanceRecords.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenanceRecords.ForeColor = System.Drawing.Color.White
        Me.btnMaintenanceRecords.Location = New System.Drawing.Point(152, 12)
        Me.btnMaintenanceRecords.Name = "btnMaintenanceRecords"
        Me.btnMaintenanceRecords.Size = New System.Drawing.Size(229, 51)
        Me.btnMaintenanceRecords.TabIndex = 7
        Me.btnMaintenanceRecords.Text = "Maintenance Records"
        Me.btnMaintenanceRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaintenanceRecords.UseVisualStyleBackColor = False
        '
        'btnBusesDetails
        '
        Me.btnBusesDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnBusesDetails.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnBusesDetails.FlatAppearance.BorderSize = 0
        Me.btnBusesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusesDetails.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusesDetails.ForeColor = System.Drawing.Color.White
        Me.btnBusesDetails.Location = New System.Drawing.Point(10, 12)
        Me.btnBusesDetails.Name = "btnBusesDetails"
        Me.btnBusesDetails.Size = New System.Drawing.Size(143, 51)
        Me.btnBusesDetails.TabIndex = 5
        Me.btnBusesDetails.Text = "Buses Records"
        Me.btnBusesDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusesDetails.UseVisualStyleBackColor = False
        '
        'FormBuses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 777)
        Me.Controls.Add(Me.btnMaintenanceRecords)
        Me.Controls.Add(Me.btnBusesDetails)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBuses"
        Me.Text = "FormBuses"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnMaintenanceRecords As System.Windows.Forms.Button
    Friend WithEvents btnBusesDetails As System.Windows.Forms.Button
End Class
