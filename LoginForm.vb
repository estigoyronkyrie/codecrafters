Public Class LoginForm

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter both username and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim role As String
        If txtUsername.Text.Contains("admin") Then
            role = "Admin"
        Else
            role = "User"
        End If

        Dim formattedUsername As String = Utilities.FormatUsername(txtUsername.Text.Trim(), role)
        Dim loginResult As Integer = Utilities.Login(formattedUsername, txtPassword.Text.Trim())

        If loginResult = 1 OrElse loginResult = 2 Then
            ' ✅ Store current user info for login history
            Utilities.CurrentUser = formattedUsername
            Utilities.User_Type = role

            ' ✅ Get full name for saving to login history
            Dim fullName As String = Utilities.GetFullName(formattedUsername, role)

            ' ✅ Record login event
            LoginHistoryModule.SaveLoginHistory(fullName, formattedUsername, role)

            MessageBox.Show("Welcome " & role & " " & fullName & "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()

            ' ✅ Redirect to dashboard (admin or user)
            If loginResult = 1 Then
                AdminDashboard.Show()
            Else
                UserBookingDetails.Show()
            End If

        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub picboxExit_MouseEnter(sender As Object, e As EventArgs) Handles picboxExit.MouseEnter
        picboxExit.BackColor = Color.Red
        picboxExit.Cursor = Cursors.Hand
    End Sub

    Private Sub picboxExit_MouseLeave(sender As Object, e As EventArgs) Handles picboxExit.MouseLeave
        picboxExit.BackColor = Color.Transparent
        picboxExit.Cursor = Cursors.Default
    End Sub

    Private Sub picboxExit_Click_1(sender As System.Object, e As System.EventArgs) Handles picboxExit.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblUsername.Parent = PictureBox1
        lblUsername.BackColor = Color.Transparent
        lblPassword.Parent = PictureBox1
        lblPassword.BackColor = Color.Transparent
        PictureBox2.Parent = PictureBox1
        PictureBox2.BackColor = Color.Transparent
        lblVictoryLiner.Parent = PictureBox1
        lblVictoryLiner.BackColor = Color.Transparent
    End Sub
End Class
