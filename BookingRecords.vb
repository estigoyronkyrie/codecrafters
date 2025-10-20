Imports System.Data.SqlClient

Public Class BookingRecords

    Private TotalSeats As Integer = 45
    Private seatStatus(44) As Boolean
    Private SelectedSeats As New List(Of String)
    Private picboxAvailable As New PictureBox
    Private picboxOccupied As New PictureBox
    Public ScheduleForm As UserScheduleAndSeat

    Private Sub LoadBookingDetails()
        Try
            OpenConn()
            Dim sql As String = "SELECT * FROM BookingRecords"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvBookingRecords.DataSource = dt
            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error Loading Employee Records: " & ex.Message)
        End Try
    End Sub
    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM BookingRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvBookingRecords.DataSource = data
            End Using
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BookingRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadBookingDetails()
    End Sub

    Private Sub btnResetSeat_Click(sender As System.Object, e As System.EventArgs) Handles btnResetSeat.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Do you want to reset all seats?", "Reset Seats", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then Return

            Using conn As New SqlConnection(connString)
                conn.Open()
                Using cmd As New SqlCommand("UPDATE BookingRecords SET SeatNo = NULL", conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("All seats have been reset successfully!", "Reset Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error resetting seats: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearFields()
        txtBookingNumber.Clear()
    End Sub
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtBookingNumber.Text) Then
            MsgBox("Please Enter Booking Number to Delete!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Are you Sure you want to Delete this Record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Using conn As New SqlConnection(connString)
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM BookingRecords WHERE BookingNumber= @BookingNumber"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@BookingNumber", txtBookingNumber.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Booking Record Deleted Successfully!", MsgBoxStyle.Information)
                    ClearFields()
                    viewdata()

                Catch ex As Exception
                    MsgBox("Error Deleting Booking Record!" & ex.Message, MsgBoxStyle.Critical)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnDeleteAllRecords_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteAllRecords.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE ALL booking records?" & vbCrLf &
                                                "This action cannot be undone.",
                                                "Confirm Delete All",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()

                    Dim deleteQuery As String = "DELETE FROM BookingRecords"
                    Using cmd As New SqlCommand(deleteQuery, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                viewdata()

                If ScheduleForm IsNot Nothing Then
                    For Each ctrl As Control In ScheduleForm.Controls
                        If TypeOf ctrl Is Button AndAlso ctrl.Name.StartsWith("btnSeat") Then
                            Dim btnSeat As Button = DirectCast(ctrl, Button)
                            btnSeat.BackColor = Color.Green
                            btnSeat.Enabled = True
                        End If
                    Next
                    MessageBox.Show("All seats have been reset to available!", "Seats Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                MessageBox.Show("All booking records have been deleted successfully!", "Delete All Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error deleting all booking records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class