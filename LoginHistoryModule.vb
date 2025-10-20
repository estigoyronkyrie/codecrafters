Imports System.Data.SqlClient

Module LoginHistoryModule
    Public Sub SaveLoginHistory(fullname As String, username As String, userType As String)
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                Dim sql As String = "INSERT INTO LoginHistory (Fullname, Username, UserType, LoginTime) " &
                                    "VALUES (@Fullname, @Username, @UserType, @LoginTime)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Fullname", fullname)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@UserType", userType)
                    cmd.Parameters.AddWithValue("@LoginTime", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error saving login history: " & ex.Message,
                            "Login History Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateLogoutTime(username As String)
        If String.IsNullOrEmpty(username) Then Exit Sub

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                ' ✅ Update latest login record for this user where LogoutTime is still NULL
                Dim sql As String =
                    "UPDATE LoginHistory " &
                    "SET LogoutTime = @LogoutTime " &
                    "WHERE Username = @Username " &
                    "AND LogoutTime IS NULL " &
                    "AND LoginTime = (" &
                        "SELECT TOP 1 LoginTime FROM LoginHistory " &
                        "WHERE Username = @Username AND LogoutTime IS NULL " &
                        "ORDER BY LoginTime DESC" &
                    ")"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@LogoutTime", DateTime.Now)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating logout time: " & ex.Message,
                            "Logout Time Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
