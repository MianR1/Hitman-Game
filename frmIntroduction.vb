Public Class frmIntro
    Public openfour As Integer = 0
    Private Sub BtnAreYouReady_Hover(sender As Object, e As EventArgs) Handles btnAreYouReady.MouseHover
        btnYes.Visible = True
    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Hide()
        frmLevel1.Show()
        openFour = 1
    End Sub

End Class
