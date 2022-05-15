Public Class StudentForm
    Private action As String = ""
    Private idUpdate As Integer = 0

    Public Sub InitForm()
        action = "CREATE"
        InitComponentsByAction()
    End Sub

    Public Sub InitForm(student As EstudianteModel)
        action = "UPDATE"

        'Fill the fields
        idUpdate = student.Id_estudiante
        TxtName.Text = student.Nombres
        TxtSubname.Text = student.Apellidos
        TxtEmail.Text = student.Email
        TxtPassword.Text = student.Password

        InitComponentsByAction()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
        Me.Dispose()
    End Sub

    'Initialize Methods
    Private Sub InitComponentsByAction()
        If action = "CREATE" Then
            LblTitle.Text = "Añadir estudiante"
            BtnAction.Text = "Agregar"
            BtnAction.BackColor = Color.Lime
        ElseIf action = "UPDATE" Then
            LblTitle.Text = "Actualizar estudiante"
            BtnAction.Text = "Actualizar"
            BtnAction.BackColor = Color.DodgerBlue
        End If

        Me.ShowDialog()
    End Sub

    Private Sub BtnAction_Click(sender As Object, e As EventArgs) Handles BtnAction.Click
        If ValidateFields() Then
            If action = "CREATE" Then
                CreateStudent()
            ElseIf action = "UPDATE" Then
                UpdateStudent()
            End If
        Else
            MessageBox.Show("Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UpdateStudent()
        Dim student As EstudianteModel = New EstudianteModel With {
            .Id_estudiante = idUpdate,
            .Nombres = TxtName.Text.Trim(),
            .Apellidos = TxtSubname.Text.Trim(),
            .Email = TxtEmail.Text.Trim(),
            .Password = TxtPassword.Text.Trim()
        }

        If EstudianteController.UpdateStudent(student) Then
            MessageBox.Show("Estudiante actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Me.Dispose()
        Else
            MessageBox.Show("Error al actualizar estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CreateStudent()
        Dim student As EstudianteModel = New EstudianteModel With {
            .Nombres = TxtName.Text.Trim(),
            .Apellidos = TxtSubname.Text.Trim(),
            .Email = TxtEmail.Text.Trim(),
            .Password = TxtPassword.Text.Trim()
        }

        If EstudianteController.InsertStudent(student) Then
            MessageBox.Show("Estudiante agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Me.Dispose()
        Else
            MessageBox.Show("Error al agregar estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        If TxtName.Text.Trim() = "" Or TxtSubname.Text.Trim() = "" Or TxtEmail.Text.Trim() = "" Or TxtPassword.Text.Trim() = "" Then
            Return False
        End If

        Return True
    End Function
End Class