Public Class frmHub
    Dim testOne As String = "The First Test - Aim Tester" & vbNewLine & "Eliminate All Targets At Sight."
    Dim testTwo As String = "The Second Test - Spot Differences" & vbNewLine & "Find All Hiden Differences."
    Dim testThree As String = "The Third Test - Mastermind" & vbNewLine & "Crack The Secret Code."
    Dim testExam As String = "The Final Test - Final Exam " & vbNewLine & "Pass All Levels."
    Dim arrayDesc() As String = {testOne, testTwo, testThree, testExam}
    Public indexDesc As Integer = 0
    Public openable() As Boolean = {True, True, True, True}

    Private Sub BtnLeaderboard_Click(sender As Object, e As EventArgs) Handles btnLeaderboard.Click
        Me.Hide()
        frmLeaderboard.Show()
        My.Settings.Reload()

        Dim Result As Integer = 0
        frmLeaderboard.Controls.Clear()
        Call frmLeaderboard.Init()

        Dim trialAll() As String = Split(My.Settings.USERALL, "|")
        For i As Integer = 0 To trialAll.Length - 1
            If trialAll(i).Contains(":") = False Then
                Continue For
            End If
            Dim x() As String = Split(trialAll(i), ":", 5)
            ReDim Preserve x(x.Length + 1)
            x(5) = CDec(x(1)) + CDec(x(2)) + CDec(x(3)) + CDec(x(4))
            If x(0) = keepUser Then
                Result = x(5)
            End If
            Dim lstTrial As New ListViewItem(x)
            frmLeaderboard.lstScore.Items.Add(lstTrial)
        Next
    End Sub

    Private Sub frmHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDesc.Text = "Description:" + vbNewLine + arrayDesc(indexDesc)
        lblSigned.Text &= keepUser
    End Sub
    '   Private Sub checkImage()
    '      picImageDesc.BackgroundImageLayout = ImageLayout.Center
    ' If lblDesc.Text.Contains(arrayDesc(0)) Then
    '        picImageDesc.BackgroundImage = My.Resources.test_1_click_all
    'ElseIf lblDesc.Text.Contains(arrayDesc(1)) Then
    '       picImageDesc.BackgroundImage = My.Resources.test_2_spot_dif
    'End If
    'End Sub
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        If indexDesc = 3 Then
            indexDesc = -1
        End If
        indexDesc += 1
        lblDesc.Text = "Description:" + vbNewLine + arrayDesc(indexDesc)
        Call GifShow()
        Disable()
    End Sub
    Public Sub Disable()
        Select Case indexDesc
            Case 0
                If frmAim.openOne = 1 Then
                    btnPlay.Enabled = False
                Else
                    btnPlay.Enabled = True
                End If
            Case 1
                If frmBegin.opentwo = 1 Then
                    btnPlay.Enabled = False
                Else
                    btnPlay.Enabled = True
                End If
            Case 2
                If frmIntroMasterMind.openThree = 1 Then
                    btnPlay.Enabled = False
                Else
                    btnPlay.Enabled = True
                End If

            Case 3
                If frmIntro.openfour = 1 Then
                    btnPlay.Enabled = False
                Else
                    btnPlay.Enabled = True
                End If
        End Select
    End Sub
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        If indexDesc = 0 Then
            indexDesc = 4
        End If
        indexDesc -= 1
        lblDesc.Text = "Description:" + vbNewLine + arrayDesc(indexDesc)
        Call GifShow()
        Disable()
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If lblDesc.Text.Contains("The First Test") Then
            frmAim.Show()
            Me.Hide()
            openable(0) = False
        ElseIf lblDesc.Text.Contains("The Second Test") Then
            frmBegin.Show()
            Me.Hide()
            openable(1) = False
        ElseIf lblDesc.Text.Contains("The Third Test") Then
            frmIntroMasterMind.Show()
            Me.Hide()
            openable(2) = False
        ElseIf lblDesc.text.Contains("The Final Test") Then
            frmIntro.Show()
            Me.Hide()
            openable(3) = False
        End If
        Disable()
    End Sub
    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        frmCredits.Show()
        Me.Hide()
    End Sub

    Public Sub GifShow()
        If lblDesc.Text.Contains("The First Test") Then
            picImageDesc.Image = My.Resources.DangerousYearlyGallinule_small
        ElseIf lblDesc.Text.Contains("The Second Test") Then
            picImageDesc.Image = My.Resources.Hocus_Focus
        ElseIf lblDesc.Text.Contains("The Third Test") Then
            picImageDesc.Image = My.Resources.INTERCEPT_OM_FINAL_170424_1494519418
        ElseIf lblDesc.Text.Contains("The Final Test") Then
            picImageDesc.Image = My.Resources.Verticalline_test_letting_us_know_who_passed_calculus_since_1667__b7cc915295d6f49d6644ba94aaedc4cb
        End If


    End Sub
End Class