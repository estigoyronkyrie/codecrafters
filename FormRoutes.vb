Public Class FormRoutes
    Private activeButton As Button = Nothing
    Private isLoading As Boolean = True

    Sub switchPanel(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel4.Controls.Add(panel)
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
    Private Sub btnRouteDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnRouteDetails.Click
        HighlightButton(btnRouteDetails)
        switchPanel(RouteDetails)
    End Sub

    Private Sub btnBusesRecords_Click(sender As System.Object, e As System.EventArgs) Handles btnBusesRecords.Click
        HighlightButton(btnBusesRecords)
        switchPanel(RouteRecords)
    End Sub

    Private Sub FormRoutes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isLoading = False
        btnRouteDetails.PerformClick()
    End Sub
End Class