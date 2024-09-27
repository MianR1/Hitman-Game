Public Class frmOverviewFinalExam
    Private Sub FrmOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lives > 0 Then
            lblTitle.Text = "You Have Passed!"
            My.Computer.Audio.Play("Files Needed\champion wave.wav")
            lstOverviewResult.Items.Add("Congratulations Agent!")
            lstOverviewResult.Items.Add("You Have Passed the ARS training Program")
            lstOverviewResult.Items.Add("Please Report to Training at:")
            lstOverviewResult.Items.Add("40 Fairfax Crescent, Scarborough, Ontario")
        Else
            lblTitle.Text = "Better Luck Next Time"
            My.Computer.Audio.Play("Files Needed\lose wave.wav")
            lstOverviewResult.Items.Add("Sorry Agent")
            lstOverviewResult.Items.Add("You Have failed the ARS Training Program")
            lstOverviewResult.Items.Add("Please Resubmit your Application in 6 Months")
        End If
    End Sub
    Private Sub BtnReturnHome_Click(sender As Object, e As EventArgs) Handles btnReturnHome.Click
        'Dim prevScore As Integer
        frmHub.Disable()
        Dim ReInp() As String = Split(My.Settings.USERALL, "|")
        Dim indexInp As Integer
        Dim testScore As Integer
        If lives > 0 Then
            testScore = 500
        Else
            testScore = 0
        End If

        Dim OutStr As String = Nothing

        For i As Integer = 0 To ReInp.Length - 1
            If ReInp(i).Contains(My.Settings.lastLogged) Then
                indexInp = i
            End If
        Next

        Dim finalInp() As String = Split(ReInp(indexInp), ":", 5)
        'prevScore = finalInp(1)
        finalInp(4) = testScore

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
    End Sub
End Class