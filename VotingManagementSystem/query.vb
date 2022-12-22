Imports System.Data.OleDb
Public Class query
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""

    Function open(ByVal sql)
        cn.ConnectionString = connection
        Try
            cn.Open()
            Dim cmd As New OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Message")
        Finally
            cn.Close()
        End Try
        Return 0
    End Function
End Class