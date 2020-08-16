Imports System.Data.SqlClient
Public Class course_add

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        cancel()

    End Sub
    Sub cancel()

        course_name.Text = ""
        duration.Text = ""
        fees.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            dbconnection_module.connectto()
            mycon.Open()

            mycmd = New OleDb.OleDbCommand("insert into course(course_name, duration, fees, status)values('" & course_name.Text & "'," & duration.Text & "," & fees.Text & ", 'Active' )", mycon)
            mydatareader = mycmd.ExecuteReader()
            mydatareader.Close()
            cancel()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mycon.Close()
        End Try

    End Sub
End Class
