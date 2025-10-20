Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing
Imports MessagingToolkit.QRCode.Codec
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions

Public Class UserBookingDetails

    Dim Barcode_Generator As New MessagingToolkit.Barcode.BarcodeEncoder()
    Dim arrImage() As Byte

    Private Function GenerateBookingNumber() As String
        Dim prefix As String = "BKG"
        Dim fixedPart As String = "00"
        Dim yearPart As String = DateTime.Now.ToString("yyyy")

        Dim lastNumber As Integer = 0

        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT TOP 1 BookingNumber FROM BookingRecords " &
                                  "WHERE BookingNumber LIKE @Pattern ORDER BY BookingNumber DESC"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Pattern", String.Format("{0}-{1}-{2}-%", prefix, fixedPart, yearPart))
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Dim parts() As String = result.ToString().Split("-"c)
                    If parts.Length = 4 Then
                        lastNumber = Convert.ToInt32(parts(3))
                    End If
                End If
            End Using
        End Using

        Dim newNumberStr As String = (lastNumber + 1).ToString("D3")
        Return String.Format("{0}-{1}-{2}-{3}", prefix, fixedPart, yearPart, newNumberStr)
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
              String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
              String.IsNullOrWhiteSpace(cmbMonth.Text) OrElse
              String.IsNullOrWhiteSpace(cmbDay.Text) OrElse
              String.IsNullOrWhiteSpace(cmbYear.Text) OrElse
              String.IsNullOrWhiteSpace(txtAge.Text) OrElse
              String.IsNullOrWhiteSpace(txtHouseNo.Text) OrElse
              String.IsNullOrWhiteSpace(txtCity.Text) OrElse
              String.IsNullOrWhiteSpace(txtZipCode.Text) OrElse
              String.IsNullOrWhiteSpace(txtEmailAddress.Text) OrElse
              String.IsNullOrWhiteSpace(txtContactNo.Text) OrElse
              String.IsNullOrWhiteSpace(txtEmergencyContactName.Text) OrElse
              String.IsNullOrWhiteSpace(txtEmergencyContactNo.Text) Then

            MsgBox("Please fill in all required fields!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtZipCode.Text.Length <> 4 Then
            MsgBox("ZIP Code must be exactly 4 digits.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim contact As String = txtContactNo.Text.Trim()
        If contact.Length <> 11 OrElse Not contact.StartsWith("09") OrElse Not IsNumeric(contact) Then
            MsgBox("Contact Number must be 11 digits and start with '09'.", MsgBoxStyle.Exclamation)
            txtContactNo.Focus()
            Exit Sub
        End If

        Dim emergencyContact As String = txtEmergencyContactNo.Text.Trim()
        If emergencyContact.Length <> 11 OrElse Not emergencyContact.StartsWith("09") OrElse Not IsNumeric(emergencyContact) Then
            MsgBox("Emergency Contact Number must be 11 digits and start with '09'.", MsgBoxStyle.Exclamation)
            txtEmergencyContactNo.Focus()
            Exit Sub
        End If

        Dim email As String = txtEmailAddress.Text.Trim().ToLower()
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@(gmail|yahoo)\.com$"

        If Not Regex.IsMatch(email, pattern) Then
            MsgBox("Please enter a valid email ending with '@gmail.com' or '@yahoo.com'.", MsgBoxStyle.Exclamation)
            txtEmailAddress.Focus()
            Exit Sub
        End If

        Dim bookingNo As String = GenerateBookingNumber()
        txtBookingNumber.Text = bookingNo
        Dim qrText As String = "Booking Number: " & bookingNo
        Dim qrBytes As Byte() = GenerateQRCode(qrText)
        If qrBytes Is Nothing Then Exit Sub

        Using ms As New MemoryStream(qrBytes)
            PicBoxQRCode.Image = Image.FromStream(ms)
        End Using

        Dim query As String = "INSERT INTO BookingRecords " &
                              "(BookingNumber, qr, FirstName, MiddleName, LastName, Month, Day, Year, Age, Gender, " &
                              "HouseNo, Street, Subdivision, Barangay, City, ZipCode, EmailAddress, " &
                              "ContactNo, EmergencyContactName, EmergencyContactNo) " &
                              "VALUES (@BookingNumber, @QR, @FirstName, @MiddleName, @LastName, @Month, @Day, @Year, @Age, @Gender, " &
                              "@HouseNo, @Street, @Subdivision, @Barangay, @City, @ZipCode, @EmailAddress, " &
                              "@ContactNo, @EmergencyContactName, @EmergencyContactNo)"


        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BookingNumber", bookingNo)
                    cmd.Parameters.Add("@QR", SqlDbType.VarBinary).Value = qrBytes
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@Month", cmbMonth.Text)
                    cmd.Parameters.AddWithValue("@Day", cmbDay.Text)
                    cmd.Parameters.AddWithValue("@Year", cmbYear.Text)
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text)
                    cmd.Parameters.AddWithValue("@HouseNo", txtHouseNo.Text)
                    cmd.Parameters.AddWithValue("@Street", txtStreet.Text)
                    cmd.Parameters.AddWithValue("@Subdivision", txtSubdivision.Text)
                    cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text)
                    cmd.Parameters.AddWithValue("@City", txtCity.Text)
                    cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text)
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text)
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text)
                    cmd.Parameters.AddWithValue("@EmergencyContactName", txtEmergencyContactName.Text)
                    cmd.Parameters.AddWithValue("@EmergencyContactNo", txtEmergencyContactNo.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Booking Added Successfully!", MsgBoxStyle.Information)

                Dim schedForm As New UserScheduleAndSeat()
                schedForm.PassedBookingNumber = bookingNo
                schedForm.Show()
                Me.Hide()

            Catch ex As Exception
                MsgBox("Error Saving Booking: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        txtBookingNumber.Clear()
        PicBoxQRCode.Image = Nothing
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        cmbMonth.SelectedIndex = -1
        cmbDay.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        txtAge.Clear()
        cmbGender.SelectedIndex = -1
        txtHouseNo.Clear()
        txtStreet.Clear()
        txtSubdivision.Clear()
        txtBarangay.Clear()
        txtCity.Clear()
        txtZipCode.Clear()
        txtEmailAddress.Clear()
        txtContactNo.Clear()
        txtEmergencyContactName.Clear()
        txtEmergencyContactNo.Clear()
    End Sub

    Public Shared Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM BookingRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
            End Using
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs)
        UserScheduleAndSeat.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim hasData As Boolean = Not String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(cmbMonth.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(cmbDay.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(cmbYear.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtAge.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtHouseNo.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtCity.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtZipCode.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtEmailAddress.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtContactNo.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtEmergencyContactName.Text) OrElse
                                 Not String.IsNullOrWhiteSpace(txtEmergencyContactNo.Text)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?",
                                                     "Cancel Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If hasData Then
                Dim deleteData As DialogResult = MessageBox.Show("You have unsaved data. Do you want to delete it?",
                                                                 "Delete Data",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning)
                If deleteData = DialogResult.Yes Then
                    txtFirstName.Clear()
                    txtLastName.Clear()
                    cmbMonth.SelectedIndex = -1
                    cmbDay.SelectedIndex = -1
                    cmbYear.SelectedIndex = -1
                    txtAge.Clear()
                    txtHouseNo.Clear()
                    txtCity.Clear()
                    txtZipCode.Clear()
                    txtEmailAddress.Clear()
                    txtContactNo.Clear()
                    txtEmergencyContactName.Clear()
                    txtEmergencyContactNo.Clear()
                End If
            End If

            LoginHistoryModule.UpdateLogoutTime(Utilities.CurrentUser)
            Me.Hide()
            LoginForm.txtUsername.Clear()
            LoginForm.txtPassword.Clear()
            LoginForm.Show()
        End If
    End Sub

    Private Sub PicBoxBarCode_Click(sender As System.Object, e As System.EventArgs) Handles PicBoxQRCode.Click
        If Not String.IsNullOrWhiteSpace(PicBoxQRCode.Text) Then
            txtBookingNumber.Text = PicBoxQRCode.Text
        End If
    End Sub

    Private Sub UserBookingDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SetTextBoxesTitleCase()
        cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDay.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        txtBookingNumber.ReadOnly = True

        Dim controlsToSet As Control() = {
            PicBoxQRCode, PictureBox2, Label2,
            lblFirstName, lblMiddleName, lblLastName,
            lblDateOfBirth, lblMonth, lblDay, Label1,
            lblGender, lblEmailAddress, lblContactNo,
            lblAge, lblHouseNo, lblStreet, lblSubdivision,
            lblBarangay, lblCity, lblZipCode, lblEmergencyContactName,
            lblEmergencyContactNo, lblBookingNumber,
            btnSubmit, btnCancel
        }

        For Each ctrl As Control In controlsToSet
            ctrl.Parent = PictureBox3
            ctrl.BackColor = Color.Transparent
        Next

        cmbMonth.Items.AddRange(New String() {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        })

        For y As Integer = DateTime.Now.Year To 1900 Step -1
            cmbYear.Items.Add(y.ToString())
        Next
    End Sub

    Private Sub txtZipCode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtZipCode.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If

        If Char.IsDigit(e.KeyChar) AndAlso txtZipCode.Text.Length >= 4 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContactNo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsDigit(e.KeyChar) AndAlso txtContactNo.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmergencyContactNo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmergencyContactNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsDigit(e.KeyChar) AndAlso txtEmergencyContactNo.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmailAddress_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailAddress.KeyPress
        If e.KeyChar = " "c Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub SetTextBoxesTitleCase()
        Dim textboxes As TextBox() = {txtFirstName, txtMiddleName, txtLastName,
                                      txtHouseNo, txtStreet, txtSubdivision,
                                      txtBarangay, txtCity, txtEmergencyContactName}

        For Each tb As TextBox In textboxes
            AddHandler tb.TextChanged, AddressOf TextBoxToTitleCase
        Next
    End Sub

    Private Sub TextBoxToTitleCase(sender As Object, e As EventArgs)
        Dim tb As TextBox = CType(sender, TextBox)
        Dim selStart As Integer = tb.SelectionStart
        Dim words As String() = tb.Text.Split(" "c)
        For i As Integer = 0 To words.Length - 1
            If words(i).Length > 0 Then
                words(i) = Char.ToUpper(words(i)(0)) & words(i).Substring(1).ToLower()
            End If
        Next
        tb.Text = String.Join(" ", words)
        tb.SelectionStart = selStart
    End Sub


    Private Function ValidateDateOfBirth() As Boolean
        If cmbYear.SelectedIndex = -1 OrElse cmbMonth.SelectedIndex = -1 OrElse cmbDay.SelectedIndex = -1 Then
            MsgBox("Please select a valid Date of Birth (Month, Day, and Year).", MsgBoxStyle.Exclamation)
            Return False
        End If

        Dim year As Integer = Integer.Parse(cmbYear.Text)
        Dim month As Integer = cmbMonth.SelectedIndex + 1
        Dim day As Integer = Integer.Parse(cmbYear.Text)

        Dim dob As Date
        Try
            dob = New Date(year, month, day)
        Catch ex As Exception
            MsgBox("Invalid Date of Birth selected. Please check the day and month.", MsgBoxStyle.Exclamation)
            Return False
        End Try

        If dob > DateTime.Now.Date Then
            MsgBox("Date of Birth cannot be a future date.", MsgBoxStyle.Exclamation)
            Return False
        End If

        Dim age As Integer = DateDiff(DateInterval.Year, dob, DateTime.Now)
        If dob.AddYears(age) > DateTime.Now Then age -= 1

        If age < 18 Then
            MsgBox("Employee must be at least 18 years old.", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Sub UpdateDays()
        Dim year As Integer
        If cmbYear.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cmbYear.Text) Then
            year = DateTime.Now.Year
        Else
            year = Integer.Parse(cmbYear.Text)
        End If

        If cmbMonth.SelectedIndex = -1 Then
            cmbDay.Items.Clear()
            cmbDay.Text = ""
            Return
        End If

        Dim month As Integer = cmbMonth.SelectedIndex + 1
        Dim daysInMonth As Integer

        If month = 2 AndAlso (cmbYear.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cmbYear.Text)) Then
            daysInMonth = 28
        Else
            daysInMonth = DateTime.DaysInMonth(year, month)
        End If

        Dim currentDay As String = cmbDay.Text

        cmbDay.Items.Clear()
        For d As Integer = 1 To daysInMonth
            cmbDay.Items.Add(d.ToString("00"))
        Next

        If Not String.IsNullOrWhiteSpace(currentDay) AndAlso cmbDay.Items.Contains(currentDay) Then
            cmbDay.Text = currentDay
        Else
            cmbDay.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        UpdateDays()
        CalculateAge()
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDay.SelectedIndexChanged
        CalculateAge()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        UpdateDays()
        CalculateAge()
    End Sub

    Private Function IsValidDOB() As Boolean
        If cmbYear.SelectedIndex = -1 OrElse cmbMonth.SelectedIndex = -1 OrElse cmbDay.SelectedIndex = -1 Then
            MsgBox("Please complete the Date selection (Day, Month, Year).", MsgBoxStyle.Exclamation)
            Return False
        End If

        Dim dob As New DateTime(Integer.Parse(cmbYear.Text), cmbMonth.SelectedIndex + 1, Integer.Parse(cmbDay.Text))

        If dob > DateTime.Now.Date Then
            MsgBox("Date of Birth cannot be a future date!", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function

    Private Sub CalculateAge()
        If cmbYear.SelectedIndex = -1 OrElse cmbMonth.SelectedIndex = -1 OrElse cmbDay.SelectedIndex = -1 Then
            txtAge.Clear()
            Exit Sub
        End If

        Try
            Dim year As Integer = Integer.Parse(cmbYear.Text)
            Dim month As Integer = cmbMonth.SelectedIndex + 1
            Dim day As Integer = Integer.Parse(cmbDay.Text)
            Dim dob As New DateTime(year, month, day)

            If dob > DateTime.Now.Date Then
                txtAge.Clear()
                Exit Sub
            End If

            Dim age As Integer = DateDiff(DateInterval.Year, dob, DateTime.Now)
            If dob.AddYears(age) > DateTime.Now Then
                age -= 1
            End If

            txtAge.Text = age.ToString()
        Catch ex As Exception
            txtAge.Clear()
        End Try
    End Sub


    Private Sub txtBookingNumber_Enter(sender As System.Object, e As System.EventArgs) Handles txtBookingNumber.Enter
        Me.ActiveControl = Nothing
    End Sub

    Private Function GenerateQRCode(text As String) As Byte()
        Try
            Dim qrEncoder As New QRCodeEncoder()
            Dim qrBitmap As Bitmap = qrEncoder.Encode(text)
            Using ms As New MemoryStream()
                qrBitmap.Save(ms, Imaging.ImageFormat.Png)
                Return ms.ToArray()
            End Using
        Catch ex As Exception
            MsgBox("Error generating QR: " & ex.Message, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function

    Public Function ScanQR(qrImage As Image) As String
        Try
            Dim qrDecoder As New QRCodeDecoder()
            Dim bmp As New Bitmap(qrImage)
            Dim qrText As String = qrDecoder.decode(New MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(bmp))
            Return qrText
        Catch ex As Exception
            MsgBox("Error scanning QR: " & ex.Message)
            Return ""
        End Try
    End Function
End Class
