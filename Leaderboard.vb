Public Class frmLeaderboard
    Dim Result As Integer = 0
    Public Sub Init()
        InitializeComponent()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmHub.Show()
    End Sub

    Private Sub btnGetResult_Click(sender As Object, e As EventArgs) Handles btnGetResult.Click
        If Result >= 1000 Then
            Me.Hide()
            frmPass.Show()
        Else
            MessageBox.Show("You have failed to became an agent!!!" & vbNewLine & "Not to worry, there is always next year!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class