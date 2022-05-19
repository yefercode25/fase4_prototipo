Public Class ExamView
    'Variables de apoyo para el manejo del estado del formulario
    Private TimeForm As Integer = 180
    Private questionNumber As Integer = 1
    Public correctAnswersNumber As Integer = 0
    Private revisionMode As Boolean = False
    Private answersUser As SortedDictionary(Of Integer, String) = New SortedDictionary(Of Integer, String)

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Ejercicio13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitFormQuestions()
        ControlTime.Start()
    End Sub

    Private Function InitFormQuestions()
        questionNumber = 1
        SetQuestionInDisplay(GetTitleQuestion(questionNumber), GetOptionsQuestion(questionNumber))
    End Function

    Private Function GetTitleQuestion(num As Integer) As String
        Dim titleQuestion As ArrayList = New ArrayList()
        titleQuestion.Add("1. ¿Qué es la Realidad Aumentada?") '1
        titleQuestion.Add("2. Algunos de los usos de la Realidad Aumentada son:") '2
        titleQuestion.Add("3. ¿Qué elementos se necesitan para trabajar RA?") '3
        titleQuestion.Add("4. ¿Por qué aumentó el uso de la Realidad Aumentada en pandemia?") '4
        titleQuestion.Add("5. La realidad aumentada se usa en el sector de automóviles por:") '5

        Return titleQuestion.Item(num - 1)
    End Function

    Private Function GetOptionsQuestion(num As Integer) As SortedDictionary(Of String, String)
        Dim optionsQuestion = New ArrayList()

        'Opciones de la pregunta 1
        Dim questionOptions = New SortedDictionary(Of String, String) From {
            {"A", "Es el nuevo nivel de la realidad, con ayuda tecnológica."},
            {"B", "Es una tecnología que permite superponer elementos virtuales sobre nuestra visión de la realidad."}, 'Is
            {"C", "Es la combinación de imágenes 2D superpuestas a la realidad."},
            {"D", "Es una tecnología de video creada hace años."}
        }
        optionsQuestion.Add(questionOptions)

        'Opciones de la pregunta 2
        questionOptions = New SortedDictionary(Of String, String) From {
            {"A", "La medicina y la educación."},
            {"B", "Desarrollo de juegos, simulaciones y marketing."},
            {"C", "Todas las opciones son válidas."}, 'Is
            {"D", "Creación de programas profesionales y hologramas."}
        }
        optionsQuestion.Add(questionOptions)

        'Opciones de la pregunta 3
        questionOptions = New SortedDictionary(Of String, String) From {
            {"A", "Video, imágen, sonidos."},
            {"B", "Celular con cámara, fotografías, texto."},
            {"C", "Fotografías, computador, imágenes 3D."},
            {"D", "Dispositivo con cámara, software, código."} 'Is
        }
        optionsQuestion.Add(questionOptions)

        'Opciones de la pregunta 4
        questionOptions = New SortedDictionary(Of String, String) From {
            {"A", "Por su capacidad para reducir el tiempo de capacitación y permitir la asistencia remota."}, 'Is
            {"B", "Por el encierro que provocó la pandemia."},
            {"C", "Por que facilita la creación de presentaciones académicas."},
            {"D", "Por el potencial que representa esta área."}
        }
        optionsQuestion.Add(questionOptions)

        'Opciones de la pregunta 5
        questionOptions = New SortedDictionary(Of String, String) From {
            {"A", "La creación de simulaciones ante posibles fallas."},
            {"B", "El desarrollo de flujos de trabajo que permiten optimizar el trabajo."},
            {"C", "Todas las opciones son válidas."}, 'Is
            {"D", "La visualización y virtualización de modelos 3D en tiempo real."}
        }
        optionsQuestion.Add(questionOptions)

        Return optionsQuestion.Item(num - 1)
    End Function

    Private Function GetCorrectAnswers() As SortedDictionary(Of Integer, String)
        Return New SortedDictionary(Of Integer, String) From {
            {1, "Es una tecnología que permite superponer elementos virtuales sobre nuestra visión de la realidad."},
            {2, "Todas las opciones son válidas."},
            {3, "Dispositivo con cámara, software, código."},
            {4, "Por su capacidad para reducir el tiempo de capacitación y permitir la asistencia remota."},
            {5, "Todas las opciones son válidas."}
        }
    End Function

    Private Function SetQuestionInDisplay(title As String, options As SortedDictionary(Of String, String))
        LblTitle.Text = title

        RadOptionA.Text = options.Item("A")
        RadOptionB.Text = options.Item("B")
        RadOptionC.Text = options.Item("C")
        RadOptionD.Text = options.Item("D")

        ClearRadChecked()
        ValidateIfIsValidPrev()
        ValidateIfIsValidNext()
        SetCheckOptionIdExist()

        If revisionMode Then
            SetCorrectResponse()
        End If
    End Function

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If Not revisionMode Then
            SetAnswerUser()
        End If

        questionNumber += 1
        SetQuestionInDisplay(GetTitleQuestion(questionNumber), GetOptionsQuestion(questionNumber))
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles BtnPrev.Click
        If Not revisionMode Then
            SetAnswerUser()
        End If

        questionNumber -= 1
        SetQuestionInDisplay(GetTitleQuestion(questionNumber), GetOptionsQuestion(questionNumber))
    End Sub

    Private Function ValidateIfIsValidPrev()
        If questionNumber = 1 Then
            BtnPrev.Cursor = Cursors.No
            BtnPrev.Enabled = False
        Else
            BtnPrev.Cursor = Cursors.Hand
            BtnPrev.Enabled = True
        End If
    End Function

    Private Function ValidateIfIsValidNext()
        If questionNumber = 5 Then
            BtnNext.Enabled = False
            BtnNext.Cursor = Cursors.No
        Else
            BtnNext.Enabled = True
            BtnNext.Cursor = Cursors.Hand
        End If
    End Function

    Private Function SetAnswerUser()
        If answersUser.ContainsKey(questionNumber) Then
            answersUser.Remove(questionNumber)
        End If

        If RadOptionA.Checked Then
            answersUser.Add(questionNumber, RadOptionA.Text)
        ElseIf RadOptionB.Checked Then
            answersUser.Add(questionNumber, RadOptionB.Text)
        ElseIf RadOptionC.Checked Then
            answersUser.Add(questionNumber, RadOptionC.Text)
        ElseIf RadOptionD.Checked Then
            answersUser.Add(questionNumber, RadOptionD.Text)
        End If
    End Function

    Private Function SetCheckOptionIdExist()
        If answersUser.ContainsKey(questionNumber) Then
            If RadOptionA.Text = answersUser.Item(questionNumber) Then
                RadOptionA.Checked = True
            ElseIf RadOptionB.Text = answersUser.Item(questionNumber) Then
                RadOptionB.Checked = True
            ElseIf RadOptionC.Text = answersUser.Item(questionNumber) Then
                RadOptionC.Checked = True
            ElseIf RadOptionD.Text = answersUser.Item(questionNumber) Then
                RadOptionD.Checked = True
            End If
        End If
    End Function

    Private Function ClearRadChecked()
        RadOptionA.Checked = False
        RadOptionB.Checked = False
        RadOptionC.Checked = False
        RadOptionD.Checked = False
    End Function

    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click
        SetAnswerUser()
        Dim numAns As Integer = answersUser.Count
        If numAns = 5 Then
            If MessageBox.Show("¿Está seguro que desea finalizar el cuestionario?", "confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                ControlTime.Stop()
                BtnFinish.Enabled = False
                revisionMode = True
                questionNumber = 1
                SetQuestionInDisplay(GetTitleQuestion(questionNumber), GetOptionsQuestion(questionNumber))
                SetCorrectAnsuers()
            End If
        Else
            MessageBox.Show("Por favor responde todas las preguntas, has respondido " + numAns.ToString() + " preguntas.", "Error Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function SetCorrectAnsuers()
        Dim correctAnswers = GetCorrectAnswers()
        For index = 1 To answersUser.Count
            If correctAnswers.Item(index) = answersUser.Item(index) Then
                correctAnswersNumber += 1
            End If
        Next

        Label13.Visible = True
        LblResult.Text = correctAnswersNumber.ToString() + "/5 Preguntas correctas"
        LblResult.Visible = True
        BtnResetForm.Visible = True
        BtnEndRevision.Visible = True
    End Function

    Private Function SetCorrectResponse()
        Dim validAnswers = GetCorrectAnswers()

        Try
            If answersUser.Item(questionNumber) = validAnswers.Item(questionNumber) Then
                If RadOptionA.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionA.Text += " (Correcto, buen trabajo)"
                    RadOptionA.ForeColor = Color.Lime
                ElseIf RadOptionB.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionB.Text += " (Correcto, buen trabajo)"
                    RadOptionB.ForeColor = Color.Lime
                ElseIf RadOptionC.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionC.Text += " (Correcto, buen trabajo)"
                    RadOptionC.ForeColor = Color.Lime
                ElseIf RadOptionD.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionD.Text += " (Correcto, buen trabajo)"
                    RadOptionD.ForeColor = Color.Lime
                Else
                    ResetForeColor()
                End If
            Else
                If RadOptionA.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionA.Text += " (Respuesta correcta)"
                    RadOptionA.ForeColor = Color.Lime
                ElseIf RadOptionB.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionB.Text += " (Respuesta correcta)"
                    RadOptionB.ForeColor = Color.Lime
                ElseIf RadOptionC.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionC.Text += " (Respuesta correcta)"
                    RadOptionC.ForeColor = Color.Lime
                ElseIf RadOptionD.Text = validAnswers.Item(questionNumber) Then
                    ResetForeColor()
                    RadOptionD.Text += " (Respuesta correcta)"
                    RadOptionD.ForeColor = Color.Lime
                End If

                If RadOptionA.Text = answersUser.Item(questionNumber) Then
                    RadOptionA.Text += " (Tú respuesta)"
                    RadOptionA.ForeColor = Color.Crimson
                ElseIf RadOptionB.Text = answersUser.Item(questionNumber) Then
                    RadOptionB.Text += " (Tú respuesta)"
                    RadOptionB.ForeColor = Color.Crimson
                ElseIf RadOptionC.Text = answersUser.Item(questionNumber) Then
                    RadOptionC.Text += " (Tú respuesta)"
                    RadOptionC.ForeColor = Color.Crimson
                ElseIf RadOptionD.Text = answersUser.Item(questionNumber) Then
                    RadOptionD.Text += " (Tú respuesta)"
                    RadOptionD.ForeColor = Color.Crimson
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al ver la revisión de la pregunta " + questionNumber.ToString() + ", no la respondiste.", "Error Revisión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function ResetForeColor()
        RadOptionA.ForeColor = Color.Black
        RadOptionB.ForeColor = Color.Black
        RadOptionC.ForeColor = Color.Black
        RadOptionD.ForeColor = Color.Black
    End Function

    Private Sub BtnResetForm_Click(sender As Object, e As EventArgs) Handles BtnResetForm.Click
        If MessageBox.Show("¿Está seguro que desea reiniciar el cuestionario? Esta acción eliminará la puntuación anterior definitivamente.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            revisionMode = False

            answersUser.Clear()
            correctAnswersNumber = 0

            questionNumber = 1
            TimeForm = 180
            SetQuestionInDisplay(GetTitleQuestion(questionNumber), GetOptionsQuestion(questionNumber))

            Label13.Visible = False
            LblResult.Visible = False
            BtnResetForm.Visible = False
            BtnEndRevision.Visible = False
            BtnFinish.Enabled = True

            ResetForeColor()
            ControlTime.Start()
        End If
    End Sub

    Private Sub ControlTime_Tick(sender As Object, e As EventArgs) Handles ControlTime.Tick
        TimeForm -= 1
        LblTime.Text = TimeForm.ToString() + " segundos"
        If TimeForm = 0 Then
            ControlTime.Stop()
            MessageBox.Show("El tiempo ha finalizado, debido a esto se le evaluará con 0 puntos.", "Tiempo Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Me.Hide()
            Me.Dispose()
        End If
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        If MessageBox.Show("¿Está seguro que desea salir del cuestionario? Todo el avance se perderá", "confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Hide()
            Me.Dispose()
            RealidadAumentadaView.Show()
        End If
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnEndRevision_Click(sender As Object, e As EventArgs) Handles BtnEndRevision.Click
        Me.Hide()
        Me.Dispose()
        RealidadAumentadaView.Show()
    End Sub
End Class