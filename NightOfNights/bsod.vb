Public Class bsod
    Private Sub bsod_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.TopMost = True
        Me.BackColor = Color.RoyalBlue
        Me.KeyPreview = True
    End Sub

    Private Sub bsod_keyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            MessageBox.Show("cop out.")
            Application.Exit()
        End If
    End Sub
End Class