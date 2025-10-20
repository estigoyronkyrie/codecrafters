Public Class FormTerminal
    Private activeButton As Button = Nothing
    Private isLoading As Boolean = True

    Sub switchPanel(ByVal panel As Form)
        Panel5.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel5.Controls.Add(panel)
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

    Private Sub btnTerminalDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminalDetails.Click
        HighlightButton(btnTerminalDetails)
        switchPanel(TerminalDetails)
    End Sub

    Private Sub btnTerminalRecords_Click(sender As System.Object, e As System.EventArgs) Handles btnTerminalRecords.Click
        HighlightButton(btnTerminalRecords)
        switchPanel(TerminalRecords)
    End Sub

    Private Sub FormTerminal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isLoading = False
        btnTerminalDetails.PerformClick()
    End Sub
End Class