Imports System.Data.SqlClient

Public Class UserAccounts
    Private Sub FormAdminTab3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadUsersList()
        dgvUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUserList.MultiSelect = False
        dgvUserList.ReadOnly = True
    End Sub
    Private Sub LoadUsersList()
       Try
            OpenConn()
            Dim query As String = "SELECT User_Id, Fullname, Username, Password, FORMAT(date_created, 'MM/dd/yyyy hh:mm tt') AS DateCreated FROM Users"
            Dim cmd As New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvUserList.DataSource = dt
            dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If dgvUserList.Columns.Contains("User_Id") Then
                dgvUserList.Columns("User_Id").Visible = False
            End If

            If dgvUserList.Columns.Contains("Fullname") Then dgvUserList.Columns("Fullname").HeaderText = "Name"
            If dgvUserList.Columns.Contains("Username") Then dgvUserList.Columns("Username").HeaderText = "Username"
            If dgvUserList.Columns.Contains("Password") Then dgvUserList.Columns("Password").HeaderText = "Password"
            If dgvUserList.Columns.Contains("DateCreated") Then dgvUserList.Columns("DateCreated").HeaderText = "Date Created"

            For Each col As DataGridViewColumn In dgvUserList.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading user list: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConn()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim username As String = txtUsername.Text.Trim()

        If Not username.EndsWith("@victoryliner.com") Then
            MsgBox("Username must end with @victoryliner.com.", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
            Exit Sub
        End If

        Dim createdAt As DateTime = DateTime.Now
        Dim formattedUsername As String = username
        Dim fullname As String = ToTitleCase(txtFullname.Text.Trim())

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Users (Fullname, Username, Password, date_created) VALUES (@Fullname, @Username, @Password, @DateCreated)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Fullname", fullname)
                    cmd.Parameters.AddWithValue("@Username", formattedUsername)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@DateCreated", createdAt)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("User Account added successfully.", MsgBoxStyle.Information)
                ClearFields()
                LoadUsersList()
            Catch ex As Exception
                MsgBox("Error Adding User: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using

    End Sub

    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM Users"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvUserList.DataSource = data
            End Using
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ClearFields()
        txtFullname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If dgvUserList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvUserList.SelectedRows(0)

            Dim id As Integer = Convert.ToInt32(row.Cells("User_Id").Value)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Using conn As New SqlConnection(connString)
                    Try
                        conn.Open()
                        Dim query As String = "DELETE FROM Users WHERE [User_Id] = @Id"

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Id", id)
                            cmd.ExecuteNonQuery()
                        End Using

                        MsgBox("Record deleted successfully.", MsgBoxStyle.Information)
                        viewdata()

                    Catch ex As Exception
                        MsgBox("Error deleting record: " & ex.Message, MsgBoxStyle.Critical)
                    End Try
                End Using
            End If
        Else
            MsgBox("Please select a record to delete.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If dgvUserList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvUserList.SelectedRows(0)
            Dim userId As Integer = Convert.ToInt32(row.Cells("User_Id").Value)

            Dim username As String = txtUsername.Text.Trim()
            If Not username.EndsWith("@victoryliner.com") Then
                MsgBox("Username must end with @victoryliner.com.", MsgBoxStyle.Exclamation)
                txtUsername.Focus()
                Exit Sub
            End If

            Dim formattedUsername As String = username
            Dim fullname As String = ToTitleCase(txtFullname.Text.Trim())

            Try
                OpenConn()
                Dim query As String = "UPDATE Users SET Fullname=@Fullname, Username=@Username, Password=@Password WHERE User_Id=@UserId"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Fullname", fullname)
                    cmd.Parameters.AddWithValue("@Username", formattedUsername)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@UserId", userId)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Record updated successfully!", MsgBoxStyle.Information)
                LoadUsersList()
            Catch ex As Exception
                MsgBox("Error updating record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConn()
            End Try
        Else
            MsgBox("Please select a record to update.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If dgvUserList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvUserList.SelectedRows(0)

            txtFullname.Text = Convert.ToString(row.Cells("Fullname").Value)
            txtUsername.Text = Convert.ToString(row.Cells("Username").Value)
            txtPassword.Text = Convert.ToString(row.Cells("Password").Value)
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtFullname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Focus()
        dgvUserList.ClearSelection()
    End Sub

    Private Function ToTitleCase(text As String) As String
        Return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower())
    End Function

    Private Sub txtFullname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFullname.TextChanged
        Dim selStart As Integer = txtFullname.SelectionStart
        txtFullname.Text = ToTitleCase(txtFullname.Text)
        txtFullname.SelectionStart = selStart
    End Sub
End Class