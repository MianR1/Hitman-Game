Public Class frmDev

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInp.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Give(txtInp.Text)
        End If
    End Sub

    Private Sub Give(input As String)
        Select Case input
            Case "clr"
                rchOut.Text &= "Clearing all Data..." & vbNewLine
                My.Settings.USERALL = Nothing
                My.Settings.UserPass = Nothing
                My.Settings.lastLogged = Nothing
                My.Settings.Save()
                rchOut.Text &= "Cleared all Data!" & vbNewLine
            Case "hub"
                frmHub.Show()
            Case "leader"
                frmLeaderboard.Show()
            Case "exit"
                Me.Close()
            Case "logout"
                Me.Hide()
                frmLog.Show()
                frmLog.txtBoth.Enabled = True
                frmLog.lblUser.Text = "Awaiting username..."
                frmLog.lblUser.ForeColor = Color.Red
                frmLog.rtfOut.Text = Nothing
                frmLog.rtfOut.ForeColor = Color.Red
                frmLog.lblBoth.Text = "Agent Name: "

            Case "print acc"
                rchOut.Text &= "Printing all accounts!" & vbNewLine
                Dim accs() As String = Split(My.Settings.UserPass, "|")
                For i As Integer = 0 To accs.Length - 1
                    rchOut.Text &= accs(i) & vbNewLine
                Next
                rchOut.Text &= "Printed all accounts!" & vbNewLine
            Case "clean"
                rchOut.Text = Nothing
            Case "cmds"
                rchOut.Text &= "Commands:" & vbNewLine & ">clr - Clears all Data" & vbNewLine & ">hub - opens hub" & vbNewLine & ">leader - opens leaderboard" & vbNewLine & ">print acc - prints all accounts" & vbNewLine & ">exit - closes program" & vbNewLine & ">Add User|(user)|(pass)|(pin) - adds an account" & vbNewLine & ">clean - clears console" & vbNewLine & ">pass - opens pass screen" & vbNewLine & ">reset - resets Leaderboard score" & vbNewLine
            Case "pass"
                frmPass.Show()
            Case "reset"
                My.Settings.USERALL = "Justin:0:0:0:0|"
                My.Settings.Save()
                Application.Restart()
            Case "hide first"
                frmFirstTime.Hide()
            Case "first time"
                My.Settings.FirstTime = True
                My.Settings.Save()
        End Select
        If input.Contains("Add User|") Then
            Dim addUser() As String = Split(input, "|", 4)
            My.Settings.UserPass &= addUser(1) & ":" & addUser(2) & ":" & addUser(3) & "|"
            My.Settings.Save()
            rchOut.Text &= "Added User - '" & addUser(1) & "'" & vbNewLine
        End If
        txtInp.Text = Nothing
    End Sub
End Class