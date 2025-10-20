Imports System.Data.SqlClient
Imports System.Drawing

Public Class UserScheduleAndSeat
    Private TotalSeats As Integer = 45
    Private seatStatus(44) As Boolean
    Private SelectedSeats As New List(Of String)
    Public Property PassedBookingNumber As String
    Public Property DepartureDate As String
    Public Property DepartureTime As String
    Public Property DepartureTerminal As String
    Public Property DestinationTerminal As String
    Public Property BusClass As String
    Public Property PassengerCount As String

    Private Sub UserScheduleAndSeat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTerminalsFromDatabase()

        For i As Integer = 0 To TotalSeats - 1
            seatStatus(i) = False
            Dim seatName As String = "Seat" & (i + 1).ToString("00")
            Dim seatPic As PictureBox = TryCast(Controls(seatName), PictureBox)
            If seatPic IsNot Nothing Then
                seatPic.Image = picboxAvailable.Image
                seatPic.SizeMode = PictureBoxSizeMode.StretchImage
                AddHandler seatPic.Click, AddressOf Seat_Click
            End If
        Next

        Using conn As New SqlConnection(connString)
            conn.Open()
            Using cmd As New SqlCommand("SELECT SeatNo FROM BookingRecords", conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim seatNos As String() = reader("SeatNo").ToString().Split(","c)
                        For Each s In seatNos
                            Dim seatIndex As Integer
                            If Integer.TryParse(s.Trim(), seatIndex) Then
                                seatIndex -= 1
                                seatStatus(seatIndex) = True
                                Dim seatName As String = "Seat" & (seatIndex + 1).ToString("00")
                                Dim seatPic As PictureBox = TryCast(Controls(seatName), PictureBox)
                                If seatPic IsNot Nothing Then
                                    seatPic.Image = picboxOccupied.Image
                                    seatPic.SizeMode = PictureBoxSizeMode.StretchImage
                                End If
                            End If
                        Next
                    End While
                End Using
            End Using
        End Using

        Dim labels As Label() = {
            lblChooseSeat, lblAvailable, lblOccupied, lblChooseDestination,
            lblDateDeparture, Label6,
            lblTerminalDeparture, lblTerminalDestination,
            lblPassenger, lblBusClassType
        }

        For i As Integer = 1 To 45
            Dim seatLabel As Label = CType(Me.Controls.Find("lbl" & i.ToString("00"), True).FirstOrDefault(), Label)
            If seatLabel IsNot Nothing Then
                Array.Resize(labels, labels.Length + 1)
                labels(labels.Length - 1) = seatLabel
            End If
        Next

        For Each lbl As Label In labels
            lbl.Parent = PictureBox3
            lbl.BackColor = Color.Transparent
        Next

    End Sub

    Private Sub Seat_Click(sender As Object, e As EventArgs)
        Dim passengerNo As Integer = CInt(pickPassenger.Value)
        If passengerNo <= 0 Then
            MessageBox.Show("Please enter the number of passengers first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If SelectedSeats.Count >= passengerNo Then
            MessageBox.Show("You have already selected seats for all passengers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim seatPic As PictureBox = TryCast(sender, PictureBox)
        If seatPic Is Nothing Then Return

        Dim seatNum As Integer
        If Not Integer.TryParse(seatPic.Name.Replace("Seat", ""), seatNum) Then Return
        seatNum -= 1

        If seatStatus(seatNum) Then
            MessageBox.Show("You already selected this seat!")
            Return
        End If

        If MessageBox.Show("Do you want to select Seat " & (seatNum + 1).ToString("00") & "?", "Confirm Seat", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            seatStatus(seatNum) = True
            SelectedSeats.Add((seatNum + 1).ToString("00"))

            seatPic.Image = picboxOccupied.Image
            seatPic.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim passengerNo As Integer = CInt(pickPassenger.Value)
            Dim busClassType As String = comboxBusClassType.Text
            Dim terminalDeparture As String = comboxTerminalDeparture.Text
            Dim dateDeparture As Date = datepickerDeparture.Value.Date
            Dim timeDepartureStr As String = comboxTimeDeparture.Text
            Dim terminalDestination As String = comboxTerminalDestination.Text

            If passengerNo <= 0 OrElse
               String.IsNullOrWhiteSpace(busClassType) OrElse
               String.IsNullOrWhiteSpace(terminalDeparture) OrElse
               String.IsNullOrWhiteSpace(timeDepartureStr) OrElse
               String.IsNullOrWhiteSpace(terminalDestination) Then

                MsgBox("Please fill in all required fields!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If SelectedSeats.Count = 0 Then
                MsgBox("Please select at least one seat before submitting!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If SelectedSeats.Count <> passengerNo Then
                MsgBox("Number of selected seats does not match the number of passengers!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim DepartureTime As TimeSpan
            If Not TimeSpan.TryParse(DateTime.Parse(timeDepartureStr).ToString("HH:mm"), DepartureTime) Then
                MsgBox("Please select a valid departure time!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If terminalDeparture = terminalDestination Then
                MsgBox("Departure and destination cannot be the same!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim query As String = "UPDATE BookingRecords SET " &
                                  "PassengerNo=@PassengerNo, " &
                                  "BusClassType=@BusClassType, " &
                                  "TerminalDeparture=@TerminalDeparture, " &
                                  "DateDeparture=@DateDeparture, " &
                                  "TimeDeparture=@TimeDeparture, " &
                                  "TerminalDestination=@TerminalDestination, " &
                                  "SeatNo=@SeatNo " &
                                  "WHERE BookingNumber=@BookingNumber"

            Using conn As New SqlConnection(connString)
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BookingNumber", PassedBookingNumber)
                    cmd.Parameters.AddWithValue("@PassengerNo", passengerNo)
                    cmd.Parameters.AddWithValue("@BusClassType", busClassType)
                    cmd.Parameters.AddWithValue("@TerminalDeparture", terminalDeparture)
                    cmd.Parameters.AddWithValue("@DateDeparture", dateDeparture)
                    cmd.Parameters.AddWithValue("@TimeDeparture", DepartureTime)
                    cmd.Parameters.AddWithValue("@TerminalDestination", terminalDestination)
                    cmd.Parameters.AddWithValue("@SeatNo", String.Join(", ", SelectedSeats))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Booking saved successfully!", MsgBoxStyle.Information)

            Dim confirmForm As New Confirmation()
            confirmForm.PassedBookingNumber = PassedBookingNumber
            confirmForm.DateDeparture = dateDeparture.ToString("MM/dd/yyyy")
            confirmForm.TimeDeparture = timeDepartureStr
            confirmForm.DepartureTerminal = terminalDeparture
            confirmForm.DestinationTerminal = terminalDestination
            confirmForm.ClassType = busClassType
            confirmForm.PassengerNo = passengerNo.ToString()
            confirmForm.PassedSeatNo = String.Join(", ", SelectedSeats)

            With confirmForm
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand("SELECT * FROM BookingRecords WHERE BookingNumber=@BookingNumber", conn)
                        cmd.Parameters.AddWithValue("@BookingNumber", Me.PassedBookingNumber)
                        Using reader = cmd.ExecuteReader()
                            If reader.Read() Then
                                .PassedFirstName = reader("FirstName").ToString()
                                .PassedMiddleName = reader("MiddleName").ToString()
                                .PassedLastName = reader("LastName").ToString()
                                .PassedHouseNo = reader("HouseNo").ToString()
                                .PassedSubdivision = reader("Subdivision").ToString()
                                .PassedStreet = reader("Street").ToString()
                                .PassedBarangay = reader("Barangay").ToString()
                                .PassedCity = reader("City").ToString()
                                .PassedZipCode = reader("ZipCode").ToString()
                                .PassedContactNo = reader("ContactNo").ToString()
                            End If
                        End Using
                    End Using
                End Using
            End With

            confirmForm.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Error saving booking: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", _
                                                         "Cancel Confirmation", _
                                                         MessageBoxButtons.YesNo, _
                                                         MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim deleteData As DialogResult = MessageBox.Show("You have unsaved data. Do you want to delete it?", _
                                                                 "Delete Data", _
                                                                 MessageBoxButtons.YesNo, _
                                                                 MessageBoxIcon.Warning)
                If deleteData = DialogResult.Yes Then

                    Using conn As New SqlConnection(connString)
                        conn.Open()
                        Using cmd As New SqlCommand("DELETE FROM BookingRecords WHERE BookingNumber = @BookingNumber", conn)
                            cmd.Parameters.AddWithValue("@BookingNumber", Me.PassedBookingNumber)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Booking deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim anotherTransaction As DialogResult = MessageBox.Show("Do you want to make another booking?", _
                                                                             "New Transaction", _
                                                                             MessageBoxButtons.YesNo, _
                                                                             MessageBoxIcon.Question)
                    If anotherTransaction = DialogResult.Yes Then
                        Dim bookingForm As New UserBookingDetails()
                        bookingForm.Show()
                        Me.Close()
                    Else
                        Dim loginForm As New LoginForm()
                        loginForm.Show()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting booking: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ResetSeats()
        Try
            Dim seatForm As UserScheduleAndSeat = Application.OpenForms.OfType(Of UserScheduleAndSeat)().FirstOrDefault()

            If seatForm IsNot Nothing Then
                seatForm.ResetSeats()
            Else
                MessageBox.Show("UserScheduleAndSeat form is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error resetting seats: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadTerminalsFromDatabase()
        Try
            Dim departures As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Dim destinations As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT StartingPoint, EndPoint FROM RouteRecords"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not IsDBNull(reader("StartingPoint")) Then
                                Dim dep As String = reader("StartingPoint").ToString().Trim()
                                If dep.Contains(",") Then
                                    dep = dep.Split(","c)(0).Trim()
                                End If
                                departures.Add(dep)
                            End If

                            If Not IsDBNull(reader("EndPoint")) Then
                                Dim dest As String = reader("EndPoint").ToString().Trim()
                                If dest.Contains(",") Then
                                    dest = dest.Split(","c)(0).Trim()
                                End If
                                destinations.Add(dest)
                            End If
                        End While
                    End Using
                End Using
            End Using

            Dim sortedDepartures = departures.OrderBy(Function(x) x).ToArray()
            Dim sortedDestinations = destinations.OrderBy(Function(x) x).ToArray()

            comboxTerminalDeparture.Items.Clear()
            comboxTerminalDeparture.Items.AddRange(sortedDepartures)

            comboxTerminalDestination.Items.Clear()
            comboxTerminalDestination.Items.AddRange(sortedDestinations)

        Catch ex As Exception
            MessageBox.Show("Error loading terminals: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub comboxTerminalDeparture_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboxTerminalDeparture.SelectedIndexChanged
         Try
            If comboxTerminalDeparture.SelectedItem Is Nothing Then Exit Sub

            Dim selectedDeparture As String = comboxTerminalDeparture.SelectedItem.ToString()

            RemoveHandler comboxTerminalDestination.SelectedIndexChanged, AddressOf comboxTerminalDestination_SelectedIndexChanged

            comboxTerminalDestination.Items.Clear()
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT DISTINCT EndPoint FROM RouteRecords"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim dest As String = reader("EndPoint").ToString().Trim()
                            If dest.Contains(",") Then dest = dest.Split(","c)(0).Trim()

                            If Not dest.Equals(selectedDeparture, StringComparison.OrdinalIgnoreCase) Then
                                comboxTerminalDestination.Items.Add(dest)
                            End If
                        End While
                    End Using
                End Using
            End Using

            comboxTerminalDestination.SelectedIndex = -1

            AddHandler comboxTerminalDestination.SelectedIndexChanged, AddressOf comboxTerminalDestination_SelectedIndexChanged

        Catch ex As Exception
            MessageBox.Show("Error updating destination list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub comboxTerminalDestination_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboxTerminalDestination.SelectedIndexChanged
        Try
            If comboxTerminalDestination.SelectedItem Is Nothing Then Exit Sub

            Dim selectedDestination As String = comboxTerminalDestination.SelectedItem.ToString()

            RemoveHandler comboxTerminalDeparture.SelectedIndexChanged, AddressOf comboxTerminalDeparture_SelectedIndexChanged

            comboxTerminalDeparture.Items.Clear()
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT DISTINCT StartingPoint FROM RouteRecords"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim dep As String = reader("StartingPoint").ToString().Trim()
                            If dep.Contains(",") Then dep = dep.Split(","c)(0).Trim()

                            If Not dep.Equals(selectedDestination, StringComparison.OrdinalIgnoreCase) Then
                                comboxTerminalDeparture.Items.Add(dep)
                            End If
                        End While
                    End Using
                End Using
            End Using

            comboxTerminalDeparture.SelectedIndex = -1

            AddHandler comboxTerminalDeparture.SelectedIndexChanged, AddressOf comboxTerminalDeparture_SelectedIndexChanged

        Catch ex As Exception
            MessageBox.Show("Error updating departure list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
