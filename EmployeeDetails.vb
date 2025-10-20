Imports System.Data.SqlClient
Public Class EmployeeDetails
    Private isUpdating As Boolean = False
    Private isEditMode As Boolean = False
Private Function GenerateEmployeeNumber() As String
        Dim prefix As String = "EMP"
        Dim fixedPart As String = "00"
        Dim yearPart As String = DateTime.Now.ToString("yyyy")

        Dim lastNumber As Integer = 0
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT TOP 1 EmployeeNumber FROM EmployeeRecords " &
                                  "WHERE EmployeeNumber LIKE @Pattern ORDER BY EmployeeNumber DESC"
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


    Public Shared Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM EmployeeRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
            End Using
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ClearFields()
        txtEmployeeNumber.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtEmailAddress.Clear()
        txtContactNumber.Clear()
        txtHouseNo.Clear()
        txtStreet.Clear()
        txtSubdivision.Clear()
        txtBarangay.Clear()
        txtCity.Clear()
        txtZipCode.Clear()
        comboxDepartment.SelectedIndex = -1
        comboxMonth.SelectedIndex = -1
        comboxDay.SelectedIndex = -1
        comboxYear.SelectedIndex = -1
        radbtnMale.Checked = False
        radbtnFemale.Checked = False
        DateHired.Value = DateTime.Now
    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub


    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
               String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
               String.IsNullOrWhiteSpace(txtEmailAddress.Text) OrElse
               String.IsNullOrWhiteSpace(txtContactNumber.Text) OrElse
               String.IsNullOrWhiteSpace(txtHouseNo.Text) OrElse
               String.IsNullOrWhiteSpace(txtStreet.Text) OrElse
               String.IsNullOrWhiteSpace(txtBarangay.Text) OrElse
               String.IsNullOrWhiteSpace(txtCity.Text) OrElse
               comboxDepartment.SelectedIndex = -1 OrElse
               comboxMonth.SelectedIndex = -1 OrElse
               comboxDay.SelectedIndex = -1 OrElse
               comboxYear.SelectedIndex = -1 OrElse
               (Not radbtnMale.Checked AndAlso Not radbtnFemale.Checked) Then

            MsgBox("Please Fill in all Required Fields before Updating!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If DateHired.Value.Date > DateTime.Now.Date Then
            MsgBox("Date Hired cannot be a future date!", MsgBoxStyle.Exclamation)
            DateHired.Focus()
            Exit Sub
        End If

        If txtZipCode.Text.Length <> 4 Then
            MsgBox("ZIP Code must be exactly 4 digits.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim email As String = txtEmailAddress.Text.Trim().ToLower()
        If Not (email.EndsWith("@gmail.com") OrElse email.EndsWith("@yahoo.com")) Then
            MsgBox("Email must end with @gmail.com or @yahoo.com", MsgBoxStyle.Exclamation)
            txtEmailAddress.Focus()
            Exit Sub
        End If

        Dim contact As String = txtContactNumber.Text.Trim()
        If contact.Length <> 11 OrElse Not contact.StartsWith("09") OrElse Not IsNumeric(contact) Then
            MsgBox("Contact Number must be 11 digits and start with '09'", MsgBoxStyle.Exclamation)
            txtContactNumber.Focus()
            Exit Sub
        End If

        Dim EmployeeNumber As String = GenerateEmployeeNumber()
        txtEmployeeNumber.Text = EmployeeNumber

        Dim gender As String = If(radbtnMale.Checked, "Male", "Female")
        Dim query As String = "INSERT INTO EmployeeRecords " &
                              "(EmployeeNumber, Department, DateHired, FirstName, MiddleName, LastName, Gender, Month, Day, Year1, EmailAddress, ContactNumber, HouseNo, Street, Subdivision, Barangay, City, ZipCode) " &
                              "VALUES (@EmployeeNumber, @Department, @DateHired, @FirstName, @MiddleName, @LastName, @Gender, @Month, @Day, @Year1, @EmailAddress, @ContactNumber, @HouseNo, @Street, @Subdivision, @Barangay, @City, @ZipCode)"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeNumber", txtEmployeeNumber.Text)
                    cmd.Parameters.AddWithValue("@Department", comboxDepartment.Text)
                    cmd.Parameters.AddWithValue("@DateHired", DateHired.Value.Date)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@Gender", gender)
                    cmd.Parameters.AddWithValue("@Month", comboxMonth.Text)

                    If String.IsNullOrWhiteSpace(comboxDay.Text) Then
                        MsgBox("Invalid Day value!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    cmd.Parameters.AddWithValue("@Day", Integer.Parse(comboxDay.Text))
                    cmd.Parameters.AddWithValue("@Year1", Integer.Parse(comboxYear.Text))

                    If String.IsNullOrWhiteSpace(comboxYear.Text) Then
                        MsgBox("Invalid Year value!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                    cmd.Parameters.AddWithValue("@HouseNo", txtHouseNo.Text)
                    cmd.Parameters.AddWithValue("@Street", txtStreet.Text)
                    cmd.Parameters.AddWithValue("@Subdivision", txtSubdivision.Text)
                    cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text)
                    cmd.Parameters.AddWithValue("@City", txtCity.Text)
                    cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Employee Record Added Successfully!", MsgBoxStyle.Information)
                ClearFields()
                EmployeeRecords.viewdata()

            Catch ex As Exception
                MsgBox("Error Adding Employee Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub


    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtEmployeeNumber.Text) Then
            MsgBox("Please Enter Employee Number to Edit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM EmployeeRecords WHERE EmployeeNumber=@EmployeeNumber"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeNumber", txtEmployeeNumber.Text)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            comboxDepartment.Text = reader("Department").ToString()
                            txtFirstName.Text = reader("FirstName").ToString()
                            txtMiddleName.Text = reader("MiddleName").ToString()
                            txtLastName.Text = reader("LastName").ToString()

                            If Not IsDBNull(reader("DateHired")) Then
                                DateHired.Value = Convert.ToDateTime(reader("DateHired"))
                            End If

                            Dim gender As String = reader("Gender").ToString()
                            If gender = "Male" Then
                                radbtnMale.Checked = True
                            ElseIf gender = "Female" Then
                                radbtnFemale.Checked = True
                            End If

                            comboxMonth.Text = reader("Month").ToString()
                            comboxDay.Text = reader("Day").ToString()
                            comboxYear.Text = reader("Year1").ToString()

                            txtEmailAddress.Text = reader("EmailAddress").ToString()
                            txtContactNumber.Text = reader("ContactNumber").ToString()

                            txtHouseNo.Text = reader("HouseNo").ToString()
                            txtStreet.Text = reader("Street").ToString()
                            txtSubdivision.Text = reader("Subdivision").ToString()
                            txtBarangay.Text = reader("Barangay").ToString()
                            txtCity.Text = reader("City").ToString()
                            txtZipCode.Text = reader("ZipCode").ToString()
                        Else
                            MsgBox("Employee Record Not Found!", MsgBoxStyle.Exclamation)
                            ClearFields()
                            EmployeeRecords.viewdata()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Loading Employee Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmailAddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtContactNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtHouseNo.Text) OrElse
           String.IsNullOrWhiteSpace(txtStreet.Text) OrElse
           String.IsNullOrWhiteSpace(txtBarangay.Text) OrElse
           String.IsNullOrWhiteSpace(txtCity.Text) OrElse
           comboxDepartment.SelectedIndex = -1 OrElse
           comboxMonth.SelectedIndex = -1 OrElse
           comboxDay.SelectedIndex = -1 OrElse
           comboxYear.SelectedIndex = -1 OrElse
           (Not radbtnMale.Checked AndAlso Not radbtnFemale.Checked) Then

            MsgBox("Please Fill in all Required Fields before Updating!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtEmployeeNumber.Text) Then
            MsgBox("Please Enter Employee Number to Update", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If DateHired.Value.Date > DateTime.Now.Date Then
            MsgBox("Date Hired cannot be a future date", MsgBoxStyle.Exclamation)
            DateHired.Focus()
            Exit Sub
        End If

        Dim email As String = txtEmailAddress.Text.Trim().ToLower()
        If Not (email.EndsWith("@gmail.com") OrElse email.EndsWith("@yahoo.com")) Then
            MsgBox("Email must end with @gmail.com or @yahoo.com", MsgBoxStyle.Exclamation)
            txtEmailAddress.Focus()
            Exit Sub
        End If

        Dim contact As String = txtContactNumber.Text.Trim()
        If contact.Length <> 11 OrElse Not contact.StartsWith("09") OrElse Not IsNumeric(contact) Then
            MsgBox("Contact Number must be 11 digits and start with '09'!", MsgBoxStyle.Exclamation)
            txtContactNumber.Focus()
            Exit Sub
        End If

        If txtZipCode.Text.Length <> 4 Then
            MsgBox("ZIP Code must be exactly 4 digits.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim gender As String = If(radbtnMale.Checked, "Male", "Female")
        Dim query As String = "UPDATE EmployeeRecords SET " &
                              "Department=@Department, DateHired=@DateHired, FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, " &
                              "Gender=@Gender, Month=@Month, Day=@Day, Year1=@Year1, EmailAddress=@EmailAddress, " &
                              "ContactNumber=@ContactNumber, HouseNo=@HouseNo, Street=@Street, Subdivision=@Subdivision, " &
                              "Barangay=@Barangay, City=@City, ZipCode=@ZipCode " &
                              "WHERE EmployeeNumber=@EmployeeNumber"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@EmployeeNumber", txtEmployeeNumber.Text)
                    cmd.Parameters.AddWithValue("@Department", comboxDepartment.Text)
                    cmd.Parameters.AddWithValue("@DateHired", DateHired.Value.Date)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@Gender", gender)

                    cmd.Parameters.AddWithValue("@Month", comboxMonth.Text)

                    If String.IsNullOrWhiteSpace(comboxDay.Text) Then
                        MsgBox("Invalid Day value!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    cmd.Parameters.AddWithValue("@Day", comboxDay.Text)

                    If String.IsNullOrWhiteSpace(comboxYear.Text) Then
                        MsgBox("Invalid Year value!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                    cmd.Parameters.AddWithValue("@Year1", comboxYear.Text)

                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text)
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
                    cmd.Parameters.AddWithValue("@HouseNo", txtHouseNo.Text)
                    cmd.Parameters.AddWithValue("@Street", txtStreet.Text)
                    cmd.Parameters.AddWithValue("@Subdivision", txtSubdivision.Text)
                    cmd.Parameters.AddWithValue("@Barangay", txtBarangay.Text)
                    cmd.Parameters.AddWithValue("@City", txtCity.Text)
                    cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text)
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeNumber.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Employee Rocord Updated Successfully!", MsgBoxStyle.Information)
                        ClearFields()
                        EmployeeRecords.viewdata()
                    Else
                        MsgBox("No Record Found with that Employee Number!", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error Updating Employee Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtEmployeeNumber.Text) Then
            MsgBox("Please Enter Employee Number to Delete!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you Sure you want to Delete this Record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Using conn As New SqlConnection(connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM EmployeeRecords WHERE EmployeeNumber = @EmployeeNumber"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@EmployeeNumber", txtEmployeeNumber.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Employee Record Deleted Successfully!", MsgBoxStyle.Information)
                    ClearFields()
                    EmployeeRecords.viewdata()

                Catch ex As Exception
                    MsgBox("Error Deleting Employee Record!" & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub

    Private Sub EmployeeDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SetTextBoxesTitleCase()

        DateHired.Format = DateTimePickerFormat.Custom
        DateHired.CustomFormat = "MM/dd/yyyy"

        comboxDepartment.DropDownStyle = ComboBoxStyle.DropDown
        comboxDepartment.AutoCompleteMode = AutoCompleteMode.None
        comboxDepartment.AutoCompleteSource = AutoCompleteSource.None

        comboxDepartment.Items.AddRange(originalDepartments.ToArray())
    End Sub

    Private Sub SetTextBoxesTitleCase()
        Dim textboxes As TextBox() = {txtFirstName, txtMiddleName, txtLastName,
                                      txtHouseNo, txtStreet, txtSubdivision,
                                      txtBarangay, txtCity, txtZipCode}

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

    Private originalDepartments As New List(Of String) From {
    "Department of Administrative & Management",
    "Department of Operations",
    "Department of Customer Service & Support",
    "Department of Maintenance & Technical"
}

    Private Sub comboxDepartment_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles comboxDepartment.KeyDown
        If e.KeyCode = Keys.Enter AndAlso comboxDepartment.SelectedIndex >= 0 Then
            comboxDepartment.Text = comboxDepartment.SelectedItem.ToString()
            comboxDepartment.DroppedDown = False
            e.Handled = True
        End If
    End Sub

    Private Sub comboxDepartment_TextUpdate(sender As System.Object, e As System.EventArgs) Handles comboxDepartment.TextUpdate
        If isUpdating Then Return

        Dim text As String = comboxDepartment.Text
        Dim cursorPos As Integer = comboxDepartment.SelectionStart

        Dim filtered = originalDepartments.Where(Function(d) d.ToLower().Contains(text.ToLower())).ToArray()

        If filtered.Length = 0 Then
            comboxDepartment.DroppedDown = False
            Return
        End If

        isUpdating = True
        comboxDepartment.BeginUpdate()
        comboxDepartment.Items.Clear()
        comboxDepartment.Items.AddRange(filtered)
        comboxDepartment.EndUpdate()
        isUpdating = False

        comboxDepartment.Text = text
        comboxDepartment.SelectionStart = cursorPos
        comboxDepartment.SelectionLength = 0

        Dim visibleCount As Integer = Math.Min(filtered.Length, 5)
        comboxDepartment.DropDownHeight = comboxDepartment.ItemHeight * visibleCount + 2

        comboxDepartment.DroppedDown = False
        comboxDepartment.DroppedDown = True
    End Sub

    Private Sub UpdateDaysCombo()
        Dim year As Integer
        If comboxYear.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(comboxYear.Text) Then
            year = DateTime.Now.Year
        Else
            year = Integer.Parse(comboxYear.Text)
        End If

        If comboxMonth.SelectedIndex = -1 Then
            comboxDay.Items.Clear()
            comboxDay.Text = ""
            Return
        End If

        Dim month As Integer = comboxMonth.SelectedIndex + 1
        Dim daysInMonth As Integer

        If month = 2 AndAlso (comboxYear.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(comboxYear.Text)) Then
            daysInMonth = 28
        Else
            daysInMonth = DateTime.DaysInMonth(year, month)
        End If

        Dim currentDay As String = comboxDay.Text

        comboxDay.Items.Clear()
        For d As Integer = 1 To daysInMonth
            comboxDay.Items.Add(d.ToString())
        Next
        If Not String.IsNullOrWhiteSpace(currentDay) AndAlso comboxDay.Items.Contains(currentDay) Then
            comboxDay.Text = currentDay
        Else
            comboxDay.Text = ""
        End If
    End Sub

    Private Sub comboxMonth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboxMonth.SelectedIndexChanged
        UpdateDaysCombo()
    End Sub

    Private Sub comboxYear_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboxYear.SelectedIndexChanged
        If comboxMonth.SelectedIndex = -1 Then Return

        Dim year As Integer = Integer.Parse(comboxYear.Text)
        Dim month As Integer = comboxMonth.SelectedIndex + 1
        Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month)
        Dim currentDay As String = comboxDay.Text

        comboxDay.Items.Clear()
        For d As Integer = 1 To daysInMonth
            comboxDay.Items.Add(d.ToString())
        Next

        If Not String.IsNullOrWhiteSpace(currentDay) AndAlso comboxDay.Items.Contains(currentDay) Then
            comboxDay.Text = currentDay
        Else
            comboxDay.Text = ""
        End If
    End Sub

    Private Function IsValidDOB() As Boolean
        If comboxYear.SelectedIndex = -1 OrElse comboxMonth.SelectedIndex = -1 OrElse comboxDay.SelectedIndex = -1 Then
            Return False
        End If

        Dim dob As New DateTime(Integer.Parse(comboxYear.Text), comboxMonth.SelectedIndex + 1, Integer.Parse(comboxDay.Text))
        If dob > DateTime.Now.Date Then
            MsgBox("Date of Birth cannot be a future date!", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub DateHired_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateHired.ValueChanged
        If DateHired.Value.Date > DateTime.Now.Date Then
            MsgBox("Date Hired cannot be a future date!", MsgBoxStyle.Exclamation)
            DateHired.Value = DateTime.Now.Date
        End If
    End Sub

    Private Sub txtContactNumber_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MsgBox("Only numbers are allowed!", MsgBoxStyle.Exclamation)
            Return
        End If

        If Char.IsDigit(e.KeyChar) AndAlso txtContactNumber.Text.Length >= 11 Then
            e.Handled = True
            MsgBox("Contact Number cannot exceed 11 digits!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtEmailAddress_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailAddress.KeyPress
        If e.KeyChar = " "c Then
            e.Handled = True
            Exit Sub
        End If
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
End Class