Imports System.Threading
Public Class frmBegin
    Dim time As Integer = 16
    Public opentwo As Integer = 0
    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click
        pic1.BackgroundImage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
        pic1.Enabled = False
        Timer1.Enabled = False
        MessageBox.Show("Congrats You Found The Panda :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        frmQueen.Show()
        frmQueen.Timer1.Enabled = True
        totalPoints += 5
    End Sub
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        score -= 1
        lblWrong.Text = "Wrong Clicks:" & Space(1) & score
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time -= 1
        lblTime.Text = "Time Remaining: " & time

        If time = 0 Then
            Timer1.Enabled = False
            pic1.BackgroundImage = My.Resources.kisspng_check_mark_computer_icons_clip_art_green_check_mark_2_icon_5ab1d1bfebf0f5_removebg_preview
            pic1.Enabled = False
            MessageBox.Show("TIMES UP!!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Sadly, You Did Not Find The Panda. TRY HARDER!! ", "Faliure", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If score < 0 Then
                score = 0
            End If
            Thread.Sleep(3000)
            Refresh()
            Me.Hide()
            frmQueen.Show()
            frmQueen.Timer1.Enabled = True
        End If
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        MessageBox.Show("There will be a certain time limit for each stage. There are 4 stages and the sequence goes from easy to hard. Every wrong click is 2 points off of your total. The first 2 stages give 5 points per difference and the harder levels give 10 points per difference." & vbNewLine & "                               Press (OK) to proceed.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnStart.Visible = False
        btnReturn.Visible = False
        Timer1.Enabled = True
        picIcon.Visible = False
        lblOR.Visible = False
        opentwo = 1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmHub.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picIcon.Click
        MessageBox.Show("There will be a certain time limit for each stage. There are 4 stages and the sequence goes from easy to hard. Every wrong click is 2 points off of your total. The first 2 stages give 5 points per difference and the harder levels give 10 points per difference." & vbNewLine & "                               Press (OK) to proceed.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnStart.Visible = False
        btnReturn.Visible = False
        Timer1.Enabled = True
        picIcon.Visible = False
        lblOR.Visible = False
        opentwo = 1
    End Sub
    Private Sub LblOR_Click(sender As Object, e As EventArgs) Handles lblOR.Click
        MessageBox.Show("There will be a certain time limit for each stage. There are 4 stages and the sequence goes from easy to hard. Every wrong click is 2 points off of your total. The first 2 stages give 5 points per difference and the harder levels give 10 points per difference." & vbNewLine & "                               Press (OK) to proceed.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BtnStart.Visible = False
        btnReturn.Visible = False
        Timer1.Enabled = True
        picIcon.Visible = False
        lblOR.Visible = False
        opentwo = 1
    End Sub

    Private Sub FrmBegin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        score = 0
    End Sub
End Class
