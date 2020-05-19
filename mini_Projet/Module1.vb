Imports System.Data.OleDb
Module MdConnexion
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public dta As OleDbDataAdapter

    Public MyConnection As New OleDbConnection()
    'procédure de connection a une bd access
    Public Sub connection(Optional nombd = "C:\Users\user\Desktop\wassim_henia\2LFSI\Semester 2\VB.net\Mini Projet\mini_Projet\mini_Projet\bin\mybase.accdb")

        Try
            MyConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" & nombd
            MyConnection.Open()
        Catch ex As Exception
            MessageBox.Show("Impossible d'établir la connection à la base." & ex.Message)
        End Try
    End Sub
    'deconenction de la base
    Public Sub deconnection()
        Try
            MyConnection.Close()

        Catch ex As Exception
            MessageBox.Show("Impossible d'établir la connection à la base." & ex.Message)
        End Try
    End Sub

    Public Sub insert(sql As String, nom As String)
        cmd = MyConnection.CreateCommand()
        cmd.CommandText = sql
        Dim Res As Integer = cmd.ExecuteNonQuery()
        If (Res = 0) Then
            MsgBox("Echec d'ajout", MsgBoxStyle.Information, "Ajouter un " + nom)
        Else
            MsgBox(nom + " ajouté avec succès", MsgBoxStyle.Information, "Ajouter un " + nom)
        End If
    End Sub


End Module
