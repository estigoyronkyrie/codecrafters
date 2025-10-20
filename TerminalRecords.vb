Imports System.Data.SqlClient

Public Class TerminalRecords
    Private Sub LoadTerminalDetails()
        Try
            OpenConn()
            Dim sql As String = "SELECT * FROM TerminalRecords"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvTerminalRecords.DataSource = dt
            CloseConn()
        Catch ex As Exception
            MessageBox.Show("Error Loading Bus Records: " & ex.Message)
        End Try
    End Sub
    Sub viewdata()
        Try
            Dim sql As String = "SELECT * FROM TerminalRecords"
            Using conn As New SqlConnection(connString)
                Dim adapter As New SqlDataAdapter(sql, conn)
                Dim data As New DataTable()
                adapter.Fill(data)
                dgvTerminalRecords.AutoGenerateColumns = True
                dgvTerminalRecords.DataSource = Nothing
                dgvTerminalRecords.DataSource = data
            End Using

            For Each col As DataGridViewColumn In dgvTerminalRecords.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next
        Catch ex As Exception
            MsgBox("Error Loading Data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BusesRecords_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadTerminalDetails()
    End Sub

    Private Sub dgvTerminalRecords_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvTerminalRecords.DataBindingComplete
        For Each col As DataGridViewColumn In dgvTerminalRecords.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
End Class