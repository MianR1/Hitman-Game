<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCredits))
        Me.lblMainCredit = New System.Windows.Forms.Label()
        Me.lblTitleCredit = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMainCredit
        '
        Me.lblMainCredit.AutoSize = True
        Me.lblMainCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainCredit.Location = New System.Drawing.Point(21, 67)
        Me.lblMainCredit.Name = "lblMainCredit"
        Me.lblMainCredit.Size = New System.Drawing.Size(356, 25)
        Me.lblMainCredit.TabIndex = 0
        Me.lblMainCredit.Text = "Made by: Akkshai.B, Kris.G, Mian.R"
        '
        'lblTitleCredit
        '
        Me.lblTitleCredit.AutoSize = True
        Me.lblTitleCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCredit.Location = New System.Drawing.Point(83, 9)
        Me.lblTitleCredit.Name = "lblTitleCredit"
        Me.lblTitleCredit.Size = New System.Drawing.Size(250, 46)
        Me.lblTitleCredit.TabIndex = 1
        Me.lblTitleCredit.Text = "ARS | BETA"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(21, 106)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(222, 25)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version: 1.0.1 | BETA"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(249, 100)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(142, 37)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmCredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 146)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitleCredit)
        Me.Controls.Add(Me.lblMainCredit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCredits"
        Me.Text = "ARS | Credits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMainCredit As Label
    Friend WithEvents lblTitleCredit As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnBack As Button
End Class
