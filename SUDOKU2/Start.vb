Public Class SUDOKU

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Select_Difficulty.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        How_To_Play.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Select_Difficulty.Show()
    End Sub
End Class