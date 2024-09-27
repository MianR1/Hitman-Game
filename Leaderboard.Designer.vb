<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeaderboard))
        Me.lstScore = New System.Windows.Forms.ListView()
        Me.ColumnHeaderusername = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTest1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTest2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTest3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderFinal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstScore
        '
        Me.lstScore.BackColor = System.Drawing.Color.Black
        Me.lstScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderusername, Me.ColumnHeaderTest1, Me.ColumnHeaderTest2, Me.ColumnHeaderTest3, Me.ColumnHeaderFinal, Me.ColumnHeaderTotal})
        Me.lstScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScore.ForeColor = System.Drawing.Color.White
        Me.lstScore.HideSelection = False
        Me.lstScore.Location = New System.Drawing.Point(283, 12)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(540, 216)
        Me.lstScore.TabIndex = 0
        Me.lstScore.UseCompatibleStateImageBehavior = False
        Me.lstScore.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderusername
        '
        Me.ColumnHeaderusername.Text = "Username"
        Me.ColumnHeaderusername.Width = 154
        '
        'ColumnHeaderTest1
        '
        Me.ColumnHeaderTest1.Text = "Test 1"
        Me.ColumnHeaderTest1.Width = 74
        '
        'ColumnHeaderTest2
        '
        Me.ColumnHeaderTest2.Text = "Test 2"
        Me.ColumnHeaderTest2.Width = 74
        '
        'ColumnHeaderTest3
        '
        Me.ColumnHeaderTest3.Text = "Test 3"
        Me.ColumnHeaderTest3.Width = 69
        '
        'ColumnHeaderFinal
        '
        Me.ColumnHeaderFinal.Text = "Final"
        Me.ColumnHeaderFinal.Width = 86
        '
        'ColumnHeaderTotal
        '
        Me.ColumnHeaderTotal.Text = "Total"
        Me.ColumnHeaderTotal.Width = 77
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(624, 234)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(199, 65)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(278, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 125)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LEGEND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test 1 - Spot The Difference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test 2 - Master Mind" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test 3 - Quick arm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F" &
    "inal - Exam"
        '
        'btnGetResult
        '
        Me.btnGetResult.BackColor = System.Drawing.Color.Black
        Me.btnGetResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetResult.ForeColor = System.Drawing.Color.White
        Me.btnGetResult.Location = New System.Drawing.Point(624, 305)
        Me.btnGetResult.Name = "btnGetResult"
        Me.btnGetResult.Size = New System.Drawing.Size(199, 65)
        Me.btnGetResult.TabIndex = 3
        Me.btnGetResult.Text = "Find Result"
        Me.btnGetResult.UseVisualStyleBackColor = False
        '
        'frmLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 382)
        Me.Controls.Add(Me.btnGetResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLeaderboard"
        Me.Text = "Leaderboard | ARS | BETA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstScore As ListView
    Friend WithEvents ColumnHeaderusername As ColumnHeader
    Friend WithEvents ColumnHeaderTest1 As ColumnHeader
    Friend WithEvents ColumnHeaderTest2 As ColumnHeader
    Friend WithEvents ColumnHeaderTest3 As ColumnHeader
    Friend WithEvents ColumnHeaderFinal As ColumnHeader
    Friend WithEvents ColumnHeaderTotal As ColumnHeader
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGetResult As Button
End Class
