
Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd = MyConnection.CreateCommand()
        cmd.CommandText = "select nomfournisseur,adresse from fournisseur"
        Try
            rd = cmd.ExecuteReader
            While rd.Read
                ComboBox1.Items.Add(rd.Item(0).ToString + "-" + rd.Item(1))

            End While
        Finally
            If rd IsNot Nothing Then rd.Close()
        End Try

    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Dim sql As String
        Dim aux, code As String
        aux = ComboBox1.SelectedItem()
        Dim words As String() = aux.Split(New Char() {"-"c})
        cmd = MyConnection.CreateCommand()
        cmd.CommandText = "select codefournisseur from fournisseur where nomfournisseur= '" & words(0) & "' and adresse = '" & words(1) & "'"
        rd = cmd.ExecuteReader
        If rd.Read Then
            code = (rd.Item(0).ToString)
        End If

        sql = "Insert into produit values ('" & TextBox1.Text & "','" &
                TextBox2.Text & "','" & TextBox3.Text & "','" &
                TextBox4.Text & "','" & code & "') "
        insert(sql, "produit")
    End Sub


End Class