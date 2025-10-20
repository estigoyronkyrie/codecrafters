Public Class FormEmployee
    Private activeButton As Button = Nothing
    Private isLoading As Boolean = True

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel2.Controls.Add(panel)
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

    Private Sub btnEmployeeDetail_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployeeDetail.Click
        HighlightButton(btnEmployeeDetail)
        switchPanel(EmployeeDetails)
    End Sub

    Private Sub btnEmployeeRecord_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployeeRecord.Click
        HighlightButton(btnEmployeeRecord)
        switchPanel(EmployeeRecords)
    End Sub

    Private Sub FormEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isLoading = False
        btnEmployeeDetail.PerformClick()
    End Sub
End Class