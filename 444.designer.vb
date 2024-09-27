<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlash))
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblDiff = New System.Windows.Forms.Label()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(1158, 310)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(32, 98)
        Me.pic1.TabIndex = 8
        Me.pic1.TabStop = False
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.Color.Transparent
        Me.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic2.Location = New System.Drawing.Point(1241, 207)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(18, 22)
        Me.pic2.TabIndex = 9
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.BackColor = System.Drawing.Color.Transparent
        Me.pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic3.Location = New System.Drawing.Point(823, 194)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(195, 516)
        Me.pic3.TabIndex = 10
        Me.pic3.TabStop = False
        '
        'pic5
        '
        Me.pic5.BackColor = System.Drawing.Color.Transparent
        Me.pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic5.Location = New System.Drawing.Point(684, 55)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(69, 93)
        Me.pic5.TabIndex = 11
        Me.pic5.TabStop = False
        '
        'pic4
        '
        Me.pic4.BackColor = System.Drawing.Color.Transparent
        Me.pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic4.Location = New System.Drawing.Point(823, 153)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(56, 97)
        Me.pic4.TabIndex = 12
        Me.pic4.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 900
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(642, 724)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Black
        Me.lblTime.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(164, 23)
        Me.lblTime.TabIndex = 17
        Me.lblTime.Text = "Time Remaining:"
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.BackColor = System.Drawing.Color.Maroon
        Me.lblWrong.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.White
        Me.lblWrong.Location = New System.Drawing.Point(1, 24)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(156, 23)
        Me.lblWrong.TabIndex = 16
        Me.lblWrong.Text = "Wrong Clicks: 0"
        '
        'lblDiff
        '
        Me.lblDiff.AutoSize = True
        Me.lblDiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDiff.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiff.ForeColor = System.Drawing.Color.White
        Me.lblDiff.Location = New System.Drawing.Point(1, 47)
        Me.lblDiff.Name = "lblDiff"
        Me.lblDiff.Size = New System.Drawing.Size(140, 23)
        Me.lblDiff.TabIndex = 18
        Me.lblDiff.Text = "Differences: 5"
        '
        'frmFlash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1261, 722)
        Me.Controls.Add(Me.lblDiff)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFlash"
        Me.Text = "Spot the difference - ULTIMATE CHALLENGE"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblWrong As Label
    Friend WithEvents lblDiff As Label
End Class
