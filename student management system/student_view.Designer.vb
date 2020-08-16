<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_view
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.search_value = New System.Windows.Forms.TextBox
        Me.search_combo = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.course_id = New System.Windows.Forms.Label
        Me.fees = New System.Windows.Forms.TextBox
        Me.duration = New System.Windows.Forms.TextBox
        Me.course_name = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(794, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 25)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'search_value
        '
        Me.search_value.Location = New System.Drawing.Point(634, 54)
        Me.search_value.Name = "search_value"
        Me.search_value.Size = New System.Drawing.Size(154, 20)
        Me.search_value.TabIndex = 30
        '
        'search_combo
        '
        Me.search_combo.FormattingEnabled = True
        Me.search_combo.Location = New System.Drawing.Point(417, 51)
        Me.search_combo.Name = "search_combo"
        Me.search_combo.Size = New System.Drawing.Size(160, 21)
        Me.search_combo.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(594, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Search By"
        '
        'course_id
        '
        Me.course_id.AutoSize = True
        Me.course_id.Location = New System.Drawing.Point(125, 60)
        Me.course_id.Name = "course_id"
        Me.course_id.Size = New System.Drawing.Size(0, 13)
        Me.course_id.TabIndex = 26
        '
        'fees
        '
        Me.fees.Location = New System.Drawing.Point(122, 213)
        Me.fees.Name = "fees"
        Me.fees.Size = New System.Drawing.Size(197, 20)
        Me.fees.TabIndex = 25
        '
        'duration
        '
        Me.duration.Location = New System.Drawing.Point(122, 164)
        Me.duration.Name = "duration"
        Me.duration.Size = New System.Drawing.Size(197, 20)
        Me.duration.TabIndex = 24
        '
        'course_name
        '
        Me.course_name.Location = New System.Drawing.Point(122, 106)
        Me.course_name.Name = "course_name"
        Me.course_name.Size = New System.Drawing.Size(197, 20)
        Me.course_name.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 43)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 43)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Duration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Course Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Course ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(358, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(489, 345)
        Me.DataGridView1.TabIndex = 16
        '
        'student_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 492)
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
        Me.Name = "student_view"
        Me.Text = "student_view"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents search_value As System.Windows.Forms.TextBox
    Friend WithEvents search_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents course_id As System.Windows.Forms.Label
    Friend WithEvents fees As System.Windows.Forms.TextBox
    Friend WithEvents duration As System.Windows.Forms.TextBox
    Friend WithEvents course_name As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
