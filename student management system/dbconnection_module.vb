

Module dbconnection_module
    Public mycon As OleDb.OleDbConnection
    Public mycmd As OleDb.OleDbCommand
    Public mydatareader As OleDb.OleDbDataReader
    Public mydataadapter As OleDb.OleDbDataAdapter
    Public mydataset As DataSet
    Public mydatatable As DataTable
    Public servername As String

    Sub connectto()
        servername = My.Computer.Name.ToString() + "\xe"
        mycon = New OleDb.OleDbConnection("Server = " & servername & "; Database = ; Integrated Security = TRUE; provider=ODP.NET, Managed Driver")

    End Sub

End Module
