Public Class Examen_Data_Mining

    Public correct As Integer
    Dim incorrect As Integer
    Dim minutos As Integer
    Dim segundos As Integer

    Private Sub Btnminimizar_Click(sender As Object, e As EventArgs) Handles Btnminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btncerrar_Click(sender As Object, e As EventArgs) Handles Btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Btniniciar_Click(sender As Object, e As EventArgs) Handles Btniniciar.Click
        correct = 0
        incorrect = 0
        segundos = 0
        minutos = 0
        lblcorrect.Text = "0"
        lblincorrect.Text = "0"
        tmr_lim.Enabled = True
        Panel1.Enabled = True
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        If Rbtnop3pgt1.Checked = True Then
            correct = correct + 1
            lblcorrect.Text = correct
        Else
            incorrect = incorrect + 1
            lblincorrect.Text = incorrect
            lblcorrectas.Show()
        End If

        If GroupBox2.Enabled = True Then
            If Rbtnop1pgt2.Checked = True Then
                correct = correct + 1
                lblcorrect.Text = correct
            Else
                incorrect = incorrect + 1
                lblincorrect.Text = incorrect
                lblcorrectas.Show()
            End If
        End If

        If GroupBox3.Enabled = True Then
            If Rbtnop2pgt3.Checked = True Then
                correct = correct + 1
                lblcorrect.Text = correct
            Else
                incorrect = incorrect + 1
                lblincorrect.Text = incorrect
                lblcorrectas.Show()
            End If
        End If

        If GroupBox4.Enabled = True Then
            If Rbtnop1pgt4.Checked = True Then
                correct = correct + 1
                lblcorrect.Text = correct
            Else
                incorrect = incorrect + 1
                lblincorrect.Text = incorrect
                lblcorrectas.Show()
            End If
        End If

        If GroupBox5.Enabled = True Then
            If Rbtnop2pgt5.Checked = True Then
                correct = correct + 1
                lblcorrect.Text = correct
            Else
                incorrect = incorrect + 1
                lblincorrect.Text = incorrect
                lblcorrectas.Show()
            End If
        End If
        tmr_lim.Stop()

    End Sub

    Private Sub tmr_lim_Tick(sender As Object, e As EventArgs) Handles tmr_lim.Tick
        segundos = segundos + 1
        lblseg.Text = segundos

        If segundos = 60 Then
            segundos = 0
            minutos = minutos + 1
            lblmin.Text = minutos
        End If

        If minutos = 2 Then
            lblseg.Text = 0
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox5.Enabled = False
            tmr_lim.Stop()
            Btnguardar.Enabled = False
            MsgBox("No terminaste de responder las preguntas en el tiempo establecido, debes volver a iniciar el quiz. Mucha suerte")
            Btniniciar.Enabled = True
        End If
    End Sub

End Class