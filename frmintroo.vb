'*******************************************************
' PROGRAMME	:	Mastermind
'  
' OUTLINE		:	This program allows the user to play the classic game Mastermind. The user guesses the code by choosing colored dots. Feedback about the user's guess is provided in the listbox.
'                   The user has a limited amount of tries and seconds to get the code right.
' 
' PROGRAMMER	:	Kris Gaudel
'
' DATE		:	December 15, 2019
' ******************************************************
Public Class frmintroo
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Me.Hide()
        frmEasyLevel.Show()
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PicIcon_Click(sender As Object, e As EventArgs) Handles picIcon.Click
        Me.Hide()
        frmEasyLevel.Show()
    End Sub
    Private Sub LblOR_Click(sender As Object, e As EventArgs) Handles lblOR.Click
        Me.Hide()
        frmEasyLevel.Show()
    End Sub
End Class