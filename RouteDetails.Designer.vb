<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RouteDetails
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
        Me.lblRouteID = New System.Windows.Forms.Label()
        Me.lblRouteNumber = New System.Windows.Forms.Label()
        Me.lblStartingPoint = New System.Windows.Forms.Label()
        Me.lblEndPoint = New System.Windows.Forms.Label()
        Me.lblRestStops = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblEstimatedTime = New System.Windows.Forms.Label()
        Me.lblBusOperator = New System.Windows.Forms.Label()
        Me.lblTypeOfService = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtRouteID = New System.Windows.Forms.TextBox()
        Me.txtRouteName = New System.Windows.Forms.TextBox()
        Me.txtStartingPoint = New System.Windows.Forms.TextBox()
        Me.txtEndPoint = New System.Windows.Forms.TextBox()
        Me.txtRestStops = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtEstimatedTime = New System.Windows.Forms.TextBox()
        Me.txtBusOperator = New System.Windows.Forms.TextBox()
        Me.txtTypeOfService = New System.Windows.Forms.TextBox()
        Me.txtSchedule = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRouteID
        '
        Me.lblRouteID.AutoSize = True
        Me.lblRouteID.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouteID.ForeColor = System.Drawing.Color.White
        Me.lblRouteID.Location = New System.Drawing.Point(53, 63)
        Me.lblRouteID.Name = "lblRouteID"
        Me.lblRouteID.Size = New System.Drawing.Size(82, 24)
        Me.lblRouteID.TabIndex = 51
        Me.lblRouteID.Text = "Route ID:"
        '
        'lblRouteNumber
        '
        Me.lblRouteNumber.AutoSize = True
        Me.lblRouteNumber.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouteNumber.ForeColor = System.Drawing.Color.White
        Me.lblRouteNumber.Location = New System.Drawing.Point(53, 105)
        Me.lblRouteNumber.Name = "lblRouteNumber"
        Me.lblRouteNumber.Size = New System.Drawing.Size(110, 24)
        Me.lblRouteNumber.TabIndex = 52
        Me.lblRouteNumber.Text = "Route Name:"
        '
        'lblStartingPoint
        '
        Me.lblStartingPoint.AutoSize = True
        Me.lblStartingPoint.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingPoint.ForeColor = System.Drawing.Color.White
        Me.lblStartingPoint.Location = New System.Drawing.Point(53, 147)
        Me.lblStartingPoint.Name = "lblStartingPoint"
        Me.lblStartingPoint.Size = New System.Drawing.Size(192, 24)
        Me.lblStartingPoint.TabIndex = 53
        Me.lblStartingPoint.Text = "Origin (Starting Point): "
        '
        'lblEndPoint
        '
        Me.lblEndPoint.AutoSize = True
        Me.lblEndPoint.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndPoint.ForeColor = System.Drawing.Color.White
        Me.lblEndPoint.Location = New System.Drawing.Point(53, 191)
        Me.lblEndPoint.Name = "lblEndPoint"
        Me.lblEndPoint.Size = New System.Drawing.Size(198, 24)
        Me.lblEndPoint.TabIndex = 54
        Me.lblEndPoint.Text = "Destination (End Point):"
        '
        'lblRestStops
        '
        Me.lblRestStops.AutoSize = True
        Me.lblRestStops.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestStops.ForeColor = System.Drawing.Color.White
        Me.lblRestStops.Location = New System.Drawing.Point(53, 231)
        Me.lblRestStops.Name = "lblRestStops"
        Me.lblRestStops.Size = New System.Drawing.Size(202, 24)
        Me.lblRestStops.TabIndex = 55
        Me.lblRestStops.Text = "Major Stops/Rest Stops:"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.ForeColor = System.Drawing.Color.White
        Me.lblDistance.Location = New System.Drawing.Point(53, 273)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(124, 24)
        Me.lblDistance.TabIndex = 56
        Me.lblDistance.Text = "Distance (km):"
        '
        'lblEstimatedTime
        '
        Me.lblEstimatedTime.AutoSize = True
        Me.lblEstimatedTime.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimatedTime.ForeColor = System.Drawing.Color.White
        Me.lblEstimatedTime.Location = New System.Drawing.Point(500, 63)
        Me.lblEstimatedTime.Name = "lblEstimatedTime"
        Me.lblEstimatedTime.Size = New System.Drawing.Size(189, 24)
        Me.lblEstimatedTime.TabIndex = 57
        Me.lblEstimatedTime.Text = "Estimated Travel Time:"
        '
        'lblBusOperator
        '
        Me.lblBusOperator.AutoSize = True
        Me.lblBusOperator.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusOperator.ForeColor = System.Drawing.Color.White
        Me.lblBusOperator.Location = New System.Drawing.Point(500, 105)
        Me.lblBusOperator.Name = "lblBusOperator"
        Me.lblBusOperator.Size = New System.Drawing.Size(202, 24)
        Me.lblBusOperator.TabIndex = 58
        Me.lblBusOperator.Text = "Bus Company/Operator: "
        '
        'lblTypeOfService
        '
        Me.lblTypeOfService.AutoSize = True
        Me.lblTypeOfService.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeOfService.ForeColor = System.Drawing.Color.White
        Me.lblTypeOfService.Location = New System.Drawing.Point(500, 147)
        Me.lblTypeOfService.Name = "lblTypeOfService"
        Me.lblTypeOfService.Size = New System.Drawing.Size(139, 24)
        Me.lblTypeOfService.TabIndex = 59
        Me.lblTypeOfService.Text = "Type of Service: "
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.ForeColor = System.Drawing.Color.White
        Me.lblSchedule.Location = New System.Drawing.Point(500, 191)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(177, 24)
        Me.lblSchedule.TabIndex = 60
        Me.lblSchedule.Text = "Schedule/Frequency:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(500, 231)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(70, 24)
        Me.lblStatus.TabIndex = 61
        Me.lblStatus.Text = "Status: "
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(209, 367)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 40)
        Me.btnSubmit.TabIndex = 70
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(455, 367)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 40)
        Me.btnClear.TabIndex = 71
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(332, 367)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 40)
        Me.btnEdit.TabIndex = 72
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(578, 367)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 40)
        Me.btnUpdate.TabIndex = 73
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtRouteID
        '
        Me.txtRouteID.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouteID.Location = New System.Drawing.Point(145, 62)
        Me.txtRouteID.Name = "txtRouteID"
        Me.txtRouteID.Size = New System.Drawing.Size(309, 31)
        Me.txtRouteID.TabIndex = 74
        '
        'txtRouteName
        '
        Me.txtRouteName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouteName.Location = New System.Drawing.Point(178, 104)
        Me.txtRouteName.Name = "txtRouteName"
        Me.txtRouteName.Size = New System.Drawing.Size(276, 31)
        Me.txtRouteName.TabIndex = 75
        '
        'txtStartingPoint
        '
        Me.txtStartingPoint.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartingPoint.Location = New System.Drawing.Point(258, 146)
        Me.txtStartingPoint.Name = "txtStartingPoint"
        Me.txtStartingPoint.Size = New System.Drawing.Size(196, 31)
        Me.txtStartingPoint.TabIndex = 76
        '
        'txtEndPoint
        '
        Me.txtEndPoint.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndPoint.Location = New System.Drawing.Point(270, 188)
        Me.txtEndPoint.Name = "txtEndPoint"
        Me.txtEndPoint.Size = New System.Drawing.Size(184, 31)
        Me.txtEndPoint.TabIndex = 77
        '
        'txtRestStops
        '
        Me.txtRestStops.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRestStops.Location = New System.Drawing.Point(270, 230)
        Me.txtRestStops.Name = "txtRestStops"
        Me.txtRestStops.Size = New System.Drawing.Size(185, 31)
        Me.txtRestStops.TabIndex = 78
        '
        'txtDistance
        '
        Me.txtDistance.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistance.Location = New System.Drawing.Point(195, 272)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(261, 31)
        Me.txtDistance.TabIndex = 79
        '
        'txtEstimatedTime
        '
        Me.txtEstimatedTime.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstimatedTime.Location = New System.Drawing.Point(704, 62)
        Me.txtEstimatedTime.Name = "txtEstimatedTime"
        Me.txtEstimatedTime.Size = New System.Drawing.Size(261, 31)
        Me.txtEstimatedTime.TabIndex = 80
        '
        'txtBusOperator
        '
        Me.txtBusOperator.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusOperator.Location = New System.Drawing.Point(713, 104)
        Me.txtBusOperator.Name = "txtBusOperator"
        Me.txtBusOperator.Size = New System.Drawing.Size(252, 31)
        Me.txtBusOperator.TabIndex = 81
        '
        'txtTypeOfService
        '
        Me.txtTypeOfService.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeOfService.Location = New System.Drawing.Point(650, 146)
        Me.txtTypeOfService.Name = "txtTypeOfService"
        Me.txtTypeOfService.Size = New System.Drawing.Size(315, 31)
        Me.txtTypeOfService.TabIndex = 82
        '
        'txtSchedule
        '
        Me.txtSchedule.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchedule.Location = New System.Drawing.Point(683, 188)
        Me.txtSchedule.Name = "txtSchedule"
        Me.txtSchedule.Size = New System.Drawing.Size(282, 31)
        Me.txtSchedule.TabIndex = 83
        '
        'txtStatus
        '
        Me.txtStatus.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(576, 230)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(389, 31)
        Me.txtStatus.TabIndex = 84
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(701, 367)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 40)
        Me.btnDelete.TabIndex = 85
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'RouteDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 696)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtSchedule)
        Me.Controls.Add(Me.txtTypeOfService)
        Me.Controls.Add(Me.txtBusOperator)
        Me.Controls.Add(Me.txtEstimatedTime)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.txtRestStops)
        Me.Controls.Add(Me.txtEndPoint)
        Me.Controls.Add(Me.txtStartingPoint)
        Me.Controls.Add(Me.txtRouteName)
        Me.Controls.Add(Me.txtRouteID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.lblTypeOfService)
        Me.Controls.Add(Me.lblBusOperator)
        Me.Controls.Add(Me.lblEstimatedTime)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblRestStops)
        Me.Controls.Add(Me.lblEndPoint)
        Me.Controls.Add(Me.lblStartingPoint)
        Me.Controls.Add(Me.lblRouteNumber)
        Me.Controls.Add(Me.lblRouteID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RouteDetails"
        Me.Text = "RouteDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRouteID As System.Windows.Forms.Label
    Friend WithEvents lblRouteNumber As System.Windows.Forms.Label
    Friend WithEvents lblStartingPoint As System.Windows.Forms.Label
    Friend WithEvents lblEndPoint As System.Windows.Forms.Label
    Friend WithEvents lblRestStops As System.Windows.Forms.Label
    Friend WithEvents lblDistance As System.Windows.Forms.Label
    Friend WithEvents lblEstimatedTime As System.Windows.Forms.Label
    Friend WithEvents lblBusOperator As System.Windows.Forms.Label
    Friend WithEvents lblTypeOfService As System.Windows.Forms.Label
    Friend WithEvents lblSchedule As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtRouteID As System.Windows.Forms.TextBox
    Friend WithEvents txtRouteName As System.Windows.Forms.TextBox
    Friend WithEvents txtStartingPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtEndPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtRestStops As System.Windows.Forms.TextBox
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtEstimatedTime As System.Windows.Forms.TextBox
    Friend WithEvents txtBusOperator As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeOfService As System.Windows.Forms.TextBox
    Friend WithEvents txtSchedule As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
