<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQueen))
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(125, 179)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(55, 59)
        Me.pic1.TabIndex = 8
        Me.pic1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(0, 38)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(164, 23)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "Time Remaining:"
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.BackColor = System.Drawing.Color.Maroon
        Me.lblWrong.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.White
        Me.lblWrong.Location = New System.Drawing.Point(0, 61)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(156, 23)
        Me.lblWrong.TabIndex = 10
        Me.lblWrong.Text = "Wrong Clicks: 0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 900
        '
        'frmQueen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(523, 409)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.pic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQueen"
        Me.Text = "Spot Queen Elizabeth II"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblWrong As Label
    Friend WithEvents Timer1 As Timer
End Class
