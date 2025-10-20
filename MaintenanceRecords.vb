Imports System.Data.SqlClient
Public Class MaintenanceRecords

    Private Sub LoadMaintenanceDetails()
        Try
            OpenConn()
            Dim sql As String = "SELECT * FROM MaintenanceRecords"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvMaintenanceRecords.DataSource = dt
            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error Loading Bus Records: " & ex.Message)
        End Try

        DateMaintenance.Format = DateTimePickerFormat.Custom
        DateMaintenance.CustomFormat = "MM/dd/yyyy"

        NextMaintenance.Format = DateTimePickerFormat.Custom
        NextMaintenance.CustomFormat = "MM/dd/yyyy"
    End Sub

    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM MaintenanceRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)

                dgvMaintenanceRecords.AutoGenerateColumns = True
                dgvMaintenanceRecords.DataSource = Nothing
                dgvMaintenanceRecords.DataSource = data
            End Using

            For Each col As DataGridViewColumn In dgvMaintenanceRecords.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MaintenanceRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadMaintenanceDetails()
        DateMaintenance.Format = DateTimePickerFormat.Custom
        DateMaintenance.CustomFormat = "MM/dd/yyyy
        NextMaintenance.Format = DateTimePickerFormat.Custom
        NextMaintenance.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub dgvMaintenanceRecords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvMaintenanceRecords.DataBindingComplete
        For Each col As DataGridViewColumn In dgvMaintenanceRecords.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        If dgvMaintenanceRecords.Columns.Contains("DateMaintenance") Then
            dgvMaintenanceRecords.Columns("DateMaintenance").DefaultCellStyle.Format = "MM/dd/yyyy"
        End If

        If dgvMaintenanceRecords.Columns.Contains("NextMaintenance") Then
            dgvMaintenanceRecords.Columns("NextMaintenance").DefaultCellStyle.Format = "MM/dd/yyyy"
        End If
    End Sub


    Private Function GenerateMaintenanceID() As String
        Dim prefix As String = "MTN"
        Dim fixedPart As String = "00"
        Dim yearPart As String = DateTime.Now.ToString("yyyy")

        Dim lastNumber As Integer = 0
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT TOP 1 MaintenanceID FROM MaintenanceRecords " &
                                  "WHERE MaintenanceID LIKE @Pattern ORDER BY MaintenanceID DESC"
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

    Private Sub ClearFields()
        txtMaintenanceID.Clear()
        txtBusNumber.Clear()
        DateMaintenance.Value = DateTime.Now
        txtMaintenanceType.Clear()
        txtPartsRepaired.Clear()
        txtServiceDescription.Clear()
        txtServiceProvider.Clear()
        NextMaintenance.Value = DateTime.Now
        txtRemarks.Clear()
    End Sub

    Private Sub btnSubmit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtBusNumber.Text) OrElse
        String.IsNullOrWhiteSpace(DateMaintenance.Text) OrElse
        String.IsNullOrWhiteSpace(txtMaintenanceType.Text) OrElse
        String.IsNullOrWhiteSpace(txtPartsRepaired.Text) OrElse
        String.IsNullOrWhiteSpace(txtServiceDescription.Text) OrElse
        String.IsNullOrWhiteSpace(txtServiceProvider.Text) OrElse
        String.IsNullOrWhiteSpace(NextMaintenance.Text) OrElse
        String.IsNullOrWhiteSpace(txtRemarks.Text) Then


            MsgBox("Please Fill in all Required Fields before Submit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim MaintenanceID As String = GenerateMaintenanceID()
        txtMaintenanceID.Text = MaintenanceID

        Dim query As String = "INSERT INTO MaintenanceRecords (MaintenanceID, BusNumber, DateMaintenance, MaintenanceType, PartsRepaired, ServiceDescription, ServiceProvider, NextMaintenance, Remarks) " &
                              "VALUES (@MaintenanceID, @BusNumber, @DateMaintenance, @MaintenanceType, @PartsRepaired, @ServiceDescription, @ServiceProvider, @NextMaintenance, @Remarks)"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaintenanceID", txtMaintenanceID.Text)
                    cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text)
                    cmd.Parameters.AddWithValue("@DateMaintenance", DateMaintenance.Value)
                    cmd.Parameters.AddWithValue("@MaintenanceType", txtMaintenanceType.Text)
                    cmd.Parameters.AddWithValue("@PartsRepaired", txtPartsRepaired.Text)
                    cmd.Parameters.AddWithValue("@ServiceDescription", txtServiceDescription.Text)
                    cmd.Parameters.AddWithValue("@ServiceProvider", txtServiceProvider.Text)
                    cmd.Parameters.AddWithValue("@NextMaintenance", NextMaintenance.Value)
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                    cmd.ExecuteNonQuery()
                End Using


                MsgBox("Maintenance Record Added Successfully!", MsgBoxStyle.Information)
                ClearFields()
                viewdata()

            Catch ex As Exception
                MsgBox("Error Adding Maintenance Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnEdit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtMaintenanceID.Text) Then
            MsgBox("Please Enter Maintenance ID to Edit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM MaintenanceRecords WHERE MaintenanceID=@MaintenanceID"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaintenanceID", txtMaintenanceID.Text)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtMaintenanceID.Text = reader("MaintenanceID").ToString()
                            txtBusNumber.Text = reader("BusNumber").ToString()

                            If Not IsDBNull(reader("DateMaintenance")) Then
                                DateMaintenance.Value = Convert.ToDateTime(reader("DateMaintenance"))
                            End If

                            txtMaintenanceType.Text = reader("MaintenanceType").ToString()
                            txtPartsRepaired.Text = reader("PartsRepaired").ToString()
                            txtServiceDescription.Text = reader("ServiceDescription").ToString()
                            txtServiceProvider.Text = reader("ServiceProvider").ToString()

                            If Not IsDBNull(reader("NextMaintenance")) Then
                                NextMaintenance.Value = Convert.ToDateTime(reader("NextMaintenance"))
                            End If

                            txtRemarks.Text = reader("Remarks").ToString()

                        Else
                            MsgBox("Maintenance Record Not Found!", MsgBoxStyle.Exclamation)
                            ClearFields()
                            viewdata()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Loading Maintenance Record! " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnClear_Click_1(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click_1(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtMaintenanceID.Text) OrElse
       String.IsNullOrWhiteSpace(txtBusNumber.Text) OrElse
       String.IsNullOrWhiteSpace(DateMaintenance.Text) OrElse
       String.IsNullOrWhiteSpace(txtMaintenanceType.Text) OrElse
       String.IsNullOrWhiteSpace(txtPartsRepaired.Text) OrElse
       String.IsNullOrWhiteSpace(txtServiceDescription.Text) OrElse
       String.IsNullOrWhiteSpace(txtServiceProvider.Text) OrElse
       String.IsNullOrWhiteSpace(NextMaintenance.Text) OrElse
       String.IsNullOrWhiteSpace(txtRemarks.Text) Then

            MsgBox("Please Fill in all Required Fields before Updating!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtMaintenanceID.Text) Then
            MsgBox("Please enter Maintenance ID to Update!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "UPDATE MaintenanceRecords SET " &
                              "MaintenanceID=@MaintenanceID," &
                              "BusNumber=@BusNumber, " &
                              "DateMaintenance=@DateMaintenance, " &
                              "MaintenanceType=@MaintenanceType, " &
                              "PartsRepaired=@PartsRepaired, " &
                              "ServiceDescription=@ServiceDescription, " &
                              "ServiceProvider=@ServiceProvider, " &
                              "NextMaintenance=@NextMaintenance, " &
                              "Remarks=@Remarks " &
                              "WHERE MaintenanceID=@MaintenanceID"


        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaintenanceID", txtMaintenanceID.Text)
                    cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text)
                    cmd.Parameters.AddWithValue("@DateMaintenance", DateMaintenance.Value)
                    cmd.Parameters.AddWithValue("@MaintenanceType", txtMaintenanceType.Text)
                    cmd.Parameters.AddWithValue("@PartsRepaired", txtPartsRepaired.Text)
                    cmd.Parameters.AddWithValue("@ServiceDescription", txtServiceDescription.Text)
                    cmd.Parameters.AddWithValue("@ServiceProvider", txtServiceProvider.Text)
                    cmd.Parameters.AddWithValue("@NextMaintenance", NextMaintenance.Value)
                    cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Maintenance Record Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFields()
                        viewdata()
                    Else
                        MsgBox("No Record found with that Maintenance ID.", MsgBoxStyle.Exclamation)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error Updating Maintenance Record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConn()
            End Try
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtMaintenanceID.Text) Then
            MsgBox("Please Enter Maintenance ID to Delete!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you Sure you want to Delete this Record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Using conn As New SqlConnection(connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM MaintenanceRecords WHERE MaintenanceID=@MaintenanceID"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@MaintenanceID", txtMaintenanceID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Maintenance Record Deleted Successfully.", MsgBoxStyle.Information)
                    ClearFields()
                    viewdata()

                Catch ex As Exception
                    MsgBox("Error Deleting Maintenance Record: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub
End Class