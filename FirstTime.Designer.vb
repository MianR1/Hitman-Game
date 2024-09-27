<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFirstTime
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstTime))
        Me.grpBottom = New System.Windows.Forms.GroupBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.tmrCut = New System.Windows.Forms.Timer(Me.components)
        Me.grpBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBottom
        '
        Me.grpBottom.Controls.Add(Me.lblDesc)
        Me.grpBottom.Controls.Add(Me.btnSkip)
        Me.grpBottom.ForeColor = System.Drawing.Color.Red
        Me.grpBottom.Location = New System.Drawing.Point(2, 349)
        Me.grpBottom.Name = "grpBottom"
        Me.grpBottom.Size = New System.Drawing.Size(802, 100)
        Me.grpBottom.TabIndex = 0
        Me.grpBottom.TabStop = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(10, 25)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(57, 25)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "ABC"
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.Black
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkip.Location = New System.Drawing.Point(666, 56)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(130, 38)
        Me.btnSkip.TabIndex = 0
        Me.btnSkip.Text = "Skip Cutscene"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'tmrCut
        '
        Me.tmrCut.Interval = 1000
        '
        'frmFirstTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFirstTime"
        Me.Text = "Cut Scene | ARS"
        Me.grpBottom.ResumeLayout(False)
        Me.grpBottom.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBottom As GroupBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnSkip As Button
    Friend WithEvents tmrCut As Timer
End Class
