Imports System.Data.SqlClient
Public Class RouteRecords

    Private Sub LoadRouteDetails()
        Try
            OpenConn()
            Dim sql As String = "SELECT * FROM RouteRecords"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRouteRecords.DataSource = dt
            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error Loading Route Records: " & ex.Message)
        End Try
    End Sub
    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM RouteRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvRouteRecords.AutoGenerateColumns = True
                dgvRouteRecords.DataSource = Nothing
                dgvRouteRecords.DataSource = data
            End Using

            For Each col As DataGridViewColumn In dgvRouteRecords.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        Catch ex As Exception
            MsgBox("Error Loading data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub RouteRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadRouteDetails()
    End Sub

    Private Sub dgvRouteRecords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvRouteRecords.DataBindingComplete
        For Each col As DataGridViewColumn In dgvRouteRecords.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
End Class