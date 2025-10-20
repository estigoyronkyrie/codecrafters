Imports System.Data.SqlClient
Imports System.Drawing
Imports MessagingToolkit.QRCode.Codec
Imports System.Globalization
Imports System.Drawing.Printing
Imports System.IO

Public Class Receipt
    Public Property BookingNumber As String
    Public Property PassengerName As String
    Public Property Suffix As String
    Public Property Address As String
    Public Property ContactNumber As String
    Public Property Departure As String
    Public Property Destination As String
    Public Property DateDeparture As String
    Public Property DateDestination As String
    Public Property TimeDeparture As String
    Public Property ClassType As String
    Public Property PassengerNo As String
    Public Property SeatNo As String
    Private WithEvents PrintDocument1 As New PrintDocument

    Private Sub Receipt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
         Try
            Dim qrEncoder As New QRCodeEncoder()
            qrEncoder.QRCodeScale = 8

            Dim qrBitmap As Bitmap = qrEncoder.Encode(BookingNumber)
            PicBoxQRCode.Image = qrBitmap
            PicBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage

            lblPassengerName.Text = PassengerName
            lblAddress.Text = Address
            lblContactNumber.Text = ContactNumber
            lblDeparture.Text = Departure
            lblDestination.Text = Destination
            lblDateDeparture.Text = DateDeparture
            lblTime.Text = TimeDeparture
            lblClassType.Text = ClassType
            lblPassengerNo.Text = PassengerNo
            lblSeatNo.Text = SeatNo

        Catch ex As Exception
            MessageBox.Show("Error loading receipt: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
   Try

            Using panelBmp As New Bitmap(Panel2.Width, Panel2.Height)
                Panel2.DrawToBitmap(panelBmp, New Rectangle(0, 0, Panel2.Width, Panel2.Height))
                Dim croppedBmp As Bitmap = CropWhiteSpace(panelBmp)

                Dim paperWidthHundredths As Integer = 803   ' ≈ 20.37 cm
                Dim paperHeightHundredths As Integer = 426  ' ≈ 10.82 cm
                Dim customPaper As New PaperSize("Receipt_20x10cm", paperWidthHundredths, paperHeightHundredths)

                e.PageSettings.PaperSize = customPaper
                e.PageSettings.Margins = New Margins(0, 0, 0, 0)
                e.PageSettings.Landscape = True


                Dim xPos As Integer = (customPaper.Width - croppedBmp.Width) / 2
                Dim yPos As Integer = (customPaper.Height - croppedBmp.Height) / 2
                If xPos < 0 Then xPos = 0
                If yPos < 0 Then yPos = 0

                e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

                e.Graphics.DrawImage(croppedBmp, 0, 0,
                                     e.PageBounds.Width,
                                     e.PageBounds.Height)
            End Using

            e.HasMorePages = False

        Catch ex As Exception
            MessageBox.Show("Error printing receipt: " & ex.Message,
                            "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
      Try
            Using pd As New PrintDialog()
                pd.Document = PrintDocument1
                PrintDocument1.DefaultPageSettings.Landscape = True

                If pd.ShowDialog() = DialogResult.OK Then
                    PrintDocument1.Print()

                    Dim result As DialogResult = MessageBox.Show("Do you want to make another transaction?",
                                                                 "Continue?", MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Dim bookingForm As New UserBookingDetails()
                        bookingForm.Show()
                    Else
                        Dim loginForm As New LoginForm()
                        loginForm.Show()
                    End If
                    Me.Close()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error printing ticket: " & ex.Message,
                            "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CropWhiteSpace(ByVal bmp As Bitmap) As Bitmap
        Dim rect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim data As Imaging.BitmapData = bmp.LockBits(rect, Imaging.ImageLockMode.ReadOnly, Imaging.PixelFormat.Format24bppRgb)

        Dim bytes(bmp.Width * bmp.Height * 3 - 1) As Byte
        Runtime.InteropServices.Marshal.Copy(data.Scan0, bytes, 0, bytes.Length)
        bmp.UnlockBits(data)

        Dim minX As Integer = bmp.Width
        Dim minY As Integer = bmp.Height
        Dim maxX As Integer = 0
        Dim maxY As Integer = 0

        For y As Integer = 0 To bmp.Height - 1
            For x As Integer = 0 To bmp.Width - 1
                Dim index As Integer = (y * bmp.Width + x) * 3
                Dim r As Byte = bytes(index + 2)
                Dim g As Byte = bytes(index + 1)
                Dim b As Byte = bytes(index)

                If Not (r > 240 AndAlso g > 240 AndAlso b > 240) Then
                    minX = Math.Min(minX, x)
                    minY = Math.Min(minY, y)
                    maxX = Math.Max(maxX, x)
                    maxY = Math.Max(maxY, y)
                End If
            Next
        Next

        If maxX <= minX OrElse maxY <= minY Then
            Return bmp
        End If

        Dim cropRect As New Rectangle(minX, minY, maxX - minX + 1, maxY - minY + 1)
        Return bmp.Clone(cropRect, bmp.PixelFormat)
    End Function
End Class


