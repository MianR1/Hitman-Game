Public Class frmPopup
    Dim timeLeft As Integer = 100
    Dim array() As PictureBox
    Dim randN As New Random
    Dim randomNumber As Integer

    Private Sub tmrSec_Tick(sender As Object, e As EventArgs) Handles tmrSec.Tick
        tmrPop.Enabled = True
        timeLeft -= 1

        lblTime.Text = "Time Left: " & timeLeft

        If timeLeft < 50 And timeLeft > 25 Then
            lblTime.ForeColor = Color.Yellow
        ElseIf timeLeft < 25 Then
            lblTime.ForeColor = Color.Red
        End If
        If timeLeft = 0 Then
            tmrSec.Enabled = False
            tmrPop.Enabled = False
            For i As Integer = 0 To array.Length - 1
                array(i).Visible = False
            Next
            MessageBox.Show("Challenge Completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(score, "Score", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            tmrSec.Enabled = False

            Dim prevScore As Integer
            Dim ReInp() As String = Split(My.Settings.USERALL, "|")
            Dim indexInp As Integer

            Dim OutStr As String = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                If ReInp(i).Contains(My.Settings.lastLogged) Then
                    indexInp = i
                End If
            Next

            Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
            prevScore = finalInp(1)
            finalInp(1) = prevScore + score

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
    Private Sub Pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click, pic2.Click, pic3.Click, pic4.Click, pic5.Click, pic6.Click, pic7.Click, pic8.Click, pic9.Click, pic10.Click, pic11.Click, pic12.Click, pic13.Click, pic14.Click, pic15.Click, pic16.Click, pic17.Click, pic18.Click, pic19.Click, pic20.Click, pic21.Click, pic22.Click, pic23.Click, pic24.Click, pic25.Click, pic26.Click, pic27.Click, pic28.Click, pic29.Click, pic30.Click, pic31.Click, pic32.Click, pic33.Click, pic34.Click, pic35.Click, pic36.Click, pic37.Click, pic38.Click
        Dim clickedPic As PictureBox = sender
        clickedPic.Visible = False
        lblScore.ForeColor = Color.Green
        score += 10
        lblScore.Text = "Score: " & score
        counter += 1
    End Sub

    Private Sub tmrPop_Tick(sender As Object, e As EventArgs) Handles tmrPop.Tick
        Dim visiblePics As Integer = 0
        array = {pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pic21, pic22, pic23, pic24, pic25, pic26, pic27, pic28, pic29, pic30, pic31, pic32, pic33, pic34, pic35, pic36, pic37, pic38}

        randomNumber = randN.Next(0, 38)
        array(randomNumber).Visible = True

        For i = 0 To array.Length - 1
            If array(i).Visible = True Then
                visiblePics += 1
            End If
        Next

        If visiblePics = 3 Then
            tmrSec.Enabled = False
            tmrPop.Enabled = False
            MessageBox.Show("You Have Missed 3 Tragets! You Need Practice", "3 Targets Missed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            MessageBox.Show(score, "Score", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim ReInp() As String = Split(My.Settings.USERALL, "|")
            Dim indexInp As Integer
            Dim prevScore As Integer
            Dim OutStr As String = Nothing

            For i As Integer = 0 To ReInp.Length - 1
                If ReInp(i).Contains(My.Settings.lastLogged) Then
                    indexInp = i
                End If
            Next

            Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
            prevScore = finalInp(1)
            finalInp(1) = prevScore + score

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

    Private Sub frmPopup_Click(sender As Object, e As EventArgs) Handles Me.Click
        lblScore.ForeColor = Color.Red
        score -= 5
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub FrmPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Get ready for challenge 2! there will be random targets poping out of the dark for a certain amount of time. If 3 targets are visible, you fail the challenge, keep your eyes sharp agent." & vbNewLine & Space(32) & "Press (OK) To Proceed.", "Challenge 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.lblScore.Text = lblScore.Text
        Me.tmrSec.Enabled = True
        score = 0
        lblScore.Text = frmAim.lblScore.Text
        tmrSec.Enabled = True
    End Sub
End Class