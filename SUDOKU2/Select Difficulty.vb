Public Class Select_Difficulty
    Public n As Integer
    Private Sub Select_Difficulty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = 1
        Me.Hide()
        Game_On.Show()
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        n = 2
        Game_On.Show()
        Me.Hide()
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        n = 3
        Game_On.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        SUDOKU.Show()
    End Sub
End Class