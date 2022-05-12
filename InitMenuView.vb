Public Class InitMenuView
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnAdminStudents_Click(sender As Object, e As EventArgs) Handles BtnAdminStudents.Click
        Me.Hide()
        StudentAdminView.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Me.Hide()
        LoginView.Show()
    End Sub
End Class