<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverviewFinalExam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverviewFinalExam))
        Me.btnReturnHome = New System.Windows.Forms.Button()
        Me.lstOverviewResult = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturnHome
        '
        Me.btnReturnHome.BackColor = System.Drawing.Color.Maroon
        Me.btnReturnHome.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnHome.Location = New System.Drawing.Point(301, 347)
        Me.btnReturnHome.Name = "btnReturnHome"
        Me.btnReturnHome.Size = New System.Drawing.Size(184, 66)
        Me.btnReturnHome.TabIndex = 9
        Me.btnReturnHome.Text = "Return to Hub"
        Me.btnReturnHome.UseVisualStyleBackColor = False
        '
        'lstOverviewResult
        '
        Me.lstOverviewResult.BackColor = System.Drawing.Color.Black
        Me.lstOverviewResult.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOverviewResult.ForeColor = System.Drawing.Color.Maroon
        Me.lstOverviewResult.FormattingEnabled = True
        Me.lstOverviewResult.ItemHeight = 25
        Me.lstOverviewResult.Location = New System.Drawing.Point(217, 157)
        Me.lstOverviewResult.Name = "lstOverviewResult"
        Me.lstOverviewResult.Size = New System.Drawing.Size(366, 179)
        Me.lstOverviewResult.TabIndex = 7
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(12, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(776, 67)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "lblTitle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BaskarRafayGaudel_FinalProject.My.Resources.Resources.Agent_47_in_Hitman_Absolution
        Me.PictureBox2.Location = New System.Drawing.Point(610, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 280)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BaskarRafayGaudel_FinalProject.My.Resources.Resources.unnamed1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmOverviewFinalExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 442)
        Me.Controls.Add(Me.btnReturnHome)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lstOverviewResult)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOverviewFinalExam"
        Me.Text = "frmOverviewFinalExam"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReturnHome As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lstOverviewResult As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
End Class
