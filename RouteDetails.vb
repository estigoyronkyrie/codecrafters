Imports System.Data.SqlClient

Public Class RouteDetails
    Private Function GenerateRouteID() As String
        Dim prefix As String = "RTS"
        Dim fixedPart As String = "00"
        Dim yearPart As String = DateTime.Now.ToString("yyyy")

        Dim lastNumber As Integer = 0
        Using conn As New SqlConnection(connString)
            Dim query As String = "SELECT TOP 1 RouteID FROM RouteRecords " &
                                  "WHERE RouteID LIKE @Pattern ORDER BY RouteID DESC"
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
        If String.IsNullOrWhiteSpace(txtRouteName.Text) OrElse
           String.IsNullOrWhiteSpace(txtStartingPoint.Text) OrElse
           String.IsNullOrWhiteSpace(txtEndPoint.Text) OrElse
           String.IsNullOrWhiteSpace(txtRestStops.Text) OrElse
           String.IsNullOrWhiteSpace(txtDistance.Text) OrElse
           String.IsNullOrWhiteSpace(txtEstimatedTime.Text) OrElse
           String.IsNullOrWhiteSpace(txtBusOperator.Text) OrElse
           String.IsNullOrWhiteSpace(txtTypeOfService.Text) OrElse
           String.IsNullOrWhiteSpace(txtSchedule.Text) OrElse
           String.IsNullOrWhiteSpace(txtStatus.Text) Then

            MsgBox("Please Fill in all Required Fields before Submit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim RouteID As String = GenerateRouteID()
        txtRouteID.Text = RouteID

        Dim query As String = "INSERT INTO RouteRecords" &
                              "(RouteID, RouteName, StartingPoint, EndPoint, RestStops, Distance, EstimatedTime, BusOperator, TypeOfService, Schedule, Status) " &
                              "VALUES (@RouteID, @RouteName, @StartingPoint, @EndPoint, @RestStops, @Distance, @EstimatedTime, @BusOperator, @TypeOfService, @Schedule, @Status)"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RouteID", txtRouteID.Text)
                    cmd.Parameters.AddWithValue("@RouteName", txtRouteName.Text)
                    cmd.Parameters.AddWithValue("@StartingPoint", txtStartingPoint.Text)
                    cmd.Parameters.AddWithValue("@EndPoint", txtEndPoint.Text)
                    cmd.Parameters.AddWithValue("@RestStops", txtRestStops.Text)
                    cmd.Parameters.AddWithValue("@Distance", txtDistance.Text)
                    cmd.Parameters.AddWithValue("@EstimatedTime", txtEstimatedTime.Text)
                    cmd.Parameters.AddWithValue("@BusOperator", txtBusOperator.Text)
                    cmd.Parameters.AddWithValue("@TypeOfService", txtTypeOfService.Text)
                    cmd.Parameters.AddWithValue("@Schedule", txtSchedule.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Route Record Added Successfully!", MsgBoxStyle.Information)
                ClearFields()
                RouteRecords.viewdata()

            Catch ex As Exception
                MsgBox("Error Adding Route Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub
    Public Shared Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM RouteRecords"
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
        txtRouteID.Clear()
        txtRouteName.Clear()
        txtStartingPoint.Clear()
        txtEndPoint.Clear()
        txtRestStops.Clear()
        txtDistance.Clear()
        txtEstimatedTime.Clear()
        txtBusOperator.Clear()
        txtTypeOfService.Clear()
        txtSchedule.Clear()
        txtStatus.Clear()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If String.IsNullOrWhiteSpace(txtRouteID.Text) Then
            MsgBox("Please Enter Route ID to Edit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM RouteRecords WHERE RouteID = @RouteID"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RouteID", txtRouteID.Text.Trim())

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtRouteName.Text = reader("RouteName").ToString()
                            txtStartingPoint.Text = reader("StartingPoint").ToString()
                            txtEndPoint.Text = reader("EndPoint").ToString()
                            txtRestStops.Text = reader("RestStops").ToString()
                            txtDistance.Text = reader("Distance").ToString()
                            txtEstimatedTime.Text = reader("EstimatedTime").ToString()
                            txtBusOperator.Text = reader("BusOperator").ToString()
                            txtTypeOfService.Text = reader("TypeOfService").ToString()
                            txtSchedule.Text = reader("Schedule").ToString()
                            txtStatus.Text = reader("Status").ToString()
                        Else
                            MsgBox("Route not found!", MsgBoxStyle.Exclamation)
                            ClearFields()
                            RouteRecords.viewdata()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Loading Route Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtRouteName.Text) OrElse
            String.IsNullOrWhiteSpace(txtStartingPoint.Text) OrElse
            String.IsNullOrWhiteSpace(txtEndPoint.Text) OrElse
            String.IsNullOrWhiteSpace(txtRestStops.Text) OrElse
            String.IsNullOrWhiteSpace(txtDistance.Text) OrElse
            String.IsNullOrWhiteSpace(txtEstimatedTime.Text) OrElse
            String.IsNullOrWhiteSpace(txtBusOperator.Text) OrElse
            String.IsNullOrWhiteSpace(txtTypeOfService.Text) OrElse
            String.IsNullOrWhiteSpace(txtSchedule.Text) OrElse
            String.IsNullOrWhiteSpace(txtStatus.Text) Then

            MsgBox("Please Fill in all Required Fields before Updating!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtRouteID.Text) Then
            MsgBox("Please Enter Route ID to Update!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim query As String = "UPDATE RouteRecords SET " &
                              "RouteName=@RouteName, StartingPoint=@StartingPoint, EndPoint=@EndPoint, RestStops=@RestStops, " &
                              "Distance=@Distance, EstimatedTime=@EstimatedTime, BusOperator=@BusOperator, " &
                              "TypeOfService=@TypeOfService, Schedule=@Schedule, Status=@Status " &
                              "WHERE RouteID=@RouteID"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RouteID", txtRouteID.Text)
                    cmd.Parameters.AddWithValue("@RouteName", txtRouteName.Text)
                    cmd.Parameters.AddWithValue("@StartingPoint", txtStartingPoint.Text)
                    cmd.Parameters.AddWithValue("@EndPoint", txtEndPoint.Text)
                    cmd.Parameters.AddWithValue("@RestStops", txtRestStops.Text)
                    cmd.Parameters.AddWithValue("@Distance", txtDistance.Text)
                    cmd.Parameters.AddWithValue("@EstimatedTime", txtEstimatedTime.Text)
                    cmd.Parameters.AddWithValue("@BusOperator", txtBusOperator.Text)
                    cmd.Parameters.AddWithValue("@TypeOfService", txtTypeOfService.Text)
                    cmd.Parameters.AddWithValue("@Schedule", txtSchedule.Text)
                    cmd.Parameters.AddWithValue("@Status", txtStatus.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Route Record Updated Successfully!", MsgBoxStyle.Information)
                        ClearFields()
                        RouteRecords.viewdata()
                    Else
                        MsgBox("No Record Found with that Route ID!", MsgBoxStyle.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MsgBox("Error Updating Route Record!" & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtRouteID.Text) Then
            MsgBox("Please Enter Route ID to Delete!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you Sure you want to Delete this Route?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Using conn As New SqlConnection(connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM RouteRecords WHERE RouteID = @RouteID"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@RouteID", txtRouteID.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Route Record Deleted Successfully!", MsgBoxStyle.Information)
                    ClearFields()
                    RouteRecords.viewdata()

                Catch ex As Exception
                    MsgBox("Error Deleting Route Record!" & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub

End Class