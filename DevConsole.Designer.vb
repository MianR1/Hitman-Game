<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDev))
        Me.rchOut = New System.Windows.Forms.RichTextBox()
        Me.txtInp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rchOut
        '
        Me.rchOut.BackColor = System.Drawing.Color.White
        Me.rchOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rchOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rchOut.Location = New System.Drawing.Point(13, 13)
        Me.rchOut.Name = "rchOut"
        Me.rchOut.ReadOnly = True
        Me.rchOut.Size = New System.Drawing.Size(446, 225)
        Me.rchOut.TabIndex = 0
        Me.rchOut.Text = ""
        '
        'txtInp
        '
        Me.txtInp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInp.Location = New System.Drawing.Point(13, 245)
        Me.txtInp.Name = "txtInp"
        Me.txtInp.Size = New System.Drawing.Size(446, 26)
        Me.txtInp.TabIndex = 1
        '
        'frmDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(471, 281)
        Me.Controls.Add(Me.txtInp)
        Me.Controls.Add(Me.rchOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDev"
        Me.Text = "DevConsole"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rchOut As RichTextBox
    Friend WithEvents txtInp As TextBox
End Class
