Imports System.Data.OleDb
Public Class adminDB_win
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""

    Function loadDGV()
        DataGridView1.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from winner_captain_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
        End While
        cn.Close()
        Return 0

    End Function
    Function loadDGV2()
        DataGridView2.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from winner_kagawad_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView2.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
        End While
        cn.Close()
        Return 0

    End Function

    Function loadDGV3()
        DataGridView3.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from winner_sec_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView3.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))


        End While
        cn.Close()

        Return 0

    End Function

    Function loadDGV4()
        DataGridView4.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from winner_tres_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView4.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))


        End While
        cn.Close()

        Return 0

    End Function

    Function loadDGV5()
        DataGridView5.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from winner_aud_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView5.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))


        End While
        cn.Close()

        Return 0

    End Function
    Private Sub adminDB_win_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDGV()
        loadDGV2()
        loadDGV3()
        loadDGV4()
        loadDGV5()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Printed!")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        adminDB_tally.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class