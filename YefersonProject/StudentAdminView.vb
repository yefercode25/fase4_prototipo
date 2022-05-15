Public Class StudentAdminView
    Private Sub UserAdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tableData = New DataTable()
        tableData = EstudianteController.GetAllStudents()

        If (tableData.Rows.Count = 0) Then
            MessageBox.Show("No hay estudiantes registrados en el programa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        TableUsers.DataSource = tableData
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Hide()
        Me.Dispose()
        InitMenuView.Show()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If TableUsers.SelectedRows.Count > 0 Then
            Dim student As EstudianteModel = New EstudianteModel With {
                .Id_estudiante = TableUsers.SelectedRows(0).Cells(0).Value,
                .Nombres = TableUsers.SelectedRows(0).Cells(1).Value,
                .Apellidos = TableUsers.SelectedRows(0).Cells(2).Value,
                .Email = TableUsers.SelectedRows(0).Cells(3).Value,
                .Password = TableUsers.SelectedRows(0).Cells(4).Value
            }

            StudentForm.InitForm(student)

            TableUsers.DataSource = EstudianteController.GetAllStudents()
        Else
            MessageBox.Show("Seleccione el estudiante que desea actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If TableUsers.SelectedRows.Count > 0 Then
            If MessageBox.Show("¿Está seguro que desea eliminar el estudiante?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim student As EstudianteModel = New EstudianteModel With {
                    .Id_estudiante = TableUsers.SelectedRows(0).Cells(0).Value
                }

                If EstudianteController.DeleteStudent(student) Then
                    MessageBox.Show("Estudiante eliminado correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TableUsers.DataSource = EstudianteController.GetAllStudents()
                Else
                    MessageBox.Show("Error al eliminar el estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Seleccione el estudiante que desea eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        StudentForm.InitForm()
        TableUsers.DataSource = EstudianteController.GetAllStudents()
    End Sub
End Class
