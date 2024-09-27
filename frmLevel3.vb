Public Class frmLevel3
    Private Sub FrmLevel3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLives.Text = "Lives Left: " & lives
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim rightAnswer As Boolean = rdbBestAnswer.Checked
        Dim chadAnswer As Boolean = rdbChad.Checked
        Dim soyAnswer As Boolean = rdbChad.Checked
        Dim krisAnswer As Boolean = rdbMark100.Checked
        If ((rightAnswer = True) And (chadAnswer = True) And (soyAnswer = True) And (krisAnswer = True)) Then
            Me.Hide()
            frmLevel4FinalExam.Show()
        Else
            lives -= 1
            MessageBox.Show("You Lost a Life: Check Your Answers!", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If lives = 0 Then
            MessageBox.Show("You Are Out of Lives!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            hasLost = True
            Me.Hide()
            frmOverviewFinalExam.Show()
        End If
        lblLives.Text = "Lives Left: " & lives
    End Sub

End Class