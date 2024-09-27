<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHub
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHub))
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.picImageDesc = New System.Windows.Forms.PictureBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnLeaderboard = New System.Windows.Forms.Button()
        Me.lblSigned = New System.Windows.Forms.Label()
        Me.btnCredits = New System.Windows.Forms.Button()
        CType(Me.picImageDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.Transparent
        Me.btnLeft.BackgroundImage = CType(resources.GetObject("btnLeft.BackgroundImage"), System.Drawing.Image)
        Me.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeft.Location = New System.Drawing.Point(507, 200)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(100, 100)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.Transparent
        Me.btnRight.BackgroundImage = CType(resources.GetObject("btnRight.BackgroundImage"), System.Drawing.Image)
        Me.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRight.Location = New System.Drawing.Point(910, 200)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(100, 100)
        Me.btnRight.TabIndex = 1
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Maroon
        Me.btnPlay.BackgroundImage = CType(resources.GetObject("btnPlay.BackgroundImage"), System.Drawing.Image)
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.Location = New System.Drawing.Point(718, 429)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(100, 100)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Agency FB", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(421, -8)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(590, 115)
        Me.lblMain.TabIndex = 4
        Me.lblMain.Text = "HUB | ARS | BETA"
        '
        'picImageDesc
        '
        Me.picImageDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImageDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picImageDesc.Image = Global.BaskarRafayGaudel_FinalProject.My.Resources.Resources.DangerousYearlyGallinule_small
        Me.picImageDesc.InitialImage = Global.BaskarRafayGaudel_FinalProject.My.Resources.Resources.test_1_click_all
        Me.picImageDesc.Location = New System.Drawing.Point(622, 145)
        Me.picImageDesc.Name = "picImageDesc"
        Me.picImageDesc.Size = New System.Drawing.Size(269, 195)
        Me.picImageDesc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImageDesc.TabIndex = 2
        Me.picImageDesc.TabStop = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Agency FB", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(619, 343)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(103, 28)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Description:"
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.BackColor = System.Drawing.Color.Silver
        Me.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeaderboard.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaderboard.Location = New System.Drawing.Point(898, 429)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(133, 100)
        Me.btnLeaderboard.TabIndex = 6
        Me.btnLeaderboard.Text = "Leaderboard"
        Me.btnLeaderboard.UseVisualStyleBackColor = False
        '
        'lblSigned
        '
        Me.lblSigned.AutoSize = True
        Me.lblSigned.BackColor = System.Drawing.Color.Transparent
        Me.lblSigned.Font = New System.Drawing.Font("Agency FB", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigned.Location = New System.Drawing.Point(435, 106)
        Me.lblSigned.Name = "lblSigned"
        Me.lblSigned.Size = New System.Drawing.Size(193, 35)
        Me.lblSigned.TabIndex = 8
        Me.lblSigned.Text = "Signed In As: Agent "
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Silver
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.Location = New System.Drawing.Point(507, 429)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(151, 108)
        Me.btnCredits.TabIndex = 9
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'frmHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1043, 552)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.lblSigned)
        Me.Controls.Add(Me.btnLeaderboard)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.picImageDesc)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHub"
        Me.Text = "Hub"
        CType(Me.picImageDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents picImageDesc As PictureBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnLeaderboard As Button
    Friend WithEvents lblSigned As Label
    Friend WithEvents btnCredits As Button
End Class
