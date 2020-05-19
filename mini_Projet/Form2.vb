Public Class Form2
    Private Sub btnAjout_Click(sender As Object, e As EventArgs) Handles btnAjout.Click
        Dim sql As String
        Dim res As Integer
        res = MsgBox("Voulez vous vraiment ajouter ce Client ? ", MsgBoxStyle.YesNo, "Ajout")
        If res = vbYes Then
            sql = "Insert into client values ('" & TextBox1.Text & "','" &
                TextBox2.Text & "','" & TextBox3.Text & "','" &
                TextBox4.Text & "','" & TextBox5.Text & "') "
            insert(sql, "client")
            MsgBox("sure ? ", MsgBoxStyle.YesNo)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        deconnection()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class