Imports System.Data.SqlClient

Module Connection
    Public connString As String = "Server=LOVELY\SQLEXPRESS; Database=TicketingSystem; Trusted_Connection=True;"
    Public conn As New SqlConnection(connString)
    Public Parameters As New List(Of SqlParameter)
    Public Data As DataSet
    Public Datacount As Integer

    Public Sub OpenConn()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Sub AddParam(ByVal Key As String, ByVal value As Object)
        Parameters.Add(New SqlParameter(Key, If(value, DBNull.Value)))
    End Sub

    Public Function Insert(ByVal insertQuery As String) As Boolean
    Try
            OpenConn()
            Using command As New SqlCommand(insertQuery, conn)
                If Parameters.Count > 0 Then
                    command.Parameters.AddRange(Parameters.ToArray())
                    Parameters.Clear()
                End If

                Datacount = command.ExecuteNonQuery()
                Return Datacount > 0
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConn()
        End Try
    End Function

    Public Function Update(ByVal updateQuery As String) As Boolean
         Try
            OpenConn()
            Using command As New SqlCommand(updateQuery, conn)
                If Parameters.Count > 0 Then
                    command.Parameters.AddRange(Parameters.ToArray())
                    Parameters.Clear()
                End If

                Datacount = command.ExecuteNonQuery()
                Return Datacount > 0
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConn()
        End Try
    End Function

    Public Function Delete(ByVal deleteQuery As String) As Boolean
        Try
            OpenConn()
            Using command As New SqlCommand(deleteQuery, conn)
                If Parameters.Count > 0 Then
                    command.Parameters.AddRange(Parameters.ToArray())
                    Parameters.Clear()
                End If

                Datacount = command.ExecuteNonQuery()
                Return Datacount > 0
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConn()
        End Try
    End Function

    Private Function ExecuteNonQuery(ByVal query As String) As Boolean
        Try
            OpenConn()
            Using command As New SqlCommand(query, conn)
                If Parameters.Count > 0 Then
                    command.Parameters.AddRange(Parameters.ToArray())
                    Parameters.Clear()
                End If

                Datacount = command.ExecuteNonQuery()
                Return (Datacount > 0)
            End Using
        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConn()
        End Try
    End Function
End Module
