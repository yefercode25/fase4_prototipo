﻿Public Class RealidadAumentadaView
    Dim numberView As Integer = 1

    Dim meaningControl As New CreateControl()
    Dim applicationsControl As New ApplicationsControl()

    Private Sub RealidadAumentadaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlComponents.Controls.Add(meaningControl)
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
        ElseIf numberView = 3 Then
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
        End If
    End Sub

    Private Sub ClearAudio()
        applicationsControl.StopAudio()
    End Sub
End Class