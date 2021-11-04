Public Class Praktikum4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Single = CSng(txtScore.Text)

        Select Case score
            Case Is > 100
                MsgBox("Nilai tidak valid")
            Case Is > 90
                MsgBox("Grade : A")
            Case Is > 70
                MsgBox("Grade : B")
            Case Is > 60
                MsgBox("Grade : C")
            Case Is >= 50
                MsgBox("Grade : D")
            Case Is < 50
                MsgBox("Grade : E")
            Case Else
                MsgBox("Grade tidak valid")
        End Select

        Select Case Me.txtGrade.Text
            Case "A", "B"
                MsgBox("Lulus dengan nilai memuaskan")
            Case "C"
                MsgBox("Lulus dengan nilai cukup")
            Case "D", "E"
                MsgBox("Tidak lulus")
            Case Else
                MsgBox("Grade tidak valid")
        End Select
    End Sub
End Class