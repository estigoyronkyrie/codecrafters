<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeRecords
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
        Me.dgvEmployeeRecords = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentOfAdministrativeManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentOfOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentOfCustomerServiceSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentOfMaintenanceAndTechnicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvEmployeeRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployeeRecords
        '
        Me.dgvEmployeeRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmployeeRecords.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmployeeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeRecords.Location = New System.Drawing.Point(0, 30)
        Me.dgvEmployeeRecords.Name = "dgvEmployeeRecords"
        Me.dgvEmployeeRecords.RowTemplate.Height = 24
        Me.dgvEmployeeRecords.Size = New System.Drawing.Size(1011, 670)
        Me.dgvEmployeeRecords.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1011, 31)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DepartmentsToolStripMenuItem
        '
        Me.DepartmentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentOfAdministrativeManagementToolStripMenuItem, Me.DepartmentOfOperationsToolStripMenuItem, Me.DepartmentOfCustomerServiceSupportToolStripMenuItem, Me.DepartmentOfMaintenanceAndTechnicalToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.DepartmentsToolStripMenuItem.Font = New System.Drawing.Font("Roboto Cn", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem"
        Me.DepartmentsToolStripMenuItem.Size = New System.Drawing.Size(118, 27)
        Me.DepartmentsToolStripMenuItem.Text = "Departments"
        '
        'DepartmentOfAdministrativeManagementToolStripMenuItem
        '
        Me.DepartmentOfAdministrativeManagementToolStripMenuItem.Name = "DepartmentOfAdministrativeManagementToolStripMenuItem"
        Me.DepartmentOfAdministrativeManagementToolStripMenuItem.Size = New System.Drawing.Size(429, 28)
        Me.DepartmentOfAdministrativeManagementToolStripMenuItem.Text = "Department of Administrative and Management"
        '
        'DepartmentOfOperationsToolStripMenuItem
        '
        Me.DepartmentOfOperationsToolStripMenuItem.Name = "DepartmentOfOperationsToolStripMenuItem"
        Me.DepartmentOfOperationsToolStripMenuItem.Size = New System.Drawing.Size(429, 28)
        Me.DepartmentOfOperationsToolStripMenuItem.Text = "Department of Operations"
        '
        'DepartmentOfCustomerServiceSupportToolStripMenuItem
        '
        Me.DepartmentOfCustomerServiceSupportToolStripMenuItem.Name = "DepartmentOfCustomerServiceSupportToolStripMenuItem"
        Me.DepartmentOfCustomerServiceSupportToolStripMenuItem.Size = New System.Drawing.Size(429, 28)
        Me.DepartmentOfCustomerServiceSupportToolStripMenuItem.Text = "Department of Customer Service and Support"
        '
        'DepartmentOfMaintenanceAndTechnicalToolStripMenuItem
        '
        Me.DepartmentOfMaintenanceAndTechnicalToolStripMenuItem.Name = "DepartmentOfMaintenanceAndTechnicalToolStripMenuItem"
        Me.DepartmentOfMaintenanceAndTechnicalToolStripMenuItem.Size = New System.Drawing.Size(429, 28)
        Me.DepartmentOfMaintenanceAndTechnicalToolStripMenuItem.Text = "Department of Maintenance and Technical"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(429, 28)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'EmployeeRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 695)
        Me.Controls.Add(Me.dgvEmployeeRecords)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeRecords"
        CType(Me.dgvEmployeeRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmployeeRecords As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentOfAdministrativeManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentOfOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentOfCustomerServiceSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentOfMaintenanceAndTechnicalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
