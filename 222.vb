Imports System.Threading
Public Class frmQueen
    Dim time As Integer = 21
    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        pic1.BackgroundImage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
        pic1.Enabled = False
        Timer1.Enabled = False
        MessageBox.Show("Congrats You Found Queen Elizabeth II :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        frmSpongebob.Show()
        frmSpongebob.Timer1.Enabled = True
        totalPoints += 5
    End Sub
    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        score -= 1
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        lblTime.Text = "Time Remaining: " & time

        If time = 0 Then
            Timer1.Enabled = False
            pic1.BackgroundImage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
            pic1.Enabled = False
            MessageBox.Show("TIMES UP!!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Sadly, You Did Not Find Queen Elizabeth II. TRY HARDER!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(3000)
            Refresh()
            Me.Hide()
            frmSpongebob.Show()
            frmSpongebob.Timer1.Enabled = True
        End If
    End Sub
End Class