<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel4FinalExam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel4FinalExam))
        Me.lblRiddle = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.grpAnswers = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.rdbButler = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.picQuestionMark = New System.Windows.Forms.PictureBox()
        Me.grpAnswers.SuspendLayout()
        CType(Me.picQuestionMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRiddle
        '
        Me.lblRiddle.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiddle.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblRiddle.Location = New System.Drawing.Point(12, 9)
        Me.lblRiddle.Name = "lblRiddle"
        Me.lblRiddle.Size = New System.Drawing.Size(536, 202)
        Me.lblRiddle.TabIndex = 0
        Me.lblRiddle.Text = resources.GetString("lblRiddle.Text")
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblLives.Location = New System.Drawing.Point(12, 360)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(103, 24)
        Me.lblLives.TabIndex = 1
        Me.lblLives.Text = "Lives Left:"
        '
        'grpAnswers
        '
        Me.grpAnswers.Controls.Add(Me.RadioButton1)
        Me.grpAnswers.Controls.Add(Me.RadioButton10)
        Me.grpAnswers.Controls.Add(Me.rdbButler)
        Me.grpAnswers.Controls.Add(Me.RadioButton12)
        Me.grpAnswers.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAnswers.ForeColor = System.Drawing.Color.Cornsilk
        Me.grpAnswers.Location = New System.Drawing.Point(16, 218)
        Me.grpAnswers.Name = "grpAnswers"
        Me.grpAnswers.Size = New System.Drawing.Size(375, 115)
        Me.grpAnswers.TabIndex = 5
        Me.grpAnswers.TabStop = False
        Me.grpAnswers.Text = "Your Answer"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.RadioButton1.Location = New System.Drawing.Point(217, 71)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 27)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Suicide"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.RadioButton10.Location = New System.Drawing.Point(217, 21)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(110, 27)
        Me.RadioButton10.TabIndex = 6
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "The Maid"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'rdbButler
        '
        Me.rdbButler.AutoSize = True
        Me.rdbButler.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbButler.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.rdbButler.Location = New System.Drawing.Point(11, 71)
        Me.rdbButler.Name = "rdbButler"
        Me.rdbButler.Size = New System.Drawing.Size(124, 27)
        Me.rdbButler.TabIndex = 5
        Me.rdbButler.TabStop = True
        Me.rdbButler.Text = "The Butler"
        Me.rdbButler.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Checked = True
        Me.RadioButton12.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton12.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.RadioButton12.Location = New System.Drawing.Point(11, 21)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(163, 27)
        Me.RadioButton12.TabIndex = 4
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "The Daughters"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnSubmit.Location = New System.Drawing.Point(229, 346)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(162, 49)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'picQuestionMark
        '
        Me.picQuestionMark.Image = Global.BaskarRafayGaudel_FinalProject.My.Resources.Resources.helllo
        Me.picQuestionMark.Location = New System.Drawing.Point(456, 201)
        Me.picQuestionMark.Name = "picQuestionMark"
        Me.picQuestionMark.Size = New System.Drawing.Size(273, 179)
        Me.picQuestionMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuestionMark.TabIndex = 3
        Me.picQuestionMark.TabStop = False
        '
        'frmLevel4FinalExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 407)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpAnswers)
        Me.Controls.Add(Me.picQuestionMark)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblRiddle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel4FinalExam"
        Me.Text = "frmLevel4"
        Me.grpAnswers.ResumeLayout(False)
        Me.grpAnswers.PerformLayout()
        CType(Me.picQuestionMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRiddle As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents picQuestionMark As PictureBox
    Friend WithEvents grpAnswers As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents rdbButler As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents btnSubmit As Button
End Class
