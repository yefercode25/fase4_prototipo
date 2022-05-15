Public Class OptionsMenuView
    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles Btncerrar.Click
        Me.Close()
        AplicativoView.Show()
    End Sub

    Private Sub BtnQueEs_Click(sender As Object, e As EventArgs) Handles BtnQueEs.Click
        Que_es.ShowDialog()
    End Sub

    Private Sub BtnComoFunciona_Click(sender As Object, e As EventArgs) Handles BtnComoFunciona.Click
        Como_funciona___tipos_de_modelado.ShowDialog()
    End Sub

    Private Sub BtnEnQueUtiliza_Click(sender As Object, e As EventArgs) Handles BtnEnQueUtiliza.Click
        En_que_se_utiliza.ShowDialog()
    End Sub

    Private Sub BtnExamen_Click(sender As Object, e As EventArgs) Handles BtnExamen.Click
        Examen_Data_Mining.ShowDialog()
    End Sub
End Class