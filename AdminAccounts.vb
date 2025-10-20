Imports System.Data.SqlClient

Public Class AdminAccounts
    Private Sub FormAdminTab2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadAdminList()
        dgvAdminList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAdminList.MultiSelect = False
        dgvAdminList.ReadOnly = True
    End Sub
    Private Sub LoadAdminList()
         Try
            OpenConn()
            Dim query As String = "SELECT Admin_Id, Fullname, Username, Password, FORMAT(date_created, 'MM/dd/yyyy hh:mm tt') AS DateCreated FROM Admins"
            Dim cmd As New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgvAdminList.DataSource = dt
            dgvAdminList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvAdminList.ReadOnly = True
            dgvAdminList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvAdminList.MultiSelect = False

            If dgvAdminList.Columns.Contains("Admin_Id") Then
                dgvAdminList.Columns("Admin_Id").Visible = False
            End If

            If dgvAdminList.Columns.Contains("Fullname") Then dgvAdminList.Columns("Fullname").HeaderText = "Name"
            If dgvAdminList.Columns.Contains("Username") Then dgvAdminList.Columns("Username").HeaderText = "Username"
            If dgvAdminList.Columns.Contains("Password") Then dgvAdminList.Columns("Password").HeaderText = "Password"
            If dgvAdminList.Columns.Contains("DateCreated") Then dgvAdminList.Columns("DateCreated").HeaderText = "Date Created"

            For Each col As DataGridViewColumn In dgvAdminList.Columns
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

        If Not username.EndsWith(".admin@victoryliner.com") Then
            MsgBox("Admin username must end with '.admin@victoryliner.com'.", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
            Exit Sub
        End If

        Dim createdAt As DateTime = DateTime.Now
        Dim fullname As String = ToTitleCase(txtFullname.Text.Trim())

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Admins (Fullname, Username, Password, date_created) VALUES (@Fullname, @Username, @Password, @DateCreated)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Fullname", fullname)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@DateCreated", createdAt)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Admin Account added successfully.", MsgBoxStyle.Information)
                ClearFields()
                LoadAdminList()
            Catch ex As Exception
                MsgBox("Error Adding Admin: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using
    End Sub

    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM Admins"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvAdminList.DataSource = data
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

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        If dgvAdminList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvAdminList.SelectedRows(0)

            txtFullname.Text = Convert.ToString(row.Cells("Fullname").Value)
            txtUsername.Text = Convert.ToString(row.Cells("Username").Value)
            txtPassword.Text = Convert.ToString(row.Cells("Password").Value)
        Else
            MsgBox("Please select a record to edit.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If dgvAdminList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvAdminList.SelectedRows(0)
            Dim AdminId As Integer = Convert.ToInt32(row.Cells("Admin_Id").Value)

            Dim username As String = txtUsername.Text.Trim()

            If Not username.EndsWith(".admin@victoryliner.com") Then
                MsgBox("Admin username must end with '.admin@victoryliner.com'.", MsgBoxStyle.Exclamation)
                txtUsername.Focus()
                Exit Sub
            End If

            Dim fullname As String = ToTitleCase(txtFullname.Text.Trim())

            Try
                OpenConn()
                Dim query As String = "UPDATE Admins SET Fullname=@Fullname, Username=@Username, Password=@Password WHERE Admin_Id=@AdminId"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Fullname", fullname)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                    cmd.Parameters.AddWithValue("@AdminId", AdminId)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Record updated successfully!", MsgBoxStyle.Information)
                LoadAdminList()
            Catch ex As Exception
                MsgBox("Error updating record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                CloseConn()
            End Try
        Else
            MsgBox("Please select a record to update.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If dgvAdminList.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvAdminList.SelectedRows(0)


            Dim id As Integer = Convert.ToInt32(row.Cells("Admin_Id").Value)

            If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Using conn As New SqlConnection(connString)
                    Try
                        conn.Open()
                        Dim query As String = "DELETE FROM Admins WHERE [Admin_Id] = @Id"

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

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtFullname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Focus()
        dgvAdminList.ClearSelection()
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
