Public Class RealidadAumentadaView
    Dim numberView As Integer = 1

    Dim meaningControl As New CreateControl()
    Dim applicationsControl As New ApplicationsControl()

    Dim examView As New ExamView()

    Dim isValidViewMeaning As Boolean = False
    Dim isValidViewApplications As Boolean = False
    Dim isValidViewWhoCreate As Boolean = False
    Dim isValidViewCovid As Boolean = False

    Public correctPointsExam = 0
    Public continueNextTheme = False

    Private Sub RealidadAumentadaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlComponents.Controls.Add(meaningControl)
        isValidViewMeaning = True
        SetStateButtons()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
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
            isValidViewMeaning = True
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(meaningControl)
            ClearAudio()
        ElseIf numberView = 2 Then
            isValidViewApplications = True
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(applicationsControl)
            ClearAudio()
        ElseIf numberView = 3 Then
            isValidViewWhoCreate = True
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(New WhoCreateControl())
            ClearAudio()
        ElseIf numberView = 4 Then
            isValidViewCovid = True
            PnlComponents.Controls.Clear()
            PnlComponents.Controls.Add(New CovidInfluenceControl())
            ClearAudio()
        End If
    End Sub

    Private Sub ClearAudio()
        applicationsControl.StopAudio()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        If MessageBox.Show("¿Está seguro que desea regresar?", "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            AplicativoView.Show()
        End If
    End Sub

    Private Sub BtnExam_Click(sender As Object, e As EventArgs) Handles BtnExam.Click
        If isValidViewApplications And isValidViewCovid And isValidViewMeaning And isValidViewWhoCreate Then
            If MessageBox.Show("¿Está seguro que desea iniciar el examen? Para realizarlo tiene un máximo de 3 minutos y empezará a contar el tiempo una vez acepte iniciar.", "Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                examView = New ExamView()

                If correctPointsExam >= 3 Then
                    Dim repeatExam = MessageBox.Show("¿Desea repetir el examen?, su puntuación se perderá definitivamente", "Repetir examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If repeatExam = DialogResult.Yes Then
                        examView.ShowDialog()
                    End If
                Else
                    examView.ShowDialog()
                End If

                correctPointsExam = examView.correctAnswersNumber

                ValidateStatusExam()
            End If
        Else
            MessageBox.Show("Debe ver todos los temas antes de realizar el examen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ValidateStatusExam()
        If correctPointsExam >= 3 Then
            LblStatusTheme.Text = "Aprobado"
            MessageBox.Show("Felicidades, ha aprobado el tema", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show("A continuación se redireccionará a la pantalla de temas, ya puede seleccionar el siguiente tema", "Redirección", MessageBoxButtons.OK, MessageBoxIcon.Information)

            continueNextTheme = True

            Me.Close()
        Else
            LblStatusTheme.Text = "Reprobado"
            MessageBox.Show($"Su puntuación es de {correctPointsExam}/5 puntos, por lo que no puede continuar con el siguiente tema y debe revisar todo el tema nuevamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            numberView = 1
            SetStateButtons()
            SetViewControl()

            isValidViewApplications = False
            isValidViewCovid = False
            isValidViewWhoCreate = False
        End If
    End Sub
End Class