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
        End Sub

    End Class
End Namespace