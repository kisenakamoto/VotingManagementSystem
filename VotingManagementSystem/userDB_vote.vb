Imports System.Data.OleDb
Public Class userDB_vote
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim k As New query

    Dim cap As String
    Dim k1 As String
    Dim k2 As String
    Dim k3 As String
    Dim k4 As String
    Dim k5 As String
    Dim k6 As String
    Dim k7 As String
    Dim capV As Integer
    Dim kv1 As Integer
    Dim kv2 As Integer
    Dim kv3 As Integer
    Dim kv4 As Integer
    Dim kv5 As Integer
    Dim kv6 As Integer
    Dim kv7 As Integer
    Dim capNew As Integer
    Dim kn1 As Integer
    Dim kn2 As Integer
    Dim kn3 As Integer
    Dim kn4 As Integer
    Dim kn5 As Integer
    Dim kn6 As Integer
    Dim kn7 As Integer
    Function search()
        cn.ConnectionString = connection
        sql = ("select * from vote_tbl where voters_ID like '%" & TextBox1.Text & "%'")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6))
        End While
        cn.Close()
        Return 0
    End Function


    Function getVal()
        cap = ComboBox1.SelectedItem.ToString()
        k1 = ComboBox2.SelectedItem.ToString()
        k2 = ComboBox3.SelectedItem.ToString()
        k3 = ComboBox4.SelectedItem.ToString()
        k4 = ComboBox5.SelectedItem.ToString()

        Return 0
    End Function
    Function v1()
        cn.ConnectionString = connection
        cn.Open()
        sql = "select * from candidate_captain_tbl where candidateName='" & ComboBox1.Text & "'"
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            capV = Val(r.GetString(2))
        End While
        cn.Close()
        Return 0
    End Function
    Function v2()
        cn.ConnectionString = connection
        cn.Open()
        sql = "select * from candidate_kagawad_tbl where candidateName='" & ComboBox2.Text & "'"
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            kv1 = Val(r.GetString(2))
        End While
        cn.Close()
        Return 0
    End Function
    Function v3()
        cn.ConnectionString = connection
        cn.Open()
        sql = "select * from candidate_sec1_tbl where candidateName='" & ComboBox3.Text & "'"
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            kv2 = Val(r.GetString(2))
        End While
        cn.Close()
        Return 0
    End Function
    Function v4()
        cn.ConnectionString = connection
        cn.Open()
        sql = "select * from candidate_tres1_tbl where candidateName='" & ComboBox4.Text & "'"
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            kv3 = Val(r.GetString(2))
        End While
        cn.Close()
        Return 0
    End Function
    Function v5()
        cn.ConnectionString = connection
        cn.Open()
        sql = "select * from candidate_aud1_tbl where candidateName='" & ComboBox5.Text & "'"
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            kv4 = Val(r.GetString(2))
        End While
        cn.Close()
        Return 0
    End Function

    Function getAll()
        v1()
        v2()
        v3()
        v4()
        v5()

        Return 0
    End Function
    Function update1()
        capNew = capV + 1
        k.open("update candidate_captain_tbl set votes='" & capNew.ToString & "' where candidateName='" & ComboBox1.Text & "'")
        Return 0
    End Function
    Function update2()
        kn1 = kv1 + 1
        k.open("update candidate_kagawad_tbl set votes='" & kn1.ToString & "' where candidateName='" & ComboBox2.Text & "'")
        Return 0
    End Function
    Function update3()
        kn2 = kv2 + 1
        k.open("update candidate_sec1_tbl set votes='" & kn2.ToString & "' where candidateName='" & ComboBox3.Text & "'")
        Return 0
    End Function
    Function update4()
        kn3 = kv3 + 1
        k.open("update candidate_tres1_tbl set votes='" & kn3.ToString & "' where candidateName='" & ComboBox4.Text & "'")
        Return 0
    End Function
    Function update5()
        kn4 = kv4 + 1
        k.open("update candidate_aud1_tbl set votes='" & kn4.ToString & "' where candidateName='" & ComboBox5.Text & "'")
        Return 0
    End Function

    Function updateAll()
        update1()
        update2()
        update3()
        update4()
        update5()

        Return 0
    End Function
    Function addToVote()
        k.open("insert into vote_tbl values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & ComboBox5.Text & "','" & Now.ToShortDateString & "')")
        Return 0
    End Function
    Function loadCB1()

        cn.ConnectionString = connection
        sql = ("select * from candidate_captain_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            ComboBox1.Items.Add(r.GetString(1))
        End While
        cn.Close()
        Return 0

    End Function
    Function loadCB2()

        cn.ConnectionString = connection
        sql = ("select * from candidate_kagawad_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            ComboBox2.Items.Add(r.GetString(1))
        End While
        cn.Close()
        Return 0

    End Function

    Function loadCB3()

        cn.ConnectionString = connection
        sql = ("select * from candidate_sec1_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            ComboBox3.Items.Add(r.GetString(1))
        End While
        cn.Close()
        Return 0

    End Function

    Function loadCB4()

        cn.ConnectionString = connection
        sql = ("select * from candidate_tres1_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            ComboBox4.Items.Add(r.GetString(1))
        End While
        cn.Close()
        Return 0

    End Function

    Function loadCB5()

        cn.ConnectionString = connection
        sql = ("select * from candidate_aud1_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            ComboBox5.Items.Add(r.GetString(1))
        End While
        cn.Close()
        Return 0

    End Function

    Private Sub userDB_vote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCB1()
        loadCB2()
        loadCB3()
        loadCB4()
        loadCB5()
    End Sub
    Dim myMessageBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myMessageBox = MsgBox("Are you sure to submit your votes?", MsgBoxStyle.YesNo, "Confirmation")
        If myMessageBox = MsgBoxResult.Yes Then
            getVal()

            'Label4.Text = "Invalid"

            'If ComboBox2.Text.Equals(ComboBox3.Text) Or ComboBox2.Text.Equals(ComboBox4.Text) Or ComboBox2.Text.Equals(ComboBox5.Text) Or ComboBox2.Text.Equals(ComboBox6.Text) Or ComboBox2.Text.Equals(ComboBox7.Text) Or ComboBox2.Text.Equals(ComboBox8.Text) Then
            '    Label4.Text = "Identical Votes are invalid"
            'ElseIf k2.Equals(k1) Or k2.Equals(k3) Or k2.Equals(k4) Or k2.Equals(k5) Or k2.Equals(k6) Or k2.Equals(k7) Then
            '    Label4.Text = "Identical Votes are invalid"
            'ElseIf k3.Equals(k1) Or k3.Equals(k2) Or k3.Equals(k4) Or k3.Equals(k5) Or k3.Equals(k6) Or k3.Equals(k7) Then
            '    Label4.Text = "Identical Votes are invalid"
            'ElseIf k4.Equals(k1) Or k4.Equals(k2) Or k4.Equals(k3) Or k4.Equals(k5) Or k4.Equals(k6) Or k4.Equals(k7) Then
            '    Label4.Text = "Identical Votes are invalid"
            'ElseIf k5.Equals(k1) Or k5.Equals(k2) Or k5.Equals(k3) Or k5.Equals(k4) Or k5.Equals(k6) Or k5.Equals(k7) Then
            '    Label4.Text = "Identical Votes are invalid"
            'ElseIf k6.Equals(k1) Or k6.Equals(k2) Or k6.Equals(k3) Or k6.Equals(k4) Or k6.Equals(k5) Or k6.Equals(k7) Then
            '    Label4.Text = "Identical Votes are invalid"
            'ElseIf k7.Equals(k1) Or k7.Equals(k2) Or k7.Equals(k3) Or k7.Equals(k4) Or k7.Equals(k5) Or k7.Equals(k6) Then
            '    Label4.Text = "Identical Votes are invalid"
            'Else
            getAll()
            updateAll()
            addToVote()
            MsgBox("Your Vote has Successfully added ! ")
            search()

        Else
            MsgBox("You can re edit your votes")
        End If


        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Printing.")
        Me.Hide()
        Form1.Show()
    End Sub
End Class