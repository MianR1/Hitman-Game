<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblBoth = New System.Windows.Forms.Label()
        Me.txtBoth = New System.Windows.Forms.TextBox()
        Me.rtfOut = New System.Windows.Forms.RichTextBox()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnRecovery = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblLastLog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.BackColor = System.Drawing.Color.Transparent
        Me.lblLog.Font = New System.Drawing.Font("Perpetua Titling MT", 60.0!, System.Drawing.FontStyle.Bold)
        Me.lblLog.ForeColor = System.Drawing.Color.Gray
        Me.lblLog.Location = New System.Drawing.Point(-3, 9)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(872, 96)
        Me.lblLog.TabIndex = 1
        Me.lblLog.Text = "Login  | ARS | BETA"
        '
        'lblBoth
        '
        Me.lblBoth.AutoSize = True
        Me.lblBoth.BackColor = System.Drawing.Color.Transparent
        Me.lblBoth.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoth.ForeColor = System.Drawing.Color.Silver
        Me.lblBoth.Location = New System.Drawing.Point(10, 126)
        Me.lblBoth.Name = "lblBoth"
        Me.lblBoth.Size = New System.Drawing.Size(181, 37)
        Me.lblBoth.TabIndex = 2
        Me.lblBoth.Text = "Agent Name:"
        '
        'txtBoth
        '
        Me.txtBoth.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBoth.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtBoth.ForeColor = System.Drawing.Color.White
        Me.txtBoth.Location = New System.Drawing.Point(17, 166)
        Me.txtBoth.Name = "txtBoth"
        Me.txtBoth.Size = New System.Drawing.Size(363, 44)
        Me.txtBoth.TabIndex = 0
        '
        'rtfOut
        '
        Me.rtfOut.BackColor = System.Drawing.Color.Black
        Me.rtfOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfOut.ForeColor = System.Drawing.Color.Red
        Me.rtfOut.Location = New System.Drawing.Point(13, 336)
        Me.rtfOut.Name = "rtfOut"
        Me.rtfOut.ReadOnly = True
        Me.rtfOut.Size = New System.Drawing.Size(551, 157)
        Me.rtfOut.TabIndex = 5
        Me.rtfOut.Text = ""
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.BackColor = System.Drawing.Color.Transparent
        Me.lblOut.Font = New System.Drawing.Font("Agency FB", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOut.ForeColor = System.Drawing.Color.Red
        Me.lblOut.Location = New System.Drawing.Point(3, 276)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(136, 59)
        Me.lblOut.TabIndex = 6
        Me.lblOut.Text = "Status:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Red
        Me.lblUser.Location = New System.Drawing.Point(15, 368)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(192, 34)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "Awaiting username..."
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.Red
        Me.lblPass.Location = New System.Drawing.Point(20, 445)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(50, 34)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "ABC"
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.Transparent
        Me.btnSignup.BackgroundImage = CType(resources.GetObject("btnSignup.BackgroundImage"), System.Drawing.Image)
        Me.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.Location = New System.Drawing.Point(449, 140)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(250, 70)
        Me.btnSignup.TabIndex = 9
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnRecovery
        '
        Me.btnRecovery.BackColor = System.Drawing.Color.Transparent
        Me.btnRecovery.BackgroundImage = CType(resources.GetObject("btnRecovery.BackgroundImage"), System.Drawing.Image)
        Me.btnRecovery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecovery.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecovery.Location = New System.Drawing.Point(449, 230)
        Me.btnRecovery.Name = "btnRecovery"
        Me.btnRecovery.Size = New System.Drawing.Size(250, 70)
        Me.btnRecovery.TabIndex = 10
        Me.btnRecovery.Text = "Forgot Passcode?"
        Me.btnRecovery.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Silver
        Me.lblInfo.Location = New System.Drawing.Point(8, 220)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(110, 24)
        Me.lblInfo.TabIndex = 11
        Me.lblInfo.Text = "(Case Sensitive!)"
        '
        'lblLastLog
        '
        Me.lblLastLog.AutoSize = True
        Me.lblLastLog.BackColor = System.Drawing.Color.Transparent
        Me.lblLastLog.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastLog.ForeColor = System.Drawing.Color.Silver
        Me.lblLastLog.Location = New System.Drawing.Point(154, 221)
        Me.lblLastLog.Name = "lblLastLog"
        Me.lblLastLog.Size = New System.Drawing.Size(111, 24)
        Me.lblLastLog.TabIndex = 12
        Me.lblLastLog.Text = "Last logged in as:"
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1163, 515)
        Me.Controls.Add(Me.lblLastLog)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnRecovery)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.rtfOut)
        Me.Controls.Add(Me.txtBoth)
        Me.Controls.Add(Me.lblBoth)
        Me.Controls.Add(Me.lblLog)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLog"
        Me.Text = "Login | ARS | BETA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLog As Label
    Friend WithEvents lblBoth As Label
    Friend WithEvents txtBoth As TextBox
    Friend WithEvents rtfOut As RichTextBox
    Friend WithEvents lblOut As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnRecovery As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblLastLog As Label
End Class
