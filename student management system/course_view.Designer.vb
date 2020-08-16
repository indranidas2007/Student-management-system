<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class course_view
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.course_name = New System.Windows.Forms.TextBox
        Me.duration = New System.Windows.Forms.TextBox
        Me.fees = New System.Windows.Forms.TextBox
        Me.course_id = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.search_combo = New System.Windows.Forms.ComboBox
        Me.search_value = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(369, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(489, 345)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Course ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Course Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Duration"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fees"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 43)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'course_name
        '
        Me.course_name.Location = New System.Drawing.Point(133, 113)
        Me.course_name.Name = "course_name"
        Me.course_name.Size = New System.Drawing.Size(197, 20)
        Me.course_name.TabIndex = 7
        '
        'duration
        '
        Me.duration.Location = New System.Drawing.Point(133, 171)
        Me.duration.Name = "duration"
        Me.duration.Size = New System.Drawing.Size(197, 20)
        Me.duration.TabIndex = 8
        '
        'fees
        '
        Me.fees.Location = New System.Drawing.Point(133, 220)
        Me.fees.Name = "fees"
        Me.fees.Size = New System.Drawing.Size(197, 20)
        Me.fees.TabIndex = 9
        '
        'course_id
        '
        Me.course_id.AutoSize = True
        Me.course_id.Location = New System.Drawing.Point(136, 67)
        Me.course_id.Name = "course_id"
        Me.course_id.Size = New System.Drawing.Size(0, 13)
        Me.course_id.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Search By"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Value"
        '
        'search_combo
        '
        Me.search_combo.FormattingEnabled = True
        Me.search_combo.Location = New System.Drawing.Point(428, 58)
        Me.search_combo.Name = "search_combo"
        Me.search_combo.Size = New System.Drawing.Size(160, 21)
        Me.search_combo.TabIndex = 13
        '
        'search_value
        '
        Me.search_value.Location = New System.Drawing.Point(645, 61)
        Me.search_value.Name = "search_value"
        Me.search_value.Size = New System.Drawing.Size(154, 20)
        Me.search_value.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(805, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'course_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 500)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.search_value)
        Me.Controls.Add(Me.search_combo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.course_id)
        Me.Controls.Add(Me.fees)
        Me.Controls.Add(Me.duration)
        Me.Controls.Add(Me.course_name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "course_view"
        Me.Text = "course_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents course_name As System.Windows.Forms.TextBox
    Friend WithEvents duration As System.Windows.Forms.TextBox
    Friend WithEvents fees As System.Windows.Forms.TextBox
    Friend WithEvents course_id As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents search_combo As System.Windows.Forms.ComboBox
    Friend WithEvents search_value As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
