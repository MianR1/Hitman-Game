<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPass))
        Me.picFireWorks = New System.Windows.Forms.PictureBox()
        Me.lblCongrats = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picFireWorks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFireWorks
        '
        Me.picFireWorks.BackColor = System.Drawing.Color.Black
        Me.picFireWorks.BackgroundImage = CType(resources.GetObject("picFireWorks.BackgroundImage"), System.Drawing.Image)
        Me.picFireWorks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFireWorks.Location = New System.Drawing.Point(-3, 1)
        Me.picFireWorks.Name = "picFireWorks"
        Me.picFireWorks.Size = New System.Drawing.Size(1048, 420)
        Me.picFireWorks.TabIndex = 0
        Me.picFireWorks.TabStop = False
        '
        'lblCongrats
        '
        Me.lblCongrats.AutoSize = True
        Me.lblCongrats.BackColor = System.Drawing.Color.Transparent
        Me.lblCongrats.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongrats.ForeColor = System.Drawing.Color.White
        Me.lblCongrats.Location = New System.Drawing.Point(115, 9)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.Size = New System.Drawing.Size(511, 76)
        Me.lblCongrats.TabIndex = 1
        Me.lblCongrats.Text = "      You successfully passed!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Welcome to Porter Interlligence!"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Italic)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 282)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 67)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(734, 361)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCongrats)
        Me.Controls.Add(Me.picFireWorks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPass"
        Me.Text = "Passed! | ARS | BETA"
        CType(Me.picFireWorks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFireWorks As PictureBox
    Friend WithEvents lblCongrats As Label
    Friend WithEvents btnBack As Button
End Class
