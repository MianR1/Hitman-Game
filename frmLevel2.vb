Public Class frmLevel2
    Public beenClicked As Integer = 0
    Private Sub FrmLevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLives.Text = "Lives Left:" & lives
    End Sub
    Private Sub GrpLava_Enter(sender As Object, e As EventArgs) Handles grpLava.MouseHover
        MessageBox.Show("You Lost A Life!", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        lives -= 1
        Me.Controls.Clear()
        InitializeComponent()

        If lives = 0 Then
            MessageBox.Show("You Are Out of Lives!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            hasLost = True
            Me.Hide()
            frmOverviewFinalExam.Show()
        End If

        lblLives.Text = "Lives Left: " & lives
    End Sub

    Private Sub BtnClick1_Click(sender As Object, e As EventArgs) Handles btnClick1.Click
        btnClick1.Text = "Clicked!"
        beenClicked += 1

        If beenClicked = 2 Then
            Me.Hide()
            frmLevel3.Show()
        End If
    End Sub

    Private Sub BtnClick2_Click(sender As Object, e As EventArgs) Handles btnClick2.Click
        btnClick2.Text = "Clicked!"
        beenClicked += 1

        If beenClicked = 2 Then
            Me.Hide()
            frmLevel3.Show()
        End If
    End Sub
End Class