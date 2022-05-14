Imports MySql.Data.MySqlClient
Public Class Database
    Private Shared connString As String = "Server=localhost; Database=db_visual_basic; Uid=root; Pwd=root;"

    Public Shared Sub TestConection()
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
        Dim conn As MySqlConnection = New MySqlConnection(connString)
        Try
            conn.Open()
            Console.WriteLine("Conexión establecida con la base de datos")
            conn.Close()

            Return conn
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos, verifica la cadena de conexión y que la base de datos exista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Algunas funciones se verán limitadas sin una conexión a la base de datos, revisa la configuración en el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Nothing
    End Function
End Class
