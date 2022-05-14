Public Class LoginView
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        Me.Dispose()
        InitMenuView.Show()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LblCreateUser_Click(sender As Object, e As EventArgs) Handles LblCreateUser.Click
        StudentForm.InitForm()
    End Sub

    Private Sub BtnLoginAction_Click(sender As Object, e As EventArgs) Handles BtnLoginAction.Click
        If ValidateFields() Then
            Dim student As New EstudianteModel With {
                .Email = TxtEmail.Text,
                .Password = TxtPass.Text
            }

            If EstudianteController.LoginStudent(student) Then
                Me.Close()
                Me.Dispose()
                RealidadAumentadaView.Show()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        If TxtEmail.Text.Trim() = "" Then
            MessageBox.Show("Por favor ingrese su correo electrónico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf TxtPass.Text.Trim() = "" Then
            MessageBox.Show("Por favor ingrese su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub LblNotCredentials_Click(sender As Object, e As EventArgs) Handles LblNotCredentials.Click
        Me.Hide()
        Me.Dispose()
        RealidadAumentadaView.Show()
    End Sub
End Class