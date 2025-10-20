Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Module Utilities
    Public CurrentUser As String = ""
    Public CurrentUserType As String = ""
    Public User_Type As String

    Public Function Login(username As String, password As String) As Integer
        Try
            OpenConn()
            Dim cmdAdmin As New SqlCommand("SELECT fullname FROM Admins WHERE username=@username AND password=@password", conn)
            cmdAdmin.Parameters.AddWithValue("@username", username)
            cmdAdmin.Parameters.AddWithValue("@password", password)
            Dim dr As SqlDataReader = cmdAdmin.ExecuteReader()

            If dr.Read() Then
                CurrentUser = dr("fullname").ToString()
                CurrentUserType = "Admin"
                dr.Close()
                CloseConn()
                Return 1
            End If
            dr.Close()

            ' Check Users
            Dim cmdUser As New SqlCommand("SELECT fullname FROM Users WHERE username=@username AND password=@password", conn)
            cmdUser.Parameters.AddWithValue("@username", username)
            cmdUser.Parameters.AddWithValue("@password", password)
            Dim dr2 As SqlDataReader = cmdUser.ExecuteReader()

            If dr2.Read() Then
                CurrentUser = dr2("fullname").ToString()
                CurrentUserType = "User"
                dr2.Close()
                CloseConn()
                Return 2
            End If
            dr2.Close()

            CloseConn()
            Return 0

        Catch ex As Exception
            MessageBox.Show("Error (Login): " & ex.Message)
            Return 0
        End Try
    End Function

    Public Function FormatUsername(baseUsername As String, role As String) As String
        Dim username As String = baseUsername.Trim()

        Select Case role
            Case "Admin"
                If Not username.EndsWith(".admin@victoryliner.com") Then
                    username &= ".admin@victoryliner.com"
                End If
            Case "User"
                If Not username.EndsWith("@victoryliner.com") Then
                    username &= "@victoryliner.com"
                End If
        End Select

        Return username
    End Function

    Public Function DeleteBooking(bookingNumber As String) As Boolean
        Dim success As Boolean = False
        Dim query As String = "DELETE FROM BookingRecords WHERE BookingNumber=@BookingNumber"

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@BookingNumber", bookingNumber)
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    success = (rows > 0)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error Deleting Booking Record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return success
    End Function

    Public Function GetFullName(username As String, userType As String) As String
        Dim fullName As String = ""
        Try
            OpenConn()
            Dim tableName As String = If(userType = "Admin", "Admins", "Users")
            Dim query As String = "SELECT fullname FROM " & tableName & " WHERE username=@username"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    fullName = result.ToString()
                End If
            End Using
            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error getting full name: " & ex.Message)
        End Try
        Return fullName
    End Function
End Module