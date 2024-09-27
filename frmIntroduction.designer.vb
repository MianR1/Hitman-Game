<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAreYouReady = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to The Final Test"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAreYouReady
        '
        Me.btnAreYouReady.Font = New System.Drawing.Font("Agency FB", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAreYouReady.ForeColor = System.Drawing.Color.Maroon
        Me.btnAreYouReady.Location = New System.Drawing.Point(128, 379)
        Me.btnAreYouReady.Name = "btnAreYouReady"
        Me.btnAreYouReady.Size = New System.Drawing.Size(595, 49)
        Me.btnAreYouReady.TabIndex = 2
        Me.btnAreYouReady.Text = "Are You Ready? (Hint: Move Your Mouse Around)"
        Me.btnAreYouReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Firebrick
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.White
        Me.btnYes.Location = New System.Drawing.Point(379, 110)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(44, 26)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "Yes!"
        Me.btnYes.UseVisualStyleBackColor = False
        Me.btnYes.Visible = False
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnAreYouReady)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIntro"
        Me.Text = "Final Exam"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAreYouReady As Label
    Friend WithEvents btnYes As Button
End Class
