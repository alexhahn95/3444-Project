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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHomeScreen))
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
        Me.grpHome = New System.Windows.Forms.GroupBox()
        Me.grpHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(21, 38)
        Me.lblTeam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(167, 27)
        Me.lblTeam.TabIndex = 0
        Me.lblTeam.Text = "View the Team"
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.Location = New System.Drawing.Point(21, 125)
        Me.lblSchedule.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(213, 27)
        Me.lblSchedule.TabIndex = 1
        Me.lblSchedule.Text = "Set Your Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(576, 341)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 2
        '
        'btnViewTeam
        '
        Me.btnViewTeam.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewTeam.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTeam.Location = New System.Drawing.Point(364, 27)
        Me.btnViewTeam.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnViewTeam.Name = "btnViewTeam"
        Me.btnViewTeam.Size = New System.Drawing.Size(110, 49)
        Me.btnViewTeam.TabIndex = 3
        Me.btnViewTeam.Text = "View"
        Me.btnViewTeam.UseVisualStyleBackColor = False
        '
        'btnSetSchedule
        '
        Me.btnSetSchedule.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSetSchedule.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetSchedule.Location = New System.Drawing.Point(364, 105)
        Me.btnSetSchedule.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSetSchedule.Name = "btnSetSchedule"
        Me.btnSetSchedule.Size = New System.Drawing.Size(110, 49)
        Me.btnSetSchedule.TabIndex = 4
        Me.btnSetSchedule.Text = "View"
        Me.btnSetSchedule.UseVisualStyleBackColor = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(21, 218)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(150, 27)
        Me.lblResults.TabIndex = 5
        Me.lblResults.Text = "View Results"
        '
        'btnResultsView
        '
        Me.btnResultsView.BackColor = System.Drawing.Color.Gainsboro
        Me.btnResultsView.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultsView.Location = New System.Drawing.Point(364, 198)
        Me.btnResultsView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnResultsView.Name = "btnResultsView"
        Me.btnResultsView.Size = New System.Drawing.Size(110, 49)
        Me.btnResultsView.TabIndex = 6
        Me.btnResultsView.Text = "View"
        Me.btnResultsView.UseVisualStyleBackColor = False
        '
        'btnModel
        '
        Me.btnModel.BackColor = System.Drawing.Color.Gainsboro
        Me.btnModel.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModel.Location = New System.Drawing.Point(364, 282)
        Me.btnModel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnModel.Name = "btnModel"
        Me.btnModel.Size = New System.Drawing.Size(110, 49)
        Me.btnModel.TabIndex = 8
        Me.btnModel.Text = "View"
        Me.btnModel.UseVisualStyleBackColor = False
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(21, 302)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(270, 27)
        Me.lblModel.TabIndex = 7
        Me.lblModel.Text = "View Mathmatical Model"
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.Gainsboro
        Me.btnInstructions.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(364, 353)
        Me.btnInstructions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(110, 49)
        Me.btnInstructions.TabIndex = 10
        Me.btnInstructions.Text = "View"
        Me.btnInstructions.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(21, 373)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(136, 27)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Instructions"
        '
        'grpHome
        '
        Me.grpHome.BackColor = System.Drawing.Color.Gainsboro
        Me.grpHome.Controls.Add(Me.lblTeam)
        Me.grpHome.Controls.Add(Me.btnInstructions)
        Me.grpHome.Controls.Add(Me.lblSchedule)
        Me.grpHome.Controls.Add(Me.lblInstructions)
        Me.grpHome.Controls.Add(Me.btnViewTeam)
        Me.grpHome.Controls.Add(Me.btnModel)
        Me.grpHome.Controls.Add(Me.btnSetSchedule)
        Me.grpHome.Controls.Add(Me.lblModel)
        Me.grpHome.Controls.Add(Me.lblResults)
        Me.grpHome.Controls.Add(Me.btnResultsView)
        Me.grpHome.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHome.Location = New System.Drawing.Point(221, 88)
        Me.grpHome.Name = "grpHome"
        Me.grpHome.Size = New System.Drawing.Size(511, 431)
        Me.grpHome.TabIndex = 11
        Me.grpHome.TabStop = False
        '
        'frmHomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(953, 603)
        Me.Controls.Add(Me.grpHome)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmHomeScreen"
        Me.Text = "Home"
        Me.grpHome.ResumeLayout(False)
        Me.grpHome.PerformLayout()
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
    Friend WithEvents grpHome As GroupBox
End Class
