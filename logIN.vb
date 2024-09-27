Imports System.Threading
Public Class frmLog
    Dim strUserPass() = Split(My.Settings.UserPass, "|")

    Private Sub txtBoth_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBoth.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lblBoth.Text = "Agent Name:" Then
                lblUser.Text &= " --> OK! --> " & txtBoth.Text
                lblUser.ForeColor = Color.LawnGreen
                keepUser = txtBoth.Text
                For i As Integer = 0 To strUserPass.Length - 1
                    Dim colSplit() As String = Nothing
                    colSplit = Split(strUserPass(i), ":", 3)
                    If colSplit(0) = txtBoth.Text And colSplit(0) <> "" Then
                        lblBoth.Text = "Passcode:"
                        My.Settings.lastLogged = colSplit(0)
                        userName = colSplit(1)
                    Else
                        lblBoth.Text = "Passcode:"
                    End If
                Next
                txtBoth.Text = Nothing
                'Thread.Sleep(750) ' ! Better if this isnt in the code. But debatable.
                lblPass.Text = "Awaiting passcode..."
            Else
                If txtBoth.Text = userName And txtBoth.Text <> "" Then 'code for next goes here.
                    lblPass.ForeColor = Color.LawnGreen
                    lblPass.Text &= " --> OK! --> " & txtBoth.Text
                    lblOut.ForeColor = Color.LawnGreen
                    txtBoth.Enabled = False
                    Refresh()
                    Thread.Sleep(750)
                    My.Settings.Save()
                    'Welcome Agent code starts here!
                    intNameLL = My.Settings.lastLogged.Length
                    ReDim arrayNameL(intNameLL)
                    For i As Integer = 0 To intNameLL - 1
                        arrayNameL(i) = My.Settings.lastLogged.Substring(i, 1)
                    Next
                    'Welcome Agent code ends here!
                    Me.Hide()
                    frmWelcome.Show()
                Else
                    lblPass.Text &= " --> OK! --> " & txtBoth.Text
                    ' lblUser.Text = "Username/Password not valid!" -- !!! WIP | New label has to be made... Necessary?
                    Refresh()
                    Thread.Sleep(750)
                    lblPass.Text = ""
                    lblUser.Text = "Agent Name/Passcode not valid!"
                    lblUser.ForeColor = Color.Red
                    lblOut.ForeColor = Color.Red
                    Refresh()
                    Thread.Sleep(750)
                    '    MessageBox.Show("Username/Password not valid!", "Error! | ARS | BETA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lblBoth.Text = "Agent Name:"
                    txtBoth.Text = Nothing
                    lblUser.Text = "Awaiting Agent Name..."
                    lblPass.ForeColor = Color.Red
                End If
            End If
        End If
    End Sub

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPass.Text = ""
        lblLastLog.Text &= " " & My.Settings.lastLogged
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        Try
            Dim inpPin As String = InputBox("Enter the 3 digit pin!", "ARS | Password Recovery", "")
            Dim passRecov() As String = Split(My.Settings.UserPass, "|")
            Dim foundRecov() As String = Nothing

            Do Until IsNumeric(inpPin) = True And inpPin.Length = 3
                MessageBox.Show("The pin has to be numeric and can only contain 3 numbers!", "ARS | Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Error)
                inpPin = InputBox("Enter the 3 digit pin!", "Password Recovery | ARS", "")
            Loop
            For i As Integer = 0 To passRecov.Length - 1
                If passRecov(i).Contains(inpPin) Then
                    foundRecov = Split(passRecov(i), ":", 3)
                End If
            Next
            If foundRecov(1) = "" Then
                MessageBox.Show("There are no accounts linked with this pin!", "ARS | Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The password linked to the account of this pin is '" & foundRecov(1) & "'!", "ARS | Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("There are no accounts linked with this pin!", "ARS | Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Me.Hide()
        frmSignup.Show()
    End Sub
End Class