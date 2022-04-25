Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim std = New EstudianteModel With {
            .Id_estudiante = 2,
            .Nombres = "Yeferson",
            .Apellidos = "Zaque",
            .Email = "zaque@email.com",
            .Password = "12345"
        }

        Console.WriteLine(EstudianteController.DeleteStudent(std))
    End Sub
End Class
