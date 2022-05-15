Imports MySql.Data.MySqlClient

Public Class EstudianteController
    Private Shared ReadOnly conn As MySqlConnection = Database.GetConnection()
    Private Shared cmd As New MySqlCommand

    Public Shared Function GetAllStudents() As DataTable
        If conn Is Nothing Then
            Return New DataTable
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_obtener_estudiantes", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dTable As New DataTable

            adapter.Fill(dTable)

            Return dTable
        Catch ex As Exception
            MessageBox.Show("No se pudo listar los estudiantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            conn.Close()
        End Try

        Return Nothing
    End Function

    Public Shared Function GetStudentById(ByVal std As EstudianteModel) As EstudianteModel
        If conn Is Nothing Then
            Return New EstudianteModel With {
                .Id_estudiante = 0,
                .Nombres = "Sin referencia",
                .Apellidos = "Sin referencia",
                .Email = "Sin referencia",
                .Password = "**********"
            }
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_obtener_estudiante", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("id_estudiante_get", MySqlDbType.Int32).Value = std.Id_estudiante

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim estudiante As New EstudianteModel
                estudiante.Id_estudiante = reader.GetInt32("id_estudiante")
                estudiante.Nombres = reader.GetString("nombres")
                estudiante.Apellidos = reader.GetString("apellidos")
                estudiante.Email = reader.GetString("email")
                estudiante.Password = reader.GetString("password")

                Return estudiante
            Else
                Return Nothing
            End If

            Return std
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            conn.Close()
        End Try

        Return Nothing
    End Function

    Public Shared Function GetStudentByEmail(ByVal std As EstudianteModel) As EstudianteModel
        If conn Is Nothing Then
            Return New EstudianteModel With {
                .Id_estudiante = 0,
                .Nombres = "Sin referencia",
                .Apellidos = "Sin referencia",
                .Email = "Sin referencia",
                .Password = "**********"
            }
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_obtener_estudiante_email", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("email_get", MySqlDbType.String).Value = std.Email

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim estudiante As New EstudianteModel
                estudiante.Id_estudiante = reader.GetInt32("id_estudiante")
                estudiante.Nombres = reader.GetString("nombres")
                estudiante.Apellidos = reader.GetString("apellidos")
                estudiante.Email = reader.GetString("email")
                estudiante.Password = reader.GetString("password")

                Return estudiante
            Else
                Return Nothing
            End If

            Return std
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            conn.Close()
        End Try

        Return Nothing
    End Function

    Public Shared Function InsertStudent(ByVal std As EstudianteModel) As Boolean
        If conn Is Nothing Then
            Return False
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_insertar_estudiante", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("nombres", MySqlDbType.String).Value = std.Nombres
            cmd.Parameters.Add("apellidos", MySqlDbType.String).Value = std.Apellidos
            cmd.Parameters.Add("email", MySqlDbType.String).Value = std.Email
            cmd.Parameters.Add("password", MySqlDbType.String).Value = std.Password

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo insertar el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try

        Return False
    End Function

    Public Shared Function UpdateStudent(ByVal std As EstudianteModel) As Boolean
        If conn Is Nothing Then
            Return False
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_actualizar_estudiante", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("id_estudiante_up", MySqlDbType.Int32).Value = std.Id_estudiante
            cmd.Parameters.Add("nombres", MySqlDbType.String).Value = std.Nombres
            cmd.Parameters.Add("apellidos", MySqlDbType.String).Value = std.Apellidos
            cmd.Parameters.Add("email", MySqlDbType.String).Value = std.Email
            cmd.Parameters.Add("password", MySqlDbType.String).Value = std.Password

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo actualizar el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try

        Return False
    End Function

    Public Shared Function DeleteStudent(ByVal std As EstudianteModel) As Boolean
        If conn Is Nothing Then
            Return False
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_eliminar_estudiante", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("id_estudiante_del", MySqlDbType.Int32).Value = std.Id_estudiante

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try

        Return False
    End Function

    Public Shared Function LoginStudent(ByVal std As EstudianteModel) As Boolean
        If conn Is Nothing Then
            Return False
        End If

        Try
            conn.Open()

            cmd = New MySqlCommand("sp_login_estudiante", conn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("email_get", MySqlDbType.String).Value = std.Email
            cmd.Parameters.Add("password_get", MySqlDbType.String).Value = std.Password

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conn.Close()
        End Try

        Return False
    End Function
End Class
