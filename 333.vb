Imports System.Threading
Public Class frmSpongebob
    Dim counter As Integer = 0
    Dim time As Integer = 31
    Dim diff As Integer = 6
    Dim pics() As PictureBox
    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic6.Click
        counter += 1
        pics = {pic1, pic2, pic3, pic4, pic5, pic6}

        sender.backgroundimage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
        sender.enabled = False
        totalPoints += 10
        diff -= 1
        lblDiff.Text = "Differences: " & diff
        If counter = 6 Then
            Timer1.Enabled = False
            Me.Hide()
            MessageBox.Show("Congrats You Found All The Differences. VERY IMPRESSIVE!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("You Think You're A Professional Agent Now AY?", "...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Get Ready For The Ultimate Challenge!!.There will be 10 seconds to begin with, there are 5 differences to be found. Every difference you find will grant you 10 extra seconds." & vbNewLine & "Best Of Luck :)" & vbNewLine & vbNewLine & "                            Press (OK) to proceed.", "Ultimate Challenge", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmFlash.Show()
            frmFlash.Timer1.Enabled = True
        End If

    End Sub
    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Me.Click
        score -= 1
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        lblTime.Text = "Time Remaining: " & time

        If time = 0 Then
            Timer1.Enabled = False
            For i As Integer = 0 To pics.Length - 1
                pics(i).BackgroundImage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
                pics(i).Enabled = False
            Next
            MessageBox.Show("TIMES UP!!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Sadly, You Only Found " & counter & " Of The 6 Differences. Theres Always Next Year :)", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(3000)
            Refresh()
            Me.Hide()
            MessageBox.Show("Get Ready For The Ultimate Challenge!!, You will have 10 seconds to begin with, there are 5 differences to be found. Every difference you find will grant you 10 extra seconds. Press (OK) to proceed.", "Ultimate Challenge", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmFlash.Show()
            frmFlash.Timer1.Enabled = True
        End If
    End Sub

End Class