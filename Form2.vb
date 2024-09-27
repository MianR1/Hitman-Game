Imports System.Threading
Public Class frmAccess
    Dim intCont As Integer = -1
    Dim intWel As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrCont.Tick
        If intCont = 30 Then
            tmrCont.Enabled = False
            Me.Text = "Loaded! | ARS | BETA"
            Me.Hide()
            frmWelcome.Show()
            Exit Sub
        End If
        intCont += 1
        Select Case Me.Text
            Case "Loading. | ARS | BETA"
                Me.Text = "Loading.. | ARS | BETA"
            Case "Loading.. | ARS | BETA"
                Me.Text = "Loading... | ARS | BETA"
            Case "Loading... | ARS | BETA"
                Me.Text = "Loading. | ARS | BETA"
        End Select
        intWel += 1
    End Sub

    Private Sub frmAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrCont.Enabled = True
    End Sub
End Class