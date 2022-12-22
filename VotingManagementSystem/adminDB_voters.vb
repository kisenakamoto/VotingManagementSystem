Imports System.Data.OleDb
Public Class adminDB_voters
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim p As Integer
    Dim k As New query
    Function loadDGV()
        DataGridView1.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from data_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4))
        End While
        cn.Close()
        Return 0

    End Function

    Private Sub adminDB_voters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDGV()

    End Sub
    Function search()
        cn.ConnectionString = connection
        sql = ("select * from data_tbl where voters_ID like '%" & TextBox1.Text & "%'")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4))
        End While
        cn.Close()
        Return 0
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.Rows.Clear()
        search()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        p = DataGridView1.CurrentRow.Index

        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
       
        TextBox4.Text = DataGridView1.Item(3, i).Value
        TextBox7.Text = DataGridView1.Item(4, i).Value



    End Sub
    Function updateData()
        k.open("update data_tbl set lastName='" & TextBox2.Text & "',middleName='" & TextBox3.Text & "',firstName='" & TextBox4.Text & "',Course/Section = '" & TextBox7.Text & "'")
        Return 0
    End Function
    Function deleteData()
        DataGridView1.Rows.RemoveAt(p)
        Return 0
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        adminDB.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox4.Text.Trim = "" Or TextBox7.Text.Trim = "" Then
            MsgBox("Incomplte Information ! ")
        Else

            MsgBox("Updated Successfully ! ")

            loadDGV()
        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.RemoveAt(p)
    End Sub
End Class