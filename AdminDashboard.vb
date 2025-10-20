Public Class AdminDashboard
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


    Private Sub btnBuses_Click(sender As System.Object, e As System.EventArgs) Handles btnBuses.Click
        HighlightButton(btnBuses)
        switchPanel(FormBuses)
        FormBuses.btnBusesDetails.PerformClick()
    End Sub

    Private Sub btnTerminal_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminal.Click
        HighlightButton(btnTerminal)
        switchPanel(FormTerminal)
        FormTerminal.btnTerminalDetails.PerformClick()
    End Sub

    Private Sub btnAdmin_Click(sender As System.Object, e As System.EventArgs) Handles btnAdmin.Click
        HighlightButton(btnAdmin)
        switchPanel(AdminForm)
        AdminForm.btnAdminAccount.PerformClick()
    End Sub

    Private Sub btnEmployee_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEmployee.Click
        HighlightButton(btnEmployee)
        switchPanel(FormEmployee)
        FormEmployee.btnEmployeeDetail.PerformClick()
    End Sub

    Private Sub btnRoutes_Click(sender As System.Object, e As System.EventArgs) Handles btnRoutes.Click
        HighlightButton(btnRoutes)
        switchPanel(FormRoutes)
        FormRoutes.btnRouteDetails.PerformClick()
    End Sub

    Private Sub btnBooking_Click(sender As System.Object, e As System.EventArgs) Handles btnBooking.Click
        HighlightButton(btnBooking)
        switchPanel(FormBooking)
    End Sub

    Private Sub AdminDashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnAdmin.PerformClick()
        isLoading = False
    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?",
                                                      "Logout Confirmation",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            LoginHistoryModule.UpdateLogoutTime(Utilities.CurrentUser)
            Me.Hide()

            LoginForm.txtUsername.Clear()
            LoginForm.txtPassword.Clear()

            LoginForm.Show()
        End If
    End Sub
End Class