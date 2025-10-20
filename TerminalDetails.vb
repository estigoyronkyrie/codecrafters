Imports System.Data.SqlClient
Public Class TerminalDetails

    Private Function GenerateTerminalID() As String
        Dim prefix As String = "TRMNL"
        Dim fixedPart As String = "00"
        Dim yearPart As String = DateTime.Now.ToString("yyyy")

        Dim lastNumber As Integer = 0
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT TOP 1 TerminalID FROM TerminalRecords " &
                                  "WHERE TerminalID LIKE @Pattern ORDER BY TerminalID DESC"
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

        Dim newNumberStr As String = (lastNumber + 1).ToString("D3") '
        Return String.Format("{0}-{1}-{2}-{3}", prefix, fixedPart, yearPart, newNumberStr)
    End Function

      Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtTerminalName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLocation.Text) OrElse
           String.IsNullOrWhiteSpace(txtCity.Text) OrElse
           String.IsNullOrWhiteSpace(txtRegion.Text) OrElse
           String.IsNullOrWhiteSpace(txtOperatingHours.Text) OrElse
           String.IsNullOrWhiteSpace(txtNumberOfPlatforms.Text) OrElse
           String.IsNullOrWhiteSpace(txtStatus.Text) OrElse
           comboxRestrooms.SelectedIndex = -1 OrElse
           comboxWaitingArea.SelectedIndex = -1 OrElse
           comboxParking.SelectedIndex = -1 OrElse
           comboxFoodStalls.SelectedIndex = -1 OrElse
           comboxTicketingBooths.SelectedIndex = -1 Then

            MsgBox("Please fill in all Required Fields!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim TerminalID As String = GenerateTerminalID()
        txtTerminalID.Text = TerminalID

        Dim query As String = "INSERT INTO TerminalRecords " &
                              "(TerminalID, TerminalName, Location, City, Region, OperatingHours, NumberOfPlatforms, Status, Restrooms, WaitingArea, Parking, FoodStalls, TicketingBooths) " &
                              "VALUES (@TerminalID, @TerminalName, @Location, @City, @Region, @OperatingHours, @NumberOfPlatforms, @Status, @Restrooms, @WaitingArea, @Parking, @FoodStalls, @TicketingBooths)"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TerminalID", txtTerminalID.Text)
                    cmd.Parameters.AddWithValue("@TerminalName", txtTerminalName.Text)
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text)
                    cmd.Parameters.AddWithValue("@City", txtCity.Text)
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text)
                    cmd.Parameters.AddWithValue("@OperatingHours", txtOperatingHours.Text)
                    cmd.Parameters.AddWithValue("@NumberOfPlatforms", txtNumberOfPlatforms.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@Restrooms", comboxRestrooms.Text)
                    cmd.Parameters.AddWithValue("@WaitingArea", comboxWaitingArea.Text)
                    cmd.Parameters.AddWithValue("@Parking", comboxParking.Text)
                    cmd.Parameters.AddWithValue("@FoodStalls", comboxFoodStalls.Text)
                    cmd.Parameters.AddWithValue("@TicketingBooths", comboxTicketingBooths.Text)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Terminal Added Successfully!", MsgBoxStyle.Information)
                ClearFields()
                TerminalRecords.viewdata()
            Catch ex As Exception
                MsgBox("Error Adding Terminal: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        txtTerminalID.Clear()
        txtTerminalName.Clear()
        txtLocation.Clear()
        txtCity.Clear()
        txtRegion.Clear()
        txtOperatingHours.Clear()
        txtNumberOfPlatforms.Clear()
        txtStatus.Clear()

        comboxRestrooms.SelectedIndex = -1
        comboxWaitingArea.SelectedIndex = -1
        comboxParking.SelectedIndex = -1
        comboxFoodStalls.SelectedIndex = -1
        comboxTicketingBooths.SelectedIndex = -1
    End Sub
    Public Shared Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM TerminalRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
            End Using
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtTerminalID.Text) Then
            MsgBox("Please Enter Terminal ID!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM TerminalRecords WHERE TerminalID = @TerminalID"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TerminalID", txtTerminalID.Text)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtTerminalName.Text = reader("TerminalName").ToString()
                            txtLocation.Text = reader("Location").ToString()
                            txtCity.Text = reader("City").ToString()
                            txtRegion.Text = reader("Region").ToString()
                            txtOperatingHours.Text = reader("OperatingHours").ToString()
                            txtNumberOfPlatforms.Text = reader("NumberOfPlatforms").ToString()
                            txtStatus.Text = reader("Status").ToString()

                            comboxRestrooms.Text = reader("Restrooms").ToString()
                            comboxWaitingArea.Text = reader("WaitingArea").ToString()
                            comboxParking.Text = reader("Parking").ToString()
                            comboxFoodStalls.Text = reader("FoodStalls").ToString()
                            comboxTicketingBooths.Text = reader("TicketingBooths").ToString()
                        Else
                            MsgBox("Terminal Not Found!", MsgBoxStyle.Exclamation)
                            ClearFields()
                            TerminalRecords.viewdata()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Loading Terminal Records: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtTerminalName.Text) OrElse
           String.IsNullOrWhiteSpace(txtLocation.Text) OrElse
           String.IsNullOrWhiteSpace(txtCity.Text) OrElse
           String.IsNullOrWhiteSpace(txtRegion.Text) OrElse
           String.IsNullOrWhiteSpace(txtOperatingHours.Text) OrElse
           String.IsNullOrWhiteSpace(txtNumberOfPlatforms.Text) OrElse
           String.IsNullOrWhiteSpace(txtStatus.Text) OrElse
           comboxRestrooms.SelectedIndex = -1 OrElse
           comboxWaitingArea.SelectedIndex = -1 OrElse
           comboxParking.SelectedIndex = -1 OrElse
           comboxFoodStalls.SelectedIndex = -1 OrElse
           comboxTicketingBooths.SelectedIndex = -1 Then

            MsgBox("Please enter Terminal ID to update!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "UPDATE TerminalRecords SET " &
                              "TerminalID=@TerminalID, TerminalName=@TerminalName, Location=@Location, City=@City, Region=@Region, OperatingHours=@OperatingHours, " &
                              "NumberOfPlatforms=@NumberOfPlatforms, Status=@Status, Restrooms=@Restrooms, WaitingArea=@WaitingArea, " &
                              "Parking=@Parking, FoodStalls=@FoodStalls, TicketingBooths=@TicketingBooths " &
                              "WHERE TerminalID=@TerminalID"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@TerminalID", txtTerminalID.Text)
                    cmd.Parameters.AddWithValue("@TerminalName", txtTerminalName.Text)
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text)
                    cmd.Parameters.AddWithValue("@City", txtCity.Text)
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text)
                    cmd.Parameters.AddWithValue("@OperatingHours", txtOperatingHours.Text)
                    cmd.Parameters.AddWithValue("@NumberOfPlatforms", txtNumberOfPlatforms.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)
                    cmd.Parameters.AddWithValue("@Restrooms", comboxRestrooms.Text)
                    cmd.Parameters.AddWithValue("@WaitingArea", comboxWaitingArea.Text)
                    cmd.Parameters.AddWithValue("@Parking", comboxParking.Text)
                    cmd.Parameters.AddWithValue("@FoodStalls", comboxFoodStalls.Text)
                    cmd.Parameters.AddWithValue("@TicketingBooths", comboxTicketingBooths.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Terminal Details Updated Successfully!", MsgBoxStyle.Information)
                        ClearFields()
                        TerminalRecords.viewdata()
                    Else
                        MsgBox("No Record Found with that Terminal ID.", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error Updating Terminal: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub


    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtTerminalID.Text) Then
            MsgBox("Please Enter Terminal ID to delete!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you sure you want to Delete this Terminal?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Using conn As New SqlConnection(connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM TerminalRecords WHERE TerminalID = @TerminalID"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@TerminalID", txtTerminalID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Terminal Deleted Successfully.", MsgBoxStyle.Information)
                    ClearFields()
                    TerminalRecords.viewdata()

                Catch ex As Exception
                    MsgBox("Error Deleting Terminal: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub
End Class