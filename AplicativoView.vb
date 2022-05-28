Public Class AplicativoView
    'Manejo de estado del tema de minería de datos
    Dim mineriaDeDatosForm As New OptionsMenuView()
    Dim mineriaDeDatosIsValid As Boolean = False

    'Manejo de estado del tema de realidad aumentada
    Dim realidadAumentadaForm As New RealidadAumentadaView()
    Dim realidadAumentadaIsValid As Boolean = False

    Private Sub BtnMineria_Click(sender As Object, e As EventArgs) Handles BtnMineria.Click
        If mineriaDeDatosIsValid Then
            If MessageBox.Show("Ya completaste este tema, ¿deseas verlo de nuevo?", "Repetir Tema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                mineriaDeDatosForm.ShowDialog()

                mineriaDeDatosIsValid = mineriaDeDatosForm.continueNextTheme
            End If
        Else
            mineriaDeDatosForm.ShowDialog()

            mineriaDeDatosIsValid = mineriaDeDatosForm.continueNextTheme
        End If
    End Sub

    Private Sub BtnRealidad_Click(sender As Object, e As EventArgs) Handles BtnRealidad.Click
        If mineriaDeDatosIsValid Then
            If realidadAumentadaIsValid Then
                If MessageBox.Show("Ya completaste este tema, ¿deseas verlo de nuevo?", "Repetir Tema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    realidadAumentadaForm.ShowDialog()

                    realidadAumentadaIsValid = realidadAumentadaForm.continueNextTheme
                End If
            Else
                realidadAumentadaForm.ShowDialog()

                realidadAumentadaIsValid = realidadAumentadaForm.continueNextTheme
            End If
        Else
            MessageBox.Show("No has completado el tema anterior, por favor revisa para acceder a este recurso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCondicional_Click(sender As Object, e As EventArgs) Handles BtnCondicional.Click
        If realidadAumentadaIsValid Then
            MessageBox.Show("No hay archivos aún, proximamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No has completado el tema anterior, por favor revisa para acceder a este recurso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class