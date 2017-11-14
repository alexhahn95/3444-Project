<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataEntry
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
        Me.components = New System.ComponentModel.Container()
        Me.lblClassSelect = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Fall2017ClassesDataSet = New DANKSolutions_ClassScheduleDSS.Fall2017ClassesDataSet()
        Me.Fall2017ClassesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fall2017ClassesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fall2017ClassesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClassSelect
        '
        Me.lblClassSelect.AutoSize = True
        Me.lblClassSelect.Location = New System.Drawing.Point(396, 392)
        Me.lblClassSelect.Name = "lblClassSelect"
        Me.lblClassSelect.Size = New System.Drawing.Size(268, 25)
        Me.lblClassSelect.TabIndex = 1
        Me.lblClassSelect.Text = "Please select your classes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Evening"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tuesday Thursday"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(379, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(379, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(379, 310)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 31)
        Me.TextBox3.TabIndex = 7
        '
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.Location = New System.Drawing.Point(98, 46)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(359, 25)
        Me.lblWeights.TabIndex = 8
        Me.lblWeights.Text = "Enter desired hours for each section" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(570, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(449, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Enter your allowed deviation for each variable"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(611, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 25)
        Me.Label9.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Monday Wednesday Friday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(253, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Morning"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(379, 146)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 31)
        Me.TextBox7.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(134, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Monday Wednesday"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(379, 204)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 31)
        Me.TextBox8.TabIndex = 19
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(893, 204)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 31)
        Me.TextBox4.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(648, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Monday Wednesday"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(893, 146)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 31)
        Me.TextBox5.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(767, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Morning"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(893, 310)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 31)
        Me.TextBox6.TabIndex = 25
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(893, 259)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 31)
        Me.TextBox9.TabIndex = 24
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(893, 94)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 31)
        Me.TextBox10.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(582, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(275, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Monday Wednesday Friday"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(666, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Tuesday Thursday"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(767, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Evening"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.Fall2017ClassesDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(29, 448)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1052, 446)
        Me.DataGridView1.TabIndex = 30
        '
        'Fall2017ClassesDataSet
        '
        Me.Fall2017ClassesDataSet.DataSetName = "Fall2017ClassesDataSet"
        Me.Fall2017ClassesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fall2017ClassesDataSetBindingSource
        '
        Me.Fall2017ClassesDataSetBindingSource.DataSource = Me.Fall2017ClassesDataSet
        Me.Fall2017ClassesDataSetBindingSource.Position = 0
        '
        'frmDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 1135)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblClassSelect)
        Me.Name = "frmDataEntry"
        Me.Text = "Data Entry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fall2017ClassesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fall2017ClassesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClassSelect As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblWeights As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Fall2017ClassesDataSetBindingSource As BindingSource
    Friend WithEvents Fall2017ClassesDataSet As Fall2017ClassesDataSet
End Class
