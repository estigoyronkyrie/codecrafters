Public Class FormBooking
    Private activeButton As Button = Nothing
    Private isLoading As Boolean = True

    Sub switchPanel(ByVal panel As Form)
        Panel6.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel6.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub HighlightButton(clickedButton As Button)
        If isLoading Then Exit Sub
        If activeButton IsNot Nothing Then
            activeButton.ForeColor = Color.Black
            activeButton.BackColor = Color.Transparent
        End If

        clickedButton.ForeColor = Color.Black
        clickedButton.BackColor = Color.LightGray

        activeButton = clickedButton
    End Sub

    Private Sub btnBookingRecords_Click(sender As System.Object, e As System.EventArgs)
        HighlightButton(btnBookingRecords)
        switchPanel(BookingRecords)
    End Sub

    Private Sub btnBookingRecords_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBookingRecords.Click
        HighlightButton(btnBookingRecords)
        switchPanel(BookingRecords)
    End Sub

    Private Sub FormBooking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isLoading = False
        btnBookingRecords.PerformClick()
    End Sub
End Class