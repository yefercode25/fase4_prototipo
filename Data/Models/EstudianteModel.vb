Public Class EstudianteModel
    Private _id_estudiante As Integer
    Private _nombres As String
    Private _apellidos As String
    Private _email As String
    Private _password As String

    Public Property Id_estudiante As Integer
        Get
            Return _id_estudiante
        End Get
        Set(value As Integer)
            _id_estudiante = value
        End Set
    End Property

    Public Property Nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
End Class
