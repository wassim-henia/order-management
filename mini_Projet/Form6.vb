Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Form6
    Dim DtSet As New DataSet()
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from client"
        cmd = New OleDbCommand(sql)
        dta = New OleDbDataAdapter(cmd)
        cmd.Connection() = MyConnection
        dta.Fill(DtSet)
        DataGridView1.DataSource = DtSet.Tables(0)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Close()
        Form1.Show()
    End Sub

    Private Sub btnsupp_Click(sender As Object, e As EventArgs) Handles btnsupp.Click
        Dim aux As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim sql As String = "delete * from client where codeclient=" & aux
        DtSet = New DataSet
        dta = New OleDbDataAdapter(sql, MyConnection)
        dta.Fill(DtSet)
        MsgBox("Ligne supprimée")
        sql = "select * from client"
        cmd = New OleDbCommand(sql)
        dta = New OleDbDataAdapter(cmd)
        cmd.Connection() = MyConnection
        dta.Fill(DtSet)
        DataGridView1.DataSource = DtSet.Tables(0)
    End Sub

    Private Sub btnmodif_Click(sender As Object, e As EventArgs) Handles btnmodif.Click
        Dim Sql As String = "select * from client"
        cmd = New OleDbCommand(Sql)
        dta = New OleDbDataAdapter(cmd)
        Dim cb = New OleDbCommandBuilder(dta)
        cmd.Connection() = MyConnection
        dta.Update(DtSet)
        MsgBox("Ligne modifiée")
        DataGridView1.DataSource = DtSet.Tables(0)
    End Sub


End Class