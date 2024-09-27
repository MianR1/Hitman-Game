<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmintroo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmintroo))
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picIcon
        '
        Me.picIcon.BackColor = System.Drawing.Color.Maroon
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(284, 12)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(241, 181)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 73
        Me.picIcon.TabStop = False
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.BackColor = System.Drawing.Color.Maroon
        Me.lblOR.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOR.ForeColor = System.Drawing.Color.Black
        Me.lblOR.Location = New System.Drawing.Point(375, 296)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(65, 41)
        Me.lblOR.TabIndex = 72
        Me.lblOR.Text = "OR"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Black
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Britannic Bold", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Maroon
        Me.btnReturn.Location = New System.Drawing.Point(323, 376)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(163, 62)
        Me.btnReturn.TabIndex = 71
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.Maroon
        Me.BtnStart.Font = New System.Drawing.Font("Britannic Bold", 32.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.Black
        Me.BtnStart.Location = New System.Drawing.Point(-9, -5)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(817, 506)
        Me.BtnStart.TabIndex = 70
        Me.BtnStart.Text = "Click To Begin The Test"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.lblOR)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.BtnStart)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmIntroduction"
        Me.Text = "frmIntroduction"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblOR As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents BtnStart As Button
End Class
