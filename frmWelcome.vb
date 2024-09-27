Imports System.Threading
Public Class frmWelcome
    Private Sub frmWelcome_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For i As Integer = 0 To arrayNameL.Length - 1
            Refresh()
            Thread.Sleep(4500 / arrayNameL.Length - 1)
            lblWelcome.Text &= arrayNameL(i)
            Me.Text &= arrayNameL(i)
        Next
        frmHub.Show()
        Me.Hide()
    End Sub
End Class