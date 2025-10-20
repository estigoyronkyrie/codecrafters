Public Class FormBuses
    Private activeButton As Button = Nothing
    Private isLoading As Boolean = True

    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub HighlightButton(clickedButton As Button)
        If isLoading Then Exit Sub

        If activeButton IsNot Nothing Then
            activeButton.ForeColor = Color.White
            activeButton.BackColor = Color.Transparent
        End If

        clickedButton.ForeColor = Color.Black
        clickedButton.BackColor = Color.LightGray

        activeButton = clickedButton
    End Sub

    Private Sub btnBusesDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnBusesDetails.Click
        HighlightButton(btnBusesDetails)
        switchPanel(BusesRecords)
    End Sub

    Private Sub btnMaintenanceRecords_Click(sender As System.Object, e As System.EventArgs) Handles btnMaintenanceRecords.Click
        HighlightButton(btnMaintenanceRecords)
        switchPanel(MaintenanceRecords)
    End Sub

    Private Sub FormBuses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isLoading = False
        btnBusesDetails.PerformClick()
    End Sub
End Class