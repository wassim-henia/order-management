Public Class Form3
    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Dim sql As String
        sql = "Insert into fournisseur values ('" & TextBox1.Text & "','" &
                TextBox2.Text & "','" & TextBox3.Text & "','" &
                TextBox4.Text & "','" & TextBox5.Text & "') "
        insert(sql, "fournisseur")
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class