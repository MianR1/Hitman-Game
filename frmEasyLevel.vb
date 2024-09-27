Public Class frmEasyLevel
    Dim tries As Integer = 0
    Dim triesLeft As Integer = 20
    Dim guessNums(2) As Integer
    Dim codeNums(2) As Integer
    Dim secondsEasy As Integer = 240
    Dim scoreEasySeconds As Integer = 0
    Dim scoreBlackDots As Integer = 0
    Public scoreFinalEasy As Integer = 0
    Dim wonYet As Boolean = False

    Dim testIntCode(2) As Integer
    Dim testIntGuess(2) As Integer
    Private blackDots As Integer = 0
    Private whiteDots As Integer = 0

    Private Sub TmrTimeToCompleteEasy_Tick(sender As Object, e As EventArgs) Handles tmrTimeToCompleteEasy.Tick
        tmrTimeToCompleteEasy.Start()
        secondsEasy -= 1
        lblTimeLeft.Text = "Time Left: " & secondsEasy & "s"

        If secondsEasy = 0 Or wonYet = True Or triesLeft = 0 Then

            tmrTimeToCompleteEasy.Stop()
            Select Case secondsEasy
                Case 180 To 240
                    secondsEasy = 50
                Case 120 To 179
                    secondsEasy = 25
                Case 60 To 119
                    secondsEasy = 15
                Case 0 To 59
                    secondsEasy = 10
            End Select

            Select Case blackDots
                Case 4
                    scoreBlackDots = 150
                Case 3
                    scoreBlackDots = 120
                Case 2
                    scoreBlackDots = 100
                Case 1
                    scoreBlackDots = 50
                Case 0
                    scoreBlackDots = 0
            End Select

            scoreFinalEasy = scoreEasySeconds + scoreBlackDots
            MessageBox.Show("Your Finished The Level. Let's see how you did!", "Time's Up!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show("Your Score for this Level is: " & scoreFinalEasy, "Level1 Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmMediumLevel.Show()
        End If
    End Sub

    Private Sub FrmEasyLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rand As New Random
        For i As Integer = 0 To 2
            codeNums(i) = rand.Next(1, 7)
        Next
        tmrTimeToCompleteEasy.Start()
    End Sub
    Private Sub PicBlue_Click(sender As Object, e As EventArgs) Handles picBlue.Click
        FillSlot(My.Resources.blueball2, 1)
    End Sub

    Private Sub PicGreen_Click(sender As Object, e As EventArgs) Handles picGreen.Click
        FillSlot(My.Resources.greenball2, 2)
    End Sub

    Private Sub PicOrange_Click(sender As Object, e As EventArgs) Handles picOrange.Click
        FillSlot(My.Resources.orangeball2, 3)
    End Sub

    Private Sub PicPurple_Click(sender As Object, e As EventArgs) Handles picPurple.Click
        FillSlot(My.Resources.purpleball2, 4)
    End Sub

    Private Sub PicRed_Click(sender As Object, e As EventArgs) Handles picRed.Click
        FillSlot(My.Resources.redball2, 5)
    End Sub

    Private Sub PicYellow_Click(sender As Object, e As EventArgs) Handles picYellow.Click
        FillSlot(My.Resources.yellowball2, 6)
    End Sub

    Private Sub FillSlot(imageValue As Image, guessNumber As Integer)
        If picGuess0.Image Is Nothing Then
            picGuess0.Image = imageValue
            guessNums(0) = guessNumber

        ElseIf picGuess1.Image Is Nothing Then
            picGuess1.Image = imageValue
            guessNums(1) = guessNumber

        ElseIf picGuess2.Image Is Nothing Then
            picGuess2.Image = imageValue
            guessNums(2) = guessNumber
        End If

    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        For i As Integer = 0 To testIntCode.Length - 1
            testIntCode(i) = codeNums(i)
        Next

        For i As Integer = 0 To testIntGuess.Length - 1
            testIntGuess(i) = guessNums(i)
        Next

        If picGuess2.Image Is Nothing Then
            MessageBox.Show("Please Fill All Avaliable Slots", "Empty Slots", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Call DetectBlackDots(testIntGuess, testIntCode, wonYet)
        triesLeft -= 1
        tries += 1
        lstOutput.Items.Add("Try Number" & " " & tries)
        lstOutput.Items.Add(blackDots & " In Code, Right Position")
        lstOutput.Items.Add(whiteDots & " In Code, Wrong Position")
        lstOutput.Items.Add("")
        lblTriesLeft.Text = "Tries Left: " & triesLeft

        If triesLeft = 0 Then
            MessageBox.Show("You've Used All Your Attempts!", "No Tries Left", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            frmHardLevel.Show()
        End If
    End Sub

    Private Function DetectBlackDots(guessedNums() As Integer, codeValues() As Integer, hasWon As Boolean)
        blackDots = 0
        whiteDots = 0

        For i As Integer = 0 To codeValues.Length - 1

            'Finding Black Dots; Right Color and Right Place
            If guessedNums(i) = codeValues(i) Then
                blackDots += 1
                guessedNums(i) = 0
                codeValues(i) = 0
            End If
        Next

        'Finding White Dots; Right Color and Wrong Place
        For x As Integer = 0 To codeValues.Length - 1
            If (guessedNums(x) <> 0 And codeValues(x) <> 0) And codeValues.Contains(guessedNums(x)) Then
                whiteDots += 1
            End If
        Next

        'IF USER WINS
        If blackDots = 3 Then
            lstOutput.Items.Add("You Cracked the Code")
            wonYet = True
        End If

        Return (blackDots, whiteDots, wonYet)
    End Function

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        picGuess0.Image = Nothing
        picGuess1.Image = Nothing
        picGuess2.Image = Nothing
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to Leave the Game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
End Class