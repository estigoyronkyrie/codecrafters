<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confirmation))
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDeparture = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.lblDateDeparture = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPassengerNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblClassType = New System.Windows.Forms.Label()
        Me.lblPassengerName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblForDeparture = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSeatNo = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Panel()
        Me.PicBoxQRCode = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Label0.SuspendLayout()
        CType(Me.PicBoxQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(368, 545)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(147, 46)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Confirm"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(521, 545)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(147, 46)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblDeparture
        '
        Me.lblDeparture.AutoSize = True
        Me.lblDeparture.Font = New System.Drawing.Font("Arial Nova Cond", 34.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeparture.Location = New System.Drawing.Point(23, 112)
        Me.lblDeparture.Name = "lblDeparture"
        Me.lblDeparture.Size = New System.Drawing.Size(268, 70)
        Me.lblDeparture.TabIndex = 9
        Me.lblDeparture.Text = "Departure"
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Arial Nova Cond", 34.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.Location = New System.Drawing.Point(401, 109)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(302, 70)
        Me.lblDestination.TabIndex = 11
        Me.lblDestination.Text = "Destination"
        '
        'lblDateDeparture
        '
        Me.lblDateDeparture.AutoSize = True
        Me.lblDateDeparture.BackColor = System.Drawing.Color.Transparent
        Me.lblDateDeparture.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateDeparture.Location = New System.Drawing.Point(29, 35)
        Me.lblDateDeparture.Name = "lblDateDeparture"
        Me.lblDateDeparture.Size = New System.Drawing.Size(73, 33)
        Me.lblDateDeparture.TabIndex = 12
        Me.lblDateDeparture.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 33)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Total Passenger: "
        '
        'lblPassengerNo
        '
        Me.lblPassengerNo.AutoSize = True
        Me.lblPassengerNo.BackColor = System.Drawing.Color.Transparent
        Me.lblPassengerNo.Font = New System.Drawing.Font("Arial Nova", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassengerNo.Location = New System.Drawing.Point(244, 225)
        Me.lblPassengerNo.Name = "lblPassengerNo"
        Me.lblPassengerNo.Size = New System.Drawing.Size(49, 29)
        Me.lblPassengerNo.TabIndex = 15
        Me.lblPassengerNo.Text = "NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 33)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Bus Class Type:"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(36, 328)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(86, 33)
        Me.label.TabIndex = 17
        Me.label.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 419)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 33)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Contact Number:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(35, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 33)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Address:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(813, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Cn", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(867, 474)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Booking Number"
        '
        'lblClassType
        '
        Me.lblClassType.AutoSize = True
        Me.lblClassType.BackColor = System.Drawing.Color.Transparent
        Me.lblClassType.Font = New System.Drawing.Font("Arial Nova Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassType.Location = New System.Drawing.Point(232, 258)
        Me.lblClassType.Name = "lblClassType"
        Me.lblClassType.Size = New System.Drawing.Size(159, 29)
        Me.lblClassType.TabIndex = 24
        Me.lblClassType.Text = "Bus Class Type"
        '
        'lblPassengerName
        '
        Me.lblPassengerName.AutoSize = True
        Me.lblPassengerName.Font = New System.Drawing.Font("Arial Nova Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassengerName.Location = New System.Drawing.Point(128, 332)
        Me.lblPassengerName.Name = "lblPassengerName"
        Me.lblPassengerName.Size = New System.Drawing.Size(178, 29)
        Me.lblPassengerName.TabIndex = 25
        Me.lblPassengerName.Text = "Passenger Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial Nova Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(154, 377)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(92, 29)
        Me.lblAddress.TabIndex = 26
        Me.lblAddress.Text = "Address"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Arial Nova Cond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(245, 423)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(170, 29)
        Me.lblContactNumber.TabIndex = 27
        Me.lblContactNumber.Text = "Contact Number"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(203, 35)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(73, 33)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "TIME"
        '
        'lblForDeparture
        '
        Me.lblForDeparture.AutoSize = True
        Me.lblForDeparture.Font = New System.Drawing.Font("Arial Nova Cond", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForDeparture.Location = New System.Drawing.Point(33, 88)
        Me.lblForDeparture.Name = "lblForDeparture"
        Me.lblForDeparture.Size = New System.Drawing.Size(83, 21)
        Me.lblForDeparture.TabIndex = 29
        Me.lblForDeparture.Text = "Departure:"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Font = New System.Drawing.Font("Arial Nova Cond", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.Location = New System.Drawing.Point(413, 88)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(93, 21)
        Me.lbl11.TabIndex = 30
        Me.lbl11.Text = "Destination:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Nova Cond", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 33)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Seat No:"
        '
        'lblSeatNo
        '
        Me.lblSeatNo.AutoSize = True
        Me.lblSeatNo.Font = New System.Drawing.Font("Arial Nova", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatNo.Location = New System.Drawing.Point(446, 225)
        Me.lblSeatNo.Name = "lblSeatNo"
        Me.lblSeatNo.Size = New System.Drawing.Size(44, 29)
        Me.lblSeatNo.TabIndex = 32
        Me.lblSeatNo.Text = "No"
        '
        'Label0
        '
        Me.Label0.BackColor = System.Drawing.Color.White
        Me.Label0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label0.Controls.Add(Me.PicBoxQRCode)
        Me.Label0.Controls.Add(Me.lblSeatNo)
        Me.Label0.Controls.Add(Me.Label1)
        Me.Label0.Controls.Add(Me.lbl11)
        Me.Label0.Controls.Add(Me.lblForDeparture)
        Me.Label0.Controls.Add(Me.lblTime)
        Me.Label0.Controls.Add(Me.lblContactNumber)
        Me.Label0.Controls.Add(Me.lblAddress)
        Me.Label0.Controls.Add(Me.lblPassengerName)
        Me.Label0.Controls.Add(Me.lblClassType)
        Me.Label0.Controls.Add(Me.Label12)
        Me.Label0.Controls.Add(Me.PictureBox1)
        Me.Label0.Controls.Add(Me.Label11)
        Me.Label0.Controls.Add(Me.Label10)
        Me.Label0.Controls.Add(Me.label)
        Me.Label0.Controls.Add(Me.Label3)
        Me.Label0.Controls.Add(Me.lblPassengerNo)
        Me.Label0.Controls.Add(Me.Label2)
        Me.Label0.Controls.Add(Me.lblDateDeparture)
        Me.Label0.Controls.Add(Me.lblDestination)
        Me.Label0.Controls.Add(Me.lblDeparture)
        Me.Label0.Font = New System.Drawing.Font("Playbill", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label0.Location = New System.Drawing.Point(-1, -1)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(1064, 526)
        Me.Label0.TabIndex = 12
        '
        'PicBoxQRCode
        '
        Me.PicBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBoxQRCode.Location = New System.Drawing.Point(795, 238)
        Me.PicBoxQRCode.Name = "PicBoxQRCode"
        Me.PicBoxQRCode.Size = New System.Drawing.Size(239, 228)
        Me.PicBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxQRCode.TabIndex = 91
        Me.PicBoxQRCode.TabStop = False
        '
        'Confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 610)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Confirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Label0.ResumeLayout(False)
        Me.Label0.PerformLayout()
        CType(Me.PicBoxQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblDeparture As System.Windows.Forms.Label
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents lblDateDeparture As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPassengerNo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblClassType As System.Windows.Forms.Label
    Friend WithEvents lblPassengerName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblForDeparture As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSeatNo As System.Windows.Forms.Label
    Friend WithEvents Label0 As System.Windows.Forms.Panel
    Friend WithEvents PicBoxQRCode As System.Windows.Forms.PictureBox
End Class
