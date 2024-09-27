Imports System.Threading
Public Class frmFlash
    Dim counter As Integer
    Dim time As Integer = 10
    Dim pics() As PictureBox
    Dim diff As Integer = 5
    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click
        counter += 1
        sender.backgroundimage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
        sender.enabled = False
        totalPoints += 10
        diff -= 1
        lblDiff.Text = "Differences: " & diff
        If counter <= 4 Then
            time += 10
        End If
        If counter = 5 Then
            Timer1.Enabled = False
            MessageBox.Show("Congrats You Found All The Differences. MAD SKILLZ!!!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("You Scored " & totalPoints + (score * 2) & " Points", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'put what eveer form comes next after this, like to the score board or somethinn

            'Dim prevScore As Integer
            Dim ReInp() As String = Split(My.Settings.USERALL, "|")
            Dim indexInp As Integer

            Dim OutStr As String = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                If ReInp(i).Contains(My.Settings.lastLogged) Then
                    indexInp = i
                End If
            Next

            Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
            'prevScore = finalInp(1)
            finalInp(2) = totalPoints + (score * 2)

            For x As Integer = 0 To finalInp.Length - 1
                If x = 4 Then
                    OutStr &= finalInp(x)
                Else
                    OutStr &= finalInp(x) & ":"
                End If
            Next

            ReInp(indexInp) = OutStr

            OutStr = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                OutStr &= ReInp(i) & "|"
            Next
            My.Settings.USERALL = OutStr
            My.Settings.Save()

            frmHub.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Form4_Click(sender As Object, e As EventArgs) Handles Me.Click
        score -= 1
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        lblTime.Text = "Time Remaining: " & time
        pics = {pic1, pic2, pic3, pic4, pic5}
        If time = 0 Then
            Timer1.Enabled = False
            For i As Integer = 0 To pics.Length - 1
                pics(i).BackgroundImage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
                pics(i).Enabled = False
            Next
            MessageBox.Show("TIMES UP!!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("You Scored " & totalPoints + (score * 2) & " Points", "Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Better Luck Next Time!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Thread.Sleep(3000)
            Refresh()

            'Dim prevScore As Integer
            Dim ReInp() As String = Split(My.Settings.USERALL, "|")
            Dim indexInp As Integer

            Dim OutStr As String = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                If ReInp(i).Contains(My.Settings.lastLogged) Then
                    indexInp = i
                End If
            Next

            Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
            'prevScore = finalInp(1)
            finalInp(2) = totalPoints + (score * 2)

            For x As Integer = 0 To finalInp.Length - 1
                If x = 4 Then
                    OutStr &= finalInp(x)
                Else
                    OutStr &= finalInp(x) & ":"
                End If
            Next

            ReInp(indexInp) = OutStr

            OutStr = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                OutStr &= ReInp(i) & "|"
            Next
            My.Settings.USERALL = OutStr
            My.Settings.Save()

            frmHub.Show()
            Me.Hide()
        End If
    End Sub
End Class