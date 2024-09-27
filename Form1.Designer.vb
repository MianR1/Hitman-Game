<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoad))
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.lblMain = New System.Windows.Forms.Label()
        Me.picAgent = New System.Windows.Forms.PictureBox()
        Me.lblPI = New System.Windows.Forms.Label()
        CType(Me.picAgent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrLoading
        '
        Me.tmrLoading.Interval = 60
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 71.99999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(200, -4)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(245, 108)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "ABC"
        '
        'picAgent
        '
        Me.picAgent.BackgroundImage = CType(resources.GetObject("picAgent.BackgroundImage"), System.Drawing.Image)
        Me.picAgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picAgent.ErrorImage = CType(resources.GetObject("picAgent.ErrorImage"), System.Drawing.Image)
        Me.picAgent.InitialImage = CType(resources.GetObject("picAgent.InitialImage"), System.Drawing.Image)
        Me.picAgent.Location = New System.Drawing.Point(-250, 141)
        Me.picAgent.Name = "picAgent"
        Me.picAgent.Size = New System.Drawing.Size(358, 273)
        Me.picAgent.TabIndex = 1
        Me.picAgent.TabStop = False
        '
        'lblPI
        '
        Me.lblPI.Font = New System.Drawing.Font("Palatino Linotype", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPI.Location = New System.Drawing.Point(207, 115)
        Me.lblPI.Name = "lblPI"
        Me.lblPI.Size = New System.Drawing.Size(403, 180)
        Me.lblPI.TabIndex = 2
        Me.lblPI.Text = "Porter Intelligence"
        Me.lblPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 439)
        Me.Controls.Add(Me.lblPI)
        Me.Controls.Add(Me.picAgent)
        Me.Controls.Add(Me.lblMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoad"
        Me.Text = "ABC"
        CType(Me.picAgent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrLoading As Timer
    Friend WithEvents lblMain As Label
    Friend WithEvents picAgent As PictureBox
    Friend WithEvents lblPI As Label
End Class
