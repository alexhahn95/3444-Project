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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResults))
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
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.tabResults = New System.Windows.Forms.TabControl()
        Me.Results = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabResults.SuspendLayout()
        Me.Results.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(-29, -56)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(68, 63)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'lblObjFunction
        '
        Me.lblObjFunction.AutoSize = True
        Me.lblObjFunction.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjFunction.Location = New System.Drawing.Point(174, 82)
        Me.lblObjFunction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObjFunction.Name = "lblObjFunction"
        Me.lblObjFunction.Size = New System.Drawing.Size(286, 27)
        Me.lblObjFunction.TabIndex = 3
        Me.lblObjFunction.Text = "Objective Function Value:"
        '
        'txtObjFunction
        '
        Me.txtObjFunction.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObjFunction.Location = New System.Drawing.Point(484, 75)
        Me.txtObjFunction.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObjFunction.Name = "txtObjFunction"
        Me.txtObjFunction.Size = New System.Drawing.Size(159, 34)
        Me.txtObjFunction.TabIndex = 4
        '
        'lblEvening
        '
        Me.lblEvening.AutoSize = True
        Me.lblEvening.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvening.Location = New System.Drawing.Point(193, 190)
        Me.lblEvening.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEvening.Name = "lblEvening"
        Me.lblEvening.Size = New System.Drawing.Size(99, 27)
        Me.lblEvening.TabIndex = 5
        Me.lblEvening.Text = "Evening"
        '
        'lblSurplusTitle
        '
        Me.lblSurplusTitle.AutoSize = True
        Me.lblSurplusTitle.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurplusTitle.Location = New System.Drawing.Point(335, 136)
        Me.lblSurplusTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSurplusTitle.Name = "lblSurplusTitle"
        Me.lblSurplusTitle.Size = New System.Drawing.Size(210, 27)
        Me.lblSurplusTitle.TabIndex = 6
        Me.lblSurplusTitle.Text = "Slack and Surplus"
        '
        'lblMorning
        '
        Me.lblMorning.AutoSize = True
        Me.lblMorning.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMorning.Location = New System.Drawing.Point(193, 242)
        Me.lblMorning.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMorning.Name = "lblMorning"
        Me.lblMorning.Size = New System.Drawing.Size(99, 27)
        Me.lblMorning.TabIndex = 7
        Me.lblMorning.Text = "Morning"
        '
        'lblTR
        '
        Me.lblTR.AutoSize = True
        Me.lblTR.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTR.Location = New System.Drawing.Point(193, 294)
        Me.lblTR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTR.Name = "lblTR"
        Me.lblTR.Size = New System.Drawing.Size(211, 27)
        Me.lblTR.TabIndex = 8
        Me.lblTR.Text = "Tuesday/Thursday"
        '
        'lblMW
        '
        Me.lblMW.AutoSize = True
        Me.lblMW.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMW.Location = New System.Drawing.Point(193, 346)
        Me.lblMW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMW.Name = "lblMW"
        Me.lblMW.Size = New System.Drawing.Size(232, 27)
        Me.lblMW.TabIndex = 9
        Me.lblMW.Text = "Monday/Wednesday"
        '
        'lblMWF
        '
        Me.lblMWF.AutoSize = True
        Me.lblMWF.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMWF.Location = New System.Drawing.Point(193, 398)
        Me.lblMWF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMWF.Name = "lblMWF"
        Me.lblMWF.Size = New System.Drawing.Size(306, 27)
        Me.lblMWF.TabIndex = 10
        Me.lblMWF.Text = "Monday/Wednesday/Friday"
        '
        'txtEven
        '
        Me.txtEven.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEven.Location = New System.Drawing.Point(555, 183)
        Me.txtEven.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEven.Name = "txtEven"
        Me.txtEven.Size = New System.Drawing.Size(68, 34)
        Me.txtEven.TabIndex = 11
        '
        'txtMorn
        '
        Me.txtMorn.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMorn.Location = New System.Drawing.Point(555, 235)
        Me.txtMorn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMorn.Name = "txtMorn"
        Me.txtMorn.Size = New System.Drawing.Size(68, 34)
        Me.txtMorn.TabIndex = 12
        '
        'txtTR
        '
        Me.txtTR.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTR.Location = New System.Drawing.Point(555, 287)
        Me.txtTR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTR.Name = "txtTR"
        Me.txtTR.Size = New System.Drawing.Size(68, 34)
        Me.txtTR.TabIndex = 13
        '
        'txtMW
        '
        Me.txtMW.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMW.Location = New System.Drawing.Point(555, 339)
        Me.txtMW.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMW.Name = "txtMW"
        Me.txtMW.Size = New System.Drawing.Size(68, 34)
        Me.txtMW.TabIndex = 14
        '
        'txtMWF
        '
        Me.txtMWF.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMWF.Location = New System.Drawing.Point(555, 391)
        Me.txtMWF.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMWF.Name = "txtMWF"
        Me.txtMWF.Size = New System.Drawing.Size(68, 34)
        Me.txtMWF.TabIndex = 15
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 23
        Me.lstResults.Location = New System.Drawing.Point(5, 102)
        Me.lstResults.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(926, 418)
        Me.lstResults.TabIndex = 17
        '
        'tabResults
        '
        Me.tabResults.Controls.Add(Me.Results)
        Me.tabResults.Controls.Add(Me.TabPage2)
        Me.tabResults.Location = New System.Drawing.Point(84, 53)
        Me.tabResults.Name = "tabResults"
        Me.tabResults.SelectedIndex = 0
        Me.tabResults.Size = New System.Drawing.Size(944, 667)
        Me.tabResults.TabIndex = 18
        '
        'Results
        '
        Me.Results.BackColor = System.Drawing.Color.Gainsboro
        Me.Results.Controls.Add(Me.lstResults)
        Me.Results.Location = New System.Drawing.Point(4, 25)
        Me.Results.Name = "Results"
        Me.Results.Padding = New System.Windows.Forms.Padding(3)
        Me.Results.Size = New System.Drawing.Size(936, 638)
        Me.Results.TabIndex = 0
        Me.Results.Text = "Results"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.lblObjFunction)
        Me.TabPage2.Controls.Add(Me.txtObjFunction)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblEvening)
        Me.TabPage2.Controls.Add(Me.txtMWF)
        Me.TabPage2.Controls.Add(Me.lblSurplusTitle)
        Me.TabPage2.Controls.Add(Me.txtMW)
        Me.TabPage2.Controls.Add(Me.lblMorning)
        Me.TabPage2.Controls.Add(Me.txtTR)
        Me.TabPage2.Controls.Add(Me.lblTR)
        Me.TabPage2.Controls.Add(Me.txtMorn)
        Me.TabPage2.Controls.Add(Me.lblMW)
        Me.TabPage2.Controls.Add(Me.txtEven)
        Me.TabPage2.Controls.Add(Me.lblMWF)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(936, 638)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LP Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 474)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(698, 27)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Negative values denote slack and postive values denote surplus"
        '
        'frmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1112, 773)
        Me.Controls.Add(Me.tabResults)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmResults"
        Me.Text = "Results"
        Me.tabResults.ResumeLayout(False)
        Me.Results.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents lstResults As ListBox
    Friend WithEvents tabResults As TabControl
    Friend WithEvents Results As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
End Class
