Public Class RealidadAumentadaView
    Dim numberView As Integer = 1

    Dim meaningControl As New CreateControl()
    Dim applicationsControl As New ApplicationsControl()

    Private Sub RealidadAumentadaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlComponents.Controls.Add(meaningControl)
        SetStateButtons()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        numberView -= 1
        SetViewControl()
        SetStateButtons()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        numberView += 1
        SetViewControl()
        SetStateButtons()
    End Sub

    Private Sub SetStateButtons()
        If numberView = 1 Then
            BtnPreview.Enabled = False
            BtnNext.Enabled = True
        ElseIf numberView = 4 Then
            BtnPreview.Enabled = True
            BtnNext.Enabled = False
        Else
            BtnPreview.Enabled = True
            BtnNext.Enabled = True
        End If
    End Sub

    Private Sub SetViewControl()
        If numberView = 1 Then
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(meaningControl)
            ClearAudio()
        ElseIf numberView = 2 Then
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(applicationsControl)
            ClearAudio()
        ElseIf numberView = 3 Then
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(New WhoCreateControl())
            ClearAudio()
        ElseIf numberView = 4 Then
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(New CovidInfluenceControl())
            ClearAudio()
        End If
    End Sub

    Private Sub ClearAudio()
        applicationsControl.StopAudio()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        If MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Me.Dispose()
            LoginView.Show()
        End If
    End Sub
End Class