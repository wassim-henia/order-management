Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        deconnection()
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub AjouterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub AjouterToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub AjouterToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem3.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub ListesDesClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListesDesClientsToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub ListesDesFacturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListesDesFacturesToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub ListesDesFournisseursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListesDesFournisseursToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub ListesDesProduisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListesDesProduisToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        MsgBox("Ce projet a été realisé par Wassim Henia ", MessageBoxIcon.Information)
    End Sub
End Class
