<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBegin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBegin))
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(112, 218)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(30, 28)
        Me.pic1.TabIndex = 7
        Me.pic1.TabStop = False
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.BackColor = System.Drawing.Color.Maroon
        Me.lblWrong.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.White
        Me.lblWrong.Location = New System.Drawing.Point(0, 66)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(156, 23)
        Me.lblWrong.TabIndex = 8
        Me.lblWrong.Text = "Wrong Clicks: 0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 900
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(0, 43)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(170, 23)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time Remaining: "
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.Maroon
        Me.BtnStart.Font = New System.Drawing.Font("Britannic Bold", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.Black
        Me.BtnStart.Location = New System.Drawing.Point(-10, -10)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(486, 412)
        Me.BtnStart.TabIndex = 10
        Me.BtnStart.Text = "Click To Begin The Test"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Black
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Britannic Bold", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Maroon
        Me.btnReturn.Location = New System.Drawing.Point(162, 302)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(163, 62)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.BackColor = System.Drawing.Color.Maroon
        Me.lblOR.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOR.ForeColor = System.Drawing.Color.Black
        Me.lblOR.Location = New System.Drawing.Point(213, 238)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(65, 41)
        Me.lblOR.TabIndex = 12
        Me.lblOR.Text = "OR"
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.Maroon
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(129, 12)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(228, 152)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 13
        Me.picIcon.TabStop = False
        '
        'frmBegin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(470, 394)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblOR)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.pic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBegin"
        Me.Text = "Spot the Panda"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents lblWrong As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblOR As Label
    Friend WithEvents picIcon As PictureBox
End Class
