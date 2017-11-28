<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRequestedCourses = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEvening = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMorning = New System.Windows.Forms.TextBox()
        Me.txtTR = New System.Windows.Forms.TextBox()
        Me.txtMW = New System.Windows.Forms.TextBox()
        Me.txtMWF = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabPage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPage)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(51, 30)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 512)
        Me.TabControl1.TabIndex = 0
        '
        'tabPage
        '
        Me.tabPage.Controls.Add(Me.txtRequestedCourses)
        Me.tabPage.Controls.Add(Me.Label1)
        Me.tabPage.Location = New System.Drawing.Point(8, 39)
        Me.tabPage.Name = "tabPage"
        Me.tabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage.Size = New System.Drawing.Size(728, 465)
        Me.tabPage.TabIndex = 0
        Me.tabPage.Text = "TabPage1"
        Me.tabPage.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMWF)
        Me.TabPage2.Controls.Add(Me.txtMW)
        Me.TabPage2.Controls.Add(Me.txtTR)
        Me.TabPage2.Controls.Add(Me.txtMorning)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtEvening)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(728, 465)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount of requested courses"
        '
        'txtRequestedCourses
        '
        Me.txtRequestedCourses.Location = New System.Drawing.Point(388, 37)
        Me.txtRequestedCourses.Name = "txtRequestedCourses"
        Me.txtRequestedCourses.Size = New System.Drawing.Size(138, 31)
        Me.txtRequestedCourses.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCalculate)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 465)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Evening Courses Goal"
        '
        'txtEvening
        '
        Me.txtEvening.Location = New System.Drawing.Point(412, 51)
        Me.txtEvening.Name = "txtEvening"
        Me.txtEvening.Size = New System.Drawing.Size(196, 31)
        Me.txtEvening.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Morning Courses Goal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tuesday/Thursday Goal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monday/Wednesday Goal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(326, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Monday/Wednesday/Friday Goal"
        '
        'txtMorning
        '
        Me.txtMorning.Location = New System.Drawing.Point(412, 123)
        Me.txtMorning.Name = "txtMorning"
        Me.txtMorning.Size = New System.Drawing.Size(196, 31)
        Me.txtMorning.TabIndex = 6
        '
        'txtTR
        '
        Me.txtTR.Location = New System.Drawing.Point(412, 196)
        Me.txtTR.Name = "txtTR"
        Me.txtTR.Size = New System.Drawing.Size(196, 31)
        Me.txtTR.TabIndex = 7
        '
        'txtMW
        '
        Me.txtMW.Location = New System.Drawing.Point(412, 273)
        Me.txtMW.Name = "txtMW"
        Me.txtMW.Size = New System.Drawing.Size(196, 31)
        Me.txtMW.TabIndex = 8
        '
        'txtMWF
        '
        Me.txtMWF.Location = New System.Drawing.Point(412, 346)
        Me.txtMWF.Name = "txtMWF"
        Me.txtMWF.Size = New System.Drawing.Size(196, 31)
        Me.txtMWF.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(94, 121)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(523, 185)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 609)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSchedule"
        Me.Text = "Set Schedule"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPage.ResumeLayout(False)
        Me.tabPage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtRequestedCourses As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtEvening As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMWF As TextBox
    Friend WithEvents txtMW As TextBox
    Friend WithEvents txtTR As TextBox
    Friend WithEvents txtMorning As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
End Class
