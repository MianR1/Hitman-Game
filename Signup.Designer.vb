<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignup))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtUser.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(528, 147)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(435, 44)
        Me.txtUser.TabIndex = 3
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUser.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.DarkGray
        Me.lblUser.Location = New System.Drawing.Point(348, 150)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(181, 37)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "Agent Name:"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPass.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(528, 213)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(435, 44)
        Me.txtPass.TabIndex = 5
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPass.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPass.Location = New System.Drawing.Point(393, 216)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(136, 37)
        Me.lblPass.TabIndex = 6
        Me.lblPass.Text = "Passcode:"
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSign.Font = New System.Drawing.Font("Perpetua Titling MT", 72.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.ForeColor = System.Drawing.Color.White
        Me.lblSign.Location = New System.Drawing.Point(-3, -4)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(0, 113)
        Me.lblSign.TabIndex = 7
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.Transparent
        Me.btnSignup.BackgroundImage = CType(resources.GetObject("btnSignup.BackgroundImage"), System.Drawing.Image)
        Me.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.Location = New System.Drawing.Point(750, 332)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(213, 65)
        Me.btnSignup.TabIndex = 10
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BackgroundImage = CType(resources.GetObject("btnReturn.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Palatino Linotype", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(527, 332)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(213, 65)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.BackColor = System.Drawing.Color.Transparent
        Me.lblLog.Font = New System.Drawing.Font("Perpetua Titling MT", 65.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.ForeColor = System.Drawing.Color.DarkGray
        Me.lblLog.Location = New System.Drawing.Point(331, 9)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(666, 104)
        Me.lblLog.TabIndex = 12
        Me.lblLog.Text = "Signup - ARS"
        '
        'txtPin
        '
        Me.txtPin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPin.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtPin.ForeColor = System.Drawing.Color.White
        Me.txtPin.Location = New System.Drawing.Point(528, 273)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(435, 44)
        Me.txtPin.TabIndex = 13
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPin.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPin.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPin.Location = New System.Drawing.Point(402, 276)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(127, 37)
        Me.lblPin.TabIndex = 14
        Me.lblPin.Text = "2FA PIN:"
        '
        'frmSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(987, 419)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignup"
        Me.Text = "Signup | ARS | BETA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblSign As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblLog As Label
    Friend WithEvents txtPin As TextBox
    Friend WithEvents lblPin As Label
End Class
