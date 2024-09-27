Imports System.Threading
Public Class frmSignup
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If txtUser.Text.Contains(":") Or txtPass.Text.Contains(":") Or txtUser.Text.Contains("|") Or txtPass.Text.Contains("|") Then
            MessageBox.Show("Username/Password cannot contain ':'(s) or '|'(s)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUser.Text = Nothing
            txtPass.Text = Nothing
        ElseIf txtUser.Text = "" Or txtPass.Text = "" Or txtPin.Text = "" Then
            MessageBox.Show("Userword/Password cannot be left blank!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPin.Text.Length <> 3 Or IsNumeric(txtPin.Text.Length) = False Then
            MessageBox.Show("2 Factor Authentication Pin must have 3 digits and only numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsNumeric(txtPin.Text) = True And txtPin.Text.Length = 3 Then
            Refresh()
            Thread.Sleep(750)
            My.Settings.UserPass &= txtUser.Text & ":" & txtPass.Text & ":" & txtPin.Text & "|"
            My.Settings.USERALL &= txtUser.Text & ":0:0:0:0|"
            My.Settings.Save()

            Dim msgR As DialogResult
            msgR = MessageBox.Show("Creating an account requires a restart, would you like to restart now?", "ARS | BETA", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgR = DialogResult.Yes Then
                Application.Restart()
            Else
                Me.Hide()
                frmLog.Show()
            End If
        End If
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmLog.Show()
    End Sub
End Class