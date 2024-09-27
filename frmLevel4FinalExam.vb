Public Class frmLevel4FinalExam
    Private Sub FrmLevel4FinalExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLives.Text = "Lives Left: " & lives
    End Sub
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rdbButler.Checked = True Then
            Me.Hide()
            frmOverviewFinalExam.Show()
        Else
            MessageBox.Show("You Lost A Life!", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lives -= 1
            Me.Controls.Clear()
            InitializeComponent()
        End If

        If lives = 0 Then
            MessageBox.Show("You Are Out of Lives!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            hasLost = True
            Me.Hide()
            frmOverviewFinalExam.Show()
        End If
    End Sub
End Class