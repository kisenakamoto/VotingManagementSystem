Imports System.ComponentModel
Imports System.Data.OleDb
Public Class adminDB_tally
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim nums As Integer
    Dim k As New query
    Function addCapWin()
        Dim nums As Integer = 0
        k.open("insert into winner_captain_tbl values('" & DataGridView1.Item(0, nums).Value.ToString & "','" & DataGridView1.Item(1, nums).Value.ToString & "','" & DataGridView1.Item(2, nums).Value.ToString & "' )")


        Return 0
    End Function
    Function addKagWin()
        Dim nums As Integer = 0
        k.open("insert into winner_kagawad_tbl values('" & DataGridView2.Item(0, nums).Value.ToString & "','" & DataGridView2.Item(1, nums).Value.ToString & "','" & DataGridView2.Item(2, nums).Value.ToString & "' )")

        Return 0
    End Function

    Function addSecWin()
        Dim nums As Integer = 0
        k.open("insert into winner_sec_tbl values('" & DataGridView3.Item(0, nums).Value.ToString & "','" & DataGridView3.Item(1, nums).Value.ToString & "','" & DataGridView3.Item(2, nums).Value.ToString & "' )")

        Return 0
    End Function

    Function addTresWin()
        Dim nums As Integer = 0
        k.open("insert into winner_tres_tbl values('" & DataGridView4.Item(0, nums).Value.ToString & "','" & DataGridView4.Item(1, nums).Value.ToString & "','" & DataGridView4.Item(2, nums).Value.ToString & "' )")

        Return 0
    End Function

    Function addAudWin()
        Dim nums As Integer = 0
        k.open("insert into winner_aud_tbl values('" & DataGridView5.Item(0, nums).Value.ToString & "','" & DataGridView5.Item(1, nums).Value.ToString & "','" & DataGridView5.Item(2, nums).Value.ToString & "' )")

        Return 0
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addCapWin()
        addKagWin()
        addSecWin()
        addTresWin()
        addAudWin()
        MsgBox("Successfully Tallied Won Candidates")
        Me.Hide()
        adminDB_win.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Format(Now, "hh:mm:ss")
        Label4.Text = Format(Now, "MMM/dd/yyyy")
    End Sub
    Function loadDGV()
        DataGridView1.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from candidate_captain_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
            DataGridView1.Sort(DataGridView1.Columns(2), ListSortDirection.Ascending)
        End While
        cn.Close()

        Return 0

    End Function


    Function loadDGV2()
        DataGridView2.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from candidate_kagawad_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView2.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
            DataGridView2.Sort(DataGridView2.Columns(2), ListSortDirection.Ascending)

        End While
        cn.Close()

        Return 0

    End Function

    Function loadDGV3()
        DataGridView3.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from candidate_sec1_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView3.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
            DataGridView3.Sort(DataGridView3.Columns(2), ListSortDirection.Ascending)

        End While
        cn.Close()

        Return 0

    End Function

    Function loadDGV4()
        DataGridView4.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from candidate_tres1_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView4.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
            DataGridView4.Sort(DataGridView4.Columns(2), ListSortDirection.Ascending)

        End While
        cn.Close()

        Return 0

    End Function

    Function loadDGV5()
        DataGridView5.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from candidate_aud1_tbl ")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView5.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2))
            DataGridView5.Sort(DataGridView5.Columns(2), ListSortDirection.Ascending)

        End While
        cn.Close()

        Return 0

    End Function

    Private Sub adminDB_tally_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDGV()
        loadDGV2()
        loadDGV3()
        loadDGV4()
        loadDGV5()

        DataGridView1.Sort(DataGridView1.Columns(2), ListSortDirection.Descending)
        DataGridView2.Sort(DataGridView2.Columns(2), ListSortDirection.Descending)
        DataGridView3.Sort(DataGridView3.Columns(2), ListSortDirection.Descending)
        DataGridView4.Sort(DataGridView4.Columns(2), ListSortDirection.Descending)
        DataGridView5.Sort(DataGridView5.Columns(2), ListSortDirection.Descending)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        adminDB.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class