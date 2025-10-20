<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceRecords
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
        Me.dgvMaintenanceRecords = New System.Windows.Forms.DataGridView()
        Me.NextMaintenance = New System.Windows.Forms.DateTimePicker()
        Me.DateMaintenance = New System.Windows.Forms.DateTimePicker()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblBusNumber = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtServiceProvider = New System.Windows.Forms.TextBox()
        Me.txtServiceDescription = New System.Windows.Forms.TextBox()
        Me.txtPartsRepaired = New System.Windows.Forms.TextBox()
        Me.txtMaintenanceType = New System.Windows.Forms.TextBox()
        Me.txtBusNumber = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblNextScheduledMaintenance = New System.Windows.Forms.Label()
        Me.lblServiceProvider = New System.Windows.Forms.Label()
        Me.lblServiceDescription = New System.Windows.Forms.Label()
        Me.lblPartsRepaired = New System.Windows.Forms.Label()
        Me.lblMaintenanceType = New System.Windows.Forms.Label()
        Me.lblDateOfMaintenance = New System.Windows.Forms.Label()
        Me.txtMaintenanceID = New System.Windows.Forms.TextBox()
        Me.lblMaintenanceID = New System.Windows.Forms.Label()
        CType(Me.dgvMaintenanceRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMaintenanceRecords
        '
        Me.dgvMaintenanceRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvMaintenanceRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaintenanceRecords.Location = New System.Drawing.Point(4, 4)
        Me.dgvMaintenanceRecords.Name = "dgvMaintenanceRecords"
        Me.dgvMaintenanceRecords.RowTemplate.Height = 24
        Me.dgvMaintenanceRecords.Size = New System.Drawing.Size(1008, 400)
        Me.dgvMaintenanceRecords.TabIndex = 100
        '
        'NextMaintenance
        '
        Me.NextMaintenance.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextMaintenance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NextMaintenance.Location = New System.Drawing.Point(773, 507)
        Me.NextMaintenance.Name = "NextMaintenance"
        Me.NextMaintenance.Size = New System.Drawing.Size(194, 31)
        Me.NextMaintenance.TabIndex = 128
        '
        'DateMaintenance
        '
        Me.DateMaintenance.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateMaintenance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateMaintenance.Location = New System.Drawing.Point(240, 507)
        Me.DateMaintenance.Name = "DateMaintenance"
        Me.DateMaintenance.Size = New System.Drawing.Size(236, 31)
        Me.DateMaintenance.TabIndex = 127
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(666, 549)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(301, 31)
        Me.txtRemarks.TabIndex = 126
        '
        'lblBusNumber
        '
        Me.lblBusNumber.AutoSize = True
        Me.lblBusNumber.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNumber.ForeColor = System.Drawing.Color.White
        Me.lblBusNumber.Location = New System.Drawing.Point(40, 466)
        Me.lblBusNumber.Name = "lblBusNumber"
        Me.lblBusNumber.Size = New System.Drawing.Size(111, 24)
        Me.lblBusNumber.TabIndex = 125
        Me.lblBusNumber.Text = "Bus Number:"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(704, 644)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 40)
        Me.btnDelete.TabIndex = 124
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(581, 644)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 40)
        Me.btnUpdate.TabIndex = 123
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(335, 644)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 40)
        Me.btnEdit.TabIndex = 122
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(458, 644)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 40)
        Me.btnClear.TabIndex = 121
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(212, 644)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 40)
        Me.btnSubmit.TabIndex = 120
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtServiceProvider
        '
        Me.txtServiceProvider.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceProvider.Location = New System.Drawing.Point(757, 465)
        Me.txtServiceProvider.Name = "txtServiceProvider"
        Me.txtServiceProvider.Size = New System.Drawing.Size(210, 31)
        Me.txtServiceProvider.TabIndex = 119
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceDescription.Location = New System.Drawing.Point(697, 424)
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.Size = New System.Drawing.Size(270, 31)
        Me.txtServiceDescription.TabIndex = 118
        '
        'txtPartsRepaired
        '
        Me.txtPartsRepaired.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartsRepaired.Location = New System.Drawing.Point(268, 591)
        Me.txtPartsRepaired.Name = "txtPartsRepaired"
        Me.txtPartsRepaired.Size = New System.Drawing.Size(206, 31)
        Me.txtPartsRepaired.TabIndex = 117
        '
        'txtMaintenanceType
        '
        Me.txtMaintenanceType.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaintenanceType.Location = New System.Drawing.Point(220, 549)
        Me.txtMaintenanceType.Name = "txtMaintenanceType"
        Me.txtMaintenanceType.Size = New System.Drawing.Size(255, 31)
        Me.txtMaintenanceType.TabIndex = 116
        '
        'txtBusNumber
        '
        Me.txtBusNumber.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusNumber.Location = New System.Drawing.Point(172, 465)
        Me.txtBusNumber.Name = "txtBusNumber"
        Me.txtBusNumber.Size = New System.Drawing.Size(304, 31)
        Me.txtBusNumber.TabIndex = 115
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(514, 550)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(136, 24)
        Me.lblRemarks.TabIndex = 113
        Me.lblRemarks.Text = "Remarks/Notes:"
        '
        'lblNextScheduledMaintenance
        '
        Me.lblNextScheduledMaintenance.AutoSize = True
        Me.lblNextScheduledMaintenance.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextScheduledMaintenance.ForeColor = System.Drawing.Color.White
        Me.lblNextScheduledMaintenance.Location = New System.Drawing.Point(514, 510)
        Me.lblNextScheduledMaintenance.Name = "lblNextScheduledMaintenance"
        Me.lblNextScheduledMaintenance.Size = New System.Drawing.Size(243, 24)
        Me.lblNextScheduledMaintenance.TabIndex = 112
        Me.lblNextScheduledMaintenance.Text = "Next Scheduled Maintenance:"
        '
        'lblServiceProvider
        '
        Me.lblServiceProvider.AutoSize = True
        Me.lblServiceProvider.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceProvider.ForeColor = System.Drawing.Color.White
        Me.lblServiceProvider.Location = New System.Drawing.Point(512, 466)
        Me.lblServiceProvider.Name = "lblServiceProvider"
        Me.lblServiceProvider.Size = New System.Drawing.Size(226, 24)
        Me.lblServiceProvider.TabIndex = 111
        Me.lblServiceProvider.Text = "Service Provider/Mechanic:"
        '
        'lblServiceDescription
        '
        Me.lblServiceDescription.AutoSize = True
        Me.lblServiceDescription.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceDescription.ForeColor = System.Drawing.Color.White
        Me.lblServiceDescription.Location = New System.Drawing.Point(513, 425)
        Me.lblServiceDescription.Name = "lblServiceDescription"
        Me.lblServiceDescription.Size = New System.Drawing.Size(168, 24)
        Me.lblServiceDescription.TabIndex = 110
        Me.lblServiceDescription.Text = "Service Description:"
        '
        'lblPartsRepaired
        '
        Me.lblPartsRepaired.AutoSize = True
        Me.lblPartsRepaired.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartsRepaired.ForeColor = System.Drawing.Color.White
        Me.lblPartsRepaired.Location = New System.Drawing.Point(40, 592)
        Me.lblPartsRepaired.Name = "lblPartsRepaired"
        Me.lblPartsRepaired.Size = New System.Drawing.Size(208, 24)
        Me.lblPartsRepaired.TabIndex = 109
        Me.lblPartsRepaired.Text = "Parts Replaced/Repaired:"
        '
        'lblMaintenanceType
        '
        Me.lblMaintenanceType.AutoSize = True
        Me.lblMaintenanceType.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenanceType.ForeColor = System.Drawing.Color.White
        Me.lblMaintenanceType.Location = New System.Drawing.Point(40, 550)
        Me.lblMaintenanceType.Name = "lblMaintenanceType"
        Me.lblMaintenanceType.Size = New System.Drawing.Size(158, 24)
        Me.lblMaintenanceType.TabIndex = 108
        Me.lblMaintenanceType.Text = "Maintenance Type:"
        '
        'lblDateOfMaintenance
        '
        Me.lblDateOfMaintenance.AutoSize = True
        Me.lblDateOfMaintenance.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfMaintenance.ForeColor = System.Drawing.Color.White
        Me.lblDateOfMaintenance.Location = New System.Drawing.Point(40, 511)
        Me.lblDateOfMaintenance.Name = "lblDateOfMaintenance"
        Me.lblDateOfMaintenance.Size = New System.Drawing.Size(176, 24)
        Me.lblDateOfMaintenance.TabIndex = 107
        Me.lblDateOfMaintenance.Text = "Date of Maintenance:"
        '
        'txtMaintenanceID
        '
        Me.txtMaintenanceID.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaintenanceID.Location = New System.Drawing.Point(198, 424)
        Me.txtMaintenanceID.Name = "txtMaintenanceID"
        Me.txtMaintenanceID.Size = New System.Drawing.Size(278, 31)
        Me.txtMaintenanceID.TabIndex = 130
        '
        'lblMaintenanceID
        '
        Me.lblMaintenanceID.AutoSize = True
        Me.lblMaintenanceID.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenanceID.ForeColor = System.Drawing.Color.White
        Me.lblMaintenanceID.Location = New System.Drawing.Point(40, 425)
        Me.lblMaintenanceID.Name = "lblMaintenanceID"
        Me.lblMaintenanceID.Size = New System.Drawing.Size(137, 24)
        Me.lblMaintenanceID.TabIndex = 129
        Me.lblMaintenanceID.Text = "Maintenance ID:"
        '
        'MaintenanceRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 696)
        Me.Controls.Add(Me.txtMaintenanceID)
        Me.Controls.Add(Me.lblMaintenanceID)
        Me.Controls.Add(Me.NextMaintenance)
        Me.Controls.Add(Me.DateMaintenance)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lblBusNumber)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtServiceProvider)
        Me.Controls.Add(Me.txtServiceDescription)
        Me.Controls.Add(Me.txtPartsRepaired)
        Me.Controls.Add(Me.txtMaintenanceType)
        Me.Controls.Add(Me.txtBusNumber)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblNextScheduledMaintenance)
        Me.Controls.Add(Me.lblServiceProvider)
        Me.Controls.Add(Me.lblServiceDescription)
        Me.Controls.Add(Me.lblPartsRepaired)
        Me.Controls.Add(Me.lblMaintenanceType)
        Me.Controls.Add(Me.lblDateOfMaintenance)
        Me.Controls.Add(Me.dgvMaintenanceRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MaintenanceRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MaintenanceRecords"
        CType(Me.dgvMaintenanceRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMaintenanceRecords As System.Windows.Forms.DataGridView
    Friend WithEvents NextMaintenance As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateMaintenance As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lblBusNumber As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtServiceProvider As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPartsRepaired As System.Windows.Forms.TextBox
    Friend WithEvents txtMaintenanceType As System.Windows.Forms.TextBox
    Friend WithEvents txtBusNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents lblNextScheduledMaintenance As System.Windows.Forms.Label
    Friend WithEvents lblServiceProvider As System.Windows.Forms.Label
    Friend WithEvents lblServiceDescription As System.Windows.Forms.Label
    Friend WithEvents lblPartsRepaired As System.Windows.Forms.Label
    Friend WithEvents lblMaintenanceType As System.Windows.Forms.Label
    Friend WithEvents lblDateOfMaintenance As System.Windows.Forms.Label
    Friend WithEvents txtMaintenanceID As System.Windows.Forms.TextBox
    Friend WithEvents lblMaintenanceID As System.Windows.Forms.Label
End Class
