Imports System.Data.SqlClient

Public Class BusesRecords
    Private Function GenerateBusNumber() As String
        Dim prefix As String = "BUS"
        Dim fixedPart As String = "00"
        Dim yearPart As String = DateTime.Now.ToString("yyyy")

        Dim lastNumber As Integer = 0
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT TOP 1 BusNumber FROM BusRecords " &
                                  "WHERE BusNumber LIKE @Pattern ORDER BY BusNumber DESC"
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

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtPlateNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtBusModel.Text) OrElse
           String.IsNullOrWhiteSpace(txtYearModel.Text) OrElse
           String.IsNullOrWhiteSpace(txtSeatingCapacity.Text) OrElse
           String.IsNullOrWhiteSpace(txtColorDesign.Text) OrElse
           String.IsNullOrWhiteSpace(txtDriverAssigned.Text) OrElse
           String.IsNullOrWhiteSpace(txtRemarks.Text) OrElse
           comboxType.SelectedIndex = -1 OrElse
           comboxStatus.SelectedIndex = -1 OrElse
           comboxFuelType.SelectedIndex = -1 Then

            MsgBox("Please Fill in all Required Fields before Submit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim BusNumber As String = GenerateBusNumber()
        txtBusNumber.Text = BusNumber

        Dim query As String = "INSERT INTO BusRecords " &
                              "(BusNumber, PlateNumber, BusModel, YearModel, SeatingCapacity, Type, Status, FuelType, ColorDesign, DriverAssigned, RemarksNotes) " &
                              "VALUES (@BusNumber, @PlateNumber, @BusModel, @YearModel, @SeatingCapacity, @Type, @Status, @FuelType, @ColorDesign, @DriverAssigned, @RemarksNotes)"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text)
                    cmd.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text)
                    cmd.Parameters.AddWithValue("@BusModel", txtBusModel.Text)
                    cmd.Parameters.AddWithValue("@YearModel", txtYearModel.Text)
                    cmd.Parameters.AddWithValue("@SeatingCapacity", txtSeatingCapacity.Text)
                    cmd.Parameters.AddWithValue("@Type", comboxType.Text)
                    cmd.Parameters.AddWithValue("@Status", comboxStatus.Text)
                    cmd.Parameters.AddWithValue("@FuelType", comboxFuelType.Text)
                    cmd.Parameters.AddWithValue("@ColorDesign", txtColorDesign.Text)
                    cmd.Parameters.AddWithValue("@DriverAssigned", txtDriverAssigned.Text)
                    cmd.Parameters.AddWithValue("@RemarksNotes", txtRemarks.Text)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Bus Record Added Successfully!", MsgBoxStyle.Information)
                ClearFields()
                viewdata()

            Catch ex As Exception
                MsgBox("Error Adding Bus Record! " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        txtBusNumber.Clear()
        txtPlateNumber.Clear()
        txtBusModel.Clear()
        txtYearModel.Clear()
        txtSeatingCapacity.Clear()
        txtColorDesign.Clear()
        txtDriverAssigned.Clear()
        txtRemarks.Clear()
        comboxType.SelectedIndex = -1
        comboxStatus.SelectedIndex = -1
        comboxFuelType.SelectedIndex = -1
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtBusNumber.Text) Then
            MsgBox("Please Enter Bus Number to Edit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM BusRecords WHERE BusNumber = @BusNumber"
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtBusNumber.Text = reader("BusNumber").ToString()
                            txtPlateNumber.Text = reader("PlateNumber").ToString()
                            txtBusModel.Text = reader("BusModel").ToString()
                            txtYearModel.Text = reader("YearModel").ToString()
                            txtSeatingCapacity.Text = reader("SeatingCapacity").ToString()
                            txtColorDesign.Text = reader("ColorDesign").ToString()
                            txtDriverAssigned.Text = reader("DriverAssigned").ToString()
                            txtRemarks.Text = reader("RemarksNotes").ToString()
                            comboxType.Text = reader("Type").ToString()
                            comboxStatus.Text = reader("Status").ToString()
                            comboxFuelType.Text = reader("FuelType").ToString()
                        Else
                            MsgBox("Bus Record Not Found!", MsgBoxStyle.Exclamation)
                            ClearFields()
                            viewdata()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Loading Bus Record: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtBusNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtPlateNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtBusModel.Text) OrElse
           String.IsNullOrWhiteSpace(txtYearModel.Text) OrElse
           String.IsNullOrWhiteSpace(txtSeatingCapacity.Text) OrElse
           String.IsNullOrWhiteSpace(txtColorDesign.Text) OrElse
           String.IsNullOrWhiteSpace(txtDriverAssigned.Text) OrElse
           String.IsNullOrWhiteSpace(txtRemarks.Text) OrElse
           comboxType.SelectedIndex = -1 OrElse
           comboxStatus.SelectedIndex = -1 OrElse
           comboxFuelType.SelectedIndex = -1 Then

            MsgBox("Please Fill in all Required Fields before Updating!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "UPDATE BusRecords SET " &
                              "PlateNumber=@PlateNumber, BusModel=@BusModel, YearModel=@YearModel, " &
                              "SeatingCapacity=@SeatingCapacity, Type=@Type, Status=@Status, FuelType=@FuelType, " &
                              "ColorDesign=@ColorDesign, DriverAssigned=@DriverAssigned, RemarksNotes=@RemarksNotes " &
                              "WHERE BusNumber=@BusNumber"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text)
                    cmd.Parameters.AddWithValue("@PlateNumber", txtPlateNumber.Text)
                    cmd.Parameters.AddWithValue("@BusModel", txtBusModel.Text)
                    cmd.Parameters.AddWithValue("@YearModel", txtYearModel.Text)
                    cmd.Parameters.AddWithValue("@SeatingCapacity", txtSeatingCapacity.Text)
                    cmd.Parameters.AddWithValue("@Type", comboxType.Text)
                    cmd.Parameters.AddWithValue("@Status", comboxStatus.Text)
                    cmd.Parameters.AddWithValue("@FuelType", comboxFuelType.Text)
                    cmd.Parameters.AddWithValue("@ColorDesign", txtColorDesign.Text)
                    cmd.Parameters.AddWithValue("@DriverAssigned", txtDriverAssigned.Text)
                    cmd.Parameters.AddWithValue("@RemarksNotes", txtRemarks.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Bus Record Updated Successfully!", MsgBoxStyle.Information)
                        ClearFields()
                        viewdata()
                    Else
                        MsgBox("No Record Found with that Bus Number!", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error Updating Bus Record!: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtBusNumber.Text) Then
            MsgBox("Please Enter Bus Number to Delete!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Using conn As New SqlConnection(connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM BusRecords WHERE BusNumber = @BusNumber"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    MsgBox("Bus Record Deleted Successfully!", MsgBoxStyle.Information)
                    ClearFields()
                    viewdata()
                Catch ex As Exception
                    MsgBox("Error Deleting Bus Record: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub

    Private Sub LoadBusesDetails()
        Try
            OpenConn()
            Dim sql As String = "SELECT * FROM BusRecords"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBusRecords.DataSource = dt
            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error Loading Bus Records: " & ex.Message)
        End Try
    End Sub

    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM BusRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvBusRecords.AutoGenerateColumns = True
                dgvBusRecords.DataSource = data
            End Using

            For Each col As DataGridViewColumn In dgvBusRecords.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            dgvBusRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgvBusRecords.EnableHeadersVisualStyles = False

        Catch ex As Exception
            MsgBox("Error Viewing Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BusesRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadBusesDetails()
    End Sub

    Private Sub dgvBusRecords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvBusRecords.DataBindingComplete
        For Each col As DataGridViewColumn In dgvBusRecords.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

End Class
