'put a header here

'!!! why is the form load still showing even after "me.hide()"?

Imports System.Threading
Public Class frmLoad
    Dim timeCount As Integer = 0
    Dim rand As New Random
    Dim intColor As Integer = 215
    Dim intKey As Integer = 0
    Private Sub frmLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("Files Needed\champion wave.wav") = False And System.IO.File.Exists("Files Needed\lose wave.wav") = False And System.IO.File.Exists("Files Needed\pistol.wav") = False Then
            MessageBox.Show("Error 404: Files Not Found", "Missing Files", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Text = "Loading... | ARS | BETA"
        lblMain.Text = "Loading."
        picAgent.ImageLocation = "https://i.gifer.com/PQIH.gif"
        tmrLoading.Start()
        lblPI.Visible = False
        lblMain.ForeColor = Color.White
    End Sub
    Private Sub ReadyGo()
        tmrLoading.Stop()
        lblMain.Location = New Point(lblMain.Location.X - 100, lblMain.Location.Y) ' moves label to the left for better positioning
        lblMain.Text = "ARS Loaded!"
        Me.Text = "Loaded! | ARS | BETA"
        lblMain.ForeColor = Color.LawnGreen
        lblPI.Visible = True
        Refresh()
        Thread.Sleep(1000)
        Me.Hide()
        frmLog.Show()
        'The code for the next thing(s) that should happen goes BELOW THIS
    End Sub
    Private Sub tmrLoading_Tick(sender As Object, e As EventArgs) Handles tmrLoading.Tick
        frmFirstTime.Hide()
        timeCount += 1
        If picAgent.Location.X = 600 Then
            For i As Integer = 0 To 15
                picAgent.Location = New Point(picAgent.Location.X + 10, picAgent.Location.Y) ' Allows agent to continue walking - walks out of screen.
            Next
            If intKey > 3 Then
                frmDev.Show()
            End If
            ReadyGo()
            Exit Sub
        End If
        picAgent.Location = New Point(picAgent.Location.X + 10, picAgent.Location.Y) ' Moves the agent
        If timeCount Mod 10 = 0 Then 'Makes sure the pace of the agent moving is the same pace as the "Loading..." animation
            Dim strComp As String = lblMain.Text
            Select Case strComp 'does the loading animation.
                Case "Loading."
                    lblMain.Text = "Loading.."
                Case "Loading.."
                    lblMain.Text = "Loading..."
                Case "Loading..."
                    lblMain.Text = "Loading."
            End Select

            'lblMain.ForeColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))
            lblMain.ForeColor = Color.FromArgb(intColor, intColor, intColor, intColor) ' Allows for a smooth transition of colors...
            intColor -= 30
        End If




    End Sub

    Private Sub frmLoad_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then
            intKey += 1
        End If
    End Sub
End Class
'Feel free to mess with and try out new values and numbers for the intervals, etc.
'ANY QUESTIONS? DM me and questions you may have. I will get back to you as soon as I can.