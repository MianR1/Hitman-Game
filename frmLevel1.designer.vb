<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel1))
        Me.lblLevel1Riddle = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.txtRiddle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLevel1Riddle
        '
        Me.lblLevel1Riddle.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel1Riddle.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblLevel1Riddle.Location = New System.Drawing.Point(94, 42)
        Me.lblLevel1Riddle.Name = "lblLevel1Riddle"
        Me.lblLevel1Riddle.Size = New System.Drawing.Size(351, 50)
        Me.lblLevel1Riddle.TabIndex = 0
        Me.lblLevel1Riddle.Text = "Here's A Riddle:"
        Me.lblLevel1Riddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.Location = New System.Drawing.Point(12, 353)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(122, 25)
        Me.lblLives.TabIndex = 1
        Me.lblLives.Text = "Lives Left:"
        Me.lblLives.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtRiddle
        '
        Me.txtRiddle.Font = New System.Drawing.Font("Agency FB", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiddle.ForeColor = System.Drawing.Color.Maroon
        Me.txtRiddle.Location = New System.Drawing.Point(478, 42)
        Me.txtRiddle.Name = "txtRiddle"
        Me.txtRiddle.Size = New System.Drawing.Size(290, 90)
        Me.txtRiddle.TabIndex = 2
        Me.txtRiddle.Text = "What has a Heart but no other organs?"
        Me.txtRiddle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(12, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type Your Answer Here:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtUser.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(423, 170)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(365, 46)
        Me.txtUser.TabIndex = 4
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Green
        Me.btnSubmit.Font = New System.Drawing.Font("Britannic Bold", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(247, 269)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(347, 75)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Answer"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'frmLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 387)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRiddle)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblLevel1Riddle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel1"
        Me.Text = "Level 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLevel1Riddle As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents txtRiddle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents btnSubmit As Button
End Class
