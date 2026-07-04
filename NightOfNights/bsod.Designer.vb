<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bsod
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub New()
        InitializeComponent()
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblText = New Label()
        Timer1 = New System.Windows.Forms.Timer()
        Timer1.Interval = 500
        Timer1.Enabled = True
        SuspendLayout()
        ' 
        ' lblText
        ' 
        lblText.BackColor = Color.Transparent
        lblText.Cursor = Cursors.No
        lblText.FlatStyle = FlatStyle.System
        lblText.Font = New Font("Consolas", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblText.ForeColor = Color.White
        lblText.Location = New Point(1, 0)
        lblText.Name = "lblText"
        lblText.Size = New Size(799, 452)
        lblText.TabIndex = 0
        ' 
        ' bsod
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblText)
        Name = "bsod"
        Text = "bsod"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblText As Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
