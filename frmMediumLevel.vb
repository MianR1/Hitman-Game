Public Class frmMediumLevel
    Dim tries As Integer = 0
    Dim triesLeft As Integer = 20
    Dim guessNums(3) As Integer
    Dim codeNums(3) As Integer
    Dim secondsMedium As Integer = 240
    Dim scoreMediumSeconds As Integer = 0
    Dim scoreBlackDots As Integer = 0
    Public scoreFinalMedium As Integer = 0
    Dim wonYet As Boolean = False

    Dim testIntCode(3) As Integer
    Dim testIntGuess(3) As Integer
    Private blackDots As Integer = 0
    Private whiteDots As Integer = 0

    Private Sub TmrTimeToCompleteMedium_Tick(sender As Object, e As EventArgs) Handles tmrTimeToCompleteMedium.Tick
        tmrTimeToCompleteMedium.Start()
        secondsMedium -= 1
        lblTimeLeft.Text = "Time Left: " & secondsMedium & "s"

        If secondsMedium = 0 Or wonYet = True Or triesLeft = 0 Then

            tmrTimeToCompleteMedium.Stop()

            Select Case secondsMedium
                Case 180 To 240
                    secondsMedium = 50
                Case 120 To 179
                    secondsMedium = 25
                Case 60 To 119
                    secondsMedium = 15
                Case 0 To 59
                    secondsMedium = 10
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

            scoreFinalMedium = scoreMediumSeconds + scoreBlackDots
            MessageBox.Show("Your Finished The Level. Let's see how you did!", "Time's Up!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show("Your Score for this Level is: " & scoreFinalMedium, "Level1 Score", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            frmHardLevel.Show()
        End If


    End Sub

    Private Sub FrmMasterMindGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rand As New Random
        For i As Integer = 0 To 3
            codeNums(i) = rand.Next(1, 7)
        Next
        tmrTimeToCompleteMedium.Start()
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

        ElseIf picGuess3.Image Is Nothing Then
            picGuess3.Image = imageValue
            guessNums(3) = guessNumber
        End If

    End Sub
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        For i As Integer = 0 To testIntCode.Length - 1
            testIntCode(i) = codeNums(i)
        Next

        For i As Integer = 0 To testIntGuess.Length - 1
            testIntGuess(i) = guessNums(i)
        Next

        If picGuess3.Image Is Nothing Then
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

        'WHITE DOTS
        For x As Integer = 0 To codeValues.Length - 1
            If (guessedNums(x) <> 0 And codeValues(x) <> 0) And codeValues.Contains(guessedNums(x)) Then
                whiteDots += 1
            End If
        Next

        'IF USER WINS
        If blackDots = 4 Then
            lstOutput.Items.Add("You Cracked the Code")
            wonYet = True
        End If

        Return (blackDots, whiteDots, wonYet)
    End Function
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        picGuess0.Image = Nothing
        picGuess1.Image = Nothing
        picGuess2.Image = Nothing
        picGuess3.Image = Nothing
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
