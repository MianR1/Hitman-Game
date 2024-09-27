Public Class frmLevel1
    Private Sub FrmLevel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLives.Text = "Lives Left: " & lives
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim userAnswer As String
        userAnswer = (txtUser.Text).ToUpper

        Select Case userAnswer
            Case "A DECK OF CARDS"
                Me.Hide()
                frmLevel2.Show()
            Case "DECK OF CARDS"
                Me.Hide()
                frmLevel2.Show()
            Case Else
                MessageBox.Show("You Lost A Life!", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lives -= 1
        End Select

        If lives = 0 Then
            MessageBox.Show("You Are Out of Lives!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            hasLost = True
            Me.Hide()
            frmOverviewFinalExam.Show()
        End If

        lblLives.Text = "Lives Left: " & lives
    End Sub
End Class