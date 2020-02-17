Imports System.Data.SqlClient
Module Module1
    Public CONN As SqlConnection
    Public DA As SqlDataAdapter
    Public DS As New DataSet
    Public CMD As SqlCommand
    Public DR As SqlDataReader
    Sub Koneksi()
        CONN = New SqlConnection("data source=srv4;initial catalog=INV ; User ID=sa;Password= ")
        If CONN.State = ConnectionState.Connecting Then
            CONN.Open()
        End If
    End Sub
End Module
