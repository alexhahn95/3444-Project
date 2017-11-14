<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Me.tblResults = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMonday = New System.Windows.Forms.Label()
        Me.lblTuesday = New System.Windows.Forms.Label()
        Me.lblWednesday = New System.Windows.Forms.Label()
        Me.lblThursday = New System.Windows.Forms.Label()
        Me.lblFriday = New System.Windows.Forms.Label()
        Me.tblResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblResults
        '
        Me.tblResults.ColumnCount = 5
        Me.tblResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResults.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblResults.Controls.Add(Me.lblMonday, 0, 0)
        Me.tblResults.Controls.Add(Me.lblTuesday, 1, 0)
        Me.tblResults.Controls.Add(Me.lblWednesday, 2, 0)
        Me.tblResults.Controls.Add(Me.lblThursday, 3, 0)
        Me.tblResults.Controls.Add(Me.lblFriday, 4, 0)
        Me.tblResults.Location = New System.Drawing.Point(39, 30)
        Me.tblResults.Name = "tblResults"
        Me.tblResults.RowCount = 8
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tblResults.Size = New System.Drawing.Size(1214, 818)
        Me.tblResults.TabIndex = 0
        '
        'lblMonday
        '
        Me.lblMonday.AutoSize = True
        Me.lblMonday.Location = New System.Drawing.Point(3, 0)
        Me.lblMonday.Name = "lblMonday"
        Me.lblMonday.Size = New System.Drawing.Size(89, 25)
        Me.lblMonday.TabIndex = 0
        Me.lblMonday.Text = "Monday"
        '
        'lblTuesday
        '
        Me.lblTuesday.AutoSize = True
        Me.lblTuesday.Location = New System.Drawing.Point(245, 0)
        Me.lblTuesday.Name = "lblTuesday"
        Me.lblTuesday.Size = New System.Drawing.Size(95, 25)
        Me.lblTuesday.TabIndex = 1
        Me.lblTuesday.Text = "Tuesday"
        '
        'lblWednesday
        '
        Me.lblWednesday.AutoSize = True
        Me.lblWednesday.Location = New System.Drawing.Point(487, 0)
        Me.lblWednesday.Name = "lblWednesday"
        Me.lblWednesday.Size = New System.Drawing.Size(126, 25)
        Me.lblWednesday.TabIndex = 2
        Me.lblWednesday.Text = "Wednesday"
        '
        'lblThursday
        '
        Me.lblThursday.AutoSize = True
        Me.lblThursday.Location = New System.Drawing.Point(729, 0)
        Me.lblThursday.Name = "lblThursday"
        Me.lblThursday.Size = New System.Drawing.Size(102, 25)
        Me.lblThursday.TabIndex = 3
        Me.lblThursday.Text = "Thursday"
        '
        'lblFriday
        '
        Me.lblFriday.AutoSize = True
        Me.lblFriday.Location = New System.Drawing.Point(971, 0)
        Me.lblFriday.Name = "lblFriday"
        Me.lblFriday.Size = New System.Drawing.Size(72, 25)
        Me.lblFriday.TabIndex = 4
        Me.lblFriday.Text = "Friday"
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 881)
        Me.Controls.Add(Me.tblResults)
        Me.Name = "Results"
        Me.Text = "Results"
        Me.tblResults.ResumeLayout(False)
        Me.tblResults.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tblResults As TableLayoutPanel
    Friend WithEvents lblMonday As Label
    Friend WithEvents lblTuesday As Label
    Friend WithEvents lblWednesday As Label
    Friend WithEvents lblThursday As Label
    Friend WithEvents lblFriday As Label
End Class
