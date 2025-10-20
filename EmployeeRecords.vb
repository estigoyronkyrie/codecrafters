Imports System.Data.SqlClient

Public Class EmployeeRecords
    Private Sub LoadEmployeeDetails()
        Try
            OpenConn()
            Dim sql As String = "SELECT * FROM EmployeeRecords"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvEmployeeRecords.DataSource = dt
            CloseConn()

            FormatDGV()

        Catch ex As Exception
            MessageBox.Show("Error Loading Employee Records: " & ex.Message)
        End Try
    End Sub
    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM EmployeeRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvEmployeeRecords.DataSource = data
                FormatDGV()

            End Using
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DepartmentOfAdministrativeManagementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentOfAdministrativeManagementToolStripMenuItem.Click
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM EmployeeRecords WHERE department='Department of Administrative & Management'"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dataset As New DataSet
                adapter.Fill(dataset)

                If dataset.Tables(0).Rows.Count > 0 Then
                    dgvEmployeeRecords.DataSource = dataset.Tables(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DepartmentOfOperationsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentOfOperationsToolStripMenuItem.Click
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM EmployeeRecords WHERE department='Department of Operations'"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dataset As New DataSet
                adapter.Fill(dataset)

                If dataset.Tables(0).Rows.Count > 0 Then
                    dgvEmployeeRecords.DataSource = dataset.Tables(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DepartmentOfCustomerServiceSupportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentOfCustomerServiceSupportToolStripMenuItem.Click
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM EmployeeRecords WHERE department='Department of Customer Service & Support'"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dataset As New DataSet
                adapter.Fill(dataset)

                If dataset.Tables(0).Rows.Count > 0 Then
                    dgvEmployeeRecords.DataSource = dataset.Tables(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DepartmentOfMaintenanceAndTechnicalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartmentOfMaintenanceAndTechnicalToolStripMenuItem.Click
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM EmployeeRecords WHERE department='Department of Maintenance & Technical'"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dataset As New DataSet
                adapter.Fill(dataset)

                If dataset.Tables(0).Rows.Count > 0 Then
                    dgvEmployeeRecords.DataSource = dataset.Tables(0)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        If TypeOf dgvEmployeeRecords.DataSource Is DataView Then
            Dim dv As DataView = CType(dgvEmployeeRecords.DataSource, DataView)
            dv.RowFilter = ""
        Else
            viewdata()
        End If
    End Sub

    Private Sub EmployeeRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadEmployeeDetails()
    End Sub
    Private Sub FormatDGV()
        dgvEmployeeRecords.Columns("EmployeeNumber").HeaderText = "Employee Number"
        dgvEmployeeRecords.Columns("Department").HeaderText = "Department"
        dgvEmployeeRecords.Columns("DateHired").HeaderText = "Date Hired"
        dgvEmployeeRecords.Columns("FirstName").HeaderText = "First Name"
        dgvEmployeeRecords.Columns("MiddleName").HeaderText = "Middle Name"
        dgvEmployeeRecords.Columns("LastName").HeaderText = "Last Name"
        dgvEmployeeRecords.Columns("Gender").HeaderText = "Gender"
        dgvEmployeeRecords.Columns("Month").HeaderText = "Month"
        dgvEmployeeRecords.Columns("Day").HeaderText = "Day"
        dgvEmployeeRecords.Columns("Year1").HeaderText = "Year"
        dgvEmployeeRecords.Columns("EmailAddress").HeaderText = "Email Address"
        dgvEmployeeRecords.Columns("ContactNumber").HeaderText = "Contact Number"
        dgvEmployeeRecords.Columns("HouseNo").HeaderText = "House No."
        dgvEmployeeRecords.Columns("Street").HeaderText = "Street"
        dgvEmployeeRecords.Columns("Subdivision").HeaderText = "Subdivision"
        dgvEmployeeRecords.Columns("Barangay").HeaderText = "Barangay"
        dgvEmployeeRecords.Columns("City").HeaderText = "City"
        dgvEmployeeRecords.Columns("ZipCode").HeaderText = "Zip Code"

        dgvEmployeeRecords.Columns("DateHired").DefaultCellStyle.Format = "MM/dd/yyyy"

        dgvEmployeeRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        For Each col As DataGridViewColumn In dgvEmployeeRecords.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
End Class