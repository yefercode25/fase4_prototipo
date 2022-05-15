Public Class En_que_se_utiliza
    Private Sub En_que_se_utiliza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles Btncerrar.Click
        Me.Close()
    End Sub
End Class