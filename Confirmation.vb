Imports System.Data.SqlClient
Imports System.Drawing
Imports MessagingToolkit.QRCode.Codec
Imports System.Globalization

Public Class Confirmation
    Public Property PassedBookingNumber As String
    Public Property DepartureTerminal As String
    Public Property DestinationTerminal As String
    Public Property DateDeparture As String
    Public Property DateDestination As String
    Public Property TimeDeparture As String
    Public Property ClassType As String
    Public Property PassengerNo As String
    Public Property PassedFirstName As String
    Public Property PassedMiddleName As String
    Public Property PassedLastName As String
    Public Property PassedHouseNo As String
    Public Property PassedSubdivision As String
    Public Property PassedStreet As String
    Public Property PassedBarangay As String
    Public Property PassedCity As String
    Public Property PassedZipCode As String
    Public Property PassedContactNo As String
    Public Property PassedSeatNo As String



    Private Sub Confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim qrEncoder As New QRCodeEncoder()
            qrEncoder.QRCodeScale = 8

            Dim qrBitmap As Bitmap = qrEncoder.Encode(PassedBookingNumber)
            PicBoxQRCode.Image = qrBitmap
            PicBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage

            lblDeparture.Text = DepartureTerminal
            lblDestination.Text = DestinationTerminal
            lblDateDeparture.Text = DateDeparture
            lblTime.Text = TimeDeparture
            lblClassType.Text = ClassType
            lblPassengerNo.Text = PassengerNo
            lblSeatNo.Text = PassedSeatNo


            lblPassengerName.Text = PassedFirstName & " " & PassedMiddleName & " " & PassedLastName
            lblAddress.Text = PassedHouseNo & " " & PassedSubdivision & " " & PassedStreet & " " & _
                              PassedBarangay & " " & PassedCity & " " & PassedZipCode
            lblContactNumber.Text = PassedContactNo


        Catch ex As Exception
            MessageBox.Show("Error loading confirmation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?",
                                                     "Cancel Confirmation",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        Dim deleteData As DialogResult = MessageBox.Show("You have unsaved data. Do you want to delete it?",
                                                         "Delete Data",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)
        If deleteData = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand("DELETE FROM BookingRecords WHERE BookingNumber = @BookingNumber", conn)
                        cmd.Parameters.AddWithValue("@BookingNumber", Me.PassedBookingNumber)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Booking deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim anotherTransaction As DialogResult = MessageBox.Show("Do you want to make another booking?",
                                                                         "New Transaction",
                                                                         MessageBoxButtons.YesNo,
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

            Catch ex As Exception
                MessageBox.Show("Error deleting booking: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to confirm this booking?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim receiptForm As New Receipt()
            receiptForm.BookingNumber = PassedBookingNumber
            receiptForm.PassengerName = PassedFirstName & " " & PassedMiddleName & " " & PassedLastName
            receiptForm.Address = PassedHouseNo & " " & PassedSubdivision & " " & PassedStreet & " " &
                                  PassedBarangay & " " & PassedCity & " " & PassedZipCode
            receiptForm.ContactNumber = PassedContactNo
            receiptForm.Departure = DepartureTerminal
            receiptForm.Destination = DestinationTerminal
            receiptForm.DateDeparture = DateDeparture
            receiptForm.DateDestination = DateDestination
            receiptForm.TimeDeparture = TimeDeparture
            receiptForm.ClassType = ClassType
            receiptForm.PassengerNo = PassengerNo
            receiptForm.SeatNo = PassedSeatNo

            receiptForm.Show()
            Me.Close()

        ElseIf result = DialogResult.No Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Using cmd As New SqlCommand("DELETE FROM BookingRecords WHERE BookingNumber = @BookingNumber", conn)
                        cmd.Parameters.AddWithValue("@BookingNumber", PassedBookingNumber)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Booking cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error cancelling booking: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
