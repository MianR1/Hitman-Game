<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClick2 = New System.Windows.Forms.Button()
        Me.grpLava = New System.Windows.Forms.GroupBox()
        Me.btnClick1 = New System.Windows.Forms.Button()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.grpLava.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 82)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Form Is Lava! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "But You Must Click the Buttons..."
        '
        'btnClick2
        '
        Me.btnClick2.BackColor = System.Drawing.Color.Black
        Me.btnClick2.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick2.ForeColor = System.Drawing.Color.White
        Me.btnClick2.Location = New System.Drawing.Point(0, 272)
        Me.btnClick2.Name = "btnClick2"
        Me.btnClick2.Size = New System.Drawing.Size(125, 75)
        Me.btnClick2.TabIndex = 1
        Me.btnClick2.Text = "Click Me!"
        Me.btnClick2.UseVisualStyleBackColor = False
        '
        'grpLava
        '
        Me.grpLava.Controls.Add(Me.btnClick1)
        Me.grpLava.Controls.Add(Me.btnClick2)
        Me.grpLava.Location = New System.Drawing.Point(12, 91)
        Me.grpLava.Name = "grpLava"
        Me.grpLava.Size = New System.Drawing.Size(776, 347)
        Me.grpLava.TabIndex = 2
        Me.grpLava.TabStop = False
        '
        'btnClick1
        '
        Me.btnClick1.BackColor = System.Drawing.Color.Black
        Me.btnClick1.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick1.ForeColor = System.Drawing.Color.White
        Me.btnClick1.Location = New System.Drawing.Point(651, 7)
        Me.btnClick1.Name = "btnClick1"
        Me.btnClick1.Size = New System.Drawing.Size(125, 85)
        Me.btnClick1.TabIndex = 2
        Me.btnClick1.Text = "Click Me!"
        Me.btnClick1.UseVisualStyleBackColor = False
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLives.Location = New System.Drawing.Point(642, 9)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(129, 25)
        Me.lblLives.TabIndex = 3
        Me.lblLives.Text = "Lives Left: "
        Me.lblLives.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmLevel2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpLava)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel2"
        Me.Text = "frmLevel2"
        Me.grpLava.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClick2 As Button
    Friend WithEvents grpLava As GroupBox
    Friend WithEvents btnClick1 As Button
    Friend WithEvents lblLives As Label
End Class
