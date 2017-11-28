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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnViewTeam = New System.Windows.Forms.Button()
        Me.btnSetSchedule = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnResultsView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View the Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Set Your Schedule"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "View Results"
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
        'frmHomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 571)
        Me.Controls.Add(Me.btnResultsView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSetSchedule)
        Me.Controls.Add(Me.btnViewTeam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHomeScreen"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnViewTeam As Button
    Friend WithEvents btnSetSchedule As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnResultsView As Button
End Class
