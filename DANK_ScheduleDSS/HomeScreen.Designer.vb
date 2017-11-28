<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomeScreen
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
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnViewTeam = New System.Windows.Forms.Button()
        Me.btnSetSchedule = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnResultsView = New System.Windows.Forms.Button()
        Me.btnModel = New System.Windows.Forms.Button()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(63, 92)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(154, 25)
        Me.lblTeam.TabIndex = 0
        Me.lblTeam.Text = "View the Team"
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Location = New System.Drawing.Point(63, 177)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(192, 25)
        Me.lblSchedule.TabIndex = 1
        Me.lblSchedule.Text = "Set Your Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 2
        '
        'btnViewTeam
        '
        Me.btnViewTeam.Location = New System.Drawing.Point(413, 92)
        Me.btnViewTeam.Name = "btnViewTeam"
        Me.btnViewTeam.Size = New System.Drawing.Size(95, 45)
        Me.btnViewTeam.TabIndex = 3
        Me.btnViewTeam.Text = "View"
        Me.btnViewTeam.UseVisualStyleBackColor = True
        '
        'btnSetSchedule
        '
        Me.btnSetSchedule.Location = New System.Drawing.Point(413, 177)
        Me.btnSetSchedule.Name = "btnSetSchedule"
        Me.btnSetSchedule.Size = New System.Drawing.Size(95, 45)
        Me.btnSetSchedule.TabIndex = 4
        Me.btnSetSchedule.Text = "View"
        Me.btnSetSchedule.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(63, 262)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(136, 25)
        Me.lblResults.TabIndex = 5
        Me.lblResults.Text = "View Results"
        '
        'btnResultsView
        '
        Me.btnResultsView.Location = New System.Drawing.Point(413, 262)
        Me.btnResultsView.Name = "btnResultsView"
        Me.btnResultsView.Size = New System.Drawing.Size(95, 45)
        Me.btnResultsView.TabIndex = 6
        Me.btnResultsView.Text = "View"
        Me.btnResultsView.UseVisualStyleBackColor = True
        '
        'btnModel
        '
        Me.btnModel.Location = New System.Drawing.Point(413, 341)
        Me.btnModel.Name = "btnModel"
        Me.btnModel.Size = New System.Drawing.Size(95, 45)
        Me.btnModel.TabIndex = 8
        Me.btnModel.Text = "View"
        Me.btnModel.UseVisualStyleBackColor = True
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(63, 341)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(245, 25)
        Me.lblModel.TabIndex = 7
        Me.lblModel.Text = "View Mathmatical Model"
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(413, 407)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(95, 45)
        Me.btnInstructions.TabIndex = 10
        Me.btnInstructions.Text = "View"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(63, 407)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(122, 25)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Instructions"
        '
        'frmHomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 571)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.btnResultsView)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnSetSchedule)
        Me.Controls.Add(Me.btnViewTeam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.lblTeam)
        Me.Name = "frmHomeScreen"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeam As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnViewTeam As Button
    Friend WithEvents btnSetSchedule As Button
    Friend WithEvents lblResults As Label
    Friend WithEvents btnResultsView As Button
    Friend WithEvents btnModel As Button
    Friend WithEvents lblModel As Label
    Friend WithEvents btnInstructions As Button
    Friend WithEvents lblInstructions As Label
End Class
