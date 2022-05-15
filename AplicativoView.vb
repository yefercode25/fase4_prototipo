Public Class AplicativoView
    Private Sub BtnMineria_Click(sender As Object, e As EventArgs) Handles BtnMineria.Click
        Me.Hide()
        OptionsMenuView.Show()
    End Sub

    Private Sub BtnRealidad_Click(sender As Object, e As EventArgs) Handles BtnRealidad.Click
        Me.Hide()
        RealidadAumentadaView.Show()
    End Sub

    Private Sub BtnCondicional_Click(sender As Object, e As EventArgs) Handles BtnCondicional.Click
        MessageBox.Show("No hay archivos aún, proximamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
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