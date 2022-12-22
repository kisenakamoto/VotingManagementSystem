Imports System.Data.OleDb
Public Class adminLogin
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim a As Boolean = False
    Function clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        Return 0
    End Function
    Function search()
        cn.ConnectionString = connection
        sql = ("select * from users_tbl where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            a = True
        End While
        cn.Close()
        Return 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub TextBox1_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub
    Private Sub TextBox2_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search()
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Then
            Label1.Text = "Incomplete Information"
        ElseIf a = False Then
            Label1.Text = "Wrong username of password"
        Else
            a = False
            MsgBox("Welcome Admin!")
            clear()
            Me.Hide()
            adminDB.Show()
        End If
    End Sub

    Private Sub adminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class