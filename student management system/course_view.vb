Imports System.Data.SqlClient

Public Class course_view
    Sub load_data()
        Try
            dbconnection_module.connectto()
            mycon.Open()
            mydataadapter = New OleDb.OleDbDataAdapter("select * from course ", mycon)
            mydataset = New DataSet
            mydataadapter.Fill(mydataset, "course_table")
            mydatatable = mydataset.Tables(0)
            DataGridView1.DataSource = mydatatable

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycon.Close()
        End Try
    End Sub
    Sub load_combo_items()
        search_combo.Items.Add("All")
        search_combo.Items.Add("Course ID")
        search_combo.Items.Add("Course Name")
        search_combo.Items.Add("Duration")
        search_combo.Items.Add("Fees")
    End Sub
    Private Sub course_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'retrieve data from course table and display in datagridview
        load_data()

        'load items in combo box
        load_combo_items()



    End Sub



    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView1.CellContentClick
        'Dim value As Object = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        'Dim c
        'c = CType(value, String)
        'MessageBox.Show(c)



        Dim index As Integer
        'Dim v As Object

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        ' now show data from the selected row to textboxes
        course_id.Text = selectedRow.Cells(0).Value.ToString()
        course_name.Text = selectedRow.Cells(1).Value.ToString()
        duration.Text = selectedRow.Cells(2).Value.ToString()
        fees.Text = selectedRow.Cells(3).Value.ToString()

        'MessageBox.Show(v)

    End Sub
    Sub cancel()
        course_id.Text = ""
        course_name.Text = ""
        duration.Text = ""
        fees.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cancel()
    End Sub
    Dim flag As Integer
    Sub verify()
        If course_name.Text = "" Then
            flag = 1
            MsgBox("Please enter the Name of Course")
        ElseIf duration.Text = "" Then
            flag = 1
            MsgBox("Please enter the Duration of Course")
        ElseIf fees.Text = "" Then
            flag = 1
            MsgBox("Please enter the Fees of Course")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        flag = 0
        verify()

        If flag = 0 Then
            Try
                dbconnection_module.connectto()
                mycon.Open()

                mycmd = New OleDb.OleDbCommand("update course SET course_name='" & course_name.Text & "', duration=" & duration.Text & ", fees=" & fees.Text & " where course_id=" & course_id.Text & "", mycon)
                mydatareader = mycmd.ExecuteReader()
                mydatareader.Close()
                MsgBox("Information Updated successfully")
                cancel()

                load_data()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mycon.Close()
            End Try
        End If
    End Sub
    Sub verify_search()
        If search_combo.Text = "" Then
            MessageBox.Show("Please select the option ")
            flag = 1
        Else
            If search_value.Text = "" Then
                MessageBox.Show("Please enter the value ")
                flag = 1
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim search_criteria As String

        flag = 0
        verify_search()
        If flag = 0 Then

            Try
                dbconnection_module.connectto()
                mycon.Open()

                If search_combo.Text = "All" Then
                    search_value.Text = ""
                    mydataadapter = New OleDb.OleDbDataAdapter("select * from course ", mycon)

                ElseIf search_combo.Text = "Course ID" Then
                    search_criteria = "course_id"

                    mydataadapter = New OleDb.OleDbDataAdapter("select * from course where " & search_criteria & " = '" & search_value.Text & "' ", mycon)

                ElseIf search_combo.Text = "Course Name" Then
                    search_criteria = "course_name"

                    mydataadapter = New OleDb.OleDbDataAdapter("select * from course where " & search_criteria & " = '" & search_value.Text & "' ", mycon)

                ElseIf search_combo.Text = "Duration" Then
                    search_criteria = "duration"

                    mydataadapter = New OleDb.OleDbDataAdapter("select * from course where " & search_criteria & " = '" & search_value.Text & "' ", mycon)

                ElseIf search_combo.Text = "Fees" Then
                    search_criteria = "fees"

                    mydataadapter = New OleDb.OleDbDataAdapter("select * from course where " & search_criteria & " = '" & search_value.Text & "' ", mycon)

                Else
                    search_criteria = ""
                End If

                mydataset = New DataSet
                mydataadapter.Fill(mydataset, "search_table")
                mydatatable = mydataset.Tables(0)
                DataGridView1.DataSource = mydatatable

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                mycon.Close()
            End Try
        End If
    End Sub

    Private Sub search_value_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_value.TextChanged

    End Sub
End Class