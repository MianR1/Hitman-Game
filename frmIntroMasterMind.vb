Public Class frmIntroMasterMind
    Public openThree As Integer = 0
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        MessageBox.Show("Try Cracking The Code!", "Mastermind", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        frmEasyLevel.Show()
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmHub.Show()
    End Sub

    Private Sub PicIcon_Click(sender As Object, e As EventArgs) Handles picIcon.Click
        MessageBox.Show("Try Cracking The Code!", "Mastermind", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        frmEasyLevel.Show()
        openThree = 1
    End Sub
End Class