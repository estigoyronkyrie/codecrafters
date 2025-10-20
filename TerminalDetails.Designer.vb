<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminalDetails
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
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtNumberOfPlatforms = New System.Windows.Forms.TextBox()
        Me.txtOperatingHours = New System.Windows.Forms.TextBox()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtTerminalName = New System.Windows.Forms.TextBox()
        Me.txtTerminalID = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblFacilitiesAvailable = New System.Windows.Forms.Label()
        Me.lblNumberOfPlatforms = New System.Windows.Forms.Label()
        Me.lblOperatingHours = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblTerminalName = New System.Windows.Forms.Label()
        Me.lblTerminalID = New System.Windows.Forms.Label()
        Me.lblRestrooms = New System.Windows.Forms.Label()
        Me.lblWaitingArea = New System.Windows.Forms.Label()
        Me.lblParking = New System.Windows.Forms.Label()
        Me.lblFoodStalls = New System.Windows.Forms.Label()
        Me.lblTicketingBooths = New System.Windows.Forms.Label()
        Me.comboxRestrooms = New System.Windows.Forms.ComboBox()
        Me.comboxWaitingArea = New System.Windows.Forms.ComboBox()
        Me.comboxParking = New System.Windows.Forms.ComboBox()
        Me.comboxFoodStalls = New System.Windows.Forms.ComboBox()
        Me.comboxTicketingBooths = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(590, 91)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(357, 31)
        Me.txtStatus.TabIndex = 107
        '
        'txtNumberOfPlatforms
        '
        Me.txtNumberOfPlatforms.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfPlatforms.Location = New System.Drawing.Point(759, 49)
        Me.txtNumberOfPlatforms.Name = "txtNumberOfPlatforms"
        Me.txtNumberOfPlatforms.Size = New System.Drawing.Size(188, 31)
        Me.txtNumberOfPlatforms.TabIndex = 106
        '
        'txtOperatingHours
        '
        Me.txtOperatingHours.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperatingHours.Location = New System.Drawing.Point(231, 274)
        Me.txtOperatingHours.Name = "txtOperatingHours"
        Me.txtOperatingHours.Size = New System.Drawing.Size(242, 31)
        Me.txtOperatingHours.TabIndex = 105
        '
        'txtRegion
        '
        Me.txtRegion.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegion.Location = New System.Drawing.Point(154, 231)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(319, 31)
        Me.txtRegion.TabIndex = 104
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(209, 189)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(264, 31)
        Me.txtCity.TabIndex = 103
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(240, 146)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(233, 31)
        Me.txtLocation.TabIndex = 102
        '
        'txtTerminalName
        '
        Me.txtTerminalName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminalName.Location = New System.Drawing.Point(224, 104)
        Me.txtTerminalName.Name = "txtTerminalName"
        Me.txtTerminalName.Size = New System.Drawing.Size(249, 31)
        Me.txtTerminalName.TabIndex = 101
        '
        'txtTerminalID
        '
        Me.txtTerminalID.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerminalID.Location = New System.Drawing.Point(197, 62)
        Me.txtTerminalID.Name = "txtTerminalID"
        Me.txtTerminalID.Size = New System.Drawing.Size(276, 31)
        Me.txtTerminalID.TabIndex = 100
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(579, 367)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 40)
        Me.btnUpdate.TabIndex = 99
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(332, 367)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 40)
        Me.btnEdit.TabIndex = 98
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(456, 367)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 40)
        Me.btnClear.TabIndex = 97
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(209, 367)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 40)
        Me.btnSubmit.TabIndex = 96
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(513, 96)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 24)
        Me.lblStatus.TabIndex = 95
        Me.lblStatus.Text = "Status: "
        '
        'lblFacilitiesAvailable
        '
        Me.lblFacilitiesAvailable.AutoSize = True
        Me.lblFacilitiesAvailable.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFacilitiesAvailable.ForeColor = System.Drawing.Color.White
        Me.lblFacilitiesAvailable.Location = New System.Drawing.Point(513, 134)
        Me.lblFacilitiesAvailable.Name = "lblFacilitiesAvailable"
        Me.lblFacilitiesAvailable.Size = New System.Drawing.Size(163, 24)
        Me.lblFacilitiesAvailable.TabIndex = 93
        Me.lblFacilitiesAvailable.Text = "Facilities Available:"
        '
        'lblNumberOfPlatforms
        '
        Me.lblNumberOfPlatforms.AutoSize = True
        Me.lblNumberOfPlatforms.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfPlatforms.ForeColor = System.Drawing.Color.White
        Me.lblNumberOfPlatforms.Location = New System.Drawing.Point(513, 50)
        Me.lblNumberOfPlatforms.Name = "lblNumberOfPlatforms"
        Me.lblNumberOfPlatforms.Size = New System.Drawing.Size(227, 24)
        Me.lblNumberOfPlatforms.TabIndex = 91
        Me.lblNumberOfPlatforms.Text = "Number of Platforms/Bays: "
        '
        'lblOperatingHours
        '
        Me.lblOperatingHours.AutoSize = True
        Me.lblOperatingHours.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperatingHours.ForeColor = System.Drawing.Color.White
        Me.lblOperatingHours.Location = New System.Drawing.Point(72, 275)
        Me.lblOperatingHours.Name = "lblOperatingHours"
        Me.lblOperatingHours.Size = New System.Drawing.Size(143, 24)
        Me.lblOperatingHours.TabIndex = 90
        Me.lblOperatingHours.Text = "Operating Hours:"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegion.ForeColor = System.Drawing.Color.White
        Me.lblRegion.Location = New System.Drawing.Point(72, 232)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(70, 24)
        Me.lblRegion.TabIndex = 89
        Me.lblRegion.Text = "Region:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(72, 190)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(122, 24)
        Me.lblCity.TabIndex = 88
        Me.lblCity.Text = "City/Province:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.White
        Me.lblLocation.Location = New System.Drawing.Point(72, 147)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(155, 24)
        Me.lblLocation.TabIndex = 87
        Me.lblLocation.Text = "Location/Address:"
        '
        'lblTerminalName
        '
        Me.lblTerminalName.AutoSize = True
        Me.lblTerminalName.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerminalName.ForeColor = System.Drawing.Color.White
        Me.lblTerminalName.Location = New System.Drawing.Point(72, 105)
        Me.lblTerminalName.Name = "lblTerminalName"
        Me.lblTerminalName.Size = New System.Drawing.Size(133, 24)
        Me.lblTerminalName.TabIndex = 86
        Me.lblTerminalName.Text = "Terminal Name:"
        '
        'lblTerminalID
        '
        Me.lblTerminalID.AutoSize = True
        Me.lblTerminalID.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerminalID.ForeColor = System.Drawing.Color.White
        Me.lblTerminalID.Location = New System.Drawing.Point(72, 63)
        Me.lblTerminalID.Name = "lblTerminalID"
        Me.lblTerminalID.Size = New System.Drawing.Size(105, 24)
        Me.lblTerminalID.TabIndex = 85
        Me.lblTerminalID.Text = "Terminal ID:"
        '
        'lblRestrooms
        '
        Me.lblRestrooms.AutoSize = True
        Me.lblRestrooms.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestrooms.ForeColor = System.Drawing.Color.White
        Me.lblRestrooms.Location = New System.Drawing.Point(576, 158)
        Me.lblRestrooms.Name = "lblRestrooms"
        Me.lblRestrooms.Size = New System.Drawing.Size(100, 24)
        Me.lblRestrooms.TabIndex = 108
        Me.lblRestrooms.Text = "Restrooms:"
        '
        'lblWaitingArea
        '
        Me.lblWaitingArea.AutoSize = True
        Me.lblWaitingArea.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaitingArea.ForeColor = System.Drawing.Color.White
        Me.lblWaitingArea.Location = New System.Drawing.Point(576, 193)
        Me.lblWaitingArea.Name = "lblWaitingArea"
        Me.lblWaitingArea.Size = New System.Drawing.Size(114, 24)
        Me.lblWaitingArea.TabIndex = 109
        Me.lblWaitingArea.Text = "Waiting Area:"
        '
        'lblParking
        '
        Me.lblParking.AutoSize = True
        Me.lblParking.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParking.ForeColor = System.Drawing.Color.White
        Me.lblParking.Location = New System.Drawing.Point(576, 228)
        Me.lblParking.Name = "lblParking"
        Me.lblParking.Size = New System.Drawing.Size(75, 24)
        Me.lblParking.TabIndex = 110
        Me.lblParking.Text = "Parking:"
        '
        'lblFoodStalls
        '
        Me.lblFoodStalls.AutoSize = True
        Me.lblFoodStalls.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodStalls.ForeColor = System.Drawing.Color.White
        Me.lblFoodStalls.Location = New System.Drawing.Point(576, 263)
        Me.lblFoodStalls.Name = "lblFoodStalls"
        Me.lblFoodStalls.Size = New System.Drawing.Size(104, 24)
        Me.lblFoodStalls.TabIndex = 111
        Me.lblFoodStalls.Text = "Food Stalls:"
        '
        'lblTicketingBooths
        '
        Me.lblTicketingBooths.AutoSize = True
        Me.lblTicketingBooths.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketingBooths.ForeColor = System.Drawing.Color.White
        Me.lblTicketingBooths.Location = New System.Drawing.Point(576, 298)
        Me.lblTicketingBooths.Name = "lblTicketingBooths"
        Me.lblTicketingBooths.Size = New System.Drawing.Size(148, 24)
        Me.lblTicketingBooths.TabIndex = 112
        Me.lblTicketingBooths.Text = "Ticketing Booths:"
        '
        'comboxRestrooms
        '
        Me.comboxRestrooms.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxRestrooms.FormattingEnabled = True
        Me.comboxRestrooms.Items.AddRange(New Object() {"YES", "NO", "LIMITED"})
        Me.comboxRestrooms.Location = New System.Drawing.Point(740, 155)
        Me.comboxRestrooms.Name = "comboxRestrooms"
        Me.comboxRestrooms.Size = New System.Drawing.Size(147, 29)
        Me.comboxRestrooms.TabIndex = 113
        '
        'comboxWaitingArea
        '
        Me.comboxWaitingArea.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxWaitingArea.FormattingEnabled = True
        Me.comboxWaitingArea.Items.AddRange(New Object() {"YES", "NO", "LIMITED"})
        Me.comboxWaitingArea.Location = New System.Drawing.Point(740, 190)
        Me.comboxWaitingArea.Name = "comboxWaitingArea"
        Me.comboxWaitingArea.Size = New System.Drawing.Size(147, 29)
        Me.comboxWaitingArea.TabIndex = 114
        '
        'comboxParking
        '
        Me.comboxParking.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxParking.FormattingEnabled = True
        Me.comboxParking.Items.AddRange(New Object() {"YES", "NO", "LIMITED"})
        Me.comboxParking.Location = New System.Drawing.Point(740, 225)
        Me.comboxParking.Name = "comboxParking"
        Me.comboxParking.Size = New System.Drawing.Size(147, 29)
        Me.comboxParking.TabIndex = 115
        '
        'comboxFoodStalls
        '
        Me.comboxFoodStalls.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxFoodStalls.FormattingEnabled = True
        Me.comboxFoodStalls.Items.AddRange(New Object() {"YES", "NO", "LIMITED"})
        Me.comboxFoodStalls.Location = New System.Drawing.Point(740, 260)
        Me.comboxFoodStalls.Name = "comboxFoodStalls"
        Me.comboxFoodStalls.Size = New System.Drawing.Size(147, 29)
        Me.comboxFoodStalls.TabIndex = 116
        '
        'comboxTicketingBooths
        '
        Me.comboxTicketingBooths.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxTicketingBooths.FormattingEnabled = True
        Me.comboxTicketingBooths.Items.AddRange(New Object() {"YES", "NO", "LIMITED"})
        Me.comboxTicketingBooths.Location = New System.Drawing.Point(740, 295)
        Me.comboxTicketingBooths.Name = "comboxTicketingBooths"
        Me.comboxTicketingBooths.Size = New System.Drawing.Size(147, 29)
        Me.comboxTicketingBooths.TabIndex = 117
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(701, 367)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 40)
        Me.btnDelete.TabIndex = 118
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'TerminalDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 696)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.comboxTicketingBooths)
        Me.Controls.Add(Me.comboxFoodStalls)
        Me.Controls.Add(Me.comboxParking)
        Me.Controls.Add(Me.comboxWaitingArea)
        Me.Controls.Add(Me.comboxRestrooms)
        Me.Controls.Add(Me.lblTicketingBooths)
        Me.Controls.Add(Me.lblFoodStalls)
        Me.Controls.Add(Me.lblParking)
        Me.Controls.Add(Me.lblWaitingArea)
        Me.Controls.Add(Me.lblRestrooms)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtNumberOfPlatforms)
        Me.Controls.Add(Me.txtOperatingHours)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtTerminalName)
        Me.Controls.Add(Me.txtTerminalID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblFacilitiesAvailable)
        Me.Controls.Add(Me.lblNumberOfPlatforms)
        Me.Controls.Add(Me.lblOperatingHours)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblTerminalName)
        Me.Controls.Add(Me.lblTerminalID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TerminalDetails"
        Me.Text = "TerminalDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfPlatforms As System.Windows.Forms.TextBox
    Friend WithEvents txtOperatingHours As System.Windows.Forms.TextBox
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtTerminalName As System.Windows.Forms.TextBox
    Friend WithEvents txtTerminalID As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblFacilitiesAvailable As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfPlatforms As System.Windows.Forms.Label
    Friend WithEvents lblOperatingHours As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblTerminalName As System.Windows.Forms.Label
    Friend WithEvents lblTerminalID As System.Windows.Forms.Label
    Friend WithEvents lblRestrooms As System.Windows.Forms.Label
    Friend WithEvents lblWaitingArea As System.Windows.Forms.Label
    Friend WithEvents lblParking As System.Windows.Forms.Label
    Friend WithEvents lblFoodStalls As System.Windows.Forms.Label
    Friend WithEvents lblTicketingBooths As System.Windows.Forms.Label
    Friend WithEvents comboxRestrooms As System.Windows.Forms.ComboBox
    Friend WithEvents comboxWaitingArea As System.Windows.Forms.ComboBox
    Friend WithEvents comboxParking As System.Windows.Forms.ComboBox
    Friend WithEvents comboxFoodStalls As System.Windows.Forms.ComboBox
    Friend WithEvents comboxTicketingBooths As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
