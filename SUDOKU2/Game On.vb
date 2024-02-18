Public Class Game_On
    Dim level As Integer
    Dim num As Integer
    Dim intRandValue As New System.Random
    Dim loc As Integer(,) = {{9, 9, 9, 9, 9, 9, 9, 9, 9}, {9, 9, 9, 9, 9, 9, 9, 9, 9}, {9, 9, 9, 9, 9, 9, 9, 9, 9}, {9, 9, 9, 9, 9, 9, 9, 9, 9},
                             {9, 9, 9, 9, 9, 9, 9, 9, 9}, {9, 9, 9, 9, 9, 9, 9, 9, 9}, {9, 9, 9, 9, 9, 9, 9, 9, 9}, {9, 9, 9, 9, 9, 9, 9, 9, 9},
                             {9, 9, 9, 9, 9, 9, 9, 9, 9}}
    Dim ngs As Integer(,) = {{0, 2, 4}, {2, 4, 0}, {4, 0, 2}, {0, 4, 2}, {4, 2, 0}, {2, 0, 4}, {1, 3, 5}, {3, 5, 1}, {5, 1, 3}, {1, 5, 3}, {5, 3, 1}, {3, 1, 5}}
    Dim ng As Integer() = {0, 0, 0}
    Dim n(9) As Integer
    Dim a1 As Integer(,) = {{0, 1, 2}, {0, 2, 1}, {1, 2, 0}, {1, 0, 2}, {2, 0, 1}, {2, 1, 0}}
    Dim a2 As Integer(,) = {{3, 4, 5}, {3, 5, 4}, {4, 5, 3}, {4, 3, 5}, {5, 3, 4}, {5, 4, 3}}
    Dim a3 As Integer(,) = {{6, 7, 8}, {6, 8, 7}, {7, 8, 6}, {7, 6, 8}, {8, 6, 7}, {8, 7, 6}}
    Dim ans As Integer(,) = {{0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0},
                             {0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0, 0},
                             {0, 0, 0, 0, 0, 0, 0, 0, 0}}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As MsgBoxResult = MsgBox("You will lose all current game. Are you sure you want to leave?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            Me.Close()
            Select_Difficulty.Show()
        End If
    End Sub

    Public Sub Game_On_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tb As TextBox(,) = {{tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9}, {tb10, tb11, tb12, tb13, tb14, tb15, tb16, tb17, tb18},
                                {tb19, tb20, tb21, tb22, tb23, tb24, tb25, tb26, tb27}, {tb28, tb29, tb30, tb31, tb32, tb33, tb34, tb35, tb36},
                                {tb37, tb38, tb39, tb40, tb41, tb42, tb43, tb44, tb45}, {tb46, tb47, tb48, tb49, tb50, tb51, tb52, tb53, tb54},
                                {tb55, tb56, tb57, tb58, tb59, tb60, tb61, tb62, tb63}, {tb64, tb65, tb66, tb67, tb68, tb69, tb70, tb71, tb72},
                                {tb73, tb74, tb75, tb76, tb77, tb78, tb79, tb80, tb81}}
        Dim txt As TextBox() = {tb0, tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9, tb10, tb11, tb12, tb13, tb14,
            tb15, tb16, tb17, tb18, tb19, tb20, tb21, tb22, tb23, tb24, tb25, tb26, tb27, tb28, tb29, tb30,
                    tb31, tb32, tb33, tb34, tb35, tb36, tb37, tb38, tb39, tb40, tb41, tb42, tb43, tb44, tb45, tb46,
                    tb47, tb48, tb49, tb50, tb51, tb52, tb53, tb54, tb55, tb56, tb57, tb58, tb59, tb60, tb61, tb62,
                    tb63, tb64, tb65, tb66, tb67, tb68, tb69, tb70, tb71, tb72, tb73, tb74, tb75, tb76, tb77, tb78,
                    tb79, tb80, tb81}
        '''''''''''''''''''''''''''''''''''''''''generating array of location START'''''''''''''''''''''''''''''''''''''''''''''        
        Dim randno As Integer = intRandValue.Next(0, 12)
        For i = 0 To 2
            ng(i) = ngs(randno, i)
        Next
        Dim m As Integer = 0
        Dim o As Integer = 0
        While m < 7
            fa1(m, ng(o))
            fa2(m, ng(o))
            fa3(m, ng(o))
            m += 3
            o += 1
        End While
        m = 1
        o = 0
        While m < 8
            fa2(m, ng(o))
            fa3(m, ng(o))
            fa1(m, ng(o))
            m += 3
            o += 1
        End While
        m = 2
        o = 0
        While m < 9
            fa3(m, ng(o))
            fa1(m, ng(o))
            fa2(m, ng(o))
            m += 3
            o += 1
        End While
        ''''''''''''''''''''''''''''''''''''''''generating array of location END'''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''generating array of numbers START'''''''''''''''''''''''''''''''''''''''''''''
        For r = 0 To 8
l0:         Dim ng As Integer = intRandValue.Next(1, 10)
            For rc = 0 To 8
                If rc <> r And n(rc) = ng Then
                    GoTo l0
                Else
                    n(r) = ng
                End If
            Next
        Next
        ''''''''''''''''''''''''''''''''''''''''generating array of numbers END'''''''''''''''''''''''''''''''''''''''''''''        
        '''''''''''''''''''''''''''''''''''''''''filling the boxes START'''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For c = 0 To 8
            For r = 0 To 8
                tb(r, loc(c, r)).Text = n(c)
            Next
        Next
        ''''''''''''''''''''''''''''''''''''''''filling the boxes END''''''''''''''''''''''''''''''''''''''''''''''''''''''        
        ''''''''''''''''''''''''''''''''''''''''filling answer sheet START''''''''''''''''''''''''''''''''''''''''''''''''''
        For i = 0 To 8
            For j = 0 To 8
                ans(i, j) = tb(i, j).Text
            Next
        Next
        ''''''''''''''''''''''''''''''''''''''''filling answer sheet END''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''setting question START''''''''''''''''''''''''''''''''''''''''''''''''''''''        
        If Select_Difficulty.n = 1 Then
            tb01.Text = "BEGINNER"
            level = 59
        ElseIf Select_Difficulty.n = 2 Then
            tb01.Text = "MODERATE"
            level = 39
        ElseIf Select_Difficulty.n = 3 Then
            tb01.Text = "EXPERT"
            level = 19
        End If
        For a = 0 To level
            Dim no As Integer = intRandValue.Next(0, 81)
            txt(no).ReadOnly = True
        Next
        For i = 0 To 81
            If txt(i).ReadOnly = True Then
                Continue For
            Else
                txt(i).Text = ""
            End If
        Next
        ''''''''''''''''''''''''''''''''''''''''setting question END''''''''''''''''''''''''''''''''''''''''''''''''''''''        
    End Sub
    Private Function fa1(ByVal a, ByVal b)
        Dim j As Integer = 0
        Dim i As Integer = 0
        While i < 3 And j < 7
            If a = 0 Or a = 3 Or a = 6 Then
                loc(a, j) = a1(b, i)
            ElseIf a = 1 Or a = 4 Or a = 7 Then
                loc(a, j) = a2(b, i)
            Else
                loc(a, j) = a3(b, i)
            End If
            i += 1
            j += 3
        End While
    End Function
    Private Function fa2(ByVal a, ByVal b)
        Dim j As Integer = 1
        Dim i As Integer = 0
        While i < 3 And j < 8
            If a = 0 Or a = 3 Or a = 6 Then
                loc(a, j) = a2(b, i)
            ElseIf a = 1 Or a = 4 Or a = 7 Then
                loc(a, j) = a3(b, i)
            Else
                loc(a, j) = a1(b, i)
            End If
            i += 1
            j += 3
        End While
    End Function
    Private Function fa3(ByVal a, ByVal b)
        Dim j As Integer = 2
        Dim i As Integer = 0
        While i < 3 And j < 9
            If a = 0 Or a = 3 Or a = 6 Then
                loc(a, j) = a3(b, i)
            ElseIf a = 1 Or a = 4 Or a = 7 Then
                loc(a, j) = a1(b, i)
            Else
                loc(a, j) = a2(b, i)
            End If
            i += 1
            j += 3
        End While
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tb As TextBox(,) = {{tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9}, {tb10, tb11, tb12, tb13, tb14, tb15, tb16, tb17, tb18},
                                {tb19, tb20, tb21, tb22, tb23, tb24, tb25, tb26, tb27}, {tb28, tb29, tb30, tb31, tb32, tb33, tb34, tb35, tb36},
                                {tb37, tb38, tb39, tb40, tb41, tb42, tb43, tb44, tb45}, {tb46, tb47, tb48, tb49, tb50, tb51, tb52, tb53, tb54},
                                {tb55, tb56, tb57, tb58, tb59, tb60, tb61, tb62, tb63}, {tb64, tb65, tb66, tb67, tb68, tb69, tb70, tb71, tb72},
                                {tb73, tb74, tb75, tb76, tb77, tb78, tb79, tb80, tb81}}
        For c = 0 To 8
            For r = 0 To 8
                If tb(c, r).ReadOnly = False Then
                    tb(c, r).Text = ans(c, r)
                    tb(c, r).ReadOnly = True
                    tb(c, r).BackColor = Color.LimeGreen
                    Exit Sub
                End If
            Next
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click '''''''''''''''''''''''''''''''CHECK BUTTON
        Dim tb As TextBox(,) = {{tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9}, {tb10, tb11, tb12, tb13, tb14, tb15, tb16, tb17, tb18},
                                {tb19, tb20, tb21, tb22, tb23, tb24, tb25, tb26, tb27}, {tb28, tb29, tb30, tb31, tb32, tb33, tb34, tb35, tb36},
                                {tb37, tb38, tb39, tb40, tb41, tb42, tb43, tb44, tb45}, {tb46, tb47, tb48, tb49, tb50, tb51, tb52, tb53, tb54},
                                {tb55, tb56, tb57, tb58, tb59, tb60, tb61, tb62, tb63}, {tb64, tb65, tb66, tb67, tb68, tb69, tb70, tb71, tb72},
                                {tb73, tb74, tb75, tb76, tb77, tb78, tb79, tb80, tb81}}
        Dim result As Boolean
        For c = 0 To 8
            For r = 0 To 8
                If tb(c, r).Text = ans(c, r).ToString Then
                    result = True
                Else
                    result = False
                End If
            Next
        Next
        If result = True Then
            MsgBox("CONGRATULATIONS")
        Else
            MsgBox("OPPS !!! TRY AGAIN")
        End If
    End Sub
End Class