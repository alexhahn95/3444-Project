<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResults
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
        Me.txtCourseResults = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblObjFunction = New System.Windows.Forms.Label()
        Me.txtObjFunction = New System.Windows.Forms.TextBox()
        Me.lblEvening = New System.Windows.Forms.Label()
        Me.lblSurplusTitle = New System.Windows.Forms.Label()
        Me.lblMorning = New System.Windows.Forms.Label()
        Me.lblTR = New System.Windows.Forms.Label()
        Me.lblMW = New System.Windows.Forms.Label()
        Me.lblMWF = New System.Windows.Forms.Label()
        Me.txtEven = New System.Windows.Forms.TextBox()
        Me.txtMorn = New System.Windows.Forms.TextBox()
        Me.txtTR = New System.Windows.Forms.TextBox()
        Me.txtMW = New System.Windows.Forms.TextBox()
        Me.txtMWF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtCourseResults
        '
        Me.txtCourseResults.AutoSize = True
        Me.txtCourseResults.Location = New System.Drawing.Point(535, 74)
        Me.txtCourseResults.Name = "txtCourseResults"
        Me.txtCourseResults.Size = New System.Drawing.Size(159, 25)
        Me.txtCourseResults.TabIndex = 1
        Me.txtCourseResults.Text = "Course Results"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(-43, -88)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'lblObjFunction
        '
        Me.lblObjFunction.AutoSize = True
        Me.lblObjFunction.Location = New System.Drawing.Point(301, 481)
        Me.lblObjFunction.Name = "lblObjFunction"
        Me.lblObjFunction.Size = New System.Drawing.Size(258, 25)
        Me.lblObjFunction.TabIndex = 3
        Me.lblObjFunction.Text = "Objective Function Value:"
        '
        'txtObjFunction
        '
        Me.txtObjFunction.Location = New System.Drawing.Point(707, 475)
        Me.txtObjFunction.Name = "txtObjFunction"
        Me.txtObjFunction.Size = New System.Drawing.Size(236, 31)
        Me.txtObjFunction.TabIndex = 4
        '
        'lblEvening
        '
        Me.lblEvening.AutoSize = True
        Me.lblEvening.Location = New System.Drawing.Point(339, 578)
        Me.lblEvening.Name = "lblEvening"
        Me.lblEvening.Size = New System.Drawing.Size(90, 25)
        Me.lblEvening.TabIndex = 5
        Me.lblEvening.Text = "Evening"
        '
        'lblSurplusTitle
        '
        Me.lblSurplusTitle.AutoSize = True
        Me.lblSurplusTitle.Location = New System.Drawing.Point(525, 522)
        Me.lblSurplusTitle.Name = "lblSurplusTitle"
        Me.lblSurplusTitle.Size = New System.Drawing.Size(186, 25)
        Me.lblSurplusTitle.TabIndex = 6
        Me.lblSurplusTitle.Text = "Slack and Surplus"
        '
        'lblMorning
        '
        Me.lblMorning.AutoSize = True
        Me.lblMorning.Location = New System.Drawing.Point(339, 658)
        Me.lblMorning.Name = "lblMorning"
        Me.lblMorning.Size = New System.Drawing.Size(90, 25)
        Me.lblMorning.TabIndex = 7
        Me.lblMorning.Text = "Morning"
        '
        'lblTR
        '
        Me.lblTR.AutoSize = True
        Me.lblTR.Location = New System.Drawing.Point(339, 732)
        Me.lblTR.Name = "lblTR"
        Me.lblTR.Size = New System.Drawing.Size(191, 25)
        Me.lblTR.TabIndex = 8
        Me.lblTR.Text = "Tuesday/Thursday"
        '
        'lblMW
        '
        Me.lblMW.AutoSize = True
        Me.lblMW.Location = New System.Drawing.Point(339, 817)
        Me.lblMW.Name = "lblMW"
        Me.lblMW.Size = New System.Drawing.Size(209, 25)
        Me.lblMW.TabIndex = 9
        Me.lblMW.Text = "Monday/Wednesday"
        '
        'lblMWF
        '
        Me.lblMWF.AutoSize = True
        Me.lblMWF.Location = New System.Drawing.Point(339, 907)
        Me.lblMWF.Name = "lblMWF"
        Me.lblMWF.Size = New System.Drawing.Size(275, 25)
        Me.lblMWF.TabIndex = 10
        Me.lblMWF.Text = "Monday/Wednesday/Friday"
        '
        'txtEven
        '
        Me.txtEven.Location = New System.Drawing.Point(815, 578)
        Me.txtEven.Name = "txtEven"
        Me.txtEven.Size = New System.Drawing.Size(100, 31)
        Me.txtEven.TabIndex = 11
        '
        'txtMorn
        '
        Me.txtMorn.Location = New System.Drawing.Point(815, 652)
        Me.txtMorn.Name = "txtMorn"
        Me.txtMorn.Size = New System.Drawing.Size(100, 31)
        Me.txtMorn.TabIndex = 12
        '
        'txtTR
        '
        Me.txtTR.Location = New System.Drawing.Point(815, 726)
        Me.txtTR.Name = "txtTR"
        Me.txtTR.Size = New System.Drawing.Size(100, 31)
        Me.txtTR.TabIndex = 13
        '
        'txtMW
        '
        Me.txtMW.Location = New System.Drawing.Point(815, 811)
        Me.txtMW.Name = "txtMW"
        Me.txtMW.Size = New System.Drawing.Size(100, 31)
        Me.txtMW.TabIndex = 14
        '
        'txtMWF
        '
        Me.txtMWF.Location = New System.Drawing.Point(815, 907)
        Me.txtMWF.Name = "txtMWF"
        Me.txtMWF.Size = New System.Drawing.Size(100, 31)
        Me.txtMWF.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 978)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(628, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Negative values denote slack and postive values denote surplus"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 25
        Me.lstResults.Location = New System.Drawing.Point(83, 12)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(1118, 379)
        Me.lstResults.TabIndex = 17
        '
        'frmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 1051)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMWF)
        Me.Controls.Add(Me.txtMW)
        Me.Controls.Add(Me.txtTR)
        Me.Controls.Add(Me.txtMorn)
        Me.Controls.Add(Me.txtEven)
        Me.Controls.Add(Me.lblMWF)
        Me.Controls.Add(Me.lblMW)
        Me.Controls.Add(Me.lblTR)
        Me.Controls.Add(Me.lblMorning)
        Me.Controls.Add(Me.lblSurplusTitle)
        Me.Controls.Add(Me.lblEvening)
        Me.Controls.Add(Me.txtObjFunction)
        Me.Controls.Add(Me.lblObjFunction)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtCourseResults)
        Me.Name = "frmResults"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCourseResults As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblObjFunction As Label
    Friend WithEvents txtObjFunction As TextBox
    Friend WithEvents lblEvening As Label
    Friend WithEvents lblSurplusTitle As Label
    Friend WithEvents lblMorning As Label
    Friend WithEvents lblTR As Label
    Friend WithEvents lblMW As Label
    Friend WithEvents lblMWF As Label
    Friend WithEvents txtEven As TextBox
    Friend WithEvents txtMorn As TextBox
    Friend WithEvents txtTR As TextBox
    Friend WithEvents txtMW As TextBox
    Friend WithEvents txtMWF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstResults As ListBox
End Class
