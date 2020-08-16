<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_add
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.name_text = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.image_location = New System.Windows.Forms.TextBox
        Me.male_radio = New System.Windows.Forms.RadioButton
        Me.female_radio = New System.Windows.Forms.RadioButton
        Me.phone_text = New System.Windows.Forms.TextBox
        Me.email_text = New System.Windows.Forms.TextBox
        Me.course_combo = New System.Windows.Forms.ComboBox
        Me.dob_datetimepicker = New System.Windows.Forms.DateTimePicker
        Me.doa_datetimepicker = New System.Windows.Forms.DateTimePicker
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label9 = New System.Windows.Forms.Label
        Me.student_id = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(354, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Course"
        '
        'name_text
        '
        Me.name_text.Location = New System.Drawing.Point(245, 77)
        Me.name_text.Name = "name_text"
        Me.name_text.Size = New System.Drawing.Size(243, 20)
        Me.name_text.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(602, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(620, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 36)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Browse Photo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(124, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date of Admission"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(533, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Image Directory"
        '
        'image_location
        '
        Me.image_location.Enabled = False
        Me.image_location.Location = New System.Drawing.Point(620, 287)
        Me.image_location.Name = "image_location"
        Me.image_location.Size = New System.Drawing.Size(183, 20)
        Me.image_location.TabIndex = 13
        '
        'male_radio
        '
        Me.male_radio.AutoSize = True
        Me.male_radio.Location = New System.Drawing.Point(245, 128)
        Me.male_radio.Name = "male_radio"
        Me.male_radio.Size = New System.Drawing.Size(48, 17)
        Me.male_radio.TabIndex = 14
        Me.male_radio.TabStop = True
        Me.male_radio.Text = "Male"
        Me.male_radio.UseVisualStyleBackColor = True
        '
        'female_radio
        '
        Me.female_radio.AutoSize = True
        Me.female_radio.Location = New System.Drawing.Point(326, 128)
        Me.female_radio.Name = "female_radio"
        Me.female_radio.Size = New System.Drawing.Size(59, 17)
        Me.female_radio.TabIndex = 15
        Me.female_radio.TabStop = True
        Me.female_radio.Text = "Female"
        Me.female_radio.UseVisualStyleBackColor = True
        '
        'phone_text
        '
        Me.phone_text.Location = New System.Drawing.Point(245, 169)
        Me.phone_text.Name = "phone_text"
        Me.phone_text.Size = New System.Drawing.Size(243, 20)
        Me.phone_text.TabIndex = 16
        '
        'email_text
        '
        Me.email_text.Location = New System.Drawing.Point(245, 210)
        Me.email_text.Name = "email_text"
        Me.email_text.Size = New System.Drawing.Size(243, 20)
        Me.email_text.TabIndex = 17
        '
        'course_combo
        '
        Me.course_combo.FormattingEnabled = True
        Me.course_combo.Location = New System.Drawing.Point(245, 260)
        Me.course_combo.Name = "course_combo"
        Me.course_combo.Size = New System.Drawing.Size(243, 21)
        Me.course_combo.TabIndex = 18
        '
        'dob_datetimepicker
        '
        Me.dob_datetimepicker.Location = New System.Drawing.Point(245, 301)
        Me.dob_datetimepicker.MaxDate = New Date(2018, 8, 20, 0, 0, 0, 0)
        Me.dob_datetimepicker.Name = "dob_datetimepicker"
        Me.dob_datetimepicker.Size = New System.Drawing.Size(182, 20)
        Me.dob_datetimepicker.TabIndex = 19
        Me.dob_datetimepicker.Value = New Date(2018, 8, 20, 0, 0, 0, 0)
        '
        'doa_datetimepicker
        '
        Me.doa_datetimepicker.Location = New System.Drawing.Point(245, 341)
        Me.doa_datetimepicker.MaxDate = New Date(2018, 8, 20, 0, 0, 0, 0)
        Me.doa_datetimepicker.Name = "doa_datetimepicker"
        Me.doa_datetimepicker.Size = New System.Drawing.Size(182, 20)
        Me.doa_datetimepicker.TabIndex = 20
        Me.doa_datetimepicker.Value = New Date(2018, 8, 20, 0, 0, 0, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Student ID"
        '
        'student_id
        '
        Me.student_id.Enabled = False
        Me.student_id.Location = New System.Drawing.Point(245, 34)
        Me.student_id.Name = "student_id"
        Me.student_id.Size = New System.Drawing.Size(243, 20)
        Me.student_id.TabIndex = 22
        '
        'student_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 484)
        Me.Controls.Add(Me.student_id)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.doa_datetimepicker)
        Me.Controls.Add(Me.dob_datetimepicker)
        Me.Controls.Add(Me.course_combo)
        Me.Controls.Add(Me.email_text)
        Me.Controls.Add(Me.phone_text)
        Me.Controls.Add(Me.female_radio)
        Me.Controls.Add(Me.male_radio)
        Me.Controls.Add(Me.image_location)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.name_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "student_add"
        Me.Text = "student_add"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents name_text As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents image_location As System.Windows.Forms.TextBox
    Friend WithEvents male_radio As System.Windows.Forms.RadioButton
    Friend WithEvents female_radio As System.Windows.Forms.RadioButton
    Friend WithEvents phone_text As System.Windows.Forms.TextBox
    Friend WithEvents email_text As System.Windows.Forms.TextBox
    Friend WithEvents course_combo As System.Windows.Forms.ComboBox
    Friend WithEvents dob_datetimepicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents doa_datetimepicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents student_id As System.Windows.Forms.TextBox
End Class
