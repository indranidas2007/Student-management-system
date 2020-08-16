Imports System.Data.SqlClient
Public Class student_add
    Dim flag, s_id As Integer
    Dim gen, image_pathname As String
    Private Sub student_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gid()
            dbconnection_module.connectto()
            mycon.Open()
            course_combo.Items.Clear()

            course_combo.DisplayMember = "Text"
            course_combo.ValueMember = "Value"
            Dim tb As New DataTable
            tb.Columns.Add("Text", GetType(String))
            tb.Columns.Add("Value", GetType(Integer))

            mycmd = New OleDb.OleDbCommand("select * from course where status = 'Active' ", mycon)
            mydatareader = mycmd.ExecuteReader
            If mydatareader.HasRows = True Then
                While mydatareader.Read()
                    tb.Rows.Add(mydatareader(0).ToString & " - " & mydatareader(1).ToString, mydatareader(0))
                    'course_combo.Items.Add(mydatareader(1).ToString)

                End While
                course_combo.DataSource = tb
            Else
                course_combo.Text = ""
            End If

            mydatareader.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycon.Close()
        End Try


    End Sub

    Sub verify()
        If name_text.Text = "" Then
            flag = 1
            MsgBox("Please enter the name of the student")
        ElseIf male_radio.Checked = False And female_radio.Checked = False Then
            flag = 1
            MsgBox("Please select the Gender")
        ElseIf phone_text.Text = "" Then
            flag = 1
            MsgBox("Please enter the Phone Number")
        ElseIf email_text.Text = "" Then
            flag = 1
            MsgBox("Please enter the Email ID")
        ElseIf course_combo.Text = "" Then
            flag = 1
            MsgBox("Please select the Course")
        ElseIf dob_datetimepicker.Text = "" Then
            flag = 1
            MsgBox("Please enter the Date of Birth")
        ElseIf doa_datetimepicker.Text = "" Then
            flag = 1
            MsgBox("Please enter the Date of Admission")
        ElseIf image_location.Text = "" Then
            flag = 1
            MsgBox("Please upload a photo")
        End If
    End Sub
    Sub gid()
        dbconnection_module.connectto()
        mycon.Open()
        mycmd = New OleDb.OleDbCommand("select * from student", mycon)
        mydatareader = mycmd.ExecuteReader()
        If mydatareader.HasRows() = True Then
            While mydatareader.Read()
                s_id = Convert.ToInt32(mydatareader(0).ToString())
            End While
            s_id = s_id + 1
        Else
            s_id = 10001
        End If
        student_id.Text = Convert.ToString(s_id)
        mydatareader.Close()
        mycon.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c_id, x As Integer
        flag = 0
        verify()
        If flag = 0 Then
            If male_radio.Checked = True Then
                gen = "Male"
            ElseIf female_radio.Checked = True Then
                gen = "Female"
            End If

            If course_combo.Text <> "" Then
                c_id = course_combo.SelectedValue
                'MessageBox.Show(s_id & vbCrLf & c_id)
            End If

            Try
                dbconnection_module.connectto()
                mycon.Open()


                'mycmd = New SqlCommand("insert into enrolls(s_id,course_id,doa,status, users_id) values ('" & student_id.Text & "','" & c_id & "','" & date2 & "','Active', 101 )", mycon)
                'mydatareader = mycmd.ExecuteReader()
                'mydatareader.Close()


                mycmd = New OleDb.OleDbCommand("insert into enrolls(s_id,course_id,doa,status, users_id) values (@s_id, @c_id, @doa, @status, @users_id)", mycon)
                mycmd.Parameters.AddWithValue("@s_id", student_id.Text)
                mycmd.Parameters.AddWithValue("@c_id", c_id)
                mycmd.Parameters.AddWithValue("@doa", doa_datetimepicker.Value)
                mycmd.Parameters.AddWithValue("@status", "Active")
                mycmd.Parameters.AddWithValue("@users_id", 101)
                mycmd.ExecuteNonQuery()



                mycmd = New OleDb.OleDbCommand("insert into student(s_id, name, gender, phone, email, dob, photo, status)values(@s_id, @name, @gender, @phone, @email, @dob, @photo, @status)", mycon)
                mycmd.Parameters.AddWithValue("@s_id", student_id.Text)
                mycmd.Parameters.AddWithValue("@name", name_text.Text)
                mycmd.Parameters.AddWithValue("@gender", gen)
                mycmd.Parameters.AddWithValue("@phone", phone_text.Text)
                mycmd.Parameters.AddWithValue("@email", email_text.Text)
                mycmd.Parameters.AddWithValue("@dob", dob_datetimepicker.Value)
                mycmd.Parameters.Add(New OleDb.OleDbParameter("@photo", SqlDbType.Image)).Value = IO.File.ReadAllBytes(image_location.Text)
                mycmd.Parameters.AddWithValue("@status", "Active")
                x = mycmd.ExecuteNonQuery()
                MsgBox("Information Saved Successfully = " & x)
                cancel()
                gid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mycon.Close()
            End Try

        End If
        

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
        image_location.Text = OpenFileDialog1.FileName
    End Sub

    Sub cancel()
        name_text.Text = ""
        male_radio.Checked = False
        female_radio.Checked = False
        phone_text.Text = ""
        email_text.Text = ""
        course_combo.Text = ""
        dob_datetimepicker.Text = ""
        doa_datetimepicker.Text = ""
        PictureBox1.Image = Nothing
        image_location.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancel()
    End Sub
End Class