Public Class Como_funciona___tipos_de_modelado
    Private Sub Como_funciona___tipos_de_modelado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles Btncerrar.Click
        Me.Close()
    End Sub
End Class