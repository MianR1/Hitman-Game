Public Class frmAim
    Dim timeLeft As Integer = 150
    Public openone As Integer = 0
    Private Sub tmrSec_Tick(sender As Object, e As EventArgs) Handles tmrSec.Tick

        timeLeft -= 1

        lblTime.Text = "Time Left: " & timeLeft

        If timeLeft < 100 And timeLeft > 30 Then
            lblTime.ForeColor = Color.Yellow
        ElseIf timeLeft < 30 Then
            lblTime.ForeColor = Color.Red
        End If
        If timeLeft = 0 Then
            tmrSec.Enabled = False
            MessageBox.Show("Times Up!", "TIME", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            MessageBox.Show(scoreAim, "Score", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MessageBox.Show("Get ready for challenge 2! there will be random targets poping out of the dark for a certain amount of time. If 3 targets are visible, you fail the challenge, keep your eyes sharp agent." & vbNewLine & Space(32) & "Press (OK) To Proceed.", "Challenge 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim ReInp() As String = Split(My.Settings.USERALL, "|")
            Dim indexInp As Integer

            Dim OutStr As String = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                If ReInp(i).Contains(My.Settings.lastLogged) Then
                    indexInp = i
                End If
            Next

            Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
            finalInp(1) = scoreAim

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

            Me.Hide()
            frmPopup.Show()
        End If
    End Sub
    Private Sub frmAim_Click(sender As Object, e As EventArgs) Handles Me.Click
        lblScore.ForeColor = Color.Red
        scoreAim -= 5
        lblScore.Text = "Score: " & scoreAim
    End Sub
    Private Sub Pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic6.Click, pic7.Click, pic8.Click, pic9.Click, pic10.Click, pic11.Click, pic12.Click, pic13.Click, pic14.Click, pic15.Click, pic16.Click, pic17.Click, pic18.Click, pic19.Click, pic20.Click, pic21.Click, pic22.Click, pic23.Click, pic24.Click, pic25.Click, pic26.Click, pic27.Click, pic28.Click, pic29.Click, pic30.Click, pic31.Click, pic32.Click, pic33.Click, pic34.Click, pic35.Click, pic36.Click, pic37.Click, pic38.Click
        Dim clickedPic As PictureBox = sender
        clickedPic.Visible = False
        lblScore.ForeColor = Color.Green
        scoreAim += 10
        lblScore.Text = "Score: " & scoreAim
        counter += 1
        If counter = 38 Then
            tmrSec.Enabled = False
            MessageBox.Show("Very Impressive Agent, You Have Eliminated All Targets" & vbNewLine & Space(32) & "Keep It Up!" & vbNewLine & Space(12) & "Press (OK) To Proceed To Challenge 2", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(scoreAim, "Score", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MessageBox.Show("Get ready for challenge 2! there will be random targets poping out of the dark for a certain amount of time. If 3 targets are visible, you fail the challenge, keep your eyes sharp agent." & vbNewLine & Space(32) & "Press (OK) To Proceed.", "Challenge 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim ReInp() As String = Split(My.Settings.USERALL, "|")
            Dim indexInp As Integer

            Dim OutStr As String = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                If ReInp(i).Contains(My.Settings.lastLogged) Then
                    indexInp = i
                End If
            Next

            Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
            finalInp(1) = scoreAim

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

            Me.Hide()
            frmPopup.Show()
        End If
    End Sub
    Public Sub visibility()
        MessageBox.Show("you will be given targets that you need to take down within a certain amount of time, get all of them and you've got my respect agent." & vbNewLine & Space(32) & "Press (OK) To Proceed.", "Challenge 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnStart.Visible = False
        btnReturn.Visible = False
        picIcon.Visible = False
        lblOR.Visible = False
        tmrSec.Enabled = True
        openone = 1
    End Sub
    Private Sub picIcon_Click(sender As Object, e As EventArgs) Handles picIcon.Click
        visibility()
    End Sub
    Private Sub lblOR_Click_1(sender As Object, e As EventArgs) Handles lblOR.Click
        visibility()
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        visibility()
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        frmHub.Show()
    End Sub
End Class
