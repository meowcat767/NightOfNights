Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim result = MessageBox.Show(
                "Warning!" & vbCrLf & vbCrLf &
                "This is a harmless joke program. It may open lots of browser windows, flash your screen and piss you off." & vbCrLf & vbCrLf &
                "Do you want to continue?",
                "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Abort Or DialogResult.No Then
                e.Cancel = True
            End If

            If result = DialogResult.Yes Then
                Try
                    Dim f As New bsod()
                    f.ShowDialog()
                Catch ex As Exception
                    ' Log and show the error instead of letting the application crash
                    Try
                        Dim logPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "NightOfNights_startup_error.log")
                        Dim text = DateTime.Now.ToString("u") & " - " & ex.ToString() & Environment.NewLine
                        System.IO.File.AppendAllText(logPath, text)
                    Catch
                        ' ignore logging failures
                    End Try

                    MessageBox.Show("Failed to open BSOD window:\n" & ex.Message, "Startup error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

    End Class
End Namespace