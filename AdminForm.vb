Public Class AdminForm
    Private activeButton As Button = Nothing
    Private isLoading As Boolean = True

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel1.Controls.Add(panel)
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

    Private Sub btnAdminAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnAdminAccount.Click
        HighlightButton(btnAdminAccount)
        switchPanel(AdminAccounts)
    End Sub

    Private Sub btnLoginHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnLoginHistory.Click
        HighlightButton(btnLoginHistory)
        switchPanel(LoginsHistory)
    End Sub

    Private Sub btnUserAccount_Click(sender As System.Object, e As System.EventArgs) Handles btnUserAccount.Click
        HighlightButton(btnUserAccount)
        switchPanel(UserAccounts)
    End Sub

    Private Sub AdminForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isLoading = False
        btnAdminAccount.PerformClick()
    End Sub
End Class