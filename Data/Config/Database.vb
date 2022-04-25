Imports MySql.Data.MySqlClient
Public Class Database
    Private Shared connString As String = "Server=localhost; Database=db_visual_basic; Uid=root; Pwd=root;"

    Public Sub TestConection()
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            MsgBox("Conexión establecida", MsgBoxStyle.Information, "Exito")
            conn.Close()
        Catch ex As Exception
            MsgBox("Conexión fallida", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connString)
    End Function
End Class
