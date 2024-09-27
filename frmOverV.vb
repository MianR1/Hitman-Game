Public Class frmOverV
    Private Sub FrmOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim finalScore As Integer = frmEasyLevel.scoreFinalEasy + frmMediumLevel.scoreFinalMedium + frmHardLevel.scoreFinalHard
        lblScore1Out.Text = frmEasyLevel.scoreFinalEasy
        lblScore2Out.Text = frmMediumLevel.scoreFinalMedium
        lblScore3Out.Text = frmHardLevel.scoreFinalHard
        lblFinalScoreOut.Text = finalScore
    End Sub

    Private Sub BtnReturnToHub_Click(sender As Object, e As EventArgs) Handles btnReturnToHub.Click
        frmHub.Disable()
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
        finalInp(3) = CInt(lblFinalScoreOut.Text)

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