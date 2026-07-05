Public Class bsod
    Private Sub bsod_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.TopMost = True
            ' Use a darker classic BSOD blue
            Me.BackColor = Color.FromArgb(0, 0, 170)
            Me.KeyPreview = True

            ' Reduce flicker by enabling double-buffering and optimized painting
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
            Me.UpdateStyles()

            If lblText IsNot Nothing Then
                lblText.Text =
                    "A problem has been detected and Windows has been shut down to prevent damage to your computer." & vbCrLf &
            End If
        Catch ex As Exception
            LogException(ex)
            MessageBox.Show("Error initializing bsod form:\n" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bsod_keyDown(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            MessageBox.Show("cop out.")
            Application.Exit()
        End If
    End Sub

    Private counter As Integer = 0

    Private Sub Timer1_Tick(Sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If lblText Is Nothing Then
                Return
            End If

            Dim baseText = lblText.Text
            If String.IsNullOrEmpty(baseText) Then
                Return
            End If

            Dim dots As String = New String("."c, (Environment.TickCount \ 500) Mod 4)
            Dim parts = baseText.Split("."c)
            If parts.Length = 0 Then
                lblText.Text = baseText & dots
            Else
                lblText.Text = parts(0) & dots
            End If
        Catch ex As Exception
            LogException(ex)
            ' swallow to avoid crash; show minimal info for debugging
            MessageBox.Show("Timer error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Simple logging helper for runtime exceptions
    Private Sub LogException(ex As Exception)
        Try
            Dim logPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "NightOfNights_bsod_error.log")
            Dim text = DateTime.Now.ToString("u") & " - " & ex.ToString() & Environment.NewLine
            System.IO.File.AppendAllText(logPath, text)
        Catch
            ' ignore logging failures
        End Try
    End Sub

End Class
