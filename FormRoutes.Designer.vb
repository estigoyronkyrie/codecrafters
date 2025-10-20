<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRoutes
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnBusesRecords = New System.Windows.Forms.Button()
        Me.btnRouteDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(12, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1015, 696)
        Me.Panel4.TabIndex = 5
        '
        'btnBusesRecords
        '
        Me.btnBusesRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnBusesRecords.FlatAppearance.BorderSize = 0
        Me.btnBusesRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBusesRecords.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusesRecords.ForeColor = System.Drawing.Color.White
        Me.btnBusesRecords.Location = New System.Drawing.Point(156, 12)
        Me.btnBusesRecords.Name = "btnBusesRecords"
        Me.btnBusesRecords.Size = New System.Drawing.Size(154, 51)
        Me.btnBusesRecords.TabIndex = 9
        Me.btnBusesRecords.Text = "Route Records"
        Me.btnBusesRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusesRecords.UseVisualStyleBackColor = False
        '
        'btnRouteDetails
        '
        Me.btnRouteDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnRouteDetails.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRouteDetails.FlatAppearance.BorderSize = 0
        Me.btnRouteDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRouteDetails.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRouteDetails.ForeColor = System.Drawing.Color.White
        Me.btnRouteDetails.Location = New System.Drawing.Point(14, 12)
        Me.btnRouteDetails.Name = "btnRouteDetails"
        Me.btnRouteDetails.Size = New System.Drawing.Size(143, 51)
        Me.btnRouteDetails.TabIndex = 8
        Me.btnRouteDetails.Text = "Route Details"
        Me.btnRouteDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRouteDetails.UseVisualStyleBackColor = False
        '
        'FormRoutes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 777)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnBusesRecords)
        Me.Controls.Add(Me.btnRouteDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormRoutes"
        Me.Text = "FormRoutes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnBusesRecords As System.Windows.Forms.Button
    Friend WithEvents btnRouteDetails As System.Windows.Forms.Button
End Class
