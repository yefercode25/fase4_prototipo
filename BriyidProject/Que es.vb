Public Class Que_es
    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles Btncerrar.Click
        AxWindowsMediaPlayer1.close()
        Me.Close()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "Videos\Mineria de datos_480p.mp4"
    End Sub
End Class