Imports System.Data.OleDb
Public Class adminDB_candidates
    Public connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\Voting.accdb;persist security info=false "
    Public cn As New OleDbConnection
    Dim sql As String = ""
    Dim p As Integer
    Dim k As New query
    Function loadDGV()
        DataGridView1.Rows.Clear()
        cn.ConnectionString = connection
        sql = ("select * from candidate_data_tbl")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5))
        End While
        cn.Close()
        Return 0

    End Function

    Private Sub adminDB_candidates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDGV()
    End Sub
    Function search()
        cn.ConnectionString = connection
        sql = ("select * from candidate_data_tbl where candidate_ID like '%" & TextBox11.Text & "%'")
        cn.Open()
        Dim cmd As New OleDbCommand(sql, cn)
        Dim r As OleDbDataReader
        r = cmd.ExecuteReader
        While r.Read
            DataGridView1.Rows.Add(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5))
        End While
        cn.Close()
        Return 0
    End Function

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
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
        TextBox12.Text = DataGridView1.Item(3, i).Value
        ComboBox1.Text = DataGridView1.Item(4, i).Value
        TextBox5.Text = DataGridView1.Item(5, i).Value




    End Sub
    Function clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        Return 0
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        clear()
    End Sub
    Function addToDB()
        k.open("insert into candidate_data_tbl values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox12.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "')")
        Return 0
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addToDB()
        MsgBox("Succesfully added!")
        clear()
        loadDGV()
    End Sub

    Dim full As String
    Dim z As Integer = 0
    Function addToPres()
        full = TextBox2.Text + ", " + TextBox12.Text + " " + TextBox3.Text
        k.open("insert into candidate_captain_tbl values('" & TextBox1.Text & "','" & full & "','" & z.ToString & "')")
        Return 0
    End Function
    Function addToVice()
        full = TextBox2.Text + ", " + TextBox12.Text + " " + TextBox3.Text
        k.open("insert into candidate_kagawad_tbl values('" & TextBox1.Text & "','" & full & "','" & z.ToString & "')")
        Return 0
    End Function
    Function addToSec()
        full = TextBox2.Text + ", " + TextBox12.Text + " " + TextBox3.Text
        k.open("insert into candidate_sec1_tbl values('" & TextBox1.Text & "','" & full & "','" & z.ToString & "')")
        Return 0
    End Function
    Function addToTres()
        full = TextBox2.Text + ", " + TextBox12.Text + " " + TextBox3.Text
        k.open("insert into candidate_tres1_tbl values('" & TextBox1.Text & "','" & full & "','" & z.ToString & "')")
        Return 0
    End Function
    Function addToAud()
        full = TextBox2.Text + ", " + TextBox12.Text + " " + TextBox3.Text
        k.open("insert into candidate_aud1_tbl values('" & TextBox1.Text & "','" & full & "','" & z.ToString & "')")
        Return 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or ComboBox1.Text.Trim = "" Or TextBox5.Text.Trim = "" Or TextBox12.Text.Trim = "" Then
            MsgBox("Incomplete information !")
        Else
            If ComboBox1.Text = "President" Then
                addToPres()
            ElseIf ComboBox1.Text = "Vice President" Then
                addToVice()
            ElseIf ComboBox1.Text = "Secretary" Then
                addToSec()
            ElseIf ComboBox1.Text = "Treasurer" Then
                addToTres()
            ElseIf ComboBox1.Text = "Auditor" Then
                addToAud()
            End If
            addToDB()
            MsgBox("Candidate Added!")
            loadDGV()
            clear()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        adminDB.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.RemoveAt(p)

    End Sub
    Function updateDB()
        k.open("update candidate_data_tbl set lastName = '" & TextBox2.Text & "', middleInitial ='" & TextBox3.Text & "', firstName = '" & TextBox12.Text & "' , position = '" & ComboBox1.Text & "' , course = '" & TextBox5.Text & "' , where candidate_ID='" & TextBox1.Text & "'")
        Return 0
    End Function
   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Or TextBox3.Text.Trim = "" Or ComboBox1.Text.Trim = "" Or TextBox5.Text.Trim = "" Then
            MsgBox("Incomplete information !")
        Else

            updateDB()
            MsgBox("Updated!")
            clear()
            loadDGV()

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class