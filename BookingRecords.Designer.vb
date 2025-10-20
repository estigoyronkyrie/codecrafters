<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingRecords
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
        Me.dgvBookingRecords = New System.Windows.Forms.DataGridView()
        Me.btnResetSeat = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtBookingNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDeleteAllRecords = New System.Windows.Forms.Button()
        CType(Me.dgvBookingRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBookingRecords
        '
        Me.dgvBookingRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBookingRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBookingRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvBookingRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookingRecords.Location = New System.Drawing.Point(4, 3)
        Me.dgvBookingRecords.Name = "dgvBookingRecords"
        Me.dgvBookingRecords.RowTemplate.Height = 24
        Me.dgvBookingRecords.Size = New System.Drawing.Size(1007, 628)
        Me.dgvBookingRecords.TabIndex = 0
        '
        'btnResetSeat
        '
        Me.btnResetSeat.Font = New System.Drawing.Font("Roboto Cn", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetSeat.Location = New System.Drawing.Point(12, 638)
        Me.btnResetSeat.Name = "btnResetSeat"
        Me.btnResetSeat.Size = New System.Drawing.Size(104, 46)
        Me.btnResetSeat.TabIndex = 1
        Me.btnResetSeat.Text = "RESET SEAT"
        Me.btnResetSeat.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Cn", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(282, 638)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(154, 46)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE RECORDS"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtBookingNumber
        '
        Me.txtBookingNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBookingNumber.DefaultText = ""
        Me.txtBookingNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBookingNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBookingNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBookingNumber.DisabledState.Parent = Me.txtBookingNumber
        Me.txtBookingNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBookingNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBookingNumber.FocusedState.Parent = Me.txtBookingNumber
        Me.txtBookingNumber.ForeColor = System.Drawing.Color.Black
        Me.txtBookingNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBookingNumber.HoverState.Parent = Me.txtBookingNumber
        Me.txtBookingNumber.Location = New System.Drawing.Point(443, 646)
        Me.txtBookingNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBookingNumber.Name = "txtBookingNumber"
        Me.txtBookingNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBookingNumber.PlaceholderText = "Booking Number"
        Me.txtBookingNumber.SelectedText = ""
        Me.txtBookingNumber.ShadowDecoration.Parent = Me.txtBookingNumber
        Me.txtBookingNumber.Size = New System.Drawing.Size(221, 30)
        Me.txtBookingNumber.TabIndex = 3
        '
        'btnDeleteAllRecords
        '
        Me.btnDeleteAllRecords.Font = New System.Drawing.Font("Roboto Cn", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAllRecords.Location = New System.Drawing.Point(122, 637)
        Me.btnDeleteAllRecords.Name = "btnDeleteAllRecords"
        Me.btnDeleteAllRecords.Size = New System.Drawing.Size(154, 46)
        Me.btnDeleteAllRecords.TabIndex = 4
        Me.btnDeleteAllRecords.Text = "DELETE ALL RECORDS"
        Me.btnDeleteAllRecords.UseVisualStyleBackColor = True
        '
        'BookingRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 696)
        Me.Controls.Add(Me.btnDeleteAllRecords)
        Me.Controls.Add(Me.txtBookingNumber)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnResetSeat)
        Me.Controls.Add(Me.dgvBookingRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookingRecords"
        Me.Text = "BookingRecords"
        CType(Me.dgvBookingRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBookingRecords As System.Windows.Forms.DataGridView
    Friend WithEvents btnResetSeat As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtBookingNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDeleteAllRecords As System.Windows.Forms.Button
End Class
