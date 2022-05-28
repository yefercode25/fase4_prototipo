Public Class OptionsMenuView
    'Estados de resultados del examen
    Public correctPointsExam = 0
    Public continueNextTheme As Boolean = False

    'Banderas de estado de temas
    Dim isValidQueEs As Boolean = False
    Dim isValidComoFunciona As Boolean = False
    Dim isValidEnQueSeUtiliza As Boolean = False

    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles Btncerrar.Click
        Me.Close()
        AplicativoView.Show()
    End Sub

    Private Sub BtnQueEs_Click(sender As Object, e As EventArgs) Handles BtnQueEs.Click
        Que_es.ShowDialog()
        isValidQueEs = True
    End Sub

    Private Sub BtnComoFunciona_Click(sender As Object, e As EventArgs) Handles BtnComoFunciona.Click
        Como_funciona___tipos_de_modelado.ShowDialog()
        isValidComoFunciona = True
    End Sub

    Private Sub BtnEnQueUtiliza_Click(sender As Object, e As EventArgs) Handles BtnEnQueUtiliza.Click
        En_que_se_utiliza.ShowDialog()
        isValidEnQueSeUtiliza = True
    End Sub

    Private Sub BtnExamen_Click(sender As Object, e As EventArgs) Handles BtnExamen.Click
        If isValidComoFunciona And isValidEnQueSeUtiliza And isValidQueEs Then
            If MessageBox.Show("¿Está seguro que desea iniciar el examen? Para realizarlo tiene un máximo de 3 minutos y empezará a contar el tiempo una vez acepte iniciar.", "Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim ExamenMineria = New Examen_Data_Mining()

                If correctPointsExam >= 3 Then
                    Dim repeatExam = MessageBox.Show("¿Desea repetir el examen?, su puntuación se perderá definitivamente", "Repetir examen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If repeatExam = DialogResult.Yes Then
                        ExamenMineria.ShowDialog()
                    End If
                Else
                    ExamenMineria.ShowDialog()
                End If

                correctPointsExam = ExamenMineria.correct

                ValidateStatusExam()
            End If
        Else
            MessageBox.Show("No puedes presentar el examen aún, debes ver toda la información del tema antes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ValidateStatusExam()
        If correctPointsExam >= 3 Then
            MessageBox.Show("Felicidades, ha aprobado el tema", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show("A continuación se redireccionará a la pantalla de temas, ya puede seleccionar el siguiente tema", "Redirección", MessageBoxButtons.OK, MessageBoxIcon.Information)

            continueNextTheme = True

            Me.Close()
        Else
            MessageBox.Show($"Su puntuación es de {correctPointsExam}/5 puntos, por lo que no puede continuar con el siguiente tema y debe revisar todo el tema nuevamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            isValidQueEs = False
            isValidComoFunciona = False
            isValidEnQueSeUtiliza = False
        End If
    End Sub
End Class