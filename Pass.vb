Public Class frmPass
    Private Sub frmPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picFireWorks.ImageLocation = "https://media.giphy.com/media/pua8zV8ljqDWo/giphy.gif"
        My.Computer.Audio.Play("Files Needed\champion wave.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        My.Computer.Audio.Stop()
        frmLeaderboard.Show()
        Me.Hide()
    End Sub
End Class