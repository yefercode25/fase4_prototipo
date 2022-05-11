Imports Microsoft.VisualBasic.Devices

Public Class ApplicationsControl
    Dim audio As New Audio
    Dim audioPath As String = Application.StartupPath & "\Pages\assets\realidad-aumentada.wav"

    Private Sub ApplicationsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        audio.Play(audioPath)
        BtnPlay.Enabled = False
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        audio.Stop()
        BtnPlay.Enabled = True
    End Sub

    Public Sub StopAudio()
        audio.Stop()
        BtnPlay.Enabled = True
    End Sub
End Class
