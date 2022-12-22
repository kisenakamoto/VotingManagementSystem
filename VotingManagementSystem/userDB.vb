Imports System.Data.OleDb
Public Class userDB
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim k As New query
    Dim a As Boolean
    Function clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        Return 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub
    Dim ad As String
    Function addToData()
        ad = TextBox7.Text
        k.open("insert into data_tbl values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "')")
        Return 0
    End Function
    Function search()
        cn.ConnectionString = connection
        sql = ("select * from data_tbl where voters_ID='" & TextBox1.Text & "'")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or TextBox4.Text.Trim = "" Or TextBox7.Text.Trim = "" Then
            MsgBox("Incomplete information!")
        ElseIf a = True Then
            MsgBox("Voter Already Exists!")
        Else
            a = False

            addToData()
                MsgBox("Succesfully added!")
                clear()
                Me.Hide()
                userDB_createAccount.Show()





        End If
    End Sub

    Private Sub userDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class