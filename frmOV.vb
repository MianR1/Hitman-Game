Public Class frmOV
    Private Sub FrmOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim finalScore As Integer = frmEasyLevel.scoreFinalEasy + frmMediumLevel.scoreFinalMedium + frmHardLevel.scoreFinalHard
        lblScore1Out.Text = frmEasyLevel.scoreFinalEasy
        lblScore2Out.Text = frmMediumLevel.scoreFinalMedium
        lblScore3Out.Text = frmHardLevel.scoreFinalHard
        lblFinalScoreOut.Text = finalScore
    End Sub

End Class