Imports System.Data.SqlClient
Public Class student_view
    Sub load_data()
        Try
            dbconnection_module.connectto()
            mycon.Open()
            mydataadapter = New OleDb.OleDbDataAdapter("select * from student status = 'Active' ", mycon)
            mydataset = New DataSet
            mydataadapter.Fill(mydataset, "student_table")
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
    Private Sub student_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_data()
        load_combo_items()
    End Sub
End Class