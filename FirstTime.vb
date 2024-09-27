'**************************************************************************************************
' PROGRAMME	    :	ARS - Agent Recruiting System
'  
' OUTLINE		:	This Program Provides Many Tests For New Agents And Gives Them A Score Based On 
'                   Thier Skill And Efficiency. After Completing All Tests And Tasks, The User Will
'                   Then Access The Leaderboard and Check If He Has Passed And Become An Official 
'                   Agent OR Will He Return Next year??
' 
' PROGRAMMERS	:	Akkshai Baskar, Mian Rafay, Kris Gaudel
'
'  DATE		    :	December 10, 2019
' **************************************************************************************************

Public Class frmFirstTime
    Dim countTime As Integer = 0
    Private Sub frmFirstTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.FirstTime = False Then
            frmLoad.Show()
            Me.Hide()
        Else
            If System.IO.File.Exists("Files Needed\champion wave.wav") = False And System.IO.File.Exists("Files Needed\lose wave.wav") = False And System.IO.File.Exists("Files Needed\pistol.wav") = False Then
                MessageBox.Show("Error 404: Files Not Found", "Missing Files", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            tmrCut.Enabled = True
            lblDesc.Text = "Agent Naka has been caught and killed in action!, You are our only hope."
            PlayMusic()
            frmLoad.Hide()

            '   Call CutScene()
        End If
    End Sub
    Private Sub PlayMusic()
        My.Computer.Audio.Play("Files Needed\pistol.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub CutScene()
        Dim index As Integer = 1
        Dim arrayPic(index) As PictureBox
        Dim name As String = "1"
        For i As Integer = 0 To 9


            Dim pb As New PictureBox
            Dim rand As New Random
            pb.Width = rand.Next(50, 151)
            pb.Height = rand.Next(50, 151)
            pb.Top = rand.Next(0, 251)
            pb.Left = rand.Next(0, 701)
            pb.BackColor = Color.Transparent
            SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            pb.SizeMode = PictureBoxSizeMode.Zoom
            pb.Image = My.Resources.blood_shot_SPLASH
            pb.BringToFront()
            Me.Controls.Add(pb)
            pb.Show()
            pb.Name = name
            name &= "1"
            index += 1
            ReDim Preserve arrayPic(index)
            arrayPic(i) = pb
        Next
    End Sub

    Private Sub tmrCut_Tick(sender As Object, e As EventArgs) Handles tmrCut.Tick
        If countTime > 10 Then
            tmrCut.Enabled = False
            My.Computer.Audio.Stop()
            btnSkip.Text = "Continue!"
        ElseIf countTime = 3 Then
            lblDesc.Text = "You will be given tests to find out whether you're agent material."
        ElseIf countTime = 6 Then
            lblDesc.Text = "Let's see if you can replace Agent Naka!"
        End If
        Dim pb As New PictureBox
        Dim rand As New Random
        pb.Width = rand.Next(50, 151)
        pb.Height = rand.Next(50, 151)
        pb.Top = rand.Next(0, 251)
        pb.Left = rand.Next(0, 701)
        pb.BackColor = Color.Transparent
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        pb.SizeMode = PictureBoxSizeMode.Zoom
        pb.Image = My.Resources.blood_shot_SPLASH
        pb.BringToFront()
        Me.Controls.Add(pb)
        pb.Show()




        'Dim G As Drawing.Graphics
        'Dim Pen As New Pen(Color.Black)

        'G.DrawImage(My.Resources.blood_shot_SPLASH, 5, 5)


        countTime += 1
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        If btnSkip.Text = "Continue!" Then
            My.Settings.FirstTime = False
            My.Settings.Save()
            Application.Restart()
        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Are you sure you want to skip the intro?", "Confirmation! | ARS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If dialog = DialogResult.Yes Then
                My.Settings.FirstTime = False
                My.Settings.Save()
                Application.Restart()
            End If
        End If
    End Sub
End Class