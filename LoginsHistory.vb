Imports System.Data.SqlClient

Public Class LoginsHistory
    Private Sub LoginsHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoginHistory()
    End Sub

    Private Sub LoadLoginHistory()
        Try
            OpenConn()
            Dim sql As String = "SELECT ID, Fullname, Username, UserType, " & _
                    "FORMAT(LoginTime, 'MM/dd/yyyy hh:mm tt') AS LoginTime, " & _
                    "FORMAT(LogoutTime, 'MM/dd/yyyy hh:mm tt') AS LogoutTime " & _
                    "FROM LoginHistory " & _
                    "ORDER BY LoginTime DESC"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvLoginHistory.DataSource = dt

            If dgvLoginHistory.Columns.Contains("ID") Then
                dgvLoginHistory.Columns("ID").Visible = False
            End If

            If dgvLoginHistory.Columns.Contains("Fullname") Then
                dgvLoginHistory.Columns("Fullname").HeaderText = "Name"
            End If

            For Each col As DataGridViewColumn In dgvLoginHistory.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            dgvLoginHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error loading login history: " & ex.Message)
        End Try
    End Sub
End Class
