Imports System.Data.OleDb
Module DBConnection
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\GYM_DB.accdb")
    Public member_id As String
    Public getdata As OleDbDataReader
    'Public Sub DBCon()
    '    con.Open()
    '
    'End Sub
    Public Function fetchData(ByVal testQ As String) As OleDbDataReader
        Dim recordToGet As New OleDbCommand(testQ, con)
        getdata = recordToGet.ExecuteReader
        getdata.Read()
        Return getdata
        getdata.Close()
    End Function


End Module
