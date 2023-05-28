Imports System.Data.OleDb
Module DBConnection
    'global variables that will be used multiple times in diff forms
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\GYM_DB.accdb")
    Public member_id As String = "0"
    Public getdata As OleDbDataReader

    Public Function fetchData(ByVal Q As String) As OleDbDataReader
        openCon()
        Dim recordToGet As New OleDbCommand(Q, con)
        getdata = recordToGet.ExecuteReader
        getdata.Read()
        Return getdata
    End Function

    Public Sub openCon()
        If con.State = ConnectionState.Open Then
            Exit Sub
        Else
            con.Open()
        End If
    End Sub
    Public Sub closeCon()
        If con.State = ConnectionState.Closed Then
            Exit Sub
        Else
            con.Close()
        End If
    End Sub

End Module
