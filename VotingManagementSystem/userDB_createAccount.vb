Imports System.Data.OleDb
Public Class userDB_createAccount
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim k As New query
    Function clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Return 0
    End Function
    Function addToUsers()
        k.open("insert into users_tbl values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')")
        Return 0
    End Function
    Private Sub userDB_createAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox2_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
    End Sub
    Private Sub TextBox3_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles TextBox3.Click
        TextBox3.Clear()
        TextBox3.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Then
            MsgBox("Incomplete information!")
        Else
            addToUsers()
            MsgBox("Succesfully Created!")
            clear()
            Me.Hide()
            userDB_login.Show()

        End If
    End Sub
End Class