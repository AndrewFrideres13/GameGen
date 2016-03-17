<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWelcome.Location = New System.Drawing.Point(2, 14)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(499, 52)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "       Welcome to the Random Game Generator!  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click below to get started and th" &
    "anks for using me!"
        '
        'btnStart
        '
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStart.Location = New System.Drawing.Point(180, 132)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStart.Size = New System.Drawing.Size(138, 78)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Load Game Generator"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 244)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblWelcome)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "Startup"
        Me.Text = "Startup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnStart As Button
End Class
