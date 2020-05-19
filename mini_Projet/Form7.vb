Imports System.Data.OleDb
Public Class Form7
    Public commd As OleDbCommand

    Dim DtSet As New DataSet()
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label2.Text = "Code Facture "
            TextBox1.Visible = True
            DateTimePicker1.Visible = False
            ComboBox2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label2.Text = "Date Facture"
            DateTimePicker1.Visible = True
            TextBox1.Visible = False
            ComboBox2.Visible = False
            TextBox1.Text = ""

        Else
            Label2.Text = "Client"
            ComboBox2.Visible = True
            TextBox1.Visible = False
            DateTimePicker1.Visible = False
            TextBox1.Text = ""
            commd = MyConnection.CreateCommand()
            commd.CommandText = "select nomclient,prenomclient from client"
            Try
                rd = commd.ExecuteReader
                While rd.Read
                    ComboBox2.Items.Add(rd.Item(0).ToString + "-" + rd.Item(1))

                End While
            Finally
                If rd IsNot Nothing Then rd.Close()
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Close()
        Form1.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from facture"
        cmd = New OleDbCommand(sql)
        dta = New OleDbDataAdapter(cmd)
        cmd.Connection() = MyConnection
        dta.Fill(DtSet)
        DataGridView1.DataSource = DtSet.Tables(0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource.clear()
        If TextBox1.Text <> "" Then
            Dim sql As String = "select * from facture where codefacture= " & (TextBox1.Text)
            cmd = New OleDbCommand(sql)
            dta = New OleDbDataAdapter(cmd)
            cmd.Connection() = MyConnection
            dta.Fill(DtSet)
            DataGridView1.DataSource = DtSet.Tables(0)
        Else
            Dim sql As String = "select * from facture"
            cmd = New OleDbCommand(sql)
            dta = New OleDbDataAdapter(cmd)
            cmd.Connection() = MyConnection
            dta.Fill(DtSet)
            DataGridView1.DataSource = DtSet.Tables(0)
        End If



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim aux, code As String
        DataGridView1.DataSource.clear()
        aux = ComboBox2.SelectedItem()
        Dim words As String() = aux.Split(New Char() {"-"c})
        commd = MyConnection.CreateCommand()
        commd.CommandText = "select codeclient from client where nomclient = '" & words(0) & "' and prenomclient = '" & words(1) & "'"
        rd = commd.ExecuteReader
            While rd.Read
            code = (rd.Item(0))

        End While
        Dim sql As String = "select * from facture where codeclient=" & code
        cmd = New OleDbCommand(sql)
        dta = New OleDbDataAdapter(cmd)
        cmd.Connection() = MyConnection
        dta.Fill(DtSet)
        DataGridView1.DataSource = DtSet.Tables(0)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DataGridView1.DataSource.clear()
        Dim sql As String = "select * from facture where datefacture=#" & DateTimePicker1.Value.ToString("yyyy'/'MM'/'dd") & "#"

        cmd = New OleDbCommand(sql)
        dta = New OleDbDataAdapter(cmd)
        cmd.Connection() = MyConnection
        dta.Fill(DtSet)
        DataGridView1.DataSource = DtSet.Tables(0)

    End Sub
End Class