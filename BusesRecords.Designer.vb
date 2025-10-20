<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusesRecords
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
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.lblDriverAssigned = New System.Windows.Forms.Label()
        Me.lblColorOrDesign = New System.Windows.Forms.Label()
        Me.lblFuelType = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblSeatingCapacity = New System.Windows.Forms.Label()
        Me.lblYearModel = New System.Windows.Forms.Label()
        Me.lblBusModel = New System.Windows.Forms.Label()
        Me.lblPlateNumber = New System.Windows.Forms.Label()
        Me.lblBusNumber = New System.Windows.Forms.Label()
        Me.txtBusNumber = New System.Windows.Forms.TextBox()
        Me.txtPlateNumber = New System.Windows.Forms.TextBox()
        Me.txtBusModel = New System.Windows.Forms.TextBox()
        Me.txtYearModel = New System.Windows.Forms.TextBox()
        Me.txtSeatingCapacity = New System.Windows.Forms.TextBox()
        Me.txtColorDesign = New System.Windows.Forms.TextBox()
        Me.txtDriverAssigned = New System.Windows.Forms.TextBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.comboxType = New System.Windows.Forms.ComboBox()
        Me.comboxStatus = New System.Windows.Forms.ComboBox()
        Me.comboxFuelType = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvBusRecords = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBusRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.ForeColor = System.Drawing.Color.White
        Me.lblRemarks.Location = New System.Drawing.Point(548, 557)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(136, 24)
        Me.lblRemarks.TabIndex = 21
        Me.lblRemarks.Text = "Remarks/Notes:"
        '
        'lblDriverAssigned
        '
        Me.lblDriverAssigned.AutoSize = True
        Me.lblDriverAssigned.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverAssigned.ForeColor = System.Drawing.Color.White
        Me.lblDriverAssigned.Location = New System.Drawing.Point(548, 515)
        Me.lblDriverAssigned.Name = "lblDriverAssigned"
        Me.lblDriverAssigned.Size = New System.Drawing.Size(139, 24)
        Me.lblDriverAssigned.TabIndex = 20
        Me.lblDriverAssigned.Text = "Driver Assigned:"
        '
        'lblColorOrDesign
        '
        Me.lblColorOrDesign.AutoSize = True
        Me.lblColorOrDesign.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorOrDesign.ForeColor = System.Drawing.Color.White
        Me.lblColorOrDesign.Location = New System.Drawing.Point(548, 473)
        Me.lblColorOrDesign.Name = "lblColorOrDesign"
        Me.lblColorOrDesign.Size = New System.Drawing.Size(119, 24)
        Me.lblColorOrDesign.TabIndex = 19
        Me.lblColorOrDesign.Text = "Color/Design:"
        '
        'lblFuelType
        '
        Me.lblFuelType.AutoSize = True
        Me.lblFuelType.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuelType.ForeColor = System.Drawing.Color.White
        Me.lblFuelType.Location = New System.Drawing.Point(548, 431)
        Me.lblFuelType.Name = "lblFuelType"
        Me.lblFuelType.Size = New System.Drawing.Size(91, 24)
        Me.lblFuelType.TabIndex = 18
        Me.lblFuelType.Text = "Fuel Type:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(548, 389)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 24)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Status:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.White
        Me.lblType.Location = New System.Drawing.Point(76, 601)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(53, 24)
        Me.lblType.TabIndex = 16
        Me.lblType.Text = "Type:"
        '
        'lblSeatingCapacity
        '
        Me.lblSeatingCapacity.AutoSize = True
        Me.lblSeatingCapacity.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatingCapacity.ForeColor = System.Drawing.Color.White
        Me.lblSeatingCapacity.Location = New System.Drawing.Point(76, 559)
        Me.lblSeatingCapacity.Name = "lblSeatingCapacity"
        Me.lblSeatingCapacity.Size = New System.Drawing.Size(147, 24)
        Me.lblSeatingCapacity.TabIndex = 15
        Me.lblSeatingCapacity.Text = "Seating Capacity:"
        '
        'lblYearModel
        '
        Me.lblYearModel.AutoSize = True
        Me.lblYearModel.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearModel.ForeColor = System.Drawing.Color.White
        Me.lblYearModel.Location = New System.Drawing.Point(76, 517)
        Me.lblYearModel.Name = "lblYearModel"
        Me.lblYearModel.Size = New System.Drawing.Size(103, 24)
        Me.lblYearModel.TabIndex = 14
        Me.lblYearModel.Text = "Year Model:"
        '
        'lblBusModel
        '
        Me.lblBusModel.AutoSize = True
        Me.lblBusModel.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusModel.ForeColor = System.Drawing.Color.White
        Me.lblBusModel.Location = New System.Drawing.Point(76, 475)
        Me.lblBusModel.Name = "lblBusModel"
        Me.lblBusModel.Size = New System.Drawing.Size(98, 24)
        Me.lblBusModel.TabIndex = 13
        Me.lblBusModel.Text = "Bus Model:"
        '
        'lblPlateNumber
        '
        Me.lblPlateNumber.AutoSize = True
        Me.lblPlateNumber.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlateNumber.ForeColor = System.Drawing.Color.White
        Me.lblPlateNumber.Location = New System.Drawing.Point(76, 433)
        Me.lblPlateNumber.Name = "lblPlateNumber"
        Me.lblPlateNumber.Size = New System.Drawing.Size(121, 24)
        Me.lblPlateNumber.TabIndex = 12
        Me.lblPlateNumber.Text = "Plate Number:"
        '
        'lblBusNumber
        '
        Me.lblBusNumber.AutoSize = True
        Me.lblBusNumber.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNumber.ForeColor = System.Drawing.Color.White
        Me.lblBusNumber.Location = New System.Drawing.Point(76, 391)
        Me.lblBusNumber.Name = "lblBusNumber"
        Me.lblBusNumber.Size = New System.Drawing.Size(111, 24)
        Me.lblBusNumber.TabIndex = 11
        Me.lblBusNumber.Text = "Bus Number:"
        '
        'txtBusNumber
        '
        Me.txtBusNumber.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusNumber.Location = New System.Drawing.Point(204, 388)
        Me.txtBusNumber.Name = "txtBusNumber"
        Me.txtBusNumber.Size = New System.Drawing.Size(284, 31)
        Me.txtBusNumber.TabIndex = 22
        '
        'txtPlateNumber
        '
        Me.txtPlateNumber.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlateNumber.Location = New System.Drawing.Point(214, 430)
        Me.txtPlateNumber.Name = "txtPlateNumber"
        Me.txtPlateNumber.Size = New System.Drawing.Size(274, 31)
        Me.txtPlateNumber.TabIndex = 23
        '
        'txtBusModel
        '
        Me.txtBusModel.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusModel.Location = New System.Drawing.Point(191, 472)
        Me.txtBusModel.Name = "txtBusModel"
        Me.txtBusModel.Size = New System.Drawing.Size(297, 31)
        Me.txtBusModel.TabIndex = 24
        '
        'txtYearModel
        '
        Me.txtYearModel.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearModel.Location = New System.Drawing.Point(199, 514)
        Me.txtYearModel.Name = "txtYearModel"
        Me.txtYearModel.Size = New System.Drawing.Size(289, 31)
        Me.txtYearModel.TabIndex = 25
        '
        'txtSeatingCapacity
        '
        Me.txtSeatingCapacity.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatingCapacity.Location = New System.Drawing.Point(243, 556)
        Me.txtSeatingCapacity.Name = "txtSeatingCapacity"
        Me.txtSeatingCapacity.Size = New System.Drawing.Size(245, 31)
        Me.txtSeatingCapacity.TabIndex = 26
        '
        'txtColorDesign
        '
        Me.txtColorDesign.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColorDesign.Location = New System.Drawing.Point(682, 472)
        Me.txtColorDesign.Name = "txtColorDesign"
        Me.txtColorDesign.Size = New System.Drawing.Size(252, 31)
        Me.txtColorDesign.TabIndex = 30
        '
        'txtDriverAssigned
        '
        Me.txtDriverAssigned.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDriverAssigned.Location = New System.Drawing.Point(702, 515)
        Me.txtDriverAssigned.Name = "txtDriverAssigned"
        Me.txtDriverAssigned.Size = New System.Drawing.Size(232, 31)
        Me.txtDriverAssigned.TabIndex = 31
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(699, 557)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(235, 31)
        Me.txtRemarks.TabIndex = 32
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(581, 644)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 40)
        Me.btnUpdate.TabIndex = 47
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(335, 644)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 40)
        Me.btnEdit.TabIndex = 46
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(458, 644)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 40)
        Me.btnClear.TabIndex = 45
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(212, 644)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 40)
        Me.btnSubmit.TabIndex = 44
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'comboxType
        '
        Me.comboxType.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxType.FormattingEnabled = True
        Me.comboxType.Items.AddRange(New Object() {"Airconditioned", "Ordinary"})
        Me.comboxType.Location = New System.Drawing.Point(149, 598)
        Me.comboxType.Name = "comboxType"
        Me.comboxType.Size = New System.Drawing.Size(339, 29)
        Me.comboxType.TabIndex = 48
        '
        'comboxStatus
        '
        Me.comboxStatus.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxStatus.FormattingEnabled = True
        Me.comboxStatus.Items.AddRange(New Object() {"Active", "Under Maintenance", "Retired"})
        Me.comboxStatus.Location = New System.Drawing.Point(629, 390)
        Me.comboxStatus.Name = "comboxStatus"
        Me.comboxStatus.Size = New System.Drawing.Size(305, 29)
        Me.comboxStatus.TabIndex = 49
        '
        'comboxFuelType
        '
        Me.comboxFuelType.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxFuelType.FormattingEnabled = True
        Me.comboxFuelType.Items.AddRange(New Object() {"Diesel", "Gasoline", "Electric", "Hybrid"})
        Me.comboxFuelType.Location = New System.Drawing.Point(654, 431)
        Me.comboxFuelType.Name = "comboxFuelType"
        Me.comboxFuelType.Size = New System.Drawing.Size(280, 29)
        Me.comboxFuelType.TabIndex = 50
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(704, 644)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 40)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvBusRecords
        '
        Me.dgvBusRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvBusRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusRecords.Location = New System.Drawing.Point(3, 5)
        Me.dgvBusRecords.Name = "dgvBusRecords"
        Me.dgvBusRecords.RowTemplate.Height = 24
        Me.dgvBusRecords.Size = New System.Drawing.Size(1008, 368)
        Me.dgvBusRecords.TabIndex = 52
        '
        'BusesRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 696)
        Me.Controls.Add(Me.dgvBusRecords)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.comboxFuelType)
        Me.Controls.Add(Me.comboxStatus)
        Me.Controls.Add(Me.comboxType)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtDriverAssigned)
        Me.Controls.Add(Me.txtColorDesign)
        Me.Controls.Add(Me.txtSeatingCapacity)
        Me.Controls.Add(Me.txtYearModel)
        Me.Controls.Add(Me.txtBusModel)
        Me.Controls.Add(Me.txtPlateNumber)
        Me.Controls.Add(Me.txtBusNumber)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.lblDriverAssigned)
        Me.Controls.Add(Me.lblColorOrDesign)
        Me.Controls.Add(Me.lblFuelType)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblSeatingCapacity)
        Me.Controls.Add(Me.lblYearModel)
        Me.Controls.Add(Me.lblBusModel)
        Me.Controls.Add(Me.lblPlateNumber)
        Me.Controls.Add(Me.lblBusNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BusesRecords"
        Me.Text = "         "
        CType(Me.dgvBusRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents lblDriverAssigned As System.Windows.Forms.Label
    Friend WithEvents lblColorOrDesign As System.Windows.Forms.Label
    Friend WithEvents lblFuelType As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblSeatingCapacity As System.Windows.Forms.Label
    Friend WithEvents lblYearModel As System.Windows.Forms.Label
    Friend WithEvents lblBusModel As System.Windows.Forms.Label
    Friend WithEvents lblPlateNumber As System.Windows.Forms.Label
    Friend WithEvents lblBusNumber As System.Windows.Forms.Label
    Friend WithEvents txtBusNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPlateNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtBusModel As System.Windows.Forms.TextBox
    Friend WithEvents txtYearModel As System.Windows.Forms.TextBox
    Friend WithEvents txtSeatingCapacity As System.Windows.Forms.TextBox
    Friend WithEvents txtColorDesign As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverAssigned As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents comboxType As System.Windows.Forms.ComboBox
    Friend WithEvents comboxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents comboxFuelType As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvBusRecords As System.Windows.Forms.DataGridView
End Class
