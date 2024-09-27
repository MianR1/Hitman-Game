<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMediumLevel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMediumLevel))
        Me.lblMasterMindTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.picBlue = New System.Windows.Forms.PictureBox()
        Me.picYellow = New System.Windows.Forms.PictureBox()
        Me.picRed = New System.Windows.Forms.PictureBox()
        Me.picPurple = New System.Windows.Forms.PictureBox()
        Me.picOrange = New System.Windows.Forms.PictureBox()
        Me.picGreen = New System.Windows.Forms.PictureBox()
        Me.grpGuess = New System.Windows.Forms.GroupBox()
        Me.picGuess3 = New System.Windows.Forms.PictureBox()
        Me.picGuess2 = New System.Windows.Forms.PictureBox()
        Me.picGuess1 = New System.Windows.Forms.PictureBox()
        Me.picGuess0 = New System.Windows.Forms.PictureBox()
        Me.tmrTimeToCompleteMedium = New System.Windows.Forms.Timer(Me.components)
        Me.lblTriesLeft = New System.Windows.Forms.Label()
        Me.lblTimeLeft = New System.Windows.Forms.Label()
        Me.grpOptions.SuspendLayout()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGuess.SuspendLayout()
        CType(Me.picGuess3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuess2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuess1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuess0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMasterMindTitle
        '
        Me.lblMasterMindTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasterMindTitle.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblMasterMindTitle.Location = New System.Drawing.Point(14, 20)
        Me.lblMasterMindTitle.Name = "lblMasterMindTitle"
        Me.lblMasterMindTitle.Size = New System.Drawing.Size(812, 38)
        Me.lblMasterMindTitle.TabIndex = 0
        Me.lblMasterMindTitle.Text = "MasterMind"
        Me.lblMasterMindTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnExit.Location = New System.Drawing.Point(12, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 62)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit Game?"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lstOutput
        '
        Me.lstOutput.BackColor = System.Drawing.Color.Black
        Me.lstOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 16
        Me.lstOutput.Location = New System.Drawing.Point(12, 86)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(355, 356)
        Me.lstOutput.TabIndex = 3
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Black
        Me.btnCheck.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCheck.Location = New System.Drawing.Point(374, 391)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(116, 51)
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDelete.Location = New System.Drawing.Point(709, 391)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 51)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'grpOptions
        '
        Me.grpOptions.BackColor = System.Drawing.Color.Black
        Me.grpOptions.Controls.Add(Me.picBlue)
        Me.grpOptions.Controls.Add(Me.picYellow)
        Me.grpOptions.Controls.Add(Me.picRed)
        Me.grpOptions.Controls.Add(Me.picPurple)
        Me.grpOptions.Controls.Add(Me.picOrange)
        Me.grpOptions.Controls.Add(Me.picGreen)
        Me.grpOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptions.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.grpOptions.Location = New System.Drawing.Point(373, 86)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(452, 86)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'picBlue
        '
        Me.picBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBlue.Image = CType(resources.GetObject("picBlue.Image"), System.Drawing.Image)
        Me.picBlue.Location = New System.Drawing.Point(6, 20)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(67, 60)
        Me.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBlue.TabIndex = 6
        Me.picBlue.TabStop = False
        '
        'picYellow
        '
        Me.picYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picYellow.Image = CType(resources.GetObject("picYellow.Image"), System.Drawing.Image)
        Me.picYellow.Location = New System.Drawing.Point(376, 20)
        Me.picYellow.Name = "picYellow"
        Me.picYellow.Size = New System.Drawing.Size(67, 60)
        Me.picYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picYellow.TabIndex = 5
        Me.picYellow.TabStop = False
        '
        'picRed
        '
        Me.picRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRed.Image = CType(resources.GetObject("picRed.Image"), System.Drawing.Image)
        Me.picRed.Location = New System.Drawing.Point(302, 21)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(67, 60)
        Me.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picRed.TabIndex = 4
        Me.picRed.TabStop = False
        '
        'picPurple
        '
        Me.picPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPurple.Image = CType(resources.GetObject("picPurple.Image"), System.Drawing.Image)
        Me.picPurple.Location = New System.Drawing.Point(228, 20)
        Me.picPurple.Name = "picPurple"
        Me.picPurple.Size = New System.Drawing.Size(67, 60)
        Me.picPurple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPurple.TabIndex = 3
        Me.picPurple.TabStop = False
        '
        'picOrange
        '
        Me.picOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picOrange.Image = CType(resources.GetObject("picOrange.Image"), System.Drawing.Image)
        Me.picOrange.Location = New System.Drawing.Point(154, 20)
        Me.picOrange.Name = "picOrange"
        Me.picOrange.Size = New System.Drawing.Size(67, 60)
        Me.picOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picOrange.TabIndex = 2
        Me.picOrange.TabStop = False
        '
        'picGreen
        '
        Me.picGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGreen.Image = CType(resources.GetObject("picGreen.Image"), System.Drawing.Image)
        Me.picGreen.Location = New System.Drawing.Point(80, 20)
        Me.picGreen.Name = "picGreen"
        Me.picGreen.Size = New System.Drawing.Size(67, 60)
        Me.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGreen.TabIndex = 1
        Me.picGreen.TabStop = False
        '
        'grpGuess
        '
        Me.grpGuess.BackColor = System.Drawing.Color.Black
        Me.grpGuess.Controls.Add(Me.picGuess3)
        Me.grpGuess.Controls.Add(Me.picGuess2)
        Me.grpGuess.Controls.Add(Me.picGuess1)
        Me.grpGuess.Controls.Add(Me.picGuess0)
        Me.grpGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuess.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.grpGuess.Location = New System.Drawing.Point(373, 233)
        Me.grpGuess.Name = "grpGuess"
        Me.grpGuess.Size = New System.Drawing.Size(452, 86)
        Me.grpGuess.TabIndex = 7
        Me.grpGuess.TabStop = False
        Me.grpGuess.Text = "Your Guess"
        '
        'picGuess3
        '
        Me.picGuess3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGuess3.Location = New System.Drawing.Point(299, 19)
        Me.picGuess3.Name = "picGuess3"
        Me.picGuess3.Size = New System.Drawing.Size(67, 60)
        Me.picGuess3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGuess3.TabIndex = 9
        Me.picGuess3.TabStop = False
        '
        'picGuess2
        '
        Me.picGuess2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGuess2.Location = New System.Drawing.Point(226, 19)
        Me.picGuess2.Name = "picGuess2"
        Me.picGuess2.Size = New System.Drawing.Size(67, 60)
        Me.picGuess2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGuess2.TabIndex = 8
        Me.picGuess2.TabStop = False
        '
        'picGuess1
        '
        Me.picGuess1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGuess1.Location = New System.Drawing.Point(153, 19)
        Me.picGuess1.Name = "picGuess1"
        Me.picGuess1.Size = New System.Drawing.Size(67, 60)
        Me.picGuess1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGuess1.TabIndex = 7
        Me.picGuess1.TabStop = False
        '
        'picGuess0
        '
        Me.picGuess0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGuess0.Location = New System.Drawing.Point(80, 19)
        Me.picGuess0.Name = "picGuess0"
        Me.picGuess0.Size = New System.Drawing.Size(67, 60)
        Me.picGuess0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picGuess0.TabIndex = 6
        Me.picGuess0.TabStop = False
        '
        'tmrTimeToCompleteMedium
        '
        Me.tmrTimeToCompleteMedium.Interval = 1000
        '
        'lblTriesLeft
        '
        Me.lblTriesLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriesLeft.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblTriesLeft.Location = New System.Drawing.Point(376, 331)
        Me.lblTriesLeft.Name = "lblTriesLeft"
        Me.lblTriesLeft.Size = New System.Drawing.Size(217, 37)
        Me.lblTriesLeft.TabIndex = 8
        Me.lblTriesLeft.Text = "Tries Left: 20"
        '
        'lblTimeLeft
        '
        Me.lblTimeLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLeft.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblTimeLeft.Location = New System.Drawing.Point(656, 331)
        Me.lblTimeLeft.Name = "lblTimeLeft"
        Me.lblTimeLeft.Size = New System.Drawing.Size(169, 37)
        Me.lblTimeLeft.TabIndex = 9
        Me.lblTimeLeft.Text = "Time Left: 240s"
        '
        'frmMediumLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(836, 454)
        Me.Controls.Add(Me.lblTimeLeft)
        Me.Controls.Add(Me.lblTriesLeft)
        Me.Controls.Add(Me.grpGuess)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMasterMindTitle)
        Me.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMediumLevel"
        Me.Text = "MasterMind Level 2"
        Me.grpOptions.ResumeLayout(False)
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGuess.ResumeLayout(False)
        CType(Me.picGuess3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuess2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuess1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuess0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMasterMindTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents picBlue As PictureBox
    Friend WithEvents picYellow As PictureBox
    Friend WithEvents picRed As PictureBox
    Friend WithEvents picPurple As PictureBox
    Friend WithEvents picOrange As PictureBox
    Friend WithEvents picGreen As PictureBox
    Friend WithEvents grpGuess As GroupBox
    Friend WithEvents picGuess3 As PictureBox
    Friend WithEvents picGuess2 As PictureBox
    Friend WithEvents picGuess1 As PictureBox
    Friend WithEvents picGuess0 As PictureBox
    Friend WithEvents tmrTimeToCompleteMedium As Timer
    Friend WithEvents lblTriesLeft As Label
    Friend WithEvents lblTimeLeft As Label
End Class
