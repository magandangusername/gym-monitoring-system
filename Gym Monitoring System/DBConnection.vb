Imports System.Data.OleDb
Module DBConnection
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\GYM_DB.accdb")
    'Public Sub DBCon()
    '    con.Open()
    '
    'End Sub

End Module
