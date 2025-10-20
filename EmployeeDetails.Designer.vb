<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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
        Me.lblEmployeeNumber = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.radbtnMale = New System.Windows.Forms.RadioButton()
        Me.radbtnFemale = New System.Windows.Forms.RadioButton()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblHouseNo = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblSubdivision = New System.Windows.Forms.Label()
        Me.lblBarangay = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtEmployeeNumber = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.comboxMonth = New System.Windows.Forms.ComboBox()
        Me.comboxDay = New System.Windows.Forms.ComboBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtSubdivision = New System.Windows.Forms.TextBox()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.comboxDepartment = New System.Windows.Forms.ComboBox()
        Me.comboxYear = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblDateHired = New System.Windows.Forms.Label()
        Me.DateHired = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblEmployeeNumber
        '
        Me.lblEmployeeNumber.AutoSize = True
        Me.lblEmployeeNumber.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeNumber.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeNumber.Location = New System.Drawing.Point(29, 32)
        Me.lblEmployeeNumber.Name = "lblEmployeeNumber"
        Me.lblEmployeeNumber.Size = New System.Drawing.Size(158, 24)
        Me.lblEmployeeNumber.TabIndex = 0
        Me.lblEmployeeNumber.Text = "Employee Number:"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.White
        Me.lblDepartment.Location = New System.Drawing.Point(293, 32)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(107, 24)
        Me.lblDepartment.TabIndex = 1
        Me.lblDepartment.Text = "Department:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.White
        Me.lblFirstName.Location = New System.Drawing.Point(29, 124)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 24)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name:"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.White
        Me.lblMiddleName.Location = New System.Drawing.Point(362, 124)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(118, 24)
        Me.lblMiddleName.TabIndex = 3
        Me.lblMiddleName.Text = "Middle Name:"
        '
        'radbtnMale
        '
        Me.radbtnMale.AutoSize = True
        Me.radbtnMale.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnMale.ForeColor = System.Drawing.Color.White
        Me.radbtnMale.Location = New System.Drawing.Point(66, 249)
        Me.radbtnMale.Name = "radbtnMale"
        Me.radbtnMale.Size = New System.Drawing.Size(73, 25)
        Me.radbtnMale.TabIndex = 4
        Me.radbtnMale.TabStop = True
        Me.radbtnMale.Text = "Male"
        Me.radbtnMale.UseVisualStyleBackColor = True
        '
        'radbtnFemale
        '
        Me.radbtnFemale.AutoSize = True
        Me.radbtnFemale.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnFemale.ForeColor = System.Drawing.Color.White
        Me.radbtnFemale.Location = New System.Drawing.Point(145, 249)
        Me.radbtnFemale.Name = "radbtnFemale"
        Me.radbtnFemale.Size = New System.Drawing.Size(91, 25)
        Me.radbtnFemale.TabIndex = 5
        Me.radbtnFemale.TabStop = True
        Me.radbtnFemale.Text = "Female"
        Me.radbtnFemale.UseVisualStyleBackColor = True
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.White
        Me.lblLastName.Location = New System.Drawing.Point(701, 124)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(98, 24)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.White
        Me.lblGender.Location = New System.Drawing.Point(32, 225)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(71, 24)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender:"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfBirth.ForeColor = System.Drawing.Color.White
        Me.lblDateOfBirth.Location = New System.Drawing.Point(276, 223)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(113, 24)
        Me.lblDateOfBirth.TabIndex = 8
        Me.lblDateOfBirth.Text = "Date of Birth:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.White
        Me.lblMonth.Location = New System.Drawing.Point(395, 225)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(66, 24)
        Me.lblMonth.TabIndex = 9
        Me.lblMonth.Text = "Month:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(650, 225)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(45, 24)
        Me.lblDay.TabIndex = 10
        Me.lblDay.Text = "Day:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(807, 223)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(50, 24)
        Me.lblYear.TabIndex = 11
        Me.lblYear.Text = "Year:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(29, 412)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(79, 24)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address:"
        '
        'lblHouseNo
        '
        Me.lblHouseNo.AutoSize = True
        Me.lblHouseNo.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseNo.ForeColor = System.Drawing.Color.White
        Me.lblHouseNo.Location = New System.Drawing.Point(105, 441)
        Me.lblHouseNo.Name = "lblHouseNo"
        Me.lblHouseNo.Size = New System.Drawing.Size(131, 24)
        Me.lblHouseNo.TabIndex = 13
        Me.lblHouseNo.Text = "House/Unit No:"
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStreet.ForeColor = System.Drawing.Color.White
        Me.lblStreet.Location = New System.Drawing.Point(301, 441)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(62, 24)
        Me.lblStreet.TabIndex = 14
        Me.lblStreet.Text = "Street:"
        '
        'lblSubdivision
        '
        Me.lblSubdivision.AutoSize = True
        Me.lblSubdivision.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubdivision.ForeColor = System.Drawing.Color.White
        Me.lblSubdivision.Location = New System.Drawing.Point(633, 441)
        Me.lblSubdivision.Name = "lblSubdivision"
        Me.lblSubdivision.Size = New System.Drawing.Size(109, 24)
        Me.lblSubdivision.TabIndex = 15
        Me.lblSubdivision.Text = "Subdivision:"
        '
        'lblBarangay
        '
        Me.lblBarangay.AutoSize = True
        Me.lblBarangay.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarangay.ForeColor = System.Drawing.Color.White
        Me.lblBarangay.Location = New System.Drawing.Point(104, 510)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(88, 24)
        Me.lblBarangay.TabIndex = 16
        Me.lblBarangay.Text = "Barangay:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.Color.White
        Me.lblCity.Location = New System.Drawing.Point(406, 510)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(46, 24)
        Me.lblCity.TabIndex = 17
        Me.lblCity.Text = "City:"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZipCode.ForeColor = System.Drawing.Color.White
        Me.lblZipCode.Location = New System.Drawing.Point(701, 510)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(84, 24)
        Me.lblZipCode.TabIndex = 18
        Me.lblZipCode.Text = "Zip Code:"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.White
        Me.lblEmailAddress.Location = New System.Drawing.Point(32, 313)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(127, 24)
        Me.lblEmailAddress.TabIndex = 19
        Me.lblEmailAddress.Text = "Email Address:"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.ForeColor = System.Drawing.Color.White
        Me.lblContactNumber.Location = New System.Drawing.Point(442, 313)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(142, 24)
        Me.lblContactNumber.TabIndex = 20
        Me.lblContactNumber.Text = "Contact Number:"
        '
        'txtEmployeeNumber
        '
        Me.txtEmployeeNumber.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeNumber.Location = New System.Drawing.Point(33, 56)
        Me.txtEmployeeNumber.Name = "txtEmployeeNumber"
        Me.txtEmployeeNumber.Size = New System.Drawing.Size(224, 31)
        Me.txtEmployeeNumber.TabIndex = 21
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(33, 148)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(274, 31)
        Me.txtFirstName.TabIndex = 23
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(366, 148)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(274, 31)
        Me.txtMiddleName.TabIndex = 24
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(705, 148)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(274, 31)
        Me.txtLastName.TabIndex = 25
        '
        'comboxMonth
        '
        Me.comboxMonth.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxMonth.FormattingEnabled = True
        Me.comboxMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.comboxMonth.Location = New System.Drawing.Point(399, 249)
        Me.comboxMonth.Name = "comboxMonth"
        Me.comboxMonth.Size = New System.Drawing.Size(185, 29)
        Me.comboxMonth.TabIndex = 26
        '
        'comboxDay
        '
        Me.comboxDay.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxDay.FormattingEnabled = True
        Me.comboxDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.comboxDay.Location = New System.Drawing.Point(654, 249)
        Me.comboxDay.Name = "comboxDay"
        Me.comboxDay.Size = New System.Drawing.Size(90, 29)
        Me.comboxDay.TabIndex = 27
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.Location = New System.Drawing.Point(36, 337)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(342, 31)
        Me.txtEmailAddress.TabIndex = 29
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(446, 337)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(342, 31)
        Me.txtContactNumber.TabIndex = 30
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.Location = New System.Drawing.Point(109, 465)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(134, 31)
        Me.txtHouseNo.TabIndex = 31
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(305, 465)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(274, 31)
        Me.txtStreet.TabIndex = 32
        '
        'txtSubdivision
        '
        Me.txtSubdivision.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubdivision.Location = New System.Drawing.Point(637, 465)
        Me.txtSubdivision.Name = "txtSubdivision"
        Me.txtSubdivision.Size = New System.Drawing.Size(247, 31)
        Me.txtSubdivision.TabIndex = 33
        '
        'txtBarangay
        '
        Me.txtBarangay.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarangay.Location = New System.Drawing.Point(107, 534)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(247, 31)
        Me.txtBarangay.TabIndex = 34
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(410, 534)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(246, 31)
        Me.txtCity.TabIndex = 35
        '
        'txtZipCode
        '
        Me.txtZipCode.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(705, 534)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(216, 31)
        Me.txtZipCode.TabIndex = 36
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(207, 613)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(117, 40)
        Me.btnSubmit.TabIndex = 37
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'comboxDepartment
        '
        Me.comboxDepartment.DropDownWidth = 320
        Me.comboxDepartment.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxDepartment.FormattingEnabled = True
        Me.comboxDepartment.Items.AddRange(New Object() {"Department of Administrative & Management", "Department of Operations", "Department of Customer Service & Support", "Department of Maintenance & Technical"})
        Me.comboxDepartment.Location = New System.Drawing.Point(297, 56)
        Me.comboxDepartment.Name = "comboxDepartment"
        Me.comboxDepartment.Size = New System.Drawing.Size(339, 29)
        Me.comboxDepartment.TabIndex = 39
        '
        'comboxYear
        '
        Me.comboxYear.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxYear.ItemHeight = 21
        Me.comboxYear.Items.AddRange(New Object() {"2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900"})
        Me.comboxYear.Location = New System.Drawing.Point(811, 249)
        Me.comboxYear.Name = "comboxYear"
        Me.comboxYear.Size = New System.Drawing.Size(151, 29)
        Me.comboxYear.TabIndex = 40
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(455, 613)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 40)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(330, 613)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(117, 40)
        Me.btnEdit.TabIndex = 42
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(578, 613)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 40)
        Me.btnUpdate.TabIndex = 43
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Roboto Cn", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(701, 613)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(117, 40)
        Me.btnDelete.TabIndex = 44
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblDateHired
        '
        Me.lblDateHired.AutoSize = True
        Me.lblDateHired.Font = New System.Drawing.Font("Roboto Cn", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateHired.ForeColor = System.Drawing.Color.White
        Me.lblDateHired.Location = New System.Drawing.Point(669, 32)
        Me.lblDateHired.Name = "lblDateHired"
        Me.lblDateHired.Size = New System.Drawing.Size(97, 24)
        Me.lblDateHired.TabIndex = 45
        Me.lblDateHired.Text = "Date Hired:"
        '
        'DateHired
        '
        Me.DateHired.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateHired.Location = New System.Drawing.Point(673, 56)
        Me.DateHired.Name = "DateHired"
        Me.DateHired.Size = New System.Drawing.Size(307, 31)
        Me.DateHired.TabIndex = 46
        '
        'EmployeeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 695)
        Me.Controls.Add(Me.DateHired)
        Me.Controls.Add(Me.lblDateHired)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.comboxYear)
        Me.Controls.Add(Me.comboxDepartment)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtBarangay)
        Me.Controls.Add(Me.txtSubdivision)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtHouseNo)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.comboxDay)
        Me.Controls.Add(Me.comboxMonth)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtEmployeeNumber)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblEmailAddress)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblBarangay)
        Me.Controls.Add(Me.lblSubdivision)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblHouseNo)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.radbtnFemale)
        Me.Controls.Add(Me.radbtnMale)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblEmployeeNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeDetails"
        Me.Text = "EmployeeDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmployeeNumber As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents radbtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDateOfBirth As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblHouseNo As System.Windows.Forms.Label
    Friend WithEvents lblStreet As System.Windows.Forms.Label
    Friend WithEvents lblSubdivision As System.Windows.Forms.Label
    Friend WithEvents lblBarangay As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents comboxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents comboxDay As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtSubdivision As System.Windows.Forms.TextBox
    Friend WithEvents txtBarangay As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents comboxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents comboxYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblDateHired As System.Windows.Forms.Label
    Friend WithEvents DateHired As System.Windows.Forms.DateTimePicker
End Class
